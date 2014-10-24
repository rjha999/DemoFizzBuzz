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

            List<string> first = new List<string> { "A", "B" };

            Dictionary<int,string> second = new Dictionary<int,string> { {1,"A"}, {2,"B"} };

            var temp= from f in first
                      join s in second on f equals second.Keys

            return View();
        }
	}
}