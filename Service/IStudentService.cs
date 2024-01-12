using StudentDatabase.Models;

namespace StudentDatabase.Service;

    public interface IStudentService
    {
        List<Student> AddStudent(string firstName, string lastName, string hobby);

        List<Student> GetStudents();

        List<Student> DeleteStudent(string firstName);
        
    }
