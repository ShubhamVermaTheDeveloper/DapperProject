using Dapper;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

class Program
{
    static void Main()
    {
        string connectionString = "Data Source=practicedbdev.database.windows.net;Initial Catalog=PracticeDatabase;User ID=practicedb;Password=Admin@123";

        using (var connection = new SqlConnection(connectionString))
        {
            connection.Open();

            string sqlQuery = "SELECT * FROM SHUBHAM_STUDENT_CRUD";
            var student = connection.Query<Student>(sqlQuery);

            Console.WriteLine("Id Name     FatherName   MotherName   Gender    DOB      AadharNo");

            foreach (var item in student)
            {
                Console.WriteLine(item.Id + "" + item.Name + "" + item.FatherName + "" + item.MotherName + "" + item.Gender + "" + item.DOB + "" + item.AadharNo);
            }
        }
    }
}

class Student
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string FatherName { get; set; }
    public string MotherName { get; set; }
    public String Gender { get; set; }
    [DataType(DataType.DateTime)]
    public DateTime DOB { get; set; }
    public long AadharNo { get; set; }


   
}



//"ConnectionStrings": {
//    //"DBConn": "Data Source=bicspcore.database.windows.net;Initial Catalog=DemoDB;User ID=BITUser;Password=p@ssbi#word753"
//    "DBConn": "Data Source=practicedbdev.database.windows.net;Initial Catalog=PracticeDatabase;User ID=practicedb;Password=Admin@123"
//  //"DBConn": "Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True"
//}