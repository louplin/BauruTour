using System.Text.Json;
using BaurusTour.Models;

namespace BaurusTour.Data
{
    /// <summary>
    /// Responsável apenas por ler o arquivo pontos.json do disco.
    /// </summary>
    public class PontoTuristicoRepository
    {
        private readonly string _caminhoArquivo;

        public PontoTuristicoRepository(string caminhoArquivo)
        {
            _caminhoArquivo = caminhoArquivo;
        }

        /// <summary>Mensagem do último erro de leitura (vazia quando deu tudo certo).</summary>
        public string UltimoErro { get; private set; } = string.Empty;

        public List<PontoTuristico> ObterTodos()
        {
            UltimoErro = string.Empty;

            if (!File.Exists(_caminhoArquivo))
            {
                UltimoErro = "Não encontrei o arquivo de dados em:\n" + _caminhoArquivo;
                return new List<PontoTuristico>();
            }

            try
            {
                string json = File.ReadAllText(_caminhoArquivo);

                var opcoes = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                return JsonSerializer.Deserialize<List<PontoTuristico>>(json, opcoes)
                       ?? new List<PontoTuristico>();
            }
            catch (JsonException ex)
            {
                UltimoErro = "O arquivo pontos.json tem um erro de formatação:\n" + ex.Message;
                return new List<PontoTuristico>();
            }
            catch (IOException ex)
            {
                UltimoErro = "Não foi possível ler o arquivo pontos.json:\n" + ex.Message;
                return new List<PontoTuristico>();
            }
        }
    }
}
