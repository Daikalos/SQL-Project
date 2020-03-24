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
    public partial class CustomerInterface : Form
    {
        private readonly NpgsqlConnection myConn;

        public CustomerInterface()
        {
            InitializeComponent();

            myConn = new NpgsqlConnection("Server=pgserver.mah.se; User Id=aj9191; Password=2z7gf3vz; Database=aj9191_bdb");
            myConn.Open();

            LoadStock();
        }

        private void LoadStock()
        {
            stockStore.Rows.Clear();
            stockStore.Refresh();

            NpgsqlCommand cmd = new NpgsqlCommand(
                "select manufacturer, model, quantity, price"
                + " from (product join store_stock on product.product_id=store_stock.product_id)", myConn);

            NpgsqlDataReader dr = cmd.ExecuteReader();

            AddColumnNames(stockStore, dr);

            while (dr.Read())
            {
                stockStore.Rows.Add(AddDataToRow(dr));
            }
            dr.Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            stockStore.Rows.Clear();
            stockStore.Refresh();

            NpgsqlCommand cmd = new NpgsqlCommand(
                "select manufacturer, model, quantity, price"
                + " from (product join store_stock on product.product_id=store_stock.product_id)"
                + " where lower(manufacturer) like @search_input"
                + " or lower(model) like @search_input", myConn);

            cmd.Parameters.AddWithValue("@search_input", "%" + SearchBox.Text.ToLower() + "%");

            NpgsqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                stockStore.Rows.Add(AddDataToRow(dr));
            }
            dr.Close();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            LoadStock();
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
