using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFramework.cSharp.FormWindows
{
    public partial class FormsTestTwo : Form
    {
        public FormsTestTwo()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            foreach (Form item in Application.OpenForms)
            {
                if(item.Name == "Form1")
                {
                    foreach ( Control formItem in item.Controls)
                    {
                        if (formItem is TextBox)
                        {
                            ((TextBox)formItem).Text = string.Empty;
                        }
                    }
                }
            }
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
           
        }
    }
}
