using BaurusTour.Models;

namespace BaurusTour.Classes
{
    // Se a foto do ponto existe na pasta Imagens, usa ela.
    // Se não existe, usa a ilustração da categoria (que está nos Recursos do projeto).
    public static class GerenciadorFotos
    {
        public static Image FotoDoPonto(PontoTuristico ponto)
        {
            string capa = "";
            if (ponto.Imagens.Count > 0)
            {
                capa = ponto.Imagens[0];
            }

            string caminho = Path.Combine(AppContext.BaseDirectory, capa);
            if (ponto.Id == 1)
            {
                string pasta = Path.GetDirectoryName(caminho) ?? "";
                string arquivos = Directory.Exists(pasta)
                    ? string.Join("\n", Directory.GetFiles(pasta).Select(f => "[" + Path.GetFileName(f) + "]"))
                    : "(a pasta não existe)";

                MessageBox.Show("Base: " + AppContext.BaseDirectory + "\n\nPasta existe? " + Directory.Exists(pasta) + "\n\nArquivos:\n" + arquivos);
            }

            if (capa != "" && File.Exists(caminho))
            {
                // Faz uma cópia da foto e fecha o arquivo,
                // senão o Windows deixa o arquivo travado enquanto o app estiver aberto
                using (Image fotoDoArquivo = Image.FromFile(caminho))
                {
                    return new Bitmap(fotoDoArquivo);
                }
            }

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