namespace BaurusTour.Telas.TelaBusca
{
    partial class FormBusca
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlMenu = new Panel();
            btnCreditos = new Button();
            btnFavoritos = new Button();
            btnMapa = new Button();
            btnInicio = new Button();
            picIlustracaoMenu = new PictureBox();
            pnlLinhaMenu = new Panel();
            pnlConteudo = new Panel();
            flpCards = new FlowLayoutPanel();
            lblNenhumResultado = new Label();
            pnlTituloSecao = new Panel();
            btnSurpreenda = new Button();
            lblQuantidade = new Label();
            lblTituloSecao = new Label();
            pnlCabecalho = new Panel();
            flpCategorias = new FlowLayoutPanel();
            btnCategoriaTodos = new Button();
            btnCategoriaNatureza = new Button();
            btnCategoriaGastronomia = new Button();
            btnCategoriaLazerCultura = new Button();
            btnCategoriaCompras = new Button();
            txtBusca = new TextBox();
            lblSubtitulo = new Label();
            lblTitulo = new Label();
            picLogo = new PictureBox();
            pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picIlustracaoMenu).BeginInit();
            pnlConteudo.SuspendLayout();
            flpCards.SuspendLayout();
            pnlTituloSecao.SuspendLayout();
            pnlCabecalho.SuspendLayout();
            flpCategorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(242, 248, 250);
            pnlMenu.Controls.Add(btnCreditos);
            pnlMenu.Controls.Add(btnFavoritos);
            pnlMenu.Controls.Add(btnMapa);
            pnlMenu.Controls.Add(btnInicio);
            pnlMenu.Controls.Add(picIlustracaoMenu);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(220, 800);
            pnlMenu.TabIndex = 0;
            // 
            // btnCreditos
            // 
            btnCreditos.Cursor = Cursors.Hand;
            btnCreditos.FlatAppearance.BorderSize = 0;
            btnCreditos.FlatAppearance.MouseOverBackColor = Color.FromArgb(232, 242, 246);
            btnCreditos.FlatStyle = FlatStyle.Flat;
            btnCreditos.Font = new Font("Segoe UI", 12F);
            btnCreditos.ForeColor = Color.FromArgb(13, 43, 94);
            btnCreditos.Image = Properties.Resources.icone_sobre;
            btnCreditos.ImageAlign = ContentAlignment.MiddleLeft;
            btnCreditos.Location = new Point(14, 206);
            btnCreditos.Name = "btnCreditos";
            btnCreditos.Padding = new Padding(12, 0, 0, 0);
            btnCreditos.Size = new Size(192, 50);
            btnCreditos.TabIndex = 3;
            btnCreditos.Text = "Créditos";
            btnCreditos.TextAlign = ContentAlignment.MiddleLeft;
            btnCreditos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCreditos.UseVisualStyleBackColor = false;
            btnCreditos.Click += btnCreditos_Click;
            // 
            // btnFavoritos
            // 
            btnFavoritos.Cursor = Cursors.Hand;
            btnFavoritos.FlatAppearance.BorderSize = 0;
            btnFavoritos.FlatAppearance.MouseOverBackColor = Color.FromArgb(232, 242, 246);
            btnFavoritos.FlatStyle = FlatStyle.Flat;
            btnFavoritos.Font = new Font("Segoe UI", 12F);
            btnFavoritos.ForeColor = Color.FromArgb(13, 43, 94);
            btnFavoritos.Image = Properties.Resources.icone_favoritos;
            btnFavoritos.ImageAlign = ContentAlignment.MiddleLeft;
            btnFavoritos.Location = new Point(14, 148);
            btnFavoritos.Name = "btnFavoritos";
            btnFavoritos.Padding = new Padding(12, 0, 0, 0);
            btnFavoritos.Size = new Size(192, 50);
            btnFavoritos.TabIndex = 2;
            btnFavoritos.Text = "Favoritos";
            btnFavoritos.TextAlign = ContentAlignment.MiddleLeft;
            btnFavoritos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFavoritos.UseVisualStyleBackColor = false;
            btnFavoritos.Click += btnFavoritos_Click;
            // 
            // btnMapa
            // 
            btnMapa.Cursor = Cursors.Hand;
            btnMapa.FlatAppearance.BorderSize = 0;
            btnMapa.FlatAppearance.MouseOverBackColor = Color.FromArgb(232, 242, 246);
            btnMapa.FlatStyle = FlatStyle.Flat;
            btnMapa.Font = new Font("Segoe UI", 12F);
            btnMapa.ForeColor = Color.FromArgb(13, 43, 94);
            btnMapa.Image = Properties.Resources.icone_mapa;
            btnMapa.ImageAlign = ContentAlignment.MiddleLeft;
            btnMapa.Location = new Point(14, 90);
            btnMapa.Name = "btnMapa";
            btnMapa.Padding = new Padding(12, 0, 0, 0);
            btnMapa.Size = new Size(192, 50);
            btnMapa.TabIndex = 1;
            btnMapa.Text = "Mapa";
            btnMapa.TextAlign = ContentAlignment.MiddleLeft;
            btnMapa.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMapa.UseVisualStyleBackColor = false;
            btnMapa.Click += btnMapa_Click;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.FromArgb(206, 228, 236);
            btnInicio.Cursor = Cursors.Hand;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatAppearance.MouseOverBackColor = Color.FromArgb(232, 242, 246);
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Segoe UI", 12F);
            btnInicio.ForeColor = Color.FromArgb(13, 43, 94);
            btnInicio.Image = Properties.Resources.icone_inicio;
            btnInicio.ImageAlign = ContentAlignment.MiddleLeft;
            btnInicio.Location = new Point(14, 32);
            btnInicio.Name = "btnInicio";
            btnInicio.Padding = new Padding(12, 0, 0, 0);
            btnInicio.Size = new Size(192, 50);
            btnInicio.TabIndex = 0;
            btnInicio.Text = "Início";
            btnInicio.TextAlign = ContentAlignment.MiddleLeft;
            btnInicio.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // picIlustracaoMenu
            // 
            picIlustracaoMenu.Dock = DockStyle.Bottom;
            picIlustracaoMenu.Image = Properties.Resources.ilustracao_menu;
            picIlustracaoMenu.Location = new Point(0, 610);
            picIlustracaoMenu.Name = "picIlustracaoMenu";
            picIlustracaoMenu.Size = new Size(220, 190);
            picIlustracaoMenu.SizeMode = PictureBoxSizeMode.Zoom;
            picIlustracaoMenu.TabIndex = 5;
            picIlustracaoMenu.TabStop = false;
            // 
            // pnlLinhaMenu
            // 
            pnlLinhaMenu.BackColor = Color.FromArgb(196, 216, 224);
            pnlLinhaMenu.Dock = DockStyle.Left;
            pnlLinhaMenu.Location = new Point(220, 0);
            pnlLinhaMenu.Name = "pnlLinhaMenu";
            pnlLinhaMenu.Size = new Size(1, 800);
            pnlLinhaMenu.TabIndex = 1;
            // 
            // pnlConteudo
            // 
            pnlConteudo.Controls.Add(flpCards);
            pnlConteudo.Controls.Add(pnlTituloSecao);
            pnlConteudo.Controls.Add(pnlCabecalho);
            pnlConteudo.Dock = DockStyle.Fill;
            pnlConteudo.Location = new Point(221, 0);
            pnlConteudo.Name = "pnlConteudo";
            pnlConteudo.Size = new Size(1059, 800);
            pnlConteudo.TabIndex = 2;
            // 
            // flpCards
            // 
            flpCards.AutoScroll = true;
            flpCards.Controls.Add(lblNenhumResultado);
            flpCards.Dock = DockStyle.Fill;
            flpCards.Location = new Point(0, 382);
            flpCards.Name = "flpCards";
            flpCards.Padding = new Padding(44, 4, 20, 24);
            flpCards.Size = new Size(1059, 418);
            flpCards.TabIndex = 2;
            // 
            // lblNenhumResultado
            // 
            lblNenhumResultado.Font = new Font("Segoe UI", 12F);
            lblNenhumResultado.ForeColor = Color.FromArgb(88, 98, 112);
            lblNenhumResultado.Location = new Point(47, 24);
            lblNenhumResultado.Margin = new Padding(3, 20, 3, 0);
            lblNenhumResultado.Name = "lblNenhumResultado";
            lblNenhumResultado.Size = new Size(700, 60);
            lblNenhumResultado.TabIndex = 0;
            lblNenhumResultado.Text = "Nenhum lugar encontrado. Tente outra palavra ou outra categoria.";
            lblNenhumResultado.Visible = false;
            // 
            // pnlTituloSecao
            // 
            pnlTituloSecao.Controls.Add(btnSurpreenda);
            pnlTituloSecao.Controls.Add(lblQuantidade);
            pnlTituloSecao.Controls.Add(lblTituloSecao);
            pnlTituloSecao.Dock = DockStyle.Top;
            pnlTituloSecao.Location = new Point(0, 312);
            pnlTituloSecao.Name = "pnlTituloSecao";
            pnlTituloSecao.Size = new Size(1059, 70);
            pnlTituloSecao.TabIndex = 1;
            // 
            // btnSurpreenda
            // 
            btnSurpreenda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSurpreenda.BackColor = Color.FromArgb(242, 248, 250);
            btnSurpreenda.Cursor = Cursors.Hand;
            btnSurpreenda.FlatAppearance.BorderColor = Color.FromArgb(11, 107, 138);
            btnSurpreenda.FlatAppearance.BorderSize = 2;
            btnSurpreenda.FlatAppearance.MouseOverBackColor = Color.FromArgb(206, 228, 236);
            btnSurpreenda.FlatStyle = FlatStyle.Flat;
            btnSurpreenda.Font = new Font("Segoe UI Semibold", 11F);
            btnSurpreenda.ForeColor = Color.FromArgb(11, 107, 138);
            btnSurpreenda.Location = new Point(840, 14);
            btnSurpreenda.Name = "btnSurpreenda";
            btnSurpreenda.Size = new Size(190, 42);
            btnSurpreenda.TabIndex = 3;
            btnSurpreenda.Text = "Me surpreenda!";
            btnSurpreenda.UseVisualStyleBackColor = false;
            btnSurpreenda.Click += btnSurpreenda_Click;
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Font = new Font("Segoe UI", 11F);
            lblQuantidade.ForeColor = Color.FromArgb(88, 98, 112);
            lblQuantidade.Location = new Point(262, 30);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(77, 20);
            lblQuantidade.TabIndex = 1;
            lblQuantidade.Text = "21 lugares";
            // 
            // lblTituloSecao
            // 
            lblTituloSecao.AutoSize = true;
            lblTituloSecao.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTituloSecao.ForeColor = Color.FromArgb(13, 43, 94);
            lblTituloSecao.Location = new Point(40, 14);
            lblTituloSecao.Name = "lblTituloSecao";
            lblTituloSecao.Size = new Size(216, 41);
            lblTituloSecao.TabIndex = 0;
            lblTituloSecao.Text = "Explore Bauru";
            // 
            // pnlCabecalho
            // 
            pnlCabecalho.BackgroundImage = Properties.Resources.banner_cabecalho;
            pnlCabecalho.BackgroundImageLayout = ImageLayout.None;
            pnlCabecalho.Controls.Add(txtBusca);
            pnlCabecalho.Controls.Add(flpCategorias);
            pnlCabecalho.Controls.Add(lblSubtitulo);
            pnlCabecalho.Controls.Add(lblTitulo);
            pnlCabecalho.Controls.Add(picLogo);
            pnlCabecalho.Dock = DockStyle.Top;
            pnlCabecalho.Location = new Point(0, 0);
            pnlCabecalho.Name = "pnlCabecalho";
            pnlCabecalho.Size = new Size(1059, 312);
            pnlCabecalho.TabIndex = 0;
            // 
            // flpCategorias
            // 
            flpCategorias.BackColor = Color.Transparent;
            flpCategorias.Controls.Add(btnCategoriaTodos);
            flpCategorias.Controls.Add(btnCategoriaNatureza);
            flpCategorias.Controls.Add(btnCategoriaGastronomia);
            flpCategorias.Controls.Add(btnCategoriaLazerCultura);
            flpCategorias.Controls.Add(btnCategoriaCompras);
            flpCategorias.Location = new Point(44, 244);
            flpCategorias.Name = "flpCategorias";
            flpCategorias.Size = new Size(760, 56);
            flpCategorias.TabIndex = 4;
            flpCategorias.WrapContents = false;
            // 
            // btnCategoriaTodos
            // 
            btnCategoriaTodos.BackColor = Color.FromArgb(11, 107, 138);
            btnCategoriaTodos.Cursor = Cursors.Hand;
            btnCategoriaTodos.FlatAppearance.BorderColor = Color.FromArgb(11, 107, 138);
            btnCategoriaTodos.FlatStyle = FlatStyle.Flat;
            btnCategoriaTodos.Font = new Font("Segoe UI Semibold", 11F);
            btnCategoriaTodos.ForeColor = Color.White;
            btnCategoriaTodos.Location = new Point(4, 4);
            btnCategoriaTodos.Margin = new Padding(4, 4, 8, 4);
            btnCategoriaTodos.Name = "btnCategoriaTodos";
            btnCategoriaTodos.Size = new Size(110, 44);
            btnCategoriaTodos.TabIndex = 0;
            btnCategoriaTodos.Tag = "Todos";
            btnCategoriaTodos.Text = "✓ Todos";
            btnCategoriaTodos.UseVisualStyleBackColor = false;
            btnCategoriaTodos.Click += Categoria_Click;
            // 
            // btnCategoriaNatureza
            // 
            btnCategoriaNatureza.BackColor = Color.FromArgb(242, 248, 250);
            btnCategoriaNatureza.Cursor = Cursors.Hand;
            btnCategoriaNatureza.FlatAppearance.BorderColor = Color.FromArgb(196, 216, 224);
            btnCategoriaNatureza.FlatStyle = FlatStyle.Flat;
            btnCategoriaNatureza.Font = new Font("Segoe UI Semibold", 11F);
            btnCategoriaNatureza.ForeColor = Color.FromArgb(13, 43, 94);
            btnCategoriaNatureza.Location = new Point(126, 4);
            btnCategoriaNatureza.Margin = new Padding(4, 4, 8, 4);
            btnCategoriaNatureza.Name = "btnCategoriaNatureza";
            btnCategoriaNatureza.Size = new Size(130, 44);
            btnCategoriaNatureza.TabIndex = 1;
            btnCategoriaNatureza.Tag = "Natureza";
            btnCategoriaNatureza.Text = "Natureza";
            btnCategoriaNatureza.UseVisualStyleBackColor = false;
            btnCategoriaNatureza.Click += Categoria_Click;
            // 
            // btnCategoriaGastronomia
            // 
            btnCategoriaGastronomia.BackColor = Color.FromArgb(242, 248, 250);
            btnCategoriaGastronomia.Cursor = Cursors.Hand;
            btnCategoriaGastronomia.FlatAppearance.BorderColor = Color.FromArgb(196, 216, 224);
            btnCategoriaGastronomia.FlatStyle = FlatStyle.Flat;
            btnCategoriaGastronomia.Font = new Font("Segoe UI Semibold", 11F);
            btnCategoriaGastronomia.ForeColor = Color.FromArgb(13, 43, 94);
            btnCategoriaGastronomia.Location = new Point(268, 4);
            btnCategoriaGastronomia.Margin = new Padding(4, 4, 8, 4);
            btnCategoriaGastronomia.Name = "btnCategoriaGastronomia";
            btnCategoriaGastronomia.Size = new Size(160, 44);
            btnCategoriaGastronomia.TabIndex = 2;
            btnCategoriaGastronomia.Tag = "Gastronomia";
            btnCategoriaGastronomia.Text = "Gastronomia";
            btnCategoriaGastronomia.UseVisualStyleBackColor = false;
            btnCategoriaGastronomia.Click += Categoria_Click;
            // 
            // btnCategoriaLazerCultura
            // 
            btnCategoriaLazerCultura.BackColor = Color.FromArgb(242, 248, 250);
            btnCategoriaLazerCultura.Cursor = Cursors.Hand;
            btnCategoriaLazerCultura.FlatAppearance.BorderColor = Color.FromArgb(196, 216, 224);
            btnCategoriaLazerCultura.FlatStyle = FlatStyle.Flat;
            btnCategoriaLazerCultura.Font = new Font("Segoe UI Semibold", 11F);
            btnCategoriaLazerCultura.ForeColor = Color.FromArgb(13, 43, 94);
            btnCategoriaLazerCultura.Location = new Point(440, 4);
            btnCategoriaLazerCultura.Margin = new Padding(4, 4, 8, 4);
            btnCategoriaLazerCultura.Name = "btnCategoriaLazerCultura";
            btnCategoriaLazerCultura.Size = new Size(180, 44);
            btnCategoriaLazerCultura.TabIndex = 3;
            btnCategoriaLazerCultura.Tag = "Lazer e Cultura";
            btnCategoriaLazerCultura.Text = "Lazer e Cultura";
            btnCategoriaLazerCultura.UseVisualStyleBackColor = false;
            btnCategoriaLazerCultura.Click += Categoria_Click;
            // 
            // btnCategoriaCompras
            // 
            btnCategoriaCompras.BackColor = Color.FromArgb(242, 248, 250);
            btnCategoriaCompras.Cursor = Cursors.Hand;
            btnCategoriaCompras.FlatAppearance.BorderColor = Color.FromArgb(196, 216, 224);
            btnCategoriaCompras.FlatStyle = FlatStyle.Flat;
            btnCategoriaCompras.Font = new Font("Segoe UI Semibold", 11F);
            btnCategoriaCompras.ForeColor = Color.FromArgb(13, 43, 94);
            btnCategoriaCompras.Location = new Point(632, 4);
            btnCategoriaCompras.Margin = new Padding(4, 4, 8, 4);
            btnCategoriaCompras.Name = "btnCategoriaCompras";
            btnCategoriaCompras.Size = new Size(120, 44);
            btnCategoriaCompras.TabIndex = 4;
            btnCategoriaCompras.Tag = "Compras";
            btnCategoriaCompras.Text = "Compras";
            btnCategoriaCompras.UseVisualStyleBackColor = false;
            btnCategoriaCompras.Click += Categoria_Click;
            // 
            // txtBusca
            // 
            txtBusca.BorderStyle = BorderStyle.None;
            txtBusca.Font = new Font("Segoe UI", 13F);
            txtBusca.ForeColor = Color.FromArgb(40, 48, 60);
            txtBusca.Location = new Point(40, 183);
            txtBusca.Name = "txtBusca";
            txtBusca.PlaceholderText = "Buscar pontos turísticos...";
            txtBusca.Size = new Size(594, 24);
            txtBusca.TabIndex = 0;
            txtBusca.TextChanged += txtBusca_TextChanged;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.BackColor = Color.Transparent;
            lblSubtitulo.Font = new Font("Segoe UI", 17F);
            lblSubtitulo.ForeColor = Color.FromArgb(13, 43, 94);
            lblSubtitulo.Location = new Point(158, 97);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(383, 31);
            lblSubtitulo.TabIndex = 2;
            lblSubtitulo.Text = "Descubra lugares incríveis em Bauru";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 34F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(13, 43, 94);
            lblTitulo.Location = new Point(158, 32);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(294, 62);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Bauru's Tour";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.Image = Properties.Resources.logo;
            picLogo.Location = new Point(44, 20);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(108, 108);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // FormBusca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(222, 236, 242);
            ClientSize = new Size(1280, 800);
            Controls.Add(pnlConteudo);
            Controls.Add(pnlLinhaMenu);
            Controls.Add(pnlMenu);
            Icon = Properties.Resources.icone;
            KeyPreview = true;
            MinimumSize = new Size(1040, 700);
            Name = "FormBusca";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bauru's Tour";
            WindowState = FormWindowState.Maximized;
            Load += FormBusca_Load;
            KeyDown += FormBusca_KeyDown;
            pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picIlustracaoMenu).EndInit();
            pnlConteudo.ResumeLayout(false);
            flpCards.ResumeLayout(false);
            pnlTituloSecao.ResumeLayout(false);
            pnlTituloSecao.PerformLayout();
            pnlCabecalho.ResumeLayout(false);
            pnlCabecalho.PerformLayout();
            flpCategorias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenu;
        private Button btnInicio;
        private Button btnMapa;
        private Button btnFavoritos;
        private Button btnCreditos;
        private PictureBox picIlustracaoMenu;
        private Panel pnlLinhaMenu;
        private Panel pnlConteudo;
        private Panel pnlCabecalho;
        private PictureBox picLogo;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private TextBox txtBusca;
        private FlowLayoutPanel flpCategorias;
        private Button btnCategoriaTodos;
        private Button btnCategoriaNatureza;
        private Button btnCategoriaGastronomia;
        private Button btnCategoriaLazerCultura;
        private Button btnCategoriaCompras;
        private Panel pnlTituloSecao;
        private Label lblTituloSecao;
        private Label lblQuantidade;
        private Button btnSurpreenda;
        private FlowLayoutPanel flpCards;
        private Label lblNenhumResultado;
    }
}
