using RepositoryAndUoW.Model;
using RepositoryAndUoW.UoW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryAndUoW.Services
{
    public class StudentService : IStudentService
    {
        private UnitOfWork unitOfWork = new UnitOfWork();

        public IEnumerable<Student> Get()
        {
            return unitOfWork.StudentRepository.Get();
        }

        public Student GetById(int id)
        {
            var student = unitOfWork.StudentRepository.GetById(id);

            return student;
        }

        public void Insert(Student student)
        {
            unitOfWork.StudentRepository.Insert(student);
        }

        public void Update(Student student)
        {
            unitOfWork.StudentRepository.Update(student);
        }

        public void Delete(int id)
        {
            unitOfWork.StudentRepository.Delete(id);
        }
    }
}
