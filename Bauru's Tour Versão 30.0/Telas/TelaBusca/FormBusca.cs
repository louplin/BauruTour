using System.Diagnostics;
using BaurusTour.Classes;
using BaurusTour.Componentes;
using BaurusTour.Modelos;
using BaurusTour.Telas.TelaDetalhe;
using BaurusTour.Telas.TelaCreditos;

namespace BaurusTour.Telas.TelaBusca
{
    public partial class FormBusca : Form
    {
        private Color corPrimaria = Color.FromArgb(11, 107, 138);
        private Color corAzulEscuro = Color.FromArgb(13, 43, 94);
        private Color corBorda = Color.FromArgb(196, 216, 224);
        private Color corMenuSelecionado = Color.FromArgb(206, 228, 236);

        private GerenciadorPontos pontos;
        private GerenciadorFavoritos favoritos;
        private GerenciadorAvaliacoes avaliacoes;

        private Random sorteio = new Random();

        private string categoriaSelecionada = "Todos";
        private bool mostrandoFavoritos = false;

        public FormBusca()
        {
            InitializeComponent();
            DoubleBuffered = true;

            string caminhoJson = Path.Combine(AppContext.BaseDirectory, "Dados", "pontos.json");
            pontos = new GerenciadorPontos(caminhoJson);
            favoritos = new GerenciadorFavoritos();
            avaliacoes = new GerenciadorAvaliacoes();
        }

