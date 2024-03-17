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
            MessageResult = "��� ������ ����� ���������� ������";
        }
        public void OnPost(string name, decimal? price)
        {
            Product = new Product();
            if (price == null || price < 0 || string.IsNullOrEmpty(name))
            {
                MessageResult = "�������� ������������ ������. ��������� ����";
                return;
            }
            var result = price * (decimal?)0.18;
            MessageResult = $"��� ������ {name} � ����� {price} ������ ��������� {result}";
            Product.Price = price;
            Product.Name = name;

        }
        public void OnPostDiscont(string name, decimal? price, double discont)
        {
            Product = new Product();
            var result = price * (decimal?)discont / 100;
            MessageResult = $"��� ������ {name} � ����� {price} � ������� {discont} ������ ��������� { result}";
            Product.Price = price;
            Product.Name = name;            
        }
        public void OnPostTotal(string name, decimal? price, double discont)
        {
            Product = new Product();
            var result = price - (price * (decimal?)discont / 100);
            MessageResult = $"��� ������ {name} � ����� {price} � ������� {discont} ��������� �������� {result}";
            Product.Price = price;
            Product.Name = name;
        }
    }
}
