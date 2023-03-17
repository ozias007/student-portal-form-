using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace StudentApp
{
    public partial class Registration_form : Form
    {
        Filehandler handler = new Filehandler();
        public Registration_form()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        public bool showPswrd = false;
        private void Cheb_showPass_CheckedChanged(object sender, EventArgs e)
        {
            showPswrd = !showPswrd;

            if (showPswrd)
            {
                txtpassword_register.PasswordChar ='\0';
                txtconpassword.PasswordChar = '\0';
            }
            else
            {
                txtpassword_register.PasswordChar = '*';
                txtconpassword.PasswordChar = '*';
            }
        }
         // function to go back to the login form if you already have an account 
        private void Lblihaveacount_Click(object sender, EventArgs e)
        {
            Login loging = new Login();
            loging.Show();
            this.Hide();
        }
         // function to close register
        private void btnclear_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //function to register 
        private void btnregister_Click(object sender, EventArgs e)
        {
            try
            {
                string password = txtpassword_register.Text;
                string username = txtusername_register.Text;
                string confermpassword = txtconpassword.Text;
                if (password == string.Empty || username == string.Empty || confermpassword == string.Empty)
                {
                    MessageBox.Show("please fill in  all fields ");
                }
                else if (password != confermpassword)
                {
                    MessageBox.Show("your passwords dont match");

                }
                else if( username!=null && confermpassword != null && password!=null && password==confermpassword )
                {
                    handler.writeRegistration(username, password);
                    txtconpassword.Clear();
                    txtusername_register.Clear();
                    txtpassword_register.Clear();
                }
            } catch(Exception exe)
            {
                MessageBox.Show("a error has occurred: "+ exe.Message);
            }
          

        }
    }
}
