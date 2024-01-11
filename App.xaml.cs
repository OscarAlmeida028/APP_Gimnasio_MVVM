using APP_Gimnasio_MVVM.Views;

namespace APP_Gimnasio_MVVM
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            APIService apiservice = new APIService();
            MainPage = new NavigationPage(new HomePage(apiservice));
        }
    }
}
