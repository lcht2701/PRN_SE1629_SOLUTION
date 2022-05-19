using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN.SE1629;
    public class Product
    {
    /*1. Define properties */
    public int Id { get; set; }
    public string ProductName { get; set; }
    public string Desc { get; set; }
    public int UnitPrice { get; set; }
    public int Quantity { get; set; }

    public Product()
    {
    }

    public Product(int id, string productName, string desc, int unitPrice, int quantity)
    {
        Id = id;
        ProductName = productName;
        Desc = desc;
        UnitPrice = unitPrice;
        Quantity = quantity;
    }
    //Expression-Bodied
    public override string? ToString() => $"[Id = {Id}, Product Name = {ProductName}, Desc = {Desc}, Unit Price = {UnitPrice} and Quantity = {Quantity}]";

    /*increase percent unit_price*/
    public void IncreaseUnitPrice(int unitPrice) => UnitPrice = UnitPrice * unitPrice / 100;

}
