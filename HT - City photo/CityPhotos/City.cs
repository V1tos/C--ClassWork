using System.Collections.Generic;

namespace CityPhotos
{
    public class City
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<string> photos { get; set; }

        public int counterViews { get; set; } = 0;

        public City()
        {
            photos = new List<string>();
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
