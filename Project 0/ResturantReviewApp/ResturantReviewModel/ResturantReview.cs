namespace ResturantReviewModel
{
    public class ResturantReview
    {

         private List<User> users;
        public List<User> Users { 
            get { return users; }
            set
            {
                if (value.Count <= 1)
                    users = value;
                else
                    throw new Exception("Resturant review can not list more than one User");
            }
                
                }

         private List<Review> reviews;
        public List<Review> Reviews { 
            get { return reviews; }
            set
            {
                if (value.Count <= 1)
                    reviews = value;
                else
                    throw new Exception("Resturant review can not list more than one review");
            }
                
                }

        private List<Resturant> resturants;
        public List<Resturant> Resturants { 
            get { return resturants; }
            set
            {
                if (value.Count <= 1)
                    resturants = value;
                else
                    throw new Exception("Resturant review can not list more than one resturant");
            }
                
                }
        public ResturantReview()

        {
            users = new List<User>()
            {
                new User();
            }

            reviews = new List<Review>()
            {
                new Review();
            }

            resturants = new List<Resturant>()
            {
                new Resturant();
            }

        }

        
        
            
       




    }
}
