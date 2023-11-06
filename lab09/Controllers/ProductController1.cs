using Bussines;
using Entity;
using lab09.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace lab09.Controllers
{
    public class ProductController1 : Controller
    {
        // GET: ProductoController1
        [Route("")]
        public ActionResult Index()
        {
            List<ProductModel> list = new List<ProductModel>();

            BProducto BProduct = new BProducto();

            List<Product> productos = BProduct.GetAllProduct();

            List<ProductModel> models = new List<ProductModel>();

            models = productos.Select(x => new ProductModel
            {
                ProductId = x.ProductId,
                Name = x.Name,
                Price = x.Price,
                Stock = x.Stock

            }).ToList();

            return View(models);
            
        }

        // GET: ProductoController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductoController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductoController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductoController1/Edit/5
        [Route("edit/{id:int}")]
        public ActionResult Edit(int id)
        {
            BProducto bproduct = new BProducto();

            Product product = bproduct.GetByid(id);
            
            ProductModel model = new ProductModel
            {
                ProductId = product.ProductId,
                Name = product.Name,
                Price = product.Price,
                Stock = product.Stock  
            };
            
            return View(model);
        }

        // POST: ProductoController1/Edit/5
        [HttpPost]
        [Route("edit/{id:int}")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ProductModel model)
        {
            try
            {
                BProducto bproduct = new BProducto();

                bproduct.Update(new Product
                {
                    ProductId = model.ProductId,
                    Name = model.Name,
                    Price=model.Price,
                    Stock = model.Stock 
                });

                return RedirectToAction(nameof(Index));
            }
            catch(Exception e)
            {
                Console.WriteLine("Error: " + e.Message);

                return View();
            }
        }

        // GET: ProductoController1/Delete/5
        [Route("delete/{id:int}")]
        public ActionResult Delete(int id)
        {
            BProducto bproduct = new BProducto();

            Product product = bproduct.GetByid(id);

            ProductModel model = new ProductModel
            {
                ProductId = product.ProductId,
                Name = product.Name,
                Price = product.Price,
                Stock = product.Stock
            };

            return View(model);
        }

        // POST: ProductoController1/Delete/5
        [HttpPost]
        [Route("delete/{id:int}")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                BProducto bproduct = new BProducto();

                bproduct.Delete(id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
