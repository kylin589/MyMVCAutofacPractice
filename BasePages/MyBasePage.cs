using MyMVCAutofac.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMVCAutofacPractice.BasePages
{
    public class MyBasePage : WebViewPage
    {

        public ISqlRepository rep { get; set; }

        public override void Execute()
        {
            throw new NotImplementedException();
        }
    }
}