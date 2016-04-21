using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Febos
{
    public partial class FormSellInventory : Form
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;//строка подключения к базе 
        SqlConnection connection = new SqlConnection(connectionString);
        SqlCommand command = new SqlCommand();
        
        public FormSellInventory()
        {
            InitializeComponent();
        }

        private void FormSellInventory_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "febosDBDataSet.Inventory". При необходимости она может быть перемещена или удалена.
            this.inventoryTableAdapter.Fill(this.febosDBDataSet.Inventory);

        }

      

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            
            command.Connection = connection;
            connection.Open();
            command.CommandText = "SELECT * FROM Inventory WHERE [SeryalNumber] = '" + comboBox1.Text + "'";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                labelInfo.Text = (string)reader["TypeOfObjects"] + "  " + (string)reader["Brend"];
            }
            reader.Close();
            connection.Close();
           
        }

        private void UpdateDGV()
        {
            FormInventory formInventory = this.Owner as FormInventory;
            formInventory.inventoryTableAdapter.Fill(formInventory.febosDBDataSet.Inventory);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            try
            {
                command.Connection = connection;
                connection.Open();
                command.CommandText = "DELETE FROM Inventory WHERE [SeryalNumber] = '" + comboBox1.Text + "'";
                command.ExecuteNonQuery();
                connection.Close();
                UpdateDGV();
            }
            catch
            {
                MessageBox.Show("Удаление не удалось");
            }
        }

       
    }
}
