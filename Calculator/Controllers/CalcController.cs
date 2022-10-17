using Calculator.Models;
using CodingSeb.ExpressionEvaluator;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection.Metadata.Ecma335;
using Z.Expressions;

namespace Calculator.Controllers
{
    public class CalcController : Controller
    {
        public IActionResult Index()
        {
            return View();

        }
        [HttpPost]
        public IActionResult Index(Prop c,string calculate)

        {
        if(calculate=="null")
            {
               
                

            }
            return View(c);
        }
    }
}
