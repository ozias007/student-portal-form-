namespace StudentApp
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddStd = new System.Windows.Forms.Button();
            this.btnUpdateStd = new System.Windows.Forms.Button();
            this.btnDeleteStd = new System.Windows.Forms.Button();
            this.btnSearchStd = new System.Windows.Forms.Button();
            this.dbGrid = new System.Windows.Forms.DataGridView();
            this.inputStdSearch = new System.Windows.Forms.TextBox();
            this.rtConsole = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddMod = new System.Windows.Forms.Button();
            this.btnUpdateMod = new System.Windows.Forms.Button();
            this.btnSearchMod = new System.Windows.Forms.Button();
            this.inputModSearch = new System.Windows.Forms.TextBox();
            this.btnDeleteMod = new System.Windows.Forms.Button();
            this.inputDeleteStd = new System.Windows.Forms.TextBox();
            this.inputDeleteMod = new System.Windows.Forms.TextBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dbGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddStd
            // 
            this.btnAddStd.BackColor = System.Drawing.Color.Teal;
            this.btnAddStd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddStd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddStd.Location = new System.Drawing.Point(35, 432);
            this.btnAddStd.Name = "btnAddStd";
            this.btnAddStd.Size = new System.Drawing.Size(133, 35);
            this.btnAddStd.TabIndex = 0;
            this.btnAddStd.Text = "Add Student";
            this.btnAddStd.UseVisualStyleBackColor = false;
            this.btnAddStd.Click += new System.EventHandler(this.btnAddStd_Click);
            // 
            // btnUpdateStd
            // 
            this.btnUpdateStd.BackColor = System.Drawing.Color.Teal;
            this.btnUpdateStd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateStd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateStd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdateStd.Location = new System.Drawing.Point(191, 432);
            this.btnUpdateStd.Name = "btnUpdateStd";
            this.btnUpdateStd.Size = new System.Drawing.Size(133, 35);
            this.btnUpdateStd.TabIndex = 1;
            this.btnUpdateStd.Text = "Update Student";
            this.btnUpdateStd.UseVisualStyleBackColor = false;
            this.btnUpdateStd.Click += new System.EventHandler(this.btnUpdateStd_Click);
            // 
            // btnDeleteStd
            // 
            this.btnDeleteStd.BackColor = System.Drawing.Color.Teal;
            this.btnDeleteStd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteStd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteStd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeleteStd.Location = new System.Drawing.Point(657, 432);
            this.btnDeleteStd.Name = "btnDeleteStd";
            this.btnDeleteStd.Size = new System.Drawing.Size(133, 35);
            this.btnDeleteStd.TabIndex = 2;
            this.btnDeleteStd.Text = "Remove Student";
            this.btnDeleteStd.UseVisualStyleBackColor = false;
            this.btnDeleteStd.Click += new System.EventHandler(this.btnDeleteStd_Click);
            // 
            // btnSearchStd
            // 
            this.btnSearchStd.BackColor = System.Drawing.Color.Teal;
            this.btnSearchStd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchStd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearchStd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearchStd.Location = new System.Drawing.Point(641, 12);
            this.btnSearchStd.Name = "btnSearchStd";
            this.btnSearchStd.Size = new System.Drawing.Size(133, 35);
            this.btnSearchStd.TabIndex = 3;
            this.btnSearchStd.Text = "Search Student";
            this.btnSearchStd.UseVisualStyleBackColor = false;
            this.btnSearchStd.Click += new System.EventHandler(this.btnSearchStd_Click);
            // 
            // dbGrid
            // 
            this.dbGrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dbGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dbGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbGrid.Location = new System.Drawing.Point(-2, 1);
            this.dbGrid.Name = "dbGrid";
            this.dbGrid.RowHeadersWidth = 62;
            this.dbGrid.RowTemplate.Height = 25;
            this.dbGrid.Size = new System.Drawing.Size(623, 366);
            this.dbGrid.TabIndex = 5;
            // 
            // inputStdSearch
            // 
            this.inputStdSearch.Location = new System.Drawing.Point(641, 53);
            this.inputStdSearch.Name = "inputStdSearch";
            this.inputStdSearch.PlaceholderText = "Student No";
            this.inputStdSearch.Size = new System.Drawing.Size(133, 23);
            this.inputStdSearch.TabIndex = 6;
            // 
            // rtConsole
            // 
            this.rtConsole.Location = new System.Drawing.Point(644, 147);
            this.rtConsole.Name = "rtConsole";
            this.rtConsole.Size = new System.Drawing.Size(314, 248);
            this.rtConsole.TabIndex = 7;
            this.rtConsole.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(644, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 46);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(82, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Output Console";
            // 
            // btnAddMod
            // 
            this.btnAddMod.BackColor = System.Drawing.Color.Teal;
            this.btnAddMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddMod.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddMod.Location = new System.Drawing.Point(350, 432);
            this.btnAddMod.Name = "btnAddMod";
            this.btnAddMod.Size = new System.Drawing.Size(133, 35);
            this.btnAddMod.TabIndex = 10;
            this.btnAddMod.Text = "Add Module";
            this.btnAddMod.UseVisualStyleBackColor = false;
            this.btnAddMod.Click += new System.EventHandler(this.btnAddMod_Click);
            // 
            // btnUpdateMod
            // 
            this.btnUpdateMod.BackColor = System.Drawing.Color.Teal;
            this.btnUpdateMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateMod.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdateMod.Location = new System.Drawing.Point(502, 432);
            this.btnUpdateMod.Name = "btnUpdateMod";
            this.btnUpdateMod.Size = new System.Drawing.Size(133, 35);
            this.btnUpdateMod.TabIndex = 11;
            this.btnUpdateMod.Text = "Update Module";
            this.btnUpdateMod.UseVisualStyleBackColor = false;
            this.btnUpdateMod.Click += new System.EventHandler(this.btnUpdateMod_Click);
            // 
            // btnSearchMod
            // 
            this.btnSearchMod.BackColor = System.Drawing.Color.Teal;
            this.btnSearchMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearchMod.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearchMod.Location = new System.Drawing.Point(804, 12);
            this.btnSearchMod.Name = "btnSearchMod";
            this.btnSearchMod.Size = new System.Drawing.Size(133, 35);
            this.btnSearchMod.TabIndex = 12;
            this.btnSearchMod.Text = "Search Module";
            this.btnSearchMod.UseVisualStyleBackColor = false;
            this.btnSearchMod.Click += new System.EventHandler(this.btnSearchMod_Click);
            // 
            // inputModSearch
            // 
            this.inputModSearch.Location = new System.Drawing.Point(804, 53);
            this.inputModSearch.Name = "inputModSearch";
            this.inputModSearch.PlaceholderText = "Module Code";
            this.inputModSearch.Size = new System.Drawing.Size(133, 23);
            this.inputModSearch.TabIndex = 13;
            // 
            // btnDeleteMod
            // 
            this.btnDeleteMod.BackColor = System.Drawing.Color.Teal;
            this.btnDeleteMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteMod.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeleteMod.Location = new System.Drawing.Point(804, 432);
            this.btnDeleteMod.Name = "btnDeleteMod";
            this.btnDeleteMod.Size = new System.Drawing.Size(133, 35);
            this.btnDeleteMod.TabIndex = 16;
            this.btnDeleteMod.Text = "Remove Module";
            this.btnDeleteMod.UseVisualStyleBackColor = false;
            this.btnDeleteMod.Click += new System.EventHandler(this.btnDeleteMod_Click);
            // 
            // inputDeleteStd
            // 
            this.inputDeleteStd.Location = new System.Drawing.Point(657, 473);
            this.inputDeleteStd.Name = "inputDeleteStd";
            this.inputDeleteStd.PlaceholderText = "StudentNo";
            this.inputDeleteStd.Size = new System.Drawing.Size(133, 23);
            this.inputDeleteStd.TabIndex = 19;
            // 
            // inputDeleteMod
            // 
            this.inputDeleteMod.Location = new System.Drawing.Point(804, 473);
            this.inputDeleteMod.Name = "inputDeleteMod";
            this.inputDeleteMod.PlaceholderText = "ModuleCode";
            this.inputDeleteMod.Size = new System.Drawing.Size(133, 23);
            this.inputDeleteMod.TabIndex = 20;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Teal;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogout.Location = new System.Drawing.Point(35, 547);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(133, 35);
            this.btnLogout.TabIndex = 21;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(545, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 31);
            this.button1.TabIndex = 22;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(448, 373);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 31);
            this.button2.TabIndex = 23;
            this.button2.Text = "Modules";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(350, 373);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 31);
            this.button3.TabIndex = 24;
            this.button3.Text = "Students";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(967, 590);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.inputDeleteMod);
            this.Controls.Add(this.inputDeleteStd);
            this.Controls.Add(this.btnDeleteMod);
            this.Controls.Add(this.inputModSearch);
            this.Controls.Add(this.btnSearchMod);
            this.Controls.Add(this.btnUpdateMod);
            this.Controls.Add(this.btnAddMod);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rtConsole);
            this.Controls.Add(this.inputStdSearch);
            this.Controls.Add(this.dbGrid);
            this.Controls.Add(this.btnSearchStd);
            this.Controls.Add(this.btnDeleteStd);
            this.Controls.Add(this.btnUpdateStd);
            this.Controls.Add(this.btnAddStd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAddStd;
        private Button btnUpdateStd;
        private Button btnDeleteStd;
        private Button btnSearchStd;
        private DataGridView dbGrid;
        private TextBox inputStdSearch;
        private RichTextBox rtConsole;
        private Panel panel1;
        private Label label1;
        private Button btnAddMod;
        private Button btnUpdateMod;
        private Button btnSearchMod;
        private TextBox inputModSearch;
        private Button btnDeleteMod;
        private TextBox inputDeleteStd;
        private TextBox inputDeleteMod;
        private Button btnLogout;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}