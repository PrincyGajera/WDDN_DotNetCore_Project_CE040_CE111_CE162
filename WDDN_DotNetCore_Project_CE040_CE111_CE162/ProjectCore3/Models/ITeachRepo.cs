using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCore3.Models
{
    public interface ITeachRepo
    {
        Teacher GetTeacher(int Id);

        Student GetStudents(int Id);

        Student Add(Student Id);
        
        Student Update(Student Id);

        Student GetStudentMarks(int Id);
    }
}
