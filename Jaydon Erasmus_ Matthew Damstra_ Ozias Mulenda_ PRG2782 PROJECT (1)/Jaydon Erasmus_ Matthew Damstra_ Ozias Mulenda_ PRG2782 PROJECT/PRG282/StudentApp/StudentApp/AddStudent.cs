using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace StudentApp
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }
        
        private void btnAddStd_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Main.ConnectionString);

            if ((inputName.Text == "") || (inputSurname.Text == "") || (inputAddress.Text == "") || (inputGender.Text == "") || (inputImage.Text == "") )
            {
                MessageBox.Show("Please ensure all inputs are being met!");
            }
            else
            {

                string mdCodes = string.Empty;
                int count = 0;
                for (int i = 0; i < listbx.CheckedItems.Count; i++)
                {
                    if (count == 0)
                    {
                        mdCodes = listbx.CheckedItems[i].ToString();
                    }
                    else
                    {
                        mdCodes = mdCodes + "-" + listbx.CheckedItems[i].ToString();
                    }
                    count++;
                }
                SqlCommand cmd = new();
                cmd.Connection = conn;
         
                cmd.CommandText = $"Insert Into Students (StudentName, StudentSurname, StudentImage, DOB, Gender, Phone, StudentAddress, ModuleCodes) Values ('{inputName.Text}', '{inputSurname.Text}', '{inputImage.Text}', '{dt.Value.Date}','{inputGender.Text}','{inputPhone.Text}','{inputAddress.Text}', '{mdCodes}');";

                conn.Open();

                try
                {
                    cmd.ExecuteNonQuery();
                    conn.Close();


                    this.Close();

                }
                catch (Exception ed)
                {

                    MessageBox.Show("Error " + ed.Message);
                }
          

             
            }

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Main.ConnectionString);
            SqlCommand cmd = new();
            cmd.Connection = conn;
            cmd.CommandText = "Select ModuleCode FROM Modules;";
            conn.Open();
            SqlDataReader rdr = cmd.ExecuteReader();

            List<string> modulecodes = new();
            while (rdr.Read())
            {
                modulecodes.Add(rdr["ModuleCode"].ToString());
            }

            foreach (var item in modulecodes)
            {
                listbx.Items.Add(item);
            }

            conn.Close();
        }
    }
}
