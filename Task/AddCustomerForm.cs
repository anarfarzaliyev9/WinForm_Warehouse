using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task
{
    public partial class AddCustomerForm : Form
    {
        //Seller seller = null;
        int sellerId = 0;
        public AddCustomerForm()
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



        private void Customer_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            List<string> inputs = new List<string>() {tbxRegName.Text.Trim(), tbxRegSurname.Text.Trim(), tbxRegEmail.Text.Trim(), maskedRegPhoneNumber.Text.Trim(), richRegAddress.Text.Trim() };
            bool isEmpty= inputs.TrueForAll(x=>x!="");
            bool isSpace = inputs.TrueForAll(x=>x!=" ");
            int maskedInputLength = maskedRegPhoneNumber.Text.Trim().Length;
            bool isNumberValid = (maskedInputLength==19)?true:false ;
            try
            {
                MailAddress mailAddress = new MailAddress(tbxRegEmail.Text);
            }
            catch (Exception)
            {
                
                MessageBox.Show("Email is not correct format", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (isEmpty &&isSpace&&isNumberValid)
            {
                using (SqlConnection sqlConnection = new SqlConnection(@"Server=(localdb)\ProjectsV13;Database=Warehouse;Trusted_Connection=True;"))
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand("insert into customers values(@name,@surname,@email,@phone_number,@address,@seller_id)",sqlConnection);
                    sqlCommand.Parameters.AddWithValue("name",tbxRegName.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("surname", tbxRegSurname.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("email", tbxRegEmail.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("phone_number", maskedRegPhoneNumber.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("address", richRegAddress.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("seller_id", sellerId);
                    var isSuccessful = sqlCommand.ExecuteNonQuery();
                    if (isSuccessful > 0)
                    {
                        MessageBox.Show("Register successful", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Register not successful", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                //seller.AddCustomer(new Customer()
                //{
                //    Name = textBox1.Text,
                //    Surname = textBox2.Text,
                //    Email = textBox3.Text,
                //    PhoneNumber = maskedTextBox1.Text,
                //    Address = richTextBox1.Text
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
                MessageBox.Show("Cannot be empty", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
            }
            

        }
    }
}
