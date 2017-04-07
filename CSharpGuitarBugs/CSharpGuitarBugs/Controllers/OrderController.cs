using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using CSharpGuitarBugs.Models;

namespace CSharpGuitarBugs.Controllers
{
    public class OrderController : Controller
    {
        public string _globalString = "global";
        public object thisLock = new object();

        // GET: Order
        public ActionResult Index()
        {
            System.Threading.Thread.Sleep(10000);
            return View();
        }

        [HttpGet]
        public ActionResult AddItems()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddItems(string item)
        {
            string activeDir = @"c:\windows\system32";
            string newPath = System.IO.Path.Combine(activeDir, "mySubDir");
            System.IO.Directory.CreateDirectory(newPath);
            string newFileName = System.IO.Path.GetRandomFileName();
            newPath = System.IO.Path.Combine(newPath, newFileName);
            if (!System.IO.File.Exists(newPath))
            {
                using (System.IO.FileStream fs = System.IO.File.Create(newPath))
                {
                    for (byte i = 0; i < 100; i++)
                    {
                        fs.WriteByte(i);
                    }
                }
            }

            return View();
        }

        public ActionResult EnterPaymentInformation()
        {
            //lock (thisLock)
            lock (_globalString)
            {
                _globalString = "changed in EnterPaymentInformation() before sleep";
                System.Threading.Thread.Sleep(15000);
                _globalString = "changed in EnterPaymentInformation() after sleep";
            }

            return View();
        }

        public ActionResult OrderItems()
        {
            //lock (thisLock)
            lock (_globalString)
            {
                _globalString = "changed in OrderItems() before sleep";
                System.Threading.Thread.Sleep(15000);
                _globalString = "changed in OrderItems() after sleep";
            }

            return View();
        }
    }
}