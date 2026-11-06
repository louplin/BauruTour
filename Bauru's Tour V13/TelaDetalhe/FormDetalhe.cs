using System.Diagnostics;
using BaurusTour.Classes;
using BaurusTour.HtmlMapas;
using BaurusTour.Models;
using BaurusTour.TelaCompartilhar;
using Microsoft.Web.WebView2.Core;

namespace BaurusTour.TelaDetalhe
{
    // Tela de detalhes de um ponto turístico.
    //
    // O visual está todo no Designer (FormDetalhe.Designer.cs). A página é assim:
    //   - topo: botão Voltar e a marca do app
    //   - cabeçalho: caminho (Início > Categoria), nome, etiquetas e endereço
    //   - botões: Google Maps, Cardápio/Loja online, Compartilhar e Favoritar
    //   - galeria de fotos
    //   - coluna da esquerda: Sobre, O que fazer, Dicas e Quanto custa
    //   - coluna da direita: mini mapa, horário e contato, avaliação, lugares parecidos e compartilhar
    //
    // Aqui no código ficam só: preencher os textos com os dados do ponto e o que cada botão faz.
    public partial class FormDetalhe : Form
    {
        private PontoTuristico? ponto;
        private GerenciadorFavoritos? favoritos;
        private GerenciadorPontos? pontos;
        private GerenciadorAvaliacoes? avaliacoes;

        // Fotos da galeria e qual está aparecendo
        private List<Image> fotos = new List<Image>();
        private int fotoAtual = 0;

        // O evento do mapa só pode ser ligado uma vez
        private bool mapaConfigurado = false;

        // Cores usadas pelo código
        private Color corPrimaria = Color.FromArgb(11, 107, 138);
        private Color corCoracao = Color.FromArgb(226, 72, 80);

        // O Designer do Visual Studio precisa de um construtor sem parâmetros
        public FormDetalhe()
        {
            InitializeComponent();
        }

        // Construtor usado pela tela de busca
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

        // =====================================================================
        // Preencher a tela
        // Também é chamado quando clica em um dos "Lugares parecidos".
        // =====================================================================
        private void MostrarPonto(PontoTuristico novoPonto)
        {
            ponto = novoPonto;

            // Cabeçalho
            Text = ponto.Nome + " - Bauru's Tour";
            lblMigalha.Text = "Início  ›  " + ponto.Categoria + "  ›  " + ponto.Nome;
            lblNome.Text = ponto.Nome;
            lblCategoria.Text = ponto.Categoria;
            lblEndereco.Text = ponto.Endereco;
            MostrarSituacao();

            // Coluna da esquerda
            lblDescricao.Text = ponto.Descricao;

            lblOQueFazer.Text = MontarLista(ponto.OQueFazer, "✓");
            flpCardOQueFazer.Visible = ponto.OQueFazer.Count > 0;

            lblDicas.Text = MontarLista(ponto.Dicas, "•");
            flpCardDicas.Visible = ponto.Dicas.Count > 0;

            lblPreco.Text = TextoOuPadrao(ponto.Preco, "Preço não informado. Vale confirmar antes de ir.");
            lblIngresso.Text = "A partir de " + ponto.IngressoAPartirDe;
            lblIngresso.Visible = ponto.IngressoAPartirDe != "";

            // Coluna da direita
            lblMapaEndereco.Text = ponto.Endereco;
            lblHorario.Text = VerificadorHorario.TextoHorario(ponto);
            lblTelefone.Text = TextoOuPadrao(ponto.Telefone, "não informado");
            lnkSite.Text = TextoOuPadrao(ponto.Site, "não informado");
            lnkSite.Enabled = ponto.Site != "";

            // Instagram: a linha só aparece se o lugar tiver perfil
            lnkInstagram.Text = ponto.Instagram;
            lblInstagramTitulo.Visible = ponto.Instagram != "";
            lnkInstagram.Visible = ponto.Instagram != "";

            // Sem link do Maps, não tem como abrir o mapa nem compartilhar
            bool temLink = ponto.LinkMaps != "";
            btnMapa.Enabled = temLink;
            btnAbrirMapa.Enabled = temLink;
            btnCompartilhar.Enabled = temLink;
            btnWhatsApp.Enabled = temLink;
            btnFacebook.Enabled = temLink;
            btnCopiar.Enabled = temLink;
            btnCopiar.Text = "Copiar";

            ConfigurarBotaoCardapioLoja();
            AtualizarBotaoFavoritar();
            AtualizarAvaliacao();
            MontarGaleria();
            MostrarSemelhantes();
            CarregarMapa();

            // Volta para o topo da página
            pnlPagina.AutoScrollPosition = new Point(0, 0);
        }

