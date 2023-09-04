using Exam_ALLIANCE.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_ALLIANCE.WorkDB;
internal class DBWorking
{

    public  List<Department> GetAllDepartment()
    {
        List<Department> departments = new List<Department>();
        string connectionString = "Server=LAPTOP-PV86VKQR\\SQLEXPRESS;Database=QuanLyNhanSu;user id=sa;password=112233;trusted_connection=true;encrypt=false";
        using (SqlConnection connection = new SqlConnection(connectionString))
        using (SqlCommand command = connection.CreateCommand())
        {
            command.CommandText = "SELECT * FROM Department";
            connection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var department = new Department
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("id")),
                        Name = reader.GetString(reader.GetOrdinal("name"))
                    };
                    departments.Add(department);

                }
            }
        }
        return departments;
    }


    public  Department GetDepartment(int id)
    {
        var department = new Department();
        string connectionString = "Server=LAPTOP-PV86VKQR\\SQLEXPRESS;Database=QuanLyNhanSu;user id=sa;password=112233;trusted_connection=true;encrypt=false";
        using (SqlConnection connection = new SqlConnection(connectionString))
        using (SqlCommand command = connection.CreateCommand())
        {
            command.CommandText = "SELECT * FROM Department";
            connection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    department = new Department
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("id")),
                        Name = reader.GetString(reader.GetOrdinal("name"))
                    };


                }
            }
        }
        return department;
    }

    public  List<Staff> GetStaff()
    {
        List<Staff> staffs = new List<Staff>();
        string connectionString = "Server=LAPTOP-PV86VKQR\\SQLEXPRESS;Database=QuanLyNhanSu;user id=sa;password=112233;trusted_connection=true;encrypt=false";
        using (SqlConnection connection = new SqlConnection(connectionString))
        using (SqlCommand command = connection.CreateCommand())
        {
            command.CommandText = "SELECT * FROM Employee";
            connection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {

                    Staff staff = new Staff
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("id")),
                        Name = reader.GetString(reader.GetOrdinal("name")),
                        DepartmentId = reader.GetInt32(reader.GetOrdinal("department_id"))
                    };

                    staffs.Add(staff);

                }
            }
        }
        return staffs;
    }
}
