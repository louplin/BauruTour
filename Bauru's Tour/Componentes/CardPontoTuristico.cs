using System.ComponentModel;
using BaurusTour.Models;
using BaurusTour.Services;

namespace BaurusTour.Componentes
{
    /// <summary>
    /// Card de um ponto turístico. O visual dele está no Designer
    /// (CardPontoTuristico.Designer.cs). Aqui só colocamos os dados do ponto
    /// e avisamos a tela de busca quando clicam nos botões.
    /// </summary>
    public partial class CardPontoTuristico : UserControl
    {
        // A tela de busca "escuta" esses dois avisos
        public event EventHandler? VerDetalhesClicado;
        public event EventHandler? FavoritarClicado;

        public CardPontoTuristico()
        {
            InitializeComponent();
        }

        /// <summary>O ponto turístico que este card está mostrando.</summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public PontoTuristico? Ponto { get; private set; }

        /// <summary>Preenche o card com os dados do ponto.</summary>
        public void MostrarPonto(PontoTuristico ponto, bool favorito)
        {
            Ponto = ponto;
            picFoto.Image = FotoService.FotoDoPonto(ponto);
            lblCategoria.Text = ponto.Categoria;
            lblNome.Text = ponto.Nome;
            lblDescricao.Text = ponto.Descricao;
            MostrarFavorito(favorito);
        }

        /// <summary>Coração cheio (♥) se for favorito, vazio (♡) se não for.</summary>
        public void MostrarFavorito(bool favorito)
        {
            btnFavoritar.Text = favorito ? "♥" : "♡";
        }

        // Clique na foto, no nome ou no botão "Ver detalhes"
        private void btnVerDetalhes_Click(object? sender, EventArgs e)
        {
            VerDetalhesClicado?.Invoke(this, EventArgs.Empty);
        }

        // Clique no coração
        private void btnFavoritar_Click(object? sender, EventArgs e)
        {
            FavoritarClicado?.Invoke(this, EventArgs.Empty);
        }
    }
}
