using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace DareZameen_Web.Models
{
    public class WebRoleProvider : RoleProvider
    {
        public RealStateDataEntities dbContext = new RealStateDataEntities();
        public override string ApplicationName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        public override string[] GetAllRoles()
        {
            var User = dbContext.UserRoles.Select(x => x.Role).Distinct().ToArray();
            return User;
        }

        public override string[] GetRolesForUser(string userId)
        {
            var User = dbContext.UserRoles.Where(x => x.UserId == userId).Select(x => x.Role).ToArray();
            return User;
        }

        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool IsUserInRole(string userId, string roleName)
        {
            var result = false;
            if (userId != null)
            {
               var userRoles = dbContext.UserRoles.Where(x=>x.UserId == userId).ToArray();
                foreach (var role in userRoles)
                {
                    if (role.Role == roleName)
                    {
                        result = true;
                        return result;
                    }
                }
            }
            return result;
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }
    }
}