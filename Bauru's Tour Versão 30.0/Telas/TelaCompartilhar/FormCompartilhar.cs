using System.Diagnostics;
using BaurusTour.Classes;
using BaurusTour.Modelos;

namespace BaurusTour.Telas.TelaCompartilhar
{
    public partial class FormCompartilhar : Form
    {
        private PontoTuristico? ponto;

        // o Designer precisa desse construtor vazio
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
            txtMensagem.Text = Compartilhamento.Mensagem(ponto);
        }

        private void btnCopiarLink_Click(object? sender, EventArgs e)
        {
            // o Clipboard dá erro com texto vazio
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

        private void btnWhatsApp_Click(object? sender, EventArgs e)
        {
            // usa o texto da caixa, porque a pessoa pode ter mudado a mensagem
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
