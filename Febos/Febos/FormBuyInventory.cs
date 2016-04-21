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
    public partial class FormBuyInventory : Form
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;//строка подключения к базе 
        SqlConnection connection = new SqlConnection(connectionString);
        SqlCommand command = new SqlCommand();
        
        public FormBuyInventory()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            try
            {
                // sql запрос добавления заказа в базу
                command.Connection = connection;
                connection.Open();
                command.CommandText = "INSERT INTO Inventory([TypeOfObjects], [Brend], [Model], [SeryalNumber], [DateOfAccess], [Money]) VALUES (N'" + textBoxTypeObject.Text + "', N'" + textBoxBrend.Text + "', N'" + textBoxModel.Text + "', N'" + textBoxSeryalNumber.Text + "', N'" + dateInsert.Value.ToString("MM-dd-yyyy") + "', N'" + textBoxMoney.Text + "')";
                command.ExecuteNonQuery();
                connection.Close();
                UpdateDGV();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Добавление не удалось. Проверьте правильность данных!!!");
            }

            
        }

        private void UpdateDGV()
        {
            FormInventory formInventory = this.Owner as FormInventory;
            formInventory.inventoryTableAdapter.Fill(formInventory.febosDBDataSet.Inventory);
        }
    }
}
