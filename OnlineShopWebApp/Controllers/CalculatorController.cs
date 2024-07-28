using Microsoft.AspNetCore.Mvc;

namespace OnlineShopWebApp.Controllers
{
    public class CalculatorController : Controller
    {
        public string Index(double a, double b, string c)
        {
            switch (c)
            {
                case null:
                case "+": return $"{a} + {b} = {a + b}";
                case "-": return $"{a} - {b} = {a - b}";
                case "*": return $"{a} * {b} = {a * b}";
                case "/": return b != 0 ? $"{a} / {b} = {a / b}" : "Нельзя делить на ноль!";
                default: return "Операция может мыть толькр +, -, *, /";
            }
        }
    }
}
