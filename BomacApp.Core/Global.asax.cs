using AutoMapper;
using BomacApp.Core.MappingProfile;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace BomacApp.Core
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);


            Mapper.Initialize(a =>
            {
                a.AddProfile<SharedMapping>();
                a.AddProfile<StockRecordMapping>();
                a.AddProfile<StockItemMapping>();
                a.AddProfile<PersonMapping>();
                a.AddProfile<UserAccountsMapping>();
            });

            var jsonformatter = GlobalConfiguration.Configuration.Formatters.OfType<JsonMediaTypeFormatter>().First();
            jsonformatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            jsonformatter.SerializerSettings.Converters.Add(new StringEnumConverter());

        }
    }
}
