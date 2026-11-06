using System.Text.Json;

namespace BaurusTour.Classes
{
    // Guarda a nota (1 a 5 estrelas) que o usuário deu para cada ponto.
    // Funciona igual aos favoritos: salva num arquivo na pasta AppData.
    public class GerenciadorAvaliacoes
    {
        // chave = id do ponto, valor = nota
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

        // Retorna 0 se o ponto ainda não foi avaliado
        public int NotaDoPonto(int id)
        {
            if (notas.ContainsKey(id))
                return notas[id];

            return 0;
        }

        // Quantos lugares receberam essa nota (usado nas barrinhas da tela de detalhes)
        public int QuantidadeComNota(int nota)
        {
            int quantidade = 0;
            foreach (int valor in notas.Values)
            {
                if (valor == nota)
                    quantidade++;
            }
            return quantidade;
        }

        public int TotalAvaliados()
        {
            return notas.Count;
        }

        public void Avaliar(int id, int nota)
        {
            notas[id] = nota;
            Salvar();
        }

        // Apaga a nota que o usuário deu para o ponto
        public void Remover(int id)
        {
            if (notas.Remove(id))
                Salvar();
        }

        // Nome de cada nota, usado embaixo das estrelas
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
                // se não conseguir salvar, a nota vale só enquanto o app estiver aberto
            }
        }
    }
}
