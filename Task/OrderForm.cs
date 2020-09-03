using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task
{
    public partial class OrderForm : Form
    {
        //Seller seller = null;
        int sellerId = 0;
        object productQuantity = null;
        string productName = null;
        int productId = 0;
        object customerId = null;
        public OrderForm()
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
        
        SqlConnection sqlConnection;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (sqlConnection = new SqlConnection(@"Server=(localdb)\ProjectsV13;Database=Warehouse;Trusted_Connection=True;"))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("select id from customers where name=@name", sqlConnection);
                sqlCommand.Parameters.AddWithValue("name",comboBoxClient.GetItemText(comboBoxClient.SelectedItem));

                customerId = sqlCommand.ExecuteScalar();

            }
        }
      
        private void OrderForm_Load(object sender, EventArgs e)
        {
            using (sqlConnection = new SqlConnection(@"Server=(localdb)\ProjectsV13;Database=Warehouse;Trusted_Connection=True;"))
            {
                sqlConnection.Open();
                using (SqlDataAdapter sqlDataAdapter =new SqlDataAdapter("select * from customers where seller_id=@sellerId",sqlConnection))
                {
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("sellerId",sellerId);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    foreach (DataRow data in dataTable.Rows)
                    {
                        comboBoxClient.Items.Add(data.Field<string>("name"));
                    }
                }
                using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from products where seller_id=@sellerId", sqlConnection))
                {
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("sellerId", sellerId);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    foreach (DataRow data in dataTable.Rows)
                    {
                        comboBoxProduct.Items.Add(data.Field<string>("name"));
                    }
                }

            }
            
            //List<string> customerNames = seller.customers.Select(x=>x.Name+" "+x.Surname).ToList();
            //comboBoxClient.DataSource = customerNames;
            //List<string> productNames = seller.products.Select(x => x.Name).ToList();
            //comboBoxProduct.DataSource =productNames ;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> inputs = new List<string>() { comboBoxClient.Text,comboBoxProduct.Text,numericUpDownQuantity.Value.ToString(),dateTimePickerArriveTime.Value.ToString() };
            bool isEmpty = inputs.TrueForAll(x => x != "");
            if (isEmpty)
            {

                if (numericUpDownQuantity.Value > 0)
                {
                    int orderedQuantity = (int)numericUpDownQuantity.Value;
                    int lastQuantity = (int)productQuantity - orderedQuantity;
                    
                    if (lastQuantity < 0)
                    {
                        MessageBox.Show($"Not have enough quantity of product in warehouse there is only {productQuantity}");
                    }
                    else
                    {
                        using (sqlConnection=new SqlConnection(@"Server=(localdb)\ProjectsV13;Database=Warehouse;Trusted_Connection=True;"))
                        {
                            sqlConnection.Open();
                            SqlCommand sqlCommand= new SqlCommand("insert into orders values(@customer_id,@product_id,@quantity,@arrive_time,@order_date,@seller_id,@status)", sqlConnection);
                            sqlCommand.Parameters.AddWithValue("customer_id",(int)customerId);
                            sqlCommand.Parameters.AddWithValue("product_id", productId);
                            sqlCommand.Parameters.AddWithValue("quantity", orderedQuantity);
                            sqlCommand.Parameters.AddWithValue("arrive_time", dateTimePickerArriveTime.Value);
                            sqlCommand.Parameters.AddWithValue("order_date", DateTime.Now);
                            sqlCommand.Parameters.AddWithValue("seller_id", sellerId);
                            sqlCommand.Parameters.AddWithValue("status", "Coming soon");
                            sqlCommand.ExecuteNonQuery();
                            sqlCommand = new SqlCommand("update products set quantity=@lastquantity where name=@productName ", sqlConnection);
                            sqlCommand.Parameters.AddWithValue("productName", productName);
                            sqlCommand.Parameters.AddWithValue("lastquantity", lastQuantity);
                            var isSuccessful = sqlCommand.ExecuteNonQuery();
                            if (isSuccessful > 0)
                            {
                                MessageBox.Show("Successfully ordered");
                            }
                            else
                            {
                                MessageBox.Show("Not Ordered");
                            }
                        
                            

                        } 

                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Quantity cannot be 0");
                }

                //if (numericUpDownQuantity.Value > 0)
                //{
                //    int indexOfSpace = comboBoxClient.Text.IndexOf(" ");
                //    string name = comboBoxClient.Text.Substring(0, indexOfSpace);
                //    string surName = comboBoxClient.Text.Substring(indexOfSpace + 1);
                //    Customer currentCustomer = seller.customers.Find(item => item.Name == name && item.Surname == surName);
                //    Product currentProduct = seller.products.Find(x => x.Name == comboBoxProduct.Text);

                //    int quantity = Convert.ToInt32(numericUpDownQuantity.Value);
                //    int productQuantity = currentProduct.Quantity -= quantity;
                //    if (productQuantity < 0)
                //    {
                //        MessageBox.Show("Not have enough quantity of product in warehouse");
                //    }
                //    else
                //    {
                //        currentCustomer.orders.Add(new Order()
                //        {
                //            Client = currentCustomer,
                //            Product = currentProduct,
                //            Quantity = quantity,
                //            ArriveTime = dateTimePicker1.Value,
                //            OrderTime = DateTime.Now
                //        });
                //        using (StreamWriter streamWriter = new StreamWriter("Db-sellers.json"))
                //        {
                //            string json = JsonConvert.SerializeObject(DbLists.sellers);
                //            streamWriter.WriteLine(json);
                //        }
                //        this.Close();
                //    }
                //}
                //else
                //{
                //    MessageBox.Show("Quantity cannot be 0");
                //}



            }
            else
            {
                MessageBox.Show("Cannot be empty");
            }
            
            
            
        }
  
        private void comboBoxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
             productName= comboBoxProduct.GetItemText(comboBoxProduct.SelectedItem);
            using (sqlConnection=new SqlConnection(@"Server=(localdb)\ProjectsV13;Database=Warehouse;Trusted_Connection=True;"))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("select quantity,id from products where name=@name",sqlConnection);
                sqlCommand.Parameters.AddWithValue("name", productName);
                
                var reader= sqlCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                       productQuantity= reader.GetInt32(0);
                       productId= reader.GetInt32(1);
                    }
                }
                else
                {
                    MessageBox.Show("Data not found");
                }
            }
        }
    }
}
