using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace inheritnve_adatbazi
{
    class dtbasehandler
    {
        MySqlConnection connection;
        public dtbasehandler()
        {
            string username = "root";
            string password = "";
            string host = "localhost";
            string dbName = "trabant";

            string connectionstring = $"username={username};password={password};host={host};database={dbName}";

            connection = new MySqlConnection(connectionstring);
        }
        public void readAll()
        {
            try
            {
                connection.Open();
                string query = "SELECT * from cars";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader read = command.ExecuteReader();
                while (read.Read())
                {
                    int id = read.GetInt32(read.GetOrdinal("id"));
                    string make = read.GetString(read.GetOrdinal("make"));
                    string model = read.GetString(read.GetOrdinal("model"));
                    string color = read.GetString(read.GetOrdinal("color"));
                    int year = read.GetInt32(read.GetOrdinal("year"));
                    int power = read.GetInt32(read.GetOrdinal("power"));

                    car oneCar = new car();

                    oneCar.id = id;
                    oneCar.make = make;
                    oneCar.model = model;
                    oneCar.color = color;
                    oneCar.year = year;
                    oneCar.hp = power;

                    car.cars.Add(oneCar);   

                }
                read.Close();
                command.Dispose();
                connection.Close();
                MessageBox.Show("siker");


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error:");
                
            }
        }
    }
}
