using System.Data;
using Microsoft.Data.SqlClient;

namespace DemoDisconnectedLayer
{
    public partial class frmMyStore : Form
    {
        public frmMyStore()
        {
            InitializeComponent();
        }
        //create a Dataset to store data
        DataSet dsMyStore = new DataSet();
        private void btnViewProducts_Click(object sender, EventArgs e)
        {
            //Show Products table
            dgvData.DataSource = dsMyStore.Tables[0];
        }

        private void btnViewCategories_Click(object sender, EventArgs e)
        {
            //Show Categories table
            dgvData.DataSource = dsMyStore.Tables[1];
        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();

        private void Form1_Load(object sender, EventArgs e)
        {
            string ConnectionString = "Server=(local); uid=sa; pwd=thanhWasab1; " +
                "database=FptEduStore; TrustServerCertificate=True";
            string SQL = "Select ProductID,ProductName,UnitsInStock from Products ; Select * from Categories";
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(SQL, ConnectionString);
                dataAdapter.Fill(dsMyStore);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Data From Database");
            }
        }
    }//end form
}