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
    public partial class Больничные : Form
    {
        public Больничные()
        {
            InitializeComponent();
        }

        private void hospitalsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hospitalsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hrDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hrDataSet.hospitals". При необходимости она может быть перемещена или удалена.
            this.hospitalsTableAdapter.Fill(this.hrDataSet.hospitals);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            hospitalsBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hospitalsBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hospitalsBindingSource.AddNew();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hospitalsBindingSource.MoveLast();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            hospitalsBindingSource.MoveNext();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            hospitalsBindingSource.RemoveCurrent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hospitalsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hrDataSet);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form12 TblForm = new Form12();
            TblForm.Show();
        }
    }
}
