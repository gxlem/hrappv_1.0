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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void vacationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vacationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hrDataSet);

        }

        private void Form13_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hrDataSet.vacation". При необходимости она может быть перемещена или удалена.
            this.vacationTableAdapter.Fill(this.hrDataSet.vacation);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vacationBindingSource1.Filter = "vid_otpuska= '" + comboBox1.Text + "'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            vacationBindingSource1.Filter = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < vacationDataGridView.RowCount; i++)
            {
                vacationDataGridView.Rows[i].Selected = false;
                for (int j = 0; j < vacationDataGridView.ColumnCount; j++)
                    if (vacationDataGridView.Rows[i].Cells[j].Value != null)
                        if (vacationDataGridView.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            vacationDataGridView.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DataGridViewColumn Col = new DataGridViewColumn();
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    Col = dataGridViewTextBoxColumn3;
                    break;
                case 1:
                    Col = dataGridViewTextBoxColumn4;
                    break;
                case 2:
                    Col = dataGridViewTextBoxColumn5;
                    break;
                case 3:
                    Col = dataGridViewTextBoxColumn6;
                    break;
                case 4:
                    Col = dataGridViewTextBoxColumn7;
                    break;
            }
            if (radioButton5.Checked)
                vacationDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Ascending);
            else vacationDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Descending);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

        

