using BaurusTour.Models;
using BaurusTour.Services;
using BaurusTour.TelaCompartilhar;
using BaurusTour.Utilitarios;

namespace BaurusTour.TelaDetalhe
{
    /// <summary>
    /// Tela de detalhes de um ponto turístico: foto grande, categoria, nome,
    /// endereço, descrição e os botões de mapa, compartilhar e favoritar.
    /// </summary>
    public partial class FormDetalhe : Form
    {
        private readonly PontoTuristico? _ponto;
        private readonly FavoritosService? _favoritos;

        // Usado só pelo Designer do Visual Studio
        public FormDetalhe()
        {
            InitializeComponent();
        }

        // Usado pelo programa: recebe o ponto que foi clicado e a lista de favoritos
        public FormDetalhe(PontoTuristico ponto, FavoritosService favoritos) : this()
        {
            _ponto = ponto;
            _favoritos = favoritos;
        }

        private void FormDetalhe_Load(object? sender, EventArgs e)
        {
            Icon = CarregadorImagens.IconeDoApp ?? Icon;
            picLogo.Image = CarregadorImagens.Logo;

            if (_ponto == null)
                return; // aberto pelo Designer

            Text = _ponto.Nome + " - Bauru's Tour";
            etqCategoria.Text = _ponto.Categoria;
            lblNome.Text = _ponto.Nome;
            lblEndereco.Text = _ponto.Endereco;
            lblDescricao.Text = _ponto.Descricao;
            imgFoto.Imagem = CarregadorImagens.ImagemDoPonto(_ponto);

            btnMapa.Enabled = !string.IsNullOrWhiteSpace(_ponto.LinkMaps);
            btnCompartilhar.Enabled = btnMapa.Enabled;

            AtualizarBotaoFavorito();
        }

        private void FormDetalhe_Shown(object? sender, EventArgs e)
        {
            AtualizarBotaoTelaCheia();
            btnVoltar.Focus();
        }

        // ------------------------------------------------------------------ botões

        private void btnVoltar_Click(object? sender, EventArgs e)
        {
            Close();
        }

        private void btnMapa_Click(object? sender, EventArgs e)
        {
            if (_ponto != null)
                AbridorLinks.AbrirLink(_ponto.LinkMaps, this);
        }

        private void btnCompartilhar_Click(object? sender, EventArgs e)
        {
            if (_ponto == null)
                return;

            using (var tela = new FormCompartilhar(_ponto))
                tela.ShowDialog(this);
        }

        private void btnFavoritar_Click(object? sender, EventArgs e)
        {
            if (_ponto == null || _favoritos == null)
                return;

            _favoritos.Alternar(_ponto.Id);
            AtualizarBotaoFavorito();
        }

        private void btnTelaCheia_Click(object? sender, EventArgs e)
        {
            AlternarTelaCheia();
        }

        /// <summary>Coração cheio e botão vermelho quando o lugar está nos favoritos.</summary>
        private void AtualizarBotaoFavorito()
        {
            bool favorito = _ponto != null && _favoritos != null && _favoritos.EhFavorito(_ponto.Id);

            btnFavoritar.Text = favorito ? "Favoritado" : "Favoritar";
            btnFavoritar.Icone = favorito ? Icones.CoracaoCheio : Icones.Coracao;
            btnFavoritar.CorFundo = favorito ? Tema.Coracao : Tema.Branco;
            btnFavoritar.CorFundoHover = favorito ? Color.FromArgb(200, 55, 64) : Tema.CoracaoClaro;
            btnFavoritar.ForeColor = favorito ? Tema.Branco : Tema.Coracao;
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
            btnTelaCheia.Text = emTelaCheia ? "Sair da tela cheia" : "Tela cheia";
            btnTelaCheia.Icone = emTelaCheia ? Icones.SairTelaCheia : Icones.TelaCheia;
        }

        private void FormDetalhe_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11)
            {
                AlternarTelaCheia();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                // Esc sai da tela cheia; se já estiver em janela, volta pra busca
                if (ControleTelaCheia.EstaEmTelaCheia(this))
                    AlternarTelaCheia();
                else
                    Close();

                e.Handled = true;
            }
        }
    }
}
