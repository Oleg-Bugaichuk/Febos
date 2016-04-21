using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace Febos
{
    public partial class FormPersonal : Form
    {
        private FormMain formMain;
       

        public FormPersonal(FormMain form)
        {
            InitializeComponent();
            this.formMain = form;

        }

        private void FormPersonal_FormClosed(object sender, FormClosedEventArgs e)
        {
            formMain.Show();
        }

        private void FormPersonal_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "febosDBDataSet.Personal". При необходимости она может быть перемещена или удалена.
            this.personalTableAdapter.Fill(this.febosDBDataSet.Personal);

        }

        private void buttonInsertPersonal_Click(object sender, EventArgs e)
        {
            ShowInsertPersonalForm();
        }

        private void ShowInsertPersonalForm()
        {
            FormInsertPersonal formInsertPersonal = new FormInsertPersonal();
            formInsertPersonal.Show();
            formInsertPersonal.Owner = this;
        }

        private void buttonPrintPersonal_Click(object sender, EventArgs e)//вывод на печать отчета о Персонале
        {

            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            //Книга.
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            //Таблица.
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
            ExcelApp.Columns.ColumnWidth = 15;
            Microsoft.Office.Interop.Excel.Range range;
            range = ExcelWorkSheet.UsedRange;
            range.get_Characters(1, dataGridViewPersonal.Rows.Count).Font.Bold = true;

            ExcelApp.Cells[1, 1] = "ФИО";
            ExcelApp.Cells[1, 2] = "Гражданство";
            ExcelApp.Cells[1, 3] = "Город проживания";
            ExcelApp.Cells[1, 4] = "Адрес";
            ExcelApp.Cells[1, 5] = "Дата рождения";
            ExcelApp.Cells[1, 6] = "ИИН";
            ExcelApp.Cells[1, 7] = "Должность";
            ExcelApp.Cells[1, 8] = "Телефон";
            ExcelApp.Cells[1, 7] = "Мобильный";


            for (int i = 0; i < dataGridViewPersonal.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridViewPersonal.ColumnCount; j++)
                {
                    ExcelApp.Cells[i + 2, j + 1] = dataGridViewPersonal.Rows[i].Cells[j].Value;
                }
            }
            //Вызываем нашу созданную эксельку.
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;  
        }
    }
}
