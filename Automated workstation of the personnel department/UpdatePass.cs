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
    public partial class UpdatePass : Form
    {
        private int usID;
        public UpdatePass(int usID)
        {
            this.usID = usID;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsersDataContext db = new UsersDataContext();
            var user = (from u in db.User_tbl
                        where u.ID == usID
                        select u).ToArray();
            if (user[0].Password == textBox1.Text)
            {
                if (textBox2.Text == textBox3.Text)
                {
                    user[0].Password = textBox2.Text;
                    db.SubmitChanges();
                    MessageBox.Show("Смена пароля прошла успешно!");
                    user[0].Date = DateTime.Now;
                    user[0].Count = 0;
                    db.SubmitChanges();
                    if (user[0].Role == "Admin")
                    {
                        Admin_frm AdmFrm = new Admin_frm();
                        AdmFrm.Show();
                        this.Hide();
                    }
                    else
                    {
                        Root_frm UserFrm = new Root_frm();
                        UserFrm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Не проходит подтверждение нового пароля!");
                }
            }
            else
            {
                MessageBox.Show("Старый пароль не совпадает!");
            }
        }

        private void UpdatePass_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
                }

        private void UpdatePass_Load(object sender, EventArgs e)
        {

        }
    }

        }

