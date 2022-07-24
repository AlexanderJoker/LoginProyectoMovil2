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
    public partial class Verificado : ContentPage
    {
        public Verificado()
        {
            InitializeComponent();
        }
       
        private async void btnregreso_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PantallaLogin());
        }
    }
}