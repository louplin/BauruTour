using System.Text.Json;

namespace BaurusTour.Classes
{
    // Guarda as notas (1 a 5) que a pessoa deu pros lugares.
    // Funciona igual aos favoritos: salva num arquivo dentro do AppData.
    public class GerenciadorAvaliacoes
    {
        // id do lugar -> nota
        private Dictionary<int, int> notas = new Dictionary<int, int>();

        private string pasta;
        private string caminhoArquivo;

        public GerenciadorAvaliacoes()
        {
            string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            pasta = Path.Combine(appData, "BaurusTour");
            caminhoArquivo = Path.Combine(pasta, "avaliacoes.json");

            Carregar();
        }

        // 0 = ainda não avaliou
        public int NotaDoPonto(int id)
        {
            if (notas.ContainsKey(id))
                return notas[id];

            return 0;
        }

        public void Avaliar(int id, int nota)
        {
            notas[id] = nota;
            Salvar();
        }

        public void Remover(int id)
        {
            notas.Remove(id);
            Salvar();
        }

        public static string NomeDaNota(int nota)
        {
            switch (nota)
            {
                case 1: return "Não gostei";
                case 2: return "Razoável";
                case 3: return "Bom";
                case 4: return "Muito bom";
                case 5: return "Incrível!";
                default: return "";
            }
        }

        private void Carregar()
        {
            if (!File.Exists(caminhoArquivo))
                return;

            try
            {
                string json = File.ReadAllText(caminhoArquivo);
                Dictionary<int, int>? lido = JsonSerializer.Deserialize<Dictionary<int, int>>(json);
                if (lido != null)
                    notas = lido;
            }
            catch (Exception)
            {
                notas = new Dictionary<int, int>();
            }
        }

        private void Salvar()
        {
            try
            {
                Directory.CreateDirectory(pasta);
                File.WriteAllText(caminhoArquivo, JsonSerializer.Serialize(notas));
            }
            catch (Exception)
            {
                // se der erro pra salvar, a nota só fica valendo até fechar o app
            }
        }
    }
}
