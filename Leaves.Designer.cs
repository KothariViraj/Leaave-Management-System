
namespace WindowsFormsApp1
{
    partial class Leaves
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Leaves));
            this.label13 = new System.Windows.Forms.Label();
            this.Cate = new System.Windows.Forms.Label();
            this.Leave = new System.Windows.Forms.Label();
            this.Emp = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Leave_GV = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_edit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cb_cate_leave = new System.Windows.Forms.ComboBox();
            this.cb_emp_leave = new System.Windows.Forms.ComboBox();
            this.date_start = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.date_end = new System.Windows.Forms.DateTimePicker();
            this.cb_search = new System.Windows.Forms.ComboBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Leave_GV)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.Emp.Click += new System.EventHandler(this.Emp_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(576, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 20);
            this.label9.TabIndex = 39;
            this.label9.Text = "Leave List";
            // 
            // Leave_GV
            // 
            this.Leave_GV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Leave_GV.BackgroundColor = System.Drawing.Color.White;
            this.Leave_GV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Leave_GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Leave_GV.Location = new System.Drawing.Point(195, 352);
            this.Leave_GV.Name = "Leave_GV";
            this.Leave_GV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Leave_GV.Size = new System.Drawing.Size(858, 379);
            this.Leave_GV.TabIndex = 38;
            this.Leave_GV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Leave_GV_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Maroon;
            this.panel3.Location = new System.Drawing.Point(171, 245);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1015, 5);
            this.panel3.TabIndex = 37;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Red;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(794, 196);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(113, 27);
            this.btn_delete.TabIndex = 36;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.DarkRed;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(794, 163);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(113, 27);
            this.btn_save.TabIndex = 35;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(585, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(585, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Date Start";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(389, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Categories";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(192, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Employees";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(554, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Manage Leaves";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(286, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Employee Management System Version 1.0";
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.Maroon;
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Location = new System.Drawing.Point(794, 130);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(113, 27);
            this.btn_edit.TabIndex = 34;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(173, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1013, 43);
            this.panel2.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.pictureBox5);
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
            this.panel1.TabIndex = 22;
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
            // cb_cate_leave
            // 
            this.cb_cate_leave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_cate_leave.FormattingEnabled = true;
            this.cb_cate_leave.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cb_cate_leave.Location = new System.Drawing.Point(392, 131);
            this.cb_cate_leave.Name = "cb_cate_leave";
            this.cb_cate_leave.Size = new System.Drawing.Size(138, 28);
            this.cb_cate_leave.TabIndex = 40;
            // 
            // cb_emp_leave
            // 
            this.cb_emp_leave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_emp_leave.FormattingEnabled = true;
            this.cb_emp_leave.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cb_emp_leave.Location = new System.Drawing.Point(195, 130);
            this.cb_emp_leave.Name = "cb_emp_leave";
            this.cb_emp_leave.Size = new System.Drawing.Size(138, 28);
            this.cb_emp_leave.TabIndex = 41;
            // 
            // date_start
            // 
            this.date_start.CalendarForeColor = System.Drawing.Color.BurlyWood;
            this.date_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_start.Location = new System.Drawing.Point(588, 136);
            this.date_start.Name = "date_start";
            this.date_start.Size = new System.Drawing.Size(167, 23);
            this.date_start.TabIndex = 42;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Maroon;
            this.label14.Location = new System.Drawing.Point(330, 178);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 17);
            this.label14.TabIndex = 43;
            this.label14.Text = "Date End";
            // 
            // cb_status
            // 
            this.cb_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Items.AddRange(new object[] {
            "Pending",
            "Approved",
            "Rejected"});
            this.cb_status.Location = new System.Drawing.Point(588, 196);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(167, 28);
            this.cb_status.TabIndex = 45;
            // 
            // date_end
            // 
            this.date_end.CalendarForeColor = System.Drawing.Color.Maroon;
            this.date_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_end.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_end.Location = new System.Drawing.Point(333, 200);
            this.date_end.MaxDate = new System.DateTime(2023, 5, 13, 0, 0, 0, 0);
            this.date_end.Name = "date_end";
            this.date_end.Size = new System.Drawing.Size(167, 23);
            this.date_end.TabIndex = 46;
            // 
            // cb_search
            // 
            this.cb_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_search.FormattingEnabled = true;
            this.cb_search.Items.AddRange(new object[] {
            "Pending",
            "Approved",
            "Rejected"});
            this.cb_search.Location = new System.Drawing.Point(534, 297);
            this.cb_search.Name = "cb_search";
            this.cb_search.Size = new System.Drawing.Size(167, 28);
            this.cb_search.TabIndex = 47;
            this.cb_search.SelectedIndexChanged += new System.EventHandler(this.cb_refresh_SelectedIndexChanged);
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.DarkRed;
            this.btn_refresh.FlatAppearance.BorderSize = 0;
            this.btn_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.Location = new System.Drawing.Point(719, 297);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(113, 28);
            this.btn_refresh.TabIndex = 48;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // Leaves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1186, 743);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.cb_search);
            this.Controls.Add(this.date_end);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.date_start);
            this.Controls.Add(this.cb_emp_leave);
            this.Controls.Add(this.cb_cate_leave);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Leave_GV);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Leaves";
            this.Text = "Leaves";
            this.Load += new System.EventHandler(this.Leaves_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Leave_GV)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label Cate;
        private System.Windows.Forms.Label Leave;
        private System.Windows.Forms.Label Emp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView Leave_GV;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cb_cate_leave;
        private System.Windows.Forms.ComboBox cb_emp_leave;
        private System.Windows.Forms.DateTimePicker date_start;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.DateTimePicker date_end;
        private System.Windows.Forms.ComboBox cb_search;
        private System.Windows.Forms.Button btn_refresh;
    }
}