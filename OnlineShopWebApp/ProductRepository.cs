using OnlineShopWebApp.Models;

namespace OnlineShopWebApp
{
    public class ProductRepository
    {
        private static List<Product> products = new List<Product>()
        {
            new Product("Игровая консоль PlayStation 5 Slim", 61999, "1000 ГБ, с дисководом, Bluetooth 5.1, Wi-Fi 6 (802.11ax), HDMI 2.1, до 8K UltraHD, 7680x4320"),
            new Product ("Игровая консоль Microsoft Xbox Series X", 49999, "1000 ГБ, с дисководом, Wi-Fi 5 (802.11ac), HDMI 2.1, до 4K UltraHD, 3840x2160"),
            new Product("6.7\" Смартфон Apple iPhone 15 Pro Max 256 ГБ черный", 140399, "ядер - 6x(3.78 ГГц), 8 ГБ, 1 SIM, Super Retina XDR, 2796x1290, камера 48+12+12 Мп, NFC, 5G, GPS, 4441 мА*ч"),
            new Product("6.73\" Смартфон Xiaomi 14 Ultra 512 ГБ черный", 139999, "ядер - 8x(3.3 ГГц), 16 ГБ, 2 SIM, AMOLED, 3200x1440, камера 50+50+50+50 Мп, NFC, 5G, GPS, 5000 мА*ч"),
            new Product("14.2\" Ноутбук HUAWEI MateBook X Pro VGHH-X голубой", 206999, "3120x2080, OLED, Intel Core Ultra 9 185H, ядра: 6 + 8 х 2.3 ГГц + 1.8 ГГц, RAM 32 ГБ, SSD 2000 ГБ, Intel Arc Graphics, Windows 11 Home")
        };

        public List<Product> GetAll()
        {
            return products;
        }

        public Product TryGetById(Guid id)
        {
            return products.FirstOrDefault(product => product.Id == id);
        }
    }
}
