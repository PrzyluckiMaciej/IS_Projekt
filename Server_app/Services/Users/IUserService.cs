using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Server_app.Entities;
using Server_app.Model;

namespace Server_app.Services.Users
{
    public interface IUserService
    {
        AuthenticationResponse Authenticate(AuthenticationRequest request);
        IEnumerable<User> GetUsers();
        User GetByUsername(string username);
        User GetById(int id);
    }
}
