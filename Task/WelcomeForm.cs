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
    public partial class WelcomeForm : Form
    {
        
      
        public WelcomeForm()
        {
            InitializeComponent();
        }
        //static void AddCustomerToSellers()
        //{
        //    Seller sellerJohn = DbLists.sellers.Find(x => x.Name == "John");
        //    sellerJohn.customers.Add(new Customer()
        //    {
        //        Name = "Carl",
        //        Surname = "Blake",
        //        Address = "London",
        //        Email = "blake@gmail.com",
        //        PhoneNumber = "+9941237458"
        //    });
        //    sellerJohn.customers.Add(new Customer()
        //    {
        //        Name = "Mikel",
        //        Surname = "Green",
        //        Address = "Baku",
        //        Email = "mikel@gmail.com",
        //        PhoneNumber = "+9941237438"
        //    });
        //    sellerJohn.products.Add(new Product()
        //    {
        //        Name = "Iphone",
        //        Quantity = 5,
        //        Price = 150,

        //    });
        //    sellerJohn.products.Add(new Product()
        //    {
        //        Name = "Hp",
        //        Quantity = 15,
        //        Price = 200,

        //    });
        //    Seller sellerLucy = DbLists.sellers.Find(x => x.Name == "Lucy");
        //    sellerLucy.customers.Add(new Customer() { Name = "Gray", Surname = "Fly", Address = "Berlin", Email = "gray@gmail.com", PhoneNumber = "+9941837458" });
        //    sellerLucy.products.Add(new Product()
        //    {
        //        Name = "Laptop",
        //        Quantity = 4,
        //        Price = 100,

        //    });
        //}
        

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            //AddCustomerToSellers();
            //using (StreamReader streamReader=new StreamReader("Db-sellers.json"))
            //{
            //    string jsonText=streamReader.ReadToEnd();
            //    DbLists.sellers = JsonConvert.DeserializeObject<List<Seller>>(jsonText);
            //}
        }
        private void button1_Click(object sender, EventArgs e)
        {
            RegisterSellerForm registerSellerForm = new RegisterSellerForm();
          
            registerSellerForm.ShowDialog();

        }
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if ((tbxWelcomeUsername.Text != "" && tbxWelcomePassword.Text != ""))
            {
                using (SqlConnection sqlConnection = new SqlConnection(@"Server=(localdb)\ProjectsV13;Database=Warehouse;Trusted_Connection=True;"))
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand("Select id from Sellers where username=@username and password=@password",sqlConnection);
                    sqlCommand.Parameters.AddWithValue("username",tbxWelcomeUsername.Text);
                    sqlCommand.Parameters.AddWithValue("password", tbxWelcomePassword.Text);
                    var sellerId=sqlCommand.ExecuteScalar();
                    if (sellerId != null)
                    {
                        MainForm mainForm = new MainForm();
                        mainForm.GetSellerId(Convert.ToInt32(sellerId));
                        mainForm.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("Seller not found please sign up", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                //Seller currentSeller = DbLists.sellers.Find(x => x.Username == tbxWelcomeUsername.Text && x.Password == tbxWelcomePassword.Text);
                //if (currentSeller != null)
                //{
                //    MainForm mainForm = new MainForm();
                //    mainForm.GetSeller(currentSeller);
                //    mainForm.ShowDialog();

                //}
                //else
                //{
                //    MessageBox.Show("Seller not found please sign up");

                //}

            }
            else
            {
                MessageBox.Show("Cannot be empty", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}
