using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using Microsoft.Data;
using CommonLayer.Models;
namespace DataLayer
{
   public class StudentDataAccessDb
    {
        private DbConnection db = new DbConnection();
        public List<Students> GetStudents()
        {
            string query = "select * from Students";
            SqlCommand command = new SqlCommand();
            command.CommandText = query;
            command.Connection = db.Cnn;
            if (db.Cnn.State == System.Data.ConnectionState.Closed)
                db.Cnn.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<Students> students = new List<Students>();
            while(reader.Read())
            {
                Students stu = new Students();
                stu.Id = (int)reader["id"];
                stu.Name = reader["name"].ToString();
                stu.Email = reader["email"].ToString();
                stu.Gender = reader["gender"].ToString();
                stu.Mobile = reader["mobile"].ToString();
                students.Add(stu);
            }
            db.Cnn.Close();
            return students;
        }
    }
}
