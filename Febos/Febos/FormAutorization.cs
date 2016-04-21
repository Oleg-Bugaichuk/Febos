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
    

    public partial class FormAutorization : Form
    {
        public string status;
        static string connectionString = ConfigurationManager.ConnectionStrings["connectionStringSign"].ConnectionString;//строка подключения к базе 
        SqlConnection connection = new SqlConnection(connectionString);
        SqlCommand command = new SqlCommand();
        private FormMain formMain;

        public FormAutorization(FormMain Form)
        {
            InitializeComponent();
            this.formMain = Form;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            formMain.Close();
            
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            try
            {
                
                // sql запрос добавления заказа в базу
                command.Connection = connection;
                connection.Open();
                command.CommandText = "SELECT * FROM Sign WHERE [login] = '"+ textBox1.Text +"'";
                command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string password = (string)reader["password"];
                    string status = (string)reader["status"];
                    status = status.Replace(" ", string.Empty);

                    password = password.Replace(" ", string.Empty);
                    if (textBox2.Text.ToString() == password)
                    {
                        switch (status)
                        {
                            case "Администратор":
                                formMain.buttonOrders.Enabled = true;
                                formMain.buttonPersonal.Enabled = true;
                                formMain.buttonInventory.Enabled = true;
                                formMain.buttonEnter.Visible = true;
                                formMain.buttonKassa.Enabled = true;
                                break;
                            case "Касса":
                                formMain.buttonKassa.Enabled = true;
                                break;
                            case "Персонал":
                                formMain.buttonPersonal.Enabled = true;
                                break;
                            case "Склад":
                                formMain.buttonInventory.Enabled = true;
                                break;
                            case "Заказы":
                                formMain.buttonOrders.Enabled = true;
                                break;
                            default:
                                break;
                        }

                        information(textBox1.Text, status);
                        formMain.Show();
                        this.Close();
                    }
                    else
                        MessageBox.Show("НЕ правильный пароль");
                }
    
                
                reader.Close();
                connection.Close();
                
            }
            catch
            {
                MessageBox.Show("Не правильно введен логин или пароль!");
            }
        }

        static void information(string information, string status)
        {
            information = "Вы вошли под учетной записью " + information;
            status = "Доступ: " + status;
            FormTrayInformation trayInformation = new FormTrayInformation(information, status);
            trayInformation.Show();

        }

        

    }
}
