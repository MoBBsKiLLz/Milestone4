using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Milestone4
{
    public partial class InventoryManagerForm : Form
    {
        // Fields for instance of the inventory class and user input
        private Inventory _myInventory = new Inventory();
        private string _name;
        private double _price;
        private int _quantity;

        public InventoryManagerForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        { 
            // Get the user input values
            _name = nameTextBox.Text;
            // Check if user input was a double
            if (double.TryParse(priceTextBox.Text, out _price))
            {
                // Check if user input was an integer
                if (int.TryParse(quantityTextBox.Text, out _quantity))
                {
                    // Call the add item method
                    _myInventory.addItem(_name, _price, _quantity);
                }
                else
                {
                    // Inform the user to use an integer value
                    MessageBox.Show("Quantity must be an integer.");
                }
            }
            else
            {
                // Inform the user to use a double value
                MessageBox.Show("Price must be a double.");
            }

            // Clear input boxes
            nameTextBox.Text = "";
            priceTextBox.Text = "";
            quantityTextBox.Text = "";
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            // Check if inventory list is empty
            if (_myInventory._inventoryList.Count > 0)
            {
                // Get the user input values
                _name = nameTextBox.Text;

                // Call the remove item method
                _myInventory.removeItem(_name);

                // Clear input boxes
                nameTextBox.Text = "";
                priceTextBox.Text = "";
                quantityTextBox.Text = "";
            }
            else
            {
                // Display that the list is empty
                MessageBox.Show("Inventory is empty.");
            }
                
        }

        private void restockButton_Click(object sender, EventArgs e)
        {
            // Check if inventory list is empty
            if (_myInventory._inventoryList.Count > 0)
            {
                // Get the user input values
                _name = nameTextBox.Text;
                // Check if user input was a double
                if (double.TryParse(priceTextBox.Text, out _price))
                {
                    // Check if user input was an integer
                    if (int.TryParse(quantityTextBox.Text, out _quantity))
                    {
                        // Call the restock inventory method
                        _myInventory.restockItem(_name, _price, _quantity);
                    }
                    else
                    {
                        // Inform the user to use an integer value
                        MessageBox.Show("Quantity must be an integer.");
                    }
                }
                else
                {
                    // Inform the user to use a double value
                    MessageBox.Show("Price must be a double.");
                }

                // Clear input boxes
                nameTextBox.Text = "";
                priceTextBox.Text = "";
                quantityTextBox.Text = "";
            }
            else
            {
                // Display that the list is empty
                MessageBox.Show("Inventory is empty.");
            }
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            // Clear the listbox
            resultsListBox.Items.Clear();

            // Check if inventory list is empty
            if (_myInventory._inventoryList.Count > 0)
            {
                // Call the show inventory method
                _myInventory.showInventory(this);
            }
            else
            {
                // Display that the list is empty
                MessageBox.Show("Inventory is empty.");
            }
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            // Check if inventory list is empty
            if (_myInventory._inventoryList.Count > 0)
            {
                // Clear the listbox
                resultsListBox.Items.Clear();

                // Get the user input values
                _name = nameTextBox.Text;
                // Check if user input was a double
                if (double.TryParse(priceTextBox.Text, out _price))
                {
                    // Call the get item inventory method and add it to the list box
                    resultsListBox.Items.Add(_myInventory.getItem(_name, _price));
                }
                else
                {
                    // Inform the user to use a double value
                    MessageBox.Show("Price must be a double.");
                }
            }
            else
            {
                // Display that the list is empty
                MessageBox.Show("Inventory is empty.");
            }
        }

        private void actionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Reset the visiblity
            nameLabel.Visible = false;
            nameTextBox.Visible = false;
            priceLabel.Visible = false;
            priceTextBox.Visible = false;
            quantityLabel.Visible = false;
            quantityTextBox.Visible = false;
            resultsLabel.Visible = false;
            resultsListBox.Visible = false;
            addButton.Visible = false;
            removeButton.Visible = false;
            restockButton.Visible = false;
            displayButton.Visible = false;
            findButton.Visible = false;

            // Clear input boxes
            nameTextBox.Text = "";
            priceTextBox.Text = "";
            quantityTextBox.Text = "";
            resultsListBox.Items.Clear();

            switch (actionComboBox.SelectedItem)
            {
                case "Add Item":
                    nameLabel.Visible = true;
                    nameTextBox.Visible = true;
                    priceLabel.Visible = true;
                    priceTextBox.Visible = true;
                    quantityLabel.Visible = true;
                    quantityTextBox.Visible = true;
                    addButton.Visible = true;
                    addButton.Location = new Point(139, 201);
                    this.Size = new Size(375, 285);
                    break;
                case "Remove Item":
                    nameLabel.Visible = true;
                    nameTextBox.Visible = true;
                    removeButton.Visible = true;
                    removeButton.Location = new Point(139, 122);
                    this.Size = new Size(375, 208);
                    break;
                case "Restock Item":
                    nameLabel.Visible = true;
                    nameTextBox.Visible = true;
                    priceLabel.Visible = true;
                    priceTextBox.Visible = true;
                    quantityLabel.Visible = true;
                    quantityTextBox.Visible = true;
                    restockButton.Visible = true;
                    restockButton.Location = new Point(139, 201);
                    this.Size = new Size(375, 285);
                    break;
                case "Display Inventory":
                    resultsLabel.Visible = true;
                    resultsLabel.Location = new Point(15, 65);
                    resultsListBox.Visible = true;
                    resultsListBox.Location = new Point(18, 81);
                    displayButton.Visible = true;
                    displayButton.Location = new Point(139, 201);
                    this.Size = new Size(375, 285);
                    break;
                case "Find Item":
                    nameLabel.Visible = true;
                    nameTextBox.Visible = true;
                    priceLabel.Visible = true;
                    priceTextBox.Visible = true;
                    resultsLabel.Visible = true;
                    resultsLabel.Location = new Point(15, 140);
                    resultsListBox.Visible = true;
                    resultsListBox.Location = new Point(18, 156);
                    findButton.Visible = true;
                    findButton.Location = new Point(139, 274);
                    this.Size = new Size(375, 358);
                    break;
            }
        }
    }
}
