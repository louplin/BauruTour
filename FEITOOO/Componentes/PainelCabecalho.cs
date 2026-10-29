using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace BaurusTour.Componentes
{
    /// <summary>
    /// Painel do topo da tela de busca. Desenha a ilustração da cidade encostada
    /// no lado direito, sempre com a altura do painel, sem distorcer.
    /// </summary>
    public class PainelCabecalho : Panel
    {
        private Image? _imagemDireita;

        public PainelCabecalho()
        {
            SetStyle(ControlStyles.UserPaint |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw, true);
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Image? ImagemDireita
        {
            get => _imagemDireita;
            set { _imagemDireita = value; Invalidate(); }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (_imagemDireita == null || Height <= 0)
                return;

            Graphics g = e.Graphics;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;

            float escala = (float)Height / _imagemDireita.Height;
            float largura = _imagemDireita.Width * escala;

            // Em telas estreitas a ilustração não pode passar da metade para a esquerda
            float x = Math.Max(Width - largura, Width * 0.35f);
            g.DrawImage(_imagemDireita, new RectangleF(x, 0, largura, Height));
        }
    }
}
