using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Text.Json;
using System.IO;

namespace TelaLogin
{
    /// <summary>
    /// Lógica interna para Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public Home()
        {
            InitializeComponent();
        }

        private void EnvioSenha(object sender, RoutedEventArgs e)
        {
            string conteudoArquivo = File.ReadAllText(@"C:\Users\leona\source\repos\TelaLogin\TelaLogin\bin\Debug\net8.0-windows\senha\senhas.txt.txt");
            MessageBox.Show(conteudoArquivo);
        }
    }
}
