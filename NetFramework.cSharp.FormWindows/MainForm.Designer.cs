namespace NetFramework.cSharp.FormWindows
{
    partial class MainForm
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
            this.txtNameMF = new System.Windows.Forms.TextBox();
            this.lblNameMF = new System.Windows.Forms.Label();
            this.txtSurnameMF = new System.Windows.Forms.TextBox();
            this.lblSurnameMF = new System.Windows.Forms.Label();
            this.txtUsernameMF = new System.Windows.Forms.TextBox();
            this.lblUsernameMF = new System.Windows.Forms.Label();
            this.txtPasswordMF = new System.Windows.Forms.TextBox();
            this.lblPasswordMF = new System.Windows.Forms.Label();
            this.txtCommentBelowMF = new System.Windows.Forms.TextBox();
            this.lblCommentBelowMF = new System.Windows.Forms.Label();
            this.btnUpdateMF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNameMF
            // 
            this.txtNameMF.Location = new System.Drawing.Point(89, 23);
            this.txtNameMF.Name = "txtNameMF";
            this.txtNameMF.Size = new System.Drawing.Size(121, 23);
            this.txtNameMF.TabIndex = 0;
            // 
            // lblNameMF
            // 
            this.lblNameMF.AutoSize = true;
            this.lblNameMF.Location = new System.Drawing.Point(29, 23);
            this.lblNameMF.Name = "lblNameMF";
            this.lblNameMF.Size = new System.Drawing.Size(39, 15);
            this.lblNameMF.TabIndex = 1;
            this.lblNameMF.Text = "Name";
            // 
            // txtSurnameMF
            // 
            this.txtSurnameMF.Location = new System.Drawing.Point(89, 69);
            this.txtSurnameMF.Name = "txtSurnameMF";
            this.txtSurnameMF.Size = new System.Drawing.Size(121, 23);
            this.txtSurnameMF.TabIndex = 0;
            // 
            // lblSurnameMF
            // 
            this.lblSurnameMF.AutoSize = true;
            this.lblSurnameMF.Location = new System.Drawing.Point(29, 69);
            this.lblSurnameMF.Name = "lblSurnameMF";
            this.lblSurnameMF.Size = new System.Drawing.Size(54, 15);
            this.lblSurnameMF.TabIndex = 1;
            this.lblSurnameMF.Text = "Surname";
            // 
            // txtUsernameMF
            // 
            this.txtUsernameMF.Location = new System.Drawing.Point(349, 25);
            this.txtUsernameMF.Name = "txtUsernameMF";
            this.txtUsernameMF.Size = new System.Drawing.Size(133, 23);
            this.txtUsernameMF.TabIndex = 0;
            // 
            // lblUsernameMF
            // 
            this.lblUsernameMF.AutoSize = true;
            this.lblUsernameMF.Location = new System.Drawing.Point(280, 25);
            this.lblUsernameMF.Name = "lblUsernameMF";
            this.lblUsernameMF.Size = new System.Drawing.Size(60, 15);
            this.lblUsernameMF.TabIndex = 1;
            this.lblUsernameMF.Text = "Username";
            // 
            // txtPasswordMF
            // 
            this.txtPasswordMF.Location = new System.Drawing.Point(349, 69);
            this.txtPasswordMF.Name = "txtPasswordMF";
            this.txtPasswordMF.Size = new System.Drawing.Size(133, 23);
            this.txtPasswordMF.TabIndex = 0;
            // 
            // lblPasswordMF
            // 
            this.lblPasswordMF.AutoSize = true;
            this.lblPasswordMF.Location = new System.Drawing.Point(280, 69);
            this.lblPasswordMF.Name = "lblPasswordMF";
            this.lblPasswordMF.Size = new System.Drawing.Size(57, 15);
            this.lblPasswordMF.TabIndex = 1;
            this.lblPasswordMF.Text = "Password";
            // 
            // txtCommentBelowMF
            // 
            this.txtCommentBelowMF.Location = new System.Drawing.Point(29, 138);
            this.txtCommentBelowMF.Multiline = true;
            this.txtCommentBelowMF.Name = "txtCommentBelowMF";
            this.txtCommentBelowMF.Size = new System.Drawing.Size(477, 70);
            this.txtCommentBelowMF.TabIndex = 0;
            // 
            // lblCommentBelowMF
            // 
            this.lblCommentBelowMF.AutoSize = true;
            this.lblCommentBelowMF.Location = new System.Drawing.Point(29, 120);
            this.lblCommentBelowMF.Name = "lblCommentBelowMF";
            this.lblCommentBelowMF.Size = new System.Drawing.Size(96, 15);
            this.lblCommentBelowMF.TabIndex = 1;
            this.lblCommentBelowMF.Text = "Comment Below";
            // 
            // btnUpdateMF
            // 
            this.btnUpdateMF.Location = new System.Drawing.Point(164, 225);
            this.btnUpdateMF.Name = "btnUpdateMF";
            this.btnUpdateMF.Size = new System.Drawing.Size(178, 23);
            this.btnUpdateMF.TabIndex = 2;
            this.btnUpdateMF.Text = "Update";
            this.btnUpdateMF.UseVisualStyleBackColor = true;
            this.btnUpdateMF.Click += new System.EventHandler(this.btnUpdateMF_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 260);
            this.Controls.Add(this.btnUpdateMF);
            this.Controls.Add(this.lblPasswordMF);
            this.Controls.Add(this.lblUsernameMF);
            this.Controls.Add(this.txtPasswordMF);
            this.Controls.Add(this.lblCommentBelowMF);
            this.Controls.Add(this.lblSurnameMF);
            this.Controls.Add(this.txtUsernameMF);
            this.Controls.Add(this.txtCommentBelowMF);
            this.Controls.Add(this.txtSurnameMF);
            this.Controls.Add(this.lblNameMF);
            this.Controls.Add(this.txtNameMF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtNameMF;
        private Label lblNameMF;
        private TextBox txtSurnameMF;
        private Label lblSurnameMF;
        private TextBox txtUsernameMF;
        private Label lblUsernameMF;
        private TextBox txtPasswordMF;
        private Label lblPasswordMF;
        private TextBox txtCommentBelowMF;
        private Label lblCommentBelowMF;
        private Button btnUpdateMF;
    }
}