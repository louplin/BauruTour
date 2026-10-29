namespace BaurusTour.TelaDetalhe
{
    partial class FormDetalhe
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
            pnlTopo = new Panel();
            btnTelaCheia = new Button();
            lblMarca = new Label();
            picLogo = new PictureBox();
            btnVoltar = new Button();
            pnlLinhaTopo = new Panel();
            picFoto = new PictureBox();
            lblCategoria = new Label();
            lblNome = new Label();
            lblEnderecoTitulo = new Label();
            lblEndereco = new Label();
            lblSobreTitulo = new Label();
            lblDescricao = new Label();
            btnMapa = new Button();
            btnCompartilhar = new Button();
            btnFavoritar = new Button();
            pnlTopo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picFoto).BeginInit();
            SuspendLayout();
            //
            // pnlTopo
            //
            pnlTopo.BackColor = Color.White;
            pnlTopo.Controls.Add(btnTelaCheia);
            pnlTopo.Controls.Add(lblMarca);
            pnlTopo.Controls.Add(picLogo);
            pnlTopo.Controls.Add(btnVoltar);
            pnlTopo.Dock = DockStyle.Top;
            pnlTopo.Location = new Point(0, 0);
            pnlTopo.Name = "pnlTopo";
            pnlTopo.Size = new Size(1200, 76);
            pnlTopo.TabIndex = 0;
            //
            // btnTelaCheia
            //
            btnTelaCheia.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTelaCheia.BackColor = Color.White;
            btnTelaCheia.Cursor = Cursors.Hand;
            btnTelaCheia.FlatAppearance.BorderColor = Color.FromArgb(220, 226, 230);
            btnTelaCheia.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 244, 246);
            btnTelaCheia.FlatStyle = FlatStyle.Flat;
            btnTelaCheia.Font = new Font("Segoe UI", 11F);
            btnTelaCheia.ForeColor = Color.FromArgb(13, 43, 94);
            btnTelaCheia.Image = Properties.Resources.icone_tela_cheia;
            btnTelaCheia.Location = new Point(992, 16);
            btnTelaCheia.Name = "btnTelaCheia";
            btnTelaCheia.Size = new Size(180, 44);
            btnTelaCheia.TabIndex = 3;
            btnTelaCheia.Text = "Tela cheia";
            btnTelaCheia.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTelaCheia.UseVisualStyleBackColor = false;
            btnTelaCheia.Click += btnTelaCheia_Click;
            //
            // lblMarca
            //
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblMarca.ForeColor = Color.FromArgb(13, 43, 94);
            lblMarca.Location = new Point(222, 22);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(142, 30);
            lblMarca.TabIndex = 2;
            lblMarca.Text = "Bauru's Tour";
            //
            // picLogo
            //
            picLogo.Image = Properties.Resources.logo;
            picLogo.Location = new Point(176, 18);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(40, 40);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 1;
            picLogo.TabStop = false;
            //
            // btnVoltar
            //
            btnVoltar.BackColor = Color.White;
            btnVoltar.Cursor = Cursors.Hand;
            btnVoltar.FlatAppearance.BorderColor = Color.FromArgb(11, 107, 138);
            btnVoltar.FlatAppearance.BorderSize = 2;
            btnVoltar.FlatAppearance.MouseOverBackColor = Color.FromArgb(228, 241, 245);
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Segoe UI Semibold", 11F);
            btnVoltar.ForeColor = Color.FromArgb(11, 107, 138);
            btnVoltar.Image = Properties.Resources.icone_voltar;
            btnVoltar.Location = new Point(28, 16);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(130, 44);
            btnVoltar.TabIndex = 0;
            btnVoltar.Text = "Voltar";
            btnVoltar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            //
            // pnlLinhaTopo
            //
            pnlLinhaTopo.BackColor = Color.FromArgb(220, 226, 230);
            pnlLinhaTopo.Dock = DockStyle.Top;
            pnlLinhaTopo.Location = new Point(0, 76);
            pnlLinhaTopo.Name = "pnlLinhaTopo";
            pnlLinhaTopo.Size = new Size(1200, 1);
            pnlLinhaTopo.TabIndex = 1;
            //
            // picFoto
            //
            picFoto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            picFoto.Image = Properties.Resources.categoria_natureza;
            picFoto.Location = new Point(40, 110);
            picFoto.Name = "picFoto";
            picFoto.Size = new Size(540, 610);
            picFoto.SizeMode = PictureBoxSizeMode.Zoom;
            picFoto.TabIndex = 2;
            picFoto.TabStop = false;
            //
            // lblCategoria
            //
            lblCategoria.AutoSize = true;
            lblCategoria.BackColor = Color.FromArgb(228, 241, 245);
            lblCategoria.Font = new Font("Segoe UI Semibold", 10F);
            lblCategoria.ForeColor = Color.FromArgb(11, 107, 138);
            lblCategoria.Location = new Point(620, 112);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Padding = new Padding(10, 4, 10, 4);
            lblCategoria.Size = new Size(84, 27);
            lblCategoria.TabIndex = 3;
            lblCategoria.Text = "Natureza";
            //
            // lblNome
            //
            lblNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblNome.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            lblNome.ForeColor = Color.FromArgb(13, 43, 94);
            lblNome.Location = new Point(614, 148);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(550, 100);
            lblNome.TabIndex = 4;
            lblNome.Text = "Nome do lugar";
            //
            // lblEnderecoTitulo
            //
            lblEnderecoTitulo.AutoSize = true;
            lblEnderecoTitulo.Font = new Font("Segoe UI Semibold", 9.75F);
            lblEnderecoTitulo.ForeColor = Color.FromArgb(11, 107, 138);
            lblEnderecoTitulo.Location = new Point(620, 258);
            lblEnderecoTitulo.Name = "lblEnderecoTitulo";
            lblEnderecoTitulo.Size = new Size(72, 17);
            lblEnderecoTitulo.TabIndex = 5;
            lblEnderecoTitulo.Text = "ENDEREÇO";
            //
            // lblEndereco
            //
            lblEndereco.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblEndereco.Font = new Font("Segoe UI", 12F);
            lblEndereco.ForeColor = Color.FromArgb(88, 98, 112);
            lblEndereco.Location = new Point(618, 280);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(546, 50);
            lblEndereco.TabIndex = 6;
            lblEndereco.Text = "Endereço do lugar";
            //
            // lblSobreTitulo
            //
            lblSobreTitulo.AutoSize = true;
            lblSobreTitulo.Font = new Font("Segoe UI Semibold", 9.75F);
            lblSobreTitulo.ForeColor = Color.FromArgb(11, 107, 138);
            lblSobreTitulo.Location = new Point(620, 344);
            lblSobreTitulo.Name = "lblSobreTitulo";
            lblSobreTitulo.Size = new Size(103, 17);
            lblSobreTitulo.TabIndex = 7;
            lblSobreTitulo.Text = "SOBRE O LUGAR";
            //
            // lblDescricao
            //
            lblDescricao.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDescricao.Font = new Font("Segoe UI", 12.5F);
            lblDescricao.ForeColor = Color.FromArgb(40, 48, 60);
            lblDescricao.Location = new Point(618, 366);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(546, 200);
            lblDescricao.TabIndex = 8;
            lblDescricao.Text = "Descrição do lugar";
            //
            // btnMapa
            //
            btnMapa.BackColor = Color.FromArgb(11, 107, 138);
            btnMapa.Cursor = Cursors.Hand;
            btnMapa.FlatAppearance.BorderSize = 0;
            btnMapa.FlatAppearance.MouseOverBackColor = Color.FromArgb(7, 84, 110);
            btnMapa.FlatStyle = FlatStyle.Flat;
            btnMapa.Font = new Font("Segoe UI Semibold", 11.5F);
            btnMapa.ForeColor = Color.White;
            btnMapa.Image = Properties.Resources.icone_mapa_branco;
            btnMapa.Location = new Point(620, 586);
            btnMapa.Name = "btnMapa";
            btnMapa.Size = new Size(236, 52);
            btnMapa.TabIndex = 9;
            btnMapa.Text = "Ver no Google Maps";
            btnMapa.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMapa.UseVisualStyleBackColor = false;
            btnMapa.Click += btnMapa_Click;
            //
            // btnCompartilhar
            //
            btnCompartilhar.BackColor = Color.White;
            btnCompartilhar.Cursor = Cursors.Hand;
            btnCompartilhar.FlatAppearance.BorderColor = Color.FromArgb(11, 107, 138);
            btnCompartilhar.FlatAppearance.BorderSize = 2;
            btnCompartilhar.FlatAppearance.MouseOverBackColor = Color.FromArgb(228, 241, 245);
            btnCompartilhar.FlatStyle = FlatStyle.Flat;
            btnCompartilhar.Font = new Font("Segoe UI Semibold", 11.5F);
            btnCompartilhar.ForeColor = Color.FromArgb(11, 107, 138);
            btnCompartilhar.Image = Properties.Resources.icone_compartilhar;
            btnCompartilhar.Location = new Point(868, 586);
            btnCompartilhar.Name = "btnCompartilhar";
            btnCompartilhar.Size = new Size(184, 52);
            btnCompartilhar.TabIndex = 10;
            btnCompartilhar.Text = "Compartilhar";
            btnCompartilhar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCompartilhar.UseVisualStyleBackColor = false;
            btnCompartilhar.Click += btnCompartilhar_Click;
            //
            // btnFavoritar
            //
            btnFavoritar.BackColor = Color.White;
            btnFavoritar.Cursor = Cursors.Hand;
            btnFavoritar.FlatAppearance.BorderColor = Color.FromArgb(226, 72, 80);
            btnFavoritar.FlatAppearance.BorderSize = 2;
            btnFavoritar.FlatAppearance.MouseOverBackColor = Color.FromArgb(253, 236, 237);
            btnFavoritar.FlatStyle = FlatStyle.Flat;
            btnFavoritar.Font = new Font("Segoe UI Semibold", 11.5F);
            btnFavoritar.ForeColor = Color.FromArgb(226, 72, 80);
            btnFavoritar.Location = new Point(620, 650);
            btnFavoritar.Name = "btnFavoritar";
            btnFavoritar.Size = new Size(184, 52);
            btnFavoritar.TabIndex = 11;
            btnFavoritar.Text = "♡  Favoritar";
            btnFavoritar.UseVisualStyleBackColor = false;
            btnFavoritar.Click += btnFavoritar_Click;
            //
            // FormDetalhe
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 248, 246);
            ClientSize = new Size(1200, 760);
            Controls.Add(btnFavoritar);
            Controls.Add(btnCompartilhar);
            Controls.Add(btnMapa);
            Controls.Add(lblDescricao);
            Controls.Add(lblSobreTitulo);
            Controls.Add(lblEndereco);
            Controls.Add(lblEnderecoTitulo);
            Controls.Add(lblNome);
            Controls.Add(lblCategoria);
            Controls.Add(picFoto);
            Controls.Add(pnlLinhaTopo);
            Controls.Add(pnlTopo);
            Icon = Properties.Resources.icone;
            KeyPreview = true;
            MinimumSize = new Size(1000, 680);
            Name = "FormDetalhe";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Detalhes - Bauru's Tour";
            WindowState = FormWindowState.Maximized;
            Load += FormDetalhe_Load;
            KeyDown += FormDetalhe_KeyDown;
            pnlTopo.ResumeLayout(false);
            pnlTopo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)picFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlTopo;
        private Button btnVoltar;
        private PictureBox picLogo;
        private Label lblMarca;
        private Button btnTelaCheia;
        private Panel pnlLinhaTopo;
        private PictureBox picFoto;
        private Label lblCategoria;
        private Label lblNome;
        private Label lblEnderecoTitulo;
        private Label lblEndereco;
        private Label lblSobreTitulo;
        private Label lblDescricao;
        private Button btnMapa;
        private Button btnCompartilhar;
        private Button btnFavoritar;
    }
}
