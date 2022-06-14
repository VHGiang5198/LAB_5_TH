using LAB_5_TH.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LAB_5_TH.Controllers
{
    public class RubikController : Controller
    {
        // GET: Rubik
        RubikStoreDataContext data = new RubikStoreDataContext();
        public ActionResult Index()
        {
            var all_rubik = from s in data.Rubiks select s;
            return View(all_rubik);
        }
    }
}