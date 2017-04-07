using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CSharpGuitarBugs.Models;

namespace CSharpGuitarBugs.Controllers
{
    public class CatalogController : Controller
    {
        // GET: Catalog
        public ActionResult Index()
        {
            System.Threading.Thread.Sleep(5000);
            return View();
        }

        public ActionResult FullCatalog()
        {
            System.Threading.Thread.Sleep(11000);
            return View();
        }

        public ActionResult ViewByManufacturer()
        {
            GuitarCatalog guitarCatalog = new GuitarCatalog();            
            //Hangs
            var guitarManufacturer = guitarCatalog.GetGuitarCatalogByManufacturer("\"Gibson Fender Charvel Taylor Jackson MartinandCompany Dean Epiphone Takamine");
            return View();
        }

        public ActionResult ViewByColor()
        {
            try
            {
                throw new System.ComponentModel.Win32Exception(5544, "CSharpGuitarBugs Win32 Exception");
            }
            catch (System.ComponentModel.Win32Exception ex)
            {
                ViewData["Exception"] = "This exception was caught in the Win32Exception catch block: " + ex.Message;
                //return View();
            }
            catch (Exception ex)
            {
                ViewData["Exception"] = "This exception was caught in the catch all Exception catch block: " + ex.Message;
                //return View();
            }

            return View();
        }

        public ActionResult ViewByStrings()
        {
            throw new System.Net.WebException("CSharpGuitarBugs View By Strings Win32 Exception");          

            return View();
        }

    }
}