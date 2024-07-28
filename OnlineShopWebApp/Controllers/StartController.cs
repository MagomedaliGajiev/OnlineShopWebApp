using Microsoft.AspNetCore.Mvc;

namespace OnlineShopWebApp.Controllers
{
    public class StartController : Controller
    {
        public string Hello()
        {
            var currentHour = DateTime.Now.Hour;

            if (currentHour >= 0 && currentHour <= 6)
            {
                return "Доброй ночи";
            }
            if (currentHour > 6 && currentHour <= 11)
            {
                return "Доброе утро";
            }
            if (currentHour > 11 && currentHour <= 17)
            {
                return "Добрый день";
            }
            return "Доброй ночи";
        }
    }
}
