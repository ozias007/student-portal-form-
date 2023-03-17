namespace StudentApp
{
    partial class AddStudent
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
            this.btnAddStd = new System.Windows.Forms.Button();
            this.inputName = new System.Windows.Forms.TextBox();
            this.inputSurname = new System.Windows.Forms.TextBox();
            this.inputImage = new System.Windows.Forms.TextBox();
            this.inputGender = new System.Windows.Forms.TextBox();
            this.inputPhone = new System.Windows.Forms.TextBox();
            this.inputAddress = new System.Windows.Forms.TextBox();
            this.dt = new System.Windows.Forms.DateTimePicker();
            this.listbx = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddStd
            // 
            this.btnAddStd.BackColor = System.Drawing.Color.Teal;
            this.btnAddStd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddStd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddStd.Location = new System.Drawing.Point(57, 471);
            this.btnAddStd.Name = "btnAddStd";
            this.btnAddStd.Size = new System.Drawing.Size(133, 35);
            this.btnAddStd.TabIndex = 1;
            this.btnAddStd.Text = "Add Student";
            this.btnAddStd.UseVisualStyleBackColor = false;
            this.btnAddStd.Click += new System.EventHandler(this.btnAddStd_Click);
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(119, 71);
            this.inputName.Name = "inputName";
            this.inputName.PlaceholderText = "Name";
            this.inputName.Size = new System.Drawing.Size(207, 24);
            this.inputName.TabIndex = 2;
            // 
            // inputSurname
            // 
            this.inputSurname.Location = new System.Drawing.Point(119, 119);
            this.inputSurname.Name = "inputSurname";
            this.inputSurname.PlaceholderText = "Surname";
            this.inputSurname.Size = new System.Drawing.Size(207, 24);
            this.inputSurname.TabIndex = 3;
            // 
            // inputImage
            // 
            this.inputImage.Location = new System.Drawing.Point(119, 166);
            this.inputImage.Name = "inputImage";
            this.inputImage.PlaceholderText = "Image Url";
            this.inputImage.Size = new System.Drawing.Size(207, 24);
            this.inputImage.TabIndex = 4;
            // 
            // inputGender
            // 
            this.inputGender.Location = new System.Drawing.Point(119, 258);
            this.inputGender.Name = "inputGender";
            this.inputGender.PlaceholderText = "Gender";
            this.inputGender.Size = new System.Drawing.Size(207, 24);
            this.inputGender.TabIndex = 6;
            // 
            // inputPhone
            // 
            this.inputPhone.Location = new System.Drawing.Point(119, 304);
            this.inputPhone.Name = "inputPhone";
            this.inputPhone.PlaceholderText = "Phone";
            this.inputPhone.Size = new System.Drawing.Size(207, 24);
            this.inputPhone.TabIndex = 7;
            // 
            // inputAddress
            // 
            this.inputAddress.Location = new System.Drawing.Point(119, 350);
            this.inputAddress.Name = "inputAddress";
            this.inputAddress.PlaceholderText = "Address";
            this.inputAddress.Size = new System.Drawing.Size(207, 24);
            this.inputAddress.TabIndex = 8;
            // 
            // dt
            // 
            this.dt.CalendarForeColor = System.Drawing.Color.DimGray;
            this.dt.CalendarTitleForeColor = System.Drawing.Color.DimGray;
            this.dt.CustomFormat = "YYYY-MM-DD";
            this.dt.Location = new System.Drawing.Point(119, 218);
            this.dt.Name = "dt";
            this.dt.Size = new System.Drawing.Size(200, 24);
            this.dt.TabIndex = 10;
            // 
            // listbx
            // 
            this.listbx.ForeColor = System.Drawing.Color.DimGray;
            this.listbx.FormattingEnabled = true;
            this.listbx.Location = new System.Drawing.Point(119, 407);
            this.listbx.Name = "listbx";
            this.listbx.Size = new System.Drawing.Size(207, 23);
            this.listbx.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(96, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "Fill In Student Details";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(262, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 35);
            this.button1.TabIndex = 13;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(119, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Date of Birth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(119, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Module Codes";
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(457, 540);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listbx);
            this.Controls.Add(this.dt);
            this.Controls.Add(this.inputAddress);
            this.Controls.Add(this.inputPhone);
            this.Controls.Add(this.inputGender);
            this.Controls.Add(this.inputImage);
            this.Controls.Add(this.inputSurname);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.btnAddStd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddStudent";
            this.Text = "AddStudent";
            this.Load += new System.EventHandler(this.AddStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAddStd;
        private TextBox inputName;
        private TextBox inputSurname;
        private TextBox inputImage;
        private TextBox inputGender;
        private TextBox inputPhone;
        private TextBox inputAddress;
        private DateTimePicker dt;
        private CheckedListBox listbx;
        private Label label1;
        private Button button1;
        private Label label2;
        private Label label3;
    }
}