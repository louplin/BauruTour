using BaurusTour.Classes;
using BaurusTour.Modelos;

namespace BaurusTour.Componentes
{
    // Card de cada lugar na tela de busca
    public partial class CardPontoTuristico : UserControl
    {
        // a tela de busca fica "escutando" esses eventos pra saber quando clicaram no card
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

        public void MostrarPonto(PontoTuristico pontoTuristico, bool favorito)
        {
            ponto = pontoTuristico;
            picFoto.Image = GerenciadorFotos.MiniaturaDoPonto(pontoTuristico, picFoto.Width, picFoto.Height);
            lblCategoria.Text = pontoTuristico.Categoria;
            lblNome.Text = pontoTuristico.Nome;
            // no card aparece só o primeiro parágrafo
            string[] paragrafos = pontoTuristico.Descricao.Split("\n\n");
            lblDescricao.Text = paragrafos[0];
            MostrarFavorito(favorito);
        }

        public void MostrarFavorito(bool favorito)
        {
            string coracao = "♡";
            if (favorito)
                coracao = "♥";

            btnFavoritar.Text = coracao;
        }

        // a foto, o nome e o botão "Ver detalhes" usam esse mesmo evento
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
