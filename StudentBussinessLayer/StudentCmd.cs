using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using StudentDataAccessLayer;
namespace StudentBussinessLayer
{
    public class StudentCmd
    {
        public static List<Student> GetAll()
        {
            string cmd = "select [St_Id],[St_Fname],[St_Lname],[St_Address] from [dbo].[Student]";
            DataTable dt = DBContext.Select(cmd);
            List<Student> list = new List<Student>();
            foreach (DataRow dr in dt.Rows)
            {
                Student student = new Student()
                {
                    Id =int.Parse(dr["St_Id"].ToString()),
                    St_Fname = dr["St_Fname"].ToString(),
                    St_Lname = dr["St_Lname"].ToString(),
                    St_Address = dr["St_Address"].ToString()
                };
                list.Add(student);
            }
            return list;
        }

        public static Student GetById(int id)
        {
            string cmd = $"select [St_Fname],[St_Lname],[St_Address] from [dbo].[Studen] where [St_Id]={id}";
            DataTable dt = DBContext.Select(cmd);
            Student student = new Student()
            {
                Id =int.Parse( dt.Rows[0]["St_Id"].ToString()),
                St_Fname = dt.Rows[0]["St_Fname"].ToString(),
                St_Lname = dt.Rows[0]["St_Lname"].ToString(),
                St_Address = dt.Rows[0]["St_Address"].ToString()
            };
            return student;
        }

        public static int insert(Student student)
        {
            string cmd = "insert into [dbo].[Student]([St_Id],[St_Fname],[St_Lname],[St_Address]) values(@id,@fname,@lname,@address)";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@id",student.Id),
                new SqlParameter("@fname",student.St_Fname),
                new SqlParameter("@lname",student.St_Lname),
                new SqlParameter("address",student.St_Address)
            };
            return DBContext.DMLCommand(cmd,sp);
        }

        public static int update(Student student)
        {
            string cmd = "update [dbo].[Student] set [St_Fname] = @fname, [St_Lname] = @lname,[St_Address] = @address where [St_Id] = @id";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@id",student.Id),
                new SqlParameter("@fname",student.St_Fname),
                new SqlParameter("@lname",student.St_Lname),
                new SqlParameter("address",student.St_Address)
            };
            return DBContext.DMLCommand(cmd, sp);
        }

        public static int delete(int id)
        {
            string command = "delete from [dbo].[Student] where [St_Id] = @id";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@id",id),
            };

            return DBContext.DMLCommand(command, sp);
        }


    }
}
