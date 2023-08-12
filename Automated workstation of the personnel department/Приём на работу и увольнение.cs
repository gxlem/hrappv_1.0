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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void hiring_and_firingBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hiring_and_firingBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hrDataSet);

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hrDataSet.hiring_and_firing". При необходимости она может быть перемещена или удалена.
            this.hiring_and_firingTableAdapter.Fill(this.hrDataSet.hiring_and_firing);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            hiring_and_firingBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hiring_and_firingBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hiring_and_firingBindingSource.AddNew();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hiring_and_firingBindingSource.MoveLast();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            hiring_and_firingBindingSource.MoveNext();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            hiring_and_firingBindingSource.RemoveCurrent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hiring_and_firingBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hrDataSet);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form16 TblForm = new Form16();
            TblForm.Show();
        }
    }
}
