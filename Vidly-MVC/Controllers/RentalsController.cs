using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly_MVC.Models;

namespace Vidly_MVC.Controllers
{
    public class RentalsController : Controller
    {
        
        [Authorize(Roles = RoleName.CanManageMovies)]
        public ActionResult New()
        {


            return View();
        }
    }
}