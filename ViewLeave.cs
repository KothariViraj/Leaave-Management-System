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
    public partial class ViewLeave : Form
    {
        Functions con;

        public ViewLeave()
        {
            InitializeComponent();
            con = new Functions();
            EmpId_lbl.Text = Login.EmpId + "";
            EmpName_lbl.Text = Login.EmpName ;
            ShowLeave();
        }
        public void ShowLeave()
        {
            String Query = "SELECT * FROM LeaveTbl WHERE Employee = {0} ";
            Query = string.Format(Query, Login.EmpId);
            View_GV.DataSource = con.GetData(Query);
        }
        private void ViewLeave_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void Emp_Click(object sender, EventArgs e)
        {

        }
    }
}
