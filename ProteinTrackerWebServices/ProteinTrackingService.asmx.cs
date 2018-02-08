using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;

namespace ProteinTrackerWebServices
{
    [WebService(Namespace = "localhost")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ScriptService]
    [ServiceContract(Namespace= "localhost")]
    public interface IProteinTrackerService
    {
        [WebMethod(Description = "Adds an amount to the total (returns total).")]
        [OperationContract]
        int AddProtein(int userId, int amount);

        [WebMethod(Description = " Add User and their daliy intake of protein (returning user id).")]
        [OperationContract]
        int AddUser(string name, int goal);

        [WebMethod(Description = " List Users (returning list of users).")]
        [OperationContract]
        List<User> ListUsers();
    }

    public class ProteinTrackingService : System.Web.Services.WebService, IProteinTrackerService
    {
        private UserRepository repository = new UserRepository();

        public int AddProtein(int userId, int amount)
        {
            var user = repository.GetById(userId);
            if (user == null)
                return -1;
            user.Total += amount;
            repository.Save(user);
            return user.Total;
        }

        public int AddUser(string name, int goal)
        {
            var user = new User { Goal = goal, Name = name, Total = 0 };
            repository.Add(user);

            return user.UserId;
        }

        public List<User> ListUsers()
        {
            return new List<User>(repository.GetAll());
        }
    }
}
