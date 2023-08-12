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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void advanced_trainingBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.advanced_trainingBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hrDataSet);

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hrDataSet.advanced_training". При необходимости она может быть перемещена или удалена.
            this.advanced_trainingTableAdapter.Fill(this.hrDataSet.advanced_training);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            advanced_trainingBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            advanced_trainingBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            advanced_trainingBindingSource.AddNew();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            advanced_trainingBindingSource.MoveLast();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            advanced_trainingBindingSource.MoveNext();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            advanced_trainingBindingSource.RemoveCurrent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.advanced_trainingBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hrDataSet);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form15 TblForm = new Form15();
            TblForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
