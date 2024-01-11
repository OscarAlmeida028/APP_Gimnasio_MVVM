using APP_Gimnasio.Models;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_Gimnasio_MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class HistorialPagoViewModel
    {
        private readonly APIService _APIService;
        public string correo { get; set; }
        public ObservableCollection<Pago> ListaPagos { get; set; }
        public string fechaPago { get; set; }
        public string montoPago { get; set; }
        public HistorialPagoViewModel(APIService apiservice)
        {
            _APIService = apiservice;
            InicializarAsync();
        }

        private async void InicializarAsync()
        {
            try
            {
                string idMiembro = Preferences.Get("idMiembro", "0");
                string correoMiembro = Preferences.Get("email", "0");
                correo = correoMiembro;
                int.TryParse(idMiembro, out int id);

                List<Pago> listaPagos = await _APIService.GetPagosPorMiembro(id);
                ListaPagos = new ObservableCollection<Pago>(listaPagos);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}
