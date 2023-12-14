
namespace InventoryManager
{
    partial class InventoryManagementStudio
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
            this.inventoryManagementStudioLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.inventoryGridView = new System.Windows.Forms.DataGridView();
            this.newButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.skuTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.skuLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // inventoryManagementStudioLabel
            // 
            this.inventoryManagementStudioLabel.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inventoryManagementStudioLabel.Location = new System.Drawing.Point(12, 9);
            this.inventoryManagementStudioLabel.Name = "inventoryManagementStudioLabel";
            this.inventoryManagementStudioLabel.Size = new System.Drawing.Size(1232, 70);
            this.inventoryManagementStudioLabel.TabIndex = 0;
            this.inventoryManagementStudioLabel.Text = "Inventory Management Studio";
            this.inventoryManagementStudioLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(12, 213);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(292, 20);
            this.priceTextBox.TabIndex = 1;
            // 
            // inventoryGridView
            // 
            this.inventoryGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.inventoryGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.inventoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventoryGridView.Location = new System.Drawing.Point(12, 320);
            this.inventoryGridView.Name = "inventoryGridView";
            this.inventoryGridView.Size = new System.Drawing.Size(1232, 393);
            this.inventoryGridView.TabIndex = 2;
            this.inventoryGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inventoryGridView_CellDoubleClick);
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(12, 277);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(96, 37);
            this.newButton.TabIndex = 3;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(114, 277);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(92, 37);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(212, 277);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(92, 37);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(310, 213);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(292, 20);
            this.descriptionTextBox.TabIndex = 6;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(609, 213);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(292, 20);
            this.quantityTextBox.TabIndex = 7;
            // 
            // skuTextBox
            // 
            this.skuTextBox.Location = new System.Drawing.Point(12, 144);
            this.skuTextBox.Name = "skuTextBox";
            this.skuTextBox.Size = new System.Drawing.Size(292, 20);
            this.skuTextBox.TabIndex = 8;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(310, 144);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(292, 20);
            this.nameTextBox.TabIndex = 9;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Items.AddRange(new object[] {
            "category1",
            "category2",
            "category3",
            "category4",
            "category5"});
            this.categoryComboBox.Location = new System.Drawing.Point(608, 144);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(291, 21);
            this.categoryComboBox.TabIndex = 10;
            // 
            // skuLabel
            // 
            this.skuLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.skuLabel.Location = new System.Drawing.Point(12, 119);
            this.skuLabel.Name = "skuLabel";
            this.skuLabel.Size = new System.Drawing.Size(292, 22);
            this.skuLabel.TabIndex = 11;
            this.skuLabel.Text = "SKU:";
            this.skuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(310, 119);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(290, 22);
            this.nameLabel.TabIndex = 12;
            this.nameLabel.Text = "Name:";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // categoryLabel
            // 
            this.categoryLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categoryLabel.Location = new System.Drawing.Point(608, 119);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(290, 22);
            this.categoryLabel.TabIndex = 13;
            this.categoryLabel.Text = "Category:";
            this.categoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // priceLabel
            // 
            this.priceLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceLabel.Location = new System.Drawing.Point(9, 188);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(290, 22);
            this.priceLabel.TabIndex = 14;
            this.priceLabel.Text = "Price:";
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionLabel.Location = new System.Drawing.Point(310, 188);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(290, 22);
            this.descriptionLabel.TabIndex = 15;
            this.descriptionLabel.Text = "Description:";
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quantityLabel
            // 
            this.quantityLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantityLabel.Location = new System.Drawing.Point(606, 188);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(290, 22);
            this.quantityLabel.TabIndex = 16;
            this.quantityLabel.Text = "Quantity:";
            this.quantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InventoryManagementStudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 725);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.skuLabel);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.skuTextBox);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.inventoryGridView);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.inventoryManagementStudioLabel);
            this.Name = "InventoryManagementStudio";
            this.Text = "Inventory Management Studio";
            this.Load += new System.EventHandler(this.InventoryManagementStudio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inventoryManagementStudioLabel;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.DataGridView inventoryGridView;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox skuTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label skuLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label quantityLabel;
    }
}

