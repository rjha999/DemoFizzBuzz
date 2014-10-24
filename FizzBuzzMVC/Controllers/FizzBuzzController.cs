using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FizzBuzzMVC.Controllers
{
    public class FizzBuzzController : Controller
    {
        //
        // GET: /FizzBuzz/
        public ActionResult Index(int data)
        {
            for (int i = 1; i<= data; i++)
            {


                if (i % 3 == 0)
                {
                    ViewBag.OutPut += "Fizz ";
                }
                else if (i % 5 == 0)
                {
                    ViewBag.OutPut += "Buzz ";
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    ViewBag.Output += "FizzBuzz ";
                }
                else
                {
                    ViewBag.Output +=i.ToString() + " ";
                }
            }

            return View();
        }
	}
}