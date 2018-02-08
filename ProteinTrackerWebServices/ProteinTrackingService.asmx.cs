using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;

namespace ProteinTrackerWebServices
{
    [WebService(Namespace = "localhost")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    [ScriptService]
     public class ProteinTrackingService : System.Web.Services.WebService
    {
        private UserRepository repository = new UserRepository();

        /* Session based code:
        // Inhert and enable Session from WebService
        [WebMethod (Description = "Adds an amount to the total (returns total).", EnableSession = true)] */
        [WebMethod(Description = "Adds an amount to the total (returns total).")]
        public int AddProtein(int userId, int amount)
        {
            /* Session based code:
             * if (Session["user" + userId] == null)
                return -1;
            var user = (User)Session["user" + userId];
            user.Total += amount;
            Session["user" + userId] = user;
            return user.Total;
            */
            // Repository based code:
            var user = repository.GetById(userId);
            if (user == null)
                return -1;
            user.Total += amount;
            repository.Save(user);
            return user.Total;
        }

        /* Session based code:
        [WebMethod (Description = " Add User and their daliy intake of protein (returning user id).", EnableSession = true)] */
        [WebMethod(Description = " Add User and their daliy intake of protein (returning user id).")]
        public int AddUser(string name, int goal)
        {
            /* Session based code:
             var userId = 0;
             if (Session["userId"] != null)
                 userId = (int)Session["userId"];
             Session["user" + userId] = new User {Goal = goal, Name = name, Total = 0, UserId = userId};
             Session["userId"] = userId + 1;
             return userId;
             */
             // Repository based code:
            var user = new User { Goal = goal, Name = name, Total = 0 };
            repository.Add(user);

            return user.UserId;
        }

        /* Session based code:
        [WebMethod(Description = " List Users (returning list of users).", EnableSession = true)] */
        [WebMethod(Description = " List Users (returning list of users).")]
        public List<User> ListUsers()
        {
            /* Sesson based code:
            var users = new List<User>();
            var userId = 0;
            if (Session["userId"] != null)
                userId = (int)Session["userId"];
            for (var i = 0; i < userId; i++)
            {
                users.Add((User)Session["user" + i]);
            }

            return users;
            */
            // Repository based code:
            return new List<User>(repository.GetAll());
        }


    }
}
