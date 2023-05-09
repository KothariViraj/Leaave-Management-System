
namespace WindowsFormsApp1
{
    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Cate = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Leave = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Emp = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_e_phone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Emp_GV = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_gender = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Emp_GV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.Cate);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.Leave);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.Emp);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 743);
            this.panel1.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(38, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 17);
            this.label13.TabIndex = 29;
            this.label13.Text = "Leave M.S";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(52, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(42, 37);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 28;
            this.pictureBox5.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(74, 504);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 17);
            this.label12.TabIndex = 26;
            this.label12.Text = "Log out";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(27, 494);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(42, 37);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 27;
            this.pictureBox4.TabStop = false;
            // 
            // Cate
            // 
            this.Cate.AutoSize = true;
            this.Cate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cate.ForeColor = System.Drawing.Color.White;
            this.Cate.Location = new System.Drawing.Point(50, 328);
            this.Cate.Name = "Cate";
            this.Cate.Size = new System.Drawing.Size(76, 17);
            this.Cate.TabIndex = 24;
            this.Cate.Text = "Categories";
            this.Cate.Click += new System.EventHandler(this.Cate_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 318);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(42, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // Leave
            // 
            this.Leave.AutoSize = true;
            this.Leave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Leave.ForeColor = System.Drawing.Color.White;
            this.Leave.Location = new System.Drawing.Point(50, 275);
            this.Leave.Name = "Leave";
            this.Leave.Size = new System.Drawing.Size(54, 17);
            this.Leave.TabIndex = 22;
            this.Leave.Text = "Leaves";
            this.Leave.Click += new System.EventHandler(this.Leave_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 265);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // Emp
            // 
            this.Emp.AutoSize = true;
            this.Emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emp.ForeColor = System.Drawing.Color.White;
            this.Emp.Location = new System.Drawing.Point(50, 220);
            this.Emp.Name = "Emp";
            this.Emp.Size = new System.Drawing.Size(77, 17);
            this.Emp.TabIndex = 21;
            this.Emp.Text = "Employees";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 210);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(173, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(892, 43);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(296, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Employee Management System Version 1.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(541, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Manage Employees";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(197, 131);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(167, 26);
            this.txt_name.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(391, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Employee Gender";
            // 
            // txt_e_phone
            // 
            this.txt_e_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_e_phone.Location = new System.Drawing.Point(590, 131);
            this.txt_e_phone.Name = "txt_e_phone";
            this.txt_e_phone.Size = new System.Drawing.Size(167, 26);
            this.txt_e_phone.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(587, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Employee Phone";
            // 
            // txt_address
            // 
            this.txt_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address.Location = new System.Drawing.Point(590, 210);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(167, 26);
            this.txt_address.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(587, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Employee Address";
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(335, 210);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(167, 26);
            this.txt_password.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(332, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Employee Password";
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.Maroon;
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Location = new System.Drawing.Point(796, 130);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(113, 27);
            this.btn_edit.TabIndex = 14;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.DarkRed;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(796, 163);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(113, 27);
            this.btn_save.TabIndex = 15;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Red;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(796, 196);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(113, 27);
            this.btn_delete.TabIndex = 16;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Maroon;
            this.panel3.Location = new System.Drawing.Point(173, 245);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1013, 5);
            this.panel3.TabIndex = 17;
            // 
            // Emp_GV
            // 
            this.Emp_GV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Emp_GV.BackgroundColor = System.Drawing.Color.White;
            this.Emp_GV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Emp_GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Emp_GV.Location = new System.Drawing.Point(195, 298);
            this.Emp_GV.Name = "Emp_GV";
            this.Emp_GV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Emp_GV.Size = new System.Drawing.Size(850, 418);
            this.Emp_GV.TabIndex = 18;
            this.Emp_GV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Emp_GV_CellContentClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(563, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Employees List";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(194, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Employee Name";
            // 
            // cb_gender
            // 
            this.cb_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_gender.FormattingEnabled = true;
            this.cb_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cb_gender.Location = new System.Drawing.Point(394, 131);
            this.cb_gender.Name = "cb_gender";
            this.cb_gender.Size = new System.Drawing.Size(138, 28);
            this.cb_gender.TabIndex = 21;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1065, 743);
            this.Controls.Add(this.cb_gender);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Emp_GV);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_e_phone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Emp_GV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_e_phone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView Emp_GV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label Cate;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label Leave;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Emp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cb_gender;
    }
}