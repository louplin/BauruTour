using BaurusTour.Models;

namespace BaurusTour.Utilitarios
{
    /// <summary>
    /// Carrega as imagens da pasta "Imagens" (que vai junto com o .exe).
    /// Cada imagem é lida uma vez só e fica guardada, então o app não trava
    /// nem deixa os arquivos presos.
    /// </summary>
    public static class CarregadorImagens
    {
        private static readonly Dictionary<string, Image?> _cache =
            new Dictionary<string, Image?>(StringComparer.OrdinalIgnoreCase);

        /// <summary>Retorna a imagem ou null se o arquivo não existir.</summary>
        public static Image? Carregar(string caminhoRelativo)
        {
            if (string.IsNullOrWhiteSpace(caminhoRelativo))
                return null;

            if (_cache.TryGetValue(caminhoRelativo, out Image? guardada))
                return guardada;

            Image? imagem = null;
            string caminho = Path.Combine(AppContext.BaseDirectory, caminhoRelativo);

            if (File.Exists(caminho))
            {
                try
                {
                    // Copia para a memória para não deixar o arquivo bloqueado
                    using (var original = Image.FromFile(caminho))
                        imagem = new Bitmap(original);
                }
                catch (Exception)
                {
                    imagem = null; // arquivo corrompido ou formato não suportado
                }
            }

            _cache[caminhoRelativo] = imagem;
            return imagem;
        }

        /// <summary>
        /// Foto do ponto turístico. Se a foto ainda não foi colocada na pasta
        /// Imagens/Pontos, usa a ilustração da categoria.
        /// </summary>
        public static Image? ImagemDoPonto(PontoTuristico ponto)
        {
            return Carregar(ponto.Imagem) ?? ImagemDaCategoria(ponto.Categoria);
        }

        public static Image? ImagemDaCategoria(string categoria)
        {
            string arquivo;
            switch (categoria.Trim().ToLowerInvariant())
            {
                case "natureza": arquivo = "natureza.png"; break;
                case "gastronomia": arquivo = "gastronomia.png"; break;
                case "lazer e cultura": arquivo = "lazer-e-cultura.png"; break;
                case "compras": arquivo = "compras.png"; break;
                default: arquivo = "padrao.png"; break;
            }

            return Carregar(Path.Combine("Imagens", "Categorias", arquivo));
        }

        public static Image? Logo => Carregar(Path.Combine("Imagens", "logo.png"));
        public static Image? Banner => Carregar(Path.Combine("Imagens", "banner.png"));
        public static Image? IlustracaoMenu => Carregar(Path.Combine("Imagens", "ilustracao-menu.png"));

        public static Icon? IconeDoApp
        {
            get
            {
                string caminho = Path.Combine(AppContext.BaseDirectory, "Imagens", "icone.ico");
                if (!File.Exists(caminho))
                    return null;

                try { return new Icon(caminho); }
                catch (Exception) { return null; }
            }
        }
    }
}
