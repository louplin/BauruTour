using System.Diagnostics;
using BaurusTour.Componentes;
using BaurusTour.Data;
using BaurusTour.Models;
using BaurusTour.Services;
using BaurusTour.TelaDetalhe;

namespace BaurusTour.TelaBusca
{
    /// <summary>
    /// Tela principal: menu lateral, busca, categorias e os cards dos pontos.
    /// Todo o visual está no Designer (FormBusca.Designer.cs).
    /// Aqui fica só o que acontece quando clica nos botões.
    /// </summary>
    public partial class FormBusca : Form
    {
        // Cores usadas para destacar o botão selecionado
        private readonly Color corPrimaria = Color.FromArgb(11, 107, 138);
        private readonly Color corAzulEscuro = Color.FromArgb(13, 43, 94);
        private readonly Color corBorda = Color.FromArgb(220, 226, 230);
        private readonly Color corMenuSelecionado = Color.FromArgb(228, 241, 245);

        private readonly PontoTuristicoService servico;
        private readonly FavoritosService favoritos;

        private string categoriaSelecionada = "Todos";
        private bool mostrandoFavoritos = false;

        public FormBusca()
        {
            InitializeComponent();

            string caminhoJson = Path.Combine(AppContext.BaseDirectory, "pontos.json");
            servico = new PontoTuristicoService(new PontoTuristicoRepository(caminhoJson));
            favoritos = new FavoritosService();
        }

        // ================================================================
        // Ao abrir a tela: cria um card para cada ponto do pontos.json
        // ================================================================
        private void FormBusca_Load(object? sender, EventArgs e)
        {
            foreach (PontoTuristico ponto in servico.ListarTodos())
            {
                var card = new CardPontoTuristico();
                card.MostrarPonto(ponto, favoritos.EhFavorito(ponto.Id));
                card.VerDetalhesClicado += Card_VerDetalhesClicado;
                card.FavoritarClicado += Card_FavoritarClicado;
                flpCards.Controls.Add(card);
            }

            AtualizarLista();
        }

        /// <summary>
        /// Mostra só os cards que combinam com a busca, a categoria
        /// e (se estiver na aba Favoritos) com os favoritos.
        /// </summary>
        private void AtualizarLista()
        {
            List<int>? somenteFavoritos = mostrandoFavoritos ? favoritos.Ids : null;
            List<PontoTuristico> resultado = servico.Pesquisar(txtBusca.Text, categoriaSelecionada, somenteFavoritos);

            foreach (CardPontoTuristico card in flpCards.Controls.OfType<CardPontoTuristico>())
            {
                card.Visible = card.Ponto != null && resultado.Contains(card.Ponto);
                card.MostrarFavorito(card.Ponto != null && favoritos.EhFavorito(card.Ponto.Id));
            }

            lblNenhumResultado.Visible = resultado.Count == 0;
            lblQuantidade.Text = resultado.Count + " lugares";
            btnFavoritos.Text = "Favoritos (" + favoritos.Ids.Count + ")";
        }

        // ================================================================
        // Cards
        // ================================================================
        private void Card_VerDetalhesClicado(object? sender, EventArgs e)
        {
            var card = (CardPontoTuristico)sender!;
            if (card.Ponto == null)
                return;

            using (var telaDetalhe = new FormDetalhe(card.Ponto, favoritos))
            {
                // Se esta tela está em tela cheia, a de detalhes abre em tela cheia também
                if (FormBorderStyle == FormBorderStyle.None)
                    telaDetalhe.FormBorderStyle = FormBorderStyle.None;

                telaDetalhe.ShowDialog(this);
            }

            AtualizarLista(); // o coração pode ter mudado lá dentro
        }

        private void Card_FavoritarClicado(object? sender, EventArgs e)
        {
            var card = (CardPontoTuristico)sender!;
            if (card.Ponto == null)
                return;

            favoritos.Alternar(card.Ponto.Id);
            AtualizarLista();
        }

