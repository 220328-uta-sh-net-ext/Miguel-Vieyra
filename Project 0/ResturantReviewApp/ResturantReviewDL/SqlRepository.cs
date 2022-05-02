using Microsoft.Data.SqlClient;
using ResturantReviewModel;
using System.Collections.Generic;
using System.Data;

namespace ResturantReviewDL
{
    public class SqlRepository : IRepository
    {
        private const string connectionStringFilePath = "../../../../ResturatDL/connection-string.txt";
        private readonly string connectionString;

        
        public SqlRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        
        public List<Resturant> GetAllResturantsConnected()
        {
            string commandString = "SELECT * FROM Resturant;";

            
            using SqlConnection connection = new(connectionString);
            
            using IDbCommand command = new SqlCommand(commandString, connection);
            connection.Open();
            
            using IDataReader reader = command.ExecuteReader();

            
            var resturants = new List<Resturant>();
            
            while (reader.Read())
            {
                
                resturants.Add(new Resturant
                {
                    Name = reader.GetString(0),
                    Menu = reader.GetInt32(1),
                    Location = reader.GetInt32(2),
                    Decor = reader.GetInt32(3),
                });
            }
            return resturants;
        }


        public List<Resturant> GetAllResturants()
        {
            string commandString = "SELECT * FROM Resturant;";

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new(commandString, connection);
            IDataAdapter adapter = new SqlDataAdapter(command);
            DataSet dataSet = new();
            connection.Open();
            adapter.Fill(dataSet); 
            connection.Close();

            
            var resturants = new List<Resturant>();
            DataColumn levelColumn = dataSet.Tables[0].Columns[2];
            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                resturants.Add(new Resturant
                {
                    Name = (string)row[0],
                    Menu = (int)row[1],
                    Location = (int)row[2],
                    Decor = (int)row[3],
                });
            }
            return resturants;
        }

        public Resturant AddResturant(Resturant rest)
        {
            string commandString = "INSERT INTO Resturant (Name, Menu, Location, Decor) " +
                "VALUES (@name, @menu, @location, @decor);";

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new(commandString, connection);
            command.Parameters.AddWithValue("@name", rest.Name);
            command.Parameters.AddWithValue("@menu", rest.Menu);
            command.Parameters.AddWithValue("@location", rest.Location);
            command.Parameters.AddWithValue("@decor", rest.Decor);
            connection.Open();
            command.ExecuteNonQuery();

            return rest;
        }

        
        public Resturant AddResturantUnsafe(Resturant rest)
        {
            string commandString = "INSERT INTO Resturant (Name, Menu, Location, Decor) " +
                $"VALUES ({rest.Name}, {rest.Menu}, {rest.Location}, {rest.Decor};";

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new(commandString, connection);
            
            connection.Open();
            command.ExecuteNonQuery();

            return rest;
        }
    }
}
