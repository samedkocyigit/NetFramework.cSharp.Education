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
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void textBox_Enter(object sender, EventArgs e)
        {
            TextBox T1 = (TextBox)sender;
            T1.Text = string.Empty;
            T1.BackColor = Color.Yellow;
        }
        private void txtBox_Leave(object sender, EventArgs e)
        {
            TextBox T1 = (TextBox)(sender);
            T1.BackColor = Color.White;
        }

        private void UserLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string _userName = txtBoxUsername.Text;
            string _password = txtBoxPassword.Text;
            User? findUser = temporaryDB.userDB.Find(i => i.userName == _userName && i.password == _password);

            if (findUser != null)
            {
                MainForm mainForm = new MainForm(findUser);
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Wrong Password or Username","Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void UserLogin_Load_1(object sender, EventArgs e)
        {

        }

        
    }
}
