using APP_Gimnasio_MVVM.ViewModels;
namespace APP_Gimnasio_MVVM.Views;

public partial class CambioContraPage : ContentPage
{
	public CambioContraPage()
	{
		InitializeComponent();
		BindingContext = new CambioContraViewModel();
	}
}