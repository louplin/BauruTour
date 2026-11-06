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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSobre));
            picLogo = new PictureBox();
            lblSobreTitulo = new Label();
            lblSobreTexto = new Label();
            lblEquipe = new Label();
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
            lblSobreTitulo.Size = new Size(281, 37);
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
            lblSobreTexto.Text = resources.GetString("lblSobreTexto.Text");
            // 
            // lblEquipe
            // 
            lblEquipe.Font = new Font("Segoe UI Semibold", 10.5F);
            lblEquipe.ForeColor = Color.FromArgb(13, 43, 94);
            lblEquipe.Location = new Point(32, 294);
            lblEquipe.Name = "lblEquipe";
            lblEquipe.Size = new Size(790, 153);
            lblEquipe.TabIndex = 3;
            lblEquipe.Text = resources.GetString("lblEquipe.Text");
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
            BackColor = Color.Azure;
            CancelButton = btnFechar;
            ClientSize = new Size(860, 456);
            Controls.Add(btnFechar);
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
        private Button btnFechar;
    }
}
