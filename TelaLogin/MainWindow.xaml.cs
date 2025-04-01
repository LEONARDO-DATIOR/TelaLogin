using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TelaLogin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void MostrarSenha(object sender, RoutedEventArgs e)
        {
            if (CampoSenhaExibida.Visibility != Visibility.Visible) { 
                CampoSenhaEscodida.Visibility = Visibility.Hidden;
                CampoSenhaExibida.Text = CampoSenhaEscodida.Password;
                CampoSenhaExibida.Visibility = Visibility.Visible;
            }
            
        }

        public void EscodeSenha(object sender, MouseEventArgs e)
        {
            CampoSenhaEscodida.Visibility = Visibility.Visible;
            CampoSenhaExibida.Text = "";
            CampoSenhaExibida.Visibility = Visibility.Hidden;
        }

        private void FazerLogin(object sender, RoutedEventArgs e)
        {
            if (CampoSenhaEscodida.Password == "1234" && CampoNome.Text == "leo")
            {
                Home home = new Home();
                home.Show();
                this.Close(); 
            } else {
                MessageBox.Show("Conta incorreta, tente novamente!");
            }
        }

  
    }
}