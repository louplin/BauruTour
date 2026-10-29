using System.ComponentModel;
using System.Drawing.Drawing2D;
using BaurusTour.Utilitarios;

namespace BaurusTour.Componentes
{
    /// <summary>
    /// Botão com cantos arredondados e ícone opcional (fonte Segoe MDL2 Assets).
    /// Aparece na caixa de ferramentas do Visual Studio depois de compilar o projeto,
    /// e todas as cores dá pra mudar pela janela de Propriedades (categoria "Bauru's Tour").
    /// </summary>
    [DefaultEvent("Click")]
    public class BotaoArredondado : Control
    {
        private int _raio = 22;
        private int _espessuraBorda = 1;
        private Color _corFundo = Color.FromArgb(11, 107, 138);
        private Color _corFundoHover = Color.FromArgb(7, 84, 110);
        private Color _corBorda = Color.Transparent;
        private string _icone = string.Empty;
        private bool _iconeADireita;
        private HorizontalAlignment _alinhamento = HorizontalAlignment.Center;
        private bool _mouseEmCima;
        private bool _pressionado;

        public BotaoArredondado()
        {
            SetStyle(ControlStyles.UserPaint |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.SupportsTransparentBackColor, true);

            // Cada clique conta como clique (clicar rápido duas vezes no coração funciona)
            SetStyle(ControlStyles.StandardDoubleClick, false);

            BackColor = Color.Transparent;
            ForeColor = Color.White;
            Cursor = Cursors.Hand;
            Size = new Size(140, 44);
            Font = new Font("Segoe UI Semibold", 11F);
        }

        [Category("Bauru's Tour"), Description("Raio dos cantos arredondados."), DefaultValue(22)]
        public int Raio
        {
            get => _raio;
            set { _raio = Math.Max(0, value); Invalidate(); }
        }

        [Category("Bauru's Tour"), Description("Espessura da borda em pixels."), DefaultValue(1)]
        public int EspessuraBorda
        {
            get => _espessuraBorda;
            set { _espessuraBorda = Math.Max(0, value); Invalidate(); }
        }

        [Category("Bauru's Tour"), Description("Cor de preenchimento do botão."),
         DefaultValue(typeof(Color), "11, 107, 138")]
        public Color CorFundo
        {
            get => _corFundo;
            set { _corFundo = value; Invalidate(); }
        }

        [Category("Bauru's Tour"), Description("Cor de preenchimento quando o mouse passa por cima."),
         DefaultValue(typeof(Color), "7, 84, 110")]
        public Color CorFundoHover
        {
            get => _corFundoHover;
            set { _corFundoHover = value; Invalidate(); }
        }

        [Category("Bauru's Tour"), Description("Cor da borda (Transparent = sem borda)."),
         DefaultValue(typeof(Color), "Transparent")]
        public Color CorBorda
        {
            get => _corBorda;
            set { _corBorda = value; Invalidate(); }
        }

        [Category("Bauru's Tour"), Description("Caractere do ícone na fonte Segoe MDL2 Assets."), DefaultValue("")]
        public string Icone
        {
            get => _icone;
            set { _icone = value ?? string.Empty; Invalidate(); }
        }

        [Category("Bauru's Tour"), Description("Mostra o ícone depois do texto."), DefaultValue(false)]
        public bool IconeADireita
        {
            get => _iconeADireita;
            set { _iconeADireita = value; Invalidate(); }
        }

        [Category("Bauru's Tour"), Description("Alinhamento do ícone e do texto."),
         DefaultValue(HorizontalAlignment.Center)]
        public HorizontalAlignment Alinhamento
        {
            get => _alinhamento;
            set { _alinhamento = value; Invalidate(); }
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            Invalidate();
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);
            Invalidate();
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            _mouseEmCima = true;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            _mouseEmCima = false;
            _pressionado = false;
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                _pressionado = true;
                Invalidate();
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            _pressionado = false;
            Invalidate();
        }

