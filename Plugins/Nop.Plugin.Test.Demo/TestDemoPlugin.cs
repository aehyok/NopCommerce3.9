using Nop.Core.Plugins;
using Nop.Services.Discounts;
using Nop.Services.Localization;
using Nop.Services.Logging;
using Nop.Web.Framework.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Routing;

namespace Nop.Plugin.Test.Demo
{
    public class TestDemoPlugin : BasePlugin, IAdminMenuPlugin
    {
        private readonly ILogger _logger;
        public TestDemoPlugin(ILogger logger)
        {
            _logger = logger;
        }


        public override void Install()
        {
            this.AddOrUpdatePluginLocaleResource("Plugins.Test.Demo", "Required Test Demo");
            base.Install();
        }

        public void ManageSiteMap(SiteMapNode rootNode)
        {
            var menuItem = new SiteMapNode()
            {
                SystemName = "TestDemo",
                Title = "TestDemo",
                ControllerName = "Test",
                ActionName = "Index",
                Visible = true,
                RouteValues = new RouteValueDictionary() { { "area", null } },
                IconClass= "fa-dot-circle-o"
            };

            var pluginNode = rootNode.ChildNodes.FirstOrDefault(x => x.SystemName == "Help");
            if (pluginNode != null)
                pluginNode.ChildNodes.Add(menuItem);
            else
                rootNode.ChildNodes.Add(menuItem);
        }

        public override void Uninstall()
        {
            base.Uninstall();
        }
    }
}
