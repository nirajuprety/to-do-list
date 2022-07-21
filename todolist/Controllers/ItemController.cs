using Microsoft.AspNetCore.Mvc;
using System.Linq;
using todolist.Models;

namespace todolist.Controllers
{
    public class ItemController : Controller
    {
        public DatabaseContextList _context;

        public ItemController(DatabaseContextList context)
        {
            _context = context;
        }
        public IActionResult Create()
        {
            return View();
        }
        //Model Binding
        [HttpPost]
        public IActionResult Create(Items i)
        {
            if (ModelState.IsValid)
            {
                var it = new Items()
                {
                    Id = i.Id,
                    ItemTitle = i.ItemTitle,
                    ItemTag = i.ItemTag,
                    ItemDescription = i.ItemDescription

                };
                //insert into database table
                //can add other database from the database context
                _context.items.Add(it);
                //for commiting changes 
                _context.SaveChanges();
                TempData["msg"] = "Saved successfully";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["error"] = "Not Valid";
                return View();
            }
        }
        public IActionResult Index()
        {
            var todotask = _context.items.ToList();
            return View(todotask);
        }

        public IActionResult Done(int id)
        {
            var it = _context.items.SingleOrDefault(i => i.Id == id);
            _context.items.Remove(it);
            _context.SaveChanges();
            TempData["msg"] = "Successfully Removed";
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var i = _context.items.SingleOrDefault(it => it.Id == id);
            return View(i);
        }
        [HttpPost]
        public IActionResult Edit(Items i)
        {
            if (ModelState.IsValid)
            {
                _context.items.Update(i);
                _context.SaveChanges();
                TempData["msg"] = "Updated Successfully";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["error"] = "Error Occured";
                return View();
            }

        }
    }
}
