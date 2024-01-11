using APP_Gimnasio_MVVM.ViewModels;
namespace APP_Gimnasio_MVVM.Views;

public partial class HistorialPagoPage : ContentPage
{
    private readonly APIService _APIService;
    public HistorialPagoPage(APIService apiservice)
	{
		InitializeComponent();
		BindingContext = new HistorialPagoViewModel(apiservice);
        _APIService = apiservice;
    }
}