using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace CustomersApi
{
    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            HttpConfiguration httpConfiguration = new HttpConfiguration();
            httpConfiguration.Formatters.Remove(httpConfiguration.Formatters.XmlFormatter);            
            WebApiConfig.Register(httpConfiguration);
            appBuilder.UseWebApi(httpConfiguration);         
        }
    }
}