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
    public partial class FormAccessOrdersEnter : Form
    {
       
        static string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;//строка подключения к базе 
        SqlConnection connection = new SqlConnection(connectionString);//строка подключения
        SqlCommand command = new SqlCommand();



        public FormAccessOrdersEnter()
        {
            InitializeComponent();
        }

        private void FormAccessOrdersEnter_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "febosDBDataSet.Orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter.Fill(this.febosDBDataSet.Orders);

        }

        private void buttonInsertOrders_Click(object sender, EventArgs e)
        {
            EnterData();
            DeleteDataFromOrders();
            UpdateDGV();
            information("Заказ выполнен!","");
            this.Close();
            

        }

        private void UpdateDGV()//обновить данные в ДГВ
        {
            FormAccessOrders formAccess = this.Owner as FormAccessOrders;
            formAccess.accessOrdersTableAdapter.Fill(formAccess.febosDBDataSet.AccessOrders);
            
        }

        private void EnterData()//Вставить данные  в таблицу Выполненные заказы
        {
            int id = Int32.Parse(comboBoxId.Text);
            command.Connection = connection;
            connection.Open();
            command.CommandText = "DECLARE @Order NCHAR(10); DECLARE @DateOfAccess NCHAR(15); DECLARE @TypeOfObject NCHAR(15); DECLARE @Brend NCHAR(70); DECLARE @Model NCHAR(70); DECLARE @SeryalNumber NCHAR(70); DECLARE @NameOfClient NCHAR(70); DECLARE @NameOfWorkman NCHAR(70); DECLARE @Money NCHAR(70); SELECT @Order = [Order] FROM Orders WHERE  [NumberOfOrder] = '" + id + "' SELECT @DateOfAccess = [DateOfAccess] FROM Orders WHERE  [NumberOfOrder] = '" + id + "' SELECT @TypeOfObject = [TypeOfObject] FROM Orders WHERE  [NumberOfOrder] = '" + id + "' SELECT @Brend = [Brend] FROM Orders WHERE  [NumberOfOrder] = '" + id + "' SELECT @Model = [Model] FROM Orders WHERE  [NumberOfOrder] = '" + id + "' SELECT @SeryalNumber= [SeryalNumber] FROM Orders WHERE  [NumberOfOrder] = '" + id + "' SELECT @NameOfClient = [NameOfClient] FROM Orders WHERE  [NumberOfOrder] = '" + id + "' SELECT @NameOfWorkman = [NameOfWorkman] FROM Orders WHERE  [NumberOfOrder] = '" + id + "' SELECT @Money = [Money] FROM Orders WHERE  [NumberOfOrder] = '" + id + "' INSERT INTO AccessOrders ([NumberOfOrder], [Order], [DateOfAccess], [DateOfEnd], [TypeOfObject], [Brend], [Model], [SeryalNumber], [NameOfClient], [NameOfWorkman], [Money] ) VALUES ('" + id + "', @Order, @DateOfAccess, '" + dateTimePicker1.Value.ToString("MM-dd-yyyy") + "', @TypeOfObject, @Brend,  @Model, @SeryalNumber, @NameOfClient, @NameOfWorkman, @Money)";
            command.ExecuteNonQuery();
            connection.Close();
            
        }

        private void DeleteDataFromOrders()//удаление данных из таблицы Заказы
        {
            int id = Int32.Parse(comboBoxId.Text);
            command.Connection = connection;
            connection.Open();
            command.CommandText = "DELETE FROM Orders WHERE [NumberOfOrder] = '"+ id +"'";
            command.ExecuteNonQuery();
            connection.Close();
        }
        static void information(string information, string status)
        {
            FormTrayInformation trayInformation = new FormTrayInformation(information, status);
            trayInformation.Show();

        }
    }


}
