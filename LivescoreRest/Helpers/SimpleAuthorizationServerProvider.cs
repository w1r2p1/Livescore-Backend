﻿using LivescoreRest.DataLayer.DAL;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace LivescoreRest.Helpers
{
    public class SimpleAuthorizationServerProvider : OAuthAuthorizationServerProvider
    {
        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            
            //context.OwinContext.Request.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });
            context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin", new[] { "http://localhost:8081" }); 
            context.OwinContext.Response.Headers.Add("Access-Control-Allow-Credentials", new[] { "true" }); 
            bool isValidUser = false;

            if (context.UserName == "test" && context.Password == "test")
            {
                isValidUser = true;
            }

            if (!isValidUser)
            {
                context.SetError("invalid_grant", "The user name or password is incorrect.");
                return;
            }

            var identity = new ClaimsIdentity(context.Options.AuthenticationType);
            identity.AddClaim(new Claim("sub", context.UserName));
            identity.AddClaim(new Claim("role", "user"));

            context.Validated(identity);
        }
    }
}