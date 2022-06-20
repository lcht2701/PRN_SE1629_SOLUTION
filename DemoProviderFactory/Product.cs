namespace Prn.Se1629;

    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }

    public Product(){}

    public Product(int productID, string productName, double unitPrice)
    {
        ProductID = productID;
        ProductName = productName;
        UnitPrice = unitPrice;
    }

    public override string? ToString() => $"[Product ID: {ProductID}], Product Name: {ProductName}, " +
        $"and Unit Price = {UnitPrice}";
}
