namespace BaurusTour.Utilitarios
{
    /// <summary>
    /// Liga e desliga o modo tela cheia (sem barra de título, cobrindo a barra de tarefas).
    /// Usado pelo botão "Tela cheia" e pela tecla F11 em todas as telas.
    /// </summary>
    public static class ControleTelaCheia
    {
        // Guarda como a janela estava antes de entrar em tela cheia
        private static readonly Dictionary<Form, FormWindowState> _estadoAnterior =
            new Dictionary<Form, FormWindowState>();

        public static bool EstaEmTelaCheia(Form tela)
        {
            return _estadoAnterior.ContainsKey(tela);
        }

        public static void Alternar(Form tela)
        {
            if (EstaEmTelaCheia(tela))
                Sair(tela);
            else
                Entrar(tela);
        }

        public static void Entrar(Form tela)
        {
            if (EstaEmTelaCheia(tela))
                return;

            _estadoAnterior[tela] = tela.WindowState == FormWindowState.Minimized
                ? FormWindowState.Maximized
                : tela.WindowState;

            tela.FormClosed -= Tela_FormClosed;
            tela.FormClosed += Tela_FormClosed;

            // A ordem importa: tirar a borda antes de maximizar faz a janela cobrir a barra de tarefas
            tela.WindowState = FormWindowState.Normal;
            tela.FormBorderStyle = FormBorderStyle.None;
            tela.WindowState = FormWindowState.Maximized;
        }

        public static void Sair(Form tela)
        {
            if (!_estadoAnterior.TryGetValue(tela, out FormWindowState anterior))
                return;

            _estadoAnterior.Remove(tela);

            tela.WindowState = FormWindowState.Normal;
            tela.FormBorderStyle = FormBorderStyle.Sizable;
            tela.WindowState = anterior;
        }

        private static void Tela_FormClosed(object? sender, FormClosedEventArgs e)
        {
            if (sender is Form tela)
            {
                _estadoAnterior.Remove(tela);
                tela.FormClosed -= Tela_FormClosed;
            }
        }
    }
}
