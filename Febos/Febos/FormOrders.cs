using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Febos
{
    public partial class FormOrders : Form
    {
        private FormMain formMain;
        
    
        public FormOrders(FormMain Form)
        {
            InitializeComponent();
            this.formMain = Form;
        }

        private void FormOrders_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "febosDBDataSet.Orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter.Fill(this.febosDBDataSet.Orders);
            
        }

        private void FormOrders_FormClosed(object sender, FormClosedEventArgs e)
        {
            formMain.Show();
            
        }

        private void buttonInsertOrders_Click(object sender, EventArgs e)
        {
            showFormInsert();
            
        }

        private void showFormInsert()// метод для создания экземпляра класса формы "Притнять Заказ"
        {
            FormInsertOrders show = new FormInsertOrders();
            show.Show();
            show.Owner = this;
        }

        private void buttonShowAccessOrders_Click(object sender, EventArgs e)
        {
            showFormAccessOrders();
        }

        private void showFormAccessOrders()// метод для создания экземпляра класса формы "Выполненные заказы"
        {
            FormAccessOrders Access = new FormAccessOrders();
            Access.Show();
            Access.Owner = this;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ordersTableAdapter.Fill(this.febosDBDataSet.Orders);
        }

    
    }
}
