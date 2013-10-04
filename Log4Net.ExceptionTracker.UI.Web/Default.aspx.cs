using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Log4Net.ExceptionTracker.UI.Web
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            log4net.Config.BasicConfigurator.Configure();
            log4net.ILog log = log4net.LogManager.GetLogger(typeof(_Default));

            log.Debug("Debug message");
            log.Info("Info message");
            log.Warn("Warning message");
            log.Error("Error message");
            log.Fatal("Fatal message");

            log4net.LogManager.Shutdown();


        }
    }
}