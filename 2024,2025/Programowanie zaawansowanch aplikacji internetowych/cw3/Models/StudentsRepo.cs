using System;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace cw3.Models;

public class StudentsRepo
{
    private readonly string? _connString;

    public StudentsRepo(IConfiguration configuration)
    {
        _connString = configuration.GetConnectionString("MySqlConnection");
    }

    public List<Student> GetStudents(){
        List<Student> students = new List<Student>();
        using MySqlConnection conn = new MySqlConnection(_connString);
        MySqlCommand cmd = conn.CreateCommand();
        cmd.CommandText = "SELECT students.id, students.firstname, students.lastname, groups.id as groupid, groups.name as name FROM students INNER JOIN groups ON students.group_id = groups.id ORDER BY students.id;";
        conn.Open();
        using MySqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read()) {
            Student student = new Student();
            student.Id = reader.GetInt32("id");
            student.Firstname = reader.GetString("firstname");
            student.Lastname = reader.GetString("lastname");
            student.GroupId = reader.GetInt32("groupid");
            student.GroupName = reader.GetString("name");
            students.Add(student);  
        }

        return students;
    }

    public List<Group> GetGroups(){
        List<Group> groups = new List<Group>();
        using MySqlConnection conn = new MySqlConnection(_connString);
        MySqlCommand cmd = conn.CreateCommand();
        cmd.CommandText = "SELECT * FROM groups";
        conn.Open();
        using MySqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read()) {
            Group group = new Group();
            group.Id = reader.GetInt32("id");
            group.Name = reader.GetString("name");
            group.Description = reader.GetString("description");
            group.Teacher = reader.GetString("teacher");
            groups.Add(group);  
        }

        return groups;
    }
}
