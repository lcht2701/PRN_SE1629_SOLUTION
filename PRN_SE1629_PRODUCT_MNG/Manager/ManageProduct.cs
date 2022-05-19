namespace PRN.SE1629;

public class ProductManagement:IProduct
{
    private Product[] lstProduct;
    private int size; //So luong phan tu trong mang 1 chieu lst
    public ProductManagement()
    {
        this.size = 0;
        this.LstProduct = new Product[Utils.InitLengthProduct];
    }

    public ProductManagement(Product[] lstProduct)
    {
        this.LstProduct = lstProduct;
        foreach (Product p in lstProduct)
        {
            if (p != null)
            {
                this.size++;
            }
        }
    }

    public Product[] LstProduct { get => lstProduct; set => lstProduct = value; }

    public void Add(Product p)
    {
        //Viet giai thuat de thuc thi chen 1 phan tu vao 1 mang 1 chieu ti~nh
        /* check de xem mang con trong khong */
        if (this.size >= this.LstProduct.Length)
        {

        }
    }


    public bool Delete(Product p)
    {
        throw new NotImplementedException();
    }

    public void Display()
    {
        throw new NotImplementedException();
    }

    public Product GetProduct(int productID)
    {
        throw new NotImplementedException();
    }

    public bool Update(Product p)
    {
        throw new NotImplementedException();
    }
}