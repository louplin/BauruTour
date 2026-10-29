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
            imgFoto = new BaurusTour.Componentes.ImagemCapa();
            etqCategoria = new BaurusTour.Componentes.EtiquetaCategoria();
            lblNome = new Label();
            lblDescricao = new Label();
            btnVerDetalhes = new BaurusTour.Componentes.BotaoArredondado();
            btnFavoritar = new BaurusTour.Componentes.BotaoArredondado();
            SuspendLayout();
            //
            // imgFoto
            //
            imgFoto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            imgFoto.ArredondarSoEmCima = true;
            imgFoto.Cursor = Cursors.Hand;
            imgFoto.Location = new Point(1, 1);
            imgFoto.Name = "imgFoto";
            imgFoto.Raio = 14;
            imgFoto.Size = new Size(338, 186);
            imgFoto.Click += AbrirDetalhes_Click;
            //
            // etqCategoria
            //
            etqCategoria.Location = new Point(20, 202);
            etqCategoria.Name = "etqCategoria";
            etqCategoria.Size = new Size(96, 26);
            etqCategoria.Text = "Natureza";
            //
            // lblNome
            //
            lblNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblNome.AutoEllipsis = true;
            lblNome.BackColor = Color.Transparent;
            lblNome.Cursor = Cursors.Hand;
            lblNome.Font = new Font("Segoe UI", 13.5F, FontStyle.Bold);
            lblNome.ForeColor = Color.FromArgb(13, 43, 94);
            lblNome.Location = new Point(18, 236);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(304, 30);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome do ponto turístico";
            lblNome.Click += AbrirDetalhes_Click;
            //
            // lblDescricao
            //
            lblDescricao.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDescricao.AutoEllipsis = true;
            lblDescricao.BackColor = Color.Transparent;
            lblDescricao.Font = new Font("Segoe UI", 10F);
            lblDescricao.ForeColor = Color.FromArgb(88, 98, 112);
            lblDescricao.Location = new Point(19, 268);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(302, 60);
            lblDescricao.TabIndex = 1;
            lblDescricao.Text = "Descrição curta do lugar.";
            //
            // btnVerDetalhes
            //
            btnVerDetalhes.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnVerDetalhes.CorBorda = Color.FromArgb(11, 107, 138);
            btnVerDetalhes.CorFundo = Color.White;
            btnVerDetalhes.CorFundoHover = Color.FromArgb(228, 241, 245);
            btnVerDetalhes.EspessuraBorda = 2;
            btnVerDetalhes.Font = new Font("Segoe UI Semibold", 10.5F);
            btnVerDetalhes.ForeColor = Color.FromArgb(11, 107, 138);
            btnVerDetalhes.Icone = "";
            btnVerDetalhes.Location = new Point(18, 340);
            btnVerDetalhes.Name = "btnVerDetalhes";
            btnVerDetalhes.Size = new Size(158, 42);
            btnVerDetalhes.TabIndex = 2;
            btnVerDetalhes.Text = "Ver detalhes";
            btnVerDetalhes.Click += AbrirDetalhes_Click;
            //
            // btnFavoritar
            //
            btnFavoritar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnFavoritar.CorFundo = Color.White;
            btnFavoritar.CorFundoHover = Color.FromArgb(253, 236, 237);
            btnFavoritar.Font = new Font("Segoe UI", 15F);
            btnFavoritar.ForeColor = Color.FromArgb(226, 72, 80);
            btnFavoritar.Icone = "";
            btnFavoritar.Location = new Point(276, 339);
            btnFavoritar.Name = "btnFavoritar";
            btnFavoritar.Raio = 22;
            btnFavoritar.Size = new Size(44, 44);
            btnFavoritar.TabIndex = 3;
            btnFavoritar.Click += btnFavoritar_Click;
            //
            // CardPontoTuristico
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(btnFavoritar);
            Controls.Add(btnVerDetalhes);
            Controls.Add(lblDescricao);
            Controls.Add(lblNome);
            Controls.Add(etqCategoria);
            Controls.Add(imgFoto);
            Margin = new Padding(0, 0, 24, 24);
            Name = "CardPontoTuristico";
            Size = new Size(340, 400);
            ResumeLayout(false);
        }

        #endregion

        private BaurusTour.Componentes.ImagemCapa imgFoto;
        private BaurusTour.Componentes.EtiquetaCategoria etqCategoria;
        private Label lblNome;
        private Label lblDescricao;
        private BaurusTour.Componentes.BotaoArredondado btnVerDetalhes;
        private BaurusTour.Componentes.BotaoArredondado btnFavoritar;
    }
}