        // ================================================================
        // Busca e categorias
        // ================================================================
        private void btnBuscar_Click(object? sender, EventArgs e)
        {
            AtualizarLista();
        }

        // A lista vai filtrando enquanto a pessoa digita
        private void txtBusca_TextChanged(object? sender, EventArgs e)
        {
            AtualizarLista();
        }

        // Todos os botões de categoria usam este mesmo clique.
        // A categoria de cada botão está escrita na propriedade Tag (no Designer).
        private void Categoria_Click(object? sender, EventArgs e)
        {
            var botaoClicado = (Button)sender!;
            categoriaSelecionada = botaoClicado.Tag?.ToString() ?? "Todos";

            foreach (Button botao in flpCategorias.Controls.OfType<Button>())
            {
                bool selecionado = botao == botaoClicado;
                botao.BackColor = selecionado ? corPrimaria : Color.White;
                botao.ForeColor = selecionado ? Color.White : corAzulEscuro;
                botao.FlatAppearance.BorderColor = selecionado ? corPrimaria : corBorda;
            }

            AtualizarLista();
        }

        private void btnVerTodos_Click(object? sender, EventArgs e)
        {
            txtBusca.Text = "";
            Categoria_Click(btnCategoriaTodos, EventArgs.Empty);
        }

        // ================================================================
        // Menu lateral
        // ================================================================
        private void btnInicio_Click(object? sender, EventArgs e)
        {
            mostrandoFavoritos = false;
            lblTituloSecao.Text = "Explore Bauru";
            MostrarLista(true);
            DestacarMenu(btnInicio);
        }

        private void btnFavoritos_Click(object? sender, EventArgs e)
        {
            mostrandoFavoritos = true;
            lblTituloSecao.Text = "Meus favoritos";
            MostrarLista(true);
            DestacarMenu(btnFavoritos);
        }

        private void btnSobre_Click(object? sender, EventArgs e)
        {
            MostrarLista(false);
            DestacarMenu(btnSobre);
        }

        private void btnMapa_Click(object? sender, EventArgs e)
        {
            string link = "https://www.google.com/maps/search/pontos+turisticos+Bauru+SP";
            Process.Start(new ProcessStartInfo(link) { UseShellExecute = true });
        }

        private void btnGuia_Click(object? sender, EventArgs e)
        {
            string pdf = Path.Combine(AppContext.BaseDirectory, "Manual", "Guia-de-uso-Bauru-Tour.pdf");
            Process.Start(new ProcessStartInfo(pdf) { UseShellExecute = true });
        }

        /// <summary>true = mostra a lista de cards. false = mostra a aba Sobre.</summary>
        private void MostrarLista(bool mostrar)
        {
            flpCards.Visible = mostrar;
            pnlTituloSecao.Visible = mostrar;
            pnlSobre.Visible = !mostrar;
            AtualizarLista();
        }

        /// <summary>Pinta de azul claro o botão do menu que está aberto.</summary>
        private void DestacarMenu(Button selecionado)
        {
            btnInicio.BackColor = Color.White;
            btnFavoritos.BackColor = Color.White;
            btnSobre.BackColor = Color.White;
            selecionado.BackColor = corMenuSelecionado;
        }

        // ================================================================
        // Tela cheia (botão do menu ou tecla F11)
        // ================================================================
        private void btnTelaCheia_Click(object? sender, EventArgs e)
        {
            AlternarTelaCheia();
        }

        private void AlternarTelaCheia()
        {
            if (FormBorderStyle == FormBorderStyle.None)
            {
                // Volta para janela normal
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Maximized;
                btnTelaCheia.Text = "Tela cheia";
            }
            else
            {
                // Tira a borda e ocupa a tela toda (cobre a barra de tarefas)
                WindowState = FormWindowState.Normal;
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
                btnTelaCheia.Text = "Sair da tela cheia";
            }
        }

        private void FormBusca_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11)
                AlternarTelaCheia();

            if (e.KeyCode == Keys.Escape && FormBorderStyle == FormBorderStyle.None)
                AlternarTelaCheia();
        }
    }
}
