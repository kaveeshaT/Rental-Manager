using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Product_Rental.Models;

namespace Product_Rental.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Batman" };
            return View(movie);
        }

        [Route("movie/released/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1,12)}")]

        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year +"/" + month);
        }
       
    }
}