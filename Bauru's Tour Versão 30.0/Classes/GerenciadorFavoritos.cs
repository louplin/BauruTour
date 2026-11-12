using System.Text.Json;

namespace BaurusTour.Classes
{
    // Guarda os ids dos favoritos num arquivo no AppData,
    // assim eles continuam lá quando abre o app de novo
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

        // se já é favorito tira, se não é coloca
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
                // se der erro pra salvar, o favorito só fica valendo até fechar o app
            }
        }
    }
}
