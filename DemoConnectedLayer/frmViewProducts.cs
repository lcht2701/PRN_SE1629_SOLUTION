using Microsoft.Data.SqlClient;
using System.Data;
namespace DemoConnectedLayer
{
    public partial class frmViewProducts : Form
    {
        public frmViewProducts()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();
        //--------------------------------------------------------------------

        private void frmViewProducts_Load(object sender, EventArgs e)
        {
            //Create a list to store Products
            List<dynamic> products = new List<dynamic>();   
            string ConnectionString = "Server=(local); uid=sa; pwd=thanhWasab1; " +
                "database=FptEduStore; TrustServerCertificate=True";
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("Select ProductName, UnitPrice from Products", connection);
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    products.Add(new
                    {
                        ProductName = reader.GetString("ProductName"),
                        UnitPrice = reader.GetDecimal("UnitPrice")
                    });
                }//end while
                //Binding with DataGridView: dgvData
                dgvData.DataSource = products;  
            }//end if
        }//end frmViewProducts_Load
    }
}