using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task
{
    public partial class MainForm : Form
    {
        //Seller seller=null;
        int sellerId=0;
        public MainForm()
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
        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerListForm customerListForm = new CustomerListForm();
            customerListForm.GetSellerId(sellerId);
            customerListForm.ShowDialog();
            //CustomerListForm customerListForm = new CustomerListForm();
            //customerListForm.GetSeller(seller);
            //customerListForm.ShowDialog();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //AddCustomerForm addCustomerForm = new AddCustomerForm();
            //addCustomerForm.GetSeller(seller);
            //addCustomerForm.ShowDialog();
            AddCustomerForm addCustomerForm = new AddCustomerForm();
            addCustomerForm.GetSellerId(sellerId);
            addCustomerForm.ShowDialog();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.GetSellerId(sellerId);
            addProductForm.ShowDialog();
            //AddProductForm addProductForm = new AddProductForm();
            //addProductForm.GetSeller(seller);
            //addProductForm.ShowDialog();
        }

        private void acceptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.GetSellerId(sellerId);
            orderForm.ShowDialog();
            //OrderForm orderForm = new OrderForm();
            //orderForm.GetSeller(seller);
            //orderForm.ShowDialog();
        }

        private void listToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OrderListForm orderListForm = new OrderListForm();
            //orderListForm.GetSeller(seller);
            orderListForm.ShowDialog();
        }

        private void listToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            ProductListForm productListForm = new ProductListForm();
            productListForm.GetSellerId(sellerId);
            productListForm.ShowDialog();
            //ProductListForm productListForm = new ProductListForm();
            //productListForm.GetSeller(seller);
            //productListForm.ShowDialog();
        }

        
    }
}
