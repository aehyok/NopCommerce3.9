using Nop.Web.Framework.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Nop.Plugin.Test.Demo.Controllers
{
    public class TestController: BasePluginController
    {

        public ActionResult Index()
        {
            return View("~/Plugins/Test.Demo/Views/Test/Index.cshtml");
        }
    }
}
