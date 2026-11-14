using System.Diagnostics;
using BaurusTour.Classes;
using BaurusTour.Modelos;
using BaurusTour.Telas.TelaCompartilhar;
using Microsoft.Web.WebView2.Core;

namespace BaurusTour.Telas.TelaDetalhe
{
    // Tela de detalhes. A foto e o mapa ficam parados do lado esquerdo
    // e as informações ficam numa página que rola do lado direito.
    public partial class FormDetalhe : Form
    {
        private PontoTuristico? ponto;
        private GerenciadorFavoritos? favoritos;
        private GerenciadorPontos? pontos;
        private GerenciadorAvaliacoes? avaliacoes;

        // fotos do lugar no tamanho original e o número da que está aparecendo
        private List<Image> fotos = new List<Image>();
        private int fotoAtual = 0;

        // os cards da página, na ordem da tela
        private List<Control> cards = new List<Control>();

        // id do lugar que está carregado no mapa (0 = nenhum ainda)
        private int idDoMapa = 0;
        private bool eventoDoMapaLigado = false;
        private bool telaJaApareceu = false;

        private Color corCoracao = Color.FromArgb(226, 72, 80);

        // o Designer precisa desse construtor vazio
        public FormDetalhe()
        {
            InitializeComponent();

            cards.Add(cardSobre);
            cards.Add(cardFicha);
            cards.Add(cardHistoria);
            cards.Add(cardVisitar);
            cards.Add(cardOQueFazer);
            cards.Add(cardParecidos);
            cards.Add(cardLinks);

            // o aviso fica por cima do mapa até ele carregar
            lblMapaErro.BringToFront();

            // No Designer a tela é bem alta pra dar pra ver a página inteira na apresentação.
            // Quando o app roda, ela volta pro tamanho normal (e abre maximizada).
            ClientSize = new Size(1280, 760);
        }

        public FormDetalhe(PontoTuristico ponto, GerenciadorFavoritos favoritos,
                           GerenciadorPontos pontos, GerenciadorAvaliacoes avaliacoes) : this()
        {
            this.ponto = ponto;
            this.favoritos = favoritos;
            this.pontos = pontos;
            this.avaliacoes = avaliacoes;
        }

        private void FormDetalhe_Load(object? sender, EventArgs e)
        {
            if (ponto != null)
                MostrarPonto(ponto);
        }

        // O mapa só começa a carregar depois que a tela já apareceu,
        // assim a tela abre na hora e o mapa vem logo em seguida
        private void FormDetalhe_Shown(object? sender, EventArgs e)
        {
            telaJaApareceu = true;
            CarregarMapa();
        }

        // A coluna da esquerda ocupa 40% da largura da tela.
        // Dentro dela, a foto fica com 60% da altura e o mapa com o resto.
        private void FormDetalhe_Resize(object? sender, EventArgs e)
        {
            pnlLateral.Width = ClientSize.Width * 40 / 100;

            int alturaUtil = pnlLateral.ClientSize.Height - pnlLateral.Padding.Vertical;
            pnlFotoArea.Height = alturaUtil * 60 / 100;
            pnlMapaArea.Height = alturaUtil - pnlFotoArea.Height;
        }

