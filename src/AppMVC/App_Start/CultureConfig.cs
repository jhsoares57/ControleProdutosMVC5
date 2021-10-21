using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace AppMVC.App_Start
{
    public class CultureConfig
    {
        public static void RegisterCulture()
        {
            var cultura = new CultureInfo("pt-BR");
            CultureInfo.DefaultThreadCurrentCulture = cultura;
            CultureInfo.CurrentCulture = cultura;
            CultureInfo.CurrentUICulture = cultura;
        }
    }
}