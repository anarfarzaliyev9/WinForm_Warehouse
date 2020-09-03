using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task
{
    public partial class ProductListForm : Form
    {
        //Seller seller = null;
        int sellerId = 0;
        public ProductListForm()
        {
            InitializeComponent();
        }
        //public void GetSeller(Seller seller)
        //{
        //    this.seller = seller;
        //}
        public void GetSellerId(int sellerId)
        {
            this.sellerId = sellerId;
        }
        private void ProductListForm_Load(object sender, EventArgs e)
        {

            listView1.Columns.Add("Name");

            listView1.Columns.Add("Price");
            listView1.Columns.Add("Quantity");
            listView1.Columns.Add("Description");
            using (SqlConnection sqlConnection = new SqlConnection(@"Server=(localdb)\ProjectsV13;Database=Warehouse;Trusted_Connection=True;"))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("select name,price,quantity,description from products where seller_id=@sellerId", sqlConnection);
                sqlCommand.Parameters.AddWithValue("sellerId", sellerId);
                var reader = sqlCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string[] data = new string[]
                        {
                           reader.GetString(0),
                           reader.GetDecimal(1).ToString(),
                           reader.GetInt32(2).ToString(),
                           reader.GetString(3)
                        };
                        ListViewItem item = new ListViewItem(data);
                        listView1.Items.Add(item);
                    }
                }
                else
                {
                    MessageBox.Show("Product list is empty, please add some", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            //for (int i = 0; i < seller.products.Count; i++)
            //{
            //    string[] data = new string[] {
            //        seller.products[i].Name,
            //            seller.products[i].Price.ToString(),
            //            seller.products[i].Quantity.ToString(),
            //            seller.products[i].Description,
            //        };
            //    ListViewItem item = new ListViewItem(data);
            //    listView1.Items.Add(item);

            //}
        }

        
    }
}
