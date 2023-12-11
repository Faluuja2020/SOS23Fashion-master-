namespace SOSFashion
{
    partial class checkoutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(checkoutForm));
            label1 = new Label();
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            label2 = new Label();
            addressTextBox = new TextBox();
            label3 = new Label();
            cityTextBox = new TextBox();
            label4 = new Label();
            zipCodeTextBox = new TextBox();
            label5 = new Label();
            phoneTextBox = new TextBox();
            label6 = new Label();
            shippingComboBox = new ComboBox();
            billingComboBox = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            confirmButton = new Button();
            totalcostlabel = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(211, 62);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 0;
            label1.Text = "First name";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(211, 85);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(209, 27);
            firstNameTextBox.TabIndex = 1;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(472, 85);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(209, 27);
            lastNameTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(472, 62);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 2;
            label2.Text = "Last name";
            // 
            // addressTextBox
            // 
            addressTextBox.BackColor = SystemColors.HighlightText;
            addressTextBox.Location = new Point(472, 166);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(209, 27);
            addressTextBox.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(472, 143);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 6;
            label3.Text = "Adress";
            // 
            // cityTextBox
            // 
            cityTextBox.Location = new Point(211, 166);
            cityTextBox.Name = "cityTextBox";
            cityTextBox.Size = new Size(209, 27);
            cityTextBox.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(211, 143);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 4;
            label4.Text = "city ";
            // 
            // zipCodeTextBox
            // 
            zipCodeTextBox.Location = new Point(211, 249);
            zipCodeTextBox.Name = "zipCodeTextBox";
            zipCodeTextBox.Size = new Size(209, 27);
            zipCodeTextBox.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(211, 226);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 9;
            label5.Text = "Zip code";
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(472, 249);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(209, 27);
            phoneTextBox.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(475, 226);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 11;
            label6.Text = "Phone";
            // 
            // shippingComboBox
            // 
            shippingComboBox.FormattingEnabled = true;
            shippingComboBox.Items.AddRange(new object[] { "Standard", "Express" });
            shippingComboBox.Location = new Point(475, 316);
            shippingComboBox.Name = "shippingComboBox";
            shippingComboBox.Size = new Size(151, 28);
            shippingComboBox.TabIndex = 12;
            // 
            // billingComboBox
            // 
            billingComboBox.FormattingEnabled = true;
            billingComboBox.Items.AddRange(new object[] { "Creditcard", "Paybal", "Cash" });
            billingComboBox.Location = new Point(211, 316);
            billingComboBox.Name = "billingComboBox";
            billingComboBox.Size = new Size(151, 28);
            billingComboBox.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(472, 293);
            label7.Name = "label7";
            label7.Size = new Size(68, 20);
            label7.TabIndex = 14;
            label7.Text = "Shipping";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(214, 293);
            label8.Name = "label8";
            label8.Size = new Size(65, 20);
            label8.TabIndex = 15;
            label8.Text = "Payment";
            // 
            // confirmButton
            // 
            confirmButton.Location = new Point(211, 365);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(127, 41);
            confirmButton.TabIndex = 16;
            confirmButton.Text = "Connfirm Order";
            confirmButton.UseVisualStyleBackColor = true;
            confirmButton.Click += checkoutButton_Click;
            // 
            // totalcostlabel
            // 
            totalcostlabel.AutoSize = true;
            totalcostlabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            totalcostlabel.Location = new Point(472, 374);
            totalcostlabel.Name = "totalcostlabel";
            totalcostlabel.Size = new Size(124, 32);
            totalcostlabel.TabIndex = 17;
            totalcostlabel.Text = "Total Cost:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Modern No. 20", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(376, 9);
            label9.Name = "label9";
            label9.Size = new Size(121, 29);
            label9.TabIndex = 18;
            label9.Text = "Checkout";
            // 
            // checkoutForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(862, 427);
            Controls.Add(label9);
            Controls.Add(totalcostlabel);
            Controls.Add(confirmButton);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(billingComboBox);
            Controls.Add(shippingComboBox);
            Controls.Add(label6);
            Controls.Add(phoneTextBox);
            Controls.Add(label5);
            Controls.Add(zipCodeTextBox);
            Controls.Add(addressTextBox);
            Controls.Add(label3);
            Controls.Add(cityTextBox);
            Controls.Add(label4);
            Controls.Add(lastNameTextBox);
            Controls.Add(label2);
            Controls.Add(firstNameTextBox);
            Controls.Add(label1);
            Name = "checkoutForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Checkout";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private Label label2;
        private TextBox addressTextBox;
        private Label label3;
        private TextBox cityTextBox;
        private Label label4;
        private TextBox zipCodeTextBox;
        private Label label5;
        private TextBox phoneTextBox;
        private Label label6;
        private ComboBox shippingComboBox;
        private ComboBox billingComboBox;
        private Label label7;
        private Label label8;
        private Button confirmButton;
        private Label totalcostlabel;
        private Label label9;
    }
}