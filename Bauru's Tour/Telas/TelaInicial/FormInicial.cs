using BaurusTour.Classes;
using BaurusTour.Telas.TelaBusca;

namespace BaurusTour.Telas.TelaInicial
{
    public partial class FormInicial : Form
    {
        // a imagem do planeta no tamanho original
        private Image fundoOriginal = Properties.Resources.fundo_inicial;

        public FormInicial()
        {
            InitializeComponent();
            Resize += FormInicial_Resize;
            FormInicial_Resize(this, EventArgs.Empty);
        }

        // Toda vez que a janela muda de tamanho, gera o fundo do tamanho exato da tela.
        // Assim a imagem cobre tudo (sem as bordas pretas dos lados)
        // e o Windows não precisa ficar aumentando a imagem a cada redesenho.
        private void FormInicial_Resize(object? sender, EventArgs e)
        {
            // minimizado a tela fica com tamanho 0
            if (ClientSize.Width == 0 || ClientSize.Height == 0)
                return;

            // se o tamanho não mudou, não precisa gerar de novo
            if (BackgroundImage != null && BackgroundImage.Size == ClientSize)
                return;

            Image? fundoAntigo = BackgroundImage;

            BackgroundImageLayout = ImageLayout.None;
            BackgroundImage = GerenciadorFotos.PreencherEspaco(fundoOriginal, ClientSize.Width, ClientSize.Height);

            // libera a memória do fundo anterior
            if (fundoAntigo != null && fundoAntigo != fundoOriginal)
                fundoAntigo.Dispose();
        }

        private void btnComecar_Click(object? sender, EventArgs e)
        {
            FormBusca telaBusca = new FormBusca();
            telaBusca.FormClosed += TelaBusca_FormClosed;
            telaBusca.Show();
            Hide();
        }

        // quando fecha a busca, fecha essa também e o app termina
        private void TelaBusca_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Close();
        }

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

        private void FormInicial_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11)
                AlternarTelaCheia();

            // Esc sai da tela cheia ou fecha o app
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
