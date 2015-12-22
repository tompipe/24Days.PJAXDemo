using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Web.Mvc;

namespace PjaxDemo.App_Code
{
    public abstract class PjaxTemplatePage : UmbracoTemplatePage
    {
        public bool IsPjaxRequest
        {
            get
            {
                return Request.Headers["X-Requested-With"] == "XMLHttpRequest" && Request.QueryString["pjax"] == "true";
            }
        }

        public string TrySwitchToPjaxLayout(string fallback)
        {
            return IsPjaxRequest ? "~/Views/Shared/_PjaxLayout.cshtml" : fallback;
        }
    }
}
