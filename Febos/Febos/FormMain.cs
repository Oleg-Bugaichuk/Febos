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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonOrders_Click(object sender, EventArgs e)
        {
            FormOrdersLoad();
        }


        private void buttonPersonal_Click(object sender, EventArgs e)
        {
            FormPersonalLoad();
        }

        private void FormOrdersLoad()
        {
            FormOrders formOrders = new FormOrders(this);
            formOrders.Show();
            this.Hide();

        }

       
        
        
        private void FormPersonalLoad()
        {
            FormPersonal formPersonal = new FormPersonal(this);
            formPersonal.Show();
            this.Hide();
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            FormInfoLoad();
        }


        private void FormInfoLoad()
        {
            InfoAboutSystem formInfo = new InfoAboutSystem();
            formInfo.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonInventory_Click(object sender, EventArgs e)
        {
            FormInventory formInventory = new FormInventory(this);
            formInventory.Show();
            this.Hide();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            FormRegisration registration = new FormRegisration();
            registration.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.Hide();
            FormAutorization autorisation = new FormAutorization(this);
            autorisation.Show();
        }
       
    }
}
