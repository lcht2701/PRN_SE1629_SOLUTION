using DemoDatabaseFirst.EntitiesModels;
using Microsoft.EntityFrameworkCore;
//1. initial object DBContext
using (FptEduStoreContext db = new())
{
    db.SaveChanges();
    var categories = db.Categories.Include(c => c.Products);
    foreach (var c in categories)
    {
        Console.WriteLine($"Category ID: {c.CategoryId}, Category Name = {c.CategoryName} " +
            $"Number of Products: {c.Products.Count}");
        var products = from p in db.Products
                       where p.UnitPrice >= 18
                       select p;

        //or
        //var products2 = db.Products.Where(p => p.UnitPrice >= 18);

        foreach (var p in products)
        {
            Console.WriteLine($"Product ID: {p.ProductId}, Product Name: {p.ProductName}");

        }
    }
}