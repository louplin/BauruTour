using System.Text.Json;
using BaurusTour.Modelos;

namespace BaurusTour.Classes
{
    // Uma linha do mapas.json: o Id do lugar e o link do mapa dele
    public class LinkDoMapa
    {
        public int Id { get; set; }
        public string Nome { get; set; } = "";
        public string LinkMapa { get; set; } = "";
    }

    // Monta a página do mini mapa que aparece na tela de detalhes.
    // Pega o modelo-mapa.html e troca o {{LINK_DO_MAPA}} pelo link do lugar (que está no mapas.json).
    public static class MapaHtml
    {
        private static string pasta = Path.Combine(AppContext.BaseDirectory, "Dados", "Mapas");

        private static List<LinkDoMapa>? links;

        public static string MontarPagina(PontoTuristico ponto)
        {
            string caminhoModelo = Path.Combine(pasta, "modelo-mapa.html");
            string modelo;

            if (File.Exists(caminhoModelo))
            {
                modelo = File.ReadAllText(caminhoModelo);
            }
            else
            {
                // se alguém apagar o modelo, usa um iframe simples
                modelo = "<html><body style='margin:0'><iframe src='{{LINK_DO_MAPA}}' style='border:0;width:100%;height:100%'></iframe></body></html>";
            }

            return modelo.Replace("{{LINK_DO_MAPA}}", LinkDoPonto(ponto));
        }

        // Usa o link do mapas.json. Se não tiver, monta um pesquisando pelo nome e endereço.
        public static string LinkDoPonto(PontoTuristico ponto)
        {
            foreach (LinkDoMapa item in CarregarLinks())
            {
                if (item.Id == ponto.Id)
                {
                    string link = PegarLinkDoIframe(item.LinkMapa);
                    if (link != "")
                        return link;
                }
            }

            string pesquisa = ponto.Nome + ", " + ponto.Endereco;
            return "https://maps.google.com/maps?q=" + Uri.EscapeDataString(pesquisa) + "&z=16&hl=pt-BR&output=embed";
        }

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
                JsonSerializerOptions opcoes = new JsonSerializerOptions();
                opcoes.PropertyNameCaseInsensitive = true;

                List<LinkDoMapa>? lidos = JsonSerializer.Deserialize<List<LinkDoMapa>>(File.ReadAllText(caminho), opcoes);
                if (lidos != null)
                    links = lidos;
            }
            catch (Exception)
            {
                // se o arquivo tiver erro, os mapas são montados pelo nome e endereço
            }

            return links;
        }

        // No mapas.json dá pra colar o link puro ou o <iframe> inteiro que o Google Maps gera.
        // Se for o iframe, pega só o que está dentro de src="..."
        private static string PegarLinkDoIframe(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
                return "";

            texto = texto.Trim();
            if (texto.StartsWith("http"))
                return texto;

            int inicio = texto.IndexOf("src=\"");
            if (inicio < 0)
                return "";

            inicio = inicio + 5;   // pula o src="
            int fim = texto.IndexOf("\"", inicio);
            if (fim < 0)
                return "";

            return texto.Substring(inicio, fim - inicio);
        }
    }
}
