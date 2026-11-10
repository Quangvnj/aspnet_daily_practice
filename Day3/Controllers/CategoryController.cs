using Day3.Models;
using Microsoft.AspNetCore.Mvc;
using Day3.Data;

namespace Day3.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ILogger<CategoryController> _logger;
        public CategoryController(ILogger<CategoryController> logger)
        {
            _logger = logger;
        }
        // GET: CategoryController
        [HttpGet]
        public ActionResult Index()
        {

            return View(DataSeeds.categories);
        }

        // GET: CategoryController/Details/5
        public ActionResult Details(int id)
        {
            _logger.LogInformation("Details action called with id: {Id}", id);
            var category = DataSeeds.categories.FirstOrDefault(c => c.Id == id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        // GET: CategoryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                category.Id = DataSeeds.categories.Count + 1;
                DataSeeds.categories.Add(category);
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        // GET: CategoryController/Edit/5
        public ActionResult Edit(int id)
        {
            var EditCategory = DataSeeds.categories.FirstOrDefault(c => c.Id == id);
            if (EditCategory == null)
            {
                return NotFound();
            }
            return View(EditCategory);
        }

        // POST: CategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Category category)
        {
            var existingCategory = DataSeeds.categories.FirstOrDefault(c => c.Id == category.Id);
            if (existingCategory == null)
            {
                return NotFound();
            }
            existingCategory.Name = category.Name;
            return RedirectToAction(nameof(Index));
        }

        // GET: CategoryController/Delete/5
        public ActionResult Delete(int id)
        {
            var category = DataSeeds.categories.FirstOrDefault(c => c.Id == id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

            // POST: CategoryController/Delete/5
            [HttpPost,ActionName("Delete")]
            [ValidateAntiForgeryToken]
            public ActionResult DeleteConfirmed(int Id)
            {

                    var category = DataSeeds.categories.FirstOrDefault(c => c.Id == Id);
                    if (category == null)
                       {
                        return NotFound();
                        }
                    DataSeeds.categories.Remove(category);
                    return RedirectToAction(nameof(Index));
            }
        }
}
