using ResturantReviewDL;
using ResturantReviewModel;


namespace ResturantReviewBL
{
    public class ResturantLogic : IResturantLogic 
    {
        private const int MaxResturants = 5;
        private readonly IRepository repo;

        public ResturantLogic(IRepository repo)
        {
            this.repo = repo;
        }

        public Resturant AddResturant(Resturant R)
        {
            Random random = new Random();
           
            review = random.Next(0, 5);
           

            
            var resturants = repo.GetAllresturants();
            if (resturants.Count < MaxResturants)
            {
                return repo.AddResturant(p);
            }
            else
            {
                throw new Exception("You cannot exceed more than 5 Resturant");
            }
        }

        public List<Resturant> SearchResturant(string name)
        {


            var resturant = repo.GetAllResturants();
            

            var filteredResturants = resturants.Where(p => p.Name.Contains(name)).ToList(); 
            
            return filteredResturants;

        }
       



}