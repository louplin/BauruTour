using System.Globalization;
using System.Text;
using BaurusTour.Data;
using BaurusTour.Models;

namespace BaurusTour.Services
{
    /// <summary>
    /// Regras de busca e filtro dos pontos turísticos.
    /// </summary>
    public class PontoTuristicoService
    {
        public const string TodasAsCategorias = "Todos";

        private readonly List<PontoTuristico> _pontos;

        public PontoTuristicoService(PontoTuristicoRepository repositorio)
        {
            _pontos = repositorio.ObterTodos();
        }

        public List<PontoTuristico> ListarTodos()
        {
            return _pontos.ToList();
        }

        public PontoTuristico? BuscarPorId(int id)
        {
            return _pontos.FirstOrDefault(p => p.Id == id);
        }

        public List<PontoTuristico> BuscarPorNome(string texto)
        {
            return Pesquisar(texto, TodasAsCategorias, null);
        }

        public List<PontoTuristico> FiltrarPorCategoria(string categoria)
        {
            return Pesquisar(string.Empty, categoria, null);
        }

        public List<string> ListarCategorias()
        {
            return _pontos
                .Select(p => p.Categoria)
                .Distinct()
                .OrderBy(c => c)
                .ToList();
        }

        /// <summary>
        /// Busca completa usada pela tela: filtra por texto (nome, categoria, endereço
        /// e descrição, sem diferenciar acentos e maiúsculas), por categoria e,
        /// opcionalmente, apenas pelos ids informados (usado na aba Favoritos).
        /// </summary>
        public List<PontoTuristico> Pesquisar(string texto, string categoria, ICollection<int>? somenteIds)
        {
            string termo = Normalizar(texto);

            IEnumerable<PontoTuristico> resultado = _pontos;

            if (somenteIds != null)
                resultado = resultado.Where(p => somenteIds.Contains(p.Id));

            if (!string.IsNullOrWhiteSpace(categoria) &&
                !categoria.Equals(TodasAsCategorias, StringComparison.OrdinalIgnoreCase))
            {
                resultado = resultado.Where(p => p.Categoria.Equals(categoria, StringComparison.OrdinalIgnoreCase));
            }

            if (termo.Length > 0)
            {
                resultado = resultado.Where(p =>
                    Normalizar(p.Nome).Contains(termo) ||
                    Normalizar(p.Categoria).Contains(termo) ||
                    Normalizar(p.Endereco).Contains(termo) ||
                    Normalizar(p.Descricao).Contains(termo));
            }

            // Quem tem o termo no nome aparece primeiro
            return resultado
                .OrderByDescending(p => termo.Length > 0 && Normalizar(p.Nome).Contains(termo))
                .ThenBy(p => p.Id)
                .ToList();
        }

        /// <summary>
        /// Deixa o texto em minúsculas e sem acentos: "Zoológico" vira "zoologico".
        /// Assim a pessoa acha o lugar mesmo digitando sem acento.
        /// </summary>
        private static string Normalizar(string? texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
                return string.Empty;

            string decomposto = texto.Trim().ToLowerInvariant().Normalize(NormalizationForm.FormD);
            var sb = new StringBuilder(decomposto.Length);

            foreach (char c in decomposto)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                    sb.Append(c);
            }

            return sb.ToString().Normalize(NormalizationForm.FormC);
        }
    }
}
