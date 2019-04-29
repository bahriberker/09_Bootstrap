using _09_Bootstrap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _09_Bootstrap.Library;

namespace _09_Bootstrap.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult homepage()
        {
            return View();
        }

        public ActionResult homepage2()
        {
            return View();
        }

        public ActionResult homepage3()
        {
            return View();
        }
        public ActionResult index()
        {
            List<Message> messages = new List<Message>();
            messages.Add(new Message() { Level = 1, Text = "Ipsum gravida vel pretium " });
            messages.Add(new Message() { Level = 2, Text = "luctus placerat scelerisque euismod " });
            messages.Add(new Message() { Level = 3, Text = "iaculis eu lacus nunc mi elit" });
            messages.Add(new Message() { Level = 4, Text = "scelerisque euismod, iaculis e" });

            return View(messages);
        }
    }
}