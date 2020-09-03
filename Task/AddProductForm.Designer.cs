namespace Task
{
    partial class AddProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbxRegName = new System.Windows.Forms.TextBox();
            this.tbxRegPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownRegQuantity = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.richRegDescription = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRegQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxRegName
            // 
            this.tbxRegName.Location = new System.Drawing.Point(321, 72);
            this.tbxRegName.Name = "tbxRegName";
            this.tbxRegName.Size = new System.Drawing.Size(210, 20);
            this.tbxRegName.TabIndex = 0;
            // 
            // tbxRegPrice
            // 
            this.tbxRegPrice.Location = new System.Drawing.Point(321, 129);
            this.tbxRegPrice.Name = "tbxRegPrice";
            this.tbxRegPrice.Size = new System.Drawing.Size(210, 20);
            this.tbxRegPrice.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Price";
            // 
            // numericUpDownRegQuantity
            // 
            this.numericUpDownRegQuantity.Location = new System.Drawing.Point(321, 186);
            this.numericUpDownRegQuantity.Name = "numericUpDownRegQuantity";
            this.numericUpDownRegQuantity.Size = new System.Drawing.Size(210, 20);
            this.numericUpDownRegQuantity.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantity";
            // 
            // richRegDescription
            // 
            this.richRegDescription.Location = new System.Drawing.Point(321, 231);
            this.richRegDescription.Name = "richRegDescription";
            this.richRegDescription.Size = new System.Drawing.Size(210, 96);
            this.richRegDescription.TabIndex = 6;
            this.richRegDescription.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Description";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(456, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richRegDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownRegQuantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxRegPrice);
            this.Controls.Add(this.tbxRegName);
            this.Name = "AddProductForm";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRegQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxRegName;
        private System.Windows.Forms.TextBox tbxRegPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownRegQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richRegDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}