        // Coloca os dados do lugar na tela.
        // Também é usado quando clica em um dos "Lugares parecidos".
        private void MostrarPonto(PontoTuristico novoPonto)
        {
            ponto = novoPonto;
            flpPagina.SuspendLayout();

            Text = ponto.Nome + " - Bauru's Tour";
            lblNome.Text = ponto.Nome;
            lblCategoria.Text = ponto.Categoria;
            lblEndereco.Text = ponto.Endereco;
            MostrarSituacao();
            MostrarPrecoResumo();

            lblDescricao.Text = ponto.Descricao;

            lblFicha.Text = MontarLista(ponto.Ficha, "•");
            cardFicha.Visible = ponto.Ficha.Count > 0;

            lblHistoria.Text = ponto.Curiosidades;
            cardHistoria.Visible = ponto.Curiosidades != "";

            lblIngresso.Text = "A partir de " + ponto.IngressoAPartirDe;
            lblIngresso.Visible = ponto.IngressoAPartirDe != "";
            lblPreco.Text = TextoOuTraco(ponto.Preco);
            lblHorario.Text = VerificadorHorario.TextoHorario(ponto);
            MostrarContato();

            lblOQueFazer.Text = MontarLista(ponto.OQueFazer, "✓");
            lblDicas.Text = MontarLista(ponto.Dicas, "•");
            lblDicasTitulo.Visible = ponto.Dicas.Count > 0;
            lblDicas.Visible = ponto.Dicas.Count > 0;

            lblFontes.Text = "Fontes das informações: " + string.Join("; ", ponto.Fontes);
            lblFontes.Visible = ponto.Fontes.Count > 0;

            // sem o link do Maps não dá pra compartilhar a localização
            btnCompartilhar.Enabled = ponto.LinkMaps != "";

            ConfigurarBotaoCardapioLoja();
            AtualizarBotaoFavoritar();
            AtualizarAvaliacao();
            MostrarSemelhantes();
            flpPagina.ResumeLayout(true);

            // volta pro topo da página e mostra a primeira foto
            flpPagina.AutoScrollPosition = new Point(0, 0);
            MontarGaleria();

            if (telaJaApareceu)
                CarregarMapa();
        }

        private string TextoOuTraco(string texto)
        {
            if (texto == "")
                return "--";

            return texto;
        }

        private string MontarLista(List<string> itens, string marcador)
        {
            string texto = "";
            foreach (string item in itens)
            {
                texto = texto + marcador + "  " + item + "\n";
            }
            return texto.Trim();
        }

        // O telefone fica no card "Planeje sua visita".
        // O Instagram e o site ficam no último card da página, e só aparece o que o lugar tiver.
        private void MostrarContato()
        {
            if (ponto == null)
                return;

            lblContatoTitulo.Visible = ponto.Telefone != "";
            lblTelefone.Visible = ponto.Telefone != "";
            lblTelefone.Text = "Telefone: " + ponto.Telefone;

            lnkInstagram.Visible = ponto.Instagram != "";
            lnkSite.Visible = ponto.Site != "";
            MostrarLink(lnkInstagram, "Instagram: ", ponto.Instagram);
            MostrarLink(lnkSite, "Site: ", ponto.Site);

            // se o lugar não tem nem Instagram nem site, o card inteiro some
            cardLinks.Visible = ponto.Instagram != "" || ponto.Site != "";
        }

        // O LinkArea diz qual pedaço do texto é clicável (só o link, sem o "Site: ")
        private void MostrarLink(LinkLabel link, string titulo, string valor)
        {
            link.Text = titulo + TextoOuTraco(valor);

            if (valor == "")
                link.LinkArea = new LinkArea(0, 0);
            else
                link.LinkArea = new LinkArea(titulo.Length, valor.Length);
        }

        // Etiqueta de preço no cabeçalho: "A partir de R$ 15" ou "Gratuito"
        private void MostrarPrecoResumo()
        {
            if (ponto == null)
                return;

            if (ponto.IngressoAPartirDe != "")
            {
                lblPrecoResumo.Text = "$  A partir de " + ponto.IngressoAPartirDe;
                lblPrecoResumo.Visible = true;
            }
            else if (ponto.Preco.StartsWith("Gratuito") || ponto.Preco.StartsWith("Entrada gratuita"))
            {
                lblPrecoResumo.Text = "$  Gratuito";
                lblPrecoResumo.Visible = true;
            }
            else
            {
                lblPrecoResumo.Visible = false;
            }
        }

