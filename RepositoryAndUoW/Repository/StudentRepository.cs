using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryAndUoW.Model;
using RepositoryAndUoW.Context;
using System.Data.Entity;

namespace RepositoryAndUoW.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private SchoolContext context;
        private bool disposed = false;

        public StudentRepository(SchoolContext context)
        {
            this.context = context;
        }

        public void DeleteStudent(int studentID)
        {
            Student student = GetStudentByID(studentID);
            context.Students.Remove(student);
        }        

        public Student GetStudentByID(int studentId)
        {
            return context.Students.Find(studentId);
        }

        public IEnumerable<Student> GetStudents()
        {
            return context.Students.ToList();
        }

        public void InsertStudent(Student student)
        {
            context.Students.Add(student);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void UpdateStudent(Student student)
        {
            context.Entry(student).State = EntityState.Modified;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
