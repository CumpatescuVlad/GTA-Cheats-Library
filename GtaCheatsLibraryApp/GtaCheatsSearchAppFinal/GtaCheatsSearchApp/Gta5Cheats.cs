using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GtaCheatsSearchApp
{
    public partial class Gta5Cheats : UserControl
    {
        public Gta5Cheats()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog =GTA;User ID =Vlad;Password=123;
                                      Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;
                                      ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            SqlCommand command;
            SqlDataReader reader;

            string querryString = $"Select Cheats,Action from GTA5Cheats Where Action='{textBox1.Text}'";
            
            string cheat = "";
           
            command = new SqlCommand(querryString, connection);
            
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                cheat += reader.GetValue(0) + "---Cheat Used For---" + reader.GetValue(1) + "\n";
               
            }
            textBox1.Text=cheat;
            connection.Close();
        }
    }
}
