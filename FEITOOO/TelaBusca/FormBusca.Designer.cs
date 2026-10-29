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
            pnlMenuLateral = new Panel();
            btnMenuTelaCheia = new BaurusTour.Componentes.BotaoArredondado();
            btnMenuSobre = new BaurusTour.Componentes.BotaoArredondado();
            btnMenuFavoritos = new BaurusTour.Componentes.BotaoArredondado();
            btnMenuMapa = new BaurusTour.Componentes.BotaoArredondado();
            btnMenuInicio = new BaurusTour.Componentes.BotaoArredondado();
            picIlustracaoMenu = new PictureBox();
            pnlDivisorMenu = new Panel();
            pnlPrincipal = new Panel();
            flpCards = new FlowLayoutPanel();
            lblSemResultados = new Label();
            pnlSobre = new Panel();
            pnlCartaoSobre = new BaurusTour.Componentes.PainelArredondado();
            lblAtalhos = new Label();
            btnGuiaSobre = new BaurusTour.Componentes.BotaoArredondado();
            lblSobreEquipe = new Label();
            lblSobreTexto = new Label();
            lblSobreTitulo = new Label();
            pnlTituloSecao = new Panel();
            btnVerTodos = new BaurusTour.Componentes.BotaoArredondado();
            flpTituloSecao = new FlowLayoutPanel();
            lblTituloSecao = new Label();
            lblQuantidade = new Label();
            pnlCabecalho = new BaurusTour.Componentes.PainelCabecalho();
            flpCategorias = new FlowLayoutPanel();
            btnCategoriaTodos = new BaurusTour.Componentes.BotaoArredondado();
            btnCategoriaNatureza = new BaurusTour.Componentes.BotaoArredondado();
            btnCategoriaGastronomia = new BaurusTour.Componentes.BotaoArredondado();
            btnCategoriaLazerCultura = new BaurusTour.Componentes.BotaoArredondado();
            btnCategoriaCompras = new BaurusTour.Componentes.BotaoArredondado();
            pnlCaixaBusca = new BaurusTour.Componentes.PainelArredondado();
            btnBuscar = new BaurusTour.Componentes.BotaoArredondado();
            txtBusca = new TextBox();
            lblIconeBusca = new Label();
            lblSubtitulo = new Label();
            lblTitulo = new Label();
            picLogo = new PictureBox();
            pnlMenuLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picIlustracaoMenu).BeginInit();
            pnlPrincipal.SuspendLayout();
            flpCards.SuspendLayout();
            pnlSobre.SuspendLayout();
            pnlCartaoSobre.SuspendLayout();
            pnlTituloSecao.SuspendLayout();
            flpTituloSecao.SuspendLayout();
            pnlCabecalho.SuspendLayout();
            flpCategorias.SuspendLayout();
            pnlCaixaBusca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            //
            // pnlMenuLateral
            //
            pnlMenuLateral.BackColor = Color.White;
            pnlMenuLateral.Controls.Add(btnMenuTelaCheia);
            pnlMenuLateral.Controls.Add(btnMenuSobre);
            pnlMenuLateral.Controls.Add(btnMenuFavoritos);
            pnlMenuLateral.Controls.Add(btnMenuMapa);
            pnlMenuLateral.Controls.Add(btnMenuInicio);
            pnlMenuLateral.Controls.Add(picIlustracaoMenu);
            pnlMenuLateral.Dock = DockStyle.Left;
            pnlMenuLateral.Location = new Point(0, 0);
            pnlMenuLateral.Name = "pnlMenuLateral";
            pnlMenuLateral.Size = new Size(220, 800);
            pnlMenuLateral.TabIndex = 0;
            //
            // btnMenuTelaCheia
            //
            btnMenuTelaCheia.Alinhamento = HorizontalAlignment.Left;
            btnMenuTelaCheia.CorFundo = Color.White;
            btnMenuTelaCheia.CorFundoHover = Color.FromArgb(240, 244, 246);
            btnMenuTelaCheia.Font = new Font("Segoe UI", 12F);
            btnMenuTelaCheia.ForeColor = Color.FromArgb(13, 43, 94);
            btnMenuTelaCheia.Icone = "";
            btnMenuTelaCheia.Location = new Point(14, 290);
            btnMenuTelaCheia.Name = "btnMenuTelaCheia";
            btnMenuTelaCheia.Raio = 14;
            btnMenuTelaCheia.Size = new Size(192, 50);
            btnMenuTelaCheia.TabIndex = 4;
            btnMenuTelaCheia.Text = "Tela cheia";
            btnMenuTelaCheia.Click += btnMenuTelaCheia_Click;
            //
            // btnMenuSobre
            //
            btnMenuSobre.Alinhamento = HorizontalAlignment.Left;
            btnMenuSobre.CorFundo = Color.White;
            btnMenuSobre.CorFundoHover = Color.FromArgb(240, 244, 246);
            btnMenuSobre.Font = new Font("Segoe UI", 12F);
            btnMenuSobre.ForeColor = Color.FromArgb(13, 43, 94);
            btnMenuSobre.Icone = "";
            btnMenuSobre.Location = new Point(14, 206);
            btnMenuSobre.Name = "btnMenuSobre";
            btnMenuSobre.Raio = 14;
            btnMenuSobre.Size = new Size(192, 50);
            btnMenuSobre.TabIndex = 3;
            btnMenuSobre.Text = "Sobre";
            btnMenuSobre.Click += btnMenuSobre_Click;
            //
            // btnMenuFavoritos
            //
            btnMenuFavoritos.Alinhamento = HorizontalAlignment.Left;
            btnMenuFavoritos.CorFundo = Color.White;
            btnMenuFavoritos.CorFundoHover = Color.FromArgb(240, 244, 246);
            btnMenuFavoritos.Font = new Font("Segoe UI", 12F);
            btnMenuFavoritos.ForeColor = Color.FromArgb(13, 43, 94);
            btnMenuFavoritos.Icone = "";
            btnMenuFavoritos.Location = new Point(14, 148);
            btnMenuFavoritos.Name = "btnMenuFavoritos";
            btnMenuFavoritos.Raio = 14;
            btnMenuFavoritos.Size = new Size(192, 50);
            btnMenuFavoritos.TabIndex = 2;
            btnMenuFavoritos.Text = "Favoritos";
            btnMenuFavoritos.Click += btnMenuFavoritos_Click;
            //
            // btnMenuMapa
            //
            btnMenuMapa.Alinhamento = HorizontalAlignment.Left;
            btnMenuMapa.CorFundo = Color.White;
            btnMenuMapa.CorFundoHover = Color.FromArgb(240, 244, 246);
            btnMenuMapa.Font = new Font("Segoe UI", 12F);
            btnMenuMapa.ForeColor = Color.FromArgb(13, 43, 94);
            btnMenuMapa.Icone = "";
            btnMenuMapa.Location = new Point(14, 90);
            btnMenuMapa.Name = "btnMenuMapa";
            btnMenuMapa.Raio = 14;
            btnMenuMapa.Size = new Size(192, 50);
            btnMenuMapa.TabIndex = 1;
            btnMenuMapa.Text = "Mapa";
            btnMenuMapa.Click += btnMenuMapa_Click;
            //
            // btnMenuInicio
            //
            btnMenuInicio.Alinhamento = HorizontalAlignment.Left;
            btnMenuInicio.CorFundo = Color.FromArgb(228, 241, 245);
            btnMenuInicio.CorFundoHover = Color.FromArgb(228, 241, 245);
            btnMenuInicio.Font = new Font("Segoe UI", 12F);
            btnMenuInicio.ForeColor = Color.FromArgb(13, 43, 94);
            btnMenuInicio.Icone = "";
            btnMenuInicio.Location = new Point(14, 32);
            btnMenuInicio.Name = "btnMenuInicio";
            btnMenuInicio.Raio = 14;
            btnMenuInicio.Size = new Size(192, 50);
            btnMenuInicio.TabIndex = 0;
            btnMenuInicio.Text = "Início";
            btnMenuInicio.Click += btnMenuInicio_Click;
            //
            // picIlustracaoMenu
            //
            picIlustracaoMenu.BackColor = Color.White;
            picIlustracaoMenu.Dock = DockStyle.Bottom;
            picIlustracaoMenu.Location = new Point(0, 610);
            picIlustracaoMenu.Name = "picIlustracaoMenu";
            picIlustracaoMenu.Padding = new Padding(8, 0, 8, 12);
            picIlustracaoMenu.Size = new Size(220, 190);
            picIlustracaoMenu.SizeMode = PictureBoxSizeMode.Zoom;
            picIlustracaoMenu.TabIndex = 5;
            picIlustracaoMenu.TabStop = false;
            //
            // pnlDivisorMenu
            //
            pnlDivisorMenu.BackColor = Color.FromArgb(220, 226, 230);
            pnlDivisorMenu.Dock = DockStyle.Left;
            pnlDivisorMenu.Location = new Point(220, 0);
            pnlDivisorMenu.Name = "pnlDivisorMenu";
            pnlDivisorMenu.Size = new Size(1, 800);
            pnlDivisorMenu.TabIndex = 1;
            //
            // pnlPrincipal
            //
            pnlPrincipal.BackColor = Color.FromArgb(247, 248, 246);
            pnlPrincipal.Controls.Add(flpCards);
            pnlPrincipal.Controls.Add(pnlSobre);
            pnlPrincipal.Controls.Add(pnlTituloSecao);
            pnlPrincipal.Controls.Add(pnlCabecalho);
            pnlPrincipal.Dock = DockStyle.Fill;
            pnlPrincipal.Location = new Point(221, 0);
            pnlPrincipal.Name = "pnlPrincipal";
            pnlPrincipal.Size = new Size(1059, 800);
            pnlPrincipal.TabIndex = 2;
            //
            // flpCards
            //
            flpCards.AutoScroll = true;
            flpCards.BackColor = Color.FromArgb(247, 248, 246);
            flpCards.Controls.Add(lblSemResultados);
            flpCards.Dock = DockStyle.Fill;
            flpCards.Location = new Point(0, 382);
            flpCards.Name = "flpCards";
            flpCards.Padding = new Padding(44, 4, 20, 24);
            flpCards.Size = new Size(1059, 418);
            flpCards.TabIndex = 2;
            flpCards.Resize += flpCards_Resize;
            //
            // lblSemResultados
            //
            lblSemResultados.Font = new Font("Segoe UI", 12F);
            lblSemResultados.ForeColor = Color.FromArgb(88, 98, 112);
            lblSemResultados.Location = new Point(44, 44);
            lblSemResultados.Margin = new Padding(0, 40, 0, 0);
            lblSemResultados.Name = "lblSemResultados";
            lblSemResultados.Size = new Size(960, 140);
            lblSemResultados.TabIndex = 0;
            lblSemResultados.Text = "Nenhum lugar encontrado.";
            lblSemResultados.TextAlign = ContentAlignment.MiddleCenter;
            lblSemResultados.Visible = false;
            //
            // pnlSobre
            //
            pnlSobre.AutoScroll = true;
            pnlSobre.BackColor = Color.FromArgb(247, 248, 246);
            pnlSobre.Controls.Add(pnlCartaoSobre);
            pnlSobre.Dock = DockStyle.Fill;
            pnlSobre.Location = new Point(0, 382);
            pnlSobre.Name = "pnlSobre";
            pnlSobre.Size = new Size(1059, 418);
            pnlSobre.TabIndex = 3;
            pnlSobre.Visible = false;
            //
            // pnlCartaoSobre
            //
            pnlCartaoSobre.Controls.Add(lblAtalhos);
            pnlCartaoSobre.Controls.Add(btnGuiaSobre);
            pnlCartaoSobre.Controls.Add(lblSobreEquipe);
            pnlCartaoSobre.Controls.Add(lblSobreTexto);
            pnlCartaoSobre.Controls.Add(lblSobreTitulo);
            pnlCartaoSobre.Location = new Point(48, 8);
            pnlCartaoSobre.Name = "pnlCartaoSobre";
            pnlCartaoSobre.Raio = 18;
            pnlCartaoSobre.Size = new Size(860, 428);
            pnlCartaoSobre.TabIndex = 0;
            //
            // lblAtalhos
            //
            lblAtalhos.AutoSize = true;
            lblAtalhos.BackColor = Color.Transparent;
            lblAtalhos.Font = new Font("Segoe UI", 9.75F);
            lblAtalhos.ForeColor = Color.FromArgb(88, 98, 112);
            lblAtalhos.Location = new Point(34, 386);
            lblAtalhos.Name = "lblAtalhos";
            lblAtalhos.Size = new Size(470, 17);
            lblAtalhos.TabIndex = 4;
            lblAtalhos.Text = "Atalhos:  F11 = tela cheia   |   Esc = sair da tela cheia   |   Ctrl + F = buscar";
            //
            // btnGuiaSobre
            //
            btnGuiaSobre.Font = new Font("Segoe UI Semibold", 11F);
            btnGuiaSobre.Icone = "";
            btnGuiaSobre.Location = new Point(32, 318);
            btnGuiaSobre.Name = "btnGuiaSobre";
            btnGuiaSobre.Size = new Size(270, 50);
            btnGuiaSobre.TabIndex = 3;
            btnGuiaSobre.Text = "Abrir guia de uso (PDF)";
            btnGuiaSobre.Click += btnGuiaSobre_Click;
            //
            // lblSobreEquipe
            //
            lblSobreEquipe.BackColor = Color.Transparent;
            lblSobreEquipe.Font = new Font("Segoe UI Semibold", 10.5F);
            lblSobreEquipe.ForeColor = Color.FromArgb(13, 43, 94);
            lblSobreEquipe.Location = new Point(34, 278);
            lblSobreEquipe.Name = "lblSobreEquipe";
            lblSobreEquipe.Size = new Size(790, 24);
            lblSobreEquipe.TabIndex = 2;
            lblSobreEquipe.Text = "Desenvolvido por: Olavo Faustino e equipe";
            //
            // lblSobreTexto
            //
            lblSobreTexto.BackColor = Color.Transparent;
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
            lblSobreTitulo.BackColor = Color.Transparent;
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
            pnlTituloSecao.Controls.Add(flpTituloSecao);
            pnlTituloSecao.Dock = DockStyle.Top;
            pnlTituloSecao.Location = new Point(0, 312);
            pnlTituloSecao.Name = "pnlTituloSecao";
            pnlTituloSecao.Size = new Size(1059, 70);
            pnlTituloSecao.TabIndex = 1;
            //
            // btnVerTodos
            //
            btnVerTodos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnVerTodos.CorFundo = Color.Transparent;
            btnVerTodos.CorFundoHover = Color.FromArgb(228, 241, 245);
            btnVerTodos.Font = new Font("Segoe UI Semibold", 12F);
            btnVerTodos.ForeColor = Color.FromArgb(11, 107, 138);
            btnVerTodos.Icone = "";
            btnVerTodos.IconeADireita = true;
            btnVerTodos.Location = new Point(887, 16);
            btnVerTodos.Name = "btnVerTodos";
            btnVerTodos.Raio = 18;
            btnVerTodos.Size = new Size(140, 40);
            btnVerTodos.TabIndex = 1;
            btnVerTodos.Text = "Ver todos";
            btnVerTodos.Click += btnVerTodos_Click;
            //
            // flpTituloSecao
            //
            flpTituloSecao.AutoSize = true;
            flpTituloSecao.Controls.Add(lblTituloSecao);
            flpTituloSecao.Controls.Add(lblQuantidade);
            flpTituloSecao.Location = new Point(40, 10);
            flpTituloSecao.Name = "flpTituloSecao";
            flpTituloSecao.Size = new Size(330, 50);
            flpTituloSecao.TabIndex = 0;
            flpTituloSecao.WrapContents = false;
            //
            // lblTituloSecao
            //
            lblTituloSecao.AutoSize = true;
            lblTituloSecao.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTituloSecao.ForeColor = Color.FromArgb(13, 43, 94);
            lblTituloSecao.Location = new Point(3, 0);
            lblTituloSecao.Name = "lblTituloSecao";
            lblTituloSecao.Size = new Size(206, 41);
            lblTituloSecao.TabIndex = 0;
            lblTituloSecao.Text = "Explore Bauru";
            //
            // lblQuantidade
            //
            lblQuantidade.AutoSize = true;
            lblQuantidade.Font = new Font("Segoe UI", 11F);
            lblQuantidade.ForeColor = Color.FromArgb(88, 98, 112);
            lblQuantidade.Location = new Point(220, 16);
            lblQuantidade.Margin = new Padding(8, 16, 3, 0);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(76, 20);
            lblQuantidade.TabIndex = 1;
            lblQuantidade.Text = "21 lugares";
            //
            // pnlCabecalho
            //
            pnlCabecalho.BackColor = Color.FromArgb(247, 248, 246);
            pnlCabecalho.Controls.Add(flpCategorias);
            pnlCabecalho.Controls.Add(pnlCaixaBusca);
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
            flpCategorias.Location = new Point(44, 246);
            flpCategorias.Name = "flpCategorias";
            flpCategorias.Size = new Size(860, 56);
            flpCategorias.TabIndex = 4;
            flpCategorias.WrapContents = false;
            //
            // btnCategoriaTodos
            //
            btnCategoriaTodos.CorBorda = Color.FromArgb(11, 107, 138);
            btnCategoriaTodos.Font = new Font("Segoe UI Semibold", 11F);
            btnCategoriaTodos.Location = new Point(4, 4);
            btnCategoriaTodos.Margin = new Padding(4, 4, 8, 4);
            btnCategoriaTodos.Name = "btnCategoriaTodos";
            btnCategoriaTodos.Size = new Size(110, 46);
            btnCategoriaTodos.TabIndex = 0;
            btnCategoriaTodos.Tag = "Todos";
            btnCategoriaTodos.Text = "Todos";
            btnCategoriaTodos.Click += Categoria_Click;
            //
            // btnCategoriaNatureza
            //
            btnCategoriaNatureza.CorBorda = Color.FromArgb(220, 226, 230);
            btnCategoriaNatureza.CorFundo = Color.White;
            btnCategoriaNatureza.CorFundoHover = Color.FromArgb(228, 241, 245);
            btnCategoriaNatureza.Font = new Font("Segoe UI", 11F);
            btnCategoriaNatureza.ForeColor = Color.FromArgb(13, 43, 94);
            btnCategoriaNatureza.Location = new Point(126, 4);
            btnCategoriaNatureza.Margin = new Padding(4, 4, 8, 4);
            btnCategoriaNatureza.Name = "btnCategoriaNatureza";
            btnCategoriaNatureza.Size = new Size(130, 46);
            btnCategoriaNatureza.TabIndex = 1;
            btnCategoriaNatureza.Tag = "Natureza";
            btnCategoriaNatureza.Text = "Natureza";
            btnCategoriaNatureza.Click += Categoria_Click;
            //
            // btnCategoriaGastronomia
            //
            btnCategoriaGastronomia.CorBorda = Color.FromArgb(220, 226, 230);
            btnCategoriaGastronomia.CorFundo = Color.White;
            btnCategoriaGastronomia.CorFundoHover = Color.FromArgb(228, 241, 245);
            btnCategoriaGastronomia.Font = new Font("Segoe UI", 11F);
            btnCategoriaGastronomia.ForeColor = Color.FromArgb(13, 43, 94);
            btnCategoriaGastronomia.Location = new Point(268, 4);
            btnCategoriaGastronomia.Margin = new Padding(4, 4, 8, 4);
            btnCategoriaGastronomia.Name = "btnCategoriaGastronomia";
            btnCategoriaGastronomia.Size = new Size(160, 46);
            btnCategoriaGastronomia.TabIndex = 2;
            btnCategoriaGastronomia.Tag = "Gastronomia";
            btnCategoriaGastronomia.Text = "Gastronomia";
            btnCategoriaGastronomia.Click += Categoria_Click;
            //
            // btnCategoriaLazerCultura
            //
            btnCategoriaLazerCultura.CorBorda = Color.FromArgb(220, 226, 230);
            btnCategoriaLazerCultura.CorFundo = Color.White;
            btnCategoriaLazerCultura.CorFundoHover = Color.FromArgb(228, 241, 245);
            btnCategoriaLazerCultura.Font = new Font("Segoe UI", 11F);
            btnCategoriaLazerCultura.ForeColor = Color.FromArgb(13, 43, 94);
            btnCategoriaLazerCultura.Location = new Point(440, 4);
            btnCategoriaLazerCultura.Margin = new Padding(4, 4, 8, 4);
            btnCategoriaLazerCultura.Name = "btnCategoriaLazerCultura";
            btnCategoriaLazerCultura.Size = new Size(180, 46);
            btnCategoriaLazerCultura.TabIndex = 3;
            btnCategoriaLazerCultura.Tag = "Lazer e Cultura";
            btnCategoriaLazerCultura.Text = "Lazer e Cultura";
            btnCategoriaLazerCultura.Click += Categoria_Click;
            //
            // btnCategoriaCompras
            //
            btnCategoriaCompras.CorBorda = Color.FromArgb(220, 226, 230);
            btnCategoriaCompras.CorFundo = Color.White;
            btnCategoriaCompras.CorFundoHover = Color.FromArgb(228, 241, 245);
            btnCategoriaCompras.Font = new Font("Segoe UI", 11F);
            btnCategoriaCompras.ForeColor = Color.FromArgb(13, 43, 94);
            btnCategoriaCompras.Location = new Point(632, 4);
            btnCategoriaCompras.Margin = new Padding(4, 4, 8, 4);
            btnCategoriaCompras.Name = "btnCategoriaCompras";
            btnCategoriaCompras.Size = new Size(130, 46);
            btnCategoriaCompras.TabIndex = 4;
            btnCategoriaCompras.Tag = "Compras";
            btnCategoriaCompras.Text = "Compras";
            btnCategoriaCompras.Click += Categoria_Click;
            //
            // pnlCaixaBusca
            //
            pnlCaixaBusca.Controls.Add(btnBuscar);
            pnlCaixaBusca.Controls.Add(txtBusca);
            pnlCaixaBusca.Controls.Add(lblIconeBusca);
            pnlCaixaBusca.Location = new Point(48, 164);
            pnlCaixaBusca.Name = "pnlCaixaBusca";
            pnlCaixaBusca.Raio = 30;
            pnlCaixaBusca.Size = new Size(760, 62);
            pnlCaixaBusca.TabIndex = 3;
            //
            // btnBuscar
            //
            btnBuscar.Font = new Font("Segoe UI Semibold", 12F);
            btnBuscar.Icone = "";
            btnBuscar.Location = new Point(600, 6);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Raio = 25;
            btnBuscar.Size = new Size(154, 50);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.Click += btnBuscar_Click;
            //
            // txtBusca
            //
            txtBusca.BackColor = Color.White;
            txtBusca.BorderStyle = BorderStyle.None;
            txtBusca.Font = new Font("Segoe UI", 13F);
            txtBusca.ForeColor = Color.FromArgb(40, 48, 60);
            txtBusca.Location = new Point(62, 18);
            txtBusca.Name = "txtBusca";
            txtBusca.PlaceholderText = "Buscar pontos turísticos...";
            txtBusca.Size = new Size(524, 24);
            txtBusca.TabIndex = 0;
            txtBusca.TextChanged += txtBusca_TextChanged;
            txtBusca.KeyDown += txtBusca_KeyDown;
            //
            // lblIconeBusca
            //
            lblIconeBusca.BackColor = Color.White;
            lblIconeBusca.Font = new Font("Segoe MDL2 Assets", 15F);
            lblIconeBusca.ForeColor = Color.FromArgb(13, 43, 94);
            lblIconeBusca.Location = new Point(22, 16);
            lblIconeBusca.Name = "lblIconeBusca";
            lblIconeBusca.Size = new Size(30, 30);
            lblIconeBusca.TabIndex = 2;
            lblIconeBusca.Text = "";
            lblIconeBusca.TextAlign = ContentAlignment.MiddleCenter;
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
            picLogo.Location = new Point(44, 26);
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
            BackColor = Color.FromArgb(247, 248, 246);
            ClientSize = new Size(1280, 800);
            Controls.Add(pnlPrincipal);
            Controls.Add(pnlDivisorMenu);
            Controls.Add(pnlMenuLateral);
            KeyPreview = true;
            MinimumSize = new Size(1040, 700);
            Name = "FormBusca";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bauru's Tour";
            WindowState = FormWindowState.Maximized;
            Load += FormBusca_Load;
            KeyDown += FormBusca_KeyDown;
            pnlMenuLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picIlustracaoMenu).EndInit();
            pnlPrincipal.ResumeLayout(false);
            flpCards.ResumeLayout(false);
            pnlSobre.ResumeLayout(false);
            pnlCartaoSobre.ResumeLayout(false);
            pnlCartaoSobre.PerformLayout();
            pnlTituloSecao.ResumeLayout(false);
            pnlTituloSecao.PerformLayout();
            flpTituloSecao.ResumeLayout(false);
            flpTituloSecao.PerformLayout();
            pnlCabecalho.ResumeLayout(false);
            pnlCabecalho.PerformLayout();
            flpCategorias.ResumeLayout(false);
            pnlCaixaBusca.ResumeLayout(false);
            pnlCaixaBusca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenuLateral;
        private BaurusTour.Componentes.BotaoArredondado btnMenuInicio;
        private BaurusTour.Componentes.BotaoArredondado btnMenuMapa;
        private BaurusTour.Componentes.BotaoArredondado btnMenuFavoritos;
        private BaurusTour.Componentes.BotaoArredondado btnMenuSobre;
        private BaurusTour.Componentes.BotaoArredondado btnMenuTelaCheia;
        private PictureBox picIlustracaoMenu;
        private Panel pnlDivisorMenu;
        private Panel pnlPrincipal;
        private BaurusTour.Componentes.PainelCabecalho pnlCabecalho;
        private PictureBox picLogo;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private BaurusTour.Componentes.PainelArredondado pnlCaixaBusca;
        private Label lblIconeBusca;
        private TextBox txtBusca;
        private BaurusTour.Componentes.BotaoArredondado btnBuscar;
        private FlowLayoutPanel flpCategorias;
        private BaurusTour.Componentes.BotaoArredondado btnCategoriaTodos;
        private BaurusTour.Componentes.BotaoArredondado btnCategoriaNatureza;
        private BaurusTour.Componentes.BotaoArredondado btnCategoriaGastronomia;
        private BaurusTour.Componentes.BotaoArredondado btnCategoriaLazerCultura;
        private BaurusTour.Componentes.BotaoArredondado btnCategoriaCompras;
        private Panel pnlTituloSecao;
        private FlowLayoutPanel flpTituloSecao;
        private Label lblTituloSecao;
        private Label lblQuantidade;
        private BaurusTour.Componentes.BotaoArredondado btnVerTodos;
        private FlowLayoutPanel flpCards;
        private Label lblSemResultados;
        private Panel pnlSobre;
        private BaurusTour.Componentes.PainelArredondado pnlCartaoSobre;
        private Label lblSobreTitulo;
        private Label lblSobreTexto;
        private Label lblSobreEquipe;
        private BaurusTour.Componentes.BotaoArredondado btnGuiaSobre;
        private Label lblAtalhos;
    }
}
