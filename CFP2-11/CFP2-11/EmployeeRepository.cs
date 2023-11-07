using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CFP2_11;

namespace CFP2_11Ado.NET

{
    public class EmployeeRepository
    {
        //public List<EmployeeModel> createdatabase()
        public void createdatabase()
        {

            SqlConnection sqlConnection;
            string connectionstring = @"Data source=LAPTOP-JDE1S40N\SQLEXPRESS;Initial Catalog=cruddb;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionstring);
            sqlConnection.Open();
            Console.WriteLine("Connection established successfully");
            Console.WriteLine("-----------------");
            Console.WriteLine("select the option below");
            Console.WriteLine("1.creation \n 2.display \n 3.update \n 4.delete");
            Console.WriteLine("enter the choice");
            int choice = int.Parse(Console.ReadLine());


            //crud operations 
            //Inserting data
            switch (choice) {
                case 1:
                    Console.WriteLine("Enter usename");
                    string username = Console.ReadLine();
                    Console.WriteLine("Enter age of user");
                    int Age = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter address of user");
                    string address = Console.ReadLine();
                    string query = "Insert into Details (Name,age,Address) values('" + username + "'," + Age + ",'" + address + "')";
                    SqlCommand cmd = new SqlCommand(query, sqlConnection);
                    cmd.ExecuteNonQuery();
                    break;

                //Reading Data
                case 2:
                    // List<EmployeeModel> list = new List<EmployeeModel>();
                    string display = "select * from Details";
                    SqlCommand cmd1 = new SqlCommand(display, sqlConnection);
                    SqlDataReader reader = cmd1.ExecuteReader();
                    //EmployeeModel emp = new EmployeeModel();
                    while (reader.Read())
                    {
                        Console.WriteLine("Id:" + reader.GetValue(0) + "Name:" + reader.GetValue(1) + "Age:" + reader.GetValue(2) + "Address:" + reader.GetValue(3));
                        //emp = new EmployeeModel();
                        //emp.Id = reader.GetInt32(0);
                        //emp.userName = reader.GetString(1);
                        //emp.Age = reader.GetInt32(2);
                        //emp.address = reader.GetString(3);
                        //list.Add(emp);
                    }

                    reader.Close();
                    break;
                case 3:

                    //Updateing data

                    Console.WriteLine("enter the name of user to update");
                    string username1 = Console.ReadLine();
                    Console.WriteLine("enter the age to be updated");
                    int Age1 = int.Parse(Console.ReadLine());

                    string updatequery = "Update Details set Age= '" + Age1 + "' where name='" + username1 + "'";
                    SqlCommand cmd2 = new SqlCommand(updatequery, sqlConnection);
                    cmd2.ExecuteNonQuery();
                    break;

                //Deleting data
                case 4:
                    Console.WriteLine("enter the user id to delete");
                    int id = int.Parse(Console.ReadLine());
                    string deletequery = "delete from details where user_id= " + id + "";
                    SqlCommand cmd3 = new SqlCommand(deletequery, sqlConnection);
                    cmd3.ExecuteNonQuery();
                    break;
                //return list;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
            sqlConnection.Close();
        }
    }
}
