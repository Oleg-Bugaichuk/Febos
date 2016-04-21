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
    public partial class FormAccessOrders : Form
    {
        public FormAccessOrders()
        {
            InitializeComponent();
        }

       

        private void FormAccessOrders_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "febosDBDataSet.AccessOrders". При необходимости она может быть перемещена или удалена.
            this.accessOrdersTableAdapter.Fill(this.febosDBDataSet.AccessOrders);

        }

        private void buttonAccessOrders_Click(object sender, EventArgs e)
        {
            showFormAccessEnterOrders();
        }

       
        
        
        
        private void showFormAccessEnterOrders()//метод открытия формы принятия заказа как выполненный
        {
            FormAccessOrdersEnter showAccessOrdersEnter = new FormAccessOrdersEnter();
            showAccessOrdersEnter.Show();
            showAccessOrdersEnter.Owner = this;
        }

        private void FormAccessOrders_FormClosed(object sender, FormClosedEventArgs e)
        {
            UpdateDGVOrders();
        }

        private void UpdateDGVOrders()//обновить дгв Заказы
        {
            FormOrders formOrders;
            formOrders = this.Owner as FormOrders;
            formOrders.ordersTableAdapter.Fill(formOrders.febosDBDataSet.Orders);
        }
    }
}
