using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoginProyecto.Pantallas;
using LoginProyecto.PantallasCambiocontra;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginProyecto.PantallasCambiocontra
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Codigocontra : ContentPage
    {
        public Codigocontra()
        {
            InitializeComponent();
        }

        private async void btncambiarclave_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Cambiarcontra());
        }
    }
}