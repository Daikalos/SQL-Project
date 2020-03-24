using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;

namespace SQL_Project
{
    public partial class StaffInterface : Form
    {
        private readonly NpgsqlConnection myConn;

        public StaffInterface()
        {
            InitializeComponent();

            this.menuStrip1.Items.OfType<ToolStripMenuItem>().ToList().ForEach(x =>
            {
                x.MouseHover += (obj, arg) => ((ToolStripDropDownItem)obj).ShowDropDown();
            });

            myConn = new NpgsqlConnection("Server=pgserver.mah.se; User Id=aj9191; Password=2z7gf3vz; Database=aj9191_bdb");
            myConn.Open();
        }

        private void productsItem_Click(object sender, EventArgs e)
        {
            dataGrid.Columns.Clear();
            dataGrid.Refresh();

            NpgsqlCommand cmd = new NpgsqlCommand("select * from product", myConn);
            NpgsqlDataReader dr = cmd.ExecuteReader();

            AddColumnNames(dataGrid, dr);

            while (dr.Read())
            {
                dataGrid.Rows.Add(AddDataToRow(dr));
            }
            dr.Close();
        }

        private void subscribersItem_Click(object sender, EventArgs e)
        {
            dataGrid.Columns.Clear();
            dataGrid.Refresh();

            NpgsqlCommand cmd = new NpgsqlCommand("select * from subscriber", myConn);
            NpgsqlDataReader dr = cmd.ExecuteReader();

            AddColumnNames(dataGrid, dr);

            while (dr.Read())
            {
                dataGrid.Rows.Add(AddDataToRow(dr));
            }
            dr.Close();
        }

        private void shoppingItem_Click(object sender, EventArgs e)
        {
            dataGrid.Columns.Clear();
            dataGrid.Refresh();

            NpgsqlCommand cmd = new NpgsqlCommand(
                "select transaction_id, subscriber.subscriber_id, subscriber.name, product.*, sale.quantity, sale.price, sale.time_of_sale" 
                + " from (sale join subscriber on sale.subscriber_id=subscriber.subscriber_id join product on sale.product_id=product.product_id)", myConn);
            NpgsqlDataReader dr = cmd.ExecuteReader();

            AddColumnNames(dataGrid, dr);

            while (dr.Read())
            {
                dataGrid.Rows.Add(AddDataToRow(dr));
            }
            dr.Close();
        }

        private void lastYearItem_Click(object sender, EventArgs e)
        {
            dataGrid.Columns.Clear();
            dataGrid.Refresh();

            NpgsqlCommand cmd = new NpgsqlCommand(
                "select subscriber.subscriber_id, subscriber.name, t.sum_price" 
                + " from (subscriber left join (select subscriber_id, sum(quantity * price) as sum_price from sale" 
                + " where time_of_sale > (current_date - interval '12 months') group by subscriber_id) t" 
                + " on subscriber.subscriber_id=t.subscriber_id)", myConn);
            NpgsqlDataReader dr = cmd.ExecuteReader();

            AddColumnNames(dataGrid, dr);

            while (dr.Read())
            {
                dataGrid.Rows.Add(AddDataToRow(dr));
            }
            dr.Close();
        }

        private void suppliersItem_Click(object sender, EventArgs e)
        {
            dataGrid.Columns.Clear();
            dataGrid.Refresh();

            NpgsqlCommand cmd = new NpgsqlCommand(
                "select * from supplier", myConn);
            NpgsqlDataReader dr = cmd.ExecuteReader();

            AddColumnNames(dataGrid, dr);

            while (dr.Read())
            {
                dataGrid.Rows.Add(AddDataToRow(dr));
            }
            dr.Close();
        }

        private void supplierStockItem_Click(object sender, EventArgs e)
        {
            dataGrid.Columns.Clear();
            dataGrid.Refresh();

            NpgsqlCommand cmd = new NpgsqlCommand(
                "select supplier, product.product_id, manufacturer, model, price" 
                + " from (product join supplier_stock on product.product_id=supplier_stock.product_id)", myConn);
            NpgsqlDataReader dr = cmd.ExecuteReader();

            AddColumnNames(dataGrid, dr);

            while (dr.Read())
            {
                dataGrid.Rows.Add(AddDataToRow(dr));
            }
            dr.Close();
        }

        private void lowestItem_Click(object sender, EventArgs e)
        {
            dataGrid.Columns.Clear();
            dataGrid.Refresh();

            NpgsqlCommand cmd = new NpgsqlCommand(
                "select product.product_id, product.manufacturer, product.model, supplier, t.min_price"
                + " from ((supplier_stock join (select product_id, min(price) as min_price from supplier_stock group by product_id) t"
                + " on supplier_stock.product_id=t.product_id and supplier_stock.price=t.min_price)"
                + " full outer join product on product.product_id=t.product_id)", myConn);
            NpgsqlDataReader dr = cmd.ExecuteReader();

            AddColumnNames(dataGrid, dr);

            while (dr.Read())
            {
                dataGrid.Rows.Add(AddDataToRow(dr));
            }
            dr.Close();
        }

        private void salesItem_Click(object sender, EventArgs e)
        {
            dataGrid.Columns.Clear();
            dataGrid.Refresh();

            NpgsqlCommand cmd = new NpgsqlCommand("select * from sale", myConn);
            NpgsqlDataReader dr = cmd.ExecuteReader();

            AddColumnNames(dataGrid, dr);

            while (dr.Read())
            {
                dataGrid.Rows.Add(AddDataToRow(dr));
            }
            dr.Close();
        }

        private void purchasesItem_Click(object sender, EventArgs e)
        {
            dataGrid.Columns.Clear();
            dataGrid.Refresh();

            NpgsqlCommand cmd = new NpgsqlCommand("select * from purchase", myConn);
            NpgsqlDataReader dr = cmd.ExecuteReader();

            AddColumnNames(dataGrid, dr);

            while (dr.Read())
            {
                dataGrid.Rows.Add(AddDataToRow(dr));
            }
            dr.Close();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            dataGrid.Columns.Clear();
            dataGrid.Refresh();
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
