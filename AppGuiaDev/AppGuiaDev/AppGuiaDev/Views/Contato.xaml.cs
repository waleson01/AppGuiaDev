using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using Xamarin.Forms.OpenWhatsApp;

namespace AppGuiaDev.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Contato : ContentPage
    {
        public Contato()
        {
            InitializeComponent();
        }

        private async void fone_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Launcher.OpenAsync("tel:+551936560052");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro", ex.Message, "OK");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        private async void email_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Launcher.OpenAsync("mailto:e060dir@cps.gov.br"); 
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro", ex.Message, "OK");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        private async void whatsapp_Clicked(object sender, EventArgs e)
        {
            try
            {
                Chat.Open("+5519356560052","E ae, fala mais do curso de TI");
            }
            catch(Exception ex)
            {
                if(await DisplayAlert("Ops, deu um erro","Não conseguimos abrir o WhatsApp. Quer ligar para (19)9 9889-0444 ?","Ligar","Agora Não"))
                {
                    await Launcher.OpenAsync("tel:+551936560052");
                }
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}