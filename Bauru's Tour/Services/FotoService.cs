using BaurusTour.Models;

namespace BaurusTour.Services
{
    /// <summary>
    /// Escolhe a imagem de cada ponto turístico.
    /// Se a foto existir na pasta Imagens/Pontos, usa a foto.
    /// Se não existir, usa a imagem da categoria (que está nos Recursos do projeto).
    /// </summary>
    public static class FotoService
    {
        public static Image FotoDoPonto(PontoTuristico ponto)
        {
            string caminho = Path.Combine(AppContext.BaseDirectory, ponto.Imagem);

            if (ponto.Imagem != "" && File.Exists(caminho))
                return Image.FromFile(caminho);

            switch (ponto.Categoria)
            {
                case "Natureza": return Properties.Resources.categoria_natureza;
                case "Gastronomia": return Properties.Resources.categoria_gastronomia;
                case "Lazer e Cultura": return Properties.Resources.categoria_lazer_e_cultura;
                case "Compras": return Properties.Resources.categoria_compras;
                default: return Properties.Resources.categoria_padrao;
            }
        }
    }
}