        // etiqueta verde (aberto) ou vermelha (fechado). Se não tiver horário ela some.
        private void MostrarSituacao()
        {
            if (ponto == null)
                return;

            string situacao = VerificadorHorario.Situacao(ponto, DateTime.Now);

            if (situacao == VerificadorHorario.NaoInformado)
            {
                lblSituacao.Visible = false;
                return;
            }

            lblSituacao.Visible = true;
            lblSituacao.Text = "●  " + situacao;

            if (situacao == VerificadorHorario.Aberto)
            {
                lblSituacao.BackColor = Color.FromArgb(214, 240, 224);
                lblSituacao.ForeColor = Color.FromArgb(30, 120, 70);
            }
            else
            {
                lblSituacao.BackColor = Color.FromArgb(250, 224, 226);
                lblSituacao.ForeColor = Color.FromArgb(180, 50, 60);
            }
        }

        // O mesmo botão vira "Ver cardápio" nos restaurantes e "Loja online" nas lojas
        private void ConfigurarBotaoCardapioLoja()
        {
            if (ponto == null)
                return;

            if (ponto.Categoria == "Gastronomia" && ponto.LinkCardapio != "")
            {
                btnCardapioLoja.Visible = true;
                btnCardapioLoja.Text = "Ver cardápio";
                btnCardapioLoja.Image = Properties.Resources.icone_cardapio_branco;
                btnCardapioLoja.BackColor = Color.FromArgb(214, 110, 40);
                btnCardapioLoja.FlatAppearance.MouseOverBackColor = Color.FromArgb(186, 92, 30);
            }
            else if (ponto.Categoria == "Compras" && ponto.LinkLoja != "")
            {
                btnCardapioLoja.Visible = true;
                btnCardapioLoja.Text = "Loja online";
                btnCardapioLoja.Image = Properties.Resources.icone_loja_branco;
                btnCardapioLoja.BackColor = Color.FromArgb(108, 70, 190);
                btnCardapioLoja.FlatAppearance.MouseOverBackColor = Color.FromArgb(88, 54, 160);
            }
            else
            {
                btnCardapioLoja.Visible = false;
            }
        }

        private void btnCardapioLoja_Click(object? sender, EventArgs e)
        {
            if (ponto == null)
                return;

            if (ponto.Categoria == "Gastronomia")
                AbrirLink(ponto.LinkCardapio);
            else
                AbrirLink(ponto.LinkLoja);
        }

        // ---------- Página que rola ----------

        // Quando a página muda de largura, os cards e os textos acompanham
        private void flpPagina_Resize(object? sender, EventArgs e)
        {
            int largura = flpPagina.ClientSize.Width - flpPagina.Padding.Horizontal - 20;
            if (largura < 520)
                largura = 520;

            // os cards têm largura fixa (mínimo = máximo)
            foreach (Control card in cards)
            {
                card.MinimumSize = new Size(largura, 0);
                card.MaximumSize = new Size(largura, 0);

                // os textos de dentro do card quebram a linha antes da borda
                foreach (Control dentro in card.Controls)
                {
                    dentro.MaximumSize = new Size(largura - 52, 0);
                }
            }

            // cabeçalho: informações de um lado, caixa de avaliação (330 px) do outro
            tlpCabecalho.MinimumSize = new Size(largura, 0);
            tlpCabecalho.MaximumSize = new Size(largura, 0);
            flpAcoes.MaximumSize = new Size(largura - 340, 0);
            lblEndereco.MaximumSize = new Size(largura - 370, 0);

            lblNome.MaximumSize = new Size(largura, 0);
            lblFontes.MaximumSize = new Size(largura, 0);

            foreach (Control item in flpSemelhantes.Controls)
            {
                item.Width = largura - 52;
            }
        }

        // ---------- Fotos ----------

        private void MontarGaleria()
        {
            if (ponto == null)
                return;

            fotos.Clear();
            fotos.Add(GerenciadorFotos.FotoDoPonto(ponto));

            foreach (string caminho in ponto.Fotos)
            {
                Image? extra = GerenciadorFotos.CarregarFoto(caminho);
                if (extra != null)
                    fotos.Add(extra);
            }

            btnFotoAnterior.Visible = fotos.Count > 1;
            btnFotoProxima.Visible = fotos.Count > 1;

            MostrarFoto(0);
        }

