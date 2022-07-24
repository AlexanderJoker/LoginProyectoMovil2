using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoginProyecto.Pantallas;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginProyecto.Pantallas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CrearUsuario : ContentPage
    {
        public CrearUsuario()
        {
            InitializeComponent();
        }      
        private async void btncrear_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Verificacion());
        }
        private async void btncancelar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PantallaLogin());
        }

        private void btnElegirimagen_Clicked(object sender, EventArgs e)
        {

        }

        private void OnDateSelected(object sender, DateChangedEventArgs e)
        {

        }

        private void btnGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}