using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResturantReviewModel;
using System.Collections.Generic;

namespace ResturantReviewDL
{
    public interface IRepository
    {
       
        Resturant AddResturant(Resturant Rest);

        List<Resturant> GetAllResturants();

    }
}
