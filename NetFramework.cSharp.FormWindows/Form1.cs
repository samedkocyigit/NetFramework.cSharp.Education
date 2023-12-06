namespace NetFramework.cSharp.FormWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string secMessage = textMsg.Text;
            Form2 newForm= new Form2(secMessage);
            newForm.Show();
        }

        private void textMsg_Enter(object sender, EventArgs e)
        {
            TextBox t1 = (TextBox)sender;
            t1.Text = string.Empty;
            
        }
    }
}