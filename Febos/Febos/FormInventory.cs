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
    public partial class FormInventory : Form
    {
        private FormMain formMain;
        public FormInventory(FormMain Form)
        {
            InitializeComponent();
            this.formMain = Form;
        }

        private void FormInventory_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "febosDBDataSet.Inventory". При необходимости она может быть перемещена или удалена.
            this.inventoryTableAdapter.Fill(this.febosDBDataSet.Inventory);

        }

        private void FormInventory_FormClosed(object sender, FormClosedEventArgs e)
        {
            formMain.Show();
        }

        private void buttonInsertOrders_Click(object sender, EventArgs e)
        {
            FormBuyInventory formBuyInventory = new FormBuyInventory();

            formBuyInventory.Show();
            formBuyInventory.Owner = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormSellInventory formSellInventory = new FormSellInventory();
            formSellInventory.Show();
            formSellInventory.Owner = this;
        }
    }
}
