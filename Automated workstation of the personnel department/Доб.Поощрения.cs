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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void encouragementBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.encouragementBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hrDataSet);

        }

        private void Form14_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hrDataSet.encouragement". При необходимости она может быть перемещена или удалена.
            this.encouragementTableAdapter.Fill(this.hrDataSet.encouragement);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Сортировать.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            encouragementBindingSource.Filter = "last_name='" + comboBox1.Text + "'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            encouragementBindingSource.Filter = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < encouragementDataGridView.RowCount; i++)
            {
                encouragementDataGridView.Rows[i].Selected = false;
                for (int j = 0; j < encouragementDataGridView.ColumnCount; j++)
                    if (encouragementDataGridView.Rows[i].Cells[j].Value != null)
                        if (encouragementDataGridView.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            encouragementDataGridView.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void Сортировать_Click(object sender, EventArgs e)
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
                encouragementDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Ascending);
            else encouragementDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Descending);
        }
    }
    }


        
