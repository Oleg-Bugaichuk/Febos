using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Febos
{
    public partial class FormTrayInformation : Form
    {
        

        public FormTrayInformation(string info, string dostup)
        { 
            InitializeComponent();
            labelInformation.Text = info;
            labelStatus.Text = dostup; 
            timer.Enabled = true;
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(60);
                this.Opacity = this.Opacity - 0.1;
            }
            this.Close();
        }

        
    }
}
