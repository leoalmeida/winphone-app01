using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Aula2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void button_Click(object sender, RoutedEventArgs e)
        {
            int anoNasc;
            int idade;
            string nome;
            string msg;

            if (txtNome.Text != "")
            {
                nome = txtNome.Text;
                if (txtAnoNasc.Text != "")
                {
                    anoNasc = Convert.ToInt32(txtAnoNasc.Text);
                    idade = DateTime.Now.Year - anoNasc;

                    msg = "Olá " + nome + ", você tem " + idade + " anos";
                }
                else
                {
                    msg = "Olá" + nome + ", coloque a data de nascimento correta.";
                }
            }
            else
            {
                msg = "Oi, qual é o seu nome?";
            }

            var dialog = new Windows.UI.Popups.MessageDialog(msg);

            await dialog.ShowAsync();
        }
        
    }
}
