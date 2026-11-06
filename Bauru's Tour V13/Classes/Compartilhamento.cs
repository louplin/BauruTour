using BaurusTour.Models;

namespace BaurusTour.Classes
{
    // Monta a mensagem e os links de compartilhamento de um ponto.
    // Fica numa classe separada porque é usada em duas telas (Detalhe e Compartilhar).
    public static class Compartilhamento
    {
        public static string Mensagem(PontoTuristico ponto)
        {
            return "Olha esse lugar em Bauru que eu achei no Bauru's Tour: " + ponto.Nome + "\r\n"
                 + "Endereço: " + ponto.Endereco + "\r\n"
                 + "Localização no Google Maps: " + ponto.LinkMaps;
        }

        // Abre o WhatsApp (app ou WhatsApp Web) com a mensagem já escrita
        public static string LinkWhatsApp(PontoTuristico ponto)
        {
            return "https://wa.me/?text=" + Uri.EscapeDataString(Mensagem(ponto));
        }

        // Abre a tela de compartilhar do Facebook com o link do Google Maps
        public static string LinkFacebook(PontoTuristico ponto)
        {
            return "https://www.facebook.com/sharer/sharer.php?u=" + Uri.EscapeDataString(ponto.LinkMaps);
        }
    }
}
