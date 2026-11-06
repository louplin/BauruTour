using System.Text.Json;
using BaurusTour.Models;

namespace BaurusTour.HtmlMapas
{
    // Um item do arquivo mapas.json: qual lugar (Id) usa qual link de mapa
    public class LinkDoMapa
    {
        public int Id { get; set; }
        public string Nome { get; set; } = "";
        public string LinkMapa { get; set; } = "";
    }

    // Monta a página HTML do mini mapa da tela de detalhes.
    //
    // Caminho do mapa até a tela:
    //   pontos.json (Id do lugar)
    //     -> mapas.json (LinkMapa daquele Id)
    //     -> modelo-mapa.html ({{LINK_DO_MAPA}} vira o link)
    //     -> MontarPagina() junta tudo
    //     -> o FormDetalhe mostra no controle webMapa (WebView2)
    public static class MapaHtml
    {
        // Os arquivos desta pasta vão junto com o .exe (veja o BaurusTour.csproj)
        private static string pasta = Path.Combine(AppContext.BaseDirectory, "HtmlMapas");

        // Os links são lidos do mapas.json uma vez só e ficam guardados aqui
        private static List<LinkDoMapa>? links;

        // Usado se o arquivo modelo-mapa.html não for encontrado
        private const string ModeloReserva =
            "<!DOCTYPE html><html><head><meta charset='utf-8'><style>"
          + "html, body { margin: 0; height: 100%; overflow: hidden; } iframe { border: 0; width: 100%; height: 100%; }"
          + "</style></head><body><iframe src='{{LINK_DO_MAPA}}' allowfullscreen></iframe></body></html>";

        // A página completa que o WebView2 vai mostrar
        public static string MontarPagina(PontoTuristico ponto)
        {
            string modelo = ModeloReserva;
            string caminhoModelo = Path.Combine(pasta, "modelo-mapa.html");

            if (File.Exists(caminhoModelo))
                modelo = File.ReadAllText(caminhoModelo);

            return modelo.Replace("{{LINK_DO_MAPA}}", LinkDoPonto(ponto));
        }

        // Link do mapa do lugar: o do mapas.json, ou um montado pelo nome + endereço
        public static string LinkDoPonto(PontoTuristico ponto)
        {
            foreach (LinkDoMapa item in CarregarLinks())
            {
                if (item.Id == ponto.Id)
                {
                    string link = ExtrairSrc(item.LinkMapa);
                    if (link != "")
                        return link;
                }
            }

            string pesquisa = ponto.Nome + ", " + ponto.Endereco;
            return "https://maps.google.com/maps?q=" + Uri.EscapeDataString(pesquisa)
                 + "&z=16&hl=pt-BR&output=embed";
        }

        // Link que abre a rota (como chegar) até o lugar no Google Maps
        public static string LinkDaRota(PontoTuristico ponto)
        {
            string destino = ponto.Nome + ", " + ponto.Endereco;
            return "https://www.google.com/maps/dir/?api=1&destination=" + Uri.EscapeDataString(destino);
        }

        private static List<LinkDoMapa> CarregarLinks()
        {
            if (links != null)
                return links;

            links = new List<LinkDoMapa>();
            string caminho = Path.Combine(pasta, "mapas.json");

            if (!File.Exists(caminho))
                return links;

            try
            {
                var opcoes = new JsonSerializerOptions();
                opcoes.PropertyNameCaseInsensitive = true;

                List<LinkDoMapa>? lidos = JsonSerializer.Deserialize<List<LinkDoMapa>>(File.ReadAllText(caminho), opcoes);
                if (lidos != null)
                    links = lidos;
            }
            catch (Exception)
            {
                // Se o arquivo estiver com erro, os mapas são montados pelo nome + endereço
            }

            return links;
        }

        // Aceita o link puro ou o <iframe ...> inteiro copiado do Google Maps.
        // Do <iframe>, pega só o que está dentro de src="..."
        private static string ExtrairSrc(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
                return "";

            texto = texto.Trim();
            if (texto.StartsWith("http"))
                return texto;

            int inicio = texto.IndexOf("src=\"");
            if (inicio < 0)
                return "";

            inicio = inicio + 5;
            int fim = texto.IndexOf("\"", inicio);
            if (fim < 0)
                return "";

            return texto.Substring(inicio, fim - inicio);
        }
    }
}
