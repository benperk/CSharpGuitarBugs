using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSharpGuitarBugs.Models
{
    public class GuitarCatalogModels
    {
        //public List<GuitarCatalog> GetFullGuitarCatalog()
        //{
        //    List<GuitarCatalog> fullGuitarCatalog = new List<GuitarCatalog>();
        //    for (int i = 0; i < 1000; i++)
        //    {
        //        GuitarCatalog guitarItem = new GuitarCatalog()
        //        {
        //            Id = i,
        //            ProductName = $"Guitar #{i.ToString()}",
        //            Description = $"The description of item {i.ToString()} goes here.",
        //            NumberOfStrings = Guitar.GetNumberOfStrings(),
        //            Manufacturer = Guitar.GetManufacturer(),
        //            Image = "some web address",
        //            Price = (i * 50)
        //        };
        //        fullGuitarCatalog.Add(guitarItem);
        //    }
        //    return fullGuitarCatalog;
        //}
        //public List<GuitarCatalog> GetFilteredGuitarCatalog(int count)
        //{
        //    List<GuitarCatalog> filteredGuitarCatalog = new List<GuitarCatalog>();
        //    for (int i = 0; i < count; i++)
        //    {
        //        GuitarCatalog guitarItem = new GuitarCatalog()
        //        {
        //            Id = i,
        //            ProductName = $"Guitar #{i.ToString()}",
        //            Description = $"The description of item {i.ToString()} goes here.",
        //            NumberOfStrings = 6,
        //            Manufacturer = "Fender",
        //            Image = "some web address",
        //            Price = (i * 50)
        //        };
        //        filteredGuitarCatalog.Add(guitarItem);
        //    }

        //    return filteredGuitarCatalog;
        //}
        //public List<GuitarCatalog> GetGuitarCatalogByManufacturer(string manufacturer)
        //{
        //    List<GuitarCatalog> fullGuitarCatalog = new List<GuitarCatalog>();

        //    for (int i = 0; i < 1000; i++)
        //    {
        //        GuitarCatalog guitarItem = new GuitarCatalog()
        //        {
        //            Id = i,
        //            ProductName = $"Guitar #{i.ToString()}",
        //            Description = $"The description of item {i.ToString()} goes here.",
        //            NumberOfStrings = Guitar.GetNumberOfStrings(),
        //            Manufacturer = Guitar.GetManufacturer(manufacturer),
        //            Image = Guitar.GetImagePath(i),
        //            Price = (i * 50)
        //        };
        //        fullGuitarCatalog.Add(guitarItem);
        //    }
        //    return fullGuitarCatalog;
        //}
    }

    public class GuitarCatalog
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int NumberOfStrings { get; set; }
        public string Manufacturer { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }

        public List<GuitarCatalog> GetFullGuitarCatalog()
        {
            List<GuitarCatalog> fullGuitarCatalog = new List<GuitarCatalog>();
            for (int i = 0; i < 1000; i++)
            {
                GuitarCatalog guitarItem = new GuitarCatalog()
                {
                    Id = i,
                    ProductName = $"Guitar #{i.ToString()}",
                    Description = $"The description of item {i.ToString()} goes here.",
                    NumberOfStrings = Guitar.GetNumberOfStrings(),
                    Manufacturer = Guitar.GetManufacturer(),
                    Image = "some web address",
                    Price = (i * 50)
                };
                fullGuitarCatalog.Add(guitarItem);
            }
            return fullGuitarCatalog;
        }
        public List<GuitarCatalog> GetFilteredGuitarCatalog(int count)
        {
            List<GuitarCatalog> filteredGuitarCatalog = new List<GuitarCatalog>();
            for (int i = 0; i < count; i++)
            {
                GuitarCatalog guitarItem = new GuitarCatalog()
                {
                    Id = i,
                    ProductName = $"Guitar #{i.ToString()}",
                    Description = $"The description of item {i.ToString()} goes here.",
                    NumberOfStrings = 6,
                    Manufacturer = "Fender",
                    Image = "some web address",
                    Price = (i * 50)
                };
                filteredGuitarCatalog.Add(guitarItem);
            }

            return filteredGuitarCatalog;
        }
        public List<GuitarCatalog> GetGuitarCatalogByManufacturer(string manufacturer)
        {
            List<GuitarCatalog> fullGuitarCatalog = new List<GuitarCatalog>();

            for (int i = 0; i < 1000; i++)
            {
                GuitarCatalog guitarItem = new GuitarCatalog()
                {
                    Id = i,
                    ProductName = $"Guitar #{i.ToString()}",
                    Description = $"The description of item {i.ToString()} goes here.",
                    NumberOfStrings = Guitar.GetNumberOfStrings(),
                    Manufacturer = Guitar.GetManufacturer(manufacturer),
                    Image = Guitar.GetImagePath(i),
                    Price = (i * 50)
                };
                fullGuitarCatalog.Add(guitarItem);
            }
            return fullGuitarCatalog;
        }
    }

    public class Guitar
    {
        static public List<string> GetManufacturers()
        {
            return new List<string> { "Gibson", "Fender", "Charvel", "Taylor", "Jackson", "Martin and Company", "Dean", "Epiphone", "Takamine" };
        }
        static public string GetManufacturer()
        {
            var manufacturers = new List<string> { "Gibson", "Fender", "Charvel", "Taylor", "Jackson", "Martin and Company", "Dean", "Epiphone", "Takamine" };
            int index = new Random().Next(manufacturers.Count);
            return manufacturers[index];
        }
        static public string GetManufacturer(string manufacturer)
        {
            //http://bit.ly/1UkSs6R            
            //System.Text.RegularExpressions.Regex slowRegex = new System.Text.RegularExpressions.Regex("([a - z] +) *=");
            //System.Text.RegularExpressions.Match m = slowRegex.Match("Gibson Fender Charvel Taylor Jackson MartinandCompany Dean Epiphone Takamine");
            //http://bit.ly/25ZcsEH
            System.Text.RegularExpressions.Match m = System.Text.RegularExpressions.Regex.Match(manufacturer, "\"(([^\\\\\"]*)(\\\\.)?)*\"");

            return m.ToString();
        }
        static public int GetNumberOfStrings()
        {
            var strings = new List<int> { 6, 7, 8 };
            int index = new Random().Next(strings.Count);
            return strings[index];
        }
        static public string GetImagePath(int number)
        {
            var images = new List<int> { 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40 };
            int index = new Random().Next(images.Count);
            var image = images[index];
            return $@"\Images\electric\{images[index].ToString()}.jpg";
        }
    }
}