using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web.Configuration;

namespace RepeatedValue
{

    public class EmployeeDB
    {
        private string connectionString;

        public EmployeeDB()
        {
            // Получить строку соединения из web.config
            connectionString = WebConfigurationManager.ConnectionStrings["AspNetDB"].ConnectionString;
        }

        public EmployeeDB(string connectionString)
        {
            // Установить указанную строку соединения
            this.connectionString = connectionString;
        }

        public int InsertEmployee(EmployeeDetails emp)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(
                "INSERT INTO Employees (FirstName, LastName, City) OUTPUT INSERTED.EmployeeID VALUES (@FirstName, @LastName, @City)", con);

            cmd.Parameters.Add(new SqlParameter("@FirstName", SqlDbType.NVarChar, 100));
            cmd.Parameters["@FirstName"].Value = emp.FirstName;
            cmd.Parameters.Add(new SqlParameter("@LastName", SqlDbType.NVarChar, 100));
            cmd.Parameters["@LastName"].Value = emp.LastName;
            cmd.Parameters.Add(new SqlParameter("@City", SqlDbType.NVarChar, 100));
            cmd.Parameters["@City"].Value = emp.City;

            try
            {
                con.Open();
                int id = (int)cmd.ExecuteScalar();
                return id;
            }
            catch (SqlException)
            {
                // Замените эту ошибку чем-то более специфичным. 
                // Здесь также можно протоколировать ошибки
                throw new ApplicationException("Ошибка данных");
            }
            finally
            {
                con.Close();
            }
        }

        public void UpdateEmployee(EmployeeDetails emp)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(
                "UPDATE Employees SET FirstName = @FirstName, LastName = @LastName, City = @City WHERE EmployeeID = @EmployeeID",
                con);

            cmd.Parameters.Add(new SqlParameter("@FirstName", SqlDbType.NVarChar, 100));
            cmd.Parameters["@FirstName"].Value = emp.FirstName;
            cmd.Parameters.Add(new SqlParameter("@LastName", SqlDbType.NVarChar, 100));
            cmd.Parameters["@LastName"].Value = emp.LastName;
            cmd.Parameters.Add(new SqlParameter("@City", SqlDbType.NVarChar, 100));
            cmd.Parameters["@City"].Value = emp.City;
            cmd.Parameters.Add(new SqlParameter("@EmployeeID", SqlDbType.Int, 4));
            cmd.Parameters["@EmployeeID"].Value = emp.EmployeeID;

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                throw new ApplicationException("Ошибка данных");
            }
            finally
            {
                con.Close();
            }
        }

        public void UpdateEmployee(int EmployeeID, string firstName, string lastName, string city)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(
                "UPDATE Employees SET FirstName = @FirstName, LastName = @LastName, City = @City WHERE EmployeeID = @EmployeeID",
                con);

            cmd.Parameters.Add(new SqlParameter("@FirstName", SqlDbType.NVarChar, 100));
            cmd.Parameters["@FirstName"].Value = firstName;
            cmd.Parameters.Add(new SqlParameter("@LastName", SqlDbType.NVarChar, 100));
            cmd.Parameters["@LastName"].Value = lastName;
            cmd.Parameters.Add(new SqlParameter("@City", SqlDbType.NVarChar, 100));
            cmd.Parameters["@City"].Value = city;
            cmd.Parameters.Add(new SqlParameter("@EmployeeID", SqlDbType.Int, 4));
            cmd.Parameters["@EmployeeID"].Value = EmployeeID;

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                throw new ApplicationException("Ошибка данных");
            }
            finally
            {
                con.Close();
            }
        }

        public void DeleteEmployee(int employeeID)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("DELETE FROM Employees WHERE EmployeeID = @EmployeeID", con);

            cmd.Parameters.Add(new SqlParameter("@EmployeeID", SqlDbType.Int, 4));
            cmd.Parameters["@EmployeeID"].Value = employeeID;

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                throw new ApplicationException("Ошибка данных");
            }
            finally
            {
                con.Close();
            }
        }

        public void DeleteEmployee(EmployeeDetails emp)
        {
            DeleteEmployee(emp.EmployeeID);
        }

        public EmployeeDetails GetEmployee(int employeeID)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Employees WHERE EmployeeID = @EmployeeID", con);

            cmd.Parameters.Add(new SqlParameter("@EmployeeID", SqlDbType.Int, 4));
            cmd.Parameters["@EmployeeID"].Value = employeeID;

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);

                // Получить новую строку
                reader.Read();
                EmployeeDetails emp = new EmployeeDetails(
                    (int)reader["EmployeeID"], (string)reader["FirstName"],
                    (string)reader["LastName"], (string)reader["City"]);
                reader.Close();
                return emp;
            }
            catch (SqlException)
            {
                throw new ApplicationException("Ошибка данных");
            }
            finally
            {
                con.Close();
            }
        }

        public List<EmployeeDetails> GetEmployees()
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Employees", con);

            // Создать коллекцию для всех записей о сотрудниках
            List<EmployeeDetails> employees = new List<EmployeeDetails>();

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    EmployeeDetails emp = new EmployeeDetails(
                        (int)reader["EmployeeID"], (string)reader["FirstName"],
                        (string)reader["LastName"], (string)reader["City"]);
                    employees.Add(emp);
                }
                reader.Close();

                return employees;
            }
            catch (SqlException)
            {
                throw new ApplicationException("Ошибка данных");
            }
            finally
            {
                con.Close();
            }
        }

        public int CountEmployees()
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT COUNT (EmployeeID) FROM Employees", con);

            try
            {
                con.Open();
                return (int)cmd.ExecuteScalar();
            }
            catch (SqlException)
            {
                throw new ApplicationException("Ошибка данных");
            }
            finally
            {
                con.Close();
            }
        }

    }

    public class EmployeeDetails
    {
        private int employeeID;
        private string firstName;
        private string lastName;
        private string city;

        public int EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public EmployeeDetails(int employeeID, string firstName, string lastName,
            string city)
        {
            this.employeeID = employeeID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.city = city;
        }

        public EmployeeDetails() { }
    }
}
