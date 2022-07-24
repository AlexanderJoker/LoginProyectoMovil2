using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginProyecto.Pantallas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Verificacion : ContentPage
    {
        public Verificacion()
        {
            InitializeComponent();
        }

        private async void btnverificar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Verificado());
        }

        private void btnotrocodigo_Clicked(object sender, EventArgs e)
        {
            
        }
    }
}