﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManager
{
    public partial class InventoryManagementStudio : Form
    {
        DataTable inventory = new DataTable();
        public InventoryManagementStudio()
        {
            InitializeComponent();
        }

        private void InventoryManagementStudio_Load(object sender, EventArgs e)
        {
            inventory.Columns.Add("SKU");
            inventory.Columns.Add("Name");
            inventory.Columns.Add("Category");
            inventory.Columns.Add("Price");
            inventory.Columns.Add("Description");
            inventory.Columns.Add("Quantity");

            inventoryGridView.DataSource = inventory;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            String sku = skuTextBox.Text;
            String name = nameTextBox.Text;
            String price = priceTextBox.Text;
            String quantity = quantityTextBox.Text;
            String description = descriptionTextBox.Text;
            String category = (string)categoryComboBox.SelectedItem;

            inventory.Rows.Add(sku, name, category, price, description, quantity);
            newButton_Click(sender, e);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                inventory.Rows[inventoryGridView.CurrentCell.RowIndex].Delete();
            } 
            catch (Exception err)
            {
                Console.WriteLine("Error: " + err);
            }
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            skuTextBox.Text = "";
            nameTextBox.Text = "";
            priceTextBox.Text = "";
            descriptionTextBox.Text = "";
            quantityTextBox.Text = "";
            categoryComboBox.SelectedIndex = -1;
        }

        private void sku_Click(object sender, EventArgs e)
        {

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void descriptionLabel_Click(object sender, EventArgs e)
        {

        }

        private void inventoryGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                skuTextBox.Text = inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[0].ToString();
                nameTextBox.Text = inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[1].ToString();
                priceTextBox.Text = inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[3].ToString();
                descriptionTextBox.Text = inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[4].ToString();
                quantityTextBox.Text = inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[4].ToString();

                String itemToLookFor =  inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[2].ToString();
                categoryComboBox.SelectedIndex = categoryComboBox.Items.IndexOf(itemToLookFor);
            }

            catch(Exception err)
            {
                Console.WriteLine("error "+ err);
                     }
        }
    }
}
