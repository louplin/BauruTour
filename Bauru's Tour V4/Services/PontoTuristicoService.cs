using System.Globalization;
using System.Text;
using BaurusTour.Data;
using BaurusTour.Models;

namespace BaurusTour.Services
{
    /// <summary>
    /// Busca e filtro dos pontos turísticos.
    /// </summary>
    public class PontoTuristicoService
    {
        private readonly List<PontoTuristico> _pontos;

        public PontoTuristicoService(PontoTuristicoRepository repositorio)
        {
            _pontos = repositorio.ObterTodos();
        }

        public List<PontoTuristico> ListarTodos()
        {
            return _pontos;
        }

        /// <summary>
        /// Filtra os pontos pelo texto digitado, pela categoria escolhida e,
        /// se for a aba Favoritos, só pelos ids favoritados.
        /// </summary>
        public List<PontoTuristico> Pesquisar(string texto, string categoria, List<int>? somenteIds)
        {
            string termo = SemAcento(texto);
            var resultado = new List<PontoTuristico>();

            foreach (PontoTuristico ponto in _pontos)
            {
                // Aba Favoritos: pula quem não está favoritado
                if (somenteIds != null && !somenteIds.Contains(ponto.Id))
                    continue;

                // Categoria: "Todos" mostra tudo
                if (categoria != "Todos" && ponto.Categoria != categoria)
                    continue;

                // Texto: procura no nome, na categoria, no endereço e na descrição
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

        /// <summary>
        /// Deixa o texto minúsculo e sem acento: "Zoológico" vira "zoologico".
        /// Assim a busca funciona mesmo se a pessoa digitar sem acento.
        /// </summary>
        private static string SemAcento(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
                return "";

            string separado = texto.Trim().ToLower().Normalize(NormalizationForm.FormD);
            var sb = new StringBuilder();

            foreach (char letra in separado)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(letra) != UnicodeCategory.NonSpacingMark)
                    sb.Append(letra);
            }

            return sb.ToString();
        }
    }
}
