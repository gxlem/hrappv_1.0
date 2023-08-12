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
    public partial class Отпуск : Form
    {
        public Отпуск()
        {
            InitializeComponent();
        }

        private void vacationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vacationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hrDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hrDataSet.vacation". При необходимости она может быть перемещена или удалена.
            this.vacationTableAdapter.Fill(this.hrDataSet.vacation);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            vacationBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vacationBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            vacationBindingSource.AddNew();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            vacationBindingSource.MoveLast();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            vacationBindingSource.MoveNext();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            vacationBindingSource.RemoveCurrent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vacationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hrDataSet);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form13 TblForm = new Form13();
            TblForm.Show();
        }
    }
}
