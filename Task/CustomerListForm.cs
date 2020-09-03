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
    public partial class CustomerListForm : Form
    {
        //Seller seller = null;
        int sellerId = 0;
        public CustomerListForm()
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
        private void CustomerListForm_Load(object sender, EventArgs e)
        {

            listView1.Columns.Add("Name");
        
            listView1.Columns.Add("Email");
            listView1.Columns.Add("Phone number");
            listView1.Columns.Add("Address");

            using (SqlConnection sqlConnection = new SqlConnection(@"Server=(localdb)\ProjectsV13;Database=Warehouse;Trusted_Connection=True;"))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("select name+' '+surname as Name,email,phone_number,address from customers where seller_id=@sellerId", sqlConnection);
                sqlCommand.Parameters.AddWithValue("sellerId",sellerId);
                var reader= sqlCommand.ExecuteReader();
                
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string[] data = new string[] 
                        {
                           reader.GetString(0),
                           reader.GetString(1),
                           reader.GetString(2),
                           reader.GetString(3)
                        }; 
                        ListViewItem item = new ListViewItem(data);
                        listView1.Items.Add(item);
                    }
                }
                else
                {
                    MessageBox.Show("Customers list is empty, please add some", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            //for (int i = 0; i < seller.customers.Count; i++)
            //{
            //    string[] data = new string[] {
            //        seller.customers[i].GetFullName(),
            //            seller.customers[i].Email,
            //            seller.customers[i].PhoneNumber,
            //            seller.customers[i].Address,
            //        };
            //    ListViewItem item = new ListViewItem(data);
            //    listView1.Items.Add(item);

            //}

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
