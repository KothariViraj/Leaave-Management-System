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
    public partial class Employee : Form
    {
        Functions con;
        public Employee()
        {
            InitializeComponent();
            con = new Functions();
            ShowEmployees();
        }
        public void ShowEmployees()
        {
            String Query = "SELECT * FROM EmployeeTbl";
            Emp_GV.DataSource = con.GetData(Query);
        }
        private void Employee_Load(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if(txt_name.Text== ""||txt_e_phone.Text== "" || txt_password.Text == "" || txt_address.Text == ""||cb_gender.SelectedIndex== -1)
                {
                    MessageBox.Show("Missing Data!!");
                }
                else
                {
                    string Name = txt_name.Text;
                    string Gender = cb_gender.SelectedItem.ToString();
                    string Phone = txt_e_phone.Text;
                    string Pass = txt_password.Text;
                    string Address = txt_address.Text;
                    string Query = "Insert Into EmployeeTbl Values('{0}','{1}','{2}','{3}','{4}')";
                    Query = string.Format(Query, Name,Gender,Phone,Pass,Address);
                    con.SetData(Query);
                    ShowEmployees();
                    txt_name.Text = "";
                    txt_e_phone.Text = "";
                    txt_password.Text = "";
                    txt_address.Text = "";
                }
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        int Key = 0;
        private void Emp_GV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_name.Text = Emp_GV.SelectedRows[0].Cells[1].Value.ToString();
            cb_gender.Text = Emp_GV.SelectedRows[0].Cells[2].Value.ToString();
            txt_e_phone.Text = Emp_GV.SelectedRows[0].Cells[3].Value.ToString();
            txt_password.Text = Emp_GV.SelectedRows[0].Cells[4].Value.ToString();
            txt_address.Text = Emp_GV.SelectedRows[0].Cells[5].Value.ToString();

            if (txt_name.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(Emp_GV.SelectedRows[0].Cells[0].Value.ToString());
            }

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_name.Text == "" || txt_e_phone.Text == "" || txt_password.Text == "" || txt_address.Text == "" || cb_gender.SelectedIndex == -1)
                {
                    MessageBox.Show("Missing Data!!");
                }
                else
                {
                    string Name = txt_name.Text;
                    string Gender = cb_gender.SelectedItem.ToString();
                    string Phone = txt_e_phone.Text;
                    string Pass = txt_password.Text;
                    string Address = txt_address.Text;
                    string Query = "Update EmployeeTbl SET EmpName = '{0}',EmpGender = '{1}',EmpPhone = '{2}',EmpPass = '{3}',EmpAddress = '{4}' WHERE EmpId ={5} ";
                    Query = string.Format(Query, Name, Gender, Phone, Pass, Address,Key);
                    con.SetData(Query);
                    ShowEmployees();
                    MessageBox.Show("Employee Detail Updated...!!");
                    txt_name.Text = "";
                    txt_e_phone.Text = "";
                    txt_password.Text = "";
                    txt_address.Text = "";
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
                if (txt_name.Text == "" || txt_e_phone.Text == "" || txt_password.Text == "" || txt_address.Text == "" || cb_gender.SelectedIndex == -1)
                {
                    MessageBox.Show("Missing Data!!");
                }
                else
                {
                    string Name = txt_name.Text;
                    string Gender = cb_gender.SelectedItem.ToString();
                    string Phone = txt_e_phone.Text;
                    string Pass = txt_password.Text;
                    string Address = txt_address.Text;
                    string Query = "DELETE From EmployeeTbl  WHERE EmpId ={0} ";
                    Query = string.Format(Query, Key);
                    con.SetData(Query);
                    ShowEmployees();
                    MessageBox.Show("Employee Detail Deleted...!!");
                    txt_name.Text = "";
                    txt_e_phone.Text = "";
                    txt_password.Text = "";
                    txt_address.Text = "";
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Cate_Click(object sender, EventArgs e)
        {
            Categories obj = new Categories();
            obj.Show();
            this.Hide();
        }

        private void Leave_Click(object sender, EventArgs e)
        {
            Leaves obj = new Leaves();
            obj.Show();
            this.Hide();
        }
        private void label12_Click(object sender, EventArgs e)
        {

            Login obj = new Login();
            obj.Show();
            this.Hide(); 
        }
    }
}
