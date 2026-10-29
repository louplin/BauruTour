namespace BaurusTour.Utilitarios
{
    /// <summary>
    /// Cores usadas em todas as telas, num lugar só. Se quiser mudar a cara do app,
    /// é só mexer aqui.
    /// </summary>
    public static class Tema
    {
        public static readonly Color Fundo = Color.FromArgb(247, 248, 246);
        public static readonly Color Branco = Color.White;
        public static readonly Color AzulMarinho = Color.FromArgb(13, 43, 94);
        public static readonly Color Primaria = Color.FromArgb(11, 107, 138);
        public static readonly Color PrimariaEscura = Color.FromArgb(7, 84, 110);
        public static readonly Color PrimariaClara = Color.FromArgb(228, 241, 245);
        public static readonly Color Texto = Color.FromArgb(40, 48, 60);
        public static readonly Color TextoSecundario = Color.FromArgb(88, 98, 112);
        public static readonly Color Borda = Color.FromArgb(220, 226, 230);
        public static readonly Color Coracao = Color.FromArgb(226, 72, 80);
        public static readonly Color CoracaoClaro = Color.FromArgb(253, 236, 237);
        public static readonly Color Sucesso = Color.FromArgb(22, 128, 72);
        public static readonly Color WhatsApp = Color.FromArgb(18, 140, 96);

        /// <summary>Cor de fundo e cor do texto da etiqueta de cada categoria.</summary>
        public static (Color fundo, Color texto) CoresDaCategoria(string categoria)
        {
            switch (categoria.Trim().ToLowerInvariant())
            {
                case "natureza":
                    return (Color.FromArgb(225, 244, 232), Color.FromArgb(28, 118, 68));
                case "gastronomia":
                    return (Color.FromArgb(255, 237, 220), Color.FromArgb(176, 82, 8));
                case "lazer e cultura":
                    return (Color.FromArgb(253, 230, 233), Color.FromArgb(182, 34, 56));
                case "compras":
                    return (Color.FromArgb(238, 233, 252), Color.FromArgb(94, 58, 176));
                default:
                    return (PrimariaClara, Primaria);
            }
        }
    }

    /// <summary>
    /// Códigos dos ícones da fonte "Segoe MDL2 Assets", que já vem no Windows 10 e 11.
    /// </summary>
    public static class Icones
    {
        public const string Fonte = "Segoe MDL2 Assets";

        public const string Inicio = "";
        public const string Mapa = "";
        public const string Coracao = "";
        public const string CoracaoCheio = "";
        public const string Informacao = "";
        public const string Buscar = "";
        public const string SetaDireita = "";
        public const string Voltar = "";
        public const string TelaCheia = "";
        public const string SairTelaCheia = "";
        public const string Compartilhar = "";
        public const string Copiar = "";
        public const string Enviar = "";
        public const string Documento = "";
        public const string Link = "";
    }
}
