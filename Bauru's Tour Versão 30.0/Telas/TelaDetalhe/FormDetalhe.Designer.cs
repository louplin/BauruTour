namespace BaurusTour.Telas.TelaDetalhe
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
            lblMarca = new Label();
            picLogo = new PictureBox();
            btnVoltar = new Button();
            pnlLinhaTopo = new Panel();
            pnlLateral = new Panel();
            pnlFotoArea = new Panel();
            picFoto = new PictureBox();
            pnlControlesFoto = new Panel();
            lblContadorFotos = new Label();
            btnFotoAnterior = new Button();
            btnFotoProxima = new Button();
            pnlMapaArea = new Panel();
            webMapa = new Microsoft.Web.WebView2.WinForms.WebView2();
            lblMapaErro = new Label();
            flpPagina = new FlowLayoutPanel();
            lblNome = new Label();
            tlpCabecalho = new TableLayoutPanel();
            flpInfo = new FlowLayoutPanel();
            flpEtiquetas = new FlowLayoutPanel();
            lblCategoria = new Label();
            lblPrecoResumo = new Label();
            lblSituacao = new Label();
            lblNotaResumo = new Label();
            flpEndereco = new FlowLayoutPanel();
            picIconeEndereco = new PictureBox();
            lblEndereco = new Label();
            flpAcoes = new FlowLayoutPanel();
            btnRota = new Button();
            btnCardapioLoja = new Button();
            btnCompartilhar = new Button();
            btnFavoritar = new Button();
            pnlAvaliacao = new Panel();
            lblAvaliacaoTitulo = new Label();
            flpEstrelas = new FlowLayoutPanel();
            btnEstrela1 = new Button();
            btnEstrela2 = new Button();
            btnEstrela3 = new Button();
            btnEstrela4 = new Button();
            btnEstrela5 = new Button();
            lblNotaDescricao = new Label();
            lnkRemoverNota = new LinkLabel();
            cardSobre = new FlowLayoutPanel();
            lblSobreTitulo = new Label();
            lblDescricao = new Label();
            cardFicha = new FlowLayoutPanel();
            lblFichaTitulo = new Label();
            lblFicha = new Label();
            cardHistoria = new FlowLayoutPanel();
            lblHistoriaTitulo = new Label();
            lblHistoria = new Label();
            cardVisitar = new FlowLayoutPanel();
            lblVisitarTitulo = new Label();
            lblIngresso = new Label();
            lblPreco = new Label();
            lblHorarioTitulo = new Label();
            lblHorario = new Label();
            lblContatoTitulo = new Label();
            lblTelefone = new Label();
            cardOQueFazer = new FlowLayoutPanel();
            lblOQueFazerTitulo = new Label();
            lblOQueFazer = new Label();
            lblDicasTitulo = new Label();
            lblDicas = new Label();
            cardParecidos = new FlowLayoutPanel();
            lblParecidosTitulo = new Label();
            flpSemelhantes = new FlowLayoutPanel();
            cardLinks = new FlowLayoutPanel();
            lblLinksTitulo = new Label();
            lnkInstagram = new LinkLabel();
            lnkSite = new LinkLabel();
            lblFontes = new Label();
            pnlEspacoFinal = new Panel();
            pnlTopo.SuspendLayout();
            pnlLinhaTopo.SuspendLayout();
            pnlLateral.SuspendLayout();
            pnlFotoArea.SuspendLayout();
            pnlControlesFoto.SuspendLayout();
            pnlMapaArea.SuspendLayout();
            flpPagina.SuspendLayout();
            tlpCabecalho.SuspendLayout();
            flpInfo.SuspendLayout();
            flpEtiquetas.SuspendLayout();
            flpEndereco.SuspendLayout();
            flpAcoes.SuspendLayout();
            pnlAvaliacao.SuspendLayout();
            flpEstrelas.SuspendLayout();
            cardSobre.SuspendLayout();
            cardFicha.SuspendLayout();
            cardHistoria.SuspendLayout();
            cardVisitar.SuspendLayout();
            cardOQueFazer.SuspendLayout();
            cardParecidos.SuspendLayout();
            flpSemelhantes.SuspendLayout();
            cardLinks.SuspendLayout();
            pnlEspacoFinal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picFoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picIconeEndereco).BeginInit();
            ((System.ComponentModel.ISupportInitialize)webMapa).BeginInit();
            SuspendLayout();
            // 
            // pnlTopo
            // 
            pnlTopo.BackColor = Color.FromArgb(242, 248, 250);
            pnlTopo.Controls.Add(lblMarca);
            pnlTopo.Controls.Add(picLogo);
            pnlTopo.Controls.Add(btnVoltar);
            pnlTopo.Dock = DockStyle.Top;
            pnlTopo.Location = new Point(0, 0);
            pnlTopo.Size = new Size(1920, 70);
            pnlTopo.Name = "pnlTopo";
            pnlTopo.TabIndex = 0;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblMarca.ForeColor = Color.FromArgb(13, 43, 94);
            lblMarca.Location = new Point(212, 19);
            lblMarca.Name = "lblMarca";
            lblMarca.TabIndex = 1;
            lblMarca.Text = "Bauru's Tour";
            // 
            // picLogo
            // 
            picLogo.Image = Properties.Resources.logo;
            picLogo.Location = new Point(166, 15);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(40, 40);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 2;
            picLogo.TabStop = false;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(242, 248, 250);
            btnVoltar.Cursor = Cursors.Hand;
            btnVoltar.FlatAppearance.BorderColor = Color.FromArgb(11, 107, 138);
            btnVoltar.FlatAppearance.BorderSize = 2;
            btnVoltar.FlatAppearance.MouseOverBackColor = Color.FromArgb(206, 228, 236);
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Segoe UI Semibold", 11F);
            btnVoltar.ForeColor = Color.FromArgb(11, 107, 138);
            btnVoltar.Image = Properties.Resources.icone_voltar;
            btnVoltar.Location = new Point(28, 13);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(120, 44);
            btnVoltar.TabIndex = 3;
            btnVoltar.Text = "Voltar";
            btnVoltar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // pnlLinhaTopo
            // 
            pnlLinhaTopo.BackColor = Color.FromArgb(196, 216, 224);
            pnlLinhaTopo.Dock = DockStyle.Top;
            pnlLinhaTopo.Location = new Point(0, 70);
            pnlLinhaTopo.Name = "pnlLinhaTopo";
            pnlLinhaTopo.Size = new Size(1920, 1);
            pnlLinhaTopo.TabIndex = 4;
            // 
            // pnlLateral
            // 
            pnlLateral.Dock = DockStyle.Left;
            pnlLateral.Controls.Add(pnlMapaArea);
            pnlLateral.Controls.Add(pnlFotoArea);
            pnlLateral.Location = new Point(0, 71);
            pnlLateral.Padding = new Padding(32, 24, 12, 24);
            pnlLateral.Size = new Size(700, 1009);
            pnlLateral.Name = "pnlLateral";
            pnlLateral.TabIndex = 5;
            // 
            // pnlFotoArea
            // 
            pnlFotoArea.Dock = DockStyle.Top;
            pnlFotoArea.Controls.Add(picFoto);
            pnlFotoArea.Controls.Add(pnlControlesFoto);
            pnlFotoArea.Location = new Point(32, 24);
            pnlFotoArea.Size = new Size(656, 577);
            pnlFotoArea.Name = "pnlFotoArea";
            pnlFotoArea.TabIndex = 6;
            // 
            // picFoto
            // 
            picFoto.BackColor = Color.FromArgb(20, 32, 48);
            picFoto.Dock = DockStyle.Fill;
            picFoto.Location = new Point(0, 0);
            picFoto.Name = "picFoto";
            picFoto.Size = new Size(656, 525);
            picFoto.SizeMode = PictureBoxSizeMode.CenterImage;
            picFoto.TabIndex = 7;
            picFoto.TabStop = false;
            picFoto.SizeChanged += picFoto_SizeChanged;
            // 
            // pnlControlesFoto
            // 
            pnlControlesFoto.BackColor = Color.FromArgb(20, 32, 48);
            pnlControlesFoto.Controls.Add(lblContadorFotos);
            pnlControlesFoto.Controls.Add(btnFotoAnterior);
            pnlControlesFoto.Controls.Add(btnFotoProxima);
            pnlControlesFoto.Dock = DockStyle.Bottom;
            pnlControlesFoto.Location = new Point(0, 525);
            pnlControlesFoto.Size = new Size(656, 52);
            pnlControlesFoto.Name = "pnlControlesFoto";
            pnlControlesFoto.TabIndex = 8;
            // 
            // lblContadorFotos
            // 
            lblContadorFotos.Dock = DockStyle.Fill;
            lblContadorFotos.TextAlign = ContentAlignment.MiddleCenter;
            lblContadorFotos.Font = new Font("Segoe UI Semibold", 11F);
            lblContadorFotos.ForeColor = Color.White;
            lblContadorFotos.Location = new Point(130, 0);
            lblContadorFotos.Name = "lblContadorFotos";
            lblContadorFotos.Size = new Size(396, 52);
            lblContadorFotos.TabIndex = 9;
            lblContadorFotos.Text = "Foto 1 de 1";
            // 
            // btnFotoAnterior
            // 
            btnFotoAnterior.BackColor = Color.FromArgb(20, 32, 48);
            btnFotoAnterior.Cursor = Cursors.Hand;
            btnFotoAnterior.FlatAppearance.BorderSize = 0;
            btnFotoAnterior.FlatAppearance.MouseOverBackColor = Color.FromArgb(11, 107, 138);
            btnFotoAnterior.FlatStyle = FlatStyle.Flat;
            btnFotoAnterior.Font = new Font("Segoe UI Semibold", 11F);
            btnFotoAnterior.ForeColor = Color.White;
            btnFotoAnterior.Dock = DockStyle.Left;
            btnFotoAnterior.Location = new Point(0, 0);
            btnFotoAnterior.Name = "btnFotoAnterior";
            btnFotoAnterior.Size = new Size(130, 52);
            btnFotoAnterior.TabIndex = 10;
            btnFotoAnterior.Text = "‹  Anterior";
            btnFotoAnterior.UseVisualStyleBackColor = false;
            btnFotoAnterior.Click += btnFotoAnterior_Click;
            // 
            // btnFotoProxima
            // 
            btnFotoProxima.BackColor = Color.FromArgb(20, 32, 48);
            btnFotoProxima.Cursor = Cursors.Hand;
            btnFotoProxima.FlatAppearance.BorderSize = 0;
            btnFotoProxima.FlatAppearance.MouseOverBackColor = Color.FromArgb(11, 107, 138);
            btnFotoProxima.FlatStyle = FlatStyle.Flat;
            btnFotoProxima.Font = new Font("Segoe UI Semibold", 11F);
            btnFotoProxima.ForeColor = Color.White;
            btnFotoProxima.Dock = DockStyle.Right;
            btnFotoProxima.Location = new Point(526, 0);
            btnFotoProxima.Name = "btnFotoProxima";
            btnFotoProxima.Size = new Size(130, 52);
            btnFotoProxima.TabIndex = 11;
            btnFotoProxima.Text = "Próxima  ›";
            btnFotoProxima.UseVisualStyleBackColor = false;
            btnFotoProxima.Click += btnFotoProxima_Click;
            // 
            // pnlMapaArea
            // 
            pnlMapaArea.Dock = DockStyle.Top;
            pnlMapaArea.Controls.Add(webMapa);
            pnlMapaArea.Controls.Add(lblMapaErro);
            pnlMapaArea.Location = new Point(32, 601);
            pnlMapaArea.Padding = new Padding(0, 16, 0, 0);
            pnlMapaArea.Size = new Size(656, 384);
            pnlMapaArea.Name = "pnlMapaArea";
            pnlMapaArea.TabIndex = 12;
            // 
            // webMapa
            // 
            webMapa.AllowExternalDrop = false;
            webMapa.CreationProperties = null;
            webMapa.DefaultBackgroundColor = Color.FromArgb(232, 242, 246);
            webMapa.Dock = DockStyle.Fill;
            webMapa.Location = new Point(0, 16);
            webMapa.Name = "webMapa";
            webMapa.Size = new Size(656, 368);
            webMapa.TabIndex = 13;
            webMapa.ZoomFactor = 1D;
            // 
            // lblMapaErro
            // 
            lblMapaErro.BackColor = Color.FromArgb(242, 248, 250);
            lblMapaErro.Dock = DockStyle.Fill;
            lblMapaErro.TextAlign = ContentAlignment.MiddleCenter;
            lblMapaErro.Font = new Font("Segoe UI", 11F);
            lblMapaErro.ForeColor = Color.FromArgb(88, 98, 112);
            lblMapaErro.Location = new Point(0, 16);
            lblMapaErro.Name = "lblMapaErro";
            lblMapaErro.Size = new Size(656, 368);
            lblMapaErro.TabIndex = 14;
            lblMapaErro.Text = "Carregando o mapa...";
            // 
            // flpPagina
            // 
            flpPagina.AutoScroll = true;
            flpPagina.Controls.Add(lblNome);
            flpPagina.Controls.Add(tlpCabecalho);
            flpPagina.Controls.Add(cardSobre);
            flpPagina.Controls.Add(cardFicha);
            flpPagina.Controls.Add(cardHistoria);
            flpPagina.Controls.Add(cardVisitar);
            flpPagina.Controls.Add(cardOQueFazer);
            flpPagina.Controls.Add(cardParecidos);
            flpPagina.Controls.Add(cardLinks);
            flpPagina.Controls.Add(lblFontes);
            flpPagina.Controls.Add(pnlEspacoFinal);
            flpPagina.Dock = DockStyle.Fill;
            flpPagina.FlowDirection = FlowDirection.TopDown;
            flpPagina.Location = new Point(700, 71);
            flpPagina.Name = "flpPagina";
            flpPagina.Padding = new Padding(24, 22, 40, 24);
            flpPagina.Size = new Size(1220, 1009);
            flpPagina.TabIndex = 15;
            flpPagina.WrapContents = false;
            flpPagina.Resize += flpPagina_Resize;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Margin = new Padding(0, 0, 0, 8);
            lblNome.MaximumSize = new Size(1150, 0);
            lblNome.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            lblNome.ForeColor = Color.FromArgb(13, 43, 94);
            lblNome.Name = "lblNome";
            lblNome.TabIndex = 16;
            lblNome.Text = "Nome do lugar";
            // 
            // tlpCabecalho
            // 
            tlpCabecalho.AutoSize = true;
            tlpCabecalho.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tlpCabecalho.ColumnCount = 2;
            tlpCabecalho.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpCabecalho.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 330F));
            tlpCabecalho.Controls.Add(flpInfo, 0, 0);
            tlpCabecalho.Controls.Add(pnlAvaliacao, 1, 0);
            tlpCabecalho.Margin = new Padding(0, 0, 0, 22);
            tlpCabecalho.MaximumSize = new Size(1150, 0);
            tlpCabecalho.MinimumSize = new Size(1150, 0);
            tlpCabecalho.Name = "tlpCabecalho";
            tlpCabecalho.RowCount = 1;
            tlpCabecalho.RowStyles.Add(new RowStyle());
            tlpCabecalho.Size = new Size(1150, 170);
            tlpCabecalho.TabIndex = 17;
            // 
            // flpInfo
            // 
            flpInfo.AutoSize = true;
            flpInfo.Controls.Add(flpEtiquetas);
            flpInfo.Controls.Add(flpEndereco);
            flpInfo.Controls.Add(flpAcoes);
            flpInfo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpInfo.FlowDirection = FlowDirection.TopDown;
            flpInfo.WrapContents = false;
            flpInfo.Margin = new Padding(0);
            flpInfo.Size = new Size(800, 160);
            flpInfo.Name = "flpInfo";
            flpInfo.TabIndex = 18;
            // 
            // flpEtiquetas
            // 
            flpEtiquetas.AutoSize = true;
            flpEtiquetas.Controls.Add(lblCategoria);
            flpEtiquetas.Controls.Add(lblPrecoResumo);
            flpEtiquetas.Controls.Add(lblSituacao);
            flpEtiquetas.Controls.Add(lblNotaResumo);
            flpEtiquetas.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpEtiquetas.Margin = new Padding(0, 0, 0, 10);
            flpEtiquetas.Size = new Size(420, 28);
            flpEtiquetas.Name = "flpEtiquetas";
            flpEtiquetas.TabIndex = 19;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.BackColor = Color.FromArgb(206, 228, 236);
            lblCategoria.Margin = new Padding(0, 0, 8, 0);
            lblCategoria.Padding = new Padding(10, 4, 10, 4);
            lblCategoria.Font = new Font("Segoe UI Semibold", 10F);
            lblCategoria.ForeColor = Color.FromArgb(11, 107, 138);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.TabIndex = 20;
            lblCategoria.Text = "Natureza";
            // 
            // lblPrecoResumo
            // 
            lblPrecoResumo.AutoSize = true;
            lblPrecoResumo.BackColor = Color.FromArgb(226, 236, 250);
            lblPrecoResumo.Margin = new Padding(0, 0, 8, 0);
            lblPrecoResumo.Padding = new Padding(10, 4, 10, 4);
            lblPrecoResumo.Font = new Font("Segoe UI Semibold", 10F);
            lblPrecoResumo.ForeColor = Color.FromArgb(40, 80, 160);
            lblPrecoResumo.Name = "lblPrecoResumo";
            lblPrecoResumo.TabIndex = 21;
            lblPrecoResumo.Text = "$  Gratuito";
            // 
            // lblSituacao
            // 
            lblSituacao.AutoSize = true;
            lblSituacao.BackColor = Color.FromArgb(214, 240, 224);
            lblSituacao.Margin = new Padding(0, 0, 8, 0);
            lblSituacao.Padding = new Padding(10, 4, 10, 4);
            lblSituacao.Font = new Font("Segoe UI Semibold", 10F);
            lblSituacao.ForeColor = Color.FromArgb(30, 120, 70);
            lblSituacao.Name = "lblSituacao";
            lblSituacao.TabIndex = 22;
            lblSituacao.Text = "●  Aberto agora";
            // 
            // lblNotaResumo
            // 
            lblNotaResumo.AutoSize = true;
            lblNotaResumo.BackColor = Color.FromArgb(250, 238, 210);
            lblNotaResumo.Margin = new Padding(0, 0, 8, 0);
            lblNotaResumo.Padding = new Padding(10, 4, 10, 4);
            lblNotaResumo.Font = new Font("Segoe UI Semibold", 10F);
            lblNotaResumo.ForeColor = Color.FromArgb(150, 100, 20);
            lblNotaResumo.Name = "lblNotaResumo";
            lblNotaResumo.TabIndex = 23;
            lblNotaResumo.Text = "★  Sua nota: 5/5";
            // 
            // flpEndereco
            // 
            flpEndereco.AutoSize = true;
            flpEndereco.Controls.Add(picIconeEndereco);
            flpEndereco.Controls.Add(lblEndereco);
            flpEndereco.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpEndereco.WrapContents = false;
            flpEndereco.Margin = new Padding(0, 0, 0, 14);
            flpEndereco.Size = new Size(400, 26);
            flpEndereco.Name = "flpEndereco";
            flpEndereco.TabIndex = 24;
            // 
            // picIconeEndereco
            // 
            picIconeEndereco.Image = Properties.Resources.icone_local;
            picIconeEndereco.Margin = new Padding(0, 2, 6, 0);
            picIconeEndereco.Name = "picIconeEndereco";
            picIconeEndereco.Size = new Size(20, 20);
            picIconeEndereco.SizeMode = PictureBoxSizeMode.Zoom;
            picIconeEndereco.TabIndex = 25;
            picIconeEndereco.TabStop = false;
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Margin = new Padding(0, 1, 0, 0);
            lblEndereco.MaximumSize = new Size(780, 0);
            lblEndereco.Font = new Font("Segoe UI", 12F);
            lblEndereco.ForeColor = Color.FromArgb(88, 98, 112);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.TabIndex = 26;
            lblEndereco.Text = "Endereço do lugar";
            // 
            // flpAcoes
            // 
            flpAcoes.AutoSize = true;
            flpAcoes.Controls.Add(btnRota);
            flpAcoes.Controls.Add(btnCardapioLoja);
            flpAcoes.Controls.Add(btnCompartilhar);
            flpAcoes.Controls.Add(btnFavoritar);
            flpAcoes.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpAcoes.MaximumSize = new Size(800, 0);
            flpAcoes.Margin = new Padding(0);
            flpAcoes.Size = new Size(800, 44);
            flpAcoes.Name = "flpAcoes";
            flpAcoes.TabIndex = 27;
            // 
            // btnRota
            // 
            btnRota.BackColor = Color.FromArgb(11, 107, 138);
            btnRota.Cursor = Cursors.Hand;
            btnRota.FlatAppearance.BorderSize = 0;
            btnRota.FlatAppearance.MouseOverBackColor = Color.FromArgb(7, 84, 110);
            btnRota.FlatStyle = FlatStyle.Flat;
            btnRota.Font = new Font("Segoe UI Semibold", 11F);
            btnRota.ForeColor = Color.White;
            btnRota.Image = Properties.Resources.icone_mapa_branco;
            btnRota.Margin = new Padding(0, 0, 10, 8);
            btnRota.Name = "btnRota";
            btnRota.Size = new Size(170, 44);
            btnRota.TabIndex = 28;
            btnRota.Text = "Como chegar";
            btnRota.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRota.UseVisualStyleBackColor = false;
            btnRota.Click += btnRota_Click;
            // 
            // btnCardapioLoja
            // 
            btnCardapioLoja.BackColor = Color.FromArgb(214, 110, 40);
            btnCardapioLoja.Cursor = Cursors.Hand;
            btnCardapioLoja.FlatAppearance.BorderSize = 0;
            btnCardapioLoja.FlatAppearance.MouseOverBackColor = Color.FromArgb(186, 92, 30);
            btnCardapioLoja.FlatStyle = FlatStyle.Flat;
            btnCardapioLoja.Font = new Font("Segoe UI Semibold", 11F);
            btnCardapioLoja.ForeColor = Color.White;
            btnCardapioLoja.Image = Properties.Resources.icone_cardapio_branco;
            btnCardapioLoja.Margin = new Padding(0, 0, 10, 8);
            btnCardapioLoja.Name = "btnCardapioLoja";
            btnCardapioLoja.Size = new Size(170, 44);
            btnCardapioLoja.TabIndex = 29;
            btnCardapioLoja.Text = "Ver cardápio";
            btnCardapioLoja.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCardapioLoja.UseVisualStyleBackColor = false;
            btnCardapioLoja.Click += btnCardapioLoja_Click;
            // 
            // btnCompartilhar
            // 
            btnCompartilhar.BackColor = Color.FromArgb(242, 248, 250);
            btnCompartilhar.Cursor = Cursors.Hand;
            btnCompartilhar.FlatAppearance.BorderColor = Color.FromArgb(11, 107, 138);
            btnCompartilhar.FlatAppearance.BorderSize = 2;
            btnCompartilhar.FlatAppearance.MouseOverBackColor = Color.FromArgb(206, 228, 236);
            btnCompartilhar.FlatStyle = FlatStyle.Flat;
            btnCompartilhar.Font = new Font("Segoe UI Semibold", 11F);
            btnCompartilhar.ForeColor = Color.FromArgb(11, 107, 138);
            btnCompartilhar.Image = Properties.Resources.icone_compartilhar;
            btnCompartilhar.Margin = new Padding(0, 0, 10, 8);
            btnCompartilhar.Name = "btnCompartilhar";
            btnCompartilhar.Size = new Size(170, 44);
            btnCompartilhar.TabIndex = 30;
            btnCompartilhar.Text = "Compartilhar";
            btnCompartilhar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCompartilhar.UseVisualStyleBackColor = false;
            btnCompartilhar.Click += btnCompartilhar_Click;
            // 
            // btnFavoritar
            // 
            btnFavoritar.BackColor = Color.FromArgb(242, 248, 250);
            btnFavoritar.Cursor = Cursors.Hand;
            btnFavoritar.FlatAppearance.BorderColor = Color.FromArgb(226, 72, 80);
            btnFavoritar.FlatAppearance.BorderSize = 2;
            btnFavoritar.FlatAppearance.MouseOverBackColor = Color.FromArgb(253, 236, 237);
            btnFavoritar.FlatStyle = FlatStyle.Flat;
            btnFavoritar.Font = new Font("Segoe UI Semibold", 11F);
            btnFavoritar.ForeColor = Color.FromArgb(226, 72, 80);
            btnFavoritar.Margin = new Padding(0, 0, 0, 8);
            btnFavoritar.Name = "btnFavoritar";
            btnFavoritar.Size = new Size(160, 44);
            btnFavoritar.TabIndex = 31;
            btnFavoritar.Text = "♡  Favoritar";
            btnFavoritar.UseVisualStyleBackColor = false;
            btnFavoritar.Click += btnFavoritar_Click;
            // 
            // pnlAvaliacao
            // 
            pnlAvaliacao.BackColor = Color.FromArgb(242, 248, 250);
            pnlAvaliacao.Controls.Add(lblAvaliacaoTitulo);
            pnlAvaliacao.Controls.Add(flpEstrelas);
            pnlAvaliacao.Controls.Add(lblNotaDescricao);
            pnlAvaliacao.Controls.Add(lnkRemoverNota);
            pnlAvaliacao.BorderStyle = BorderStyle.FixedSingle;
            pnlAvaliacao.Margin = new Padding(10, 0, 0, 0);
            pnlAvaliacao.Size = new Size(320, 158);
            pnlAvaliacao.Name = "pnlAvaliacao";
            pnlAvaliacao.TabIndex = 32;
            // 
            // lblAvaliacaoTitulo
            // 
            lblAvaliacaoTitulo.AutoSize = true;
            lblAvaliacaoTitulo.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblAvaliacaoTitulo.ForeColor = Color.FromArgb(13, 43, 94);
            lblAvaliacaoTitulo.Location = new Point(16, 12);
            lblAvaliacaoTitulo.Name = "lblAvaliacaoTitulo";
            lblAvaliacaoTitulo.TabIndex = 33;
            lblAvaliacaoTitulo.Text = "Sua avaliação";
            // 
            // flpEstrelas
            // 
            flpEstrelas.AutoSize = true;
            flpEstrelas.Controls.Add(btnEstrela1);
            flpEstrelas.Controls.Add(btnEstrela2);
            flpEstrelas.Controls.Add(btnEstrela3);
            flpEstrelas.Controls.Add(btnEstrela4);
            flpEstrelas.Controls.Add(btnEstrela5);
            flpEstrelas.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpEstrelas.Location = new Point(12, 40);
            flpEstrelas.Margin = new Padding(0);
            flpEstrelas.Size = new Size(230, 46);
            flpEstrelas.Name = "flpEstrelas";
            flpEstrelas.TabIndex = 34;
            // 
            // btnEstrela1
            // 
            btnEstrela1.Cursor = Cursors.Hand;
            btnEstrela1.FlatAppearance.BorderSize = 0;
            btnEstrela1.FlatAppearance.MouseOverBackColor = Color.FromArgb(206, 228, 236);
            btnEstrela1.FlatStyle = FlatStyle.Flat;
            btnEstrela1.Font = new Font("Segoe UI", 20F);
            btnEstrela1.ForeColor = Color.FromArgb(214, 158, 46);
            btnEstrela1.Margin = new Padding(0);
            btnEstrela1.Name = "btnEstrela1";
            btnEstrela1.Size = new Size(46, 46);
            btnEstrela1.TabIndex = 35;
            btnEstrela1.Tag = "1";
            btnEstrela1.Text = "☆";
            btnEstrela1.UseVisualStyleBackColor = true;
            btnEstrela1.Click += Estrela_Click;
            btnEstrela1.MouseEnter += Estrela_MouseEnter;
            btnEstrela1.MouseLeave += Estrela_MouseLeave;
            // 
            // btnEstrela2
            // 
            btnEstrela2.Cursor = Cursors.Hand;
            btnEstrela2.FlatAppearance.BorderSize = 0;
            btnEstrela2.FlatAppearance.MouseOverBackColor = Color.FromArgb(206, 228, 236);
            btnEstrela2.FlatStyle = FlatStyle.Flat;
            btnEstrela2.Font = new Font("Segoe UI", 20F);
            btnEstrela2.ForeColor = Color.FromArgb(214, 158, 46);
            btnEstrela2.Margin = new Padding(0);
            btnEstrela2.Name = "btnEstrela2";
            btnEstrela2.Size = new Size(46, 46);
            btnEstrela2.TabIndex = 36;
            btnEstrela2.Tag = "2";
            btnEstrela2.Text = "☆";
            btnEstrela2.UseVisualStyleBackColor = true;
            btnEstrela2.Click += Estrela_Click;
            btnEstrela2.MouseEnter += Estrela_MouseEnter;
            btnEstrela2.MouseLeave += Estrela_MouseLeave;
            // 
            // btnEstrela3
            // 
            btnEstrela3.Cursor = Cursors.Hand;
            btnEstrela3.FlatAppearance.BorderSize = 0;
            btnEstrela3.FlatAppearance.MouseOverBackColor = Color.FromArgb(206, 228, 236);
            btnEstrela3.FlatStyle = FlatStyle.Flat;
            btnEstrela3.Font = new Font("Segoe UI", 20F);
            btnEstrela3.ForeColor = Color.FromArgb(214, 158, 46);
            btnEstrela3.Margin = new Padding(0);
            btnEstrela3.Name = "btnEstrela3";
            btnEstrela3.Size = new Size(46, 46);
            btnEstrela3.TabIndex = 37;
            btnEstrela3.Tag = "3";
            btnEstrela3.Text = "☆";
            btnEstrela3.UseVisualStyleBackColor = true;
            btnEstrela3.Click += Estrela_Click;
            btnEstrela3.MouseEnter += Estrela_MouseEnter;
            btnEstrela3.MouseLeave += Estrela_MouseLeave;
            // 
            // btnEstrela4
            // 
            btnEstrela4.Cursor = Cursors.Hand;
            btnEstrela4.FlatAppearance.BorderSize = 0;
            btnEstrela4.FlatAppearance.MouseOverBackColor = Color.FromArgb(206, 228, 236);
            btnEstrela4.FlatStyle = FlatStyle.Flat;
            btnEstrela4.Font = new Font("Segoe UI", 20F);
            btnEstrela4.ForeColor = Color.FromArgb(214, 158, 46);
            btnEstrela4.Margin = new Padding(0);
            btnEstrela4.Name = "btnEstrela4";
            btnEstrela4.Size = new Size(46, 46);
            btnEstrela4.TabIndex = 38;
            btnEstrela4.Tag = "4";
            btnEstrela4.Text = "☆";
            btnEstrela4.UseVisualStyleBackColor = true;
            btnEstrela4.Click += Estrela_Click;
            btnEstrela4.MouseEnter += Estrela_MouseEnter;
            btnEstrela4.MouseLeave += Estrela_MouseLeave;
            // 
            // btnEstrela5
            // 
            btnEstrela5.Cursor = Cursors.Hand;
            btnEstrela5.FlatAppearance.BorderSize = 0;
            btnEstrela5.FlatAppearance.MouseOverBackColor = Color.FromArgb(206, 228, 236);
            btnEstrela5.FlatStyle = FlatStyle.Flat;
            btnEstrela5.Font = new Font("Segoe UI", 20F);
            btnEstrela5.ForeColor = Color.FromArgb(214, 158, 46);
            btnEstrela5.Margin = new Padding(0);
            btnEstrela5.Name = "btnEstrela5";
            btnEstrela5.Size = new Size(46, 46);
            btnEstrela5.TabIndex = 39;
            btnEstrela5.Tag = "5";
            btnEstrela5.Text = "☆";
            btnEstrela5.UseVisualStyleBackColor = true;
            btnEstrela5.Click += Estrela_Click;
            btnEstrela5.MouseEnter += Estrela_MouseEnter;
            btnEstrela5.MouseLeave += Estrela_MouseLeave;
            // 
            // lblNotaDescricao
            // 
            lblNotaDescricao.AutoSize = true;
            lblNotaDescricao.Font = new Font("Segoe UI", 10.5F);
            lblNotaDescricao.ForeColor = Color.FromArgb(40, 48, 60);
            lblNotaDescricao.Location = new Point(16, 94);
            lblNotaDescricao.Name = "lblNotaDescricao";
            lblNotaDescricao.TabIndex = 40;
            lblNotaDescricao.Text = "Clique nas estrelas para dar sua nota";
            // 
            // lnkRemoverNota
            // 
            lnkRemoverNota.AutoSize = true;
            lnkRemoverNota.Font = new Font("Segoe UI", 10F);
            lnkRemoverNota.LinkColor = Color.FromArgb(11, 107, 138);
            lnkRemoverNota.Location = new Point(16, 122);
            lnkRemoverNota.Name = "lnkRemoverNota";
            lnkRemoverNota.TabIndex = 41;
            lnkRemoverNota.TabStop = true;
            lnkRemoverNota.Text = "Remover minha nota";
            lnkRemoverNota.LinkClicked += lnkRemoverNota_LinkClicked;
            // 
            // cardSobre
            // 
            cardSobre.AutoSize = true;
            cardSobre.Controls.Add(lblSobreTitulo);
            cardSobre.Controls.Add(lblDescricao);
            cardSobre.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cardSobre.BackColor = Color.FromArgb(242, 248, 250);
            cardSobre.FlowDirection = FlowDirection.TopDown;
            cardSobre.Margin = new Padding(0, 0, 0, 18);
            cardSobre.MaximumSize = new Size(1150, 0);
            cardSobre.MinimumSize = new Size(1150, 0);
            cardSobre.Padding = new Padding(26, 20, 26, 22);
            cardSobre.Size = new Size(1150, 120);
            cardSobre.WrapContents = false;
            cardSobre.Name = "cardSobre";
            cardSobre.TabIndex = 42;
            // 
            // lblSobreTitulo
            // 
            lblSobreTitulo.AutoSize = true;
            lblSobreTitulo.Margin = new Padding(0, 0, 0, 10);
            lblSobreTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblSobreTitulo.ForeColor = Color.FromArgb(13, 43, 94);
            lblSobreTitulo.Name = "lblSobreTitulo";
            lblSobreTitulo.TabIndex = 43;
            lblSobreTitulo.Text = "Sobre o lugar";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Margin = new Padding(0, 0, 0, 4);
            lblDescricao.MaximumSize = new Size(1098, 0);
            lblDescricao.Font = new Font("Segoe UI", 13F);
            lblDescricao.ForeColor = Color.FromArgb(40, 48, 60);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.TabIndex = 44;
            lblDescricao.Text = "Descrição do lugar";
            // 
            // cardFicha
            // 
            cardFicha.AutoSize = true;
            cardFicha.Controls.Add(lblFichaTitulo);
            cardFicha.Controls.Add(lblFicha);
            cardFicha.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cardFicha.BackColor = Color.FromArgb(242, 248, 250);
            cardFicha.FlowDirection = FlowDirection.TopDown;
            cardFicha.Margin = new Padding(0, 0, 0, 18);
            cardFicha.MaximumSize = new Size(1150, 0);
            cardFicha.MinimumSize = new Size(1150, 0);
            cardFicha.Padding = new Padding(26, 20, 26, 22);
            cardFicha.Size = new Size(1150, 120);
            cardFicha.WrapContents = false;
            cardFicha.Name = "cardFicha";
            cardFicha.TabIndex = 45;
            // 
            // lblFichaTitulo
            // 
            lblFichaTitulo.AutoSize = true;
            lblFichaTitulo.Margin = new Padding(0, 0, 0, 10);
            lblFichaTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblFichaTitulo.ForeColor = Color.FromArgb(13, 43, 94);
            lblFichaTitulo.Name = "lblFichaTitulo";
            lblFichaTitulo.TabIndex = 46;
            lblFichaTitulo.Text = "Ficha do lugar";
            // 
            // lblFicha
            // 
            lblFicha.AutoSize = true;
            lblFicha.Margin = new Padding(0, 0, 0, 4);
            lblFicha.MaximumSize = new Size(1098, 0);
            lblFicha.Font = new Font("Segoe UI", 13F);
            lblFicha.ForeColor = Color.FromArgb(40, 48, 60);
            lblFicha.Name = "lblFicha";
            lblFicha.TabIndex = 47;
            lblFicha.Text = "•  Inauguração: ...";
            // 
            // cardHistoria
            // 
            cardHistoria.AutoSize = true;
            cardHistoria.Controls.Add(lblHistoriaTitulo);
            cardHistoria.Controls.Add(lblHistoria);
            cardHistoria.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cardHistoria.BackColor = Color.FromArgb(242, 248, 250);
            cardHistoria.FlowDirection = FlowDirection.TopDown;
            cardHistoria.Margin = new Padding(0, 0, 0, 18);
            cardHistoria.MaximumSize = new Size(1150, 0);
            cardHistoria.MinimumSize = new Size(1150, 0);
            cardHistoria.Padding = new Padding(26, 20, 26, 22);
            cardHistoria.Size = new Size(1150, 120);
            cardHistoria.WrapContents = false;
            cardHistoria.Name = "cardHistoria";
            cardHistoria.TabIndex = 48;
            // 
            // lblHistoriaTitulo
            // 
            lblHistoriaTitulo.AutoSize = true;
            lblHistoriaTitulo.Margin = new Padding(0, 0, 0, 10);
            lblHistoriaTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblHistoriaTitulo.ForeColor = Color.FromArgb(13, 43, 94);
            lblHistoriaTitulo.Name = "lblHistoriaTitulo";
            lblHistoriaTitulo.TabIndex = 49;
            lblHistoriaTitulo.Text = "História e curiosidades";
            // 
            // lblHistoria
            // 
            lblHistoria.AutoSize = true;
            lblHistoria.Margin = new Padding(0, 0, 0, 4);
            lblHistoria.MaximumSize = new Size(1098, 0);
            lblHistoria.Font = new Font("Segoe UI", 13F);
            lblHistoria.ForeColor = Color.FromArgb(40, 48, 60);
            lblHistoria.Name = "lblHistoria";
            lblHistoria.TabIndex = 50;
            lblHistoria.Text = "História do lugar";
            // 
            // cardVisitar
            // 
            cardVisitar.AutoSize = true;
            cardVisitar.Controls.Add(lblVisitarTitulo);
            cardVisitar.Controls.Add(lblIngresso);
            cardVisitar.Controls.Add(lblPreco);
            cardVisitar.Controls.Add(lblHorarioTitulo);
            cardVisitar.Controls.Add(lblHorario);
            cardVisitar.Controls.Add(lblContatoTitulo);
            cardVisitar.Controls.Add(lblTelefone);
            cardVisitar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cardVisitar.BackColor = Color.FromArgb(242, 248, 250);
            cardVisitar.FlowDirection = FlowDirection.TopDown;
            cardVisitar.Margin = new Padding(0, 0, 0, 18);
            cardVisitar.MaximumSize = new Size(1150, 0);
            cardVisitar.MinimumSize = new Size(1150, 0);
            cardVisitar.Padding = new Padding(26, 20, 26, 22);
            cardVisitar.Size = new Size(1150, 300);
            cardVisitar.WrapContents = false;
            cardVisitar.Name = "cardVisitar";
            cardVisitar.TabIndex = 51;
            // 
            // lblVisitarTitulo
            // 
            lblVisitarTitulo.AutoSize = true;
            lblVisitarTitulo.Margin = new Padding(0, 0, 0, 10);
            lblVisitarTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblVisitarTitulo.ForeColor = Color.FromArgb(13, 43, 94);
            lblVisitarTitulo.Name = "lblVisitarTitulo";
            lblVisitarTitulo.TabIndex = 52;
            lblVisitarTitulo.Text = "Planeje sua visita";
            // 
            // lblIngresso
            // 
            lblIngresso.AutoSize = true;
            lblIngresso.Margin = new Padding(0, 0, 0, 4);
            lblIngresso.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblIngresso.ForeColor = Color.FromArgb(11, 107, 138);
            lblIngresso.Name = "lblIngresso";
            lblIngresso.TabIndex = 53;
            lblIngresso.Text = "A partir de R$ 0";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Margin = new Padding(0, 0, 0, 4);
            lblPreco.MaximumSize = new Size(1098, 0);
            lblPreco.Font = new Font("Segoe UI", 13F);
            lblPreco.ForeColor = Color.FromArgb(40, 48, 60);
            lblPreco.Name = "lblPreco";
            lblPreco.TabIndex = 54;
            lblPreco.Text = "Preço";
            // 
            // lblHorarioTitulo
            // 
            lblHorarioTitulo.AutoSize = true;
            lblHorarioTitulo.Margin = new Padding(0, 16, 0, 6);
            lblHorarioTitulo.Font = new Font("Segoe UI Semibold", 12F);
            lblHorarioTitulo.ForeColor = Color.FromArgb(11, 107, 138);
            lblHorarioTitulo.Name = "lblHorarioTitulo";
            lblHorarioTitulo.TabIndex = 55;
            lblHorarioTitulo.Text = "HORÁRIOS";
            // 
            // lblHorario
            // 
            lblHorario.AutoSize = true;
            lblHorario.Margin = new Padding(0, 0, 0, 4);
            lblHorario.MaximumSize = new Size(1098, 0);
            lblHorario.Font = new Font("Segoe UI", 13F);
            lblHorario.ForeColor = Color.FromArgb(40, 48, 60);
            lblHorario.Name = "lblHorario";
            lblHorario.TabIndex = 56;
            lblHorario.Text = "Horários";
            // 
            // lblContatoTitulo
            // 
            lblContatoTitulo.AutoSize = true;
            lblContatoTitulo.Margin = new Padding(0, 16, 0, 6);
            lblContatoTitulo.Font = new Font("Segoe UI Semibold", 12F);
            lblContatoTitulo.ForeColor = Color.FromArgb(11, 107, 138);
            lblContatoTitulo.Name = "lblContatoTitulo";
            lblContatoTitulo.TabIndex = 57;
            lblContatoTitulo.Text = "CONTATO";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Margin = new Padding(0, 0, 0, 6);
            lblTelefone.Font = new Font("Segoe UI", 13F);
            lblTelefone.ForeColor = Color.FromArgb(40, 48, 60);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.TabIndex = 58;
            lblTelefone.Text = "Telefone: --";
            // 
            // cardOQueFazer
            // 
            cardOQueFazer.AutoSize = true;
            cardOQueFazer.Controls.Add(lblOQueFazerTitulo);
            cardOQueFazer.Controls.Add(lblOQueFazer);
            cardOQueFazer.Controls.Add(lblDicasTitulo);
            cardOQueFazer.Controls.Add(lblDicas);
            cardOQueFazer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cardOQueFazer.BackColor = Color.FromArgb(242, 248, 250);
            cardOQueFazer.FlowDirection = FlowDirection.TopDown;
            cardOQueFazer.Margin = new Padding(0, 0, 0, 18);
            cardOQueFazer.MaximumSize = new Size(1150, 0);
            cardOQueFazer.MinimumSize = new Size(1150, 0);
            cardOQueFazer.Padding = new Padding(26, 20, 26, 22);
            cardOQueFazer.Size = new Size(1150, 200);
            cardOQueFazer.WrapContents = false;
            cardOQueFazer.Name = "cardOQueFazer";
            cardOQueFazer.TabIndex = 59;
            // 
            // lblOQueFazerTitulo
            // 
            lblOQueFazerTitulo.AutoSize = true;
            lblOQueFazerTitulo.Margin = new Padding(0, 0, 0, 10);
            lblOQueFazerTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblOQueFazerTitulo.ForeColor = Color.FromArgb(13, 43, 94);
            lblOQueFazerTitulo.Name = "lblOQueFazerTitulo";
            lblOQueFazerTitulo.TabIndex = 60;
            lblOQueFazerTitulo.Text = "O que fazer";
            // 
            // lblOQueFazer
            // 
            lblOQueFazer.AutoSize = true;
            lblOQueFazer.Margin = new Padding(0, 0, 0, 4);
            lblOQueFazer.MaximumSize = new Size(1098, 0);
            lblOQueFazer.Font = new Font("Segoe UI", 13F);
            lblOQueFazer.ForeColor = Color.FromArgb(40, 48, 60);
            lblOQueFazer.Name = "lblOQueFazer";
            lblOQueFazer.TabIndex = 61;
            lblOQueFazer.Text = "✓  Atividade";
            // 
            // lblDicasTitulo
            // 
            lblDicasTitulo.AutoSize = true;
            lblDicasTitulo.Margin = new Padding(0, 16, 0, 6);
            lblDicasTitulo.Font = new Font("Segoe UI Semibold", 12F);
            lblDicasTitulo.ForeColor = Color.FromArgb(11, 107, 138);
            lblDicasTitulo.Name = "lblDicasTitulo";
            lblDicasTitulo.TabIndex = 62;
            lblDicasTitulo.Text = "DICAS DA NOSSA EQUIPE";
            // 
            // lblDicas
            // 
            lblDicas.AutoSize = true;
            lblDicas.Margin = new Padding(0, 0, 0, 4);
            lblDicas.MaximumSize = new Size(1098, 0);
            lblDicas.Font = new Font("Segoe UI", 13F);
            lblDicas.ForeColor = Color.FromArgb(40, 48, 60);
            lblDicas.Name = "lblDicas";
            lblDicas.TabIndex = 63;
            lblDicas.Text = "•  Dica";
            // 
            // cardParecidos
            // 
            cardParecidos.AutoSize = true;
            cardParecidos.Controls.Add(lblParecidosTitulo);
            cardParecidos.Controls.Add(flpSemelhantes);
            cardParecidos.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cardParecidos.BackColor = Color.FromArgb(242, 248, 250);
            cardParecidos.FlowDirection = FlowDirection.TopDown;
            cardParecidos.Margin = new Padding(0, 0, 0, 18);
            cardParecidos.MaximumSize = new Size(1150, 0);
            cardParecidos.MinimumSize = new Size(1150, 0);
            cardParecidos.Padding = new Padding(26, 20, 26, 22);
            cardParecidos.Size = new Size(1150, 200);
            cardParecidos.WrapContents = false;
            cardParecidos.Name = "cardParecidos";
            cardParecidos.TabIndex = 64;
            // 
            // lblParecidosTitulo
            // 
            lblParecidosTitulo.AutoSize = true;
            lblParecidosTitulo.Margin = new Padding(0, 0, 0, 10);
            lblParecidosTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblParecidosTitulo.ForeColor = Color.FromArgb(13, 43, 94);
            lblParecidosTitulo.Name = "lblParecidosTitulo";
            lblParecidosTitulo.TabIndex = 65;
            lblParecidosTitulo.Text = "Lugares parecidos";
            // 
            // flpSemelhantes
            // 
            flpSemelhantes.AutoSize = true;
            flpSemelhantes.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpSemelhantes.FlowDirection = FlowDirection.TopDown;
            flpSemelhantes.Margin = new Padding(0);
            flpSemelhantes.Size = new Size(1098, 10);
            flpSemelhantes.WrapContents = false;
            flpSemelhantes.Name = "flpSemelhantes";
            flpSemelhantes.TabIndex = 66;
            // 
            // cardLinks
            // 
            cardLinks.AutoSize = true;
            cardLinks.Controls.Add(lblLinksTitulo);
            cardLinks.Controls.Add(lnkInstagram);
            cardLinks.Controls.Add(lnkSite);
            cardLinks.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cardLinks.BackColor = Color.FromArgb(242, 248, 250);
            cardLinks.FlowDirection = FlowDirection.TopDown;
            cardLinks.Margin = new Padding(0, 0, 0, 18);
            cardLinks.MaximumSize = new Size(1150, 0);
            cardLinks.MinimumSize = new Size(1150, 0);
            cardLinks.Padding = new Padding(26, 20, 26, 22);
            cardLinks.Size = new Size(1150, 140);
            cardLinks.WrapContents = false;
            cardLinks.Name = "cardLinks";
            cardLinks.TabIndex = 67;
            // 
            // lblLinksTitulo
            // 
            lblLinksTitulo.AutoSize = true;
            lblLinksTitulo.Margin = new Padding(0, 0, 0, 10);
            lblLinksTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblLinksTitulo.ForeColor = Color.FromArgb(13, 43, 94);
            lblLinksTitulo.Name = "lblLinksTitulo";
            lblLinksTitulo.TabIndex = 68;
            lblLinksTitulo.Text = "Instagram e site";
            // 
            // lnkInstagram
            // 
            lnkInstagram.AutoSize = true;
            lnkInstagram.Font = new Font("Segoe UI", 14F);
            lnkInstagram.ForeColor = Color.FromArgb(40, 48, 60);
            lnkInstagram.LinkColor = Color.FromArgb(11, 107, 138);
            lnkInstagram.Margin = new Padding(0, 0, 0, 8);
            lnkInstagram.MaximumSize = new Size(1098, 0);
            lnkInstagram.Name = "lnkInstagram";
            lnkInstagram.TabIndex = 69;
            lnkInstagram.TabStop = true;
            lnkInstagram.Text = "Instagram: @perfil";
            lnkInstagram.LinkClicked += lnkInstagram_LinkClicked;
            // 
            // lnkSite
            // 
            lnkSite.AutoSize = true;
            lnkSite.Font = new Font("Segoe UI", 14F);
            lnkSite.ForeColor = Color.FromArgb(40, 48, 60);
            lnkSite.LinkColor = Color.FromArgb(11, 107, 138);
            lnkSite.Margin = new Padding(0, 0, 0, 8);
            lnkSite.MaximumSize = new Size(1098, 0);
            lnkSite.Name = "lnkSite";
            lnkSite.TabIndex = 70;
            lnkSite.TabStop = true;
            lnkSite.Text = "Site: www.site.com.br";
            lnkSite.LinkClicked += lnkSite_LinkClicked;
            // 
            // lblFontes
            // 
            lblFontes.AutoSize = true;
            lblFontes.Margin = new Padding(0, 4, 0, 0);
            lblFontes.MaximumSize = new Size(1150, 0);
            lblFontes.Font = new Font("Segoe UI", 9.5F);
            lblFontes.ForeColor = Color.FromArgb(88, 98, 112);
            lblFontes.Name = "lblFontes";
            lblFontes.TabIndex = 71;
            lblFontes.Text = "Fontes:";
            // 
            // pnlEspacoFinal
            // 
            pnlEspacoFinal.Margin = new Padding(0);
            pnlEspacoFinal.Name = "pnlEspacoFinal";
            pnlEspacoFinal.Size = new Size(600, 40);
            pnlEspacoFinal.TabIndex = 72;
            // 
            // FormDetalhe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(222, 236, 242);
            ClientSize = new Size(1920, 2300);
            Controls.Add(flpPagina);
            Controls.Add(pnlLateral);
            Controls.Add(pnlLinhaTopo);
            Controls.Add(pnlTopo);
            Icon = Properties.Resources.icone;
            KeyPreview = true;
            MinimumSize = new Size(1200, 760);
            Name = "FormDetalhe";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Detalhes - Bauru's Tour";
            WindowState = FormWindowState.Maximized;
            Load += FormDetalhe_Load;
            Shown += FormDetalhe_Shown;
            Resize += FormDetalhe_Resize;
            KeyDown += FormDetalhe_KeyDown;
            pnlTopo.ResumeLayout(false);
            pnlTopo.PerformLayout();
            pnlLinhaTopo.ResumeLayout(false);
            pnlLinhaTopo.PerformLayout();
            pnlLateral.ResumeLayout(false);
            pnlLateral.PerformLayout();
            pnlFotoArea.ResumeLayout(false);
            pnlFotoArea.PerformLayout();
            pnlControlesFoto.ResumeLayout(false);
            pnlControlesFoto.PerformLayout();
            pnlMapaArea.ResumeLayout(false);
            pnlMapaArea.PerformLayout();
            flpPagina.ResumeLayout(false);
            flpPagina.PerformLayout();
            tlpCabecalho.ResumeLayout(false);
            tlpCabecalho.PerformLayout();
            flpInfo.ResumeLayout(false);
            flpInfo.PerformLayout();
            flpEtiquetas.ResumeLayout(false);
            flpEtiquetas.PerformLayout();
            flpEndereco.ResumeLayout(false);
            flpEndereco.PerformLayout();
            flpAcoes.ResumeLayout(false);
            flpAcoes.PerformLayout();
            pnlAvaliacao.ResumeLayout(false);
            pnlAvaliacao.PerformLayout();
            flpEstrelas.ResumeLayout(false);
            flpEstrelas.PerformLayout();
            cardSobre.ResumeLayout(false);
            cardSobre.PerformLayout();
            cardFicha.ResumeLayout(false);
            cardFicha.PerformLayout();
            cardHistoria.ResumeLayout(false);
            cardHistoria.PerformLayout();
            cardVisitar.ResumeLayout(false);
            cardVisitar.PerformLayout();
            cardOQueFazer.ResumeLayout(false);
            cardOQueFazer.PerformLayout();
            cardParecidos.ResumeLayout(false);
            cardParecidos.PerformLayout();
            flpSemelhantes.ResumeLayout(false);
            flpSemelhantes.PerformLayout();
            cardLinks.ResumeLayout(false);
            cardLinks.PerformLayout();
            pnlEspacoFinal.ResumeLayout(false);
            pnlEspacoFinal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)picFoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)picIconeEndereco).EndInit();
            ((System.ComponentModel.ISupportInitialize)webMapa).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTopo;
        private Label lblMarca;
        private PictureBox picLogo;
        private Button btnVoltar;
        private Panel pnlLinhaTopo;
        private Panel pnlLateral;
        private Panel pnlFotoArea;
        private PictureBox picFoto;
        private Panel pnlControlesFoto;
        private Label lblContadorFotos;
        private Button btnFotoAnterior;
        private Button btnFotoProxima;
        private Panel pnlMapaArea;
        private Microsoft.Web.WebView2.WinForms.WebView2 webMapa;
        private Label lblMapaErro;
        private FlowLayoutPanel flpPagina;
        private Label lblNome;
        private TableLayoutPanel tlpCabecalho;
        private FlowLayoutPanel flpInfo;
        private FlowLayoutPanel flpEtiquetas;
        private Label lblCategoria;
        private Label lblPrecoResumo;
        private Label lblSituacao;
        private Label lblNotaResumo;
        private FlowLayoutPanel flpEndereco;
        private PictureBox picIconeEndereco;
        private Label lblEndereco;
        private FlowLayoutPanel flpAcoes;
        private Button btnRota;
        private Button btnCardapioLoja;
        private Button btnCompartilhar;
        private Button btnFavoritar;
        private Panel pnlAvaliacao;
        private Label lblAvaliacaoTitulo;
        private FlowLayoutPanel flpEstrelas;
        private Button btnEstrela1;
        private Button btnEstrela2;
        private Button btnEstrela3;
        private Button btnEstrela4;
        private Button btnEstrela5;
        private Label lblNotaDescricao;
        private LinkLabel lnkRemoverNota;
        private FlowLayoutPanel cardSobre;
        private Label lblSobreTitulo;
        private Label lblDescricao;
        private FlowLayoutPanel cardFicha;
        private Label lblFichaTitulo;
        private Label lblFicha;
        private FlowLayoutPanel cardHistoria;
        private Label lblHistoriaTitulo;
        private Label lblHistoria;
        private FlowLayoutPanel cardVisitar;
        private Label lblVisitarTitulo;
        private Label lblIngresso;
        private Label lblPreco;
        private Label lblHorarioTitulo;
        private Label lblHorario;
        private Label lblContatoTitulo;
        private Label lblTelefone;
        private FlowLayoutPanel cardOQueFazer;
        private Label lblOQueFazerTitulo;
        private Label lblOQueFazer;
        private Label lblDicasTitulo;
        private Label lblDicas;
        private FlowLayoutPanel cardParecidos;
        private Label lblParecidosTitulo;
        private FlowLayoutPanel flpSemelhantes;
        private FlowLayoutPanel cardLinks;
        private Label lblLinksTitulo;
        private LinkLabel lnkInstagram;
        private LinkLabel lnkSite;
        private Label lblFontes;
        private Panel pnlEspacoFinal;
    }
}
