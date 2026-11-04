using System.Diagnostics;
using BaurusTour.Models;

namespace BaurusTour.TelaCompartilhar
{
    /// <summary>
    /// Janela de compartilhar: copia o link do Google Maps (ou uma mensagem pronta)
    /// para colar no WhatsApp, ou já abre o WhatsApp com a mensagem escrita.
    /// O visual está no Designer (FormCompartilhar.Designer.cs).
    /// </summary>
    public partial class FormCompartilhar : Form
    {
        private readonly PontoTuristico? ponto;

        // Usado só pelo Designer do Visual Studio
        public FormCompartilhar()
        {
            InitializeComponent();
        }

        public FormCompartilhar(PontoTuristico ponto) : this()
        {
            this.ponto = ponto;
        }

        // Ao abrir: preenche o link e monta a mensagem
        private void FormCompartilhar_Load(object? sender, EventArgs e)
        {
            if (ponto == null)
                return;

            lblNomeLugar.Text = ponto.Nome;
            txtLink.Text = ponto.LinkMaps;
            txtMensagem.Text = "Olha esse lugar em Bauru que eu achei no Bauru's Tour: " + ponto.Nome + "\r\n"
                             + "Endereço: " + ponto.Endereco + "\r\n"
                             + "Localização no Google Maps: " + ponto.LinkMaps;
        }

        private void btnCopiarLink_Click(object? sender, EventArgs e)
        {
            Clipboard.SetText(txtLink.Text);
            lblConfirmacao.Text = "Link copiado! Agora é só colar no WhatsApp (Ctrl + V).";
            lblConfirmacao.Visible = true;
        }

        private void btnCopiarMensagem_Click(object? sender, EventArgs e)
        {
            Clipboard.SetText(txtMensagem.Text);
            lblConfirmacao.Text = "Mensagem copiada! Agora é só colar no WhatsApp (Ctrl + V).";
            lblConfirmacao.Visible = true;
        }

        // Abre o WhatsApp (aplicativo ou WhatsApp Web) com a mensagem já escrita
        private void btnWhatsApp_Click(object? sender, EventArgs e)
        {
            string link = "https://wa.me/?text=" + Uri.EscapeDataString(txtMensagem.Text);
            Process.Start(new ProcessStartInfo(link) { UseShellExecute = true });
        }

        // Esc fecha a janela
        private void FormCompartilhar_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}
