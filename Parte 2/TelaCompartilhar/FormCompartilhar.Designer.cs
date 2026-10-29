namespace BaurusTour.TelaCompartilhar
{
    partial class FormCompartilhar
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
            lblTitulo = new Label();
            lblNomeLugar = new Label();
            lblLinkTitulo = new Label();
            txtLink = new TextBox();
            lblMensagemTitulo = new Label();
            txtMensagem = new TextBox();
            btnCopiarLink = new Button();
            btnCopiarMensagem = new Button();
            btnWhatsApp = new Button();
            lblConfirmacao = new Label();
            SuspendLayout();
            //
            // lblTitulo
            //
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(13, 43, 94);
            lblTitulo.Location = new Point(26, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(176, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Compartilhar";
            //
            // lblNomeLugar
            //
            lblNomeLugar.AutoEllipsis = true;
            lblNomeLugar.Font = new Font("Segoe UI", 11F);
            lblNomeLugar.ForeColor = Color.FromArgb(88, 98, 112);
            lblNomeLugar.Location = new Point(29, 58);
            lblNomeLugar.Name = "lblNomeLugar";
            lblNomeLugar.Size = new Size(562, 24);
            lblNomeLugar.TabIndex = 1;
            lblNomeLugar.Text = "Nome do lugar";
            //
            // lblLinkTitulo
            //
            lblLinkTitulo.AutoSize = true;
            lblLinkTitulo.Font = new Font("Segoe UI Semibold", 9.75F);
            lblLinkTitulo.ForeColor = Color.FromArgb(11, 107, 138);
            lblLinkTitulo.Location = new Point(29, 98);
            lblLinkTitulo.Name = "lblLinkTitulo";
            lblLinkTitulo.Size = new Size(145, 17);
            lblLinkTitulo.TabIndex = 2;
            lblLinkTitulo.Text = "LINK DO GOOGLE MAPS";
            //
            // txtLink
            //
            txtLink.BackColor = Color.FromArgb(247, 248, 246);
            txtLink.Font = new Font("Segoe UI", 11F);
            txtLink.ForeColor = Color.FromArgb(40, 48, 60);
            txtLink.Location = new Point(29, 120);
            txtLink.Name = "txtLink";
            txtLink.ReadOnly = true;
            txtLink.Size = new Size(562, 27);
            txtLink.TabIndex = 3;
            //
            // lblMensagemTitulo
            //
            lblMensagemTitulo.AutoSize = true;
            lblMensagemTitulo.Font = new Font("Segoe UI Semibold", 9.75F);
            lblMensagemTitulo.ForeColor = Color.FromArgb(11, 107, 138);
            lblMensagemTitulo.Location = new Point(29, 164);
            lblMensagemTitulo.Name = "lblMensagemTitulo";
            lblMensagemTitulo.Size = new Size(234, 17);
            lblMensagemTitulo.TabIndex = 4;
            lblMensagemTitulo.Text = "MENSAGEM PRONTA PARA O WHATSAPP";
            //
            // txtMensagem
            //
            txtMensagem.BackColor = Color.FromArgb(247, 248, 246);
            txtMensagem.Font = new Font("Segoe UI", 10.5F);
            txtMensagem.ForeColor = Color.FromArgb(40, 48, 60);
            txtMensagem.Location = new Point(29, 186);
            txtMensagem.Multiline = true;
            txtMensagem.Name = "txtMensagem";
            txtMensagem.ReadOnly = true;
            txtMensagem.ScrollBars = ScrollBars.Vertical;
            txtMensagem.Size = new Size(562, 86);
            txtMensagem.TabIndex = 5;
            //
            // btnCopiarLink
            //
            btnCopiarLink.BackColor = Color.FromArgb(11, 107, 138);
            btnCopiarLink.Cursor = Cursors.Hand;
            btnCopiarLink.FlatAppearance.BorderSize = 0;
            btnCopiarLink.FlatAppearance.MouseOverBackColor = Color.FromArgb(7, 84, 110);
            btnCopiarLink.FlatStyle = FlatStyle.Flat;
            btnCopiarLink.Font = new Font("Segoe UI Semibold", 11F);
            btnCopiarLink.ForeColor = Color.White;
            btnCopiarLink.Image = Properties.Resources.icone_copiar_branco;
            btnCopiarLink.Location = new Point(28, 292);
            btnCopiarLink.Name = "btnCopiarLink";
            btnCopiarLink.Size = new Size(170, 48);
            btnCopiarLink.TabIndex = 6;
            btnCopiarLink.Text = "Copiar link";
            btnCopiarLink.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCopiarLink.UseVisualStyleBackColor = false;
            btnCopiarLink.Click += btnCopiarLink_Click;
            //
            // btnCopiarMensagem
            //
            btnCopiarMensagem.BackColor = Color.White;
            btnCopiarMensagem.Cursor = Cursors.Hand;
            btnCopiarMensagem.FlatAppearance.BorderColor = Color.FromArgb(11, 107, 138);
            btnCopiarMensagem.FlatAppearance.BorderSize = 2;
            btnCopiarMensagem.FlatAppearance.MouseOverBackColor = Color.FromArgb(228, 241, 245);
            btnCopiarMensagem.FlatStyle = FlatStyle.Flat;
            btnCopiarMensagem.Font = new Font("Segoe UI Semibold", 11F);
            btnCopiarMensagem.ForeColor = Color.FromArgb(11, 107, 138);
            btnCopiarMensagem.Image = Properties.Resources.icone_copiar;
            btnCopiarMensagem.Location = new Point(208, 292);
            btnCopiarMensagem.Name = "btnCopiarMensagem";
            btnCopiarMensagem.Size = new Size(206, 48);
            btnCopiarMensagem.TabIndex = 7;
            btnCopiarMensagem.Text = "Copiar mensagem";
            btnCopiarMensagem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCopiarMensagem.UseVisualStyleBackColor = false;
            btnCopiarMensagem.Click += btnCopiarMensagem_Click;
            //
            // btnWhatsApp
            //
            btnWhatsApp.BackColor = Color.FromArgb(18, 140, 96);
            btnWhatsApp.Cursor = Cursors.Hand;
            btnWhatsApp.FlatAppearance.BorderSize = 0;
            btnWhatsApp.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 112, 76);
            btnWhatsApp.FlatStyle = FlatStyle.Flat;
            btnWhatsApp.Font = new Font("Segoe UI Semibold", 11F);
            btnWhatsApp.ForeColor = Color.White;
            btnWhatsApp.Image = Properties.Resources.icone_whatsapp_branco;
            btnWhatsApp.Location = new Point(424, 292);
            btnWhatsApp.Name = "btnWhatsApp";
            btnWhatsApp.Size = new Size(168, 48);
            btnWhatsApp.TabIndex = 8;
            btnWhatsApp.Text = "WhatsApp";
            btnWhatsApp.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnWhatsApp.UseVisualStyleBackColor = false;
            btnWhatsApp.Click += btnWhatsApp_Click;
            //
            // lblConfirmacao
            //
            lblConfirmacao.AutoSize = true;
            lblConfirmacao.Font = new Font("Segoe UI Semibold", 10F);
            lblConfirmacao.ForeColor = Color.FromArgb(22, 128, 72);
            lblConfirmacao.Location = new Point(29, 352);
            lblConfirmacao.Name = "lblConfirmacao";
            lblConfirmacao.Size = new Size(290, 19);
            lblConfirmacao.TabIndex = 9;
            lblConfirmacao.Text = "Copiado! Agora é só colar no WhatsApp.";
            lblConfirmacao.Visible = false;
            //
            // FormCompartilhar
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(620, 386);
            Controls.Add(lblConfirmacao);
            Controls.Add(btnWhatsApp);
            Controls.Add(btnCopiarMensagem);
            Controls.Add(btnCopiarLink);
            Controls.Add(txtMensagem);
            Controls.Add(lblMensagemTitulo);
            Controls.Add(txtLink);
            Controls.Add(lblLinkTitulo);
            Controls.Add(lblNomeLugar);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = Properties.Resources.icone;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCompartilhar";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Compartilhar - Bauru's Tour";
            Load += FormCompartilhar_Load;
            KeyDown += FormCompartilhar_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNomeLugar;
        private Label lblLinkTitulo;
        private TextBox txtLink;
        private Label lblMensagemTitulo;
        private TextBox txtMensagem;
        private Button btnCopiarLink;
        private Button btnCopiarMensagem;
        private Button btnWhatsApp;
        private Label lblConfirmacao;
    }
}
