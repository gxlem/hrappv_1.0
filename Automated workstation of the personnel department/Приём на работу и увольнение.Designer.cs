
namespace Automated_workstation_of_the_personnel_department
{
    partial class Form8
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label last_nameLabel;
            System.Windows.Forms.Label first_nameLabel;
            System.Windows.Forms.Label middle_nameLabel;
            System.Windows.Forms.Label data_rojdeniaLabel;
            System.Windows.Forms.Label seria_and_nomer_pasportaLabel;
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label vid_prikazaLabel;
            System.Windows.Forms.Label osnovanieLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.label1 = new System.Windows.Forms.Label();
            this.hrDataSet = new Automated_workstation_of_the_personnel_department.hrDataSet();
            this.hiring_and_firingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hiring_and_firingTableAdapter = new Automated_workstation_of_the_personnel_department.hrDataSetTableAdapters.hiring_and_firingTableAdapter();
            this.tableAdapterManager = new Automated_workstation_of_the_personnel_department.hrDataSetTableAdapters.TableAdapterManager();
            this.last_nameTextBox = new System.Windows.Forms.TextBox();
            this.first_nameTextBox = new System.Windows.Forms.TextBox();
            this.middle_nameTextBox = new System.Windows.Forms.TextBox();
            this.data_rojdeniaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.seria_and_nomer_pasportaTextBox = new System.Windows.Forms.TextBox();
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.vid_prikazaTextBox = new System.Windows.Forms.TextBox();
            this.osnovanieTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            last_nameLabel = new System.Windows.Forms.Label();
            first_nameLabel = new System.Windows.Forms.Label();
            middle_nameLabel = new System.Windows.Forms.Label();
            data_rojdeniaLabel = new System.Windows.Forms.Label();
            seria_and_nomer_pasportaLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            vid_prikazaLabel = new System.Windows.Forms.Label();
            osnovanieLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hrDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hiring_and_firingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // last_nameLabel
            // 
            last_nameLabel.AutoSize = true;
            last_nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            last_nameLabel.Location = new System.Drawing.Point(12, 85);
            last_nameLabel.Name = "last_nameLabel";
            last_nameLabel.Size = new System.Drawing.Size(96, 24);
            last_nameLabel.TabIndex = 2;
            last_nameLabel.Text = "Фамилия:";
            // 
            // first_nameLabel
            // 
            first_nameLabel.AutoSize = true;
            first_nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            first_nameLabel.Location = new System.Drawing.Point(13, 142);
            first_nameLabel.Name = "first_nameLabel";
            first_nameLabel.Size = new System.Drawing.Size(51, 24);
            first_nameLabel.TabIndex = 4;
            first_nameLabel.Text = "Имя:";
            // 
            // middle_nameLabel
            // 
            middle_nameLabel.AutoSize = true;
            middle_nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            middle_nameLabel.Location = new System.Drawing.Point(12, 196);
            middle_nameLabel.Name = "middle_nameLabel";
            middle_nameLabel.Size = new System.Drawing.Size(103, 24);
            middle_nameLabel.TabIndex = 6;
            middle_nameLabel.Text = "Отчество:";
            // 
            // data_rojdeniaLabel
            // 
            data_rojdeniaLabel.AutoSize = true;
            data_rojdeniaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            data_rojdeniaLabel.Location = new System.Drawing.Point(14, 249);
            data_rojdeniaLabel.Name = "data_rojdeniaLabel";
            data_rojdeniaLabel.Size = new System.Drawing.Size(156, 24);
            data_rojdeniaLabel.TabIndex = 8;
            data_rojdeniaLabel.Text = "Дата Рождения:";
            // 
            // seria_and_nomer_pasportaLabel
            // 
            seria_and_nomer_pasportaLabel.AutoSize = true;
            seria_and_nomer_pasportaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            seria_and_nomer_pasportaLabel.Location = new System.Drawing.Point(12, 301);
            seria_and_nomer_pasportaLabel.Name = "seria_and_nomer_pasportaLabel";
            seria_and_nomer_pasportaLabel.Size = new System.Drawing.Size(238, 24);
            seria_and_nomer_pasportaLabel.TabIndex = 10;
            seria_and_nomer_pasportaLabel.Text = "Серия и номер паспорта:";
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataLabel.Location = new System.Drawing.Point(14, 353);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(59, 24);
            dataLabel.TabIndex = 12;
            dataLabel.Text = "Дата:";
            // 
            // vid_prikazaLabel
            // 
            vid_prikazaLabel.AutoSize = true;
            vid_prikazaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            vid_prikazaLabel.Location = new System.Drawing.Point(12, 397);
            vid_prikazaLabel.Name = "vid_prikazaLabel";
            vid_prikazaLabel.Size = new System.Drawing.Size(127, 24);
            vid_prikazaLabel.TabIndex = 14;
            vid_prikazaLabel.Text = "Вид приказа:";
            // 
            // osnovanieLabel
            // 
            osnovanieLabel.AutoSize = true;
            osnovanieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            osnovanieLabel.Location = new System.Drawing.Point(12, 446);
            osnovanieLabel.Name = "osnovanieLabel";
            osnovanieLabel.Size = new System.Drawing.Size(116, 24);
            osnovanieLabel.TabIndex = 16;
            osnovanieLabel.Text = "Основание:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(284, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Приём на работу и увольнение";
            // 
            // hrDataSet
            // 
            this.hrDataSet.DataSetName = "hrDataSet";
            this.hrDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hiring_and_firingBindingSource
            // 
            this.hiring_and_firingBindingSource.DataMember = "hiring and firing";
            this.hiring_and_firingBindingSource.DataSource = this.hrDataSet;
            // 
            // hiring_and_firingTableAdapter
            // 
            this.hiring_and_firingTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.advanced_trainingTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.employeeTableAdapter = null;
            this.tableAdapterManager.encouragementTableAdapter = null;
            this.tableAdapterManager.hiring_and_firingTableAdapter = this.hiring_and_firingTableAdapter;
            this.tableAdapterManager.hospitalsTableAdapter = null;
            this.tableAdapterManager.otdelTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Automated_workstation_of_the_personnel_department.hrDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vacationTableAdapter = null;
            // 
            // last_nameTextBox
            // 
            this.last_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hiring_and_firingBindingSource, "last_name", true));
            this.last_nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.last_nameTextBox.Location = new System.Drawing.Point(114, 85);
            this.last_nameTextBox.Name = "last_nameTextBox";
            this.last_nameTextBox.Size = new System.Drawing.Size(674, 29);
            this.last_nameTextBox.TabIndex = 3;
            // 
            // first_nameTextBox
            // 
            this.first_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hiring_and_firingBindingSource, "first_name", true));
            this.first_nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.first_nameTextBox.Location = new System.Drawing.Point(70, 139);
            this.first_nameTextBox.Name = "first_nameTextBox";
            this.first_nameTextBox.Size = new System.Drawing.Size(718, 29);
            this.first_nameTextBox.TabIndex = 5;
            // 
            // middle_nameTextBox
            // 
            this.middle_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hiring_and_firingBindingSource, "middle_name", true));
            this.middle_nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.middle_nameTextBox.Location = new System.Drawing.Point(121, 196);
            this.middle_nameTextBox.Name = "middle_nameTextBox";
            this.middle_nameTextBox.Size = new System.Drawing.Size(667, 29);
            this.middle_nameTextBox.TabIndex = 7;
            // 
            // data_rojdeniaDateTimePicker
            // 
            this.data_rojdeniaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.hiring_and_firingBindingSource, "data_rojdenia", true));
            this.data_rojdeniaDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.data_rojdeniaDateTimePicker.Location = new System.Drawing.Point(176, 249);
            this.data_rojdeniaDateTimePicker.Name = "data_rojdeniaDateTimePicker";
            this.data_rojdeniaDateTimePicker.Size = new System.Drawing.Size(612, 29);
            this.data_rojdeniaDateTimePicker.TabIndex = 9;
            // 
            // seria_and_nomer_pasportaTextBox
            // 
            this.seria_and_nomer_pasportaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hiring_and_firingBindingSource, "seria_and_nomer_pasporta", true));
            this.seria_and_nomer_pasportaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seria_and_nomer_pasportaTextBox.Location = new System.Drawing.Point(256, 301);
            this.seria_and_nomer_pasportaTextBox.Name = "seria_and_nomer_pasportaTextBox";
            this.seria_and_nomer_pasportaTextBox.Size = new System.Drawing.Size(532, 29);
            this.seria_and_nomer_pasportaTextBox.TabIndex = 11;
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.hiring_and_firingBindingSource, "data", true));
            this.dataDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataDateTimePicker.Location = new System.Drawing.Point(79, 353);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(709, 29);
            this.dataDateTimePicker.TabIndex = 13;
            // 
            // vid_prikazaTextBox
            // 
            this.vid_prikazaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hiring_and_firingBindingSource, "vid_prikaza", true));
            this.vid_prikazaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vid_prikazaTextBox.Location = new System.Drawing.Point(145, 397);
            this.vid_prikazaTextBox.Name = "vid_prikazaTextBox";
            this.vid_prikazaTextBox.Size = new System.Drawing.Size(642, 29);
            this.vid_prikazaTextBox.TabIndex = 15;
            // 
            // osnovanieTextBox
            // 
            this.osnovanieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hiring_and_firingBindingSource, "osnovanie", true));
            this.osnovanieTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.osnovanieTextBox.Location = new System.Drawing.Point(134, 443);
            this.osnovanieTextBox.Name = "osnovanieTextBox";
            this.osnovanieTextBox.Size = new System.Drawing.Size(653, 29);
            this.osnovanieTextBox.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(16, 495);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 41);
            this.button1.TabIndex = 18;
            this.button1.Text = "Первая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(224, 495);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 41);
            this.button2.TabIndex = 19;
            this.button2.Text = "Предыдущая";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(444, 495);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 41);
            this.button3.TabIndex = 20;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(656, 495);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(131, 41);
            this.button4.TabIndex = 21;
            this.button4.Text = "Сохранить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(18, 562);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(121, 44);
            this.button5.TabIndex = 22;
            this.button5.Text = "Последняя";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(224, 562);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(120, 44);
            this.button6.TabIndex = 23;
            this.button6.Text = "Следующая";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(444, 562);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(125, 44);
            this.button7.TabIndex = 24;
            this.button7.Text = "Удалить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(656, 562);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(131, 44);
            this.button8.TabIndex = 25;
            this.button8.Text = "Поиск и фильтрация";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 618);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(osnovanieLabel);
            this.Controls.Add(this.osnovanieTextBox);
            this.Controls.Add(vid_prikazaLabel);
            this.Controls.Add(this.vid_prikazaTextBox);
            this.Controls.Add(dataLabel);
            this.Controls.Add(this.dataDateTimePicker);
            this.Controls.Add(seria_and_nomer_pasportaLabel);
            this.Controls.Add(this.seria_and_nomer_pasportaTextBox);
            this.Controls.Add(data_rojdeniaLabel);
            this.Controls.Add(this.data_rojdeniaDateTimePicker);
            this.Controls.Add(middle_nameLabel);
            this.Controls.Add(this.middle_nameTextBox);
            this.Controls.Add(first_nameLabel);
            this.Controls.Add(this.first_nameTextBox);
            this.Controls.Add(last_nameLabel);
            this.Controls.Add(this.last_nameTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form8";
            this.Text = "Приём на работу и увольнение";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hrDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hiring_and_firingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private hrDataSet hrDataSet;
        private System.Windows.Forms.BindingSource hiring_and_firingBindingSource;
        private hrDataSetTableAdapters.hiring_and_firingTableAdapter hiring_and_firingTableAdapter;
        private hrDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox last_nameTextBox;
        private System.Windows.Forms.TextBox first_nameTextBox;
        private System.Windows.Forms.TextBox middle_nameTextBox;
        private System.Windows.Forms.DateTimePicker data_rojdeniaDateTimePicker;
        private System.Windows.Forms.TextBox seria_and_nomer_pasportaTextBox;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
        private System.Windows.Forms.TextBox vid_prikazaTextBox;
        private System.Windows.Forms.TextBox osnovanieTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}