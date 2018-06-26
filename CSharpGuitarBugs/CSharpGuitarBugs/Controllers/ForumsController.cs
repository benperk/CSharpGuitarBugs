using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CSharpGuitarBugs.Controllers
{
    public class ForumsController : Controller
    {
        // GET: Forums
        public ActionResult Index()
        {
            System.Threading.Thread.Sleep(15000);            
            return View();
        }

        [HttpGet]
        public ActionResult Feedback()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Feedback(string item)
        {
            //This loop will kill the process over an over again until Rapid Protection kicks in and will not start it back up
            //foreach (var process in System.Diagnostics.Process.GetProcessesByName("w3wp"))
            //{
            //    process.Kill();
            //}

            //this requires that only 1 W3WP process is running on the IIS server, if there are more, it is no certain that 
            //it will kill the CSharpGuitarBugs process
            var process = System.Diagnostics.Process.GetProcessesByName("w3wp");
            process[0].Kill();

            return View();
        }

        public ActionResult RateProduct()
        {
            Models.ForumsMemoryConsumptionBigListOfGuitars memoryConsumptionBigListOfGuitarsClass = new Models.ForumsMemoryConsumptionBigListOfGuitars()
            { memoryConsumptionBigListOfGuitars = String.Empty };

            try
            {
                var memoryConsumptionFilePath = Server.MapPath("~/Content/ListOfGuitars.txt");
                string memoryConsumptionListOfGuitars = System.IO.File.ReadAllText(memoryConsumptionFilePath);                

                //make it consume 155MB, file is 5MB (5 + 10 + 20 + 40 + 80)
                for (int i = 0; i < 6; i++)
                {
                    memoryConsumptionBigListOfGuitarsClass.memoryConsumptionBigListOfGuitars += memoryConsumptionListOfGuitars;
                    System.Threading.Thread.Sleep(5000);
                }
            }
            catch(Exception ex)
            {
                return View($"Error: {ex.Message}");
            }

            System.Threading.Thread.Sleep(5000);
            return View(memoryConsumptionBigListOfGuitarsClass);
        }

        [HttpGet]
        public ActionResult FAQ()
        {
            decimal percentage = 0, number = 1000, total = 0;

            try
            {
                percentage = number / total;
                ViewBag.Message = "You will never see this one.";
            }
            catch (DivideByZeroException divEx)
            {
                ViewBag.Message = $"A handled exception just happened: -> {divEx.Message.ToString()}";
            }
            return View();
        }

        [HttpPost]
        public ActionResult FAQ(string item)
        {
            decimal percentage = 0, number = 1000, total = 0;
            percentage = number / total;
            ViewBag.Message = $"KABOOOOOOOOM!! -> {percentage.ToString()}";

            return View();
        }
    }
}