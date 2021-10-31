using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Project.Models.Entity;

namespace MVC_Project.Controllers
{
    public class ColorController : Controller
    {
        // GET: Color
        MvsColorChangeEntities db = new MvsColorChangeEntities();
        public ActionResult Index()
        {
            var numbers = db.TblColors.ToList();

            ViewBag.numbers = numbers;
            return View();
        }
    }
}