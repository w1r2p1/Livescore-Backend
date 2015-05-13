using Autofac;
using Autofac.Integration.WebApi;
using AutoMapper;
using LivescoreRest;
using LivescoreRest.App_Start;
using LivescoreRest.Helpers;
using LivescoreRest.DataLayer.DAL.Interface;
using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OAuth;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using LivescoreRest.ServiceLayer.Service.Interface;

[assembly: OwinStartup(typeof(AngularJSAuthentication.API.Startup))]
namespace AngularJSAuthentication.API
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureOAuth(app);
            AutomapperConfiguration.Configure();
            Mapper.AssertConfigurationIsValid();
            var builder = new ContainerBuilder();

            HttpConfiguration config = new HttpConfiguration();
            config.Filters.Add(new AuthorizeAttribute());
            app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);
            WebApiConfig.Register(config);

            
            AutofacSetup.RegisterDependencies(ref builder);
            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);

            app.UseAutofacMiddleware(container);
            app.UseAutofacWebApi(config);
            app.UseWebApi(config);

            
        }

        

        public void ConfigureOAuth(IAppBuilder app)
        {
            OAuthAuthorizationServerOptions OAuthServerOptions = new OAuthAuthorizationServerOptions()
            {
                AllowInsecureHttp = true,
                TokenEndpointPath = new PathString("/token"),
                AccessTokenExpireTimeSpan = TimeSpan.FromDays(1),
                Provider = new SimpleAuthorizationServerProvider()
            };

            // Token Generation
            app.UseOAuthAuthorizationServer(OAuthServerOptions);
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());

        }

    }
}