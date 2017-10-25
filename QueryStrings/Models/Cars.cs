using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QueryStrings.Models
{
    public class Cars
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Country { get; set; }

        public int Power { get; set; }


        public List<Cars> CarsList = new List<Cars>();

        public List<Cars> ReturnCars()
        {
            CarsList.Add( new Cars { Id = 1, Name = "Volvo", Country = "Sweden", Power=200 });
            CarsList.Add(new Cars { Id = 2, Name = "BMW", Country = "Germany", Power = 300 });
            CarsList.Add(new Cars { Id = 3, Name = "Audi", Country = "Germany", Power = 400 });
            CarsList.Add(new Cars { Id = 4, Name = "Ford", Country = "USA", Power = 500 });
            CarsList.Add(new Cars { Id = 2, Name = "Bently", Country = "UK", Power = 300 });

            return CarsList;
        }



    }
}