namespace employee
{
    partial class SearchUpdateDeleteEmployee
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchemp = new System.Windows.Forms.TextBox();
            this.updatebtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.genderCombo = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nic = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.RichTextBox();
            this.dobdate = new System.Windows.Forms.DateTimePicker();
            this.email = new System.Windows.Forms.TextBox();
            this.contactnum = new System.Windows.Forms.TextBox();
            this.fname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.depidcombo = new System.Windows.Forms.ComboBox();
            this.jobrolecombo = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.regdate = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.txtsalary = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.passwrdtxt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(454, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Search Employee";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Employee ID";
            // 
            // searchemp
            // 
            this.searchemp.Location = new System.Drawing.Point(281, 35);
            this.searchemp.Name = "searchemp";
            this.searchemp.Size = new System.Drawing.Size(148, 20);
            this.searchemp.TabIndex = 2;
            // 
            // updatebtn
            // 
            this.updatebtn.Location = new System.Drawing.Point(628, 425);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(83, 26);
            this.updatebtn.TabIndex = 5;
            this.updatebtn.Text = "Update Employee";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Location = new System.Drawing.Point(513, 425);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(84, 26);
            this.deletebtn.TabIndex = 6;
            this.deletebtn.Text = "Delete Employee";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.genderCombo);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.lname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nic);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.address);
            this.groupBox1.Controls.Add(this.dobdate);
            this.groupBox1.Controls.Add(this.email);
            this.groupBox1.Controls.Add(this.contactnum);
            this.groupBox1.Controls.Add(this.fname);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(12, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 370);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Information";
            // 
            // genderCombo
            // 
            this.genderCombo.FormattingEnabled = true;
            this.genderCombo.Location = new System.Drawing.Point(146, 106);
            this.genderCombo.Name = "genderCombo";
            this.genderCombo.Size = new System.Drawing.Size(205, 21);
            this.genderCombo.TabIndex = 19;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(17, 112);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 13);
            this.label17.TabIndex = 18;
            this.label17.Text = "Gender";
            // 
            // lname
            // 
            this.lname.Location = new System.Drawing.Point(146, 73);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(205, 20);
            this.lname.TabIndex = 17;
            this.lname.TextChanged += new System.EventHandler(this.lname_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Last Name";
            // 
            // nic
            // 
            this.nic.Location = new System.Drawing.Point(146, 338);
            this.nic.Name = "nic";
            this.nic.Size = new System.Drawing.Size(205, 20);
            this.nic.TabIndex = 13;
            this.nic.TextChanged += new System.EventHandler(this.nic_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 347);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "NIC Number";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(146, 263);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(205, 57);
            this.address.TabIndex = 11;
            this.address.Text = "";
            this.address.TextChanged += new System.EventHandler(this.address_TextChanged);
            // 
            // dobdate
            // 
            this.dobdate.Location = new System.Drawing.Point(146, 140);
            this.dobdate.Name = "dobdate";
            this.dobdate.Size = new System.Drawing.Size(205, 20);
            this.dobdate.TabIndex = 10;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(146, 221);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(205, 20);
            this.email.TabIndex = 8;
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // contactnum
            // 
            this.contactnum.Location = new System.Drawing.Point(146, 179);
            this.contactnum.Name = "contactnum";
            this.contactnum.Size = new System.Drawing.Size(205, 20);
            this.contactnum.TabIndex = 7;
            this.contactnum.TextChanged += new System.EventHandler(this.contactnum_TextChanged);
            // 
            // fname
            // 
            this.fname.Location = new System.Drawing.Point(146, 37);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(205, 20);
            this.fname.TabIndex = 6;
            this.fname.TextChanged += new System.EventHandler(this.fname_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "First  Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date Of Birth";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 182);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Contact No.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.passwrdtxt);
            this.groupBox2.Controls.Add(this.usernametxt);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.depidcombo);
            this.groupBox2.Controls.Add(this.jobrolecombo);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.regdate);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtsalary);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(429, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(388, 321);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Department Information";
            // 
            // depidcombo
            // 
            this.depidcombo.FormattingEnabled = true;
            this.depidcombo.Location = new System.Drawing.Point(181, 42);
            this.depidcombo.Name = "depidcombo";
            this.depidcombo.Size = new System.Drawing.Size(155, 21);
            this.depidcombo.TabIndex = 16;
            // 
            // jobrolecombo
            // 
            this.jobrolecombo.FormattingEnabled = true;
            this.jobrolecombo.Location = new System.Drawing.Point(181, 137);
            this.jobrolecombo.Name = "jobrolecombo";
            this.jobrolecombo.Size = new System.Drawing.Size(155, 21);
            this.jobrolecombo.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(28, 140);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "Job Role";
            // 
            // regdate
            // 
            this.regdate.Location = new System.Drawing.Point(181, 187);
            this.regdate.Name = "regdate";
            this.regdate.Size = new System.Drawing.Size(200, 20);
            this.regdate.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(25, 193);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "Date of Regisration";
            // 
            // txtsalary
            // 
            this.txtsalary.Location = new System.Drawing.Point(181, 90);
            this.txtsalary.Name = "txtsalary";
            this.txtsalary.Size = new System.Drawing.Size(155, 20);
            this.txtsalary.TabIndex = 7;
            this.txtsalary.TextChanged += new System.EventHandler(this.txtsalary_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Basic Salary";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Department ID";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 243);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Username";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 290);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Password";
            // 
            // usernametxt
            // 
            this.usernametxt.Location = new System.Drawing.Point(181, 243);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(155, 20);
            this.usernametxt.TabIndex = 19;
            // 
            // passwrdtxt
            // 
            this.passwrdtxt.Location = new System.Drawing.Point(181, 290);
            this.passwrdtxt.Name = "passwrdtxt";
            this.passwrdtxt.Size = new System.Drawing.Size(155, 20);
            this.passwrdtxt.TabIndex = 20;
            // 
            // SearchUpdateDeleteEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(845, 488);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.searchemp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "SearchUpdateDeleteEmployee";
            this.Text = "SearchUpdateDeleteEmployee";
            this.Load += new System.EventHandler(this.SearchUpdateDeleteEmployee_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchemp;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox genderCombo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox lname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nic;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox address;
        private System.Windows.Forms.DateTimePicker dobdate;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox contactnum;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox depidcombo;
        private System.Windows.Forms.ComboBox jobrolecombo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker regdate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtsalary;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox passwrdtxt;
        private System.Windows.Forms.TextBox usernametxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}