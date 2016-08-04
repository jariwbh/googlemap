using AddressMapSystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddressMapSystem.Core.IServices
{
    public interface IUserService
    {
        void AddUser(User User);
    }
}
