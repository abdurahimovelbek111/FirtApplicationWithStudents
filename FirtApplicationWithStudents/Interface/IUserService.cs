using FirtApplicationWithStudents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirtApplicationWithStudents.Interface
{
    public interface IUserService
    {
        public IList<User> GetUsers();
    }
}
