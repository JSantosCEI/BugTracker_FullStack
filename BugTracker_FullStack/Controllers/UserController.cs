using BugTracker_FullStack.Data;
using BugTracker_FullStack.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BugTracker_FullStack.Controllers
{
    public class UserController : Controller
    {

        private readonly BTContext _db;

        public UserController(BTContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Auth()
        {
            return View();
        }
    }
}
