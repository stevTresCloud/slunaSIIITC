using System;
using Microsoft.Maui.Controls;

namespace slunaSIIITC.Views
{
    public partial class vLista3 : ContentPage
    {
        public vLista3()
        {
            InitializeComponent();
        }

        private async void btnRegistrar_Clicked(object sender, EventArgs e)
        {
            string nuevoUsuario = txtNuevoUsuario.Text;
            string nuevaContrasena = txtNuevaContrasena.Text;

            // Aqu� podr�as guardar los datos en base de datos o memoria
            await DisplayAlert("Registro exitoso", $"Usuario {nuevoUsuario} registrado correctamente.", "OK");
            await Navigation.PopAsync(); // Regresa al login
        }
    }
}
