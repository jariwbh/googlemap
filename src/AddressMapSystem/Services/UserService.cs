using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AddressMapSystem.Models;
using AddressMapSystem.Data;

namespace AddressMapSystem.Services
{
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext _Context;
        public UserService(ApplicationDbContext Context)
        {
            _Context = Context;
        }
        public void AddUser(User User)
        {
            _Context.User.Add(User);
            _Context.SaveChanges();
        }
    }
}