        // Enter e Espaço também "clicam" quando o botão tem o foco (navegação pelo Tab)
        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space)
                OnClick(EventArgs.Empty);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Color fundo = _mouseEmCima && Enabled ? _corFundoHover : _corFundo;
            if (_pressionado)
                fundo = ControlPaint.Dark(fundo, 0.05f);

            var area = new RectangleF(0.5f, 0.5f, Width - 1.5f, Height - 1.5f);
            using (GraphicsPath caminho = Desenho.RetanguloArredondado(area, _raio))
            {
                if (fundo.A > 0)
                {
                    using (var pincel = new SolidBrush(Enabled ? fundo : Color.FromArgb(120, fundo)))
                        g.FillPath(pincel, caminho);
                }

                if (_corBorda.A > 0 && _espessuraBorda > 0)
                {
                    using (var caneta = new Pen(_corBorda, _espessuraBorda))
                        g.DrawPath(caneta, caminho);
                }
            }

            if (Focused && ShowFocusCues)
            {
                var foco = Rectangle.Inflate(ClientRectangle, -4, -4);
                using (GraphicsPath caminhoFoco = Desenho.RetanguloArredondado(foco, Math.Max(0, _raio - 4)))
                using (var caneta = new Pen(Color.FromArgb(90, ForeColor)) { DashStyle = DashStyle.Dot })
                    g.DrawPath(caneta, caminhoFoco);
            }

            DesenharConteudo(g);
        }

        private void DesenharConteudo(Graphics g)
        {
            Color corTexto = Enabled ? ForeColor : Color.FromArgb(150, ForeColor);
            const TextFormatFlags flags = TextFormatFlags.NoPadding | TextFormatFlags.SingleLine |
                                          TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis;

            bool temIcone = _icone.Length > 0;
            bool temTexto = Text.Length > 0;

            using (var fonteIcone = new Font(Icones.Fonte, Font.SizeInPoints * 0.95f, FontStyle.Regular, GraphicsUnit.Point))
            {
                Size tamIcone = temIcone ? TextRenderer.MeasureText(g, _icone, fonteIcone, Size.Empty, flags) : Size.Empty;
                Size tamTexto = temTexto ? TextRenderer.MeasureText(g, Text, Font, Size.Empty, flags) : Size.Empty;
                int espaco = temIcone && temTexto ? LogicalToDeviceUnits(10) : 0;
                int larguraTotal = tamIcone.Width + espaco + tamTexto.Width;

                int x;
                switch (_alinhamento)
                {
                    case HorizontalAlignment.Left:
                        x = Padding.Left > 0 ? Padding.Left : LogicalToDeviceUnits(16);
                        break;
                    case HorizontalAlignment.Right:
                        x = Width - larguraTotal - (Padding.Right > 0 ? Padding.Right : LogicalToDeviceUnits(16));
                        break;
                    default:
                        x = (Width - larguraTotal) / 2;
                        break;
                }

                int larguraMaxTexto = Math.Max(0, Width - x - tamIcone.Width - espaco - LogicalToDeviceUnits(8));

                if (_iconeADireita)
                {
                    if (temTexto)
                        TextRenderer.DrawText(g, Text, Font, new Rectangle(x, 0, Math.Min(tamTexto.Width, larguraMaxTexto), Height), corTexto, flags);
                    if (temIcone)
                        TextRenderer.DrawText(g, _icone, fonteIcone, new Rectangle(x + Math.Min(tamTexto.Width, larguraMaxTexto) + espaco, 1, tamIcone.Width, Height), corTexto, flags);
                }
                else
                {
                    if (temIcone)
                        TextRenderer.DrawText(g, _icone, fonteIcone, new Rectangle(x, 1, tamIcone.Width, Height), corTexto, flags);
                    if (temTexto)
                        TextRenderer.DrawText(g, Text, Font, new Rectangle(x + tamIcone.Width + espaco, 0, Math.Min(tamTexto.Width, larguraMaxTexto), Height), corTexto, flags);
                }
            }
        }
    }
}
