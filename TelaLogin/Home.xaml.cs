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
    /// 

    public class Senhas
    {
        public string NomeLocal { get; set; }
        public string SenhaEscolhida { get; set; }

        public Senhas(string NomeLocal, string SenhaEscolhida)
        {
            this.NomeLocal = NomeLocal;
            this.SenhaEscolhida = SenhaEscolhida;
        }

        public List<Senhas> SalvarSenha(Senhas senhaCriada, List<Senhas> listaSenhas)
        {
            if (!listaSenhas.Any(senha => senha.NomeLocal == senhaCriada.NomeLocal))
            {
                listaSenhas.Add(senhaCriada);
            }
            else
            {
                MessageBox.Show("Esse local já existe, tente outro!");
                return listaSenhas;
            }
            return listaSenhas;
        }
    }

    public partial class Home : Window
    {
        public Home()
        {
            InitializeComponent();
        }

        private void EnvioSenha(object sender, RoutedEventArgs e)
        {
            string CaminhoArquivo = @"C:\Users\leona\source\repos\TelaLogin\TelaLogin\bin\Debug\net8.0-windows\senha\senhas.txt.txt";
            List<Senhas> listaSenhas = new List<Senhas>();

            // PEGA AS SENHAS DENTRO DO ARQUIVO
            string conteudoArquivo = File.ReadAllText(CaminhoArquivo);
            listaSenhas = JsonSerializer.Deserialize<List<Senhas>>(conteudoArquivo);

            // ADICIONA A SENHA NA LISTA JSON 
            Senhas senhaCriada = new Senhas(CampoNomeLocal.Text, CampoSenhaEscolhida.Text);
            listaSenhas = senhaCriada.SalvarSenha(senhaCriada, listaSenhas);

            // SALVA EM UMA STRING JSON E SALVA NO ARQUIVO
            string StringSenhasJson = JsonSerializer.Serialize(listaSenhas, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(CaminhoArquivo, StringSenhasJson);




            conteudoArquivo = File.ReadAllText(CaminhoArquivo);
            MessageBox.Show(conteudoArquivo);

        }
    }
}
