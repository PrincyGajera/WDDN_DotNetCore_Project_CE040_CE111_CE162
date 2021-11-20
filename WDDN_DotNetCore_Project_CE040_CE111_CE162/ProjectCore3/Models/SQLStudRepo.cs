using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCore3.Models
{
    public class SQLStudRepo: IStudRepo
    {
        private readonly AppDbContext context;
        public SQLStudRepo(AppDbContext context)
        {
            this.context = context;
        }
        Student IStudRepo.GetStudent(int id)
        {
            return context.Students.FirstOrDefault(m => m.Id == id);
        }
    }
}
