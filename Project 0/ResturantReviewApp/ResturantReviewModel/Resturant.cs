using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantReviewModel
{
    public class Resturant
    {
        public string Name { get; set; }
        public string Menu { get; set; }
        public string Location { get; set; }
        public string Decor { get; set; }

      

        public Resturant()
        {
            Name = "Italian Resturant";
            Menu = ("Lasagna Salad Bread");
            Location = "Riverside";
            Decor = "Good";
        }
    }
}
