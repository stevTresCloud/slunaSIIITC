using System;
using Microsoft.Maui.Controls;

namespace slunaSIIITC.Views
{
    public partial class vLista1 : ContentPage
    {
        public vLista1()
        {
            InitializeComponent();
            
        }

        private async void btnIniciarSesion_Clicked(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;

            // Validaci�n simple (ejemplo)
            if (usuario == "steven" && contrasena == "1234")
            {
                await Navigation.PushAsync(new vLista2(usuario)); // Navega a la vista principal
            }
            else
            {
                await DisplayAlert("Error", "Usuario o contrase�a incorrectos", "OK");
            }
        }

        private async void btnRegistrarse_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new vLista3()); // Navega al formulario de registro
        }
    }
}
