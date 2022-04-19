namespace ResturantReviewModel
{
    public class ResturantReview
    {


        private List<Resturant> _resturants;
        public List<Resturant> Resturants { 
            get { return _resturants; }
            set
            {
                if (value.Count <= 1)
                    _resturants = value;
                else
                    throw new Exception("Resturant review con not list more than one resturant");
            }
                
                }
        public ResturantReview()

        {
            User = 
        }
    }
}
