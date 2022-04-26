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
    public partial class Registro : ContentPage
    {
        private double totalAPagar = 0;
        public Registro(string nombreUsuario)
        {
            InitializeComponent();
            lblNombreUsuario.Text = nombreUsuario;
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            double montoInicial = 0;
            double cuotaMensual = 0;
            try
            {
                montoInicial = Convert.ToDouble(txtMontoInicial.Text);
                if (montoInicial > 1800)
                {
                    DisplayAlert("Error en monto inicial","Error en el monto Inical debe ser <=1800", "Continuar");

                }
                else
                {
                    cuotaMensual = ((1800 - montoInicial) * 1.05 / 3);
                }
                txtPagoMensual.Text = cuotaMensual.ToString();
            }
            catch (Exception ex)
            {
                DisplayAlert("Error en monto inicial", "Error en el monto Inical debe ser numerico", "Continuar");

            }
            totalAPagar = montoInicial + (cuotaMensual * 3);
        }

        private async void btnEnviar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Resumen(lblNombreUsuario.Text, txtNombreEstudiante.Text, totalAPagar));

        }
    }
}