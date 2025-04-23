using System;
using Microsoft.Maui.Controls;

namespace slunaSIIITC.Views
{
    public partial class vLista2 : ContentPage
    {

        public vLista2(String usuario)
        {
            InitializeComponent();
            lblUsuario.Text = "Usuario Conectado" + usuario;
        }

        private async void btnCerrarSesion_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync(); // Vuelve al login
        }
    }
}