        // A foto é desenhada no tamanho exato do espaço, com qualidade alta.
        // Assim ela fica nítida (o PictureBox sozinho aumenta a foto de um jeito mais borrado).
        private void MostrarFoto(int numero)
        {
            fotoAtual = numero;

            Image? fotoAntiga = picFoto.Image;
            picFoto.Image = GerenciadorFotos.AjustarParaCaber(fotos[numero], picFoto.Width, picFoto.Height);

            // a foto ajustada é criada na hora, então a antiga pode ser apagada da memória
            if (fotoAntiga != null)
                fotoAntiga.Dispose();

            lblContadorFotos.Text = "Foto " + (numero + 1) + " de " + fotos.Count;
        }

        // se o espaço da foto mudar de tamanho, desenha a foto de novo no tamanho certo
        private void picFoto_SizeChanged(object? sender, EventArgs e)
        {
            if (fotos.Count > 0 && picFoto.Width > 0 && picFoto.Height > 0)
                MostrarFoto(fotoAtual);
        }

        private void btnFotoAnterior_Click(object? sender, EventArgs e)
        {
            int anterior = fotoAtual - 1;
            if (anterior < 0)
                anterior = fotos.Count - 1;   // se está na primeira, vai pra última

            MostrarFoto(anterior);
        }

        private void btnFotoProxima_Click(object? sender, EventArgs e)
        {
            int proxima = fotoAtual + 1;
            if (proxima >= fotos.Count)
                proxima = 0;   // se está na última, volta pra primeira

            MostrarFoto(proxima);
        }

        // ---------- Mapa ----------

        // O mini mapa usa o WebView2, que é um navegador (Edge) dentro do form.
        // A página do mapa é montada pela classe MapaHtml, na pasta HtmlMapas.
        // O "async/await" é porque o navegador demora um pouco pra ficar pronto
        // e a gente espera ele sem travar a tela.
        private async void CarregarMapa()
        {
            if (ponto == null || idDoMapa == ponto.Id)
                return;

            idDoMapa = ponto.Id;
            lblMapaErro.Text = "Carregando o mapa...";
            lblMapaErro.Visible = true;

            try
            {
                await webMapa.EnsureCoreWebView2Async();

                if (!eventoDoMapaLigado)
                {
                    // link clicado dentro do mapa abre no navegador normal do computador
                    webMapa.CoreWebView2.NewWindowRequested += Mapa_NewWindowRequested;
                    eventoDoMapaLigado = true;
                }

                webMapa.NavigateToString(MapaHtml.MontarPagina(ponto));
                lblMapaErro.Visible = false;
            }
            catch (Exception)
            {
                // cai aqui se o PC não tiver o WebView2 instalado
                lblMapaErro.Text = "Não foi possível carregar o mapa.\nUse o botão \"Como chegar\" para abrir no Google Maps.";
                lblMapaErro.Visible = true;
            }
        }

        private void Mapa_NewWindowRequested(object? sender, CoreWebView2NewWindowRequestedEventArgs e)
        {
            e.Handled = true;
            AbrirLink(e.Uri);
        }

        private void btnRota_Click(object? sender, EventArgs e)
        {
            if (ponto != null)
                AbrirLink(MapaHtml.LinkDaRota(ponto));
        }

        // ---------- Avaliação ----------

        // As 5 estrelas usam os mesmos eventos. O número de cada estrela está no Tag dela (Designer).
        private void Estrela_Click(object? sender, EventArgs e)
        {
            int numero = NumeroDaEstrela(sender);
            if (numero == 0 || ponto == null || avaliacoes == null)
                return;

            avaliacoes.Avaliar(ponto.Id, numero);
            AtualizarAvaliacao();
        }

        // quando passa o mouse, mostra como vai ficar antes de clicar
        private void Estrela_MouseEnter(object? sender, EventArgs e)
        {
            int numero = NumeroDaEstrela(sender);
            if (numero == 0)
                return;

            PintarEstrelas(numero);
            lblNotaDescricao.Text = numero + " de 5  ·  " + GerenciadorAvaliacoes.NomeDaNota(numero);
        }

