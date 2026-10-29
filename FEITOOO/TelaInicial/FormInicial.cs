using System.Drawing.Drawing2D;
using System.Drawing.Text;
using BaurusTour.TelaBusca;
using BaurusTour.Utilitarios;

namespace BaurusTour.TelaInicial
{
    /// <summary>
    /// Tela de boas-vindas: o planeta com Bauru marcado, o botão de começar
    /// e o botão que abre o guia de uso em PDF.
    ///
    /// O app começa por aqui: o método Main fica nesta classe, então o projeto
    /// não precisa de Program.cs.
    /// </summary>
    public partial class FormInicial : Form
    {
        private const string CaminhoGuiaPdf = @"Manual\Guia-de-uso-Bauru-Tour.pdf";

        // Tamanho do espaço em que o desenho foi criado
        private const float Largura = 380f;
        private const float Altura = 290f;

        private static readonly Color Ouro = Color.FromArgb(201, 169, 106);
        private static readonly Color Branco = Color.FromArgb(243, 244, 246);

        // Escala e deslocamento são calculados conforme o tamanho da janela
        private float _escala = 2f;
        private float _deslocX;
        private float _deslocY;

        // Fontes criadas por nós (somente elas podem receber Dispose)
        private Font? _fonteComecar;
        private Font? _fonteGuia;

