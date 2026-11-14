namespace BaurusTour.Modelos
{
    // Representa um lugar do pontos.json.
    // Os nomes das propriedades têm que ser iguais aos do JSON.
    public class PontoTuristico
    {
        public int Id { get; set; }
        public string Nome { get; set; } = "";
        public string Categoria { get; set; } = "";
        public string Descricao { get; set; } = "";

        // história e curiosidades do lugar. Vazio = a parte some.
        public string Curiosidades { get; set; } = "";

        // ficha rápida, ex.: "Inauguração: 24 de agosto de 1980"
        public List<string> Ficha { get; set; } = new List<string>();

        // de onde vieram as informações
        public List<string> Fontes { get; set; } = new List<string>();

        public string Endereco { get; set; } = "";
        public string LinkMaps { get; set; } = "";

        public string Telefone { get; set; } = "";
        public string Site { get; set; } = "";
        public string Instagram { get; set; } = "";
        public string LinkCardapio { get; set; } = "";
        public string LinkLoja { get; set; } = "";

        public string Preco { get; set; } = "";
        public string IngressoAPartirDe { get; set; } = "";

        // horários no formato "08:00" (vazio = fechado ou não sabemos)
        public string AbreSemana { get; set; } = "";
        public string FechaSemana { get; set; } = "";
        public string AbreSabado { get; set; } = "";
        public string FechaSabado { get; set; } = "";
        public string AbreDomingo { get; set; } = "";
        public string FechaDomingo { get; set; } = "";
        public bool FechadoSegunda { get; set; }
        public string ObservacaoHorario { get; set; } = "";

        public List<string> OQueFazer { get; set; } = new List<string>();
        public List<string> Dicas { get; set; } = new List<string>();

        // ids de outros lugares que ficam perto
        public List<int> LugaresPerto { get; set; } = new List<int>();

        public string Imagem { get; set; } = "";
        public List<string> Fotos { get; set; } = new List<string>();
    }
}
