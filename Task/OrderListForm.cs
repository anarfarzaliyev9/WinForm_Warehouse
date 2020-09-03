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
    public partial class OrderListForm : Form
    {
        Seller seller = null;
        public OrderListForm()
        {
            InitializeComponent();
        }
        public void GetSeller(Seller seller)
        {
            this.seller = seller;
        }
        

        private void OrderListForm_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("User name");
            listView1.Columns.Add("Product");
            listView1.Columns.Add("Quantiy");
            listView1.Columns.Add("Order time");
            listView1.Columns.Add("Arrive time");
            listView1.Columns.Add("Status");

            using (SqlConnection sqlConnection = new SqlConnection(@"Server=(localdb)\ProjectsV13;Database=Warehouse;Trusted_Connection=True;"))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("select c.Name+' '+c.Surname as FullName,p.Name,o.Quantity,o.order_date,o.Arrive_time,o.status from orders o join Customers c on o.Customer_id=c.Id join Products p on o.Product_id = p.Id",sqlConnection);
                var reader = sqlCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string[] data = new string[]
                        {
                           reader.GetString(0),
                           reader.GetString(1),
                           reader.GetInt32(2).ToString(),
                           reader.GetDateTime(3).ToString(),
                           reader.GetDateTime(4).ToString(),
                           reader.GetString(5)
                        };
                        ListViewItem item = new ListViewItem(data);
                        listView1.Items.Add(item);
                    }
                }
                else
                {
                    MessageBox.Show("Data not found", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);      
                }

            }

            //for (int i = 0; i < seller.customers.Count; i++)
            //{
            //    for (int j = 0; j < seller.customers[i].orders.Count; j++)
            //    {
            //        string[] data = new string[] {seller.customers[i].GetFullName(),
            //            seller.customers[i].orders[j].Product.Name,
            //            seller.customers[i].orders[j].Quantity.ToString(),
            //            seller.customers[i].orders[j].OrderTime.ToString(),
            //           seller.customers[i].orders[j].ArriveTime.ToString(),
            //           "Coming"
            //        };

            //        ListViewItem item = new ListViewItem(data);
            //        listView1.Items.Add(item);
            //    }
            //}


        }

    }
}
