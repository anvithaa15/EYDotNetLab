using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Microsoft.Owin.Security.OAuth;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using TokenAuthenticationWebApi.Models;
using System.Web.Http;

[assembly: OwinStartup(typeof(TokenAuthenticationWebApi.Startup1))]

namespace TokenAuthenticationWebApi
{
    public class Startup1
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
            //Enable CORS for making request using browser from diff domains.
            app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);

            OAuthAuthorizationServerOptions options = new OAuthAuthorizationServerOptions
            {
                AllowInsecureHttp = true,

                //the path for generating token
                TokenEndpointPath = new PathString("/token"),

                //setting token expored time(24 hrs)
                AccessTokenExpireTimeSpan = TimeSpan.FromDays(1),

                //MyAuthorizationServerProvider class will validate the user credentials
                Provider = new MyAuthorizationServerProvider()
            };
            //token generations
            app.UseOAuthAuthorizationServer(options);
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());

            HttpConfiguration config = new HttpConfiguration();
            WebApiConfig.Register(config);
        }
    }
}
