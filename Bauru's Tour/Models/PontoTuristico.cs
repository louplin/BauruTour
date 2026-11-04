namespace BaurusTour.Models
{
    /// <summary>
    /// Representa um ponto turístico lido do arquivo pontos.json.
    /// Os nomes das propriedades são iguais às chaves do JSON.
    /// </summary>
    public class PontoTuristico
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public string Imagem { get; set; } = string.Empty;
        public string Categoria { get; set; } = string.Empty;
        public string Endereco { get; set; } = string.Empty;
        public string LinkMaps { get; set; } = string.Empty;
    }
}
