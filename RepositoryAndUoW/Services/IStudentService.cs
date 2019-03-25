using RepositoryAndUoW.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryAndUoW.Services
{
    public interface IStudentService
    {
        IEnumerable<Student> Get();
        Student GetById(int id);
        void Insert(Student student);
        void Update(Student student);
        void Delete(int id);
    }
}
