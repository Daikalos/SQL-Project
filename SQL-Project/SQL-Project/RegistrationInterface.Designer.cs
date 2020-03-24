namespace SQL_Project
{
    partial class RegistrationInterface
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.stockSupplier = new System.Windows.Forms.DataGridView();
            this.sellButton = new System.Windows.Forms.Button();
            this.purchaseButton = new System.Windows.Forms.Button();
            this.productPurchaseBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.productSellBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.supplierPurchaseBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.quantityPurchaseBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.quantitySellBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.stockStore = new System.Windows.Forms.DataGridView();
            this.pricePurchaseBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.subscriberSellBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.supplierRegisterBox = new System.Windows.Forms.TextBox();
            this.registerSupplierButton = new System.Windows.Forms.Button();
            this.productRegisterBox = new System.Windows.Forms.TextBox();
            this.priceRegisterBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.registerSubscriberButton = new System.Windows.Forms.Button();
            this.idRegisterBox = new System.Windows.Forms.TextBox();
            this.nameRegisterBox = new System.Windows.Forms.TextBox();
            this.emailRegisterBox = new System.Windows.Forms.TextBox();
            this.addressRegisterBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stockSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockStore)).BeginInit();
            this.SuspendLayout();
            // 
            // stockSupplier
            // 
            this.stockSupplier.AllowUserToAddRows = false;
            this.stockSupplier.AllowUserToDeleteRows = false;
            this.stockSupplier.AllowUserToResizeColumns = false;
            this.stockSupplier.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.NullValue = "null";
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stockSupplier.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.stockSupplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stockSupplier.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.stockSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockSupplier.Dock = System.Windows.Forms.DockStyle.Right;
            this.stockSupplier.Location = new System.Drawing.Point(681, 0);
            this.stockSupplier.Name = "stockSupplier";
            this.stockSupplier.ReadOnly = true;
            this.stockSupplier.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.stockSupplier.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.stockSupplier.Size = new System.Drawing.Size(473, 485);
            this.stockSupplier.TabIndex = 2;
            // 
            // sellButton
            // 
            this.sellButton.Location = new System.Drawing.Point(13, 171);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(105, 37);
            this.sellButton.TabIndex = 4;
            this.sellButton.Text = "Sell";
            this.sellButton.UseVisualStyleBackColor = true;
            this.sellButton.Click += new System.EventHandler(this.sellButton_Click);
            // 
            // purchaseButton
            // 
            this.purchaseButton.Location = new System.Drawing.Point(13, 56);
            this.purchaseButton.Name = "purchaseButton";
            this.purchaseButton.Size = new System.Drawing.Size(105, 37);
            this.purchaseButton.TabIndex = 5;
            this.purchaseButton.Text = "Purchase";
            this.purchaseButton.UseVisualStyleBackColor = true;
            this.purchaseButton.Click += new System.EventHandler(this.purchaseButton_Click);
            // 
            // productPurchaseBox
            // 
            this.productPurchaseBox.Location = new System.Drawing.Point(124, 30);
            this.productPurchaseBox.Name = "productPurchaseBox";
            this.productPurchaseBox.Size = new System.Drawing.Size(63, 20);
            this.productPurchaseBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Product id";
            // 
            // productSellBox
            // 
            this.productSellBox.Location = new System.Drawing.Point(124, 145);
            this.productSellBox.Name = "productSellBox";
            this.productSellBox.Size = new System.Drawing.Size(63, 20);
            this.productSellBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Product id";
            // 
            // supplierPurchaseBox
            // 
            this.supplierPurchaseBox.Location = new System.Drawing.Point(13, 30);
            this.supplierPurchaseBox.Name = "supplierPurchaseBox";
            this.supplierPurchaseBox.Size = new System.Drawing.Size(105, 20);
            this.supplierPurchaseBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Supplier";
            // 
            // quantityPurchaseBox
            // 
            this.quantityPurchaseBox.Location = new System.Drawing.Point(193, 30);
            this.quantityPurchaseBox.Name = "quantityPurchaseBox";
            this.quantityPurchaseBox.Size = new System.Drawing.Size(63, 20);
            this.quantityPurchaseBox.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Quantity";
            // 
            // quantitySellBox
            // 
            this.quantitySellBox.Location = new System.Drawing.Point(193, 145);
            this.quantitySellBox.Name = "quantitySellBox";
            this.quantitySellBox.Size = new System.Drawing.Size(63, 20);
            this.quantitySellBox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Quantity";
            // 
            // stockStore
            // 
            this.stockStore.AllowUserToAddRows = false;
            this.stockStore.AllowUserToDeleteRows = false;
            this.stockStore.AllowUserToResizeColumns = false;
            this.stockStore.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.NullValue = "null";
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stockStore.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.stockStore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stockStore.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.stockStore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockStore.Location = new System.Drawing.Point(262, 0);
            this.stockStore.Name = "stockStore";
            this.stockStore.ReadOnly = true;
            this.stockStore.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.stockStore.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.stockStore.Size = new System.Drawing.Size(413, 485);
            this.stockStore.TabIndex = 16;
            // 
            // pricePurchaseBox
            // 
            this.pricePurchaseBox.Location = new System.Drawing.Point(124, 73);
            this.pricePurchaseBox.Name = "pricePurchaseBox";
            this.pricePurchaseBox.Size = new System.Drawing.Size(63, 20);
            this.pricePurchaseBox.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(121, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Price to sell for";
            // 
            // subscriberSellBox
            // 
            this.subscriberSellBox.Location = new System.Drawing.Point(13, 145);
            this.subscriberSellBox.Name = "subscriberSellBox";
            this.subscriberSellBox.Size = new System.Drawing.Size(105, 20);
            this.subscriberSellBox.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Subscriber";
            // 
            // supplierRegisterBox
            // 
            this.supplierRegisterBox.Location = new System.Drawing.Point(13, 254);
            this.supplierRegisterBox.Name = "supplierRegisterBox";
            this.supplierRegisterBox.Size = new System.Drawing.Size(105, 20);
            this.supplierRegisterBox.TabIndex = 21;
            // 
            // registerSupplierButton
            // 
            this.registerSupplierButton.Location = new System.Drawing.Point(13, 280);
            this.registerSupplierButton.Name = "registerSupplierButton";
            this.registerSupplierButton.Size = new System.Drawing.Size(105, 37);
            this.registerSupplierButton.TabIndex = 22;
            this.registerSupplierButton.Text = "Register";
            this.registerSupplierButton.UseVisualStyleBackColor = true;
            this.registerSupplierButton.Click += new System.EventHandler(this.registerSupplierButton_Click);
            // 
            // productRegisterBox
            // 
            this.productRegisterBox.Location = new System.Drawing.Point(124, 254);
            this.productRegisterBox.Name = "productRegisterBox";
            this.productRegisterBox.Size = new System.Drawing.Size(63, 20);
            this.productRegisterBox.TabIndex = 23;
            // 
            // priceRegisterBox
            // 
            this.priceRegisterBox.Location = new System.Drawing.Point(193, 254);
            this.priceRegisterBox.Name = "priceRegisterBox";
            this.priceRegisterBox.Size = new System.Drawing.Size(63, 20);
            this.priceRegisterBox.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Supplier";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(121, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Product id";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(190, 238);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Price";
            // 
            // registerSubscriberButton
            // 
            this.registerSubscriberButton.Location = new System.Drawing.Point(13, 400);
            this.registerSubscriberButton.Name = "registerSubscriberButton";
            this.registerSubscriberButton.Size = new System.Drawing.Size(105, 37);
            this.registerSubscriberButton.TabIndex = 28;
            this.registerSubscriberButton.Text = "Register";
            this.registerSubscriberButton.UseVisualStyleBackColor = true;
            this.registerSubscriberButton.Click += new System.EventHandler(this.registerSubscriberButton_Click);
            // 
            // idRegisterBox
            // 
            this.idRegisterBox.Location = new System.Drawing.Point(13, 374);
            this.idRegisterBox.Name = "idRegisterBox";
            this.idRegisterBox.Size = new System.Drawing.Size(105, 20);
            this.idRegisterBox.TabIndex = 29;
            // 
            // nameRegisterBox
            // 
            this.nameRegisterBox.Location = new System.Drawing.Point(124, 375);
            this.nameRegisterBox.Name = "nameRegisterBox";
            this.nameRegisterBox.Size = new System.Drawing.Size(132, 20);
            this.nameRegisterBox.TabIndex = 30;
            // 
            // emailRegisterBox
            // 
            this.emailRegisterBox.Location = new System.Drawing.Point(124, 453);
            this.emailRegisterBox.Name = "emailRegisterBox";
            this.emailRegisterBox.Size = new System.Drawing.Size(132, 20);
            this.emailRegisterBox.TabIndex = 31;
            // 
            // addressRegisterBox
            // 
            this.addressRegisterBox.Location = new System.Drawing.Point(124, 414);
            this.addressRegisterBox.Name = "addressRegisterBox";
            this.addressRegisterBox.Size = new System.Drawing.Size(132, 20);
            this.addressRegisterBox.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 358);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "ID";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(124, 357);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(124, 437);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 35;
            this.label13.Text = "Email";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(124, 398);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 13);
            this.label14.TabIndex = 36;
            this.label14.Text = "Address";
            // 
            // RegistrationInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 485);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.addressRegisterBox);
            this.Controls.Add(this.emailRegisterBox);
            this.Controls.Add(this.nameRegisterBox);
            this.Controls.Add(this.idRegisterBox);
            this.Controls.Add(this.registerSubscriberButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.priceRegisterBox);
            this.Controls.Add(this.productRegisterBox);
            this.Controls.Add(this.registerSupplierButton);
            this.Controls.Add(this.supplierRegisterBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.subscriberSellBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pricePurchaseBox);
            this.Controls.Add(this.stockStore);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.quantitySellBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.quantityPurchaseBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.supplierPurchaseBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productSellBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productPurchaseBox);
            this.Controls.Add(this.purchaseButton);
            this.Controls.Add(this.sellButton);
            this.Controls.Add(this.stockSupplier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RegistrationInterface";
            this.Text = "Registration";
            ((System.ComponentModel.ISupportInitialize)(this.stockSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockStore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView stockSupplier;
        private System.Windows.Forms.Button sellButton;
        private System.Windows.Forms.Button purchaseButton;
        private System.Windows.Forms.TextBox productPurchaseBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox productSellBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox supplierPurchaseBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox quantityPurchaseBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox quantitySellBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView stockStore;
        private System.Windows.Forms.TextBox pricePurchaseBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox subscriberSellBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox supplierRegisterBox;
        private System.Windows.Forms.Button registerSupplierButton;
        private System.Windows.Forms.TextBox productRegisterBox;
        private System.Windows.Forms.TextBox priceRegisterBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button registerSubscriberButton;
        private System.Windows.Forms.TextBox idRegisterBox;
        private System.Windows.Forms.TextBox nameRegisterBox;
        private System.Windows.Forms.TextBox emailRegisterBox;
        private System.Windows.Forms.TextBox addressRegisterBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}