using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TokenAuthenticationWebApi.Models
{
    public class UserMasterRepository:IDisposable
    {
        //security_dbentities it is your context class
        security_dbEntities context = new security_dbEntities();

        //this method is used to check and validate the user credentials
        public UserMaster ValidateUser(string username,string password)
        {
            return context.UserMasters.FirstOrDefault(user =>
            user.userName.Equals(username, StringComparison.OrdinalIgnoreCase)
            && user.userPassword == password);
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}