using RepositoryAndUoW.Model;
using RepositoryAndUoW.Services;
using RepositoryAndUoW.UoW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryAndUoW
{
    public class Main
    {
        private IStudentService _service;

        public Main(IStudentService service)
        {
            _service = service;
        }

        public Student GetById(int id)
        {
            return _service.GetById(id);
        }
    }
}
