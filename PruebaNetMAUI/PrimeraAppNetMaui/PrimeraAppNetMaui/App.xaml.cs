

using System.Diagnostics;

namespace PrimeraAppNetMaui
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
        protected override Window CreateWindow(IActivationState? activationState)
        {

            Window nuestraApp = base.CreateWindow(activationState);
            //nuestraApp.Activated += SaludoDeBienvenida;
            nuestraApp.Created += async (s, a) => await SaludoDeBienvenida(s,a);
            nuestraApp.Destroying += async (s,a)=> await SaludoDeSalida(s, a);
            nuestraApp.Resumed += async (s, a) => await MensajeDeAppRestaurada(s,a);
            nuestraApp.Deactivated += async (s, a) => await MensajeDeAppSuspendida(s,a);

            return nuestraApp;

                
                
                }

        private async Task MensajeDeAppSuspendida(object? sender, EventArgs e)
        {
            Debug.Print(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>Ha salido de la app pero todavia sigue cargada en memoria ");
        }

        private async Task MensajeDeAppRestaurada(object? sender, EventArgs e)
        {
            Debug.Print(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>HA vuelto a la app ");
        }

        private async Task  SaludoDeSalida(object? sender, EventArgs e)
        {
            Debug.Print(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>ha salido de la APP correctamente");
        }

        private async Task SaludoDeBienvenida(object? sender, EventArgs e)
        {
            await Application.Current.MainPage.DisplayAlert("Mensaje", "Bienvenidos a nuestra app NET.MAUI", "Ok");
        
            
        }
    }
}
