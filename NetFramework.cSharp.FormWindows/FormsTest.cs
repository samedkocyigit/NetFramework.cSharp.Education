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
    public partial class FormsTest : Form
    {
        public FormsTest()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FormsTestTwo formsTestTwo= new FormsTestTwo();

            ((TextBox)formsTestTwo.Controls["txtName"]).Text = txtName.Text;
            ((TextBox)formsTestTwo.Controls["txtSurame"]).Text = txtSurname.Text;
            ((TextBox)formsTestTwo.Controls["txtEmail"]).Text = txtEmail.Text;
            ((TextBox)formsTestTwo.Controls["txtNumber"]).Text = txtNumber.Text;
            
            formsTestTwo.ShowDialog();

            
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {

        }
    }
}
