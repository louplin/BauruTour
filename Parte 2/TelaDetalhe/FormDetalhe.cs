using System.Diagnostics;
using BaurusTour.Models;
using BaurusTour.Services;
using BaurusTour.TelaCompartilhar;

namespace BaurusTour.TelaDetalhe
{
    /// <summary>
    /// Tela de detalhes de um ponto turístico.
    /// O visual está todo no Designer (FormDetalhe.Designer.cs).
    /// Aqui só colocamos os dados do ponto e o que cada botão faz.
    /// </summary>
    public partial class FormDetalhe : Form
    {
        private readonly PontoTuristico? ponto;
        private readonly FavoritosService? favoritos;

        // Usado só pelo Designer do Visual Studio
        public FormDetalhe()
        {
            InitializeComponent();
        }

        // Usado pela tela de busca: recebe o ponto que foi clicado
        public FormDetalhe(PontoTuristico ponto, FavoritosService favoritos) : this()
        {
            this.ponto = ponto;
            this.favoritos = favoritos;
        }

        // Ao abrir: coloca os dados do ponto nos labels e na foto
        private void FormDetalhe_Load(object? sender, EventArgs e)
        {
            if (ponto == null)
                return;

            Text = ponto.Nome + " - Bauru's Tour";
            lblCategoria.Text = ponto.Categoria;
            lblNome.Text = ponto.Nome;
            lblEndereco.Text = ponto.Endereco;
            lblDescricao.Text = ponto.Descricao;
            picFoto.Image = FotoService.FotoDoPonto(ponto);

            AtualizarBotaoFavoritar();

            if (FormBorderStyle == FormBorderStyle.None)
                btnTelaCheia.Text = "Sair da tela cheia";
        }

        // ================================================================
        // Botões
        // ================================================================
        private void btnVoltar_Click(object? sender, EventArgs e)
        {
            Close();
        }

        private void btnMapa_Click(object? sender, EventArgs e)
        {
            if (ponto == null)
                return;

            Process.Start(new ProcessStartInfo(ponto.LinkMaps) { UseShellExecute = true });
        }

        private void btnCompartilhar_Click(object? sender, EventArgs e)
        {
            if (ponto == null)
                return;

            using (var telaCompartilhar = new FormCompartilhar(ponto))
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

        /// <summary>Botão vermelho cheio quando é favorito, só com borda quando não é.</summary>
        private void AtualizarBotaoFavoritar()
        {
            if (ponto == null || favoritos == null)
                return;

            if (favoritos.EhFavorito(ponto.Id))
            {
                btnFavoritar.Text = "♥  Favoritado";
                btnFavoritar.BackColor = Color.FromArgb(226, 72, 80);
                btnFavoritar.ForeColor = Color.White;
            }
            else
            {
                btnFavoritar.Text = "♡  Favoritar";
                btnFavoritar.BackColor = Color.White;
                btnFavoritar.ForeColor = Color.FromArgb(226, 72, 80);
            }
        }

        // ================================================================
        // Tela cheia (botão ou F11) e tecla Esc
        // ================================================================
        private void btnTelaCheia_Click(object? sender, EventArgs e)
        {
            AlternarTelaCheia();
        }

        private void AlternarTelaCheia()
        {
            if (FormBorderStyle == FormBorderStyle.None)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Maximized;
                btnTelaCheia.Text = "Tela cheia";
            }
            else
            {
                WindowState = FormWindowState.Normal;
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
                btnTelaCheia.Text = "Sair da tela cheia";
            }
        }

        private void FormDetalhe_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11)
                AlternarTelaCheia();

            // Esc: sai da tela cheia; se já estiver em janela, volta para a busca
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
