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
    public class DetallesMiembroViewModel
    {
        private readonly APIService _APIService;
        public string idUsuario { get; set; }
        public string NombreMiembro { get; set; }
        public string Correo { get; set; }
        public string Fecha { get; set; }

        public DetallesMiembroViewModel(APIService apiservice)
        {
            _APIService = apiservice;
            string idMiembro = Preferences.Get("idMiembro", "0");
            string nombreMiembro = Preferences.Get("nombre", "0");
            string apellidoMiembro = Preferences.Get("apellido", "0");
            string correoMiembro = Preferences.Get("email", "0");
            string fecha = Preferences.Get("fechaInscripcion", "0");

            string nombreCompleto = $"{nombreMiembro} {apellidoMiembro}";

            idUsuario = idMiembro;
            NombreMiembro = nombreCompleto;
            Correo = correoMiembro;
            Fecha = fecha;
        }

        public ICommand OnClickCerrarSesion =>
            new Command(async () =>
            {
                try
                {
                    Preferences.Set("username", "0");
                    await App.Current.MainPage.Navigation.PushAsync(new LoginPage(_APIService));
                }
                catch (Exception ex) { }
            });

        public ICommand OnClicKCambiar =>
            new Command(async () =>
            {
                var toast = Toast.Make("Cambiar contraseña", ToastDuration.Short, 14);
                await toast.Show();

            });
    }
}
