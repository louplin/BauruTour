using System.Text.Json;

namespace BaurusTour.Services
{
    /// <summary>
    /// Guarda os ids dos pontos favoritados num arquivo dentro da pasta AppData
    /// do usuário. Assim os favoritos continuam lá quando o app abre de novo.
    /// </summary>
    public class FavoritosService
    {
        private List<int> _favoritos = new List<int>();

        private readonly string _caminho = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "BaurusTour",
            "favoritos.json");

        public FavoritosService()
        {
            Carregar();
        }

        public List<int> Ids => _favoritos;

        public bool EhFavorito(int id)
        {
            return _favoritos.Contains(id);
        }

        /// <summary>Se já é favorito, tira. Se não é, coloca.</summary>
        public void Alternar(int id)
        {
            if (EhFavorito(id))
                _favoritos.Remove(id);
            else
                _favoritos.Add(id);

            Salvar();
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
            catch (Exception)
            {
                // Arquivo estragado: começa com a lista vazia
                _favoritos = new List<int>();
            }
        }

        private void Salvar()
        {
            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(_caminho)!);
                File.WriteAllText(_caminho, JsonSerializer.Serialize(_favoritos));
            }
            catch (Exception)
            {
                // Se não der pra salvar, o favorito vale enquanto o app estiver aberto
            }
        }
    }
}
