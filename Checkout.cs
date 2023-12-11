using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace SOSFashion
{
    public partial class checkoutForm : Form
    {
        private int totalCost;

        public checkoutForm(int totalCost)
        {
            InitializeComponent();
            this.totalCost = totalCost;
            totalcostlabel.Text = $"Total Cost: {totalCost} kr";
        }

        private bool IsPaymentMethodValid(string billingMethod)
        {
            string[] validMethods = { "true", "Paypal", "Creditcard", "Cash" };
            return Array.Exists(validMethods, method => method == billingMethod);
        }

        private void UpdateInventory(List<Item> purchasedItems)
        {
            // Implement inventory update logic
        }

        private void SendOrderConfirmation(string firstName, string lastName, List<Item> purchasedItems, string shippingMethod, string billingOption)
        {
            // Implement order confirmation logic
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string city = cityTextBox.Text;
            string address = addressTextBox.Text;
            string zipCode = zipCodeTextBox.Text;
            string phone = phoneTextBox.Text;

            string selectedShippingMethod = shippingComboBox.SelectedItem?.ToString();
            string selectedBillingOption = billingComboBox.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedBillingOption))
            {
                MessageBox.Show("Please select a payment method before checking out.");
                return;
            }

            bool paymentSuccess = IsPaymentMethodValid(selectedBillingOption);

            if (paymentSuccess)
            {
                List<Item> purchasedItems = new List<Item>();
                // Assuming you have logic to populate purchasedItems based on the user's cart

                // Update inventory
                UpdateInventory(purchasedItems);

                // Send order confirmation


                // Close the form or perform additional actions
                this.Close();
            }
            else
            {
                MessageBox.Show("Payment failed. Please try again or choose a different payment method.");
            }
        }


    }
}
