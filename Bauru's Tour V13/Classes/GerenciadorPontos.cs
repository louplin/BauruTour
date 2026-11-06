using System.Text.Json;
using BaurusTour.Models;

namespace BaurusTour.Classes
{
    // Lê os pontos do arquivo pontos.json e faz a busca/filtro
    public class GerenciadorPontos
    {
        private List<PontoTuristico> pontos = new List<PontoTuristico>();

        // Fica vazia se deu tudo certo ao ler o arquivo
        public string MensagemErro { get; private set; } = "";

        public GerenciadorPontos(string caminhoArquivo)
        {
            CarregarArquivo(caminhoArquivo);
        }

        private void CarregarArquivo(string caminhoArquivo)
        {
            if (!File.Exists(caminhoArquivo))
            {
                MensagemErro = "Não encontrei o arquivo de dados em:\n" + caminhoArquivo;
                return;
            }

            try
            {
                string json = File.ReadAllText(caminhoArquivo);

                var opcoes = new JsonSerializerOptions();
                opcoes.PropertyNameCaseInsensitive = true;

                List<PontoTuristico>? lista = JsonSerializer.Deserialize<List<PontoTuristico>>(json, opcoes);
                if (lista != null)
                    pontos = lista;
            }
            catch (Exception ex)
            {
                MensagemErro = "Não foi possível ler o arquivo pontos.json:\n" + ex.Message;
            }
        }

        public List<PontoTuristico> ListarTodos()
        {
            return pontos;
        }

        // Filtra pelo texto digitado, pela categoria e (na aba Favoritos) pelos ids favoritados.
        // Se somenteIds for null, não filtra por favoritos.
        public List<PontoTuristico> Pesquisar(string texto, string categoria, List<int>? somenteIds)
        {
            string termo = SemAcento(texto);
            List<PontoTuristico> resultado = new List<PontoTuristico>();

            foreach (PontoTuristico ponto in pontos)
            {
                if (somenteIds != null && !somenteIds.Contains(ponto.Id))
                    continue;

                if (categoria != "Todos" && ponto.Categoria != categoria)
                    continue;

                if (termo != "")
                {
                    bool achou = SemAcento(ponto.Nome).Contains(termo)
                              || SemAcento(ponto.Categoria).Contains(termo)
                              || SemAcento(ponto.Endereco).Contains(termo)
                              || SemAcento(ponto.Descricao).Contains(termo);

                    if (!achou)
                        continue;
                }

                resultado.Add(ponto);
            }

            return resultado;
        }

        // Deixa o texto minúsculo e troca as letras acentuadas pelas normais,
        // assim "zoologico" encontra "Zoológico"
        private string SemAcento(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
                return "";

            texto = texto.Trim().ToLower();

            texto = texto.Replace("á", "a").Replace("à", "a").Replace("ã", "a").Replace("â", "a");
            texto = texto.Replace("é", "e").Replace("ê", "e");
            texto = texto.Replace("í", "i");
            texto = texto.Replace("ó", "o").Replace("õ", "o").Replace("ô", "o");
            texto = texto.Replace("ú", "u").Replace("ü", "u");
            texto = texto.Replace("ç", "c");

            return texto;
        }
    }
}
