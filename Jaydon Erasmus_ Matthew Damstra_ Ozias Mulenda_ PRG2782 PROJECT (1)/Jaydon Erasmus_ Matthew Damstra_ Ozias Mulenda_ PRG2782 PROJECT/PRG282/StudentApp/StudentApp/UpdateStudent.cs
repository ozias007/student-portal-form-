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
    public partial class UpdateStudent : Form
    {
        public UpdateStudent()
        {
            InitializeComponent();
        }

        private void UpdateStudent_Load(object sender, EventArgs e)
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

            inputName.Enabled= false;
            inputAddress.Enabled= false;
            inputGender.Enabled= false;
            inputPhone.Enabled= false;
            inputSurname.Enabled= false;    
            dt.Enabled= false;
            listbx.Enabled= false;
            btnUpdateStd.Enabled= false;


        }

        public List<Student> students = new();
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Main.ConnectionString);
            SqlCommand cmd = new();
            cmd.Connection = conn;
            cmd.CommandText = "Select * FROM Students;";
            conn.Open();
            SqlDataReader rdr = cmd.ExecuteReader();

         
            try
            {
                while (rdr.Read())
                {
                    students.Add(new Student()
                    {
                        StudentNo = int.Parse(rdr["StudentNo"].ToString()),
                        Name = rdr["StudentName"].ToString(),
                        Surname = rdr["StudentSurname"].ToString(),
                        ImageUrl = rdr["StudentImage"].ToString(),
                        DOB = DateTime.Parse( rdr["DOB"].ToString()),
                        Gender = rdr["Gender"].ToString(),
                        Phone = rdr["Phone"].ToString(),
                        Address = rdr["StudentAddress"].ToString(),
                        ModuleCodes = rdr["ModuleCodes"].ToString()
                    });
                }
            }
            catch (Exception ed)
            {

                MessageBox.Show(ed.Message);
            }

            try
            {
                int studentNoToUpdate = int.Parse(inputStudentNo.Text);
                bool doesExist = false;
                Student studentToChange = new();

                foreach (var std in students)
                {
                    if (std.StudentNo == studentNoToUpdate)
                    {
                        doesExist= true;
                        studentToChange = std;
                    }
                }
                if (doesExist)
                {
                    inputName.Enabled = true;
                    inputAddress.Enabled = true;
                    inputGender.Enabled = true;
                    inputPhone.Enabled = true;
                    inputSurname.Enabled = true;
                    dt.Enabled = true;
                    listbx.Enabled = true;
                    btnUpdateStd.Enabled = true;

                    inputName.Text = studentToChange.Name;
                    inputImage.Text = studentToChange.ImageUrl;
                    inputGender.Text = studentToChange.Gender;
                    inputAddress.Text = studentToChange.Address;
                    inputPhone.Text = studentToChange.Phone;
                    inputSurname.Text= studentToChange.Surname;
                    dt.Value = studentToChange.DOB;
                

                    try
                    {
                        string[] tmps = studentToChange.ModuleCodes.Split("-");

                        foreach (var item in tmps)
                        {
                            for (int i = 0; i < listbx.Items.Count; i++)
                            {
                                if (listbx.Items[i].ToString() == item)
                                {
                                    listbx.SetItemChecked(i, true);
                                }
                            }
                        }
                    }
                    catch (Exception ed)
                    {

                        MessageBox.Show(ed.Message);
                    }
                  


                }
                else
                {
                    MessageBox.Show("Student doesn't exist!");
                }

            }
            catch (Exception ed)
            {

               MessageBox.Show(ed.Message);
            }
          
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddStd_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Main.ConnectionString);

            SqlCommand cmd = new();
            cmd.Connection = conn;

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

            cmd.CommandText = $"UPDATE Students SET StudentName = '{inputName.Text}', StudentSurname ='{inputSurname.Text}', StudentImage = '{inputImage.Text}', DOB = '{dt.Value.Date}', Gender = '{inputGender.Text}', Phone = '{inputPhone.Text}', StudentAddress = '{inputAddress.Text}', ModuleCodes = '{mdCodes}' WHERE StudentNo = '{inputStudentNo.Text}'";

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
}
