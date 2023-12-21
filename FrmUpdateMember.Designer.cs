namespace DatabaseConnect_ashReyes
{
    partial class FrmUpdateMember
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
            this.Lastname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Firstname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.StudID = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Program = new System.Windows.Forms.ComboBox();
            this.Middlename = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lastname
            // 
            this.Lastname.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Lastname.Location = new System.Drawing.Point(33, 123);
            this.Lastname.Name = "Lastname";
            this.Lastname.Size = new System.Drawing.Size(193, 26);
            this.Lastname.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 22;
            this.label2.Text = "Last name: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "Student ID: ";
            // 
            // Firstname
            // 
            this.Firstname.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Firstname.Location = new System.Drawing.Point(33, 182);
            this.Firstname.Name = "Firstname";
            this.Firstname.Size = new System.Drawing.Size(193, 26);
            this.Firstname.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 19);
            this.label4.TabIndex = 25;
            this.label4.Text = "First name: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 19);
            this.label7.TabIndex = 32;
            this.label7.Text = "Middle name:";
            // 
            // Age
            // 
            this.Age.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Age.Location = new System.Drawing.Point(33, 300);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(193, 26);
            this.Age.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 19);
            this.label3.TabIndex = 34;
            this.label3.Text = "Age:";
            // 
            // Gender
            // 
            this.Gender.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Gender.FormattingEnabled = true;
            this.Gender.Location = new System.Drawing.Point(33, 359);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(193, 27);
            this.Gender.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 19);
            this.label5.TabIndex = 36;
            this.label5.Text = "Gender:";
            // 
            // StudID
            // 
            this.StudID.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.StudID.FormattingEnabled = true;
            this.StudID.Location = new System.Drawing.Point(33, 63);
            this.StudID.Name = "StudID";
            this.StudID.Size = new System.Drawing.Size(193, 27);
            this.StudID.TabIndex = 42;
            this.StudID.SelectedIndexChanged += new System.EventHandler(this.StudID_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 393);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 19);
            this.label6.TabIndex = 43;
            this.label6.Text = "Program:";
            // 
            // Program
            // 
            this.Program.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Program.FormattingEnabled = true;
            this.Program.Location = new System.Drawing.Point(33, 419);
            this.Program.Name = "Program";
            this.Program.Size = new System.Drawing.Size(193, 27);
            this.Program.TabIndex = 44;
            // 
            // Middlename
            // 
            this.Middlename.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Middlename.Location = new System.Drawing.Point(34, 235);
            this.Middlename.Name = "Middlename";
            this.Middlename.Size = new System.Drawing.Size(193, 26);
            this.Middlename.TabIndex = 45;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnConfirm.Location = new System.Drawing.Point(85, 455);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(91, 31);
            this.btnConfirm.TabIndex = 46;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // FrmUpdateMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(260, 497);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.Middlename);
            this.Controls.Add(this.Program);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.StudID);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Firstname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Lastname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmUpdateMember";
            this.Text = "FrmUpdateMember";
            this.Load += new System.EventHandler(this.FrmUpdateMember_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Lastname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Firstname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Age;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Gender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox StudID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Program;
        private System.Windows.Forms.TextBox Middlename;
        private System.Windows.Forms.Button btnConfirm;
    }
}