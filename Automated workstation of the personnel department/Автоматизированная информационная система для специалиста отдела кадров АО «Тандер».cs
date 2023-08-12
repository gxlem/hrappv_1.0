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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Отдел secondForm = new Отдел();
            secondForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Сотрудник threeForm = new Сотрудник();
            threeForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Больничные fourForm = new Больничные();
            fourForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Отпуск fiveForm = new Отпуск();
            fiveForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Поощрения sixForm = new Поощрения();
            sixForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form7 sevenForm = new Form7();
            sevenForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form8 eightForm = new Form8();
            eightForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