        /// <summary>Ponto de entrada do programa.</summary>
        [STAThread]
        private static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormInicial());
        }

        public FormInicial()
        {
            InitializeComponent();
            ResizeRedraw = true; // repinta o desenho quando a janela muda de tamanho
        }

        private void FormInicial_Load(object? sender, EventArgs e)
        {
            Icon = CarregadorImagens.IconeDoApp ?? Icon;
            Reajustar();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Reajustar();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            _fonteComecar?.Dispose();
            _fonteGuia?.Dispose();
            _fonteComecar = null;
            _fonteGuia = null;
        }

        // ------------------------------------------------------------------ botões

        private void btnComecar_Click(object? sender, EventArgs e)
        {
            var telaBusca = new FormBusca();

            // Quando a tela de busca fechar, o app inteiro fecha
            telaBusca.FormClosed += (s, args) => Close();

            if (ControleTelaCheia.EstaEmTelaCheia(this))
                telaBusca.Load += (s, args) => ControleTelaCheia.Entrar(telaBusca);

            telaBusca.Show();
            Hide();
        }

        private void btnGuiaUso_Click(object? sender, EventArgs e)
        {
            AbridorLinks.AbrirArquivo(CaminhoGuiaPdf, this);
        }

        private void btnTelaCheia_Click(object? sender, EventArgs e)
        {
            AlternarTelaCheia();
        }

        private void AlternarTelaCheia()
        {
            ControleTelaCheia.Alternar(this);

            bool emTelaCheia = ControleTelaCheia.EstaEmTelaCheia(this);
            btnTelaCheia.Text = emTelaCheia ? "Sair da tela cheia" : "Tela cheia";
            btnTelaCheia.Icone = emTelaCheia ? Icones.SairTelaCheia : Icones.TelaCheia;
        }

        private void FormInicial_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11)
            {
                AlternarTelaCheia();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                if (ControleTelaCheia.EstaEmTelaCheia(this))
                    AlternarTelaCheia();
                else
                    Close();

                e.Handled = true;
            }
        }

        // ------------------------------------------------------------------ layout

        /// <summary>Recalcula escala, centralização e posição/tamanho/fonte dos botões.</summary>
        private void Reajustar()
        {
            if (btnComecar == null || btnGuiaUso == null)
                return;
            if (ClientSize.Width <= 0 || ClientSize.Height <= 0)
                return; // minimizado

            _escala = Math.Min(ClientSize.Width / Largura, ClientSize.Height / Altura);
            _deslocX = (ClientSize.Width - Largura * _escala) / 2f;
            _deslocY = (ClientSize.Height - Altura * _escala) / 2f;

            float s = _escala;

            btnComecar.Bounds = new Rectangle(
                (int)(_deslocX + 100.5f * s), (int)(_deslocY + 128f * s),
                (int)(179 * s), (int)(32 * s));
            btnComecar.Raio = (int)(16 * s);

            btnGuiaUso.Bounds = new Rectangle(
                (int)(_deslocX + 120f * s), (int)(_deslocY + 166f * s),
                (int)(140 * s), (int)(20 * s));
            btnGuiaUso.Raio = (int)(10 * s);

            TrocarFonte(btnComecar, ref _fonteComecar, 12.5f * s);
            TrocarFonte(btnGuiaUso, ref _fonteGuia, 7.5f * s);

            Invalidate();
        }

        /// <summary>
        /// Troca a fonte do botão só quando o tamanho realmente mudou.
        /// Importante: se a fonte nova for igual à antiga, o Windows Forms ignora a troca
        /// e continua usando a antiga. Se a gente descartasse a antiga nesse caso,
        /// o botão ficaria com uma fonte destruída e o app quebraria ("Parameter is not valid").
        /// </summary>
        private static void TrocarFonte(Control controle, ref Font? fonteAtual, float tamanhoPx)
        {
            if (fonteAtual != null && Math.Abs(fonteAtual.Size - tamanhoPx) < 0.01f)
                return;

            var novaFonte = new Font("Segoe UI", tamanhoPx, FontStyle.Regular, GraphicsUnit.Pixel);
            controle.Font = novaFonte;
            fonteAtual?.Dispose();
            fonteAtual = novaFonte;
        }

        // ------------------------------------------------------------------ desenho

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (ClientSize.Width <= 0 || ClientSize.Height <= 0)
                return;

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;

            // 1) Fundo na tela inteira, ANTES das transformações
            using (var fundo = new LinearGradientBrush(
                       ClientRectangle,
                       Color.FromArgb(4, 7, 13),
                       Color.FromArgb(10, 18, 34),
                       LinearGradientMode.Vertical))
            {
                g.FillRectangle(fundo, ClientRectangle);
            }

            // 2) Centraliza e amplia o desenho (a ordem importa)
            GraphicsState estado = g.Save();
            g.TranslateTransform(_deslocX, _deslocY);
            g.ScaleTransform(_escala, _escala);
            g.TranslateTransform(0, -30);

            DesenharEstrelas(g);
            DesenharTerra(g);
            DesenharTextos(g);

            g.Restore(estado);
        }

        private static void DesenharEstrelas(Graphics g)
        {
            float[][] estrelas =
            {
                new[] {34f, 58f, 0.8f}, new[] {90f, 98f, 0.7f}, new[] {336f, 66f, 0.9f},
                new[] {312f, 128f, 0.7f}, new[] {58f, 170f, 0.7f}, new[] {352f, 176f, 0.8f},
                new[] {150f, 46f, 0.6f}, new[] {262f, 48f, 0.7f}, new[] {22f, 120f, 0.6f}
            };

            using (var pincel = new SolidBrush(Color.FromArgb(115, 255, 255, 255)))
            {
                foreach (float[] estrela in estrelas)
                    g.FillEllipse(pincel, estrela[0] - estrela[2], estrela[1] - estrela[2], estrela[2] * 2, estrela[2] * 2);
            }
        }

        private static void DesenharTerra(Graphics g)
        {
            const float cx = 190f, cy = 520f, r = 300f;

            // Brilho azul da atmosfera
            for (int i = 0; i < 12; i++)
            {
                float rr = r + i * 1.6f;
                int alpha = (int)(80 * (1 - i / 12f));
                using (var caneta = new Pen(Color.FromArgb(alpha, 127, 187, 255), 1.8f))
                    g.DrawEllipse(caneta, cx - rr, cy - rr, rr * 2, rr * 2);
            }

            using (var globo = new GraphicsPath())
            {
                globo.AddEllipse(cx - r, cy - r, r * 2, r * 2);

                // Oceano
                using (var oceano = new PathGradientBrush(globo))
                {
                    oceano.CenterPoint = new PointF(cx, cy - r * 0.88f);
                    oceano.InterpolationColors = new ColorBlend
                    {
                        Colors = new[]
                        {
                            Color.FromArgb(2, 6, 15),
                            Color.FromArgb(10, 38, 71),
                            Color.FromArgb(20, 70, 122)
                        },
                        Positions = new[] { 0f, 0.55f, 1f }
                    };
                    g.FillPath(oceano, globo);
                }

                // Tudo abaixo fica recortado dentro do planeta
                Region recorteAnterior = g.Clip;
                g.SetClip(globo, CombineMode.Intersect);

                // Continentes (formas simplificadas)
                using (var terra = new SolidBrush(Color.FromArgb(18, 33, 27)))
                {
                    PointF[] americaSul =
                    {
                        new PointF(148, 236), new PointF(190, 225), new PointF(234, 238),
                        new PointF(246, 270), new PointF(222, 302), new PointF(202, 332),
                        new PointF(150, 332), new PointF(146, 290), new PointF(138, 252)
                    };
                    PointF[] africa =
                    {
                        new PointF(302, 254), new PointF(340, 250), new PointF(376, 280),
                        new PointF(376, 332), new PointF(320, 332), new PointF(300, 290)
                    };
                    PointF[] americaNorte =
                    {
                        new PointF(4, 264), new PointF(60, 248), new PointF(128, 248),
                        new PointF(106, 294), new PointF(30, 332), new PointF(4, 332)
                    };

                    foreach (PointF[] pontos in new[] { americaSul, africa, americaNorte })
                    {
                        using (var continente = new GraphicsPath())
                        {
                            continente.AddClosedCurve(pontos, 0.5f);
                            g.FillPath(terra, continente);
                        }
                    }
                }

                // Brilho das cidades
                Brilho(g, 212, 272, 22, 140);
                Brilho(g, 86, 284, 14, 90);
                Brilho(g, 338, 290, 12, 76);

                float[][] luzes =
                {
                    new[] {208f, 268f, 1.3f}, new[] {212f, 272f, 1.5f}, new[] {216f, 270f, 1.0f},
                    new[] {210f, 277f, 1.2f}, new[] {218f, 276f, 0.9f}, new[] {205f, 274f, 0.8f},
                    new[] {222f, 280f, 1.0f}, new[] {214f, 284f, 0.9f}, new[] {200f, 282f, 0.8f},
                    new[] {226f, 266f, 0.8f}, new[] {196f, 290f, 0.9f}, new[] {206f, 296f, 0.8f},
                    new[] {188f, 262f, 0.7f}, new[] {176f, 254f, 0.7f},
                    new[] {84f, 282f, 1.2f}, new[] {90f, 286f, 1.0f}, new[] {80f, 290f, 0.9f},
                    new[] {96f, 278f, 0.8f}, new[] {72f, 272f, 0.8f}, new[] {104f, 268f, 0.7f},
                    new[] {60f, 290f, 0.7f},
                    new[] {336f, 288f, 1.1f}, new[] {342f, 294f, 0.9f}, new[] {330f, 280f, 0.8f},
                    new[] {348f, 284f, 0.7f}, new[] {322f, 296f, 0.7f}
                };

                using (var luz = new SolidBrush(Color.FromArgb(255, 213, 138)))
                {
                    foreach (float[] l in luzes)
                        g.FillEllipse(luz, l[0] - l[2], l[1] - l[2], l[2] * 2, l[2] * 2);
                }

                // Sombra do lado direito (noite)
                using (var sombra = new SolidBrush(Color.FromArgb(71, 0, 0, 0)))
                    g.FillEllipse(sombra, 234 - r, cy - r, r * 2, r * 2);

                g.Clip = recorteAnterior;
                recorteAnterior.Dispose();
            }

            // Marcação de Bauru
            using (var caneta = new Pen(Ouro, 0.8f))
                g.DrawEllipse(caneta, 211 - 6, 269 - 6, 12, 12);
        }

        private static void Brilho(Graphics g, float cx, float cy, float r, int alpha)
        {
            using (var caminho = new GraphicsPath())
            {
                caminho.AddEllipse(cx - r, cy - r, r * 2, r * 2);
                using (var pincel = new PathGradientBrush(caminho))
                {
                    pincel.CenterColor = Color.FromArgb(alpha, 255, 201, 120);
                    pincel.SurroundColors = new[] { Color.FromArgb(0, 255, 201, 120) };
                    g.FillPath(pincel, caminho);
                }
            }
        }

        private static void DesenharTextos(Graphics g)
        {
            using (var fonteRotulo = new Font("Segoe UI", 11f, FontStyle.Regular, GraphicsUnit.Pixel))
            using (var fonteTitulo = new Font("Georgia", 32f, FontStyle.Regular, GraphicsUnit.Pixel))
            using (var fonteSubtitulo = new Font("Segoe UI", 12f, FontStyle.Regular, GraphicsUnit.Pixel))
            using (var pincelRotulo = new SolidBrush(Color.FromArgb(154, 167, 189)))
            using (var pincelTitulo = new SolidBrush(Branco))
            using (var pincelSubtitulo = new SolidBrush(Color.FromArgb(139, 152, 174)))
            using (var canetaOuro = new Pen(Ouro, 1f))
            {
                TextoEspacado(g, "BEM-VINDO AO", fonteRotulo, pincelRotulo, 190, 72, 5f);
                TextoEspacado(g, "BAURU'S TOUR", fonteTitulo, pincelTitulo, 190, 108, 4f);
                g.DrawLine(canetaOuro, 170, 122, 210, 122);
                TextoEspacado(g, "Descubra os pontos turísticos de Bauru", fonteSubtitulo, pincelSubtitulo, 190, 144, 0f);
            }
        }

        /// <summary>Escreve texto centralizado com espaço extra entre as letras.</summary>
        private static void TextoEspacado(Graphics g, string texto, Font fonte, Brush pincel,
                                          float centroX, float baseY, float espaco)
        {
            using (var formato = new StringFormat(StringFormat.GenericTypographic))
            {
                formato.FormatFlags |= StringFormatFlags.MeasureTrailingSpaces;

                var larguras = new float[texto.Length];
                float total = 0;
                for (int i = 0; i < texto.Length; i++)
                {
                    larguras[i] = g.MeasureString(texto[i].ToString(), fonte, PointF.Empty, formato).Width;
                    total += larguras[i];
                }
                total += espaco * (texto.Length - 1);

                float x = centroX - total / 2f;
                float y = baseY - fonte.Size * 0.92f;

                for (int i = 0; i < texto.Length; i++)
                {
                    g.DrawString(texto[i].ToString(), fonte, pincel, x, y, formato);
                    x += larguras[i] + espaco;
                }
            }
        }
    }
}
