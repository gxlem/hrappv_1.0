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
    public partial class Поощрения : Form
    {
        public Поощрения()
        {
            InitializeComponent();
        }

        private void encouragementBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.encouragementBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hrDataSet);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hrDataSet.encouragement". При необходимости она может быть перемещена или удалена.
            this.encouragementTableAdapter.Fill(this.hrDataSet.encouragement);

        }

        private void middle_nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void last_nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            encouragementBindingSource.MoveLast();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            encouragementBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            encouragementBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            encouragementBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            encouragementBindingSource.MoveNext();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            encouragementBindingSource.RemoveCurrent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.encouragementBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hrDataSet);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form14 TblForm = new Form14();
            TblForm.Show();
        }
    }
}
