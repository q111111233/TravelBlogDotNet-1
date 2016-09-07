using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TravelBlogDotNet.Models;

namespace ToDoList.Controllers
{
    public class ItemsController : Controller
    {
        private WorldTravelContext db = new WorldTravelContext();
        public IActionResult Index()
        {
            return View(db.Experiences.Include(items => items.Location).ToList());
        }
        public IActionResult Details(int id)
        {
            var thisItem = db.Experiences.FirstOrDefault(items => items.ExperienceId == id);
            return View(thisItem);
        }
        public ActionResult Create()
        {
            ViewBag.LocationId = new SelectList(db.Locations, "LocationId", "Name");
            return View();
        }
        [HttpPost]
        public ActionResult Create(Experience item)
        {
            db.Experiences.Add(item);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            var thisItem = db.Experiences.FirstOrDefault(items => items.ExperienceId == id);
            ViewBag.LocationId = new SelectList(db.Locations, "LocationId", "Name");
            return View(thisItem);
        }
        [HttpPost]
        public ActionResult Edit(Experience item)
        {
            db.Entry(item).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            var thisItem = db.Experiences.FirstOrDefault(items => items.ExperienceId == id);
            return View(thisItem);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var thisItem = db.Experiences.FirstOrDefault(items => items.ExperienceId == id);
            db.Experiences.Remove(thisItem);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}