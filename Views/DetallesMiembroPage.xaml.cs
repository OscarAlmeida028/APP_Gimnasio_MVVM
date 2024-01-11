using APP_Gimnasio_MVVM.ViewModels;
namespace APP_Gimnasio_MVVM.Views;

public partial class DetallesMiembroPage : ContentPage
{
    private readonly APIService _APIService;
    public DetallesMiembroPage(APIService apiservice)
    {
        InitializeComponent();
        BindingContext = new DetallesMiembroViewModel(apiservice);
        _APIService = apiservice;
    }
}