using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class Test2222Controller : Controller
    {
        // GET: Test2222
        public string Index()
        {
            return "This is my <b>default</b> action...";
        }
        //
        // GET: /HelloWorld/Welcome/
        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}