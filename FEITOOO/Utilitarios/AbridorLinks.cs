using System.ComponentModel;
using System.Diagnostics;

namespace BaurusTour.Utilitarios
{
    /// <summary>
    /// Abre links no navegador padrão e arquivos (como o PDF do guia) no programa padrão do Windows.
    /// </summary>
    public static class AbridorLinks
    {
        public static void AbrirLink(string url, IWin32Window? dono = null)
        {
            if (string.IsNullOrWhiteSpace(url))
            {
                MessageBox.Show(dono, "Esse lugar ainda não tem link cadastrado.", "Bauru's Tour",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Abrir(url, dono, "Não consegui abrir o navegador.");
        }

        public static void AbrirArquivo(string caminhoRelativo, IWin32Window? dono = null)
        {
            string caminho = Path.Combine(AppContext.BaseDirectory, caminhoRelativo);

            if (!File.Exists(caminho))
            {
                MessageBox.Show(dono, "Arquivo não encontrado:\n" + caminho, "Bauru's Tour",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Abrir(caminho, dono, "Não consegui abrir o arquivo. Verifique se existe um leitor de PDF instalado.");
        }

        private static void Abrir(string alvo, IWin32Window? dono, string mensagemErro)
        {
            try
            {
                Process.Start(new ProcessStartInfo(alvo) { UseShellExecute = true });
            }
            catch (Win32Exception)
            {
                MessageBox.Show(dono, mensagemErro, "Bauru's Tour", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show(dono, mensagemErro, "Bauru's Tour", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
