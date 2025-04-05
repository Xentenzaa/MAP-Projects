namespace MauiApp4
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void OnVerticalStart(object sender, EventArgs e)
        {
            target.VerticalOptions = LayoutOptions.Start;
        }
        private void OnVerticalCenter(object sender, EventArgs e)
        {
            target.VerticalOptions = LayoutOptions.Center;
        }
        private void OnVerticalEnd(object sender, EventArgs e)
        {
            target.VerticalOptions = LayoutOptions.End;
        }

        private void OnHorizontalStart(object sender, EventArgs e)
        {
            target.HorizontalOptions = LayoutOptions.Start;
        }
        private void OnHorizontalCenter(object sender, EventArgs e)
        {
            target.HorizontalOptions = LayoutOptions.Center;
        }
        private void OnHorizontalEnd(object sender, EventArgs e)
        {
            target.HorizontalOptions = LayoutOptions.End;
        }
    }

}
