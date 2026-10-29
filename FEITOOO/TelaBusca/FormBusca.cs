using BaurusTour.Componentes;
using BaurusTour.Data;
using BaurusTour.Models;
using BaurusTour.Services;
using BaurusTour.TelaDetalhe;
using BaurusTour.Utilitarios;

namespace BaurusTour.TelaBusca
{
    /// <summary>
    /// Tela principal do app: menu lateral, busca, filtro por categoria e os cards
    /// dos pontos turísticos. O layout está todo no FormBusca.Designer.cs.
    /// </summary>
    public partial class FormBusca : Form
    {
        private enum Aba { Inicio, Favoritos, Sobre }

        private const string CaminhoGuiaPdf = @"Manual\Guia-de-uso-Bauru-Tour.pdf";

        private readonly PontoTuristicoService _servico;
        private readonly FavoritosService _favoritos;
        private readonly string _erroAoCarregar;

        // Um card por ponto turístico, criado uma vez só. A busca apenas mostra/esconde.
        private readonly Dictionary<int, CardPontoTuristico> _cards = new Dictionary<int, CardPontoTuristico>();

        // Fontes do menu lateral (normal e item selecionado)
        private readonly Font _fonteMenu = new Font("Segoe UI", 12F, FontStyle.Regular);
        private readonly Font _fonteMenuAtivo = new Font("Segoe UI", 12F, FontStyle.Bold);

        private string _categoriaSelecionada = PontoTuristicoService.TodasAsCategorias;
        private Aba _abaAtual = Aba.Inicio;

        public FormBusca()
        {
            InitializeComponent();

            var repositorio = new PontoTuristicoRepository(Path.Combine(AppContext.BaseDirectory, "pontos.json"));
            _servico = new PontoTuristicoService(repositorio);
            _erroAoCarregar = repositorio.UltimoErro;

            _favoritos = new FavoritosService();
            _favoritos.FavoritosAlterados += Favoritos_FavoritosAlterados;
        }

        // ------------------------------------------------------------------ carregamento

