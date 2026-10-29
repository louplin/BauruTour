using System.Drawing.Drawing2D;

namespace BaurusTour.Utilitarios
{
    /// <summary>
    /// Funções de desenho usadas pelos componentes com cantos arredondados.
    /// </summary>
    public static class Desenho
    {
        public static GraphicsPath RetanguloArredondado(RectangleF r, float raio)
        {
            var caminho = new GraphicsPath();

            float d = Math.Min(raio * 2, Math.Min(r.Width, r.Height));
            if (d <= 0.5f)
            {
                caminho.AddRectangle(r);
                return caminho;
            }

            caminho.AddArc(r.X, r.Y, d, d, 180, 90);
            caminho.AddArc(r.Right - d, r.Y, d, d, 270, 90);
            caminho.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
            caminho.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
            caminho.CloseFigure();
            return caminho;
        }
    }
}
