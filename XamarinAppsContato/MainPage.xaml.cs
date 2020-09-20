using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace XamarinAppsContato
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnEnviar_Clicked(object sender, EventArgs e)
        {
            string destinatario = EntDestinatario.Text;
            string assunto = EntAssunto.Text;
            string mensagem = EdtMensagem.Text;

            string url = "mailto:" + destinatario + "?subject=" + assunto + "&body=" + mensagem;

            Launcher.OpenAsync(url);
            //Device.OpenUri(new Uri(url));
        }

        private void BtnLigar_Clicked(object sender, EventArgs e)
        {
            string telefone = EntTelefone.Text;
            string url = "tel:" + telefone;
            Launcher.OpenAsync(url);
        }

        private void BtnAbrirAppWhats_Clicked(object sender, EventArgs e)
        {
            Launcher.OpenAsync("https://api.whatsapp.com/send?l=pt&phone=558134615556");
        }

        private void BtnAbrirAppInsta_Clicked(object sender, EventArgs e)
        {
            Launcher.OpenAsync("https://www.instagram.com/JacquesLassau/");
        }
    }
}
