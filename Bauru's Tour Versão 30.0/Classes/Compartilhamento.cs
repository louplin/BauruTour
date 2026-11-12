using BaurusTour.Modelos;

namespace BaurusTour.Classes
{
    // Mensagem e links de compartilhar (usados na tela de detalhes e na de compartilhar)
    public static class Compartilhamento
    {
        public static string Mensagem(PontoTuristico ponto)
        {
            return "Olha esse lugar em Bauru que eu achei no Bauru's Tour: " + ponto.Nome + "\r\n"
                 + "Endereço: " + ponto.Endereco + "\r\n"
                 + "Localização no Google Maps: " + ponto.LinkMaps;
        }

        // EscapeDataString troca espaço e acento por códigos que funcionam dentro de um link
        public static string LinkWhatsApp(PontoTuristico ponto)
        {
            return "https://wa.me/?text=" + Uri.EscapeDataString(Mensagem(ponto));
        }

        public static string LinkFacebook(PontoTuristico ponto)
        {
            return "https://www.facebook.com/sharer/sharer.php?u=" + Uri.EscapeDataString(ponto.LinkMaps);
        }
    }
}
