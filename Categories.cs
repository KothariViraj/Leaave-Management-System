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
    public partial class Categories : Form
    {
        Functions con;
        public Categories()
        {
            InitializeComponent();
            con = new Functions();
            ShowCategories();
        }
        public void ShowCategories()
        {
            String Query = "SELECT * FROM CategoryTbl";
            Cate_GV.DataSource = con.GetData(Query);
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_cat_name.Text == "")
                {
                    MessageBox.Show("Missing Data!!");
                }
                else
                {
                    string Category =txt_cat_name.Text;
                    string Query = "Insert Into CategoryTbl Values('{0}')";
                    Query = string.Format(Query, Category);
                    con.SetData(Query);
                    ShowCategories();
                    txt_cat_name.Text = "";

                }
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        int Key = 0;
        private void Cate_GV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_cat_name.Text = Cate_GV.SelectedRows[0].Cells[1].Value.ToString();
            if (txt_cat_name.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(Cate_GV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_cat_name.Text == "")
                {
                    MessageBox.Show("Missing Data!!");
                }
                else
                {
                    string Category = txt_cat_name.Text;
                    string Query = "Update CategoryTbl SET CatName ='{0}' WHERE CatId={1}";
                    Query = string.Format(Query, Category,Key);
                    con.SetData(Query);
                    ShowCategories();
                    txt_cat_name.Text = "";
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
                if (Key==0)
                {
                    MessageBox.Show("Missing Data!!");
                }
                else
                {
                    string Category = txt_cat_name.Text;
                    string Query = "DELETE FROM CategoryTbl WHERE CatId={0}";
                    Query = string.Format(Query, Key);
                    con.SetData(Query);
                    ShowCategories();
                    txt_cat_name.Text = "";
                }
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Emp_Click(object sender, EventArgs e)
        {
            Employee obj = new Employee();
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

        }
    }
}
