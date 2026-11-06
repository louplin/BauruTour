namespace BaurusTour.TelaSobre
{
    partial class FormSobre
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
            picLogo = new PictureBox();
            lblSobreTitulo = new Label();
            lblSobreTexto = new Label();
            lblEquipe = new Label();
            lblAtalhos = new Label();
            btnFechar = new Button();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            //
            // picLogo
            //
            picLogo.Image = Properties.Resources.logo;
            picLogo.Location = new Point(32, 24);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(64, 64);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            //
            // lblSobreTitulo
            //
            lblSobreTitulo.AutoSize = true;
            lblSobreTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblSobreTitulo.ForeColor = Color.FromArgb(13, 43, 94);
            lblSobreTitulo.Location = new Point(106, 36);
            lblSobreTitulo.Name = "lblSobreTitulo";
            lblSobreTitulo.Size = new Size(285, 37);
            lblSobreTitulo.TabIndex = 1;
            lblSobreTitulo.Text = "Sobre o Bauru's Tour";
            //
            // lblSobreTexto
            //
            lblSobreTexto.Font = new Font("Segoe UI", 11F);
            lblSobreTexto.ForeColor = Color.FromArgb(40, 48, 60);
            lblSobreTexto.Location = new Point(34, 108);
            lblSobreTexto.Name = "lblSobreTexto";
            lblSobreTexto.Size = new Size(790, 186);
            lblSobreTexto.TabIndex = 2;
            lblSobreTexto.Text = "O Bauru's Tour é um guia dos pontos turísticos de Bauru (SP), feito em C# com Windows Forms como trabalho da faculdade.\r\n\r\nNo app dá pra buscar um lugar pelo nome, filtrar por categoria, ver os detalhes de cada ponto, abrir a localização no Google Maps, mandar o link pelo WhatsApp e guardar os seus favoritos.\r\n\r\nOs lugares ficam no arquivo pontos.json e os favoritos são salvos no próprio computador, então continuam lá quando você abre o app de novo.";
            //
            // lblEquipe
            //
            lblEquipe.Font = new Font("Segoe UI Semibold", 10.5F);
            lblEquipe.ForeColor = Color.FromArgb(13, 43, 94);
            lblEquipe.Location = new Point(34, 304);
            lblEquipe.Name = "lblEquipe";
            lblEquipe.Size = new Size(790, 24);
            lblEquipe.TabIndex = 3;
            lblEquipe.Text = "Desenvolvido por: Olavo Faustino e equipe";
            //
            // lblAtalhos
            //
            lblAtalhos.AutoSize = true;
            lblAtalhos.Font = new Font("Segoe UI", 9.75F);
            lblAtalhos.ForeColor = Color.FromArgb(88, 98, 112);
            lblAtalhos.Location = new Point(34, 342);
            lblAtalhos.Name = "lblAtalhos";
            lblAtalhos.Size = new Size(380, 17);
            lblAtalhos.TabIndex = 4;
            lblAtalhos.Text = "Atalhos:  F11 = tela cheia   |   Esc = sair da tela cheia";
            //
            // btnFechar
            //
            btnFechar.BackColor = Color.FromArgb(11, 107, 138);
            btnFechar.Cursor = Cursors.Hand;
            btnFechar.DialogResult = DialogResult.Cancel;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatAppearance.MouseOverBackColor = Color.FromArgb(7, 84, 110);
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Font = new Font("Segoe UI Semibold", 11F);
            btnFechar.ForeColor = Color.White;
            btnFechar.Location = new Point(680, 384);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(144, 46);
            btnFechar.TabIndex = 5;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = false;
            //
            // FormSobre
            //
            AcceptButton = btnFechar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = btnFechar;
            ClientSize = new Size(860, 456);
            Controls.Add(btnFechar);
            Controls.Add(lblAtalhos);
            Controls.Add(lblEquipe);
            Controls.Add(lblSobreTexto);
            Controls.Add(lblSobreTitulo);
            Controls.Add(picLogo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = Properties.Resources.icone;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormSobre";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Sobre - Bauru's Tour";
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picLogo;
        private Label lblSobreTitulo;
        private Label lblSobreTexto;
        private Label lblEquipe;
        private Label lblAtalhos;
        private Button btnFechar;
    }
}
