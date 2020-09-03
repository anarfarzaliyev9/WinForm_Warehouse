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
    public partial class RegisterSellerForm : Form
    {
        
        public RegisterSellerForm()
        {
            InitializeComponent();
        }
 
        private void button1_Click(object sender, EventArgs e)
        {
            List<string> textboxes = new List<string>() { textBox2.Text.Trim(), tbxRegPassword.Text.Trim(), tbxRegName.Text.Trim(), tbxRegSurname.Text.Trim(), tbxRegUsername.Text.Trim() };
            bool isEmpty = textboxes.TrueForAll(x => x != "");
            bool isSpace = textboxes.TrueForAll(x => x != " ");
            if (isEmpty&&isSpace)
            {
                if (textBox2.Text == tbxRegPassword.Text)
                {
                    //DbLists.sellers.Add(new Seller()
                    //{
                    //    Username = tbxRegUsername.Text,
                    //    Password = textBox3.Text,
                    //    Name = textBox4.Text,
                    //    Surname = textBox5.Text
                    //});
                    //using (StreamWriter streamWriter = new StreamWriter("Db-sellers.json"))
                    //{
                    //    string json = JsonConvert.SerializeObject(DbLists.sellers);
                    //    streamWriter.WriteLine(json);
                    //}
                    using (SqlConnection sqlConnection = new SqlConnection(@"Server=(localdb)\ProjectsV13;Database=Warehouse;Trusted_Connection=True;"))
                    {
                        sqlConnection.Open();
                        SqlCommand sqlCommand = new SqlCommand("insert into Sellers values(@username,@password,@name,@surname)",sqlConnection);
                        sqlCommand.Parameters.AddWithValue("username",tbxRegUsername.Text.Trim());
                        sqlCommand.Parameters.AddWithValue("password", tbxRegPassword.Text.Trim());
                        sqlCommand.Parameters.AddWithValue("name", tbxRegName.Text.Trim());
                        sqlCommand.Parameters.AddWithValue("surname", tbxRegSurname.Text.Trim());
                        var isSuccessful= sqlCommand.ExecuteNonQuery();
                        if (isSuccessful>0)
                        {
                            MessageBox.Show("Register successful","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Register not successful", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    
                    
                    this.Close();
                }
                else
                {
              
                    MessageBox.Show("Passwords not same", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Cannot be empty", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
       
            }
            
            
            
            
        }
    }
}
