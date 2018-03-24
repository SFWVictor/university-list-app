namespace UniversityListApp
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using UniversityListApp.Domain;
    using UniversityListApp.ViewModels;
    using Xamarin.Forms;

    public partial class MainPage : ContentPage
    {
        public const string ImagePath = "UniversityListApp.Images.";
        private const string JsonFileName = "Data.universities.json";

        public MainPage()
        {
            InitializeComponent();

            ListViewUniversities.ItemsSource = new ObservableCollection<UniversityViewModel>(GetUniversityViewModels());
        }

        private List<UniversityViewModel> GetUniversityViewModels()
        {
            var viewModels = new List<UniversityViewModel>();
            var objects = FetchData();
            objects.ForEach((o) => { viewModels.Add(new UniversityViewModel(o)); });
            return viewModels;
        }

        private List<University> FetchData()
        {
            var objects = JsonDeserializer.LoadFromJson<University>(JsonFileName);
            return objects;
        }

        private async void ListViewUniversities_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var selectedObject = ((ListView)sender).SelectedItem;
            ((ListView)sender).SelectedItem = null;

            var uniDetailsPage = new UniversityDetailsPage
            {
                BindingContext = selectedObject
            };

            await Navigation.PushAsync(uniDetailsPage);
        }
    }
}
