using MovieManagementApplication.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagementApplication
{
    public static class Constants
    {
        public static user currentUser;

        public static UserType GetUserType()
        {
            switch (currentUser.user_type)
            {
                case "admin":
                    return UserType.Admin;

                case "reviewer":
                    return UserType.Reviewer;

                case "actor":
                    return UserType.Actor;

                default:
                    return UserType.Director;
            }
        }
    }

    public enum UserType
    {
        Admin,
        Reviewer,
        Actor,
        Director
    }

}
