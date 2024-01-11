using APP_Gimnasio_MVVM.ViewModels;
namespace APP_Gimnasio_MVVM.Views;

public partial class HistorialVisitasPage : ContentPage
{
	public HistorialVisitasPage()
	{
		InitializeComponent();
		BindingContext = new HistorialVisitasViewModel();
	}
}