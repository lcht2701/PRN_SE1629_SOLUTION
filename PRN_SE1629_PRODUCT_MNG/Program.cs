namespace PRN.SE1629;
public class Program
{
    public static void Main()
    {
        //1. Khai bao doi tuong ManagerProduct
        ProductManagement productManagement = new ProductManagement();
        //2. Them n product vao

        productManagement.Add(new Product(1, "Laptop Dell 19inch", "new Product with new feature 2022", 2500, 2));
        productManagement.Add(new Product(2, "Macbook Pro 2022", "new Product with new feature 2022", 3500, 2));
        productManagement.Add(new Product(3, "Ip 14 Pro", "new Product with new feature 2022", 1500, 2));
        Product p = new Product(4, "Laptop Acer Nitro 5 16inch", "new Product with new feature 2022", 3000, 2);
        productManagement.Add(p);

        //3. Call display
        productManagement.Display();
        /*4. Xoa p */
        Console.WriteLine("-----------------------------------------------------------------");
        productManagement.Delete(p);
        productManagement.Display();
        /*5. Loc theo mot tieu chi nao do*/
        //Lay het sp ra
        Product[] lstData = FilterProduct(2500, productManagement.LstProduct);
        foreach (Product pf in lstData)
        {
            if (pf != null)
            {
                Console.WriteLine(pf);
            }
        }
    }

    private static Product[] FilterProduct(double unitPrice, Product[] lstData)
    {
        Product[] result = new Product[lstData.Length];
        int i = 0;
        foreach (Product p in lstData)
        {
            if (p.UnitPrice >= unitPrice)
            {
                result[i] = p;
                i++;
            }
        }
        return lstData;
    }
}