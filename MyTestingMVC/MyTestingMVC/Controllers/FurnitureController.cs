using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyTestingMVC.Models;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace MyTestingMVC.Controllers
{
    public class FurnitureController : Controller
    {
        private readonly RepositoryContext _db;
        public FurnitureController(RepositoryContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Furniture> furniture = new List<Furniture>();
            furniture = _db.Furniture.ToList();
            return View(furniture);
        }
       
        #region API Calls
        [HttpGet]
        public IActionResult GetFurnitureList()
        {
            List<Furniture> furniture = new List<Furniture>();
            furniture = _db.Furniture.ToList();
            return View(furniture);
        }
        #endregion
    }
}
