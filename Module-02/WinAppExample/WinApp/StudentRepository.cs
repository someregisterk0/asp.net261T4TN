using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace WinApp
{
    class StudentRepository
    {
        readonly static string connectionString = @"Data Source=PM505-03\MSSQLSERVER2014;Initial Catalog=Stores;Integrated Security=True";

        public List<Student> GetStudents()
        {
            IDbConnection connection = new SqlConnection(connectionString);

            IDbCommand command = connection.CreateCommand();
            command.CommandText = "GetStudents";
            // default CommandType.Text;
            command.CommandType = CommandType.StoredProcedure;

            connection.Open();

            IDataReader reader = command.ExecuteReader();
            List<Student> list = new List<Student>();
            while(reader.Read())
            {
                Student obj = new Student()
                {
                    Id = (int)reader["StudentId"],
                    FullName = (string)reader["FullName"],
                    Email = (string)reader["Email"],
                    DateOfBirth = (DateTime)reader["DateOfBirth"],
                    PlaceOfBirth = (string)reader["PlaceOfBirth"],
                    Address = (string)reader["Address"],
                    Phone = (string)reader["Phone"],
                    Gender = (bool)reader["Gender"]
                };
                list.Add(obj);
            }

            reader.Close();
            connection.Close();

            return list;
        }

        public int AddStudent(Student obj)
        {
            IDbConnection connection = new SqlConnection(connectionString);

            IDbCommand command = connection.CreateCommand();
            command.CommandText = "AddStudent";
            command.CommandType = CommandType.StoredProcedure;

            IDataParameter fullnameParameter = command.CreateParameter();
            fullnameParameter.ParameterName = "@FullName";
            fullnameParameter.Value = obj.FullName;
            command.Parameters.Add(fullnameParameter);

            IDataParameter emailParameter = command.CreateParameter();
            emailParameter.ParameterName = "@Email";
            emailParameter.Value = obj.Email;
            command.Parameters.Add(emailParameter);

            IDataParameter dateofbirthParameter = command.CreateParameter();
            dateofbirthParameter.ParameterName = "@DateOfBirth";
            dateofbirthParameter.Value = obj.DateOfBirth;
            command.Parameters.Add(dateofbirthParameter);

            IDataParameter placeofbirthParameter = command.CreateParameter();
            placeofbirthParameter.ParameterName = "@PlaceOfBirth";
            placeofbirthParameter.Value = obj.PlaceOfBirth;
            command.Parameters.Add(placeofbirthParameter);

            IDataParameter addressParameter = command.CreateParameter();
            addressParameter.ParameterName = "@Address";
            addressParameter.Value = obj.Address;
            command.Parameters.Add(addressParameter);

            IDataParameter phoneParameter = command.CreateParameter();
            phoneParameter.ParameterName = "@Phone";
            phoneParameter.Value = obj.Phone;
            command.Parameters.Add(phoneParameter);

            IDataParameter genderParameter = command.CreateParameter();
            genderParameter.ParameterName = "@Gender";
            genderParameter.Value = obj.Gender;
            command.Parameters.Add(genderParameter);

            connection.Open();

            int ret = command.ExecuteNonQuery();

            connection.Close();

            return ret;
        }

        public int DeleteStudent(int id)
        {
            IDbConnection connection = new SqlConnection(connectionString);

            IDbCommand command = connection.CreateCommand();
            command.CommandText = "DeleteStudent";
            command.CommandType = CommandType.StoredProcedure;

            IDataParameter idParameter = command.CreateParameter();
            idParameter.ParameterName = "@Id";
            idParameter.Value = id;
            command.Parameters.Add(idParameter);

            connection.Open();

            int ret = command.ExecuteNonQuery();

            connection.Close();

            return ret;
        }

        public Student GetStudentById(int id)
        {
            IDbConnection connection = new SqlConnection(connectionString);

            IDbCommand command = connection.CreateCommand();
            command.CommandText = "GetStudentById";
            command.CommandType = CommandType.StoredProcedure;

            IDataParameter idParameter = command.CreateParameter();
            idParameter.ParameterName = "@Id";
            idParameter.Value = id;
            command.Parameters.Add(idParameter);

            connection.Open();

            IDataReader reader = command.ExecuteReader();
            Student obj = null;
            if(reader.Read())
            {
                obj = new Student()
                {
                    Id = (int)reader["StudentId"],
                    FullName = (string)reader["FullName"],
                    Email = (string)reader["Email"],
                    DateOfBirth = (DateTime)reader["DateOfBirth"],
                    PlaceOfBirth = (string)reader["PlaceOfBirth"],
                    Address = (string)reader["Address"],
                    Phone = (string)reader["Phone"],
                    Gender = (bool)reader["Gender"]
                };
            }

            reader.Close();
            connection.Close();

            return obj;
        }

        public int EditStudent(Student obj)
        {
            IDbConnection connection = new SqlConnection(connectionString);

            IDbCommand command = connection.CreateCommand();
            command.CommandText = "EditStudent";
            command.CommandType = CommandType.StoredProcedure;

            IDataParameter idParameter = command.CreateParameter();
            idParameter.ParameterName = "@Id";
            idParameter.Value = obj.Id;
            command.Parameters.Add(idParameter);

            IDataParameter fullnameParameter = command.CreateParameter();
            fullnameParameter.ParameterName = "@FullName";
            fullnameParameter.Value = obj.FullName;
            command.Parameters.Add(fullnameParameter);

            IDataParameter emailParameter = command.CreateParameter();
            emailParameter.ParameterName = "@Email";
            emailParameter.Value = obj.Email;
            command.Parameters.Add(emailParameter);

            IDataParameter dateofbirthParameter = command.CreateParameter();
            dateofbirthParameter.ParameterName = "@DateOfBirth";
            dateofbirthParameter.Value = obj.DateOfBirth;
            command.Parameters.Add(dateofbirthParameter);

            IDataParameter placeofbirthParameter = command.CreateParameter();
            placeofbirthParameter.ParameterName = "@PlaceOfBirth";
            placeofbirthParameter.Value = obj.PlaceOfBirth;
            command.Parameters.Add(placeofbirthParameter);

            IDataParameter addressParameter = command.CreateParameter();
            addressParameter.ParameterName = "@Address";
            addressParameter.Value = obj.Address;
            command.Parameters.Add(addressParameter);

            IDataParameter phoneParameter = command.CreateParameter();
            phoneParameter.ParameterName = "@Phone";
            phoneParameter.Value = obj.Phone;
            command.Parameters.Add(phoneParameter);

            IDataParameter genderParameter = command.CreateParameter();
            genderParameter.ParameterName = "@Gender";
            genderParameter.Value = obj.Gender;
            command.Parameters.Add(genderParameter);

            connection.Open();

            int ret = command.ExecuteNonQuery();

            connection.Close();

            return ret;
        }
    }
}
