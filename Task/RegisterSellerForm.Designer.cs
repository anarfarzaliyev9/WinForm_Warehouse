namespace Task
{
    partial class RegisterSellerForm
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
            this.tbxRegUsername = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tbxRegPassword = new System.Windows.Forms.TextBox();
            this.tbxRegName = new System.Windows.Forms.TextBox();
            this.tbxRegSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxRegUsername
            // 
            this.tbxRegUsername.Location = new System.Drawing.Point(321, 70);
            this.tbxRegUsername.Name = "tbxRegUsername";
            this.tbxRegUsername.Size = new System.Drawing.Size(143, 20);
            this.tbxRegUsername.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(321, 155);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(143, 20);
            this.textBox2.TabIndex = 1;
            // 
            // tbxRegPassword
            // 
            this.tbxRegPassword.Location = new System.Drawing.Point(321, 112);
            this.tbxRegPassword.Name = "tbxRegPassword";
            this.tbxRegPassword.PasswordChar = '*';
            this.tbxRegPassword.Size = new System.Drawing.Size(143, 20);
            this.tbxRegPassword.TabIndex = 2;
            // 
            // tbxRegName
            // 
            this.tbxRegName.Location = new System.Drawing.Point(321, 192);
            this.tbxRegName.Name = "tbxRegName";
            this.tbxRegName.Size = new System.Drawing.Size(143, 20);
            this.tbxRegName.TabIndex = 3;
            // 
            // tbxRegSurname
            // 
            this.tbxRegSurname.Location = new System.Drawing.Point(321, 232);
            this.tbxRegSurname.Name = "tbxRegSurname";
            this.tbxRegSurname.Size = new System.Drawing.Size(143, 20);
            this.tbxRegSurname.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Re-Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(237, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Surname";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(388, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegisterSellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxRegSurname);
            this.Controls.Add(this.tbxRegName);
            this.Controls.Add(this.tbxRegPassword);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tbxRegUsername);
            this.Name = "RegisterSellerForm";
            this.Text = "RegisterSeller";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxRegUsername;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox tbxRegPassword;
        private System.Windows.Forms.TextBox tbxRegName;
        private System.Windows.Forms.TextBox tbxRegSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}