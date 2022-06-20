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
        CheckSize();
        /*2. Meu ma con cho trong, thi ta chi viec add product vao*/
        this.lstProduct[this.size++] = p;
    }

    private void CheckSize()
    {
        if (this.size >= this.LstProduct.Length)
        {
            //Thuc hien noi mang ra
            Product[] tmp = new Product[this.size * 2];
            //Hot du lieu tu cu sang mang temp moi 
            for (int i = 0; i < this.size; i++)
            {
                tmp[i] = this.LstProduct[i];
            }
            this.lstProduct = tmp;
        }
    }

    public bool Delete(Product p)
    {
        int index = -1;
        /*1. Tim phan tu p do co trong mang hay khong? */
        foreach (var item in this.lstProduct)
        {   
            if (item != null && item.Id == p.Id)
            {
                /*Neu tim thay thi xoa di*/
                for(int  i = index; i < size; i++)
                {
                    lstProduct[i] = lstProduct[i + 1];                 
                }
                lstProduct[size - 1] = null;
                return true;
            }
        }
        return false;
    }

    public void Display()
    {
        foreach(Product p in this.LstProduct)
        {
            Console.WriteLine(p);
        }  
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