using MyWeatherApp.Resources;

namespace MyWeatherApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            if (VersionTracking.IsFirstLaunchEver == true)
            {
                MainPage = new WelcomePage();
            }
            else
            {
                MainPage = new WeatherPage();
            }
        }
    }
}
