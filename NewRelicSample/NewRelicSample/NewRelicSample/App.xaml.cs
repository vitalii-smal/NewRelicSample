using NewRelic.Xamarin.Plugin;
using Xamarin.Forms;

namespace NewRelicSample
{
    public partial class App : Application
    {
        public App ()
        {
            InitializeComponent();

            CrossNewRelicClient.Current.HandleUncaughtException();
            CrossNewRelicClient.Current.Start("token");

            MainPage = new MainPage();
        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}

