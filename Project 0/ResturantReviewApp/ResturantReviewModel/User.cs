using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantReviewModel
{
    internal class User
    {
        public string Name { get; set; }
        private int Password;

        public int password
        {
            get { return Password; }
            set {
                if (Password.length < 7 || Password.Length > 14)
                    return false;  }
        }

        public User()
        {
            Name = "Miguel";
            Password = 0;
        }
    }
}
