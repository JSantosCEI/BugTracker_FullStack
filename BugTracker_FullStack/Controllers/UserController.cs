using BugTracker_FullStack.Areas.Identity.Data;
using Microsoft.AspNetCore.Mvc;

namespace BugTracker_FullStack.Controllers
{
    public class UserController : Controller
    {

        private readonly AppDbContext _db;

        public UserController(AppDbContext db)
        {
            _db = db;
        }

    }
}
