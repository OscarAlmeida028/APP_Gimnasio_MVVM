using APP_Gimnasio_MVVM.ViewModels;
namespace APP_Gimnasio_MVVM.Views;

public partial class DetallesMembresiaPage : ContentPage
{
	public DetallesMembresiaPage()
	{
		InitializeComponent();
		BindingContext = new DetallesMembresiaViewModel();
	}
}