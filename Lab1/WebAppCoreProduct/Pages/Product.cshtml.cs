using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using WebAppCoreProduct.Models;

namespace WebAppCoreProduct.Pages

{
    public class ProductModel : PageModel
    {
        public Product Product { get; private set; }
        public string MessageResult { get; set; }
        public void OnGet()
        {
            MessageResult = "Для товара можно определить скидку";
        }
        public void OnPost(string name, decimal? price)
        {
            Product = new Product();
            if (price == null || price < 0 || string.IsNullOrEmpty(name))
            {
                MessageResult = "Переданы некорректные данные. Повторите ввод";
                return;
            }
            var result = price * (decimal?)0.18;
            MessageResult = $"Для товара {name} с ценой {price} скидка получится {result}";
            Product.Price = price;
            Product.Name = name;

        }
        public void OnPostDiscont(string name, decimal? price, double discont)
        {
            Product = new Product();
            var result = price * (decimal?)discont / 100;
            MessageResult = $"Для товара {name} с ценой {price} и скидкой {discont} скидка получится { result}";
            Product.Price = price;
            Product.Name = name;            
        }
        public void OnPostTotal(string name, decimal? price, double discont)
        {
            Product = new Product();
            var result = price - (price * (decimal?)discont / 100);
            MessageResult = $"Для товара {name} с ценой {price} и скидкой {discont} стоимость составит {result}";
            Product.Price = price;
            Product.Name = name;
        }
    }
}
