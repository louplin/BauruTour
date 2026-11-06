using BaurusTour.Models;

namespace BaurusTour.Classes
{
    public static class GerenciadorFotos
    {
        // Foto principal do ponto. Se a foto não existir na pasta Imagens/Pontos,
        // usa a imagem da categoria (que está nos Recursos do projeto).
        public static Image FotoDoPonto(PontoTuristico ponto)
        {
            Image? foto = CarregarFoto(ponto.Imagem);
            if (foto != null)
                return foto;

            return FotoDaCategoria(ponto.Categoria);
        }

        public static Image FotoDaCategoria(string categoria)
        {
            switch (categoria)
            {
                case "Natureza": return Properties.Resources.categoria_natureza;
                case "Gastronomia": return Properties.Resources.categoria_gastronomia;
                case "Lazer e Cultura": return Properties.Resources.categoria_lazer_e_cultura;
                case "Compras": return Properties.Resources.categoria_compras;
                default: return Properties.Resources.categoria_padrao;
            }
        }

        // Abre uma foto da pasta do app. Retorna null se o arquivo não existir.
        public static Image? CarregarFoto(string caminhoRelativo)
        {
            if (caminhoRelativo == "")
                return null;

            string caminho = Path.Combine(AppContext.BaseDirectory, caminhoRelativo);
            if (!File.Exists(caminho))
                return null;

            // Faz uma cópia da imagem e fecha o arquivo,
            // senão o Windows deixa o arquivo da foto travado enquanto o app estiver aberto
            using (Image imagemDoArquivo = Image.FromFile(caminho))
            {
                return new Bitmap(imagemDoArquivo);
            }
        }
    }
}
