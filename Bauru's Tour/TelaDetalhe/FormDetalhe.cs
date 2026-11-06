using System.Diagnostics;
using BaurusTour.Classes;
using BaurusTour.Models;
using BaurusTour.TelaCompartilhar;

namespace BaurusTour.TelaDetalhe
{
    // Tela com os detalhes de um ponto turístico
    public partial class FormDetalhe : Form
    {
        private PontoTuristico? ponto;
        private GerenciadorFavoritos? favoritos;

        // O Designer do Visual Studio precisa de um construtor sem parâmetros
        public FormDetalhe()
        {
            InitializeComponent();
        }

        // Construtor usado pela tela de busca, recebe o ponto que foi clicado
        public FormDetalhe(PontoTuristico ponto, GerenciadorFavoritos favoritos) : this()
        {
            this.ponto = ponto;
            this.favoritos = favoritos;
        }

        private void FormDetalhe_Load(object? sender, EventArgs e)
        {
            if (ponto == null)
                return;

            Text = ponto.Nome + " - Bauru's Tour";
            lblCategoria.Text = ponto.Categoria;
            lblNome.Text = ponto.Nome;
            lblEndereco.Text = ponto.Endereco;
            lblDescricao.Text = ponto.Descricao;
            picFoto.Image = GerenciadorFotos.FotoDoPonto(ponto);

            // sem link, não tem como abrir o mapa nem compartilhar
            if (ponto.LinkMaps == "")
            {
                btnMapa.Enabled = false;
                btnCompartilhar.Enabled = false;
            }

            AtualizarBotaoFavoritar();
        }

        private void btnVoltar_Click(object? sender, EventArgs e)
        {
            Close();
        }

        private void btnMapa_Click(object? sender, EventArgs e)
        {
            if (ponto == null || ponto.LinkMaps == "")
                return;

            try
            {
                Process.Start(new ProcessStartInfo(ponto.LinkMaps) { UseShellExecute = true });
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível abrir o mapa.", "Bauru's Tour",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCompartilhar_Click(object? sender, EventArgs e)
        {
            if (ponto == null)
                return;

            using (FormCompartilhar telaCompartilhar = new FormCompartilhar(ponto))
            {
                telaCompartilhar.ShowDialog(this);
            }
        }

        private void btnFavoritar_Click(object? sender, EventArgs e)
        {
            if (ponto == null || favoritos == null)
                return;

            favoritos.Alternar(ponto.Id);
            AtualizarBotaoFavoritar();
        }

        // Favorito: botão vermelho. Não favorito: botão branco com letra vermelha.
        private void AtualizarBotaoFavoritar()
        {
            if (ponto == null || favoritos == null)
                return;

            Color vermelho = Color.FromArgb(226, 72, 80);

            if (favoritos.EhFavorito(ponto.Id))
            {
                btnFavoritar.Text = "♥  Favoritado";
                btnFavoritar.BackColor = vermelho;
                btnFavoritar.ForeColor = Color.White;
            }
            else
            {
                btnFavoritar.Text = "♡  Favoritar";
                btnFavoritar.BackColor = Color.White;
                btnFavoritar.ForeColor = vermelho;
            }
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

        private void FormDetalhe_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11)
                AlternarTelaCheia();

            // Esc sai da tela cheia, ou volta pra busca se não estiver em tela cheia
            if (e.KeyCode == Keys.Escape)
            {
                if (FormBorderStyle == FormBorderStyle.None)
                    AlternarTelaCheia();
                else
                    Close();
            }
        }
    }
}