        private string TextoOuPadrao(string texto, string padrao)
        {
            if (texto == "")
                return padrao;

            return texto;
        }

        // Transforma a lista em texto, um item por linha, com uma linha em branco entre eles
        private string MontarLista(List<string> itens, string marcador)
        {
            string texto = "";
            foreach (string item in itens)
            {
                texto = texto + marcador + "   " + item + "\n\n";
            }
            return texto.TrimEnd();
        }

        // Etiqueta verde "Aberto agora" ou vermelha "Fechado agora" (some se não tiver horário)
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

        // =====================================================================
        // Botão de Cardápio (restaurantes) ou Loja online (compras)
        // =====================================================================
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

        // =====================================================================
        // Mini mapa (WebView2 = navegador do Edge dentro do formulário)
        // A página HTML do mapa é montada pela classe MapaHtml (pasta HtmlMapas).
        // =====================================================================
        private async void CarregarMapa()
        {
            if (ponto == null)
                return;

            lblMapaErro.Visible = false;

            try
            {
                // Prepara o navegador (na primeira vez demora um pouquinho)
                await webMapa.EnsureCoreWebView2Async();

                if (!mapaConfigurado)
                {
                    // Links clicados dentro do mapa abrem no navegador do computador
                    webMapa.CoreWebView2.NewWindowRequested += Mapa_NewWindowRequested;
                    mapaConfigurado = true;
                }

                webMapa.NavigateToString(MapaHtml.MontarPagina(ponto));
            }
            catch (Exception)
            {
                // Acontece se o computador não tiver o WebView2 Runtime ou estiver sem internet
                lblMapaErro.Visible = true;
                lblMapaErro.BringToFront();
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

        // =====================================================================
        // Galeria de fotos
        // =====================================================================
        private void MontarGaleria()
        {
            if (ponto == null)
                return;

            // Foto principal + fotos extras do pontos.json
            fotos.Clear();
            fotos.Add(GerenciadorFotos.FotoDoPonto(ponto));

            foreach (string caminho in ponto.Fotos)
            {
                Image? extra = GerenciadorFotos.CarregarFoto(caminho);
                if (extra != null)
                    fotos.Add(extra);
            }

            bool variasFotos = fotos.Count > 1;
            btnFotoAnterior.Visible = variasFotos;
            btnFotoProxima.Visible = variasFotos;
            lblContadorFotos.Visible = variasFotos;

            // Miniaturas embaixo da foto grande (uma para cada foto)
            while (flpMiniaturas.Controls.Count > 0)
            {
                flpMiniaturas.Controls[0].Dispose();
            }

            if (variasFotos)
            {
                for (int i = 0; i < fotos.Count; i++)
                {
                    PictureBox miniatura = new PictureBox();
                    miniatura.Image = fotos[i];
                    miniatura.SizeMode = PictureBoxSizeMode.Zoom;
                    miniatura.Size = new Size(128, 80);
                    miniatura.Padding = new Padding(3);
                    miniatura.Margin = new Padding(0, 0, 10, 0);
                    miniatura.BackColor = Color.FromArgb(20, 32, 48);
                    miniatura.Cursor = Cursors.Hand;
                    miniatura.Tag = i;
                    miniatura.Click += Miniatura_Click;
                    flpMiniaturas.Controls.Add(miniatura);
                }
            }

            flpMiniaturas.Visible = variasFotos;
            MostrarFoto(0);
        }

        private void MostrarFoto(int indice)
        {
            if (fotos.Count == 0)
                return;

            fotoAtual = indice;
            picFoto.Image = fotos[indice];
            lblContadorFotos.Text = (indice + 1) + " / " + fotos.Count;

            // A miniatura da foto que está aparecendo ganha uma borda azul
            foreach (Control controle in flpMiniaturas.Controls)
            {
                if (controle.Tag is int numero && numero == indice)
                    controle.BackColor = corPrimaria;
                else
                    controle.BackColor = Color.FromArgb(20, 32, 48);
            }
        }

        private void btnFotoAnterior_Click(object? sender, EventArgs e)
        {
            if (fotos.Count == 0)
                return;

            // Se estiver na primeira, vai para a última
            int anterior = fotoAtual - 1;
            if (anterior < 0)
                anterior = fotos.Count - 1;

            MostrarFoto(anterior);
        }

        private void btnFotoProxima_Click(object? sender, EventArgs e)
        {
            if (fotos.Count == 0)
                return;

            // Se estiver na última, volta para a primeira
            MostrarFoto((fotoAtual + 1) % fotos.Count);
        }

        private void Miniatura_Click(object? sender, EventArgs e)
        {
            PictureBox? miniatura = sender as PictureBox;
            if (miniatura != null && miniatura.Tag is int numero)
                MostrarFoto(numero);
        }

        // =====================================================================
        // Avaliação com estrelas
        // As 5 estrelas usam os mesmos eventos. O número de cada uma está no Tag (Designer).
        // =====================================================================
        private void Estrela_Click(object? sender, EventArgs e)
        {
            int numero = NumeroDaEstrela(sender);
            if (numero == 0 || ponto == null || avaliacoes == null)
                return;

            avaliacoes.Avaliar(ponto.Id, numero);
            AtualizarAvaliacao();
            MostrarSemelhantes();
        }

        // Passou o mouse: mostra como vai ficar antes de clicar
        private void Estrela_MouseEnter(object? sender, EventArgs e)
        {
            int numero = NumeroDaEstrela(sender);
            if (numero == 0)
                return;

            PintarEstrelas(numero);
            lblNotaDescricao.Text = numero + " de 5  ·  " + GerenciadorAvaliacoes.NomeDaNota(numero);
        }

        // Tirou o mouse: volta a mostrar a nota que está salva
        private void Estrela_MouseLeave(object? sender, EventArgs e)
        {
            AtualizarAvaliacao();
        }

        private void lnkRemoverNota_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            if (ponto == null || avaliacoes == null)
                return;

            avaliacoes.Remover(ponto.Id);
            AtualizarAvaliacao();
            MostrarSemelhantes();
        }

        private int NumeroDaEstrela(object? sender)
        {
            Button? estrela = sender as Button;
            if (estrela == null)
                return 0;

            int numero;
            if (int.TryParse(estrela.Tag as string, out numero))
                return numero;

            return 0;
        }

        // ★ cheia até a quantidade, ☆ vazia depois
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

        // =====================================================================
        // Lugares parecidos
        // Mostra até 3: primeiro os que estão em "LugaresPerto" no JSON,
        // depois completa com lugares da mesma categoria.
        // =====================================================================
        private void MostrarSemelhantes()
        {
            if (ponto == null || pontos == null)
                return;

            List<PontoTuristico> escolhidos = new List<PontoTuristico>();

            foreach (int id in ponto.LugaresPerto)
            {
                PontoTuristico? lugar = pontos.BuscarPorId(id);
                if (lugar != null && escolhidos.Count < 3)
                    escolhidos.Add(lugar);
            }

            foreach (PontoTuristico lugar in pontos.ListarTodos())
            {
                if (escolhidos.Count >= 3)
                    break;

                if (lugar.Id != ponto.Id && lugar.Categoria == ponto.Categoria && !escolhidos.Contains(lugar))
                    escolhidos.Add(lugar);
            }

            // Apaga os itens do ponto anterior
            while (flpSemelhantes.Controls.Count > 0)
            {
                flpSemelhantes.Controls[0].Dispose();
            }

            foreach (PontoTuristico lugar in escolhidos)
            {
                flpSemelhantes.Controls.Add(CriarItemSemelhante(lugar));
            }

            flpCardSemelhantes.Visible = escolhidos.Count > 0;
        }

        // Uma linha com foto pequena, nome e categoria. Clicar em qualquer parte abre o lugar.
        private Panel CriarItemSemelhante(PontoTuristico lugar)
        {
            Panel item = new Panel();
            item.Size = new Size(404, 76);
            item.Margin = new Padding(0, 0, 0, 10);
            item.BackColor = Color.FromArgb(242, 248, 250);
            item.Cursor = Cursors.Hand;
            item.Tag = lugar;

            PictureBox foto = new PictureBox();
            foto.Image = GerenciadorFotos.FotoDoPonto(lugar);
            foto.SizeMode = PictureBoxSizeMode.StretchImage;
            foto.Location = new Point(0, 0);
            foto.Size = new Size(112, 76);
            foto.Tag = lugar;

            Label nome = new Label();
            nome.Text = lugar.Nome;
            nome.AutoEllipsis = true;
            nome.Font = new Font("Segoe UI Semibold", 11F);
            nome.ForeColor = Color.FromArgb(13, 43, 94);
            nome.Location = new Point(124, 12);
            nome.Size = new Size(272, 26);
            nome.Tag = lugar;

            Label info = new Label();
            info.Text = lugar.Categoria + "  ·  " + TextoNota(lugar);
            info.Font = new Font("Segoe UI", 10F);
            info.ForeColor = Color.FromArgb(88, 98, 112);
            info.Location = new Point(124, 42);
            info.Size = new Size(272, 22);
            info.Tag = lugar;

            item.Click += Semelhante_Click;
            foto.Click += Semelhante_Click;
            nome.Click += Semelhante_Click;
            info.Click += Semelhante_Click;

            item.Controls.Add(foto);
            item.Controls.Add(nome);
            item.Controls.Add(info);
            return item;
        }

        private string TextoNota(PontoTuristico lugar)
        {
            if (avaliacoes == null || avaliacoes.NotaDoPonto(lugar.Id) == 0)
                return "sem nota";

            return "★ " + avaliacoes.NotaDoPonto(lugar.Id) + "/5";
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

        // =====================================================================
        // Botões do topo da página e de compartilhar
        // =====================================================================
        private void btnVoltar_Click(object? sender, EventArgs e)
        {
            Close();
        }

        private void btnMapa_Click(object? sender, EventArgs e)
        {
            if (ponto != null && ponto.LinkMaps != "")
                AbrirLink(ponto.LinkMaps);
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

        // Abre o perfil no Instagram. Aceita "@perfil" ou o link completo no JSON.
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

        private void btnWhatsApp_Click(object? sender, EventArgs e)
        {
            if (ponto != null)
                AbrirLink(Compartilhamento.LinkWhatsApp(ponto));
        }

        private void btnFacebook_Click(object? sender, EventArgs e)
        {
            if (ponto != null)
                AbrirLink(Compartilhamento.LinkFacebook(ponto));
        }

        private void btnCopiar_Click(object? sender, EventArgs e)
        {
            if (ponto == null)
                return;

            Clipboard.SetText(Compartilhamento.Mensagem(ponto));
            btnCopiar.Text = "Copiado!";
        }

        private void btnFavoritar_Click(object? sender, EventArgs e)
        {
            if (ponto == null || favoritos == null)
                return;

            favoritos.Alternar(ponto.Id);
            AtualizarBotaoFavoritar();
        }

        // Favorito: botão vermelho cheio. Não favorito: botão branco com borda vermelha.
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
                btnFavoritar.BackColor = Color.White;
                btnFavoritar.ForeColor = corCoracao;
                btnFavoritar.FlatAppearance.MouseOverBackColor = Color.FromArgb(253, 236, 237);
            }
        }

        // Abre um link no navegador padrão do computador
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

        // =====================================================================
        // Tela cheia (F11) e tecla Esc
        // =====================================================================
        private void AlternarTelaCheia()
        {
            if (FormBorderStyle == FormBorderStyle.None)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                // Volta pra Normal antes, senão a barra de tarefas continua aparecendo
                WindowState = FormWindowState.Normal;
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
            }
        }

        private void FormDetalhe_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11)
                AlternarTelaCheia();

            // Esc sai da tela cheia, ou volta para a busca se não estiver em tela cheia
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