        private void Estrela_MouseLeave(object? sender, EventArgs e)
        {
            AtualizarAvaliacao();
        }

        private void lnkRemoverNota_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            if (ponto == null || avaliacoes == null)
                return;

            // O link "Remover minha nota" vai sumir. Se ele some com o foco do teclado,
            // o Windows passa o foco pro próximo controle (que fica lá embaixo na página)
            // e a página rola sozinha até ele. Por isso o foco vai antes pra primeira estrela.
            btnEstrela1.Focus();

            avaliacoes.Remover(ponto.Id);
            AtualizarAvaliacao();
        }

        private int NumeroDaEstrela(object? sender)
        {
            Button? estrela = sender as Button;
            if (estrela == null)
                return 0;

            string? texto = estrela.Tag as string;
            if (texto == null)
                return 0;

            return int.Parse(texto);
        }

        private void PintarEstrelas(int quantidade)
        {
            Button[] estrelas = { btnEstrela1, btnEstrela2, btnEstrela3, btnEstrela4, btnEstrela5 };
            for (int i = 0; i < estrelas.Length; i++)
            {
                if (i < quantidade)
                    estrelas[i].Text = "★";
                else
                    estrelas[i].Text = "☆";
            }
        }

        private void AtualizarAvaliacao()
        {
            if (ponto == null || avaliacoes == null)
                return;

            int nota = avaliacoes.NotaDoPonto(ponto.Id);
            PintarEstrelas(nota);

            if (nota == 0)
            {
                lblNotaDescricao.Text = "Clique nas estrelas para dar sua nota";
                lnkRemoverNota.Visible = false;
                lblNotaResumo.Visible = false;
            }
            else
            {
                lblNotaDescricao.Text = "Sua nota: " + nota + " de 5  ·  " + GerenciadorAvaliacoes.NomeDaNota(nota);
                lnkRemoverNota.Visible = true;
                lblNotaResumo.Text = "★  Sua nota: " + nota + "/5";
                lblNotaResumo.Visible = true;
            }
        }

        // ---------- Lugares parecidos ----------

        // Mostra até 4 lugares: primeiro os do "LugaresPerto" do JSON,
        // depois completa com lugares da mesma categoria
        private void MostrarSemelhantes()
        {
            if (ponto == null || pontos == null)
                return;

            List<PontoTuristico> escolhidos = new List<PontoTuristico>();

            foreach (int id in ponto.LugaresPerto)
            {
                PontoTuristico? lugar = pontos.BuscarPorId(id);
                if (lugar != null && escolhidos.Count < 4)
                    escolhidos.Add(lugar);
            }

            foreach (PontoTuristico lugar in pontos.ListarTodos())
            {
                if (escolhidos.Count >= 4)
                    break;

                if (lugar.Id != ponto.Id && lugar.Categoria == ponto.Categoria && !escolhidos.Contains(lugar))
                    escolhidos.Add(lugar);
            }

            while (flpSemelhantes.Controls.Count > 0)
            {
                flpSemelhantes.Controls[0].Dispose();
            }

            int largura = cardParecidos.Width - 52;
            foreach (PontoTuristico lugar in escolhidos)
            {
                flpSemelhantes.Controls.Add(CriarItemSemelhante(lugar, largura));
            }
        }

