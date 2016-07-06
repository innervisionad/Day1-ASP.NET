﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCRecords.Models;
namespace MVCRecords.Controllers
{
    public class HomeController : Controller
    {
        List<Album> albums = new List<Album>();
        // GET: Home
        public ActionResult Index()
        {
            Album album1 = new Album("Dark Side of the Moon", "Pink Floyd", "Vinyl", 9.99M);
            albums.Add(album1);

            Album album2 = new Album("Tubular Bells", "Mike Oldfield", "Vinyl", 11.00M);
            albums.Add(album2);

            Album album3 = new Album("Back to Black", "Amy Winehouse", "CD", 7.98M);
            albums.Add(album3);


            return View(albums);
        }
    }
}