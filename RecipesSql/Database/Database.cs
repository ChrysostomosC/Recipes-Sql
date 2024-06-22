using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Database
    {

        public List<Recipe> GetRecipes()
        {
            SqlCommand cmd = GetDbCommand();

            cmd.CommandText = "SELECT * FROM Recipe";

            var reader = cmd.ExecuteReader();

            var books = new List<Recipe>();

            while (reader.Read())
            {
                int id = int.Parse(reader["Id"].ToString());
                string name = reader["Name"].ToString();
                string image = reader["Image"].ToString();
                string ingredients = reader["Ingredients"].ToString();
                string directions = reader["Directions"].ToString();


                Recipe newRecipe = new Recipe()
                {
                    Name = name,
                    Image = image,
                    Ingredients = ingredients,
                    Directions = directions 
                };
            }
            return books;
        }

        public void SaveRecipe(string name, string image, string ingredients, string directions)
        {
            SqlCommand cmd = GetDbCommand();

            cmd.CommandText = $"INSERT INTO Recipe (Name, Image, Ingredients, Directions) VALUES ('{name}', '{image}', '{ingredients}', '{directions}')";

            cmd.ExecuteNonQuery();
        }

        
        private static SqlCommand GetDbCommand()
        {
            string connectionString = "Data Source=localhost;Initial Catalog=RecipesDB;Integrated Security=True";

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandType = CommandType.Text;
            return cmd;
        }
    }
}
