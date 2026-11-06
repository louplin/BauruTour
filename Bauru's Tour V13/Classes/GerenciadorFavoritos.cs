using System.Text.Json;

namespace BaurusTour.Classes
{
    // Guarda os ids dos pontos favoritos num arquivo na pasta AppData do usuário,
    // assim eles continuam salvos quando o app é aberto de novo
    public class GerenciadorFavoritos
    {
        private List<int> favoritos = new List<int>();

        private string pasta;
        private string caminhoArquivo;

        public GerenciadorFavoritos()
        {
            string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            pasta = Path.Combine(appData, "BaurusTour");
            caminhoArquivo = Path.Combine(pasta, "favoritos.json");

            Carregar();
        }

        public List<int> Ids
        {
            get { return favoritos; }
        }

        public bool EhFavorito(int id)
        {
            return favoritos.Contains(id);
        }

        // Se já é favorito, tira. Se não é, coloca.
        public void Alternar(int id)
        {
            if (EhFavorito(id))
                favoritos.Remove(id);
            else
                favoritos.Add(id);

            Salvar();
        }

        private void Carregar()
        {
            if (!File.Exists(caminhoArquivo))
                return;

            try
            {
                string json = File.ReadAllText(caminhoArquivo);
                List<int>? lista = JsonSerializer.Deserialize<List<int>>(json);
                if (lista != null)
                    favoritos = lista;
            }
            catch (Exception)
            {
                // arquivo com problema: começa com a lista vazia
                favoritos = new List<int>();
            }
        }

        private void Salvar()
        {
            try
            {
                Directory.CreateDirectory(pasta);
                File.WriteAllText(caminhoArquivo, JsonSerializer.Serialize(favoritos));
            }
            catch (Exception)
            {
                // se não conseguir salvar, o favorito vale só enquanto o app estiver aberto
            }
        }
    }
}
