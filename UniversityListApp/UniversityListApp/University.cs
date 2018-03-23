namespace UniversityListApp
{
    using System;
    using Newtonsoft.Json;

    public class University
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
        public University(string name, int students, int founded, string country, string description, string smallImage, string largeImage, string url)
        {
            _name = name ?? throw new ArgumentNullException(nameof(name));
            _country = country ?? throw new ArgumentNullException(nameof(country));
            _students = students;
            _founded = founded;
            _description = description ?? throw new ArgumentNullException(nameof(description));
            _smallImage = smallImage ?? throw new ArgumentNullException(nameof(smallImage));
            _largeImage = largeImage ?? throw new ArgumentNullException(nameof(largeImage));
            _link = url ?? throw new ArgumentNullException(nameof(url));
        }

        public string Name { get => _name; set => _name = value; }
        public int Students { get => _students; set => _students = value; }
        public int Founded { get => _founded; set => _founded = value; }
        public string Country { get => _country; set => _country = value; }
        public string Description { get => _description; set => _description = value; }
        [JsonProperty("Small image")]
        public string SmallImage { get => _smallImage; set => _smallImage = value; }
        [JsonProperty("Large image")]
        public string LargeImage { get => _largeImage; set => _largeImage = value; }
        public string Link { get => _link; set => _link = value; }
    }
}
