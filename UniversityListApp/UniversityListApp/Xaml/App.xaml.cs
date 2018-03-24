namespace UniversityListApp
{
    using Xamarin.Forms;

    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            NavigationPage navigationPage = new NavigationPage(new UniversityListApp.MainPage())
            {
                BarBackgroundColor = Color.Green
            };

            MainPage = navigationPage;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
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
