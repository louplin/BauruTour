using System.Text.Json;

namespace BaurusTour.Services
{
    /// <summary>
    /// Guarda os pontos favoritados (pelo Id) num arquivo JSON dentro da pasta
    /// AppData do usuário, então os favoritos continuam lá quando o app é aberto de novo.
    /// </summary>
    public class FavoritosService
    {
        private List<int> _favoritos = new List<int>();

        private readonly string _caminho = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "BaurusTour",
            "favoritos.json");

        /// <summary>Avisa as telas sempre que um favorito é adicionado ou removido.</summary>
        public event EventHandler? FavoritosAlterados;

        public FavoritosService()
        {
            Carregar();
        }

        public IReadOnlyCollection<int> Ids => _favoritos.AsReadOnly();

        public int Quantidade => _favoritos.Count;

        public bool EhFavorito(int id)
        {
            return _favoritos.Contains(id);
        }

        /// <summary>
        /// Se o ponto já é favorito, remove. Se não é, adiciona.
        /// Retorna true quando o ponto ficou favoritado.
        /// </summary>
        public bool Alternar(int id)
        {
            bool ficouFavorito;

            if (EhFavorito(id))
            {
                _favoritos.Remove(id);
                ficouFavorito = false;
            }
            else
            {
                _favoritos.Add(id);
                ficouFavorito = true;
            }

            Salvar();
            FavoritosAlterados?.Invoke(this, EventArgs.Empty);
            return ficouFavorito;
        }

        private void Carregar()
        {
            if (!File.Exists(_caminho))
                return;

            try
            {
                string json = File.ReadAllText(_caminho);
                _favoritos = JsonSerializer.Deserialize<List<int>>(json) ?? new List<int>();
            }
            catch (JsonException)
            {
                // Arquivo estragado: começa com a lista vazia
                _favoritos = new List<int>();
            }
            catch (IOException)
            {
                _favoritos = new List<int>();
            }
        }

        private void Salvar()
        {
            try
            {
                string? pasta = Path.GetDirectoryName(_caminho);
                if (!string.IsNullOrEmpty(pasta))
                    Directory.CreateDirectory(pasta);

                File.WriteAllText(_caminho, JsonSerializer.Serialize(_favoritos));
            }
            catch (IOException)
            {
                // Se não der pra salvar, o favorito continua valendo enquanto o app estiver aberto
            }
            catch (UnauthorizedAccessException)
            {
            }
        }
    }
}
