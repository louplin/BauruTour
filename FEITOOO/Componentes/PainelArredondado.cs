using System.ComponentModel;
using System.Drawing.Drawing2D;
using BaurusTour.Utilitarios;

namespace BaurusTour.Componentes
{
    /// <summary>
    /// Painel com cantos arredondados e borda. Usado na caixa de busca.
    /// Deixe o BackColor como Transparent para os cantos mostrarem o fundo de trás.
    /// </summary>
    public class PainelArredondado : Panel
    {
        private int _raio = 28;
        private Color _corFundo = Color.White;
        private Color _corBorda = Color.FromArgb(220, 226, 230);

        public PainelArredondado()
        {
            SetStyle(ControlStyles.UserPaint |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;
        }

        [Category("Bauru's Tour"), Description("Raio dos cantos arredondados."), DefaultValue(28)]
        public int Raio
        {
            get => _raio;
            set { _raio = Math.Max(0, value); Invalidate(); }
        }

        [Category("Bauru's Tour"), Description("Cor de dentro do painel."), DefaultValue(typeof(Color), "White")]
        public Color CorFundo
        {
            get => _corFundo;
            set { _corFundo = value; Invalidate(); }
        }

        [Category("Bauru's Tour"), Description("Cor da borda."), DefaultValue(typeof(Color), "220, 226, 230")]
        public Color CorBorda
        {
            get => _corBorda;
            set { _corBorda = value; Invalidate(); }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            var area = new RectangleF(0.5f, 0.5f, Width - 1.5f, Height - 1.5f);
            using (GraphicsPath caminho = Desenho.RetanguloArredondado(area, _raio))
            {
                using (var pincel = new SolidBrush(_corFundo))
                    g.FillPath(pincel, caminho);

                if (_corBorda.A > 0)
                {
                    using (var caneta = new Pen(_corBorda, 1.2f))
                        g.DrawPath(caneta, caminho);
                }
            }
        }
    }
}
