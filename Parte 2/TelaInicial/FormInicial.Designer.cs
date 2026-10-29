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
            lblBemVindo = new Label();
            lblTitulo = new Label();
            pnlLinhaDourada = new Panel();
            lblSubtitulo = new Label();
            btnComecar = new Button();
            btnGuia = new Button();
            btnTelaCheia = new Button();
            lblAtalhos = new Label();
            SuspendLayout();
            //
            // lblBemVindo
            //
            lblBemVindo.Anchor = AnchorStyles.None;
            lblBemVindo.BackColor = Color.Transparent;
            lblBemVindo.Font = new Font("Segoe UI", 11F);
            lblBemVindo.ForeColor = Color.FromArgb(154, 167, 189);
            lblBemVindo.Location = new Point(390, 110);
            lblBemVindo.Name = "lblBemVindo";
            lblBemVindo.Size = new Size(500, 26);
            lblBemVindo.TabIndex = 0;
            lblBemVindo.Text = "B E M - V I N D O   A O";
            lblBemVindo.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblTitulo
            //
            lblTitulo.Anchor = AnchorStyles.None;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Georgia", 40F);
            lblTitulo.ForeColor = Color.FromArgb(243, 244, 246);
            lblTitulo.Location = new Point(290, 140);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(700, 72);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "BAURU'S TOUR";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            //
            // pnlLinhaDourada
            //
            pnlLinhaDourada.Anchor = AnchorStyles.None;
            pnlLinhaDourada.BackColor = Color.FromArgb(201, 169, 106);
            pnlLinhaDourada.Location = new Point(600, 220);
            pnlLinhaDourada.Name = "pnlLinhaDourada";
            pnlLinhaDourada.Size = new Size(80, 2);
            pnlLinhaDourada.TabIndex = 2;
            //
            // lblSubtitulo
            //
            lblSubtitulo.Anchor = AnchorStyles.None;
            lblSubtitulo.BackColor = Color.Transparent;
            lblSubtitulo.Font = new Font("Segoe UI", 14F);
            lblSubtitulo.ForeColor = Color.FromArgb(139, 152, 174);
            lblSubtitulo.Location = new Point(290, 232);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(700, 32);
            lblSubtitulo.TabIndex = 3;
            lblSubtitulo.Text = "Descubra os pontos turísticos de Bauru";
            lblSubtitulo.TextAlign = ContentAlignment.MiddleCenter;
            //
            // btnComecar
            //
            btnComecar.Anchor = AnchorStyles.None;
            btnComecar.BackColor = Color.FromArgb(10, 18, 34);
            btnComecar.Cursor = Cursors.Hand;
            btnComecar.FlatAppearance.BorderColor = Color.FromArgb(201, 169, 106);
            btnComecar.FlatAppearance.BorderSize = 2;
            btnComecar.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 36, 64);
            btnComecar.FlatStyle = FlatStyle.Flat;
            btnComecar.Font = new Font("Segoe UI", 14F);
            btnComecar.ForeColor = Color.FromArgb(243, 244, 246);
            btnComecar.Image = Properties.Resources.icone_seta_clara;
            btnComecar.Location = new Point(440, 296);
            btnComecar.Name = "btnComecar";
            btnComecar.Size = new Size(400, 60);
            btnComecar.TabIndex = 4;
            btnComecar.Text = "Começar minha jornada";
            btnComecar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnComecar.UseVisualStyleBackColor = false;
            btnComecar.Click += btnComecar_Click;
            //
            // btnGuia
            //
            btnGuia.Anchor = AnchorStyles.None;
            btnGuia.BackColor = Color.FromArgb(10, 18, 34);
            btnGuia.Cursor = Cursors.Hand;
            btnGuia.FlatAppearance.BorderColor = Color.FromArgb(90, 110, 140);
            btnGuia.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 36, 64);
            btnGuia.FlatStyle = FlatStyle.Flat;
            btnGuia.Font = new Font("Segoe UI", 11F);
            btnGuia.ForeColor = Color.FromArgb(200, 208, 222);
            btnGuia.Image = Properties.Resources.icone_documento_claro;
            btnGuia.Location = new Point(480, 372);
            btnGuia.Name = "btnGuia";
            btnGuia.Size = new Size(320, 44);
            btnGuia.TabIndex = 5;
            btnGuia.Text = "Como usar o app (guia em PDF)";
            btnGuia.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuia.UseVisualStyleBackColor = false;
            btnGuia.Click += btnGuia_Click;
            //
            // btnTelaCheia
            //
            btnTelaCheia.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTelaCheia.BackColor = Color.FromArgb(10, 18, 34);
            btnTelaCheia.Cursor = Cursors.Hand;
            btnTelaCheia.FlatAppearance.BorderColor = Color.FromArgb(60, 75, 100);
            btnTelaCheia.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 36, 64);
            btnTelaCheia.FlatStyle = FlatStyle.Flat;
            btnTelaCheia.Font = new Font("Segoe UI", 10F);
            btnTelaCheia.ForeColor = Color.FromArgb(170, 180, 200);
            btnTelaCheia.Image = Properties.Resources.icone_tela_cheia_claro;
            btnTelaCheia.Location = new Point(1088, 18);
            btnTelaCheia.Name = "btnTelaCheia";
            btnTelaCheia.Size = new Size(172, 40);
            btnTelaCheia.TabIndex = 6;
            btnTelaCheia.Text = "Tela cheia";
            btnTelaCheia.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTelaCheia.UseVisualStyleBackColor = false;
            btnTelaCheia.Click += btnTelaCheia_Click;
            //
            // lblAtalhos
            //
            lblAtalhos.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblAtalhos.BackColor = Color.Transparent;
            lblAtalhos.Font = new Font("Segoe UI", 9.75F);
            lblAtalhos.ForeColor = Color.FromArgb(150, 165, 190);
            lblAtalhos.Location = new Point(0, 690);
            lblAtalhos.Name = "lblAtalhos";
            lblAtalhos.Size = new Size(1280, 24);
            lblAtalhos.TabIndex = 7;
            lblAtalhos.Text = "F11: tela cheia     •     Esc: sair da tela cheia / fechar o app";
            lblAtalhos.TextAlign = ContentAlignment.MiddleCenter;
            //
            // FormInicial
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(6, 11, 22);
            BackgroundImage = Properties.Resources.fundo_inicial;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1280, 720);
            Controls.Add(lblAtalhos);
            Controls.Add(btnTelaCheia);
            Controls.Add(btnGuia);
            Controls.Add(btnComecar);
            Controls.Add(lblSubtitulo);
            Controls.Add(pnlLinhaDourada);
            Controls.Add(lblTitulo);
            Controls.Add(lblBemVindo);
            DoubleBuffered = true;
            Icon = Properties.Resources.icone;
            KeyPreview = true;
            MinimumSize = new Size(1000, 640);
            Name = "FormInicial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bauru's Tour";
            WindowState = FormWindowState.Maximized;
            KeyDown += FormInicial_KeyDown;
            ResumeLayout(false);
        }

        #endregion

        private Label lblBemVindo;
        private Label lblTitulo;
        private Panel pnlLinhaDourada;
        private Label lblSubtitulo;
        private Button btnComecar;
        private Button btnGuia;
        private Button btnTelaCheia;
        private Label lblAtalhos;
    }
}
