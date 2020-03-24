using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;

namespace SQL_Project
{
    public partial class RegistrationInterface : Form
    {
        private readonly NpgsqlConnection myConn;

        public RegistrationInterface()
        {
            InitializeComponent();

            myConn = new NpgsqlConnection("Server=pgserver.mah.se; User Id=aj9191; Password=2z7gf3vz; Database=aj9191_bdb");
            myConn.Open();

            LoadStoreStock();
            LoadSupplierStock();
        }

        private void purchaseButton_Click(object sender, EventArgs e)
        {
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = myConn;

            NpgsqlTransaction trans = myConn.BeginTransaction(IsolationLevel.Serializable);

            cmd.Parameters.AddWithValue("@purchase_supplier", supplierPurchaseBox.Text);
            cmd.Parameters.Add(new NpgsqlParameter("@purchase_product", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(new NpgsqlParameter("@purchase_quantity", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(new NpgsqlParameter("@purchase_price", NpgsqlTypes.NpgsqlDbType.Integer));
            Int32.TryParse(productPurchaseBox.Text, out int productId);
            Int32.TryParse(quantityPurchaseBox.Text, out int quantity);
            Int32.TryParse(pricePurchaseBox.Text, out int price);
            cmd.Parameters[1].Value = productId;
            cmd.Parameters[2].Value = quantity;
            cmd.Parameters[3].Value = price;

            try
            {
                cmd.CommandText = "insert into purchase(transaction_id, supplier, product_id, quantity, price, time_of_purchase)"
                    + " values (floor(random()*10000), @purchase_supplier, @purchase_product, @purchase_quantity, (select price from supplier_stock"
                    + " where supplier_stock.product_id=@purchase_product and supplier_stock.supplier=@purchase_supplier), current_timestamp)";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "insert into store_stock(product_id, quantity, price)"
                    + " values (@purchase_product, @purchase_quantity, @purchase_price)";
                cmd.ExecuteNonQuery();

                trans.Commit();
                LoadStoreStock();
            }
            catch (PostgresException exception)
            {
                if (exception.SqlState == "23505") //Duplicate Key
                {
                    trans.Rollback(); //Transaction has aborted, restart 
                    trans = myConn.BeginTransaction(IsolationLevel.Serializable);

                    cmd.CommandText = "insert into purchase(transaction_id, supplier, product_id, quantity, price, time_of_purchase)"
                        + " values (floor(random()*10000), @purchase_supplier, @purchase_product, @purchase_quantity,"
                        + " (select price from supplier_stock where supplier_stock.product_id=@purchase_product and supplier_stock.supplier=@purchase_supplier), current_timestamp)";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "update store_stock set quantity = quantity + @purchase_quantity, price = @purchase_price"
                        + " where product_id=@purchase_product";
                    cmd.ExecuteNonQuery();

                    trans.Commit();
                    LoadStoreStock();
                }
                else
                {
                    trans.Rollback();
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void sellButton_Click(object sender, EventArgs e)
        {
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = myConn;

            NpgsqlTransaction trans = myConn.BeginTransaction(IsolationLevel.Serializable);
            cmd.Transaction = trans;

            cmd.Parameters.AddWithValue("@sell_subscriber", StringOrNull(subscriberSellBox.Text));
            cmd.Parameters.Add(new NpgsqlParameter("@sell_product", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(new NpgsqlParameter("@sell_quantity", NpgsqlTypes.NpgsqlDbType.Integer));
            Int32.TryParse(productSellBox.Text, out int productId);
            Int32.TryParse(quantitySellBox.Text, out int quantity);
            cmd.Parameters[1].Value = productId;
            cmd.Parameters[2].Value = quantity;

            try
            {
                cmd.CommandText = "update store_stock set quantity = quantity - @sell_quantity"
                    + " where product_id=@sell_product";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "insert into sale(transaction_id, subscriber_id, product_id, quantity, price, time_of_sale)"
                    + " values (floor(random()*10000), @sell_subscriber, @sell_product, @sell_quantity, (select price from store_stock where store_stock.product_id=@sell_product), current_timestamp)";
                cmd.ExecuteNonQuery();

                trans.Commit();
                LoadStoreStock();
            }
            catch (PostgresException exception)
            {
                trans.Rollback();
                MessageBox.Show(exception.Message);
            }
        }

        private void registerSupplierButton_Click(object sender, EventArgs e)
        {
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = myConn;

            NpgsqlTransaction trans = myConn.BeginTransaction(IsolationLevel.RepeatableRead);

            cmd.Parameters.AddWithValue("@register_supplier", supplierRegisterBox.Text);
            cmd.Parameters.Add(new NpgsqlParameter("@register_product", NpgsqlTypes.NpgsqlDbType.Integer));
            cmd.Parameters.Add(new NpgsqlParameter("@register_price", NpgsqlTypes.NpgsqlDbType.Integer));
            Int32.TryParse(productRegisterBox.Text, out int productId);
            Int32.TryParse(priceRegisterBox.Text, out int price);
            cmd.Parameters[1].Value = productId;
            cmd.Parameters[2].Value = price;

            try
            {
                cmd.CommandText = "insert into supplier_stock(supplier, product_id, price)"
                    + " values (@register_supplier, @register_product, @register_price)";
                cmd.ExecuteNonQuery();

                trans.Commit();
                LoadSupplierStock();
            }
            catch (PostgresException exception)
            {
                if (exception.SqlState == "23505") //Duplicate Key
                {
                    trans.Rollback(); //Transaction has aborted, restart 
                    trans = myConn.BeginTransaction(IsolationLevel.RepeatableRead);

                    cmd.CommandText = "update supplier_stock set price = @register_price"
                        + " where supplier=@register_supplier and product_id=@register_product";
                    cmd.ExecuteNonQuery();

                    trans.Commit();
                    LoadSupplierStock();
                }
                else
                {
                    trans.Rollback();
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void registerSubscriberButton_Click(object sender, EventArgs e)
        {
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = myConn;

            NpgsqlTransaction trans = myConn.BeginTransaction(IsolationLevel.RepeatableRead);
            cmd.Transaction = trans;

            cmd.Parameters.AddWithValue("@register_id", idRegisterBox.Text);
            cmd.Parameters.AddWithValue("@register_name", StringOrNull(nameRegisterBox.Text));
            cmd.Parameters.AddWithValue("@register_address", StringOrNull(addressRegisterBox.Text));
            cmd.Parameters.AddWithValue("@register_email", StringOrNull(emailRegisterBox.Text));

            try
            {
                cmd.CommandText = "insert into subscriber(subscriber_id, name, address, email)"
                    + " values (@register_id, @register_name, @register_address, @register_email)";
                cmd.ExecuteNonQuery();

                trans.Commit();
            }
            catch (PostgresException exception)
            {
                trans.Rollback();
                MessageBox.Show(exception.Message);
            }
        }

        private void LoadSupplierStock()
        {
            stockSupplier.Columns.Clear();
            stockSupplier.Refresh();

            NpgsqlCommand cmd = new NpgsqlCommand(
                "select supplier, product.product_id, manufacturer, model, price"
                + " from (product join supplier_stock on product.product_id=supplier_stock.product_id)", myConn);
            NpgsqlDataReader dr = cmd.ExecuteReader();

            AddColumnNames(stockSupplier, dr);

            while (dr.Read())
            {
                stockSupplier.Rows.Add(AddDataToRow(dr));
            }
            dr.Close();
        }

        private void LoadStoreStock()
        {
            stockStore.Rows.Clear();
            stockStore.Refresh();

            NpgsqlCommand cmd = new NpgsqlCommand(
                "select product.*, quantity, price"
                + " from (product join store_stock on product.product_id=store_stock.product_id)", myConn);

            NpgsqlDataReader dr = cmd.ExecuteReader();

            AddColumnNames(stockStore, dr);

            while (dr.Read())
            {
                stockStore.Rows.Add(AddDataToRow(dr));
            }
            dr.Close();
        }

        private object StringOrNull(string aString)
        {
            if (aString != "")
            {
                return aString;
            }
            return DBNull.Value;
        }

        private void AddColumnNames(DataGridView dataGridView, NpgsqlDataReader dr)
        {
            dataGridView.ColumnCount = dr.FieldCount;
            for (int i = 0; i < dr.FieldCount; i++)
            {
                dataGridView.Columns[i].Name = dr.GetName(i);
            }
        }

        private string[] AddDataToRow(NpgsqlDataReader dr)
        {
            string[] row = new string[dr.FieldCount];
            for (int i = 0; i < dr.FieldCount; i++)
            {
                row[i] = dr[i].ToString();
            }

            return row;
        }
    }
}
