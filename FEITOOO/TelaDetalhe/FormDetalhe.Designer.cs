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
            pnlBarraTopo = new Panel();
            btnTelaCheia = new BaurusTour.Componentes.BotaoArredondado();
            lblMarca = new Label();
            picLogo = new PictureBox();
            btnVoltar = new BaurusTour.Componentes.BotaoArredondado();
            pnlDivisorTopo = new Panel();
            tlpConteudo = new TableLayoutPanel();
            imgFoto = new BaurusTour.Componentes.ImagemCapa();
            tlpInformacoes = new TableLayoutPanel();
            etqCategoria = new BaurusTour.Componentes.EtiquetaCategoria();
            lblNome = new Label();
            lblEnderecoTitulo = new Label();
            lblEndereco = new Label();
            lblSobreTitulo = new Label();
            lblDescricao = new Label();
            flpAcoes = new FlowLayoutPanel();
            btnMapa = new BaurusTour.Componentes.BotaoArredondado();
            btnCompartilhar = new BaurusTour.Componentes.BotaoArredondado();
            btnFavoritar = new BaurusTour.Componentes.BotaoArredondado();
            pnlBarraTopo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            tlpConteudo.SuspendLayout();
            tlpInformacoes.SuspendLayout();
            flpAcoes.SuspendLayout();
            SuspendLayout();
            //
            // pnlBarraTopo
            //
            pnlBarraTopo.BackColor = Color.White;
            pnlBarraTopo.Controls.Add(btnTelaCheia);
            pnlBarraTopo.Controls.Add(lblMarca);
            pnlBarraTopo.Controls.Add(picLogo);
            pnlBarraTopo.Controls.Add(btnVoltar);
            pnlBarraTopo.Dock = DockStyle.Top;
            pnlBarraTopo.Location = new Point(0, 0);
            pnlBarraTopo.Name = "pnlBarraTopo";
            pnlBarraTopo.Size = new Size(1200, 76);
            pnlBarraTopo.TabIndex = 0;
            //
            // btnTelaCheia
            //
            btnTelaCheia.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTelaCheia.CorBorda = Color.FromArgb(220, 226, 230);
            btnTelaCheia.CorFundo = Color.White;
            btnTelaCheia.CorFundoHover = Color.FromArgb(240, 244, 246);
            btnTelaCheia.Font = new Font("Segoe UI", 11F);
            btnTelaCheia.ForeColor = Color.FromArgb(13, 43, 94);
            btnTelaCheia.Icone = "";
            btnTelaCheia.Location = new Point(992, 16);
            btnTelaCheia.Name = "btnTelaCheia";
            btnTelaCheia.Size = new Size(180, 44);
            btnTelaCheia.TabIndex = 1;
            btnTelaCheia.Text = "Tela cheia";
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
            lblMarca.TabIndex = 3;
            lblMarca.Text = "Bauru's Tour";
            //
            // picLogo
            //
            picLogo.Location = new Point(176, 18);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(40, 40);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 2;
            picLogo.TabStop = false;
            //
            // btnVoltar
            //
            btnVoltar.CorBorda = Color.FromArgb(11, 107, 138);
            btnVoltar.CorFundo = Color.White;
            btnVoltar.CorFundoHover = Color.FromArgb(228, 241, 245);
            btnVoltar.EspessuraBorda = 2;
            btnVoltar.Font = new Font("Segoe UI Semibold", 11F);
            btnVoltar.ForeColor = Color.FromArgb(11, 107, 138);
            btnVoltar.Icone = "";
            btnVoltar.Location = new Point(28, 16);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(130, 44);
            btnVoltar.TabIndex = 0;
            btnVoltar.Text = "Voltar";
            btnVoltar.Click += btnVoltar_Click;
            //
            // pnlDivisorTopo
            //
            pnlDivisorTopo.BackColor = Color.FromArgb(220, 226, 230);
            pnlDivisorTopo.Dock = DockStyle.Top;
            pnlDivisorTopo.Location = new Point(0, 76);
            pnlDivisorTopo.Name = "pnlDivisorTopo";
            pnlDivisorTopo.Size = new Size(1200, 1);
            pnlDivisorTopo.TabIndex = 1;
            //
            // tlpConteudo
            //
            tlpConteudo.BackColor = Color.FromArgb(247, 248, 246);
            tlpConteudo.ColumnCount = 2;
            tlpConteudo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52F));
            tlpConteudo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48F));
            tlpConteudo.Controls.Add(imgFoto, 0, 0);
            tlpConteudo.Controls.Add(tlpInformacoes, 1, 0);
            tlpConteudo.Dock = DockStyle.Fill;
            tlpConteudo.Location = new Point(0, 77);
            tlpConteudo.Name = "tlpConteudo";
            tlpConteudo.Padding = new Padding(40, 32, 40, 32);
            tlpConteudo.RowCount = 1;
            tlpConteudo.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpConteudo.Size = new Size(1200, 683);
            tlpConteudo.TabIndex = 2;
            //
            // imgFoto
            //
            imgFoto.Dock = DockStyle.Fill;
            imgFoto.Location = new Point(40, 32);
            imgFoto.Margin = new Padding(0, 0, 32, 0);
            imgFoto.Name = "imgFoto";
            imgFoto.Raio = 22;
            imgFoto.Size = new Size(536, 619);
            //
            // tlpInformacoes
            //
            tlpInformacoes.AutoScroll = true;
            tlpInformacoes.ColumnCount = 1;
            tlpInformacoes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpInformacoes.Controls.Add(etqCategoria, 0, 0);
            tlpInformacoes.Controls.Add(lblNome, 0, 1);
            tlpInformacoes.Controls.Add(lblEnderecoTitulo, 0, 2);
            tlpInformacoes.Controls.Add(lblEndereco, 0, 3);
            tlpInformacoes.Controls.Add(lblSobreTitulo, 0, 4);
            tlpInformacoes.Controls.Add(lblDescricao, 0, 5);
            tlpInformacoes.Controls.Add(flpAcoes, 0, 6);
            tlpInformacoes.Dock = DockStyle.Fill;
            tlpInformacoes.Location = new Point(608, 32);
            tlpInformacoes.Margin = new Padding(0);
            tlpInformacoes.Name = "tlpInformacoes";
            tlpInformacoes.Padding = new Padding(8, 4, 8, 4);
            tlpInformacoes.RowCount = 8;
            tlpInformacoes.RowStyles.Add(new RowStyle());
            tlpInformacoes.RowStyles.Add(new RowStyle());
            tlpInformacoes.RowStyles.Add(new RowStyle());
            tlpInformacoes.RowStyles.Add(new RowStyle());
            tlpInformacoes.RowStyles.Add(new RowStyle());
            tlpInformacoes.RowStyles.Add(new RowStyle());
            tlpInformacoes.RowStyles.Add(new RowStyle());
            tlpInformacoes.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpInformacoes.Size = new Size(552, 619);
            tlpInformacoes.TabIndex = 1;
            //
            // etqCategoria
            //
            etqCategoria.Location = new Point(8, 4);
            etqCategoria.Margin = new Padding(0, 0, 0, 14);
            etqCategoria.Name = "etqCategoria";
            etqCategoria.Size = new Size(110, 28);
            etqCategoria.Text = "Natureza";
            //
            // lblNome
            //
            lblNome.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblNome.ForeColor = Color.FromArgb(13, 43, 94);
            lblNome.Location = new Point(8, 46);
            lblNome.Margin = new Padding(0, 0, 0, 20);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(536, 51);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome do lugar";
            //
            // lblEnderecoTitulo
            //
            lblEnderecoTitulo.AutoSize = true;
            lblEnderecoTitulo.Font = new Font("Segoe UI Semibold", 9.75F);
            lblEnderecoTitulo.ForeColor = Color.FromArgb(11, 107, 138);
            lblEnderecoTitulo.Location = new Point(8, 117);
            lblEnderecoTitulo.Margin = new Padding(0, 0, 0, 4);
            lblEnderecoTitulo.Name = "lblEnderecoTitulo";
            lblEnderecoTitulo.Size = new Size(72, 17);
            lblEnderecoTitulo.TabIndex = 1;
            lblEnderecoTitulo.Text = "ENDEREÇO";
            //
            // lblEndereco
            //
            lblEndereco.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblEndereco.AutoSize = true;
            lblEndereco.Font = new Font("Segoe UI", 12F);
            lblEndereco.ForeColor = Color.FromArgb(88, 98, 112);
            lblEndereco.Location = new Point(8, 138);
            lblEndereco.Margin = new Padding(0, 0, 0, 24);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(536, 21);
            lblEndereco.TabIndex = 2;
            lblEndereco.Text = "Endereço";
            //
            // lblSobreTitulo
            //
            lblSobreTitulo.AutoSize = true;
            lblSobreTitulo.Font = new Font("Segoe UI Semibold", 9.75F);
            lblSobreTitulo.ForeColor = Color.FromArgb(11, 107, 138);
            lblSobreTitulo.Location = new Point(8, 183);
            lblSobreTitulo.Margin = new Padding(0, 0, 0, 4);
            lblSobreTitulo.Name = "lblSobreTitulo";
            lblSobreTitulo.Size = new Size(103, 17);
            lblSobreTitulo.TabIndex = 3;
            lblSobreTitulo.Text = "SOBRE O LUGAR";
            //
            // lblDescricao
            //
            lblDescricao.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblDescricao.AutoSize = true;
            lblDescricao.Font = new Font("Segoe UI", 12.5F);
            lblDescricao.ForeColor = Color.FromArgb(40, 48, 60);
            lblDescricao.Location = new Point(8, 204);
            lblDescricao.Margin = new Padding(0, 0, 0, 30);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(536, 23);
            lblDescricao.TabIndex = 4;
            lblDescricao.Text = "Descrição";
            //
            // flpAcoes
            //
            flpAcoes.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            flpAcoes.AutoSize = true;
            flpAcoes.Controls.Add(btnMapa);
            flpAcoes.Controls.Add(btnCompartilhar);
            flpAcoes.Controls.Add(btnFavoritar);
            flpAcoes.Location = new Point(8, 257);
            flpAcoes.Margin = new Padding(0);
            flpAcoes.Name = "flpAcoes";
            flpAcoes.Size = new Size(536, 64);
            flpAcoes.TabIndex = 5;
            //
            // btnMapa
            //
            btnMapa.Font = new Font("Segoe UI Semibold", 11.5F);
            btnMapa.Icone = "";
            btnMapa.Location = new Point(0, 0);
            btnMapa.Margin = new Padding(0, 0, 12, 12);
            btnMapa.Name = "btnMapa";
            btnMapa.Raio = 26;
            btnMapa.Size = new Size(236, 52);
            btnMapa.TabIndex = 0;
            btnMapa.Text = "Ver no Google Maps";
            btnMapa.Click += btnMapa_Click;
            //
            // btnCompartilhar
            //
            btnCompartilhar.CorBorda = Color.FromArgb(11, 107, 138);
            btnCompartilhar.CorFundo = Color.White;
            btnCompartilhar.CorFundoHover = Color.FromArgb(228, 241, 245);
            btnCompartilhar.EspessuraBorda = 2;
            btnCompartilhar.Font = new Font("Segoe UI Semibold", 11.5F);
            btnCompartilhar.ForeColor = Color.FromArgb(11, 107, 138);
            btnCompartilhar.Icone = "";
            btnCompartilhar.Location = new Point(248, 0);
            btnCompartilhar.Margin = new Padding(0, 0, 12, 12);
            btnCompartilhar.Name = "btnCompartilhar";
            btnCompartilhar.Raio = 26;
            btnCompartilhar.Size = new Size(184, 52);
            btnCompartilhar.TabIndex = 1;
            btnCompartilhar.Text = "Compartilhar";
            btnCompartilhar.Click += btnCompartilhar_Click;
            //
            // btnFavoritar
            //
            btnFavoritar.CorBorda = Color.FromArgb(226, 72, 80);
            btnFavoritar.CorFundo = Color.White;
            btnFavoritar.CorFundoHover = Color.FromArgb(253, 236, 237);
            btnFavoritar.EspessuraBorda = 2;
            btnFavoritar.Font = new Font("Segoe UI Semibold", 11.5F);
            btnFavoritar.ForeColor = Color.FromArgb(226, 72, 80);
            btnFavoritar.Icone = "";
            btnFavoritar.Location = new Point(0, 64);
            btnFavoritar.Margin = new Padding(0, 0, 12, 12);
            btnFavoritar.Name = "btnFavoritar";
            btnFavoritar.Raio = 26;
            btnFavoritar.Size = new Size(176, 52);
            btnFavoritar.TabIndex = 2;
            btnFavoritar.Text = "Favoritar";
            btnFavoritar.Click += btnFavoritar_Click;
            //
            // FormDetalhe
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 248, 246);
            ClientSize = new Size(1200, 760);
            Controls.Add(tlpConteudo);
            Controls.Add(pnlDivisorTopo);
            Controls.Add(pnlBarraTopo);
            KeyPreview = true;
            MinimumSize = new Size(1000, 680);
            Name = "FormDetalhe";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Detalhes - Bauru's Tour";
            WindowState = FormWindowState.Maximized;
            Load += FormDetalhe_Load;
            Shown += FormDetalhe_Shown;
            KeyDown += FormDetalhe_KeyDown;
            pnlBarraTopo.ResumeLayout(false);
            pnlBarraTopo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            tlpConteudo.ResumeLayout(false);
            tlpInformacoes.ResumeLayout(false);
            tlpInformacoes.PerformLayout();
            flpAcoes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBarraTopo;
        private BaurusTour.Componentes.BotaoArredondado btnVoltar;
        private PictureBox picLogo;
        private Label lblMarca;
        private BaurusTour.Componentes.BotaoArredondado btnTelaCheia;
        private Panel pnlDivisorTopo;
        private TableLayoutPanel tlpConteudo;
        private BaurusTour.Componentes.ImagemCapa imgFoto;
        private TableLayoutPanel tlpInformacoes;
        private BaurusTour.Componentes.EtiquetaCategoria etqCategoria;
        private Label lblNome;
        private Label lblEnderecoTitulo;
        private Label lblEndereco;
        private Label lblSobreTitulo;
        private Label lblDescricao;
        private FlowLayoutPanel flpAcoes;
        private BaurusTour.Componentes.BotaoArredondado btnMapa;
        private BaurusTour.Componentes.BotaoArredondado btnCompartilhar;
        private BaurusTour.Componentes.BotaoArredondado btnFavoritar;
    }
}
