namespace BaurusTour.Models
{
    // Um ponto turístico do pontos.json (os nomes são iguais às chaves do JSON)
    public class PontoTuristico
    {
        public int Id { get; set; }
        public string Nome { get; set; } = "";
        public string Descricao { get; set; } = "";
        public List<string> Imagens { get; set; } = new();
        public string Categoria { get; set; } = "";
        public string Endereco { get; set; } = "";
        public string LinkMaps { get; set; } = "";
    }
}
