using System;
using Xamarin.Forms;

namespace MobileCenterQs
{
    public partial class MobileCenterQsPage : ContentPage
    {
        public MobileCenterQsPage()
        {
            InitializeComponent();

			txtUserName.TextChanged += ValidateMandatory;
            txtPassword.TextChanged += ValidateMandatory;

            btnLogin.Clicked += DoLogin;
        }

        void DoLogin(object sender, EventArgs e)
        {
			var userName = txtUserName.Text;
			var password = txtPassword.Text;

            if (userName.Contains("ex")) {
                throw new NotSupportedException("You have entered invalid data!");
            }

            DisplayAlert("Greeting", $"Welcome {userName} to Mobile Center!", "Ok");
        }


        void ValidateMandatory(object sender, TextChangedEventArgs e)
        {
			var userName = txtUserName.Text;
			var password = txtPassword.Text;

            var shouldEnable = !string.IsNullOrWhiteSpace(userName) && !string.IsNullOrWhiteSpace(password);

            btnLogin.IsEnabled = shouldEnable;
        }
   }
}
