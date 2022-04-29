using Xunit;
using ResturantReviewBL;

namespace ResturantTest
{
    public class BLforTest
    {
        [Fact]

        public void TestAdd()
        {
            ResturantLogic obj=new ResturantLogic();
            int a = 10, b = 20, expected = 30;
            var actual=obj.Add(a, b);

            Assert.Equal(expected, actual);
        }
    }
}