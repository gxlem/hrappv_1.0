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
    public partial class Authorization_frm : Form
    {
        public Authorization_frm()
        {
            InitializeComponent();
        }
        private int usID;
        private void Input_btn_Click(object sender, EventArgs e)
        {
            UsersDataContext db = new UsersDataContext();
            try
            {
                var user = (from u in db.User_tbl
                            where u.Login == Log_txt.Text
                            select u).ToArray();
                if (Log_txt.Text.Length == 0 || Pass_txt.Text.Length == 0)
                {
                    MessageBox.Show("Для входа в программу необходимо ввести логин и пароль");
                }
                else
                {
                    if (Log_txt.Text == user[0].Login)
                    {
                        if (Pass_txt.Text == user[0].Password)
                        {
                            DateTime d1 = DateTime.Now;
                            DateTime d2 = Convert.ToDateTime(user[0].Date);
                            TimeSpan d = d1 - d2;
                            if (Convert.ToInt32(d.ToString("dd")) > 30)
                            {
                                user[0].Active = false;
                                db.SubmitChanges();
                            }
                            if (user[0].Active == true)
                            {
                                if (Convert.ToInt32(d.ToString("dd")) >= 14)
                                {
                                    usID = user[0].ID;
                                    UpdatePass UpPas = new UpdatePass(this.usID);
                                    UpPas.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    if (user[0].Role == "Admin")
                                    {
                                        Admin_frm AdmFrm = new Admin_frm();
                                        AdmFrm.Show();
                                        this.Hide();
                                    }
                                    else
                                    {
                                        Form1 UserFrm = new Form1();
                                        UserFrm.Show();
                                        this.Hide();
                                    }
                                    user[0].Date = DateTime.Now;
                                    user[0].Count = 0;
                                    db.SubmitChanges();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Вы заблокированны. Обратитесь к администратору системы");
                            }
                        }
                        else
                        {
                            if (user[0].Count > 2)
                            {
                                user[0].Active = false;
                                db.SubmitChanges();
                                MessageBox.Show("Вы ввели не верный логин или пароль. Пожалуйста проверьте еще раз введенные данные");
                                user[0].Count += 1;
                                db.SubmitChanges();
                            }
                        }
                    }
                }
            }
            catch (SystemException)
            {
             //MessageBox.Show("Вы ввели не верный логин и пароль. Пожалуйста проверьте еще раз введеннеы данные");
            }
            }

        private void Authorization_frm_Load(object sender, EventArgs e)
        {

        }
    }
}
