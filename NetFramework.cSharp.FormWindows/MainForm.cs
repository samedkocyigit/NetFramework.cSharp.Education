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
    public partial class MainForm : Form
    {
        public MainForm(User username)
        {
            InitializeComponent();
            txtNameMF.Text = username.name;
            txtPasswordMF.Text = username.password;
            txtSurnameMF.Text = username.surname;
            txtUsernameMF.Enabled = false;
            txtCommentBelowMF.Text = username.commentBelow;
            btnUpdateMF.Tag = username.id;
        }

        private void btnUpdateMF_Click(object sender,EventArgs e)
        {
            int id = (int)btnUpdateMF.Tag;
            int index = temporaryDB.userDB.FindIndex(i=>i.id== id);
            temporaryDB.userDB[index].name = txtNameMF.Text;
            temporaryDB.userDB[index].surname= txtSurnameMF.Text;
            temporaryDB.userDB[index].password = txtPasswordMF.Text;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
