using AddressMapSystem.Core.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AddressMapSystem.Core.Models;
using AddressMapSystem.Core.Data;

namespace AddressMapSystem.Core.Services
{
    public class UserService : IUserService
    {
        private readonly ApplicationCoreDbContext _Context;
        public  UserService(ApplicationCoreDbContext Context)
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
