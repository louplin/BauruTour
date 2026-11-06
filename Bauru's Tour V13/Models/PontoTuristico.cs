namespace BaurusTour.Models
{
    // Um ponto turístico do pontos.json (os nomes das propriedades são iguais às chaves do JSON)
    public class PontoTuristico
    {
        // ---------- Dados principais ----------
        public int Id { get; set; }
        public string Nome { get; set; } = "";
        public string Categoria { get; set; } = "";

        // Texto da seção "Sobre o lugar". Use \n\n no JSON para separar parágrafos.
        public string Descricao { get; set; } = "";

        // ---------- Localização ----------
        public string Endereco { get; set; } = "";

        // Link curto do Google Maps (botão "Abrir no Google Maps" e compartilhar)
        public string LinkMaps { get; set; } = "";

        // O link do mini mapa fica na pasta HtmlMapas, no arquivo mapas.json (pelo Id)

        // ---------- Contato e links ----------
        public string Telefone { get; set; } = "";
        public string Site { get; set; } = "";

        // Perfil do Instagram, ex.: "@coisaboadochefmoa". Vazio = a linha some da tela.
        public string Instagram { get; set; } = "";

        // Gastronomia: link do cardápio. Vazio = o botão abre uma busca pelo cardápio no Google.
        public string LinkCardapio { get; set; } = "";

        // Compras: link da loja online ou do site com as lojas. Vazio = o botão não aparece.
        public string LinkLoja { get; set; } = "";

        // ---------- Preço e horários ----------
        // Preço que aparece na tela (ex.: "Gratuito", "Ingresso varia conforme o jogo")
        public string Preco { get; set; } = "";

        // Destaque grande no card "Quanto custa", ex.: "R$ 15" (vira "A partir de R$ 15").
        // Vazio = o destaque some.
        public string IngressoAPartirDe { get; set; } = "";

        // Horários no formato "08:00". Vazio = não informado ou fechado nesse dia.
        public string AbreSemana { get; set; } = "";
        public string FechaSemana { get; set; } = "";
        public string AbreSabado { get; set; } = "";
        public string FechaSabado { get; set; } = "";
        public string AbreDomingo { get; set; } = "";
        public string FechaDomingo { get; set; } = "";

        // true = fecha na segunda-feira (muitos restaurantes e o SESC fecham)
        public bool FechadoSegunda { get; set; }

        // Texto extra embaixo dos horários, ex.: "Almoço de terça a sexta, das 11h30 às 15h"
        public string ObservacaoHorario { get; set; } = "";

        // ---------- Conteúdo extra ----------
        public List<string> OQueFazer { get; set; } = new List<string>();
        public List<string> Dicas { get; set; } = new List<string>();

        // Ids de outros pontos do app que ficam perto deste
        public List<int> LugaresPerto { get; set; } = new List<int>();

        // ---------- Fotos ----------
        // Foto principal (ex.: "Imagens/Pontos/parque-vitoria-regia.jpg")
        public string Imagem { get; set; } = "";

        // Fotos extras da galeria (ex.: "Imagens/Pontos/parque-vitoria-regia-2.jpg")
        public List<string> Fotos { get; set; } = new List<string>();
    }
}
