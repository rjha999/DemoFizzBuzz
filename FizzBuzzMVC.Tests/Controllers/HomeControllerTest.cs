using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzzMVC;
using FizzBuzzMVC.Controllers;

namespace FizzBuzzMVC.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Given10Return()
        {
            FizzBuzzController fizz = new FizzBuzzController();
            ViewResult result = fizz.Index(10) as ViewResult;
            string expected="1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz ";
            string actual = result.ViewBag.OutPut;
            Assert.AreEqual(expected, actual);
        }

        
    }
}
