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
    public partial class Отдел : Form
    {
        public object ОтделBindingSource1 { get; private set; }

        public Отдел()
        {
            InitializeComponent();
        }

        private void OtdelBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.otdelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hrDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hrDataSet.otdel". При необходимости она может быть перемещена или удалена.
            this.otdelTableAdapter.Fill(this.hrDataSet.otdel);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            otdelBindingSource.MoveFirst();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            otdelBindingSource.MovePrevious();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            otdelBindingSource.AddNew();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            otdelBindingSource.MoveLast();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            otdelBindingSource.MoveNext();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            otdelBindingSource.RemoveCurrent();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.otdelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hrDataSet);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form10 TblForm = new Form10();
            TblForm.Show();
        }
    }
}
