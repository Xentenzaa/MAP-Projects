namespace MauiApp3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
            async void OnDial(object sender, EventArgs args)
            {
                try
                {
                    PhoneDialer.Open(PhoneNum.Text);
                }
                catch
                {
                    await DisplayAlert("Invalid input!", "Enter a valid number", "OK");
                }
            }
        }
    }

