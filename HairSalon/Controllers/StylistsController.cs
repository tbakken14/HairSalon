using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using HairSalon.Models;

namespace HairSalon.Controllers
{
    public class StylistsController : Controller
    {
        private readonly HairSalonContext _db;
        public StylistsController(HairSalonContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            return View(_db.Stylists.ToList());
        }

        public ActionResult New()
        {
            return View("Create");
        }

        [HttpPost]
        public ActionResult Create(Stylist stylist)
        {
            _db.Stylists.Add(stylist);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            Stylist stylist = _db.Stylists
                .Include(model => model.Clients)
                .FirstOrDefault(model => model.StylistId == id);
            return View(stylist);
        }
    }
}