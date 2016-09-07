﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TravelBlogDotNet.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace TravelBlogDotNet.Controllers
{
    public class ExperiencesController : Controller
    {
        // GET: /<controller>/
        private WorldTravelContext db = new WorldTravelContext();
        public IActionResult Index()
        {
            return View(db.Experiences.ToList());
        }
    }
}
