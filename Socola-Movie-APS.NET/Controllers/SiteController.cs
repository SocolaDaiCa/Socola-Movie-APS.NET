using Socola_Movie_APS.NET.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Socola_Movie_APS.NET.Controllers
{
    public class SiteController : Controller
    {
        private SocolaMovieEntity db = new SocolaMovieEntity();
        public SiteController()
        {
            ViewBag.Categories = db.Categorys.ToList();
        }
    }
}