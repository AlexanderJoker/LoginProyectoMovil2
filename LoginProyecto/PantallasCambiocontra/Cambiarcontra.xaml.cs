using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoginProyecto.PantallasCambiocontra;
using LoginProyecto.Pantallas;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginProyecto.PantallasCambiocontra
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Cambiarcontra : ContentPage
    {
        public Cambiarcontra()
        {
            InitializeComponent();
        }

        private async void btncambiar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PantallaLogin());
        }
    }
}