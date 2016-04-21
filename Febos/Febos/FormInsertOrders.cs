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
using Word = Microsoft.Office.Interop.Word;


namespace Febos
{
    public partial class FormInsertOrders : Form
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;//строка подключения к базе 
        SqlConnection connection = new SqlConnection(connectionString);
        SqlCommand command = new SqlCommand();
        private readonly string filePath = Application.StartupPath + @"\shablons\Shablon_cvitancii.docx";
        private readonly string fileSavePath = Application.StartupPath + @"\shablons\result.docx";
        

        public FormInsertOrders()
        {
            InitializeComponent();
        }

        private void FormInsertOrders_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "febosDBDataSet.Personal". При необходимости она может быть перемещена или удалена.
            this.personalTableAdapter.Fill(this.febosDBDataSet.Personal);
            
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
           
            try
            {
            // sql запрос добавления заказа в базу
                command.Connection = connection;
                connection.Open();
                command.CommandText = "INSERT INTO Orders([Order], [DateOfAccess], [DateOfEnd], [TypeOfObject], [Brend], [Model], [SeryalNumber], [NameOfClient], [NameOfWorkman], [Money]) VALUES (N'" + textBoxOrder.Text + "', '" + dateTimePicker1.Value.ToString("MM-dd-yyyy") + "', '" + dateTimePicker2.Value.ToString("MM-dd-yyyy") + "', N'" + textBoxType.Text + "', N'" + textBoxBrend.Text + "', N'" + textBoxModel.Text + "', N'" + textBoxSeryal.Text + "', N'" + textBoxNameOfClient.Text + "', N'" + comboBoxNameOfWokman.Text + "', N'" + textBoxMoney.Text + "')";
                command.ExecuteNonQuery();
                connection.Close();



                //Создание шаблона чека. в документе Word
                var wordApp = new Word.Application();
                wordApp.Visible = false;
                var wordDocument = wordApp.Documents.Open(filePath);

                try
                {
                    ClassWordInsertText.InsertTextToDocument("{date}", dateTimePicker1.Text, wordDocument);
                    ClassWordInsertText.InsertTextToDocument("{date1}", dateTimePicker1.Text, wordDocument);
                    ClassWordInsertText.InsertTextToDocument("{order}", textBoxOrder.Text, wordDocument);
                    ClassWordInsertText.InsertTextToDocument("{FIOClient}", textBoxNameOfClient.Text, wordDocument);
                    ClassWordInsertText.InsertTextToDocument("{FIOWorkman}", comboBoxNameOfWokman.Text, wordDocument);
                    ClassWordInsertText.InsertTextToDocument("{Money}", textBoxMoney.Text, wordDocument);
                    wordDocument.SaveAs2(fileSavePath);
                    wordApp.Visible = true;
                }
                catch
                {
                    MessageBox.Show("Ошибка добавления текста в шаблон документа, для печати чека!!");
                }
                UpdateDGV();
                information("Заказ принят","");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Добавление не удалось. Проверьте правильность данных!!!");
            }
           
            
           
        }

       

        private void UpdateDGV()//метод обновления данных в дгв
        {
            FormOrders formOrders = this.Owner as FormOrders;
            formOrders.ordersTableAdapter.Fill(formOrders.febosDBDataSet.Orders);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        static void information(string information, string status)
        {
            FormTrayInformation trayInformation = new FormTrayInformation(information, status);
            trayInformation.Show();

        }
    }
}
