using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentApp
{
    
    public partial class Login : Form
    {
        List<Registration> allregistration  = new List<Registration>();

        Filehandler handler = new Filehandler();
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string password = txtpasswordlog.Text;
            string  username = TxTusernamelog.Text;
            if ( username==String.Empty || password==String.Empty)
            {
                MessageBox.Show("please fill in all fields ");
            }
         
          var test = handler.GetVerification(username,password);

            if (test)
            {
                TxTusernamelog.Text = "";
                txtpasswordlog.Text = "";
                Main main = new Main();
                main.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error, Incorrect details");
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        // function to  exit the logout form
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult exiting;
            exiting = MessageBox.Show("confirm if you want to Exit ", "exit application", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (exiting == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        //function to open the registration form 
        private void btnGotoRegister_Click(object sender, EventArgs e)
        {
            Registration_form registration = new Registration_form();
            registration.ShowDialog();
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
          
        }
    }
}
