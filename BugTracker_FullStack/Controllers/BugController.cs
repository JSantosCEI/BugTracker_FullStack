using Microsoft.AspNetCore.Mvc;
using BugTracker_FullStack.Models;
using BugTracker_FullStack.Data;

namespace BugTracker_FullStack.Controllers
{
    public class BugController : Controller
    {
        private readonly BTContext _bTContext;

        public BugController(BTContext bTContext)
        {
            _bTContext = bTContext;
        }

        public IActionResult Index()
        {
            IEnumerable<Bug> bugList = _bTContext.Bugs;
            return View(bugList);
        }

        public IActionResult Create()
        {
            return View();
        }
         
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Bug bug)
        {
            if (ModelState.IsValid)
            {
                _bTContext.Bugs.Add(bug);
                _bTContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bug);
        }

        [Route("Bug/{id:int}")]
        public IActionResult Detail(int id)
        {
            Bug thisBug = _bTContext.Bugs.First(x => x.BugId == id);
            return View(thisBug);
        }

        [Route("Bug/Edit/{id:int}")]
        public IActionResult Edit(int id)
        {
            Bug thisBug = _bTContext.Bugs.First(x => x.BugId == id);
            return View(thisBug);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditPOST(Bug bug)
        {
            if (ModelState.IsValid)
            {
                _bTContext.Bugs.Update(bug);
                _bTContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bug);
        }

        [Route("Bug/Delete/{id:int}")]
        public IActionResult Delete(int id)
        {
            Bug thisBug = _bTContext.Bugs.First(x => x.BugId == id);
            return View(thisBug);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int id)
        {
            Bug bugToDelete = _bTContext.Bugs.First(x => x.BugId == id);
            if (bugToDelete != null)
            {
                _bTContext.Bugs.Remove(bugToDelete);
                _bTContext.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(id);
        }

    }
}
