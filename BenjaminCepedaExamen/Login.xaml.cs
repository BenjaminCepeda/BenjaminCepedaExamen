using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BenjaminCepedaExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
            string nombreUsuario = "";
            string mensaje = validarIngreso(txtUser.Text, txtPassword.Text);
            if (mensaje != "")
            {
                await DisplayAlert("Error de validación", mensaje, "Continuar");
            }
            else
            {
                nombreUsuario = txtUser.Text;
                await Navigation.PushAsync(new Registro(nombreUsuario));
            }

        }
        private string validarIngreso(string usuario, string clave)
        {
            string mensaje = "";
            if (usuario != "benjamin2022")
            {
                mensaje = "Usuario incorrecto !";
            }
            else if (clave != "uisrael2022")
            {
                mensaje = "Clave incorrecta !";
            }
            return mensaje;
        }
    }
}