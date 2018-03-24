namespace UniversityListApp
{
    using UniversityListApp.Domain;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UniversityDetailsPage : ContentPage
    {
        public UniversityDetailsPage()
        {
            InitializeComponent();
        }

        private async void ButtonLink_Pressed(object sender, ItemTappedEventArgs e)
        {
            string link = ((University)BindingContext).Link;

            var webBrowserPage = new WebPage
            {
                BindingContext = link
            };

            await Navigation.PushAsync(webBrowserPage);
        }
    }
}