using APP_Gimnasio_MVVM.ViewModels;
namespace APP_Gimnasio_MVVM.Views;

public partial class HomePage : ContentPage
{
    private readonly APIService _APIService;
    public HomePage(APIService apiservice)
	{
		InitializeComponent();
		BindingContext = new HomePageViewModel(apiservice);
        _APIService = apiservice;
    }
}