using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Day3.Models;
using Day3.Data;

namespace Day3.Controllers
{
    public class ProductController : Controller
    {
        // GET: ProductController
        public ActionResult Index()
        {
            //Lấy danh sách sản phẩm từ cơ sở dữ liệu (giả lập)
            return View(DataSeeds.products);
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            var product = DataSeeds.products.FirstOrDefault(c => c.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            DataSeeds.products.Add(product);
            return RedirectToAction(nameof(Index));
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            var EditProduct = DataSeeds.products.FirstOrDefault(c => c.Id == id);
            if (EditProduct == null)
            {
                return NotFound();
            }
            return View(EditProduct);
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Product product)
        {
            var existingCategory = DataSeeds.products.FirstOrDefault(c => c.Id == product.Id);
            if (existingCategory == null)
            {
                return NotFound();
            }
            existingCategory.Name = product.Name;
            existingCategory.Description = product.Description;
            existingCategory.Price = product.Price;
            existingCategory.CategoryId = product.CategoryId;
            return RedirectToAction(nameof(Index));
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            var product = DataSeeds.products.FirstOrDefault(c => c.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: ProductController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var product = DataSeeds.products.FirstOrDefault(c => c.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            DataSeeds.products.Remove(product);
            return RedirectToAction(nameof(Index));
        }
    }
}
