using BaurusTour.TelaBusca;

namespace BaurusTour.TelaInicial
{
    // Tela de boas-vindas
    public partial class FormInicial : Form
    {
        public FormInicial()
        {
            InitializeComponent();
        }

        private void btnComecar_Click(object? sender, EventArgs e)
        {
            FormBusca telaBusca = new FormBusca();
            telaBusca.FormClosed += TelaBusca_FormClosed;
            telaBusca.Show();
            Hide();
        }

        // Quando a tela de busca fecha, fecha esta também (e o app termina)
        private void TelaBusca_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Close();
        }

        // F11 liga/desliga a tela cheia
        private void AlternarTelaCheia()
        {
            if (FormBorderStyle == FormBorderStyle.None)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                // Se a janela já estiver maximizada, o Windows não recalcula o tamanho
                // e a barra de tarefas continua aparecendo. Por isso volta pra Normal antes.
                WindowState = FormWindowState.Normal;
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
            }
        }

        private void FormInicial_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11)
                AlternarTelaCheia();

            // Esc sai da tela cheia, ou fecha o app se não estiver em tela cheia
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
