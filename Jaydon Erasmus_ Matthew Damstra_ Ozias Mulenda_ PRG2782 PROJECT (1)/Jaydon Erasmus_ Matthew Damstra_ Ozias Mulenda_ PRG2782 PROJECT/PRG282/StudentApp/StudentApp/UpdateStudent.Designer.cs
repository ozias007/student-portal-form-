namespace StudentApp
{
    partial class UpdateStudent
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
            this.btnUpdateStd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.inputStudentNo = new System.Windows.Forms.TextBox();
            this.inputName = new System.Windows.Forms.TextBox();
            this.inputSurname = new System.Windows.Forms.TextBox();
            this.inputImage = new System.Windows.Forms.TextBox();
            this.inputGender = new System.Windows.Forms.TextBox();
            this.inputPhone = new System.Windows.Forms.TextBox();
            this.inputAddress = new System.Windows.Forms.TextBox();
            this.dt = new System.Windows.Forms.DateTimePicker();
            this.listbx = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUpdateStd
            // 
            this.btnUpdateStd.BackColor = System.Drawing.Color.Teal;
            this.btnUpdateStd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateStd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateStd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdateStd.Location = new System.Drawing.Point(35, 488);
            this.btnUpdateStd.Name = "btnUpdateStd";
            this.btnUpdateStd.Size = new System.Drawing.Size(133, 35);
            this.btnUpdateStd.TabIndex = 2;
            this.btnUpdateStd.Text = "Update Student";
            this.btnUpdateStd.UseVisualStyleBackColor = false;
            this.btnUpdateStd.Click += new System.EventHandler(this.btnAddStd_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(284, 488);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 35);
            this.button1.TabIndex = 14;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 31);
            this.label1.TabIndex = 15;
            this.label1.Text = "Fill In Student Details To Update";
            // 
            // inputStudentNo
            // 
            this.inputStudentNo.Location = new System.Drawing.Point(104, 78);
            this.inputStudentNo.Name = "inputStudentNo";
            this.inputStudentNo.PlaceholderText = "Student No";
            this.inputStudentNo.Size = new System.Drawing.Size(216, 24);
            this.inputStudentNo.TabIndex = 16;
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(104, 119);
            this.inputName.Name = "inputName";
            this.inputName.PlaceholderText = "Name";
            this.inputName.Size = new System.Drawing.Size(216, 24);
            this.inputName.TabIndex = 17;
            // 
            // inputSurname
            // 
            this.inputSurname.Location = new System.Drawing.Point(104, 164);
            this.inputSurname.Name = "inputSurname";
            this.inputSurname.PlaceholderText = "Surname";
            this.inputSurname.Size = new System.Drawing.Size(216, 24);
            this.inputSurname.TabIndex = 18;
            // 
            // inputImage
            // 
            this.inputImage.Location = new System.Drawing.Point(104, 208);
            this.inputImage.Name = "inputImage";
            this.inputImage.PlaceholderText = "Image Url";
            this.inputImage.Size = new System.Drawing.Size(216, 24);
            this.inputImage.TabIndex = 19;
            // 
            // inputGender
            // 
            this.inputGender.Location = new System.Drawing.Point(104, 307);
            this.inputGender.Name = "inputGender";
            this.inputGender.PlaceholderText = "Gender";
            this.inputGender.Size = new System.Drawing.Size(216, 24);
            this.inputGender.TabIndex = 21;
            // 
            // inputPhone
            // 
            this.inputPhone.Location = new System.Drawing.Point(104, 348);
            this.inputPhone.Name = "inputPhone";
            this.inputPhone.PlaceholderText = "Phone";
            this.inputPhone.Size = new System.Drawing.Size(216, 24);
            this.inputPhone.TabIndex = 22;
            // 
            // inputAddress
            // 
            this.inputAddress.Location = new System.Drawing.Point(104, 387);
            this.inputAddress.Name = "inputAddress";
            this.inputAddress.PlaceholderText = "Address";
            this.inputAddress.Size = new System.Drawing.Size(216, 24);
            this.inputAddress.TabIndex = 23;
            // 
            // dt
            // 
            this.dt.Location = new System.Drawing.Point(104, 267);
            this.dt.Name = "dt";
            this.dt.Size = new System.Drawing.Size(216, 24);
            this.dt.TabIndex = 24;
            // 
            // listbx
            // 
            this.listbx.ForeColor = System.Drawing.Color.DimGray;
            this.listbx.FormattingEnabled = true;
            this.listbx.Location = new System.Drawing.Point(104, 435);
            this.listbx.Name = "listbx";
            this.listbx.Size = new System.Drawing.Size(216, 23);
            this.listbx.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(104, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 26;
            this.label2.Text = "Date of Birth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(104, 414);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 18);
            this.label3.TabIndex = 27;
            this.label3.Text = "Module Codes";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(326, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 24);
            this.button2.TabIndex = 28;
            this.button2.Text = "Check";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UpdateStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(459, 560);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listbx);
            this.Controls.Add(this.dt);
            this.Controls.Add(this.inputAddress);
            this.Controls.Add(this.inputPhone);
            this.Controls.Add(this.inputGender);
            this.Controls.Add(this.inputImage);
            this.Controls.Add(this.inputSurname);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.inputStudentNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUpdateStd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UpdateStudent";
            this.Text = "UpdateStudent";
            this.Load += new System.EventHandler(this.UpdateStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnUpdateStd;
        private Button button1;
        private Label label1;
        private TextBox inputStudentNo;
        private TextBox inputName;
        private TextBox inputSurname;
        private TextBox inputImage;
        private TextBox inputGender;
        private TextBox inputPhone;
        private TextBox inputAddress;
        private DateTimePicker dt;
        private CheckedListBox listbx;
        private Label label2;
        private Label label3;
        private Button button2;
    }
}