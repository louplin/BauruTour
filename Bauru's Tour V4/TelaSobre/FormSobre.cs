namespace BaurusTour.TelaSobre
{
    /// <summary>
    /// Tela "Sobre": abre quando clica em "Sobre" no menu lateral da tela de busca.
    ///
    /// Ela não precisa de código: o visual está todo no Designer (FormSobre.Designer.cs)
    /// e o botão Fechar já fecha a janela sozinho, porque a propriedade
    /// DialogResult dele está como "Cancel". A tecla Esc também fecha
    /// (propriedade CancelButton do formulário).
    /// </summary>
    public partial class FormSobre : Form
    {
        public FormSobre()
        {
            InitializeComponent();
        }
    }
}
