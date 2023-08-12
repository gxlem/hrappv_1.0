using System;
using System.Windows.Forms;

namespace Automated_workstation_of_the_personnel_department
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }



        private void OtdelBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.otdelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hrDataSet);

        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hrDataSet.otdel". При необходимости она может быть перемещена или удалена.
            this.otdelTableAdapter.Fill(this.hrDataSet.otdel);

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            otdelBindingSource.Filter = "";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            otdelBindingSource.Filter = "name='" + comboBox1.Text + "'";
        }

        private void Button1_Click(object sender, EventArgs e, DataGridViewTextBoxColumn col, DataGridViewTextBoxColumn dataGridViewTextBoxColumn4, DataGridViewTextBoxColumn dataGridViewTextBoxColumn5, DataGridViewTextBoxColumn dataGridViewTextBoxColumn7, DataGridViewTextBoxColumn dataGridViewTextBoxColumn8, DataGridViewTextBoxColumn dataGridViewTextBoxColumn12, DataGridViewTextBoxColumn dataGridViewTextBoxColumn11, DataGridViewTextBoxColumn dataGridViewTextBoxColumn10, DataGridViewTextBoxColumn dataGridViewTextBoxColumn9)
        {
            if (sender is null)
            {
                throw new ArgumentNullException(nameof(sender));
            }

            DataGridViewTextBoxColumn dataGridViewTextBoxColumn6 = null;
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    col = dataGridViewTextBoxColumn2;
                    break;
                case 1:
                    col = dataGridViewTextBoxColumn3;
                    break;
                case 2:
                    col = dataGridViewTextBoxColumn4;
                    break;
                case 3:
                    col = dataGridViewTextBoxColumn5;
                    break;
                case 4:
                    col = dataGridViewTextBoxColumn6;
                    break;
                case 5:
                    col = dataGridViewTextBoxColumn7;
                    break;
                case 6:
                    col = dataGridViewTextBoxColumn8;
                    break;
                case 7:
                    col = dataGridViewTextBoxColumn9;
                    break;
                case 8:
                    col = dataGridViewTextBoxColumn10;
                    break;
                case 9:
                    col = dataGridViewTextBoxColumn11;
                    break;
                case 10:
                    col = dataGridViewTextBoxColumn12;
                    break;
            }
            if (radioButton1.Checked)
                otdelDataGridView.Sort(col, System.ComponentModel.ListSortDirection.Ascending);
            else otdelDataGridView.Sort(col, System.ComponentModel.ListSortDirection.Descending);
        }

        private void otdelDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < otdelDataGridView.RowCount; i++)
            {
                otdelDataGridView.Rows[i].Selected = false;
                for (int j = 0; j < otdelDataGridView.ColumnCount; j++)
                    if (otdelDataGridView.Rows[i].Cells[j].Value != null)
                        if (otdelDataGridView.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            otdelDataGridView.Rows[i].Selected = true;
                            break;
                        }
            }
        }
    }
        }

        internal class TextBox1
        {
            public static char Text { get; internal set; }
        }

        internal class Color
        {
            public static System.Drawing.Color White { get; internal set; }
            public static System.Drawing.Color Black { get; internal set; }
            public static System.Drawing.Color AliceBlue { get; internal set; }
            public static System.Drawing.Color Blue { get; internal set; }
        }
