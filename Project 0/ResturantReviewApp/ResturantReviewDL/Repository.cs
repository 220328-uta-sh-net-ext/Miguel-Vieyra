using System.IO;
using ResturantReviewModel;
using System.Collections.Generic;
using System.Text.Json; 

namespace ResturantReviewDL

{
    public class Repository:IRepository
    {
        private string filePath = "../ResturantDL/Database";
        private string jsonString;
        public Resturant AddResturant(Resturant Rest)
        {
            var resturants=GetAllResturants();
            resturants.Add(Rest);
           var resturantString= JsonSerializer.Serialize<List<Resturant>>(resturants, new JsonSerializerOptions { WriteIndented=true});
            File.WriteAllText(filePath, resturantString);
            return Rest;
        }

        public List<Resturant> GetAllResturants()
        {
            try
            {
                jsonString = File.ReadAllText(filePath + "Resturant.json");
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            if (!string.IsNullOrEmpty(jsonString))
                return JsonSerializer.Deserialize<List<Resturant>>(jsonString);
            else
                return null;

        }


        List<Resturant> IRepository.GetAllResturants()
        {
            throw new System.NotImplementedException();
        }

    }
}