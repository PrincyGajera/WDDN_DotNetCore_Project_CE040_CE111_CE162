using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCore3.Models
{
    public interface IStudRepo
    {
        Student GetStudent(int Id);
    }
}
