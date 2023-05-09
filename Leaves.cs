using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Leaves : Form
    {
        Functions con;
        public Leaves()
        {
            InitializeComponent();
            con = new Functions();
            ShowLeave();
            GetEmployees();
            GetCategory();
        }
        public void ShowLeave()
        {
            String Query = "SELECT * FROM LeaveTbl";
            Leave_GV.DataSource = con.GetData(Query);
        }
        public void FilterLeave()
        {
            String Query = "SELECT * FROM LeaveTbl WHERE Status = '{0}' ";
            Query = string.Format(Query, cb_search.SelectedItem.ToString());
            Leave_GV.DataSource = con.GetData(Query);
        }
        public void GetEmployees()
        {
            string query = "SELECT * FROM EmployeeTbl";
            cb_emp_leave.DisplayMember = con.GetData(query).Columns["EmpName"].ToString();
            cb_emp_leave.ValueMember = con.GetData(query).Columns["EmpId"].ToString();
            cb_emp_leave.DataSource = con.GetData(query);
        }
        public void GetCategory()
        {
            string query = "SELECT * FROM CategoryTbl";
            cb_cate_leave.DisplayMember = con.GetData(query).Columns["CatName"].ToString();
            cb_cate_leave.ValueMember = con.GetData(query).Columns["CatId"].ToString();
            cb_cate_leave.DataSource = con.GetData(query);
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_cate_leave.SelectedIndex == -1 || cb_emp_leave.SelectedIndex == -1 || cb_status.SelectedIndex == -1)
                {
                    MessageBox.Show("Missing Data!!");
                }
                else
                {
                    int Emp = Convert.ToInt32(cb_emp_leave.SelectedValue.ToString());
                    int Category = Convert.ToInt32(cb_cate_leave.SelectedValue.ToString());

                    string DateStart = date_start.Value.Date.ToString("yyyy-MM-dd");
                    string DateEnd = date_end.Value.Date.ToString("yyyy-MM-dd");
                    string DateApplied = DateTime.Now.ToString("yyyy-MM-dd");
                    //string Status = cb_status.SelectedItem.ToString();
                    string Status = "Pending";
                    string Query = "Insert Into LeaveTbl Values({0},{1},'{2}','{3}','{4}','{5}')";
                    Query = string.Format(Query, Emp, Category, DateStart, DateEnd, DateApplied,Status);
                    con.SetData(Query);
                    ShowLeave();
                    MessageBox.Show("Leave Added...!");
                  
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        int Key = 0;
        private void Leave_GV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cb_emp_leave.Text = Leave_GV.SelectedRows[0].Cells[1].Value.ToString();
            cb_cate_leave.Text = Leave_GV.SelectedRows[0].Cells[2].Value.ToString();
            date_start.Text = Leave_GV.SelectedRows[0].Cells[3].Value.ToString();
            date_end.Text = Leave_GV.SelectedRows[0].Cells[4].Value.ToString();
            cb_status.Text = Leave_GV.SelectedRows[0].Cells[6].Value.ToString();

            if (cb_emp_leave.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(Leave_GV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_cate_leave.SelectedIndex == -1 || cb_emp_leave.SelectedIndex == -1 || cb_status.SelectedIndex == -1)
                {
                    MessageBox.Show("Missing Data!!");
                }
                else
                {
                    int Emp = Convert.ToInt32(cb_emp_leave.SelectedValue.ToString());
                    int Category = Convert.ToInt32(cb_cate_leave.SelectedValue.ToString());

                    string DateStart = date_start.Value.Date.ToString("yyyy-MM-dd");
                    string DateEnd = date_end.Value.Date.ToString("yyyy-MM-dd");
                    string DateApplied = DateTime.Now.ToString("yyyy-MM-dd");
                    string Status = cb_status.SelectedItem.ToString();
                    
                    string Query = "UPDATE  LeaveTbl SET Employee = {0},Category = {1},DateStart = '{2}',DateEnd = '{3}',Status = '{4}' WHERE LId={5} ";
                    Query = string.Format(Query, Emp, Category, DateStart, DateEnd,Status,Key);
                    con.SetData(Query);
                    ShowLeave();
                    MessageBox.Show("Leave Updated...!");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_cate_leave.SelectedIndex == -1 || cb_emp_leave.SelectedIndex == -1 || cb_status.SelectedIndex == -1)
                {
                    MessageBox.Show("Missing Data!!");
                }
                else
                {
                    string Query = "DELETE FROM LeaveTbl WHERE LId={0} ";
                    Query = string.Format(Query, Key);
                    con.SetData(Query);
                    ShowLeave();
                    MessageBox.Show("Leave Deleted...!");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            ShowLeave();
        }

        private void cb_refresh_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterLeave();
        }

        private void Leaves_Load(object sender, EventArgs e)
        {

        }

        private void Emp_Click(object sender, EventArgs e)
        {
            Employee obj = new Employee();
            obj.Show();
            this.Hide();
        }

        private void Cate_Click(object sender, EventArgs e)
        {
            Categories obj = new Categories();
            obj.Show();
            this.Hide();
        }
    }
}
