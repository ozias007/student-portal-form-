using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentApp
{
    public partial class AddModule : Form
    {
        public AddModule()
        {
            InitializeComponent();
        }

        private void btnAddStd_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Main.ConnectionString);

            if ((inputCode.Text == "") || (inputName.Text == "") || (inputDesc.Text == "") || (inputLinks.Text == ""))
            {
                MessageBox.Show("Please ensure all inputs are being met!");
            }
            else
            {
                SqlCommand cmd = new();
                cmd.Connection = conn;

                cmd.CommandText = $"Insert Into Modules (ModuleCode, ModuleName, ModuleDescription, Links) Values ('{inputCode.Text}', '{inputName.Text}', '{inputDesc.Text}', '{inputLinks.Text}');";

                conn.Open();

                try
                {
                    cmd.ExecuteNonQuery();

                }
                catch (Exception ed)
                {

                    MessageBox.Show("Error " + ed.Message);
                }


                conn.Close();


                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
