using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using APP_Gimnasio.Models;
using APP_Gimnasio_MVVM.Views;
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;

namespace APP_Gimnasio_MVVM.ViewModels
{
    public class LoginViewModel
    {
        public string Username { get; set; }
        public string Password { get; set; }

        private readonly APIService _APIService;
        public LoginViewModel(APIService apiservice)
        {
            _APIService = apiservice;
        }

        public ICommand OnClickLogin =>
            new Command(async() => {
                string username = Username;
                string password = Password;

                Miembro miembro = new Miembro
                {
                    emailMiembro = username,
                    passwordMiembro = password,
                };

                Miembro miembro2 = await _APIService.LoginMiembro(miembro);
                if (miembro2 != null)
                {
                    Preferences.Set("idMiembro", miembro2.idMiembro.ToString());
                    Preferences.Set("idMembresia", miembro2.idMembresia.ToString());
                    Preferences.Set("nombre", miembro2.nombreMiembro);
                    Preferences.Set("apellido", miembro2.apellidoMiembro);
                    Preferences.Set("email", miembro2.emailMiembro);
                    Preferences.Set("fechaInscripcion", miembro2.fechaInscripcion.ToString());

                    var toast = Toast.Make("Ingreso Correcto", ToastDuration.Short, 14);
                    await toast.Show();

                    await App.Current.MainPage.Navigation.PushAsync(new HomePage(_APIService));
                }
                else
                {
                    var toast = Toast.Make("Nombre de usuario o password incorrecto", ToastDuration.Short, 14);
                    await toast.Show();
                }
                });
    }
}
