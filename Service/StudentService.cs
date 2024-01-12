
using API_Database.Data;
using StudentDatabase.Models;

namespace StudentDatabase.Service;

    public class StudentService : IStudentService
    {
        private readonly DataContext _db;

        public List<string> studentList = new();

        public StudentService(DataContext db)
    {
        _db = db;
    }

    public List<Student> AddStudent(string firstName, string lastName, string hobby)
    {
        Student newStudent = new Student();
        newStudent.firstName = firstName;
        newStudent.lastName = lastName;
        newStudent.hobby = hobby;

        _db.Students.Add(newStudent);
        _db.SaveChanges();

        return _db.Students.ToList();
    }

    public List<Student> GetStudents()
    {
        return _db.Students.ToList();
    }

    public List<Student> DeleteStudent(string firstName)
    {
        var student = _db.Students.FirstOrDefault(removeStudent => removeStudent.firstName == firstName);
        if(student != null){
            _db.Students.Remove(student);
            _db.SaveChanges();
        }
        return _db.Students.ToList();
    }
    }
