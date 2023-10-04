using CP2.Interfaces;
using CP2.Models;
using Microsoft.AspNetCore.Mvc;

namespace CP2.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService) 
        {
           _productService = productService;
        }

        public IActionResult Index()
        {
            return View(_productService.getAllProducts());
        }

        [HttpPost]
        public IActionResult Edit(Product product) 
        {
            Product? updatedProduct = _productService.update(product);

            if(updatedProduct == null)
            {
                return BadRequest("Não foi possivel atualizar o produto");
            }

            TempData["msg"] = $"Produto {updatedProduct.Name} atualizado com sucesso";

            return RedirectToAction("Index");
        }

        public IActionResult Edit(Guid guid)
        {
            return View(_productService.findByGuid(guid));
        }

        [HttpPost]
        public IActionResult Remove(Guid guid)
        {
            TempData["msg"] = $"Produto {_productService.findByGuid(guid)?.Name} removido com sucesso";
            
            _productService.delete(guid);

            return RedirectToAction("Index");
        }
    }
}
