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
    public partial class Сотрудник : Form
    {
        public Сотрудник()
        {
            InitializeComponent();
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hrDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hrDataSet.employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.hrDataSet.employee);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            employeeBindingSource.MoveNext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            employeeBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            employeeBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            employeeBindingSource.AddNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hrDataSet);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            employeeBindingSource.MoveLast();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            employeeBindingSource.RemoveCurrent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form11 TblForm = new Form11();
            TblForm.Show();
        }
    }
}
