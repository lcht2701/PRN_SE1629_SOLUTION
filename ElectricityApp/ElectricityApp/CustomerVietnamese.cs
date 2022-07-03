using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityApp
{
    public class CustomerVietnamese
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int TypeOfUse { get; set; } //1 for sinh hoat, 2 for kinh doanh, 3 for san xuat
        public double Amount { get; set; }
        public decimal Price { get; set; }
        public double Rate { get; set; }

        public CustomerVietnamese(int id, string name, string address, int typeOfUse, double amount, decimal price, double rate)
        {
            Id = id;
            Name = name;
            Address = address;
            TypeOfUse = typeOfUse;
            Amount = amount;
            Price = price;
            Rate = rate;
        }

        public override string? ToString() => $"[Customer] ID = {Id}, Name = {Name}, Address = {Address}, Type Of Use = {TypeOfUse}, Amount = {Amount}, Total = {Amount * (double)Price * Rate + (Amount-Rate)* (double)Price * 2.5}";
    }
}
