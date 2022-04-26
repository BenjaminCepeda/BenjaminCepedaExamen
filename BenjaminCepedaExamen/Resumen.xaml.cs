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
    public partial class Resumen : ContentPage
    {
        public Resumen(string nombreUsuario, string nombreEstudiante, double totalAPagar)
        {
            InitializeComponent();
            lblNombreUsuario.Text = nombreUsuario;
            lblNombreEstudiante.Text = nombreEstudiante;
            lblTotalAPagar.Text = totalAPagar.ToString();

        }
    }
}