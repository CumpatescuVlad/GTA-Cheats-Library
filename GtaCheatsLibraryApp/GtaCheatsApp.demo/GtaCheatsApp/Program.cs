using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;

namespace GtaCheatsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = GTA;Password=123;User ID =Vlad;
                                      Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;
                                      ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            SqlCommand sqlCommand;
            SqlDataReader reader;
            String querryString, Cheats="";

            string action = Console.ReadLine();

            querryString = $"Select  Cheats,Action from GTA5CHEATS Where Action='{action}'";
            sqlCommand =new SqlCommand(querryString, connection);
            reader = sqlCommand.ExecuteReader();    

            while (reader.Read())
            {
                Cheats += reader.GetValue(0) +"---Cheat Used For---"+reader.GetValue(1)+"\n";
               
            }

            Console.Write(Cheats);
            
            connection.Close();
        }
    }
}
