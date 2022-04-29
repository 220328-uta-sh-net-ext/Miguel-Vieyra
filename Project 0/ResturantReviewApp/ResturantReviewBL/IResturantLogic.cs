using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantReviewBL
{
    public interface IResturantLogic
    {

        Resturant AddResturant(Resturant R);


        List<Resturant> SearchResturant(string name);

    }

    interface IResturantSearch
    {
        List<Resturant> SearchAll();
    }




}
