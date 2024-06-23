using BulkyBookWeb.Data;
using BulkyBookWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyBookWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<CategoryModel> objCategoryList = _db.Categories.ToList();
            return View(objCategoryList);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CategoryModel obj) 
        {
            if(obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("Name","Display Order cannot exactly match the name");
            }
            if (ModelState.IsValid) {
                _db.Categories.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index", "Category");
            }
            return View();
            
            
        }

        // GETTING THE CATEGORY
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            CategoryModel? categoryFromDb = _db.Categories.FirstOrDefault(u=>u.Id==id);
            if(categoryFromDb==null)
            {
                return NotFound();  
            }
            return View(categoryFromDb);  
        }
        // UPDATING THE CATEGORY
        [HttpPost]
        public IActionResult Edit(CategoryModel obj)
        {
            if(ModelState.IsValid)
            {
                _db.Categories.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index", "Category");
            }
            return View();
        }
    }
}
