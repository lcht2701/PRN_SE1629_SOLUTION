using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ECommerceWebApp.pages;

public class SuppliersModel : PageModel
{
    public IEnumerable<string>? Suppliers { get; set; }

    public void OnGet()
    {
        ViewData["Title"] = "Ecommerce data B2B - Suppliers";
        Suppliers = new[] { "SOLID Co", "CMC Limited", "FPT Education Corp" };
    }
}
