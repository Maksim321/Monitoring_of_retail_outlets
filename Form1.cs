using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monitoring_of_retail_outlets
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Add_Outlets_Button_Click(object sender, EventArgs e)
        {
            getOutletsInfo.List_Outlets.Add(new COutlets(Outlets_Name_TB.Text));
            List_Of_Outlets_LB.Items.Add(Outlets_Name_TB.Text);
        }
        private void Config_Outlets_Button_Click(object sender, EventArgs e)
        {
            Add_Outlets_Form a = new Add_Outlets_Form();
            a.Owner = this;
            a.Show();
            a.Select();
        }
    }
}
