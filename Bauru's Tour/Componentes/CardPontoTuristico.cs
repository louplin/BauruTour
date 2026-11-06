using BaurusTour.Classes;
using BaurusTour.Models;

namespace BaurusTour.Componentes
{
    // Card que aparece na tela de busca para cada ponto turístico.
    // O visual está no Designer.
    public partial class CardPontoTuristico : UserControl
    {
        // Eventos que a tela de busca "escuta" para saber quando clicaram no card
        public event EventHandler? VerDetalhesClicado;
        public event EventHandler? FavoritarClicado;

        private PontoTuristico? ponto;

        public CardPontoTuristico()
        {
            InitializeComponent();
        }

        public PontoTuristico? ObterPonto()
        {
            return ponto;
        }

        // Coloca os dados do ponto no card
        public void MostrarPonto(PontoTuristico pontoTuristico, bool favorito)
        {
            ponto = pontoTuristico;
            picFoto.Image = GerenciadorFotos.FotoDoPonto(pontoTuristico);
            lblCategoria.Text = pontoTuristico.Categoria;
            lblNome.Text = pontoTuristico.Nome;
            lblDescricao.Text = pontoTuristico.Descricao;
            MostrarFavorito(favorito);
        }

        // ♥ = favorito, ♡ = não favorito
        public void MostrarFavorito(bool favorito)
        {
            if (favorito)
                btnFavoritar.Text = "♥";
            else
                btnFavoritar.Text = "♡";
        }

        // Clique na foto, no nome ou no botão "Ver detalhes"
        private void btnVerDetalhes_Click(object? sender, EventArgs e)
        {
            if (VerDetalhesClicado != null)
                VerDetalhesClicado(this, EventArgs.Empty);
        }

        private void btnFavoritar_Click(object? sender, EventArgs e)
        {
            if (FavoritarClicado != null)
                FavoritarClicado(this, EventArgs.Empty);
        }
    }
}
