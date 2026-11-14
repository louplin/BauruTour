namespace BaurusTour.Telas.TelaCreditos
{
    partial class FormCreditos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreditos));
            picLogo = new PictureBox();
            lblTitulo = new Label();
            lblSobreTexto = new Label();
            lblEquipe = new Label();
            lblOrientador = new Label();
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
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(13, 43, 94);
            lblTitulo.Location = new Point(106, 36);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(281, 37);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Créditos";
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
            // lblOrientador
            // 
            lblOrientador.Font = new Font("Segoe UI", 10.5F);
            lblOrientador.ForeColor = Color.FromArgb(13, 43, 94);
            lblOrientador.Location = new Point(32, 456);
            lblOrientador.Name = "lblOrientador";
            lblOrientador.Size = new Size(620, 48);
            lblOrientador.TabIndex = 4;
            lblOrientador.Text = "Orientador: Prof. Elvio Gilberto da Silva\r\nDisciplina: Programação de Computadores - 2º semestre de 2026";
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
            btnFechar.Location = new Point(680, 458);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(144, 46);
            btnFechar.TabIndex = 5;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = false;
            // 
            // FormCreditos
            // 
            AcceptButton = btnFechar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            CancelButton = btnFechar;
            ClientSize = new Size(860, 530);
            Controls.Add(btnFechar);
            Controls.Add(lblOrientador);
            Controls.Add(lblEquipe);
            Controls.Add(lblSobreTexto);
            Controls.Add(lblTitulo);
            Controls.Add(picLogo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = Properties.Resources.icone;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCreditos";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Créditos - Bauru's Tour";
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picLogo;
        private Label lblTitulo;
        private Label lblSobreTexto;
        private Label lblEquipe;
        private Label lblOrientador;
        private Button btnFechar;
    }
}
