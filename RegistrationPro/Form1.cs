using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationPro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            modeDropDown.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modeDropDown.SelectedIndex == 1)
            {
                adminPasswordBox.Visible = true;
                adminPasswordLabel.Visible = true;
            }
            else
            {
                adminPasswordBox.Visible = false;
                adminPasswordLabel.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
