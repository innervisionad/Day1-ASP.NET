using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using MVCMoviesAC.Models;

namespace MVCMoviesAC.Controllers
{
    public class HomeController : Controller
    {
        private MoviesAdamEntities db = new MoviesAdamEntities();
         
        // GET: Home
        public ActionResult Index()
        {
            //LINQ query to return all movies from the database
            var movies = from m in db.Movies
                         select m;

            return View(movies);
        }

        public ActionResult Details(int? Id)
        {
            Movie movie = db.Movies.Find(Id);
            return View(movie);
        }

        public ActionResult Edit(int? Id)
        {
            Movie movie = db.Movies.Find(Id);
            return View(movie);
        }
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id, Title, ReleaseDate, Genre, Price")]Movie movie)
        {//using bind to specify fields to be returned protects from overposting attacks

            //get the edited data
            db.Entry(movie).State = EntityState.Modified;
            //save changes to the DB
            db.SaveChanges();
            //go back to the Index action method
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int? Id)
        {
            Movie movie = db.Movies.Find(Id);
            return View(movie);
        }
       [HttpPost]
       public ActionResult Delete([Bind(Include= "Id")]Movie movie)
        {
            db.Entry(movie).State = EntityState.Deleted;
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
    

}