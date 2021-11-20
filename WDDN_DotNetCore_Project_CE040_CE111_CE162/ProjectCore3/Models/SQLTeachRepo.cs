using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace ProjectCore3.Models
{
    public class SQLTeachRepo: ITeachRepo
    {
        private readonly AppDbContext context;
        public SQLTeachRepo(AppDbContext context)
        {
            this.context = context;
        }
        Teacher ITeachRepo.GetTeacher(int id)
        {
            return context.Teachers.FirstOrDefault(m => m.Id == id);
        }
        Student ITeachRepo.GetStudents(int id)
        {
            return context.Students.FirstOrDefault(m => m.Teacher_id == id);
        }
        Student ITeachRepo.GetStudentMarks(int id)
        {
            return context.Students.FirstOrDefault(m => m.Teacher_id == id);
        }
        Student ITeachRepo.Add(Student student)
        {
            context.Students.Add(student);
            context.SaveChanges();
            return student;
        }
       
        Student ITeachRepo.Update(Student studentChanges)
        {
            var student = context.Students.Attach(studentChanges);
            student.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return studentChanges;
        }
    }
}
