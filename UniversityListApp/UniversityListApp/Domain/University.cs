namespace UniversityListApp.Domain
{
    using System;
    using System.ComponentModel;
    using Newtonsoft.Json;

    public class University : INotifyPropertyChanged
    {
        private string _name;
        private int _students;
        private int _founded;
        private string _country;
        private string _description;
        private string _smallImage;
        private string _largeImage;
        private string _link;

        public University() { }
        public University(string name, int students, int founded, string country, string description, string smallImage, string largeImage, string link)
        {
            _name = name ?? throw new ArgumentNullException(nameof(name));
            _country = country ?? throw new ArgumentNullException(nameof(country));
            _students = students;
            _founded = founded;
            _description = description ?? throw new ArgumentNullException(nameof(description));
            _smallImage = smallImage ?? throw new ArgumentNullException(nameof(smallImage));
            _largeImage = largeImage ?? throw new ArgumentNullException(nameof(largeImage));
            _link = link ?? throw new ArgumentNullException(nameof(link));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string Name
        {
            get => _name;
            set
            {
                if (_name != value)
                {
                    _name = value;

                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
                }
            }
        }
        public int Students
        {
            get => _students;
            set
            {
                if (_students != value)
                {
                    _students = value;

                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Students)));
                }
            }
        }
        public int Founded
        {
            get => _founded;
            set
            {
                if (_founded != value)
                {
                    _founded = value;

                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Founded)));
                }
            }
        }
        public string Country
        {
            get => _country;
            set
            {
                if (_country != value)
                {
                    _country = value;

                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Country)));
                }
            }
        }
        public string Description
        {
            get => _description;
            set
            {
                if (_description != value)
                {
                    _description = value;

                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Description)));
                }
            }
        }
        [JsonProperty("Small image name")]
        public string SmallImageName
        {
            get => _smallImage;
            set
            {
                if (_smallImage != value)
                {
                    _smallImage = value;

                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SmallImageName)));
                }
            }
        }

        [JsonProperty("Large image name")]
        public string LargeImageName
        {
            get => _largeImage;
            set
            {
                if (_largeImage != value)
                {
                    _largeImage = value;

                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(LargeImageName)));
                }
            }
        }

        public string Link
        {
            get => _link;
            set
            {
                if (_link != value)
                {
                    _link = value;

                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Link)));
                }
            }
        }
    }
}
