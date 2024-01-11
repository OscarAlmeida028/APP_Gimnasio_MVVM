using APP_Gimnasio_MVVM.ViewModels;
using System.Windows.Input;
namespace APP_Gimnasio_MVVM.Views;

public partial class LoginPage : ContentPage
{
    private readonly APIService _APIService;
    public LoginPage(APIService apiservice)
	{
		InitializeComponent();
		BindingContext = new LoginViewModel(apiservice);
        _APIService = apiservice;
    }
}