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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hrDataSet);

        }

        private void Form11_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hrDataSet.employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.hrDataSet.employee);

        }

        private void employeeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            employeeBindingSource.Filter = "last_name='" + comboBox1.Text + "'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            employeeBindingSource.Filter = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < employeeDataGridView.RowCount; i++)
            {
                employeeDataGridView.Rows[i].Selected = false;
                for (int j = 0; j < employeeDataGridView.ColumnCount; j++)
                    if (employeeDataGridView.Rows[i].Cells[j].Value != null)
                        if (employeeDataGridView.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            employeeDataGridView.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
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
                case 8:
                    Col = dataGridViewTextBoxColumn11;
                    break;
                case 9:
                    Col = dataGridViewTextBoxColumn12;
                    break;
                case 10:
                    Col = dataGridViewTextBoxColumn13;
                    break;
            }
            if (radioButton1.Checked)
                employeeDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Ascending);
            else employeeDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Descending);
        }
    }
    }

        
    