        private void FormBusca_Load(object? sender, EventArgs e)
        {
            Icon = CarregadorImagens.IconeDoApp ?? Icon;
            picLogo.Image = CarregadorImagens.Logo;
            picIlustracaoMenu.Image = CarregadorImagens.IlustracaoMenu;
            pnlCabecalho.ImagemDireita = CarregadorImagens.Banner;

            CriarCards();
            AtualizarChips();
            AtualizarMenuFavoritos();
            MostrarAba(Aba.Inicio);

            ActiveControl = txtBusca;

            if (_erroAoCarregar.Length > 0)
            {
                MessageBox.Show(this, _erroAoCarregar, "Bauru's Tour", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CriarCards()
        {
            flpCards.SuspendLayout();

            foreach (PontoTuristico ponto in _servico.ListarTodos())
            {
                var card = new CardPontoTuristico();
                card.Preencher(ponto, _favoritos.EhFavorito(ponto.Id));
                card.VerDetalhesClicado += Card_VerDetalhesClicado;
                card.FavoritarClicado += Card_FavoritarClicado;
                card.Visible = false;

                _cards[ponto.Id] = card;
                flpCards.Controls.Add(card);
            }

            flpCards.ResumeLayout();
        }

        // ------------------------------------------------------------------ lista de cards

        /// <summary>Aplica busca + categoria + aba (Início/Favoritos) e mostra os cards certos.</summary>
        private void AtualizarLista()
        {
            if (_abaAtual == Aba.Sobre)
                return;

            ICollection<int>? somenteFavoritos = _abaAtual == Aba.Favoritos ? _favoritos.Ids.ToList() : null;
            List<PontoTuristico> resultado = _servico.Pesquisar(txtBusca.Text, _categoriaSelecionada, somenteFavoritos);

            flpCards.SuspendLayout();

            foreach (CardPontoTuristico card in _cards.Values)
                card.Visible = false;

            // O label de "nenhum resultado" fica na posição 0; os cards vêm depois, na ordem da busca
            int posicao = 1;
            foreach (PontoTuristico ponto in resultado)
            {
                if (!_cards.TryGetValue(ponto.Id, out CardPontoTuristico? card))
                    continue;

                flpCards.Controls.SetChildIndex(card, posicao++);
                card.DefinirFavorito(_favoritos.EhFavorito(ponto.Id));
                card.Visible = true;
            }

            lblSemResultados.Visible = resultado.Count == 0;
            lblSemResultados.Text = TextoSemResultados();
            lblQuantidade.Text = resultado.Count == 1 ? "1 lugar" : resultado.Count + " lugares";

            AjustarTamanhoDosCards();
            flpCards.ResumeLayout(true);
            flpCards.AutoScrollPosition = new Point(0, 0);
        }

        private string TextoSemResultados()
        {
            if (_erroAoCarregar.Length > 0)
                return "Não foi possível carregar os pontos turísticos.\r\n" + _erroAoCarregar;

            bool temFiltro = txtBusca.Text.Trim().Length > 0 ||
                             _categoriaSelecionada != PontoTuristicoService.TodasAsCategorias;

            if (_abaAtual == Aba.Favoritos && !temFiltro)
                return "Você ainda não tem favoritos.\r\nClique no coração de um lugar para guardar ele aqui.";

            if (txtBusca.Text.Trim().Length > 0)
                return "Nenhum lugar encontrado para \"" + txtBusca.Text.Trim() + "\".\r\nTente outra palavra ou escolha outra categoria.";

            return "Nenhum lugar nessa categoria.";
        }

        /// <summary>
        /// Divide a largura disponível em colunas (de 1 a 4) para os cards
        /// ocuparem a tela toda, tanto em janela pequena quanto em tela cheia.
        /// </summary>
        private void AjustarTamanhoDosCards()
        {
            int espaco = LogicalToDeviceUnits(24);
            int larguraUtil = flpCards.ClientSize.Width - flpCards.Padding.Horizontal - SystemInformation.VerticalScrollBarWidth;
            if (larguraUtil <= 0)
                return;

            int larguraMinima = LogicalToDeviceUnits(290);
            int colunas = Math.Clamp((larguraUtil + espaco) / (larguraMinima + espaco), 1, 4);
            int largura = larguraUtil / colunas - espaco;

            foreach (CardPontoTuristico card in _cards.Values)
            {
                card.Margin = new Padding(0, 0, espaco, espaco);
                card.Width = largura;
            }

            lblSemResultados.Width = Math.Max(LogicalToDeviceUnits(300), larguraUtil - espaco);
        }

        private void flpCards_Resize(object? sender, EventArgs e)
        {
            if (_cards.Count == 0)
                return;

            flpCards.SuspendLayout();
            AjustarTamanhoDosCards();
            flpCards.ResumeLayout(true);
        }

        // ------------------------------------------------------------------ cards

        private void Card_VerDetalhesClicado(object? sender, EventArgs e)
        {
            if (sender is CardPontoTuristico card && card.Ponto != null)
                AbrirDetalhes(card.Ponto);
        }

        private void Card_FavoritarClicado(object? sender, EventArgs e)
        {
            if (sender is CardPontoTuristico card && card.Ponto != null)
                _favoritos.Alternar(card.Ponto.Id);
        }

        private void AbrirDetalhes(PontoTuristico ponto)
        {
            using (var tela = new FormDetalhe(ponto, _favoritos))
            {
                // Se a busca está em tela cheia, a tela de detalhes abre em tela cheia também
                if (ControleTelaCheia.EstaEmTelaCheia(this))
                    tela.Load += (s, e) => ControleTelaCheia.Entrar(tela);

                tela.ShowDialog(this);
            }
        }

        // Chamado sempre que algum coração é clicado (aqui ou na tela de detalhes)
        private void Favoritos_FavoritosAlterados(object? sender, EventArgs e)
        {
            AtualizarMenuFavoritos();

            if (_abaAtual == Aba.Favoritos)
            {
                AtualizarLista();
                return;
            }

            foreach (CardPontoTuristico card in _cards.Values)
            {
                if (card.Ponto != null)
                    card.DefinirFavorito(_favoritos.EhFavorito(card.Ponto.Id));
            }
        }

        private void AtualizarMenuFavoritos()
        {
            btnMenuFavoritos.Text = _favoritos.Quantidade > 0
                ? "Favoritos (" + _favoritos.Quantidade + ")"
                : "Favoritos";
        }

        // ------------------------------------------------------------------ busca e categorias

        private void btnBuscar_Click(object? sender, EventArgs e)
        {
            if (_abaAtual == Aba.Sobre)
                MostrarAba(Aba.Inicio);
            else
                AtualizarLista();
        }

        // A lista vai filtrando enquanto a pessoa digita
        private void txtBusca_TextChanged(object? sender, EventArgs e)
        {
            if (_abaAtual == Aba.Sobre)
                MostrarAba(Aba.Inicio);
            else
                AtualizarLista();
        }

        private void txtBusca_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // tira o "bip" do Windows
                btnBuscar_Click(sender, EventArgs.Empty);
            }
        }

        // Um único evento para todos os botões de categoria (a categoria fica na propriedade Tag)
        private void Categoria_Click(object? sender, EventArgs e)
        {
            if (sender is BotaoArredondado botao && botao.Tag is string categoria)
            {
                _categoriaSelecionada = categoria;
                AtualizarChips();

                if (_abaAtual == Aba.Sobre)
                    MostrarAba(Aba.Inicio);
                else
                    AtualizarLista();
            }
        }

        private void AtualizarChips()
        {
            foreach (BotaoArredondado chip in flpCategorias.Controls.OfType<BotaoArredondado>())
            {
                bool selecionado = chip.Tag is string categoria && categoria == _categoriaSelecionada;

                chip.CorFundo = selecionado ? Tema.Primaria : Tema.Branco;
                chip.CorFundoHover = selecionado ? Tema.PrimariaEscura : Tema.PrimariaClara;
                chip.CorBorda = selecionado ? Tema.Primaria : Tema.Borda;
                chip.ForeColor = selecionado ? Tema.Branco : Tema.AzulMarinho;
            }
        }

        private void btnVerTodos_Click(object? sender, EventArgs e)
        {
            _categoriaSelecionada = PontoTuristicoService.TodasAsCategorias;
            AtualizarChips();

            _abaAtual = Aba.Inicio;          // evita atualizar a lista duas vezes
            txtBusca.Clear();
            MostrarAba(Aba.Inicio);
        }

        // ------------------------------------------------------------------ menu lateral

        private void btnMenuInicio_Click(object? sender, EventArgs e)
        {
            MostrarAba(Aba.Inicio);
        }

        private void btnMenuMapa_Click(object? sender, EventArgs e)
        {
            string busca = Uri.EscapeDataString("pontos turísticos em Bauru SP");
            AbridorLinks.AbrirLink("https://www.google.com/maps/search/?api=1&query=" + busca, this);
        }

        private void btnMenuFavoritos_Click(object? sender, EventArgs e)
        {
            MostrarAba(Aba.Favoritos);
        }

        private void btnMenuSobre_Click(object? sender, EventArgs e)
        {
            MostrarAba(Aba.Sobre);
        }

        private void btnMenuTelaCheia_Click(object? sender, EventArgs e)
        {
            AlternarTelaCheia();
        }

        private void btnGuiaSobre_Click(object? sender, EventArgs e)
        {
            AbridorLinks.AbrirArquivo(CaminhoGuiaPdf, this);
        }

        private void MostrarAba(Aba aba)
        {
            _abaAtual = aba;

            bool sobre = aba == Aba.Sobre;
            pnlSobre.Visible = sobre;
            pnlTituloSecao.Visible = !sobre;
            flpCards.Visible = !sobre;

            lblTituloSecao.Text = aba == Aba.Favoritos ? "Meus favoritos" : "Explore Bauru";

            DestacarMenu(aba == Aba.Inicio ? btnMenuInicio : aba == Aba.Favoritos ? btnMenuFavoritos : btnMenuSobre);
            AtualizarLista();
        }

        private void DestacarMenu(BotaoArredondado selecionado)
        {
            foreach (BotaoArredondado item in new[] { btnMenuInicio, btnMenuFavoritos, btnMenuSobre })
            {
                bool ativo = item == selecionado;
                item.CorFundo = ativo ? Tema.PrimariaClara : Tema.Branco;
                item.CorFundoHover = ativo ? Tema.PrimariaClara : Color.FromArgb(240, 244, 246);
                item.Font = ativo ? _fonteMenuAtivo : _fonteMenu;
            }
        }

        // ------------------------------------------------------------------ tela cheia e atalhos

        private void AlternarTelaCheia()
        {
            ControleTelaCheia.Alternar(this);
            AtualizarBotaoTelaCheia();
        }

        private void AtualizarBotaoTelaCheia()
        {
            bool emTelaCheia = ControleTelaCheia.EstaEmTelaCheia(this);
            btnMenuTelaCheia.Text = emTelaCheia ? "Sair da tela cheia" : "Tela cheia";
            btnMenuTelaCheia.Icone = emTelaCheia ? Icones.SairTelaCheia : Icones.TelaCheia;
        }

        private void FormBusca_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11)
            {
                AlternarTelaCheia();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Escape && ControleTelaCheia.EstaEmTelaCheia(this))
            {
                AlternarTelaCheia();
                e.Handled = true;
            }
            else if (e.Control && e.KeyCode == Keys.F)
            {
                txtBusca.Focus();
                txtBusca.SelectAll();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
