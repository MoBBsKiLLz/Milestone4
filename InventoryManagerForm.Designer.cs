namespace Milestone4
{
    partial class InventoryManagerForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.restockButton = new System.Windows.Forms.Button();
            this.displayButton = new System.Windows.Forms.Button();
            this.findButton = new System.Windows.Forms.Button();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.resultsListBox = new System.Windows.Forms.ListBox();
            this.actionComboBox = new System.Windows.Forms.ComboBox();
            this.actionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(87, 90);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            this.nameLabel.Visible = false;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(139, 87);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.Visible = false;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(87, 122);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(31, 13);
            this.priceLabel.TabIndex = 2;
            this.priceLabel.Text = "Price";
            this.priceLabel.Visible = false;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(139, 119);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 3;
            this.priceTextBox.Visible = false;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(87, 154);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(46, 13);
            this.quantityLabel.TabIndex = 4;
            this.quantityLabel.Text = "Quantity";
            this.quantityLabel.Visible = false;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(139, 151);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantityTextBox.TabIndex = 5;
            this.quantityTextBox.Visible = false;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(60, 343);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 34);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add Item";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Visible = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(141, 343);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 34);
            this.removeButton.TabIndex = 7;
            this.removeButton.Text = "Remove Item";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Visible = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // restockButton
            // 
            this.restockButton.Location = new System.Drawing.Point(222, 343);
            this.restockButton.Name = "restockButton";
            this.restockButton.Size = new System.Drawing.Size(75, 34);
            this.restockButton.TabIndex = 8;
            this.restockButton.Text = "Restock Item";
            this.restockButton.UseVisualStyleBackColor = true;
            this.restockButton.Visible = false;
            this.restockButton.Click += new System.EventHandler(this.restockButton_Click);
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(102, 383);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(75, 34);
            this.displayButton.TabIndex = 9;
            this.displayButton.Text = "Display Inventory";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Visible = false;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(181, 383);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(75, 34);
            this.findButton.TabIndex = 10;
            this.findButton.Text = "Find Item";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Visible = false;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // resultsLabel
            // 
            this.resultsLabel.AutoSize = true;
            this.resultsLabel.Location = new System.Drawing.Point(15, 201);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(42, 13);
            this.resultsLabel.TabIndex = 12;
            this.resultsLabel.Text = "Results";
            this.resultsLabel.Visible = false;
            // 
            // resultsListBox
            // 
            this.resultsListBox.FormattingEnabled = true;
            this.resultsListBox.Location = new System.Drawing.Point(18, 217);
            this.resultsListBox.Name = "resultsListBox";
            this.resultsListBox.Size = new System.Drawing.Size(323, 108);
            this.resultsListBox.TabIndex = 13;
            this.resultsListBox.Visible = false;
            // 
            // actionComboBox
            // 
            this.actionComboBox.FormattingEnabled = true;
            this.actionComboBox.Items.AddRange(new object[] {
            "Add Item",
            "Remove Item",
            "Restock Item",
            "Display Inventory",
            "Find Item"});
            this.actionComboBox.Location = new System.Drawing.Point(18, 31);
            this.actionComboBox.Name = "actionComboBox";
            this.actionComboBox.Size = new System.Drawing.Size(121, 21);
            this.actionComboBox.TabIndex = 14;
            this.actionComboBox.SelectedIndexChanged += new System.EventHandler(this.actionComboBox_SelectedIndexChanged);
            // 
            // actionLabel
            // 
            this.actionLabel.AutoSize = true;
            this.actionLabel.Location = new System.Drawing.Point(15, 15);
            this.actionLabel.Name = "actionLabel";
            this.actionLabel.Size = new System.Drawing.Size(79, 13);
            this.actionLabel.TabIndex = 15;
            this.actionLabel.Text = "Choose Action:";
            // 
            // InventoryManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 79);
            this.Controls.Add(this.actionLabel);
            this.Controls.Add(this.actionComboBox);
            this.Controls.Add(this.resultsListBox);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.restockButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Name = "InventoryManagerForm";
            this.Text = "Inventory Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button restockButton;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.Label resultsLabel;
        public System.Windows.Forms.ListBox resultsListBox;
        private System.Windows.Forms.ComboBox actionComboBox;
        private System.Windows.Forms.Label actionLabel;
    }
}

