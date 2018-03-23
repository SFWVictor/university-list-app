namespace UniversityListApp
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using Xamarin.Forms;

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            ListViewUniversities.ItemsSource = new ObservableCollection<University>(FetchData());
        }

        private List<University> FetchData()
        {
            var universities = UniversityJsonDeserializer.LoadFromJson<University>();
            return universities;
        }

        private async void ListViewUniversities_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var selectedObject = ((ListView)sender).SelectedItem;

            var uniDetailsPage = new UniversityDetailsPage
            {
                BindingContext = selectedObject
            };

            await Navigation.PushAsync(uniDetailsPage);
        }
    }
}
