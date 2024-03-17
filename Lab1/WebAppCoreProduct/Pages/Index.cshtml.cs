using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppCoreProduct.Models;

namespace WebAppCoreProduct.Pages
{
    public class IndexModel : PageModel
    {     
        public string MessageResult { get; set; }
        public void OnGet()
        {
            MessageResult = "Для товара можно определить скидку";
        }
    }
}
