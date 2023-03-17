namespace StudentApp
{
    partial class Registration_form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtusername_register = new System.Windows.Forms.TextBox();
            this.txtpassword_register = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtconpassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Cheb_showPass = new System.Windows.Forms.CheckBox();
            this.btnregister = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(20, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Get started ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(20, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtusername_register
            // 
            this.txtusername_register.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtusername_register.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtusername_register.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtusername_register.Location = new System.Drawing.Point(20, 131);
            this.txtusername_register.Margin = new System.Windows.Forms.Padding(2);
            this.txtusername_register.Multiline = true;
            this.txtusername_register.Name = "txtusername_register";
            this.txtusername_register.Size = new System.Drawing.Size(295, 28);
            this.txtusername_register.TabIndex = 2;
            // 
            // txtpassword_register
            // 
            this.txtpassword_register.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtpassword_register.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpassword_register.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtpassword_register.Location = new System.Drawing.Point(22, 200);
            this.txtpassword_register.Margin = new System.Windows.Forms.Padding(2);
            this.txtpassword_register.Multiline = true;
            this.txtpassword_register.Name = "txtpassword_register";
            this.txtpassword_register.PasswordChar = '*';
            this.txtpassword_register.Size = new System.Drawing.Size(295, 28);
            this.txtpassword_register.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(22, 175);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // txtconpassword
            // 
            this.txtconpassword.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtconpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtconpassword.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtconpassword.Location = new System.Drawing.Point(20, 275);
            this.txtconpassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtconpassword.Multiline = true;
            this.txtconpassword.Name = "txtconpassword";
            this.txtconpassword.PasswordChar = '*';
            this.txtconpassword.Size = new System.Drawing.Size(295, 28);
            this.txtconpassword.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(20, 249);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Confirm password ";
            // 
            // Cheb_showPass
            // 
            this.Cheb_showPass.AutoSize = true;
            this.Cheb_showPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cheb_showPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cheb_showPass.ForeColor = System.Drawing.Color.Teal;
            this.Cheb_showPass.Location = new System.Drawing.Point(195, 314);
            this.Cheb_showPass.Margin = new System.Windows.Forms.Padding(2);
            this.Cheb_showPass.Name = "Cheb_showPass";
            this.Cheb_showPass.Size = new System.Drawing.Size(105, 19);
            this.Cheb_showPass.TabIndex = 7;
            this.Cheb_showPass.Text = "Show Password";
            this.Cheb_showPass.UseVisualStyleBackColor = true;
            this.Cheb_showPass.CheckedChanged += new System.EventHandler(this.Cheb_showPass_CheckedChanged);
            // 
            // btnregister
            // 
            this.btnregister.BackColor = System.Drawing.Color.Teal;
            this.btnregister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnregister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregister.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnregister.ForeColor = System.Drawing.Color.White;
            this.btnregister.Location = new System.Drawing.Point(55, 371);
            this.btnregister.Margin = new System.Windows.Forms.Padding(2);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(223, 31);
            this.btnregister.TabIndex = 8;
            this.btnregister.Text = "Register";
            this.btnregister.UseVisualStyleBackColor = false;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnclear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnclear.ForeColor = System.Drawing.Color.Teal;
            this.btnclear.Location = new System.Drawing.Point(55, 413);
            this.btnclear.Margin = new System.Windows.Forms.Padding(2);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(223, 31);
            this.btnclear.TabIndex = 9;
            this.btnclear.Text = "Cancel";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // Registration_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(340, 499);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.Cheb_showPass);
            this.Controls.Add(this.txtconpassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtpassword_register);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtusername_register);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Registration_form";
            this.Text = "Registration_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtusername_register;
        private TextBox txtpassword_register;
        private Label label3;
        private TextBox txtconpassword;
        private Label label4;
        private CheckBox Cheb_showPass;
        private Button btnregister;
        private Button btnclear;
    }
}