using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automated_workstation_of_the_personnel_department
{
    public partial class Admin_frm : Form
    {
        public Admin_frm()
        {
            InitializeComponent();
        }

        private void Admin_frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void User_tblBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.user_tblBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.securityDBDataSet);

        }

        private void Admin_frm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "securityDBDataSet.User_tbl". При необходимости она может быть перемещена или удалена.
            this.user_tblTableAdapter.Fill(this.securityDBDataSet.User_tbl);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            UsersDataContext db = new UsersDataContext();
            User_tbl UsTbl = new User_tbl();
            var user = (from u in db.User_tbl
                        where u.Login == textBox1.Text
                        select u).ToArray();
            if (user.Length == 0)
            {
                UsTbl.Login = textBox1.Text;
                UsTbl.Password = textBox2.Text;
                UsTbl.Role = textBox3.Text;
                UsTbl.Date = DateTime.Now;
                UsTbl.Active = true;
                UsTbl.Count = 0;
                db.User_tbl.InsertOnSubmit(UsTbl);
                db.SubmitChanges();
                user_tblTableAdapter.Fill(securityDBDataSet.User_tbl);
            }
            else
            {
                MessageBox.Show("Такой пользователь уже существует");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.user_tblBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.securityDBDataSet);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Authorization_frm AF = new Authorization_frm();
            AF.Show();
        }
    }
}
