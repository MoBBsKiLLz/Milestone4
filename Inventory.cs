using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone4
{
    public class Inventory
    {
        // Fields for the inventory object, default number of rows and columns and the number of items added to the inventory 
        public List<string> _inventoryList;
        private const int _MAX_INVENTORY = 5;

        // Class object contructor
        public Inventory()
        {
            _inventoryList = new List<string>();
        }

        public void addItem(string name, double price, int quantity)
        {
            // Check if the number of inventory items is less than the number of rows
            if (_inventoryList.Count < _MAX_INVENTORY)
            {
                // Add the item to the empty row
                _inventoryList.Add("Item '" + name + "' costs " + price.ToString() + " and there is " +
                quantity.ToString() + " in stock.");

                // Display item was added
                MessageBox.Show("Item added!");
            }
            else
            {
                // Display that the array is full
                MessageBox.Show("Inventory is full!");
            }
        }

        public void removeItem(string name)
        {
            // Track if a match was found
            bool itemFound = false;

            // Check if the inventory list is empty
            if (_inventoryList.Count > 0)
            {
                // Loop through the rows
                for (int row = 0; row < _inventoryList.Count; row++)
                {
                    // Check if the first column  matches the name
                    if (_inventoryList[row].Contains(name))
                    {
                        // Set itemFound to true
                        itemFound = true;

                        // Remove the item to the empty row
                        _inventoryList.RemoveAt(row);
                        MessageBox.Show("Item was removed!");
                    }
                }
            }

            // Check if a match was found in the list
            if (!itemFound)
            {
                // Display that the item was not found
                MessageBox.Show("Item was not found.");
            }
        }

        public void restockItem(string name, double price, int quantity)
        {
            // Track if a match was found
            bool itemFound = false;

            // Check if the inventory list is empty
            if (_inventoryList.Count > 0)
            {
                // Loop through the rows
                for (int row = 0; row < _inventoryList.Count; row++)
                {
                    // Check if the first column matches the name and price
                    if (_inventoryList[row].Contains(name) && _inventoryList[row].Contains(price.ToString()))
                    {
                        // Set itemFound to true
                        itemFound = true;

                        // Add the quantity to the item
                        _inventoryList[row] = "Item '" + name + "' costs " + price.ToString() + " and there is " +
                        quantity.ToString() + " in stock.";

                        // Display item was restocked
                        MessageBox.Show("Item restocked!");
                    }
                }
            }

            // Check if a match was found in the list
            if (!itemFound)
            {
                // Display that the item was not found
                MessageBox.Show("Item was not found.");
            }
        }

        public void showInventory(InventoryManagerForm _inventoryManagerForm)
        {
            // Loop through the rows
            for (int row = 0; row < _inventoryList.Count; row++)
            {
                // Check if the list is empty
                if (_inventoryList.Count > 0)
                {
                    // Dipslay the row details in a string
                    _inventoryManagerForm.resultsListBox.Items.Add(_inventoryList[row]);
                }
            }
        }

        public string getItem(string name, double price)
        {
            string item = "Not Matches Found.";
            bool itemFound = false; // Track if a match was found

            // Check if the inventory list is empty
            if (_inventoryList.Count > 0)
            {
                // Loop through the rows
                for (int row = 0; row < _inventoryList.Count; row++)
                {
                    // Check if the first column matches the name and price
                    if (_inventoryList[row].Contains(name) && _inventoryList[row].Contains(price.ToString()))
                    {
                        // Set itemFound to true
                        itemFound = true;

                        // Set the item to the variable
                        item = _inventoryList[row];
                    }
                }
            }

            // Check if a match was found in the list
            if (!itemFound)
            {
                // Display that the item was not found
                MessageBox.Show("Item was not found.");
            }

            return item;
        }
    }
}
