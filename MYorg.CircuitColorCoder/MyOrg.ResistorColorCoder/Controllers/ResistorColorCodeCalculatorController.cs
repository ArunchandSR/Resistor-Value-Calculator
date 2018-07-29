using MyOrg.CircuitColorCoder.BL.Abstractions;
using MyOrg.ResistorColorCoder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyOrg.ResistorColorCoder.Controllers
{
    public class ResistorColorCodeCalculatorController : Controller
    {
        IResistorValueCalculator ResistorValueCalculator;


        public ResistorColorCodeCalculatorController(IResistorValueCalculator resistorValueCalculator)
        {
            ResistorValueCalculator = resistorValueCalculator;
        }
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CalculateResistorValue(UserSelectedColorCodes userSelectedColorCodes)
        {
               try
                {
                    long calculatedresult = ResistorValueCalculator.CalculateResistorValue(userSelectedColorCodes.BandA, userSelectedColorCodes.BandB,
                    userSelectedColorCodes.BandC, userSelectedColorCodes.BandD);
                    var resulttolerance = ResistorValueCalculator.GetTolerance(userSelectedColorCodes.BandD);
                    return Json(new { Result = $"Result : { calculatedresult } Ωs +/- { resulttolerance } %" }, JsonRequestBehavior.AllowGet);
                }
                catch (Exception)
                {
                    return Json(new { Result = $"Error in Processing Request" }, JsonRequestBehavior.AllowGet);
                }
            
        

        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}