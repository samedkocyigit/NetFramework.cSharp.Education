namespace NetFramework.cSharp.FormWindows
{
    partial class NotificationTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSaveNT = new System.Windows.Forms.Button();
            this.txtPhoneNumberNT = new System.Windows.Forms.TextBox();
            this.txtEmailNT = new System.Windows.Forms.TextBox();
            this.txtSurnameNT = new System.Windows.Forms.TextBox();
            this.txtNameNT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstUser = new System.Windows.Forms.ListBox();
            this.ntfyNT = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSaveNT);
            this.groupBox1.Controls.Add(this.txtPhoneNumberNT);
            this.groupBox1.Controls.Add(this.txtEmailNT);
            this.groupBox1.Controls.Add(this.txtSurnameNT);
            this.groupBox1.Controls.Add(this.txtNameNT);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 188);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Customer";
            // 
            // btnSaveNT
            // 
            this.btnSaveNT.Location = new System.Drawing.Point(127, 149);
            this.btnSaveNT.Name = "btnSaveNT";
            this.btnSaveNT.Size = new System.Drawing.Size(152, 23);
            this.btnSaveNT.TabIndex = 4;
            this.btnSaveNT.Text = "Save";
            this.btnSaveNT.UseVisualStyleBackColor = true;
            this.btnSaveNT.Click += new System.EventHandler(this.btnSaveNT_Click);
            // 
            // txtPhoneNumberNT
            // 
            this.txtPhoneNumberNT.Location = new System.Drawing.Point(127, 120);
            this.txtPhoneNumberNT.Name = "txtPhoneNumberNT";
            this.txtPhoneNumberNT.Size = new System.Drawing.Size(152, 23);
            this.txtPhoneNumberNT.TabIndex = 3;
            // 
            // txtEmailNT
            // 
            this.txtEmailNT.Location = new System.Drawing.Point(127, 92);
            this.txtEmailNT.Name = "txtEmailNT";
            this.txtEmailNT.Size = new System.Drawing.Size(152, 23);
            this.txtEmailNT.TabIndex = 2;
            // 
            // txtSurnameNT
            // 
            this.txtSurnameNT.Location = new System.Drawing.Point(127, 63);
            this.txtSurnameNT.Name = "txtSurnameNT";
            this.txtSurnameNT.Size = new System.Drawing.Size(152, 23);
            this.txtSurnameNT.TabIndex = 1;
            // 
            // txtNameNT
            // 
            this.txtNameNT.Location = new System.Drawing.Point(127, 30);
            this.txtNameNT.Name = "txtNameNT";
            this.txtNameNT.Size = new System.Drawing.Size(152, 23);
            this.txtNameNT.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Phone Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // lstUser
            // 
            this.lstUser.AccessibleDescription = "";
            this.lstUser.AccessibleName = "";
            this.lstUser.FormattingEnabled = true;
            this.lstUser.ItemHeight = 15;
            this.lstUser.Location = new System.Drawing.Point(368, 29);
            this.lstUser.Name = "lstUser";
            this.lstUser.Size = new System.Drawing.Size(338, 184);
            this.lstUser.TabIndex = 0;
            this.lstUser.Tag = "";
            // 
            // ntfyNT
            // 
            this.ntfyNT.Text = "Number Of Users";
            this.ntfyNT.Visible = true;
            // 
            // NotificationTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 222);
            this.Controls.Add(this.lstUser);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NotificationTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NotificationTest";
            this.Load += new System.EventHandler(this.NotificationTest_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btnSaveNT;
        private TextBox txtPhoneNumberNT;
        private TextBox txtEmailNT;
        private TextBox txtSurnameNT;
        private TextBox txtNameNT;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ListBox lstUser;
        private NotifyIcon ntfyNT;
    }
}