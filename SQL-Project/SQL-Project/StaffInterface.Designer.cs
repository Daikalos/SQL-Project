namespace SQL_Project
{
    partial class StaffInterface
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.productsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subscribersItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shoppingItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lastYearItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppliersItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierStockItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lowestItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchasesItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productsItem,
            this.subscribersItem,
            this.suppliersItem,
            this.salesItem,
            this.purchasesItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1052, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // productsItem
            // 
            this.productsItem.Name = "productsItem";
            this.productsItem.Size = new System.Drawing.Size(66, 20);
            this.productsItem.Text = "Products";
            this.productsItem.Click += new System.EventHandler(this.productsItem_Click);
            // 
            // subscribersItem
            // 
            this.subscribersItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shoppingItem});
            this.subscribersItem.Name = "subscribersItem";
            this.subscribersItem.Size = new System.Drawing.Size(79, 20);
            this.subscribersItem.Text = "Subscribers";
            this.subscribersItem.Click += new System.EventHandler(this.subscribersItem_Click);
            // 
            // shoppingItem
            // 
            this.shoppingItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lastYearItem});
            this.shoppingItem.Name = "shoppingItem";
            this.shoppingItem.Size = new System.Drawing.Size(125, 22);
            this.shoppingItem.Text = "Shopping";
            this.shoppingItem.Click += new System.EventHandler(this.shoppingItem_Click);
            // 
            // lastYearItem
            // 
            this.lastYearItem.Name = "lastYearItem";
            this.lastYearItem.Size = new System.Drawing.Size(120, 22);
            this.lastYearItem.Text = "Last Year";
            this.lastYearItem.Click += new System.EventHandler(this.lastYearItem_Click);
            // 
            // suppliersItem
            // 
            this.suppliersItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supplierStockItem});
            this.suppliersItem.Name = "suppliersItem";
            this.suppliersItem.Size = new System.Drawing.Size(67, 20);
            this.suppliersItem.Text = "Suppliers";
            this.suppliersItem.Click += new System.EventHandler(this.suppliersItem_Click);
            // 
            // supplierStockItem
            // 
            this.supplierStockItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lowestItem});
            this.supplierStockItem.Name = "supplierStockItem";
            this.supplierStockItem.Size = new System.Drawing.Size(103, 22);
            this.supplierStockItem.Text = "Stock";
            this.supplierStockItem.Click += new System.EventHandler(this.supplierStockItem_Click);
            // 
            // lowestItem
            // 
            this.lowestItem.Name = "lowestItem";
            this.lowestItem.Size = new System.Drawing.Size(111, 22);
            this.lowestItem.Text = "Lowest";
            this.lowestItem.Click += new System.EventHandler(this.lowestItem_Click);
            // 
            // salesItem
            // 
            this.salesItem.Name = "salesItem";
            this.salesItem.Size = new System.Drawing.Size(45, 20);
            this.salesItem.Text = "Sales";
            this.salesItem.Click += new System.EventHandler(this.salesItem_Click);
            // 
            // purchasesItem
            // 
            this.purchasesItem.Name = "purchasesItem";
            this.purchasesItem.Size = new System.Drawing.Size(72, 20);
            this.purchasesItem.Text = "Purchases";
            this.purchasesItem.Click += new System.EventHandler(this.purchasesItem_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToResizeColumns = false;
            this.dataGrid.AllowUserToResizeRows = false;
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.Location = new System.Drawing.Point(0, 24);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGrid.Size = new System.Drawing.Size(1052, 418);
            this.dataGrid.TabIndex = 1;
            // 
            // StaffInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 442);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StaffInterface";
            this.Text = "Staff";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem subscribersItem;
        private System.Windows.Forms.ToolStripMenuItem salesItem;
        private System.Windows.Forms.ToolStripMenuItem purchasesItem;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.ToolStripMenuItem shoppingItem;
        private System.Windows.Forms.ToolStripMenuItem suppliersItem;
        private System.Windows.Forms.ToolStripMenuItem supplierStockItem;
        private System.Windows.Forms.ToolStripMenuItem productsItem;
        private System.Windows.Forms.ToolStripMenuItem lastYearItem;
        private System.Windows.Forms.ToolStripMenuItem lowestItem;
    }
}