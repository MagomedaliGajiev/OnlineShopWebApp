using Microsoft.AspNetCore.Mvc;

namespace OnlineShopWebApp.Controllers
{
    public class CalculatorController : Controller
    {
        public string Index(double a, double b, string operation)
        {
                switch (operation)
            {
                case null:
                case "+":
                    return $"{a} + {b} = {a + b}";
                case "-":
                    return $"{a} - {b} = {a - b}";
                case "*":
                    return $"{a} * {b} = {a * b}";
                default:
                    return "Можно передавать только операции +, -, *!";
            }
        }
    }
}
