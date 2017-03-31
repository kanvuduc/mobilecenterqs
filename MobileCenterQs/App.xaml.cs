using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;
using Xamarin.Forms;

namespace MobileCenterQs
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MobileCenterQsPage();
        }

        protected override void OnStart()
        {
			MobileCenter.Start(
                    "android=0b90a986-7763-46b1-a7e9-21f19506220a;ios=1f1807e4-d38b-4888-98d3-5fd5921ab930",
				    typeof(Analytics), 
                    typeof(Crashes));
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
