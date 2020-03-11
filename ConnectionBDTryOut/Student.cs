using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ConnectionBDTryOut
{
    class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private string connectionStr = "Server=INSTRUCTORIT;Database=IBTCollege;User Id=ProfileUser;Password=ProfileUser2019";

        public Student(){}

        public List<string> ListOfStudent()
        {
            List<string> students = new List<string>();

            using (SqlConnection conn = new SqlConnection(connectionStr))
            {
                string sql = "SELECT Id, firstName, lastName FROM Students";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    students.Add(reader["id"] + " - " + reader["firstName"] + " " + reader["lastName"]);
                }
                reader.Close();
            }
            return students;
        }

        public Student getStudent(int id)
        {
            Student student = new Student();
            using (SqlConnection conn = new SqlConnection(connectionStr))
            {
                string sql = "SELECT Id, firstName, lastName FROM Students WHERE Id=" + id;
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    student.Id = int.Parse(dt.Rows[0]["Id"].ToString());
                    student.FirstName = dt.Rows[0]["firstName"].ToString();
                    student.LastName = dt.Rows[0]["lastName"].ToString();
                }

            }
            return student;
        }

        public bool DeleteStudent(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionStr))
            {
                conn.Open();
                string sql = "DELETE FROM Students WHERE id = " + id;
                SqlCommand cmd = new SqlCommand(sql, conn);
                if(cmd.ExecuteNonQuery() != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool UpdateStudent(Student student)
        {
            using (SqlConnection conn = new SqlConnection(connectionStr))
            {
                conn.Open();
                string sql = "UPDATE Students SET " +
                    "firstName = '" + student.FirstName + "'," +
                    "lastName = '" + student.LastName + "' " +
                    "WHERE id = " + student.Id;
                SqlCommand cmd = new SqlCommand(sql, conn);
                if (cmd.ExecuteNonQuery() != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool InsertStudent(Student student)
        {
            using (SqlConnection conn = new SqlConnection(connectionStr))
            {

                conn.Open();
                string sql = "INSERT INTO Students (firstName, lastName) VALUES(" +
                    "'" + student.FirstName + "'," +
                    "'" + student.LastName + "')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                if (cmd.ExecuteNonQuery() != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

    }
}
