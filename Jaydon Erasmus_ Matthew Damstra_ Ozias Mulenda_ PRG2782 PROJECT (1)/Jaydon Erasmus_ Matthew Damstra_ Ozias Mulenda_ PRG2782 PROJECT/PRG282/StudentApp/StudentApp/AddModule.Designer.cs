namespace StudentApp
{
    partial class AddModule
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
            this.btnAddStd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.inputName = new System.Windows.Forms.TextBox();
            this.inputCode = new System.Windows.Forms.TextBox();
            this.inputDesc = new System.Windows.Forms.TextBox();
            this.inputLinks = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(60, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "Fill In Module Details";
            // 
            // btnAddStd
            // 
            this.btnAddStd.BackColor = System.Drawing.Color.Teal;
            this.btnAddStd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddStd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddStd.Location = new System.Drawing.Point(31, 390);
            this.btnAddStd.Name = "btnAddStd";
            this.btnAddStd.Size = new System.Drawing.Size(133, 35);
            this.btnAddStd.TabIndex = 14;
            this.btnAddStd.Text = "Add Module";
            this.btnAddStd.UseVisualStyleBackColor = false;
            this.btnAddStd.Click += new System.EventHandler(this.btnAddStd_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(225, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 35);
            this.button1.TabIndex = 15;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(84, 135);
            this.inputName.Name = "inputName";
            this.inputName.PlaceholderText = "Name";
            this.inputName.Size = new System.Drawing.Size(207, 23);
            this.inputName.TabIndex = 16;
            // 
            // inputCode
            // 
            this.inputCode.Location = new System.Drawing.Point(84, 93);
            this.inputCode.Name = "inputCode";
            this.inputCode.PlaceholderText = "Module Code";
            this.inputCode.Size = new System.Drawing.Size(207, 23);
            this.inputCode.TabIndex = 17;
            // 
            // inputDesc
            // 
            this.inputDesc.Location = new System.Drawing.Point(84, 176);
            this.inputDesc.Name = "inputDesc";
            this.inputDesc.PlaceholderText = "Description";
            this.inputDesc.Size = new System.Drawing.Size(207, 23);
            this.inputDesc.TabIndex = 18;
            // 
            // inputLinks
            // 
            this.inputLinks.Location = new System.Drawing.Point(84, 226);
            this.inputLinks.Name = "inputLinks";
            this.inputLinks.PlaceholderText = "Links";
            this.inputLinks.Size = new System.Drawing.Size(207, 23);
            this.inputLinks.TabIndex = 19;
            // 
            // AddModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(395, 450);
            this.Controls.Add(this.inputLinks);
            this.Controls.Add(this.inputDesc);
            this.Controls.Add(this.inputCode);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddStd);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddModule";
            this.Text = "AddModule";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnAddStd;
        private Button button1;
        private TextBox inputName;
        private TextBox inputCode;
        private TextBox inputDesc;
        private TextBox inputLinks;
    }
}