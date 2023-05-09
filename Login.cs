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
    public partial class Login : Form
    {
        Functions con;
        public Login()
        {
            InitializeComponent();
            con = new Functions();
        }
        public static int EmpId;
        public static string EmpName = "";
        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_un.Text == "" || txt_pass.Text == "")
            {
                MessageBox.Show("Missing Info...!");
            }
            else 
            {
                if(txt_un.Text == "Admin" || txt_pass.Text == "")
                {
                    Employee obj = new Employee();
                    obj.Show();
                    this.Hide();
                }
                else
                {
                    try
                    {
                            string query = "Select * From EmployeeTbl WHERE EmpName ='{0}'  AND EmpPass ='{1}' ";
                            query = string.Format(query, txt_un.Text, txt_pass.Text);
                            DataTable dt = con.GetData(query);
                               if (dt.Rows.Count == 0)
                                {
                                    MessageBox.Show("Incorrect Password...!");
                                    txt_un.Text = "";
                                    txt_pass.Text = "";
                                }
                                else
                                {
                                    EmpId = Convert.ToInt32(dt.Rows[0][0].ToString());
                                    EmpName = dt.Rows[0][1].ToString();
                                    ViewLeave obj = new ViewLeave();
                                    obj.Show();
                                    this.Hide();
                                }            
                    }
                    catch(Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }
                }
                
            }
        }

        private void Close_App_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
