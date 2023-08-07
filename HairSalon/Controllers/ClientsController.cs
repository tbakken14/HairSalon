using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using HairSalon.Models;

namespace HairSalon.Controllers
{
    public class ClientsController : Controller
    {
        private readonly HairSalonContext _db;
        public ClientsController(HairSalonContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            return View(_db.Clients.ToList());
        }

        public ActionResult New()
        {
            ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "Name");
            return View("Create");
        }

        [HttpPost]
        public ActionResult Create(Client client)
        {
            _db.Clients.Add(client);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            Client client = _db.Clients
                .Include(model => model.Stylist)
                .FirstOrDefault(model => model.ClientId == id);
            return View(client);
        }
    }
}