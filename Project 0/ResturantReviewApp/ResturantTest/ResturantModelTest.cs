using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResturantReviewModel;
using Xunit;

namespace ResturantTest
{
    public class ResturantModelTest
    {
        [Fact]
        public void ReviewShouldBevalidData()
        {
            
            Resturant resturant = new Resturant();
            int validReview = 5;
            
            resturant.review = validreview;
            
            Assert.Equal(validreview, Resturant.review); 
        }

        [Theory]
        [InlineData(-10)]
        [InlineData(-120)]
        [InlineData(-123445)]
        public void ReviewShouldSetValidData(int r_invalidData)
        {

            Resturant ab = new Resturant();


            Assert.Throws<System.Exception>(
                () => ab.Review = r_invalidData
                );
        }



    }
}
