using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Runtime.Intrinsics.Arm;

namespace StudentApp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        // function to logout of the student app
        private void btnLogout_Click(object sender, EventArgs e)
        {
             DialogResult logingout= new DialogResult();
            logingout = MessageBox.Show("Are you sure you want to logout", "save data", MessageBoxButtons.YesNo);
            if(logingout == DialogResult.Yes)
            {
              
                this.Close();
            }
            
        }


        public static string ConnectionString = @"Server=localhost;Database=StudentsDB;Trusted_Connection=True;";
        public SqlConnection conn = new();
        public SqlDataReader reader = null;
        private void Main_Load(object sender, EventArgs e)
        {
            bool isConnected = false;

            try
            {
                conn = new SqlConnection(ConnectionString);
                conn.Open();

                SqlCommand command = new();
                command.Connection = conn;

                //Insert test modules into db

                //command.CommandText = "Insert Into Modules (ModuleCode, ModuleName, ModuleDescription, Links) values ('PRG281', 'Programming','This is a description of the subject', 'testlink.com');";
                //command.ExecuteNonQuery();
                //command.CommandText = "Insert Into Modules (ModuleCode, ModuleName, ModuleDescription, Links) values ('PRG282', 'Programming','This is a description of the subject', 'testlink.com');";
                //command.ExecuteNonQuery();
                //command.CommandText = "Insert Into Modules (ModuleCode, ModuleName, ModuleDescription, Links) values ('IOT281', 'Internet Of Things','This is a description of the subject', 'testlink.com');";
                //command.ExecuteNonQuery();
                //command.CommandText = "Insert Into Modules (ModuleCode, ModuleName, ModuleDescription, Links) values ('DBD281', 'Database Development','This is a description of the subject', 'testlink.com');";
                //command.ExecuteNonQuery();

                conn.Close();
                isConnected = true;
            }
            catch (Exception)
            {

                MessageBox.Show($"Connection Failed!");
                isConnected = false;
            }

            if (isConnected)
            {
                LoadGrid();

            }

        }

        public static SqlDataAdapter da = new SqlDataAdapter("Select * FROM Students;", new SqlConnection(ConnectionString));
        public static SqlDataAdapter daMd = new SqlDataAdapter("Select * FROM Modules;", new SqlConnection(ConnectionString));
        public static DataSet ds = new();
        public bool isStudents = true;
        // REFRESH/LOAD GRID
        public void LoadGrid()
        {
            dbGrid.DataSource = null;
            dbGrid.Rows.Clear();
            ds.Tables.Clear();

            if (isStudents)
            {
                da.Fill(ds);
            }
            else
            {
                daMd.Fill(ds);
            }


            dbGrid.ReadOnly = true;
            dbGrid.DataSource = ds.Tables[0];
        }

        private void btnAddStd_Click(object sender, EventArgs e)
        {
           
            AddStudent frm = new();
            frm.ShowDialog();

        }



        private void button1_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void btnAddMod_Click(object sender, EventArgs e)
        {
            AddModule frm = new();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            isStudents = true;
            LoadGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            isStudents = false;
            LoadGrid();
        }

        private void btnUpdateStd_Click(object sender, EventArgs e)
        {
            UpdateStudent frm = new();
            frm.ShowDialog();
        }

        private void btnUpdateMod_Click(object sender, EventArgs e)
        {
            UpdateModule frm = new();
            frm.ShowDialog();
        }

        private void btnDeleteStd_Click(object sender, EventArgs e)
        {
            int studentNoToDelete = int.Parse(inputDeleteStd.Text);
            SqlCommand cmd = new();

            cmd.Connection = conn;
            cmd.CommandText = $"Delete From Students Where StudentNo = '{studentNoToDelete}';";

            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
                conn.Close();
                LoadGrid();
            }
            catch (Exception ed)
            {

                MessageBox.Show(ed.Message);
            }
        }

        private void btnDeleteMod_Click(object sender, EventArgs e)
        {
            string modcodeToDelete = inputDeleteMod.Text.Trim().ToLower();

            SqlCommand cmd = new();

            cmd.Connection = conn;

            cmd.CommandText = $"Delete From Modules Where ModuleCode = '{modcodeToDelete}';";
            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
                conn.Close();
                LoadGrid();
            }
            catch (Exception ed)
            {

                MessageBox.Show(ed.Message);
            }
        }

        private void btnSearchStd_Click(object sender, EventArgs e)
        {
            int studentNoToSearch = int.Parse(inputStdSearch.Text);

            SqlCommand cmd = new();

            cmd.Connection = conn;

            cmd.CommandText = $"Select * From Students Where StudentNo = '{studentNoToSearch}';";
            conn.Open();
            SqlDataReader rdr = cmd.ExecuteReader();

            Student student = new();
            while (rdr.Read())
            {

                student.StudentNo = int.Parse(rdr["StudentNo"].ToString());
                student.Name = rdr["StudentName"].ToString();
                student.Surname = rdr["StudentSurname"].ToString();
                student.ImageUrl = rdr["StudentImage"].ToString();
                student.DOB = DateTime.Parse(rdr["DOB"].ToString());
                student.Gender = rdr["Gender"].ToString();
                student.Phone = rdr["Phone"].ToString();
                student.Address = rdr["StudentAddress"].ToString();
                student.ModuleCodes = rdr["ModuleCodes"].ToString();
            }

            if (!(string.IsNullOrEmpty(student.Name)))
            {
               
                rtConsole.Text = $"----Student Details---- {Environment.NewLine} Name: {student.Name} {Environment.NewLine} Surname: {student.Surname} {Environment.NewLine} Gender: {student.Gender} {Environment.NewLine} Address: {student.Address} {Environment.NewLine} DOB: {student.DOB.ToString("dd MMM yy")} {Environment.NewLine} Module Codes: {student.ModuleCodes} ";

            }
            else
            {
                rtConsole.Text = "Student not found";
            }


            conn.Close();
        }

        private void btnSearchMod_Click(object sender, EventArgs e)
        {
            string modcodeToSearch = inputModSearch.Text.Trim().ToLower();
            SqlCommand cmd = new();

            cmd.Connection = conn;

            cmd.CommandText = $"Select * From Modules Where ModuleCode = '{modcodeToSearch}';";

            conn.Open();
            SqlDataReader rdr = cmd.ExecuteReader();


            Module mod = new();
            while (rdr.Read())
            {

                mod.Code = rdr["ModuleCode"].ToString();
                mod.Links = rdr["Links"].ToString();
                mod.Description = rdr["ModuleDescription"].ToString();
                mod.Name = rdr["ModuleName"].ToString();
            }

            if (!(string.IsNullOrEmpty(mod.Name)))
            {

                rtConsole.Text = $"----Module Details---- {Environment.NewLine} Code: {mod.Code} {Environment.NewLine} Name: {mod.Name} {Environment.NewLine} Description: {mod.Description} {Environment.NewLine} Links: {mod.Links} ";

            }
            else
            {
                rtConsole.Text = "Module not found";
            }

            conn.Close();


        }
    }
}