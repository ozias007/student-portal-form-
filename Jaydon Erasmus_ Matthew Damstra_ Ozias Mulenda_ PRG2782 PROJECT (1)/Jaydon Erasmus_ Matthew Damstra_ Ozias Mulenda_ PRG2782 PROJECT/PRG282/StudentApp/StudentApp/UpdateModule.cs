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
    public partial class UpdateModule : Form
    {
        public UpdateModule()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateModule_Load(object sender, EventArgs e)
        {
            inputDesc.Enabled= false;
            inputLinks.Enabled= false;
            inputName.Enabled= false;   
           btnUpdateMod.Enabled= false;
        }

        public List<Module> modules = new();
        public string ModuleCodeToChange = string.Empty;
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Main.ConnectionString);
            SqlCommand cmd = new();
            cmd.Connection = conn;
            cmd.CommandText = "Select * FROM Modules;";
            conn.Open();
            SqlDataReader rdr = cmd.ExecuteReader();


            try
            {
                while (rdr.Read())
                {
                    modules.Add(new Module()
                    {
                     
                        Name = rdr["ModuleName"].ToString(),
                      Code = rdr["ModuleCode"].ToString().Trim().ToLower(),
                      Description = rdr["ModuleDescription"].ToString(),
                      Links = rdr["Links"].ToString()
                      
                    });
                }
            }
            catch (Exception ed)
            {

                MessageBox.Show(ed.Message);
            }

            try
            {
                string moduleCodeToUpdate = inputCode.Text.Trim().ToLower();
                bool doesExist = false;
               Module moduleToChange = new();

                foreach (var mod in modules)
                {
                    if (mod.Code == moduleCodeToUpdate)
                    {
                        doesExist = true;
                        moduleToChange = mod;
                        ModuleCodeToChange = moduleCodeToUpdate;
                    }
                }
                if (doesExist)
                {
                    inputName.Enabled = true;
                    inputDesc.Enabled = true;
                    inputLinks.Enabled= true;
                    btnUpdateMod.Enabled = true;

                    inputName.Text= moduleToChange.Name;
                    inputLinks.Text = moduleToChange.Links;
                    inputDesc.Text = moduleToChange.Description;
                }
                else
                {
                    MessageBox.Show("Module doesn't exist!");
                }

            }
            catch (Exception ed)
            {

                MessageBox.Show(ed.Message);
            }

        }

        private void btnUpdateMod_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Main.ConnectionString);

            SqlCommand cmd = new();
            cmd.Connection = conn;

           

            cmd.CommandText = $"UPDATE Modules SET ModuleCode = '{inputCode.Text}' ,ModuleName = '{inputName.Text}', ModuleDescription ='{inputDesc.Text}', Links = '{inputLinks.Text}' WHERE ModuleCode = '{ModuleCodeToChange}'";

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
