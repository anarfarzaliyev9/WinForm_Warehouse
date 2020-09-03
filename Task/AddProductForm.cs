using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task
{
    public partial class AddProductForm : Form
    {
        //Seller seller = null;
        int sellerId = 0;
        public AddProductForm()
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
        private void ProductForm_Load(object sender, EventArgs e)
        {

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            List<string> inputs = new List<string>() { tbxRegName.Text.Trim(), tbxRegPrice.Text.Trim(), numericUpDownRegQuantity.Value.ToString() };
            bool isEmpty = inputs.TrueForAll(x => x != "");
            bool isSpace = inputs.TrueForAll(x=>x!=" ");
            try
            {
                Convert.ToDecimal(tbxRegPrice.Text);             
            }
            catch(FormatException)
            {
                MessageBox.Show("Price cannot be string");
                return;
            }
            decimal.TryParse(tbxRegPrice.Text, out decimal price);

            if (isEmpty&& isSpace)
            {
               
                    if (numericUpDownRegQuantity.Value > 0 && price>0)
                    {
                       
                        int quantity = Convert.ToInt32(numericUpDownRegQuantity.Value);
                        try
                        {
                            using (SqlConnection sqlConnection = new SqlConnection(@"Server=(localdb)\ProjectsV13;Database=Warehouse;Trusted_Connection=True;"))
                            {
                                sqlConnection.Open();
                                SqlCommand sqlCommand = new SqlCommand("insert into products values(@name,@price,@quantity,@description,@seller_id)", sqlConnection);
                                sqlCommand.Parameters.AddWithValue("name", tbxRegName.Text.Trim());
                                sqlCommand.Parameters.AddWithValue("price", price);
                                sqlCommand.Parameters.AddWithValue("quantity", quantity);
                                sqlCommand.Parameters.AddWithValue("description", richRegDescription.Text.Trim());
                                sqlCommand.Parameters.AddWithValue("seller_id", sellerId);
                                var isSuccessful = sqlCommand.ExecuteNonQuery();
                                if (isSuccessful > 0)
                                {
                                    MessageBox.Show("Added successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Not added", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                            }
                        }
                        catch (SqlException ex) when (ex.Number == 2627)
                        {

                            MessageBox.Show("Cannot use same product name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                        }
                        catch (SqlException ex) when (ex.Number == 8115)
                        {
                            //MessageBox.Show($"{ex.Number}");
                            MessageBox.Show("Price format is not correct.\n Correct format: Max number before point must be 4, and after point must be 2", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show($"SqlException message is : {ex.Message}, number is : {ex.Number}");
                        return;
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show($"Error message is : {ex.Message}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                        }

                        //decimal.TryParse(textBox2.Text, out decimal price);
                        //int quantity = Convert.ToInt32(numericUpDown1.Value);
                        //seller.AddProduct(new Product()
                        //{
                        //    Name = textBox1.Text,
                        //    Price = price,
                        //    Quantity = quantity,
                        //    Description = richTextBox1.Text
                        //});
                        //using (StreamWriter streamWriter = new StreamWriter("Db-sellers.json"))
                        //{
                        //    string json = JsonConvert.SerializeObject(DbLists.sellers);
                        //    streamWriter.WriteLine(json);
                        //}
                        this.Close();
                    }

                    else
                    {
                        MessageBox.Show("Cannot be 0");
                    }
               
              
            }
            else
            {
                MessageBox.Show("Cannot be empty");
            }
        }

        
    }
}
