using APP_Gimnasio_MVVM.ViewModels;
namespace APP_Gimnasio_MVVM.Views;

public partial class NuevoPagoPage : ContentPage
{
	public NuevoPagoPage()
	{
		InitializeComponent();
		BindingContext = new NuevoPagoViewModel();
	}
}