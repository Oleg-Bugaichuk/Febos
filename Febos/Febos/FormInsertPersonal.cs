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
    public partial class FormInsertPersonal : Form
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;//строка подключения к базе
        SqlConnection connection = new SqlConnection(connectionString);
        SqlCommand command = new SqlCommand();
        private readonly string filePath = Application.StartupPath + @"\shablons\Shablon_Insert_Personal.docx";
        private readonly string fileSavePath = Application.StartupPath + @"\shablons\result_Personal.docx";
        
        
        public FormInsertPersonal()
        {
            InitializeComponent();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            try
            {
                // sql запрос добаление работника в базу
                command.Connection = connection;
                connection.Open();
                command.CommandText = "INSERT INTO Personal([Name(All)], [Ntionality], [City], [Adress], [DateOfBirth], [IIN], [Position], [Tel], [MobileTel]) VALUES (N'" + textBoxName.Text + "', N'" + textBoxNationality.Text + "', N'" + textBoxCity.Text + "', N'" + textBoxAdress.Text + "', '" + dateTimePickerBirth.Value.ToString("MM-dd-yyyy") + "', N'" + textBoxIIN.Text + "', N'" + textBoxPosition.Text + "', N'" + textBoxTel.Text + "', N'" + textBoxMobile.Text + "')";
                command.ExecuteNonQuery();
                connection.Close();
                information("Субъект добавлен в базу персонала!","");
            }
            catch
            {
                MessageBox.Show("Добавление не удалось. Проверьте правильность данных!!!");
            }


            //Создание шаблона чека. в документе Word
            var wordApp = new Word.Application();
            wordApp.Visible = false;
            var wordDocument = wordApp.Documents.Open(filePath);

            try
            {
                ClassWordInsertText.InsertTextToDocument("{Name}", textBoxName.Text, wordDocument);
                ClassWordInsertText.InsertTextToDocument("{IIN}", textBoxIIN.Text, wordDocument);
                ClassWordInsertText.InsertTextToDocument("{City}", textBoxCity.Text, wordDocument);
                ClassWordInsertText.InsertTextToDocument("{Adress}", textBoxAdress.Text, wordDocument);
                ClassWordInsertText.InsertTextToDocument("{Position}", textBoxPosition.Text, wordDocument);
                ClassWordInsertText.InsertTextToDocument("{Name1}", textBoxName.Text, wordDocument);
                ClassWordInsertText.InsertTextToDocument("{Adress1}", textBoxAdress.Text, wordDocument);
                ClassWordInsertText.InsertTextToDocument("{IIN1}", textBoxIIN.Text, wordDocument);
                ClassWordInsertText.InsertTextToDocument("{Name2}", textBoxName.Text, wordDocument);
                ClassWordInsertText.InsertTextToDocument("{Name3}", textBoxName.Text, wordDocument);
                ClassWordInsertText.InsertTextToDocument("{Adress2}", textBoxAdress.Text, wordDocument);
                ClassWordInsertText.InsertTextToDocument("{IIN2}", textBoxIIN.Text, wordDocument);
                ClassWordInsertText.InsertTextToDocument("{Name4}", textBoxName.Text, wordDocument);
                ClassWordInsertText.InsertTextToDocument("{Position1}", textBoxPosition.Text, wordDocument);
                ClassWordInsertText.InsertTextToDocument("{Name5}", textBoxName.Text, wordDocument);
                ClassWordInsertText.InsertTextToDocument("{Adress3}", textBoxAdress.Text, wordDocument);
                ClassWordInsertText.InsertTextToDocument("{IIN3}", textBoxIIN.Text, wordDocument);

                wordDocument.SaveAs2(fileSavePath);
                wordApp.Visible = true;
            }
            catch
            {
                MessageBox.Show("Ошибка добавления текста в шаблон документа, для печати чека!!");
            }
            UpdateDGV();

            this.Close();
        }


       

        private void UpdateDGV()//метод обновления дгв
        {
            FormPersonal formPersonal = this.Owner as FormPersonal;
            formPersonal.personalTableAdapter.Fill(formPersonal.febosDBDataSet.Personal);
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
