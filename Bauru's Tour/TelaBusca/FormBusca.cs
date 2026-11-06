using System.Diagnostics;
using BaurusTour.Classes;
using BaurusTour.Componentes;
using BaurusTour.Models;
using BaurusTour.TelaDetalhe;
using BaurusTour.TelaSobre;

namespace BaurusTour.TelaBusca
{
    // Tela principal: menu lateral, busca, categorias e os cards dos pontos
    public partial class FormBusca : Form
    {
        // Cores do botão selecionado
        private Color corPrimaria = Color.FromArgb(11, 107, 138);
        private Color corAzulEscuro = Color.FromArgb(13, 43, 94);
        private Color corBorda = Color.FromArgb(220, 226, 230);
        private Color corMenuSelecionado = Color.FromArgb(228, 241, 245);

        private GerenciadorPontos pontos;
        private GerenciadorFavoritos favoritos;

        private string categoriaSelecionada = "Todos";
        private bool mostrandoFavoritos = false;

        public FormBusca()
        {
            InitializeComponent();

            string caminhoJson = Path.Combine(AppContext.BaseDirectory, "pontos.json");
            pontos = new GerenciadorPontos(caminhoJson);
            favoritos = new GerenciadorFavoritos();
        }

        // Cria um card para cada ponto do pontos.json
        private void FormBusca_Load(object? sender, EventArgs e)
        {
            if (pontos.MensagemErro != "")
            {
                MessageBox.Show(pontos.MensagemErro, "Erro ao carregar os pontos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            foreach (PontoTuristico ponto in pontos.ListarTodos())
            {
                CardPontoTuristico card = new CardPontoTuristico();
                card.MostrarPonto(ponto, favoritos.EhFavorito(ponto.Id));
                card.VerDetalhesClicado += Card_VerDetalhesClicado;
                card.FavoritarClicado += Card_FavoritarClicado;
                flpCards.Controls.Add(card);
            }

            AtualizarLista();
        }

        // Mostra só os cards que combinam com a busca, a categoria e os favoritos
        private void AtualizarLista()
        {
            List<int>? somenteFavoritos = null;
            if (mostrandoFavoritos)
                somenteFavoritos = favoritos.Ids;

            List<PontoTuristico> resultado = pontos.Pesquisar(txtBusca.Text, categoriaSelecionada, somenteFavoritos);

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
            if (ponto == null)
                return;

            using (FormDetalhe telaDetalhe = new FormDetalhe(ponto, favoritos))
            {
                // se esta tela está em tela cheia, a de detalhes abre em tela cheia também
                if (FormBorderStyle == FormBorderStyle.None)
                    telaDetalhe.FormBorderStyle = FormBorderStyle.None;

                telaDetalhe.ShowDialog(this);
            }

            // o favorito pode ter mudado na tela de detalhes
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

        private void btnBuscar_Click(object? sender, EventArgs e)
        {
            AtualizarLista();
        }

        // Vai filtrando enquanto a pessoa digita
        private void txtBusca_TextChanged(object? sender, EventArgs e)
        {
            AtualizarLista();
        }

        // Todos os botões de categoria usam este evento.
        // O nome da categoria de cada botão está na propriedade Tag (no Designer).
        private void Categoria_Click(object? sender, EventArgs e)
        {
            Button? botaoClicado = sender as Button;
            if (botaoClicado == null)
                return;

            string? categoria = botaoClicado.Tag as string;
            if (categoria == null)
                categoria = "Todos";

            categoriaSelecionada = categoria;

            foreach (Control controle in flpCategorias.Controls)
            {
                Button? botao = controle as Button;
                if (botao == null)
                    continue;

                if (botao == botaoClicado)
                {
                    botao.BackColor = corPrimaria;
                    botao.ForeColor = Color.White;
                    botao.FlatAppearance.BorderColor = corPrimaria;
                }
                else
                {
                    botao.BackColor = Color.White;
                    botao.ForeColor = corAzulEscuro;
                    botao.FlatAppearance.BorderColor = corBorda;
                }
            }

            AtualizarLista();
        }

        private void btnVerTodos_Click(object? sender, EventArgs e)
        {
            txtBusca.Text = "";
            Categoria_Click(btnCategoriaTodos, EventArgs.Empty);
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

        private void btnSobre_Click(object? sender, EventArgs e)
        {
            using (FormSobre telaSobre = new FormSobre())
            {
                telaSobre.ShowDialog(this);
            }
        }

        private void btnMapa_Click(object? sender, EventArgs e)
        {
            string link = "https://www.google.com/maps/search/pontos+turisticos+Bauru+SP";
            Process.Start(new ProcessStartInfo(link) { UseShellExecute = true });
        }

        // Pinta de azul claro o botão do menu que está selecionado
        private void DestacarMenu(Button selecionado)
        {
            btnInicio.BackColor = Color.White;
            btnFavoritos.BackColor = Color.White;
            selecionado.BackColor = corMenuSelecionado;
        }

        // F11 liga/desliga a tela cheia
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
    }
}
