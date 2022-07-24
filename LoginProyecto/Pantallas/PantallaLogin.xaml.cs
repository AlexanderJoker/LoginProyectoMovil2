using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoginProyecto.Pantallas;
using LoginProyecto.PantallasCambiocontra;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginProyecto.Pantallas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PantallaLogin : ContentPage
    {
        public PantallaLogin()
        {
            InitializeComponent();
            
        }
        //Boton para iniciar Sesion
        private async void btnIniciar_Clicked(object sender, EventArgs e)
        {
            // await Navigation.PushAsync(new);
        }
        //Boton para crear usuario
        private async void btnCrear_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CrearUsuario());
        }
       //Boton que olvide la clave
        private async void btnclave_Clicked(object sender, EventArgs e)
        {
           await Navigation.PushAsync(new Codigocontra());
        }
        //cambio de estado del checkbox
        private void mostrar_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {

        }

    }
}