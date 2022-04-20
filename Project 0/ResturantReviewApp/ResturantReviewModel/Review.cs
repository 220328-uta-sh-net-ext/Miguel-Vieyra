using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantReviewModel
{
    public class Review
    {
        public string UsersName { get; set; }
        public string ResturantName { get; set; }
        private int Score;
        public int score 
        { 
            get { return Score; } 
            set { if (value >= 0)
                    Score = value;
                else
                    throw new Exception("You can not set score lower than zero!");
                        } 
        }


        public string Comment { get; set; }

        public Review()
        {
            UsersName = "Miguel";
            ResturantName = "Italian Resturant";
            Score = 5;
            Comment = "I like this resturant.";
        }

    }
}
