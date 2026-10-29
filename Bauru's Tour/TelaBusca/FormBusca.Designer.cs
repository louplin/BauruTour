namespace BaurusTour.TelaBusca
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
            btnTelaCheia = new Button();
            btnSobre = new Button();
            btnFavoritos = new Button();
            btnMapa = new Button();
            btnInicio = new Button();
            picIlustracaoMenu = new PictureBox();
            pnlLinhaMenu = new Panel();
            pnlConteudo = new Panel();
            flpCards = new FlowLayoutPanel();
            lblNenhumResultado = new Label();
            pnlSobre = new Panel();
            pnlCaixaSobre = new Panel();
            lblAtalhos = new Label();
            btnGuia = new Button();
            lblEquipe = new Label();
            lblSobreTexto = new Label();
            lblSobreTitulo = new Label();
            pnlTituloSecao = new Panel();
            btnVerTodos = new Button();
            lblQuantidade = new Label();
            lblTituloSecao = new Label();
            pnlCabecalho = new Panel();
            flpCategorias = new FlowLayoutPanel();
            btnCategoriaTodos = new Button();
            btnCategoriaNatureza = new Button();
            btnCategoriaGastronomia = new Button();
            btnCategoriaLazerCultura = new Button();
            btnCategoriaCompras = new Button();
            pnlBusca = new Panel();
            btnBuscar = new Button();
            txtBusca = new TextBox();
            picLupa = new PictureBox();
            lblSubtitulo = new Label();
            lblTitulo = new Label();
            picLogo = new PictureBox();
            pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picIlustracaoMenu).BeginInit();
            pnlConteudo.SuspendLayout();
            flpCards.SuspendLayout();
            pnlSobre.SuspendLayout();
            pnlCaixaSobre.SuspendLayout();
            pnlTituloSecao.SuspendLayout();
            pnlCabecalho.SuspendLayout();
            flpCategorias.SuspendLayout();
            pnlBusca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLupa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            //
            // pnlMenu
            //
            pnlMenu.BackColor = Color.White;
            pnlMenu.Controls.Add(btnTelaCheia);
            pnlMenu.Controls.Add(btnSobre);
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
            // btnTelaCheia
            //
            btnTelaCheia.BackColor = Color.White;
            btnTelaCheia.Cursor = Cursors.Hand;
            btnTelaCheia.FlatAppearance.BorderSize = 0;
            btnTelaCheia.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 244, 246);
            btnTelaCheia.FlatStyle = FlatStyle.Flat;
            btnTelaCheia.Font = new Font("Segoe UI", 12F);
            btnTelaCheia.ForeColor = Color.FromArgb(13, 43, 94);
            btnTelaCheia.Image = Properties.Resources.icone_tela_cheia;
            btnTelaCheia.ImageAlign = ContentAlignment.MiddleLeft;
            btnTelaCheia.Location = new Point(14, 290);
            btnTelaCheia.Name = "btnTelaCheia";
            btnTelaCheia.Padding = new Padding(12, 0, 0, 0);
            btnTelaCheia.Size = new Size(192, 50);
            btnTelaCheia.TabIndex = 4;
            btnTelaCheia.Text = "Tela cheia";
            btnTelaCheia.TextAlign = ContentAlignment.MiddleLeft;
            btnTelaCheia.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTelaCheia.UseVisualStyleBackColor = false;
            btnTelaCheia.Click += btnTelaCheia_Click;
            //
            // btnSobre
            //
            btnSobre.BackColor = Color.White;
            btnSobre.Cursor = Cursors.Hand;
            btnSobre.FlatAppearance.BorderSize = 0;
            btnSobre.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 244, 246);
            btnSobre.FlatStyle = FlatStyle.Flat;
            btnSobre.Font = new Font("Segoe UI", 12F);
            btnSobre.ForeColor = Color.FromArgb(13, 43, 94);
            btnSobre.Image = Properties.Resources.icone_sobre;
            btnSobre.ImageAlign = ContentAlignment.MiddleLeft;
            btnSobre.Location = new Point(14, 206);
            btnSobre.Name = "btnSobre";
            btnSobre.Padding = new Padding(12, 0, 0, 0);
            btnSobre.Size = new Size(192, 50);
            btnSobre.TabIndex = 3;
            btnSobre.Text = "Sobre";
            btnSobre.TextAlign = ContentAlignment.MiddleLeft;
            btnSobre.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSobre.UseVisualStyleBackColor = false;
            btnSobre.Click += btnSobre_Click;
            //
            // btnFavoritos
            //
            btnFavoritos.BackColor = Color.White;
            btnFavoritos.Cursor = Cursors.Hand;
            btnFavoritos.FlatAppearance.BorderSize = 0;
            btnFavoritos.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 244, 246);
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
            btnMapa.BackColor = Color.White;
            btnMapa.Cursor = Cursors.Hand;
            btnMapa.FlatAppearance.BorderSize = 0;
            btnMapa.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 244, 246);
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
            btnInicio.BackColor = Color.FromArgb(228, 241, 245);
            btnInicio.Cursor = Cursors.Hand;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 244, 246);
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
            pnlLinhaMenu.BackColor = Color.FromArgb(220, 226, 230);
            pnlLinhaMenu.Dock = DockStyle.Left;
            pnlLinhaMenu.Location = new Point(220, 0);
            pnlLinhaMenu.Name = "pnlLinhaMenu";
            pnlLinhaMenu.Size = new Size(1, 800);
            pnlLinhaMenu.TabIndex = 1;
            //
            // pnlConteudo
            //
            pnlConteudo.BackColor = Color.FromArgb(247, 248, 246);
            pnlConteudo.Controls.Add(flpCards);
            pnlConteudo.Controls.Add(pnlSobre);
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
            // pnlSobre
            //
            pnlSobre.AutoScroll = true;
            pnlSobre.Controls.Add(pnlCaixaSobre);
            pnlSobre.Dock = DockStyle.Fill;
            pnlSobre.Location = new Point(0, 382);
            pnlSobre.Name = "pnlSobre";
            pnlSobre.Size = new Size(1059, 418);
            pnlSobre.TabIndex = 3;
            pnlSobre.Visible = false;
            //
            // pnlCaixaSobre
            //
            pnlCaixaSobre.BackColor = Color.White;
            pnlCaixaSobre.BorderStyle = BorderStyle.FixedSingle;
            pnlCaixaSobre.Controls.Add(lblAtalhos);
            pnlCaixaSobre.Controls.Add(btnGuia);
            pnlCaixaSobre.Controls.Add(lblEquipe);
            pnlCaixaSobre.Controls.Add(lblSobreTexto);
            pnlCaixaSobre.Controls.Add(lblSobreTitulo);
            pnlCaixaSobre.Location = new Point(48, 8);
            pnlCaixaSobre.Name = "pnlCaixaSobre";
            pnlCaixaSobre.Size = new Size(860, 428);
            pnlCaixaSobre.TabIndex = 0;
            //
            // lblAtalhos
            //
            lblAtalhos.AutoSize = true;
            lblAtalhos.Font = new Font("Segoe UI", 9.75F);
            lblAtalhos.ForeColor = Color.FromArgb(88, 98, 112);
            lblAtalhos.Location = new Point(34, 386);
            lblAtalhos.Name = "lblAtalhos";
            lblAtalhos.Size = new Size(380, 17);
            lblAtalhos.TabIndex = 4;
            lblAtalhos.Text = "Atalhos:  F11 = tela cheia   |   Esc = sair da tela cheia";
            //
            // btnGuia
            //
            btnGuia.BackColor = Color.FromArgb(11, 107, 138);
            btnGuia.Cursor = Cursors.Hand;
            btnGuia.FlatAppearance.BorderSize = 0;
            btnGuia.FlatAppearance.MouseOverBackColor = Color.FromArgb(7, 84, 110);
            btnGuia.FlatStyle = FlatStyle.Flat;
            btnGuia.Font = new Font("Segoe UI Semibold", 11F);
            btnGuia.ForeColor = Color.White;
            btnGuia.Image = Properties.Resources.icone_documento_branco;
            btnGuia.Location = new Point(32, 318);
            btnGuia.Name = "btnGuia";
            btnGuia.Size = new Size(270, 50);
            btnGuia.TabIndex = 3;
            btnGuia.Text = "Abrir guia de uso (PDF)";
            btnGuia.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuia.UseVisualStyleBackColor = false;
            btnGuia.Click += btnGuia_Click;
            //
            // lblEquipe
            //
            lblEquipe.Font = new Font("Segoe UI Semibold", 10.5F);
            lblEquipe.ForeColor = Color.FromArgb(13, 43, 94);
            lblEquipe.Location = new Point(34, 278);
            lblEquipe.Name = "lblEquipe";
            lblEquipe.Size = new Size(790, 24);
            lblEquipe.TabIndex = 2;
            lblEquipe.Text = "Desenvolvido por: Olavo Faustino e equipe";
            //
            // lblSobreTexto
            //
            lblSobreTexto.Font = new Font("Segoe UI", 11F);
            lblSobreTexto.ForeColor = Color.FromArgb(40, 48, 60);
            lblSobreTexto.Location = new Point(34, 82);
            lblSobreTexto.Name = "lblSobreTexto";
            lblSobreTexto.Size = new Size(790, 186);
            lblSobreTexto.TabIndex = 1;
            lblSobreTexto.Text = "O Bauru's Tour é um guia dos pontos turísticos de Bauru (SP), feito em C# com Windows Forms como trabalho da faculdade.\r\n\r\nNo app dá pra buscar um lugar pelo nome, filtrar por categoria, ver os detalhes de cada ponto, abrir a localização no Google Maps, mandar o link pelo WhatsApp e guardar os seus favoritos.\r\n\r\nOs lugares ficam no arquivo pontos.json e os favoritos são salvos no próprio computador, então continuam lá quando você abre o app de novo.";
            //
            // lblSobreTitulo
            //
            lblSobreTitulo.AutoSize = true;
            lblSobreTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblSobreTitulo.ForeColor = Color.FromArgb(13, 43, 94);
            lblSobreTitulo.Location = new Point(30, 28);
            lblSobreTitulo.Name = "lblSobreTitulo";
            lblSobreTitulo.Size = new Size(285, 37);
            lblSobreTitulo.TabIndex = 0;
            lblSobreTitulo.Text = "Sobre o Bauru's Tour";
            //
            // pnlTituloSecao
            //
            pnlTituloSecao.Controls.Add(btnVerTodos);
            pnlTituloSecao.Controls.Add(lblQuantidade);
            pnlTituloSecao.Controls.Add(lblTituloSecao);
            pnlTituloSecao.Dock = DockStyle.Top;
            pnlTituloSecao.Location = new Point(0, 312);
            pnlTituloSecao.Name = "pnlTituloSecao";
            pnlTituloSecao.Size = new Size(1059, 70);
            pnlTituloSecao.TabIndex = 1;
            //
            // btnVerTodos
            //
            btnVerTodos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnVerTodos.Cursor = Cursors.Hand;
            btnVerTodos.FlatAppearance.BorderSize = 0;
            btnVerTodos.FlatAppearance.MouseOverBackColor = Color.FromArgb(228, 241, 245);
            btnVerTodos.FlatStyle = FlatStyle.Flat;
            btnVerTodos.Font = new Font("Segoe UI Semibold", 12F);
            btnVerTodos.ForeColor = Color.FromArgb(11, 107, 138);
            btnVerTodos.Image = Properties.Resources.icone_seta;
            btnVerTodos.Location = new Point(880, 16);
            btnVerTodos.Name = "btnVerTodos";
            btnVerTodos.Size = new Size(150, 40);
            btnVerTodos.TabIndex = 2;
            btnVerTodos.Text = "Ver todos";
            btnVerTodos.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnVerTodos.UseVisualStyleBackColor = true;
            btnVerTodos.Click += btnVerTodos_Click;
            //
            // lblQuantidade
            //
            lblQuantidade.AutoSize = true;
            lblQuantidade.Font = new Font("Segoe UI", 11F);
            lblQuantidade.ForeColor = Color.FromArgb(88, 98, 112);
            lblQuantidade.Location = new Point(300, 28);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(76, 20);
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
            lblTituloSecao.Size = new Size(206, 41);
            lblTituloSecao.TabIndex = 0;
            lblTituloSecao.Text = "Explore Bauru";
            //
            // pnlCabecalho
            //
            pnlCabecalho.BackgroundImage = Properties.Resources.banner_cabecalho;
            pnlCabecalho.BackgroundImageLayout = ImageLayout.None;
            pnlCabecalho.Controls.Add(flpCategorias);
            pnlCabecalho.Controls.Add(pnlBusca);
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
            btnCategoriaTodos.Text = "Todos";
            btnCategoriaTodos.UseVisualStyleBackColor = false;
            btnCategoriaTodos.Click += Categoria_Click;
            //
            // btnCategoriaNatureza
            //
            btnCategoriaNatureza.BackColor = Color.White;
            btnCategoriaNatureza.Cursor = Cursors.Hand;
            btnCategoriaNatureza.FlatAppearance.BorderColor = Color.FromArgb(220, 226, 230);
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
            btnCategoriaGastronomia.BackColor = Color.White;
            btnCategoriaGastronomia.Cursor = Cursors.Hand;
            btnCategoriaGastronomia.FlatAppearance.BorderColor = Color.FromArgb(220, 226, 230);
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
            btnCategoriaLazerCultura.BackColor = Color.White;
            btnCategoriaLazerCultura.Cursor = Cursors.Hand;
            btnCategoriaLazerCultura.FlatAppearance.BorderColor = Color.FromArgb(220, 226, 230);
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
            btnCategoriaCompras.BackColor = Color.White;
            btnCategoriaCompras.Cursor = Cursors.Hand;
            btnCategoriaCompras.FlatAppearance.BorderColor = Color.FromArgb(220, 226, 230);
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
            // pnlBusca
            //
            pnlBusca.BackColor = Color.White;
            pnlBusca.BorderStyle = BorderStyle.FixedSingle;
            pnlBusca.Controls.Add(btnBuscar);
            pnlBusca.Controls.Add(txtBusca);
            pnlBusca.Controls.Add(picLupa);
            pnlBusca.Location = new Point(48, 164);
            pnlBusca.Name = "pnlBusca";
            pnlBusca.Size = new Size(760, 60);
            pnlBusca.TabIndex = 3;
            //
            // btnBuscar
            //
            btnBuscar.BackColor = Color.FromArgb(11, 107, 138);
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatAppearance.MouseOverBackColor = Color.FromArgb(7, 84, 110);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI Semibold", 12F);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Image = Properties.Resources.icone_buscar_branco;
            btnBuscar.Location = new Point(606, 6);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(146, 46);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            //
            // txtBusca
            //
            txtBusca.BorderStyle = BorderStyle.None;
            txtBusca.Font = new Font("Segoe UI", 13F);
            txtBusca.ForeColor = Color.FromArgb(40, 48, 60);
            txtBusca.Location = new Point(54, 16);
            txtBusca.Name = "txtBusca";
            txtBusca.PlaceholderText = "Buscar pontos turísticos...";
            txtBusca.Size = new Size(540, 24);
            txtBusca.TabIndex = 0;
            txtBusca.TextChanged += txtBusca_TextChanged;
            //
            // picLupa
            //
            picLupa.Image = Properties.Resources.icone_buscar;
            picLupa.Location = new Point(18, 17);
            picLupa.Name = "picLupa";
            picLupa.Size = new Size(24, 24);
            picLupa.TabIndex = 2;
            picLupa.TabStop = false;
            //
            // lblSubtitulo
            //
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.BackColor = Color.Transparent;
            lblSubtitulo.Font = new Font("Segoe UI", 17F);
            lblSubtitulo.ForeColor = Color.FromArgb(13, 43, 94);
            lblSubtitulo.Location = new Point(170, 98);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(376, 31);
            lblSubtitulo.TabIndex = 2;
            lblSubtitulo.Text = "Descubra lugares incríveis em Bauru";
            //
            // lblTitulo
            //
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 34F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(13, 43, 94);
            lblTitulo.Location = new Point(160, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(300, 61);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Bauru's Tour";
            //
            // picLogo
            //
            picLogo.BackColor = Color.Transparent;
            picLogo.Image = Properties.Resources.logo;
            picLogo.Location = new Point(44, 26);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(108, 108);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            //
            // FormBusca
            //
            AcceptButton = btnBuscar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 248, 246);
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
            pnlSobre.ResumeLayout(false);
            pnlCaixaSobre.ResumeLayout(false);
            pnlCaixaSobre.PerformLayout();
            pnlTituloSecao.ResumeLayout(false);
            pnlTituloSecao.PerformLayout();
            pnlCabecalho.ResumeLayout(false);
            pnlCabecalho.PerformLayout();
            flpCategorias.ResumeLayout(false);
            pnlBusca.ResumeLayout(false);
            pnlBusca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLupa).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenu;
        private Button btnInicio;
        private Button btnMapa;
        private Button btnFavoritos;
        private Button btnSobre;
        private Button btnTelaCheia;
        private PictureBox picIlustracaoMenu;
        private Panel pnlLinhaMenu;
        private Panel pnlConteudo;
        private Panel pnlCabecalho;
        private PictureBox picLogo;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private Panel pnlBusca;
        private PictureBox picLupa;
        private TextBox txtBusca;
        private Button btnBuscar;
        private FlowLayoutPanel flpCategorias;
        private Button btnCategoriaTodos;
        private Button btnCategoriaNatureza;
        private Button btnCategoriaGastronomia;
        private Button btnCategoriaLazerCultura;
        private Button btnCategoriaCompras;
        private Panel pnlTituloSecao;
        private Label lblTituloSecao;
        private Label lblQuantidade;
        private Button btnVerTodos;
        private FlowLayoutPanel flpCards;
        private Label lblNenhumResultado;
        private Panel pnlSobre;
        private Panel pnlCaixaSobre;
        private Label lblSobreTitulo;
        private Label lblSobreTexto;
        private Label lblEquipe;
        private Button btnGuia;
        private Label lblAtalhos;
    }
}
