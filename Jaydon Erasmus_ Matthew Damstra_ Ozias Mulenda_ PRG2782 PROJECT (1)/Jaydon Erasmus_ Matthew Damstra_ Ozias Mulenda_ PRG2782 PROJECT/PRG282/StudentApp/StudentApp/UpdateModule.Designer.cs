namespace StudentApp
{
    partial class UpdateModule
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
            this.inputCode = new System.Windows.Forms.TextBox();
            this.inputName = new System.Windows.Forms.TextBox();
            this.inputDesc = new System.Windows.Forms.TextBox();
            this.inputLinks = new System.Windows.Forms.TextBox();
            this.btnUpdateMod = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(26, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 31);
            this.label1.TabIndex = 16;
            this.label1.Text = "Fill In Module Details To Update";
            // 
            // inputCode
            // 
            this.inputCode.Location = new System.Drawing.Point(110, 85);
            this.inputCode.Name = "inputCode";
            this.inputCode.PlaceholderText = "Module Code";
            this.inputCode.Size = new System.Drawing.Size(207, 23);
            this.inputCode.TabIndex = 18;
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(110, 131);
            this.inputName.Name = "inputName";
            this.inputName.PlaceholderText = "Name";
            this.inputName.Size = new System.Drawing.Size(207, 23);
            this.inputName.TabIndex = 19;
            // 
            // inputDesc
            // 
            this.inputDesc.Location = new System.Drawing.Point(110, 179);
            this.inputDesc.Name = "inputDesc";
            this.inputDesc.PlaceholderText = "Description";
            this.inputDesc.Size = new System.Drawing.Size(207, 23);
            this.inputDesc.TabIndex = 20;
            // 
            // inputLinks
            // 
            this.inputLinks.Location = new System.Drawing.Point(110, 232);
            this.inputLinks.Name = "inputLinks";
            this.inputLinks.PlaceholderText = "Links";
            this.inputLinks.Size = new System.Drawing.Size(207, 23);
            this.inputLinks.TabIndex = 21;
            // 
            // btnUpdateMod
            // 
            this.btnUpdateMod.BackColor = System.Drawing.Color.Teal;
            this.btnUpdateMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateMod.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdateMod.Location = new System.Drawing.Point(43, 382);
            this.btnUpdateMod.Name = "btnUpdateMod";
            this.btnUpdateMod.Size = new System.Drawing.Size(133, 35);
            this.btnUpdateMod.TabIndex = 22;
            this.btnUpdateMod.Text = "Update Module";
            this.btnUpdateMod.UseVisualStyleBackColor = false;
            this.btnUpdateMod.Click += new System.EventHandler(this.btnUpdateMod_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(261, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 35);
            this.button1.TabIndex = 23;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(356, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 24);
            this.button2.TabIndex = 29;
            this.button2.Text = "Check";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UpdateModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(459, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUpdateMod);
            this.Controls.Add(this.inputLinks);
            this.Controls.Add(this.inputDesc);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.inputCode);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateModule";
            this.Text = "UpdateModule";
            this.Load += new System.EventHandler(this.UpdateModule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox inputCode;
        private TextBox inputName;
        private TextBox inputDesc;
        private TextBox inputLinks;
        private Button btnUpdateMod;
        private Button button1;
        private Button button2;
    }
}