        private void FormBusca_Load(object? sender, EventArgs e)
        {
            if (pontos.MensagemErro != "")
            {
                MessageBox.Show(pontos.MensagemErro, "Erro ao carregar os pontos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // cria um card pra cada lugar do JSON
            flpCards.SuspendLayout();
            foreach (PontoTuristico ponto in pontos.ListarTodos())
            {
                CardPontoTuristico card = new CardPontoTuristico();
                card.MostrarPonto(ponto, favoritos.EhFavorito(ponto.Id));
                card.VerDetalhesClicado += Card_VerDetalhesClicado;
                card.FavoritarClicado += Card_FavoritarClicado;
                flpCards.Controls.Add(card);
            }
            flpCards.ResumeLayout();

            AtualizarLista();
        }

        private List<PontoTuristico> PesquisarLugares()
        {
            List<int>? somenteFavoritos = null;
            if (mostrandoFavoritos)
                somenteFavoritos = favoritos.Ids;

            return pontos.Pesquisar(txtBusca.Text, categoriaSelecionada, somenteFavoritos);
        }

        private void AtualizarLista()
        {
            List<PontoTuristico> resultado = PesquisarLugares();

            // SuspendLayout pausa a organização da tela enquanto mexe nos cards,
            // senão ela se reorganiza uma vez pra cada card e fica travando
            flpCards.SuspendLayout();
            foreach (Control controle in flpCards.Controls)
            {
                CardPontoTuristico? card = controle as CardPontoTuristico;
                if (card == null)
                    continue;

                PontoTuristico? ponto = card.ObterPonto();
                if (ponto == null)
                    continue;

                card.Visible = resultado.Contains(ponto);
                card.MostrarFavorito(favoritos.EhFavorito(ponto.Id));
            }
            flpCards.ResumeLayout();

            lblNenhumResultado.Visible = resultado.Count == 0;
            lblQuantidade.Text = resultado.Count + " lugares";
            btnFavoritos.Text = "Favoritos (" + favoritos.Ids.Count + ")";
        }

        private void Card_VerDetalhesClicado(object? sender, EventArgs e)
        {
            CardPontoTuristico? card = sender as CardPontoTuristico;
            if (card == null)
                return;

            PontoTuristico? ponto = card.ObterPonto();
            if (ponto != null)
                AbrirDetalhe(ponto);
        }

        private void AbrirDetalhe(PontoTuristico ponto)
        {
            using (FormDetalhe telaDetalhe = new FormDetalhe(ponto, favoritos, pontos, avaliacoes))
            {
                // se a busca está em tela cheia, o detalhe abre em tela cheia também
                if (FormBorderStyle == FormBorderStyle.None)
                    telaDetalhe.FormBorderStyle = FormBorderStyle.None;

                telaDetalhe.ShowDialog(this);
            }

            // atualiza porque a pessoa pode ter favoritado lá dentro
            AtualizarLista();
        }

        private void Card_FavoritarClicado(object? sender, EventArgs e)
        {
            CardPontoTuristico? card = sender as CardPontoTuristico;
            if (card == null)
                return;

            PontoTuristico? ponto = card.ObterPonto();
            if (ponto == null)
                return;

            favoritos.Alternar(ponto.Id);
            AtualizarLista();
        }

        private void btnSurpreenda_Click(object? sender, EventArgs e)
        {
            List<PontoTuristico> resultado = PesquisarLugares();

            if (resultado.Count == 0)
            {
                MessageBox.Show("Não tem nenhum lugar na lista para sortear.", "Me surpreenda",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int posicao = sorteio.Next(resultado.Count);
            AbrirDetalhe(resultado[posicao]);
        }

        private void txtBusca_TextChanged(object? sender, EventArgs e)
        {
            AtualizarLista();
        }

        // Todos os botões de categoria usam esse evento.
        // O nome da categoria está escrito no Tag de cada botão (no Designer).
        private void Categoria_Click(object? sender, EventArgs e)
        {
            Button? botaoClicado = sender as Button;
            if (botaoClicado == null)
                return;

            string? categoria = botaoClicado.Tag as string;
            if (categoria == null)
                categoria = "Todos";

            categoriaSelecionada = categoria;

            // pinta o botão clicado de azul e os outros de branco.
            // O selecionado também ganha um ✓, pra não depender só da cor (acessibilidade).
            foreach (Control controle in flpCategorias.Controls)
            {
                Button? botao = controle as Button;
                if (botao == null)
                    continue;

                string? nome = botao.Tag as string;

                if (botao == botaoClicado)
                {
                    botao.Text = "✓ " + nome;
                    botao.BackColor = corPrimaria;
                    botao.ForeColor = Color.White;
                    botao.FlatAppearance.BorderColor = corPrimaria;
                }
                else
                {
                    botao.Text = nome;
                    botao.BackColor = Color.FromArgb(242, 248, 250);
                    botao.ForeColor = corAzulEscuro;
                    botao.FlatAppearance.BorderColor = corBorda;
                }
            }

            AtualizarLista();
        }

        private void btnInicio_Click(object? sender, EventArgs e)
        {
            mostrandoFavoritos = false;
            lblTituloSecao.Text = "Explore Bauru";
            DestacarMenu(btnInicio);
            AtualizarLista();
        }

        private void btnFavoritos_Click(object? sender, EventArgs e)
        {
            mostrandoFavoritos = true;
            lblTituloSecao.Text = "Meus favoritos";
            DestacarMenu(btnFavoritos);
            AtualizarLista();
        }

        private void btnCreditos_Click(object? sender, EventArgs e)
        {
            using (FormCreditos telaCreditos = new FormCreditos())
            {
                telaCreditos.ShowDialog(this);
            }
        }

        private void btnMapa_Click(object? sender, EventArgs e)
        {
            string link = "https://www.google.com/maps/search/pontos+turisticos+Bauru+SP";
            Process.Start(new ProcessStartInfo(link) { UseShellExecute = true });
        }

        private void DestacarMenu(Button selecionado)
        {
            btnInicio.BackColor = pnlMenu.BackColor;
            btnFavoritos.BackColor = pnlMenu.BackColor;
            selecionado.BackColor = corMenuSelecionado;
        }

        private void AlternarTelaCheia()
        {
            if (FormBorderStyle == FormBorderStyle.None)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                // volta pra Normal antes, senão a barra de tarefas continua aparecendo
                WindowState = FormWindowState.Normal;
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
            }
        }

        private void FormBusca_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11)
                AlternarTelaCheia();

            if (e.KeyCode == Keys.Escape && FormBorderStyle == FormBorderStyle.None)
                AlternarTelaCheia();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