        private Panel CriarItemSemelhante(PontoTuristico lugar, int largura)
        {
            Panel item = new Panel();
            item.Size = new Size(largura, 100);
            item.Margin = new Padding(0, 0, 0, 10);
            item.BackColor = Color.FromArgb(222, 236, 242);
            item.Cursor = Cursors.Hand;
            item.Tag = lugar;

            PictureBox foto = new PictureBox();
            foto.Image = GerenciadorFotos.MiniaturaDoPonto(lugar, 150, 100);
            foto.SizeMode = PictureBoxSizeMode.StretchImage;
            foto.Location = new Point(0, 0);
            foto.Size = new Size(150, 100);
            foto.Tag = lugar;

            Label nome = new Label();
            nome.Text = lugar.Nome;
            nome.AutoEllipsis = true;
            nome.Font = new Font("Segoe UI Semibold", 14F);
            nome.ForeColor = Color.FromArgb(13, 43, 94);
            nome.Location = new Point(168, 18);
            nome.Size = new Size(largura - 180, 32);
            nome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nome.Tag = lugar;

            Label info = new Label();
            info.Text = lugar.Categoria + "  ·  ver detalhes ›";
            info.Font = new Font("Segoe UI", 11.5F);
            info.ForeColor = Color.FromArgb(88, 98, 112);
            info.Location = new Point(168, 56);
            info.Size = new Size(largura - 180, 26);
            info.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            info.Tag = lugar;

            // clicando em qualquer parte do item abre o lugar
            item.Click += Semelhante_Click;
            foto.Click += Semelhante_Click;
            nome.Click += Semelhante_Click;
            info.Click += Semelhante_Click;

            item.Controls.Add(foto);
            item.Controls.Add(nome);
            item.Controls.Add(info);
            return item;
        }

        private void Semelhante_Click(object? sender, EventArgs e)
        {
            Control? clicado = sender as Control;
            if (clicado == null)
                return;

            PontoTuristico? lugar = clicado.Tag as PontoTuristico;
            if (lugar != null)
                MostrarPonto(lugar);
        }

        // ---------- Botões ----------

        private void btnVoltar_Click(object? sender, EventArgs e)
        {
            Close();
        }

        private void lnkSite_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            if (ponto == null || ponto.Site == "")
                return;

            string link = ponto.Site;
            if (!link.StartsWith("http"))
                link = "https://" + link;

            AbrirLink(link);
        }

        // no JSON pode estar "@perfil" ou o link inteiro
        private void lnkInstagram_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            if (ponto == null || ponto.Instagram == "")
                return;

            string perfil = ponto.Instagram;
            if (!perfil.StartsWith("http"))
                perfil = "https://www.instagram.com/" + perfil.TrimStart('@') + "/";

            AbrirLink(perfil);
        }

        private void btnCompartilhar_Click(object? sender, EventArgs e)
        {
            if (ponto == null)
                return;

            using (FormCompartilhar telaCompartilhar = new FormCompartilhar(ponto))
            {
                telaCompartilhar.ShowDialog(this);
            }
        }

        private void btnFavoritar_Click(object? sender, EventArgs e)
        {
            if (ponto == null || favoritos == null)
                return;

            favoritos.Alternar(ponto.Id);
            AtualizarBotaoFavoritar();
        }

        private void AtualizarBotaoFavoritar()
        {
            if (ponto == null || favoritos == null)
                return;

            if (favoritos.EhFavorito(ponto.Id))
            {
                btnFavoritar.Text = "♥  Favoritado";
                btnFavoritar.BackColor = corCoracao;
                btnFavoritar.ForeColor = Color.White;
                btnFavoritar.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 55, 64);
            }
            else
            {
                btnFavoritar.Text = "♡  Favoritar";
                btnFavoritar.BackColor = Color.FromArgb(242, 248, 250);
                btnFavoritar.ForeColor = corCoracao;
                btnFavoritar.FlatAppearance.MouseOverBackColor = Color.FromArgb(253, 236, 237);
            }
        }

        private void AbrirLink(string link)
        {
            if (link == "")
                return;

            try
            {
                Process.Start(new ProcessStartInfo(link) { UseShellExecute = true });
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível abrir o link.", "Bauru's Tour",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ---------- Tela cheia ----------

        private void AlternarTelaCheia()
        {
            if (FormBorderStyle == FormBorderStyle.None)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                // volta pra Normal antes, senão a barra de tarefas continua aparecendo
                WindowState = FormWindowState.Normal;
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
            }
        }

        private void FormDetalhe_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11)
                AlternarTelaCheia();

            // Esc sai da tela cheia ou volta pra busca
            if (e.KeyCode == Keys.Escape)
            {
                if (FormBorderStyle == FormBorderStyle.None)
                    AlternarTelaCheia();
                else
                    Close();
            }
        }
    }
}
