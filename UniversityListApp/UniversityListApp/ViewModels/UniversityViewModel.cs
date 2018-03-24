namespace UniversityListApp.ViewModels
{
    using UniversityListApp.Domain;
    using UniversityListApp.Extensions;
    using Xamarin.Forms;

    public class UniversityViewModel : University
    {
        private string _imagePath = MainPage.ImagePath;

        public UniversityViewModel()
        {
        }

        public UniversityViewModel(string name, int students, int founded, string country, string description, string smallImage, string largeImage, string link) : base(name, students, founded, country, description, smallImage, largeImage, link)
        {

        }

        public UniversityViewModel(University university) : base(university.Name, university.Students, university.Founded, university.Country, university.Description, university.SmallImageName, university.LargeImageName, university.Link)
        {

        }

        public string ImagePath
        {
            get
            {
                return _imagePath;
            }
            set
            {
                _imagePath = value;
            }
        }

        public ImageSource SmallImage
        {
            get
            {
                return ImageSource.FromResource(ImagePath + SmallImageName);
            }
        }

        public ImageSource LargeImage
        {
            get
            {
                return ImageSource.FromResource(ImagePath + LargeImageName);
            }
        }
    }
}
