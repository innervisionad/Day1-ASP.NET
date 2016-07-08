using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using MVCMoviesAC.Models;
using System.Net;

namespace MVCMoviesAC.Controllers
{
    public class HomeController : Controller
    {
        private MoviesAdamEntities db = new MoviesAdamEntities();
         
        // GET: Home
        public ActionResult Index(string movieGenre, string searchString)
        {
            //LINQ query to return all movies from the database
            var movies = from m in db.Movies
                         select m;

            //genre search
            //first put genres into the fenre dropdown list
            var GenreList = new List<string>();
            //LINQ query to retreive genre names from db to populate the genre dropdown list
            var GenreQuery = from g in db.Movies
                             orderby g.Genre
                             select g.Genre;
            //adding genres to the genre list without duplicates
            GenreList.AddRange(GenreQuery.Distinct());
            ViewBag.movieGenre = new SelectList(GenreList);

            //if there is a value in the movieGenre string, then search for that genre
            if(!String.IsNullOrEmpty(movieGenre))
            {
                movies = movies.Where(x => x.Genre == movieGenre);
            }

            //title search
            if(!String.IsNullOrEmpty(searchString))
            {
                movies = movies.Where(s => s.Title.Contains(searchString));
            }
       

            return View(movies);
        }

        public ActionResult Details(int? Id)
        {
            //if the movie id is missing ...
            if(Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //get the movie
            Movie movie = db.Movies.Find(Id);

            //if the movie id wasnt found in the database
            if(movie == null)
            {
                return HttpNotFound();
            }


            return View(movie);
        }



        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create([Bind(Include ="Title, ReleaseDate, Genre, Price")]Movie movie)
        {
            if (ModelState.IsValid)
            {
                //add movie to db
                db.Entry(movie).State = EntityState.Added;
                //save changes to db
                db.SaveChanges();
                //redirect back to index page
                return RedirectToAction("Index");
            }
            return View(movie);
        }


        public ActionResult Edit(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = db.Movies.Find(Id);

            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id, Title, ReleaseDate, Genre, Price")]Movie movie)
        {//using bind to specify fields to be returned protects from overposting attacks
            if (ModelState.IsValid)
            {
                //get the edited data
                db.Entry(movie).State = EntityState.Modified;
                //save changes to the DB
                db.SaveChanges();
                //go back to the Index action method
                return RedirectToAction("Index");
            }
            return View(movie);
           
        }

        [HttpGet]
        public ActionResult Delete(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = db.Movies.Find(Id);

            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }
       [HttpPost, ActionName("Delete")]
       public ActionResult Delete([Bind(Include= "Id")]Movie movie)
        {
            db.Entry(movie).State = EntityState.Deleted;
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        
   
    }
    

}