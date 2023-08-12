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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void hiring_and_firingBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hiring_and_firingBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hrDataSet);

        }

        private void Form16_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hrDataSet.hiring_and_firing". При необходимости она может быть перемещена или удалена.
            this.hiring_and_firingTableAdapter.Fill(this.hrDataSet.hiring_and_firing);

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
            hiring_and_firingBindingSource.Filter = "last_name='" + comboBox1.Text + "'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hiring_and_firingBindingSource.Filter = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < hiring_and_firingDataGridView.RowCount; i++)
            {
                hiring_and_firingDataGridView.Rows[i].Selected = false;
                for (int j = 0; j < hiring_and_firingDataGridView.ColumnCount; j++)
                    if (hiring_and_firingDataGridView.Rows[i].Cells[j].Value != null)
                        if (hiring_and_firingDataGridView.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            hiring_and_firingDataGridView.Rows[i].Selected = true;
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
                case 5:
                    Col = dataGridViewTextBoxColumn8;
                    break;
                case 6:
                    Col = dataGridViewTextBoxColumn9;
                    break;
                case 7:
                    Col = dataGridViewTextBoxColumn10;
                    break;
            }
            if (radioButton1.Checked)
                hiring_and_firingDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Ascending);
            else hiring_and_firingDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Descending);
        }
    }
    }


        
