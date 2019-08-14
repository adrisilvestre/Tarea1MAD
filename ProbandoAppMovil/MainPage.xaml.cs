using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ProbandoAppMovil
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

        async void SignInClicked(object ob, EventArgs ar)
        {
            string name = UsernameEntry.Text;
            if (String.IsNullOrEmpty(UsernameEntry.Text) || String.IsNullOrEmpty(PasswordEntry.Text))
            {
                await DisplayAlert("Error","No se admiten entradas en blanco","Ok");
            }
            else
            {
                await DisplayAlert("Bienvenido/a", $"Hola {name}, gusto en volver a verte.", "Gracias");
            }

        }
    }
}
