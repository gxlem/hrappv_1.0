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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void advanced_trainingBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.advanced_trainingBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hrDataSet);

        }

        private void Form15_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hrDataSet.advanced_training". При необходимости она может быть перемещена или удалена.
            this.advanced_trainingTableAdapter.Fill(this.hrDataSet.advanced_training);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hrDataSet.advanced_training". При необходимости она может быть перемещена или удалена.
            this.advanced_trainingTableAdapter.Fill(this.hrDataSet.advanced_training);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            advanced_trainingBindingSource.Filter = "last_name= '" + comboBox1.Text + "'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            advanced_trainingBindingSource.Filter = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < advanced_trainingDataGridView.RowCount; i++)
            {
                advanced_trainingDataGridView.Rows[i].Selected = false;
                for (int j = 0; j < advanced_trainingDataGridView.ColumnCount; j++)
                    if (advanced_trainingDataGridView.Rows[i].Cells[j].Value != null)
                        if (advanced_trainingDataGridView.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            advanced_trainingDataGridView.Rows[i].Selected = true;
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
                case 8:
                    Col = dataGridViewTextBoxColumn11;
                    break;
                case 9:
                    Col = dataGridViewTextBoxColumn12;
                    break;
            }
            if (radioButton1.Checked)
                advanced_trainingDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Ascending);
            else advanced_trainingDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Descending);
        }
    }
    }

            
   
