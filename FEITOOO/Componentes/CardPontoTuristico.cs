using System.ComponentModel;
using System.Drawing.Drawing2D;
using BaurusTour.Models;
using BaurusTour.Utilitarios;

namespace BaurusTour.Componentes
{
    /// <summary>
    /// Card de um ponto turístico na tela de busca: foto, categoria, nome,
    /// descrição curta, botão "Ver detalhes" e o coração de favoritar.
    /// </summary>
    public partial class CardPontoTuristico : UserControl
    {
        /// <summary>Disparado quando clicam na foto, no nome ou em "Ver detalhes".</summary>
        public event EventHandler? VerDetalhesClicado;

        /// <summary>Disparado quando clicam no coração.</summary>
        public event EventHandler? FavoritarClicado;

        public CardPontoTuristico()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.ResizeRedraw, true);

            InitializeComponent();
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public PontoTuristico? Ponto { get; private set; }

        /// <summary>Coloca os dados do ponto no card.</summary>
        public void Preencher(PontoTuristico ponto, bool favorito)
        {
            Ponto = ponto;
            imgFoto.Imagem = CarregadorImagens.ImagemDoPonto(ponto);
            etqCategoria.Text = ponto.Categoria;
            lblNome.Text = ponto.Nome;
            lblDescricao.Text = ponto.Descricao;
            DefinirFavorito(favorito);
        }

        /// <summary>Troca o coração vazio pelo cheio (e vice-versa).</summary>
        public void DefinirFavorito(bool favorito)
        {
            btnFavoritar.Icone = favorito ? Icones.CoracaoCheio : Icones.Coracao;
        }

        private void AbrirDetalhes_Click(object? sender, EventArgs e)
        {
            VerDetalhesClicado?.Invoke(this, EventArgs.Empty);
        }

        private void btnFavoritar_Click(object? sender, EventArgs e)
        {
            FavoritarClicado?.Invoke(this, EventArgs.Empty);
        }

        // Fundo branco com cantos arredondados e borda
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int raio = LogicalToDeviceUnits(14);
            var area = new RectangleF(0.5f, 0.5f, Width - 1.5f, Height - 1.5f);

            using (GraphicsPath caminho = Desenho.RetanguloArredondado(area, raio))
            using (var pincel = new SolidBrush(Color.White))
            using (var caneta = new Pen(Tema.Borda, 1f))
            {
                g.FillPath(pincel, caminho);
                g.DrawPath(caneta, caminho);
            }
        }
    }
}
