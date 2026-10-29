namespace BaurusTour.TelaInicial
{
    partial class FormInicial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnComecar = new BaurusTour.Componentes.BotaoArredondado();
            btnGuiaUso = new BaurusTour.Componentes.BotaoArredondado();
            btnTelaCheia = new BaurusTour.Componentes.BotaoArredondado();
            lblAtalhos = new Label();
            SuspendLayout();
            //
            // btnComecar
            //
            btnComecar.CorBorda = Color.FromArgb(201, 169, 106);
            btnComecar.CorFundo = Color.FromArgb(10, 18, 34);
            btnComecar.CorFundoHover = Color.FromArgb(24, 36, 64);
            btnComecar.EspessuraBorda = 2;
            btnComecar.Font = new Font("Segoe UI", 14F);
            btnComecar.ForeColor = Color.FromArgb(243, 244, 246);
            btnComecar.Icone = "";
            btnComecar.IconeADireita = true;
            btnComecar.Location = new Point(440, 420);
            btnComecar.Name = "btnComecar";
            btnComecar.Raio = 30;
            btnComecar.Size = new Size(400, 64);
            btnComecar.TabIndex = 0;
            btnComecar.Text = "Começar minha jornada";
            btnComecar.Click += btnComecar_Click;
            //
            // btnGuiaUso
            //
            btnGuiaUso.CorBorda = Color.FromArgb(90, 110, 140);
            btnGuiaUso.CorFundo = Color.Transparent;
            btnGuiaUso.CorFundoHover = Color.FromArgb(40, 255, 255, 255);
            btnGuiaUso.Font = new Font("Segoe UI", 11F);
            btnGuiaUso.ForeColor = Color.FromArgb(200, 208, 222);
            btnGuiaUso.Icone = "";
            btnGuiaUso.Location = new Point(480, 500);
            btnGuiaUso.Name = "btnGuiaUso";
            btnGuiaUso.Raio = 22;
            btnGuiaUso.Size = new Size(320, 44);
            btnGuiaUso.TabIndex = 1;
            btnGuiaUso.Text = "Como usar o app (guia em PDF)";
            btnGuiaUso.Click += btnGuiaUso_Click;
            //
            // btnTelaCheia
            //
            btnTelaCheia.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTelaCheia.CorBorda = Color.FromArgb(60, 75, 100);
            btnTelaCheia.CorFundo = Color.Transparent;
            btnTelaCheia.CorFundoHover = Color.FromArgb(40, 255, 255, 255);
            btnTelaCheia.Font = new Font("Segoe UI", 10F);
            btnTelaCheia.ForeColor = Color.FromArgb(170, 180, 200);
            btnTelaCheia.Icone = "";
            btnTelaCheia.Location = new Point(1088, 18);
            btnTelaCheia.Name = "btnTelaCheia";
            btnTelaCheia.Raio = 18;
            btnTelaCheia.Size = new Size(172, 38);
            btnTelaCheia.TabIndex = 2;
            btnTelaCheia.Text = "Tela cheia";
            btnTelaCheia.Click += btnTelaCheia_Click;
            //
            // lblAtalhos
            //
            lblAtalhos.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblAtalhos.BackColor = Color.Transparent;
            lblAtalhos.Font = new Font("Segoe UI", 9.75F);
            lblAtalhos.ForeColor = Color.FromArgb(120, 135, 160);
            lblAtalhos.Location = new Point(0, 766);
            lblAtalhos.Name = "lblAtalhos";
            lblAtalhos.Size = new Size(1280, 24);
            lblAtalhos.TabIndex = 3;
            lblAtalhos.Text = "F11: tela cheia     •     Esc: sair da tela cheia / fechar o app";
            lblAtalhos.TextAlign = ContentAlignment.MiddleCenter;
            //
            // FormInicial
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(4, 7, 13);
            ClientSize = new Size(1280, 800);
            Controls.Add(lblAtalhos);
            Controls.Add(btnTelaCheia);
            Controls.Add(btnGuiaUso);
            Controls.Add(btnComecar);
            DoubleBuffered = true;
            KeyPreview = true;
            MinimumSize = new Size(900, 640);
            Name = "FormInicial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bauru's Tour";
            WindowState = FormWindowState.Maximized;
            Load += FormInicial_Load;
            KeyDown += FormInicial_KeyDown;
            ResumeLayout(false);
        }

        #endregion

        private BaurusTour.Componentes.BotaoArredondado btnComecar;
        private BaurusTour.Componentes.BotaoArredondado btnGuiaUso;
        private BaurusTour.Componentes.BotaoArredondado btnTelaCheia;
        private Label lblAtalhos;
    }
}
