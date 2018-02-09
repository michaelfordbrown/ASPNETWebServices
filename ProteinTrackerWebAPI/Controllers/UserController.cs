using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProteinTrackerWebAPI.Models;

namespace ProteinTrackerWebAPI.Controllers
{
    public class UserController : ApiController
    {
        private UserRepository repository = new UserRepository();

        // /api/user/{id}
        public int Put(int id, [FromBody]int amount)
        {
            var user = repository.GetById(id);
            if (user == null)
                return -1;
            user.Total += amount;
            repository.Save(user);
            return user.Total;
        }

        // /api/user {"Name":"Max","Total":200}
        public int Post([FromBody]CreateUserRequest request)
        {
            var user = new User { Goal = request.Goal, Name = request.Name, Total = 0 };
            repository.Add(user);

            return user.UserId;
        }

        // /api/user
        public IEnumerable<User> Get()
        {
            return new List<User>(repository.GetAll());
        }

        public class CreateUserRequest
        {
            public string Name { get; set; }
            public int Goal { get; set; }
        }
    }
}
