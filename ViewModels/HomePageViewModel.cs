using APP_Gimnasio_MVVM.Views;
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace APP_Gimnasio_MVVM.ViewModels
{
    public class HomePageViewModel
    {
        private readonly APIService _APIService;
        public string Username { get; set; }
        public string idMiembro { get; set; }
        public HomePageViewModel(APIService apiservice)
        {
            _APIService = apiservice;
            validarLogin();
            string username = Preferences.Get("email", "0");
            Username = username;

            string idmiembro = Preferences.Get("idMiembro", "0");
            idMiembro = idmiembro;

        }

        private async void validarLogin()
        {
            if (Preferences.Get("idMiembro", "0").Equals("0"))
            {
                await App.Current.MainPage.Navigation.PushAsync(new LoginPage(_APIService));
            }
        }

        public ICommand OnClickHistorialPagos =>
            new Command(() =>
            {
                App.Current.MainPage.Navigation.PushAsync(new HistorialPagoPage(_APIService));
            });
        public ICommand OnClickHistorialVisitas =>
            new Command(async() =>
            {
                var toast = Toast.Make("Historial Visitas", ToastDuration.Short, 14);
                await toast.Show();
            });
        public ICommand OnClickDetallesMembresia =>
            new Command(async() =>
            {
                var toast = Toast.Make("Detalle Membresía", ToastDuration.Short, 14);
                await toast.Show();
            });

        public ICommand OnClikDetallesMiembro =>
            new Command(() =>
    {

        App.Current.MainPage.Navigation.PushAsync(new DetallesMiembroPage(_APIService));
    });
    }
}
