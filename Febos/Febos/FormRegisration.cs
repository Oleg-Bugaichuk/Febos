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
    public partial class FormRegisration : Form
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["connectionStringSign"].ConnectionString;//строка подключения к базе 
        SqlConnection connection = new SqlConnection(connectionString);
        SqlCommand command = new SqlCommand();

        public FormRegisration()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            try
            {
                // sql запрос добавления заказа в базу
                command.Connection = connection;
                connection.Open();
                command.CommandText = "INSERT INTO Sign([login], [password], [status]) VALUES (N'" + textBoxLogin.Text + "', N'" + textBoxPassword.Text + "', N'" + comboBoxStatus.Text + "')";
                command.ExecuteNonQuery();
                connection.Close();
                information("Пользователь зарегистрирован", "");
            }
            catch
            {
                MessageBox.Show("Регистрация не удалась");
            }
        }
        
        static void information(string information, string status)
        {
            
            FormTrayInformation trayInformation = new FormTrayInformation(information, status);
            trayInformation.Show();

        }
    }
}
