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
    public partial class NotificationTest : Form
    {
        public NotificationTest()
        {
            InitializeComponent();
        }

        private void btnSaveNT_Click(object sender, EventArgs e)
        {

            int resultProcess =addNewCustomer(new User()
            {
                id = 1,
                 name = txtNameNT.Text,
                  surname = txtSurnameNT.Text,
                   email = txtEmailNT.Text,
                    phoneNumber = txtPhoneNumberNT.Text
            });
            if (resultProcess > 0)
            {
                DialogResult result = MessageBox.Show("Do You Want to Add Another Customer?", "INFO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    showNotify();
                }
                else if (result == DialogResult.No)
                {
                    showNotify();
                }

                txtClear();
                showList();
            }
            else
            {
                MessageBox.Show("Failed to Adding New Customer", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void showNotify()
        {
            ntfyNT = new NotifyIcon();
            ntfyNT.Visible = true;
            ntfyNT.Icon = SystemIcons.Information;
            ntfyNT.BalloonTipText = "Number Of Users: " + temporaryDB.usersDB.Count().ToString();
            ntfyNT.BalloonTipTitle = "Information of number of users";
            ntfyNT.ShowBalloonTip(2000);
        }
        private void txtClear()
        {
            txtEmailNT.Text = string.Empty;
            txtNameNT.Text = string.Empty;
            txtPhoneNumberNT.Text = string.Empty;
            txtSurnameNT.Text = string.Empty;   
        }
        private void showList()
        {
            lstUser.DataSource = temporaryDB.usersDB;
        }
        private int addNewCustomer(User data)
        {
            temporaryDB.usersDB.Add(data);
            return 1;
        }

        private void NotificationTest_Load(object sender, EventArgs e)
        {

        }
    }
}
