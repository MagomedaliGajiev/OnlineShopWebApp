using Microsoft.AspNetCore.Mvc;

namespace OnlineShopWebApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductRepository _productRepository;

        public ProductController()
        {
            _productRepository = new ProductRepository();
        }
        public string Index(Guid id)
        {
            var product = _productRepository.TryGetById(id);

            if (product == null)
            {
                return $"Продукта с id={id} не существует";
            }
            return $"{product}\n{product.Description}";
        }
    }
}
