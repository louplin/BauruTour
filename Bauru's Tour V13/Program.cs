using BaurusTour.TelaInicial;

namespace BaurusTour
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FormInicial());
        }
    }
}
