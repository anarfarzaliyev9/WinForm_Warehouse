namespace Task
{
    partial class AddCustomerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxRegName = new System.Windows.Forms.TextBox();
            this.tbxRegSurname = new System.Windows.Forms.TextBox();
            this.tbxRegEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedRegPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.richRegAddress = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname";
            // 
            // tbxRegName
            // 
            this.tbxRegName.Location = new System.Drawing.Point(351, 74);
            this.tbxRegName.Name = "tbxRegName";
            this.tbxRegName.Size = new System.Drawing.Size(193, 20);
            this.tbxRegName.TabIndex = 2;
            // 
            // tbxRegSurname
            // 
            this.tbxRegSurname.Location = new System.Drawing.Point(351, 124);
            this.tbxRegSurname.Name = "tbxRegSurname";
            this.tbxRegSurname.Size = new System.Drawing.Size(193, 20);
            this.tbxRegSurname.TabIndex = 3;
            // 
            // tbxRegEmail
            // 
            this.tbxRegEmail.Location = new System.Drawing.Point(351, 175);
            this.tbxRegEmail.Name = "tbxRegEmail";
            this.tbxRegEmail.Size = new System.Drawing.Size(193, 20);
            this.tbxRegEmail.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tel-number";
            // 
            // maskedRegPhoneNumber
            // 
            this.maskedRegPhoneNumber.Location = new System.Drawing.Point(351, 215);
            this.maskedRegPhoneNumber.Mask = "(+\\9\\94) 00-000-00-00";
            this.maskedRegPhoneNumber.Name = "maskedRegPhoneNumber";
            this.maskedRegPhoneNumber.Size = new System.Drawing.Size(193, 20);
            this.maskedRegPhoneNumber.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(273, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Address";
            // 
            // richRegAddress
            // 
            this.richRegAddress.Location = new System.Drawing.Point(351, 259);
            this.richRegAddress.Name = "richRegAddress";
            this.richRegAddress.Size = new System.Drawing.Size(193, 96);
            this.richRegAddress.TabIndex = 9;
            this.richRegAddress.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(443, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.richRegAddress);
            this.Controls.Add(this.maskedRegPhoneNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxRegEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxRegSurname);
            this.Controls.Add(this.tbxRegName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddCustomerForm";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxRegName;
        private System.Windows.Forms.TextBox tbxRegSurname;
        private System.Windows.Forms.TextBox tbxRegEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedRegPhoneNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richRegAddress;
        private System.Windows.Forms.Button button1;
    }
}