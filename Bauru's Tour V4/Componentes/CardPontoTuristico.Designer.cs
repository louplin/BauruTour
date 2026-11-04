namespace BaurusTour.Componentes
{
    partial class CardPontoTuristico
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            picFoto = new PictureBox();
            lblCategoria = new Label();
            lblNome = new Label();
            lblDescricao = new Label();
            btnVerDetalhes = new Button();
            btnFavoritar = new Button();
            ((System.ComponentModel.ISupportInitialize)picFoto).BeginInit();
            SuspendLayout();
            //
            // picFoto
            //
            picFoto.Cursor = Cursors.Hand;
            picFoto.Image = Properties.Resources.categoria_natureza;
            picFoto.Location = new Point(0, 0);
            picFoto.Name = "picFoto";
            picFoto.Size = new Size(328, 186);
            picFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            picFoto.TabIndex = 0;
            picFoto.TabStop = false;
            picFoto.Click += btnVerDetalhes_Click;
            //
            // lblCategoria
            //
            lblCategoria.AutoSize = true;
            lblCategoria.BackColor = Color.FromArgb(228, 241, 245);
            lblCategoria.Font = new Font("Segoe UI Semibold", 9F);
            lblCategoria.ForeColor = Color.FromArgb(11, 107, 138);
            lblCategoria.Location = new Point(16, 200);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Padding = new Padding(8, 3, 8, 3);
            lblCategoria.Size = new Size(72, 21);
            lblCategoria.TabIndex = 1;
            lblCategoria.Text = "Natureza";
            //
            // lblNome
            //
            lblNome.AutoEllipsis = true;
            lblNome.Cursor = Cursors.Hand;
            lblNome.Font = new Font("Segoe UI", 13.5F, FontStyle.Bold);
            lblNome.ForeColor = Color.FromArgb(13, 43, 94);
            lblNome.Location = new Point(14, 230);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(300, 30);
            lblNome.TabIndex = 2;
            lblNome.Text = "Nome do lugar";
            lblNome.Click += btnVerDetalhes_Click;
            //
            // lblDescricao
            //
            lblDescricao.AutoEllipsis = true;
            lblDescricao.Font = new Font("Segoe UI", 9.75F);
            lblDescricao.ForeColor = Color.FromArgb(88, 98, 112);
            lblDescricao.Location = new Point(15, 262);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(298, 58);
            lblDescricao.TabIndex = 3;
            lblDescricao.Text = "Descrição curta do lugar.";
            //
            // btnVerDetalhes
            //
            btnVerDetalhes.BackColor = Color.White;
            btnVerDetalhes.Cursor = Cursors.Hand;
            btnVerDetalhes.FlatAppearance.BorderColor = Color.FromArgb(11, 107, 138);
            btnVerDetalhes.FlatAppearance.BorderSize = 2;
            btnVerDetalhes.FlatAppearance.MouseOverBackColor = Color.FromArgb(228, 241, 245);
            btnVerDetalhes.FlatStyle = FlatStyle.Flat;
            btnVerDetalhes.Font = new Font("Segoe UI Semibold", 10F);
            btnVerDetalhes.ForeColor = Color.FromArgb(11, 107, 138);
            btnVerDetalhes.Image = Properties.Resources.icone_seta;
            btnVerDetalhes.Location = new Point(16, 332);
            btnVerDetalhes.Name = "btnVerDetalhes";
            btnVerDetalhes.Size = new Size(150, 42);
            btnVerDetalhes.TabIndex = 4;
            btnVerDetalhes.Text = "Ver detalhes";
            btnVerDetalhes.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnVerDetalhes.UseVisualStyleBackColor = false;
            btnVerDetalhes.Click += btnVerDetalhes_Click;
            //
            // btnFavoritar
            //
            btnFavoritar.BackColor = Color.White;
            btnFavoritar.Cursor = Cursors.Hand;
            btnFavoritar.FlatAppearance.BorderSize = 0;
            btnFavoritar.FlatAppearance.MouseOverBackColor = Color.FromArgb(253, 236, 237);
            btnFavoritar.FlatStyle = FlatStyle.Flat;
            btnFavoritar.Font = new Font("Segoe UI Symbol", 16F);
            btnFavoritar.ForeColor = Color.FromArgb(226, 72, 80);
            btnFavoritar.Location = new Point(266, 330);
            btnFavoritar.Name = "btnFavoritar";
            btnFavoritar.Size = new Size(46, 46);
            btnFavoritar.TabIndex = 5;
            btnFavoritar.Text = "♡";
            btnFavoritar.UseVisualStyleBackColor = false;
            btnFavoritar.Click += btnFavoritar_Click;
            //
            // CardPontoTuristico
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(btnFavoritar);
            Controls.Add(btnVerDetalhes);
            Controls.Add(lblDescricao);
            Controls.Add(lblNome);
            Controls.Add(lblCategoria);
            Controls.Add(picFoto);
            Margin = new Padding(0, 0, 20, 20);
            Name = "CardPontoTuristico";
            Size = new Size(330, 390);
            ((System.ComponentModel.ISupportInitialize)picFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picFoto;
        private Label lblCategoria;
        private Label lblNome;
        private Label lblDescricao;
        private Button btnVerDetalhes;
        private Button btnFavoritar;
    }
}
