using BaurusTour.Modelos;

namespace BaurusTour.Classes
{
    public static class GerenciadorFotos
    {
        // Fotos que já foram abertas ficam guardadas aqui.
        // Sem isso o app abria o mesmo arquivo várias vezes e ficava lento.
        private static Dictionary<string, Image> fotosAbertas = new Dictionary<string, Image>();

        // Foto do lugar. Se a foto não estiver na pasta, mostra uma imagem padrão.
        public static Image FotoDoPonto(PontoTuristico ponto)
        {
            Image? foto = CarregarFoto(ponto.Imagem);
            if (foto != null)
                return foto;

            return Properties.Resources.sem_foto;
        }

        // Foto pequena pro card. Corta as sobras pra foto não ficar esticada
        // e fica guardada pra não ter que gerar de novo.
        public static Image MiniaturaDoPonto(PontoTuristico ponto, int largura, int altura)
        {
            string chave = "mini_" + ponto.Id + "_" + largura + "x" + altura;

            if (!fotosAbertas.ContainsKey(chave))
                fotosAbertas[chave] = PreencherEspaco(FotoDoPonto(ponto), largura, altura);

            return fotosAbertas[chave];
        }

        // Aumenta ou diminui a foto pra caber inteira no espaço, sem esticar.
        // A conta é feita uma vez só, com qualidade alta, e a foto já vai pronta pro PictureBox.
        public static Bitmap AjustarParaCaber(Image original, int largura, int altura)
        {
            if (largura < 1) largura = 1;
            if (altura < 1) altura = 1;

            double escalaLargura = (double)largura / original.Width;
            double escalaAltura = (double)altura / original.Height;

            // usa a menor escala, pra foto caber inteira
            double escala = escalaLargura;
            if (escalaAltura < escala)
                escala = escalaAltura;

            int novaLargura = (int)(original.Width * escala);
            int novaAltura = (int)(original.Height * escala);
            if (novaLargura < 1) novaLargura = 1;
            if (novaAltura < 1) novaAltura = 1;

            return Redimensionar(original, novaLargura, novaAltura);
        }

        // Aumenta ou diminui a foto pra cobrir o espaço inteiro, sem esticar.
        // O que sobra nas bordas é cortado (usado no fundo da tela inicial).
        public static Bitmap PreencherEspaco(Image original, int largura, int altura)
        {
            double escalaLargura = (double)largura / original.Width;
            double escalaAltura = (double)altura / original.Height;

            // usa a maior escala, pra não sobrar borda
            double escala = escalaLargura;
            if (escalaAltura > escala)
                escala = escalaAltura;

            int novaLargura = (int)(original.Width * escala) + 1;
            int novaAltura = (int)(original.Height * escala) + 1;

            // centraliza: a sobra fica metade de cada lado
            int x = (largura - novaLargura) / 2;
            int y = (altura - novaAltura) / 2;

            Bitmap nova = new Bitmap(largura, altura);
            using (Graphics g = Graphics.FromImage(nova))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(original, x, y, novaLargura, novaAltura);
            }
            return nova;
        }

        private static Bitmap Redimensionar(Image original, int largura, int altura)
        {
            Bitmap nova = new Bitmap(largura, altura);
            using (Graphics g = Graphics.FromImage(nova))
            {
                // qualidade alta, senão a foto fica serrilhada quando diminui
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(original, 0, 0, largura, altura);
            }
            return nova;
        }

        // Abre uma foto da pasta do app. Se o arquivo não existir, retorna null.
        public static Image? CarregarFoto(string caminhoRelativo)
        {
            if (caminhoRelativo == "")
                return null;

            if (fotosAbertas.ContainsKey(caminhoRelativo))
                return fotosAbertas[caminhoRelativo];

            string caminho = Path.Combine(AppContext.BaseDirectory, caminhoRelativo);
            if (!File.Exists(caminho))
                return null;

            Image foto;
            using (Image imagemDoArquivo = Image.FromFile(caminho))
            {
                // foto muito grande deixa o app pesado, então diminui pra no máximo 1600 de largura
                int largura = imagemDoArquivo.Width;
                int altura = imagemDoArquivo.Height;
                if (largura > 1600)
                {
                    altura = altura * 1600 / largura;
                    largura = 1600;
                }

                // copia a foto e fecha o arquivo (senão o Windows deixa ele travado)
                foto = Redimensionar(imagemDoArquivo, largura, altura);
            }

            fotosAbertas[caminhoRelativo] = foto;
            return foto;
        }
    }
}
