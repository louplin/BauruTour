using System.ComponentModel;
using System.Drawing.Drawing2D;
using BaurusTour.Utilitarios;

namespace BaurusTour.Componentes
{
    /// <summary>
    /// Mostra uma imagem preenchendo todo o espaço sem distorcer (recorta as sobras),
    /// igual a foto de capa de rede social. Os cantos podem ser arredondados.
    /// </summary>
    public class ImagemCapa : Control
    {
        private Image? _imagem;
        private int _raio;
        private bool _arredondarSoEmCima;

        public ImagemCapa()
        {
            SetStyle(ControlStyles.UserPaint |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(ControlStyles.Selectable, false);

            BackColor = Color.Transparent;
            TabStop = false;
        }

        /// <summary>A imagem é definida pelo código (não é salva pelo Designer).</summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Image? Imagem
        {
            get => _imagem;
            set { _imagem = value; Invalidate(); }
        }

        [Category("Bauru's Tour"), Description("Raio dos cantos arredondados."), DefaultValue(0)]
        public int Raio
        {
            get => _raio;
            set { _raio = Math.Max(0, value); Invalidate(); }
        }

        [Category("Bauru's Tour"), Description("Arredonda só os cantos de cima (usado nos cards)."), DefaultValue(false)]
        public bool ArredondarSoEmCima
        {
            get => _arredondarSoEmCima;
            set { _arredondarSoEmCima = value; Invalidate(); }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;

            if (Width <= 0 || Height <= 0)
                return;

            using (GraphicsPath caminho = CriarContorno())
            {
                if (_imagem == null)
                {
                    using (var pincel = new SolidBrush(Color.FromArgb(225, 232, 238)))
                        g.FillPath(pincel, caminho);
                    return;
                }

                // Escala de "capa": a imagem cobre tudo e o que sobra é cortado no meio
                float escala = Math.Max((float)Width / _imagem.Width, (float)Height / _imagem.Height);
                float largura = _imagem.Width * escala;
                float altura = _imagem.Height * escala;
                float x = (Width - largura) / 2f;
                float y = (Height - altura) / 2f;

                using (var textura = new TextureBrush(_imagem, WrapMode.Clamp))
                {
                    textura.TranslateTransform(x, y);
                    textura.ScaleTransform(escala, escala);
                    g.FillPath(textura, caminho);
                }
            }
        }

        private GraphicsPath CriarContorno()
        {
            var area = new RectangleF(0, 0, Width, Height);

            if (_raio <= 0)
            {
                var retangulo = new GraphicsPath();
                retangulo.AddRectangle(area);
                return retangulo;
            }

            if (!_arredondarSoEmCima)
                return Desenho.RetanguloArredondado(area, _raio);

            float d = Math.Min(_raio * 2f, Math.Min(Width, Height));
            var caminho = new GraphicsPath();
            caminho.AddArc(area.X, area.Y, d, d, 180, 90);
            caminho.AddArc(area.Right - d, area.Y, d, d, 270, 90);
            caminho.AddLine(area.Right, area.Bottom, area.X, area.Bottom);
            caminho.CloseFigure();
            return caminho;
        }
    }
}
