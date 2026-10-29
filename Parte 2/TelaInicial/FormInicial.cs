using System.Diagnostics;
using BaurusTour.TelaBusca;

namespace BaurusTour.TelaInicial
{
    /// <summary>
    /// Tela de boas-vindas. O visual (fundo com o planeta, textos e botões)
    /// está todo no Designer (FormInicial.Designer.cs).
    ///
    /// O app começa por aqui: o método Main fica nesta classe,
    /// por isso o projeto não precisa de Program.cs.
    /// </summary>
    public partial class FormInicial : Form
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormInicial());
        }

        public FormInicial()
        {
            InitializeComponent();
        }

        // Abre a tela de busca e esconde esta
        private void btnComecar_Click(object? sender, EventArgs e)
        {
            var telaBusca = new FormBusca();

            // Quando a tela de busca fechar, o app inteiro fecha
            telaBusca.FormClosed += (s, args) => Close();

            telaBusca.Show();
            Hide();
        }

        // Abre o PDF com o passo a passo de como usar o app
        private void btnGuia_Click(object? sender, EventArgs e)
        {
            string pdf = Path.Combine(AppContext.BaseDirectory, "Manual", "Guia-de-uso-Bauru-Tour.pdf");
            Process.Start(new ProcessStartInfo(pdf) { UseShellExecute = true });
        }

        // ================================================================
        // Tela cheia (botão ou F11) e tecla Esc
        // ================================================================
        private void btnTelaCheia_Click(object? sender, EventArgs e)
        {
            AlternarTelaCheia();
        }

        private void AlternarTelaCheia()
        {
            if (FormBorderStyle == FormBorderStyle.None)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Maximized;
                btnTelaCheia.Text = "Tela cheia";
            }
            else
            {
                WindowState = FormWindowState.Normal;
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
                btnTelaCheia.Text = "Sair da tela cheia";
            }
        }

        private void FormInicial_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11)
                AlternarTelaCheia();

            // Esc: sai da tela cheia; se já estiver em janela, fecha o app
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
