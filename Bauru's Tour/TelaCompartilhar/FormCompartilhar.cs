using System.Diagnostics;
using BaurusTour.Models;

namespace BaurusTour.TelaCompartilhar
{
    // Janela para copiar o link/mensagem ou abrir o WhatsApp com a mensagem pronta
    public partial class FormCompartilhar : Form
    {
        private PontoTuristico? ponto;

        // O Designer do Visual Studio precisa de um construtor sem parâmetros
        public FormCompartilhar()
        {
            InitializeComponent();
        }

        public FormCompartilhar(PontoTuristico ponto) : this()
        {
            this.ponto = ponto;
        }

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
            // Clipboard.SetText dá erro se o texto estiver vazio
            if (txtLink.Text == "")
                return;

            Clipboard.SetText(txtLink.Text);
            lblConfirmacao.Text = "Link copiado! Agora é só colar no WhatsApp (Ctrl + V).";
            lblConfirmacao.Visible = true;
        }

        private void btnCopiarMensagem_Click(object? sender, EventArgs e)
        {
            if (txtMensagem.Text == "")
                return;

            Clipboard.SetText(txtMensagem.Text);
            lblConfirmacao.Text = "Mensagem copiada! Agora é só colar no WhatsApp (Ctrl + V).";
            lblConfirmacao.Visible = true;
        }

        // Abre o WhatsApp (app ou WhatsApp Web) com a mensagem já escrita.
        // EscapeDataString troca espaços e acentos por códigos que funcionam num link.
        private void btnWhatsApp_Click(object? sender, EventArgs e)
        {
            string link = "https://wa.me/?text=" + Uri.EscapeDataString(txtMensagem.Text);

            try
            {
                Process.Start(new ProcessStartInfo(link) { UseShellExecute = true });
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível abrir o WhatsApp.", "Bauru's Tour",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FormCompartilhar_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}
