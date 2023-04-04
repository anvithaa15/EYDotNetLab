using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Owin.Security.OAuth;
using System.Security.Claims;
using System.Threading.Tasks;

namespace TokenAuthenticationWebApi.Models
{
    public class MyAuthorizationServerProvider:OAuthAuthorizationServerProvider
    {
        public override async Task ValidateClientAuthentication
            (OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
        }
        public override async Task GrantResourceOwnerCredentials
            (OAuthGrantResourceOwnerCredentialsContext context)
        {
            using(UserMasterRepository _repo=new UserMasterRepository())
            {
                var user = _repo.ValidateUser(context.UserName, context.Password);
                if (user == null)
                {
                    context.SetError("invalid_grant", "Provided username and password is incorrect");
                    return;
                }
                var identity = new ClaimsIdentity(context.Options.AuthenticationType);

                identity.AddClaim(new Claim(ClaimTypes.Role, user.userRole));
                identity.AddClaim(new Claim(ClaimTypes.Name, user.userName));
                identity.AddClaim(new Claim("email", user.userEmailID));

                context.Validated(identity);
            }
        }
    }
}