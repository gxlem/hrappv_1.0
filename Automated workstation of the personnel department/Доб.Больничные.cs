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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form12_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hrDataSet.hospitals". При необходимости она может быть перемещена или удалена.
            this.hospitalsTableAdapter.Fill(this.hrDataSet.hospitals);

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
            }
            if (radioButton1.Checked)
                hospitalsDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Ascending);
            else hospitalsDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Descending);
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
            hospitalsBindingSource.Filter = "last_name='" + comboBox1.Text + "'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hospitalsBindingSource.Filter = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < hospitalsDataGridView.RowCount; i++)
            {
                hospitalsDataGridView.Rows[i].Selected = false;
                for (int j = 0; j < hospitalsDataGridView.ColumnCount; j++)
                    if (hospitalsDataGridView.Rows[i].Cells[j].Value != null)
                        if (hospitalsDataGridView.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            hospitalsDataGridView.Rows[i].Selected = true;
                            break;
                        }
            }
            }
        }
    }
