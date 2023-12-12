using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace SOSFashion
{
    public partial class checkoutForm : Form
    {
        private int totalCost;

        private ListBox kundvagnListBox;
        private List<Item> itemsList;

        public checkoutFormc(int totalCost, ListBox kundvagnListBox, List<Item> itemsList)
        {
            InitializeComponent();
            this.totalCost = totalCost;
            this.kundvagnListBox = kundvagnListBox;
            this.itemsList = itemsList;

            totalcostlabel.Text = $"Total Cost: {totalCost} kr";
        }

        private bool IsPaymentMethodValid(string billingMethod)
        {
            string[] validMethods = { "Paypal", "Creditcard", "Cash" }; // Remove "true" from the array
            return Array.Exists(validMethods, method => method == billingMethod);
        }

        private void UpdateInventory(List<Item> purchasedItems)
        {
            foreach (Item cartItem in purchasedItems)
            {
                // Find the corresponding item in the inventory
                Item inventoryItem = itemsList.Find(item => item.ItemName == cartItem.ItemName && item.Size == cartItem.Size);

                if (inventoryItem != null)
                {
                    // Update the inventory quantity
                    inventoryItem.AmountStock -= 1; // Assuming each purchase reduces the stock by 1

                    if (inventoryItem.AmountStock < 0)
                    {
                        inventoryItem.AmountStock = 0;
                    }

                    // Update the amount sold
                    inventoryItem.AmountSold += 1;

                    // You can add more logic here if needed
                }
                else
                {
                    // Handle the case where the item is not found in the inventory
                    MessageBox.Show($"Error: Item {cartItem.ItemName} with size {cartItem.Size} not found in inventory.");
                }
            }

            // Save the updated inventory back to the file or database
            SaveInventoryToFile();
        }

        private void SaveInventoryToFile()
        {
            // Implement the logic to save the updated inventory to the file
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
                SendOrderConfirmation(firstName, lastName, purchasedItems, selectedShippingMethod, selectedBillingOption);

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
