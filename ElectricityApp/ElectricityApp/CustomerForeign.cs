using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityApp
{
    public class CustomerForeign
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Nationality { get; set; }
        public double Amount { get; set; }
        public decimal Price { get; set; }

        public CustomerForeign(int id, string name, string address, string nationality, double amount, decimal price)
        {
            Id = id;
            Name = name;
            Address = address;
            Nationality = nationality;
            Amount = amount;
            Price = price;
        }

        public override string? ToString() => $"[Customer] ID = {Id}, Name = {Name}, Address = {Address}, Nationality = {Nationality}, Amount = {Amount}, Total = {Amount * (double)Price}";
    }
}
