using System.Runtime.InteropServices;
using BaurusTour.Models;
using BaurusTour.Utilitarios;

namespace BaurusTour.TelaCompartilhar
{
    /// <summary>
    /// Janela de compartilhar: copia o link do Google Maps (ou uma mensagem pronta)
    /// para colar no WhatsApp, ou já abre o WhatsApp com a mensagem escrita.
    /// </summary>
    public partial class FormCompartilhar : Form
    {
        private readonly PontoTuristico? _ponto;

        // Usado só pelo Designer do Visual Studio
        public FormCompartilhar()
        {
            InitializeComponent();
        }

        public FormCompartilhar(PontoTuristico ponto) : this()
        {
            _ponto = ponto;
        }

        private void FormCompartilhar_Load(object? sender, EventArgs e)
        {
            Icon = CarregadorImagens.IconeDoApp ?? Icon;

            if (_ponto == null)
                return;

            lblNomeLugar.Text = _ponto.Nome;
            txtLink.Text = _ponto.LinkMaps;
            txtMensagem.Text = MontarMensagem(_ponto);
        }

        private static string MontarMensagem(PontoTuristico ponto)
        {
            return "Olha esse lugar em Bauru que eu achei no Bauru's Tour: " + ponto.Nome + "\r\n" +
                   "Endereço: " + ponto.Endereco + "\r\n" +
                   "Localização no Google Maps: " + ponto.LinkMaps;
        }

        private void btnCopiarLink_Click(object? sender, EventArgs e)
        {
            Copiar(txtLink.Text, "Link copiado! Agora é só colar no WhatsApp.");
        }

        private void btnCopiarMensagem_Click(object? sender, EventArgs e)
        {
            Copiar(txtMensagem.Text, "Mensagem copiada! Agora é só colar no WhatsApp.");
        }

        // Abre o WhatsApp (aplicativo ou WhatsApp Web) com a mensagem já escrita
        private void btnWhatsApp_Click(object? sender, EventArgs e)
        {
            string url = "https://wa.me/?text=" + Uri.EscapeDataString(txtMensagem.Text);
            AbridorLinks.AbrirLink(url, this);
        }

        private void Copiar(string texto, string mensagemOk)
        {
            if (string.IsNullOrWhiteSpace(texto))
                return;

            try
            {
                Clipboard.SetText(texto);
                lblConfirmacao.ForeColor = Tema.Sucesso;
                lblConfirmacao.Text = mensagemOk;
            }
            catch (ExternalException)
            {
                // Acontece quando outro programa está usando a área de transferência
                lblConfirmacao.ForeColor = Tema.Coracao;
                lblConfirmacao.Text = "Não deu pra copiar agora. Tente de novo.";
            }

            lblConfirmacao.Visible = true;
        }

        private void FormCompartilhar_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
                e.Handled = true;
            }
        }
    }
}
