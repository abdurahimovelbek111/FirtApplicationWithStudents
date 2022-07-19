using FirtApplicationWithStudents.Interface;
using FirtApplicationWithStudents.Models;
using System.Collections.Generic;

namespace FirtApplicationWithStudents.Service
{
    public class UserServiceWithMockData : IUserService
    {
        private IList<User> Users;
        public UserServiceWithMockData()
        {
            Users = new List<User>
            {
                new User
               {
                  id = 1,
                  Name = "Xondamir"
               },
               new User
               {
                  id = 2,
                  Name = "Elbek"
               }
            };
        }
        public IList<User> GetUsers()
        {
            return Users;
        }
    }
}
