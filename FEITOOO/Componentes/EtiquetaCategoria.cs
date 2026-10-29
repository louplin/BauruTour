using System.ComponentModel;
using System.Drawing.Drawing2D;
using BaurusTour.Utilitarios;

namespace BaurusTour.Componentes
{
    /// <summary>
    /// Etiqueta arredondada que mostra a categoria do ponto (Natureza, Gastronomia...).
    /// A cor muda sozinha conforme o texto. A largura se ajusta ao tamanho do texto.
    /// </summary>
    public class EtiquetaCategoria : Control
    {
        public EtiquetaCategoria()
        {
            SetStyle(ControlStyles.UserPaint |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(ControlStyles.Selectable, false);

            BackColor = Color.Transparent;
            Font = new Font("Segoe UI Semibold", 9F);
            Size = new Size(110, 26);
            TabStop = false;
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            AjustarLargura();
            Invalidate();
        }

        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            AjustarLargura();
        }

        private void AjustarLargura()
        {
            if (string.IsNullOrEmpty(Text))
                return;

            Size tam = TextRenderer.MeasureText(Text, Font);
            Width = tam.Width + LogicalToDeviceUnits(22);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            (Color fundo, Color texto) = Tema.CoresDaCategoria(Text);

            var area = new RectangleF(0, 0, Width - 1, Height - 1);
            using (GraphicsPath caminho = Desenho.RetanguloArredondado(area, Height / 2f))
            using (var pincel = new SolidBrush(fundo))
                g.FillPath(pincel, caminho);

            TextRenderer.DrawText(g, Text, Font, ClientRectangle, texto,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter |
                TextFormatFlags.SingleLine | TextFormatFlags.NoPadding);
        }
    }
}
