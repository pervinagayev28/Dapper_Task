







using ConsoleApp1.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;



namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-47DGCU6\\SQL;Initial Catalog=Library;User ID=MySql;Password=pervina9266_1;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

            //--------------------------------------------------------- Inserts --------------------------------------------------------------------------------------
            //var insertParameters = new { Id = 17, FirstName = "pervin", LastName = "agayev" };
            //string insertQuery = "INSERT INTO authors values(@Id, @FirstName, @LastName)";
            //connection.Execute(insertQuery, insertParameters);

            //var insertParameters = new { Id = 100, Name = "categ1"};
            //string insertQuery = "INSERT INTO Categories values(@Id, @Name)";
            //connection.Execute(insertQuery, insertParameters);

            //var insertParameters = new { Id = 100, Name = "dep1"};
            //string insertQuery = "INSERT INTO Departments values(@Id, @Name)";
            //connection.Execute(insertQuery, insertParameters);

            //var insertParameters = new { Id = 100, Name = "Fac1"};
            //string insertQuery = "INSERT INTO Faculties values(@Id, @Name)";
            //connection.Execute(insertQuery, insertParameters);

            //var insertParameters = new { Id = 100, Name = "Group1",IdFaculity = 1};
            //string insertQuery = "INSERT INTO Faculties values(@Id, @Name,@IdFaculity)";
            //connection.Execute(insertQuery, insertParameters);

            //var insertParameters = new { Id = 17, FirstName = "lib", LastName = "agayev" };
            //string insertQuery = "INSERT INTO Libs values(@Id, @FirstName, @LastName)";
            //connection.Execute(insertQuery, insertParameters);

            //var insertParameters = new { Id = 100, Name = "Press1"};
            //string insertQuery = "INSERT INTO Press values(@Id, @Name)";
            //connection.Execute(insertQuery, insertParameters);

            //var insertParameters = new { Id = 100, Name = "Theme1"};
            //string insertQuery = "INSERT INTO Themes values(@Id, @Name)";
            //connection.Execute(insertQuery, insertParameters);

            //var insertParameters = new { Id = 100, Name = "Group1",IdGroup = 1,Term = 2};
            //string insertQuery = "INSERT INTO Students values(@Id, @Name,@IdGroup,@Term)";
            //connection.Execute(insertQuery, insertParameters);

            //--------------------------------------------------------- Updates --------------------------------------------------------------------------------------
            //var insertParameters = new { Id = 17, FirstName = "pervin" };
            //string insertQuery = "update  authors set FirstName =  @FirstName where Id = @Id)";
            //connection.Execute(insertQuery, insertParameters);

            //var insertParameters = new { Id = 17, Name = "pervin" };
            //string insertQuery = "update  Categories set Name =  @Name where Id = @Id)";
            //connection.Execute(insertQuery, insertParameters);

            //var insertParameters = new { Id = 17, Name = "pervin" };
            //string insertQuery = "update  Departments set Name =  @Name where Id = @Id)";
            //connection.Execute(insertQuery, insertParameters);


            //var insertParameters = new { Id = 17, Name = "pervin" };
            //string insertQuery = "update  Faculties set Name =  @Name where Id = @Id)";
            //connection.Execute(insertQuery, insertParameters);

            //var insertParameters = new { Id = 100, Name = "Group1"};
            //string insertQuery = "update  Groups set Name = @Name where Id = @Id)";
            //connection.Execute(insertQuery, insertParameters);

            //var insertParameters = new { Id = 100, FirstName = "Group1"};
            //string insertQuery = "update  Libs set FirstName = @FirstName where Id = @Id)";
            //connection.Execute(insertQuery, insertParameters);

            //var insertParameters = new { Id = 100, Name = "Group1"};
            //string insertQuery = "update  Press set Name = @Name where Id = @Id)";
            //connection.Execute(insertQuery, insertParameters);

            //var insertParameters = new { Id = 100, Name = "Group1"};
            //string insertQuery = "update  Themes set Name = @Name where Id = @Id)";
            //connection.Execute(insertQuery, insertParameters);

            //var insertParameters = new { Id = 100, Name = "Group1"};
            //string insertQuery = "update  Students set Name = @Name where Id = @Id)";
            //connection.Execute(insertQuery, insertParameters);

            //--------------------------------------------------------- Deletes --------------------------------------------------------------------------------------
            //var insertParameters = new { Id = 17};
            //string insertQuery = "delete from authors where Id = @Id)";
            //connection.Execute(insertQuery, insertParameters);

            //var insertParameters = new { Id = 17};
            //string insertQuery = "delete from Categories where Id = @Id)";
            //connection.Execute(insertQuery, insertParameters);

            //var insertParameters = new { Id = 17};
            //string insertQuery = "delete from Departments where Id = @Id)";
            //connection.Execute(insertQuery, insertParameters);

            //var insertParameters = new { Id = 17};
            //string insertQuery = "delete from Faculties where Id = @Id)";
            //connection.Execute(insertQuery, insertParameters);

            //var insertParameters = new { Id = 17};
            //string insertQuery = "delete from Groups where Id = @Id)";
            //connection.Execute(insertQuery, insertParameters);

            //var insertParameters = new { Id = 17};
            //string insertQuery = "delete from Libs where Id = @Id)";
            //connection.Execute(insertQuery, insertParameters);

            //var insertParameters = new { Id = 17};
            //string insertQuery = "delete from Press where Id = @Id)";
            //connection.Execute(insertQuery, insertParameters);

            //var insertParameters = new { Id = 17};
            //string insertQuery = "delete from Themes where Id = @Id)";
            //connection.Execute(insertQuery, insertParameters);

            //var insertParameters = new { Id = 17};
            //string insertQuery = "delete from Students where Id = @Id)";
            //connection.Execute(insertQuery, insertParameters);

            //--------------------------------------------------------- Updates --------------------------------------------------------------------------------------

            //string selectQuery = "select * from authors";
            //connection.Query<Author>(selectQuery);

            //string selectQuery = "select * from Categories";
            //connection.Query<Categories>(selectQuery);

            //string selectQuery = "select * from Departments";
            //connection.Query<Departments>(selectQuery);

            //string selectQuery = "select * from Faculties";
            //connection.Query<Faculties>(selectQuery);

            //string selectQuery = "select * from Groups";
            //connection.Query<Groups>(selectQuery);

            //string selectQuery = "select * from Libs";
            //connection.Query<Libs>(selectQuery);

            //string selectQuery = "select * from Press";
            //connection.Query<Press>(selectQuery);

            //string selectQuery = "select * from Themes";
            //connection.Query<Themes>(selectQuery);

            //string selectQuery = "select * from Students";
            //connection.Query<Students>(selectQuery);

        }
    }
}