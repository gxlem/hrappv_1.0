
namespace Automated_workstation_of_the_personnel_department
{
    partial class Сотрудник
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
            System.Windows.Forms.Label mesto_rojdeniaLabel;
            System.Windows.Forms.Label positionLabel;
            System.Windows.Forms.Label registrationLabel;
            System.Windows.Forms.Label seriaandnumberpasportaLabel;
            System.Windows.Forms.Label obrazovanieLabel;
            System.Windows.Forms.Label nomer_dogovoraLabel;
            System.Windows.Forms.Label nomer_prikazaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Сотрудник));
            this.label1 = new System.Windows.Forms.Label();
            this.hrDataSet = new Automated_workstation_of_the_personnel_department.hrDataSet();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new Automated_workstation_of_the_personnel_department.hrDataSetTableAdapters.employeeTableAdapter();
            this.tableAdapterManager = new Automated_workstation_of_the_personnel_department.hrDataSetTableAdapters.TableAdapterManager();
            this.last_nameTextBox = new System.Windows.Forms.TextBox();
            this.first_nameTextBox = new System.Windows.Forms.TextBox();
            this.middle_nameTextBox = new System.Windows.Forms.TextBox();
            this.data_rojdeniaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.mesto_rojdeniaTextBox = new System.Windows.Forms.TextBox();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.registrationTextBox = new System.Windows.Forms.TextBox();
            this.seriaandnumberpasportaTextBox = new System.Windows.Forms.TextBox();
            this.obrazovanieTextBox = new System.Windows.Forms.TextBox();
            this.nomer_dogovoraTextBox = new System.Windows.Forms.TextBox();
            this.nomer_prikazaTextBox = new System.Windows.Forms.TextBox();
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
            mesto_rojdeniaLabel = new System.Windows.Forms.Label();
            positionLabel = new System.Windows.Forms.Label();
            registrationLabel = new System.Windows.Forms.Label();
            seriaandnumberpasportaLabel = new System.Windows.Forms.Label();
            obrazovanieLabel = new System.Windows.Forms.Label();
            nomer_dogovoraLabel = new System.Windows.Forms.Label();
            nomer_prikazaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hrDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // last_nameLabel
            // 
            last_nameLabel.AutoSize = true;
            last_nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            last_nameLabel.Location = new System.Drawing.Point(12, 80);
            last_nameLabel.Name = "last_nameLabel";
            last_nameLabel.Size = new System.Drawing.Size(96, 24);
            last_nameLabel.TabIndex = 2;
            last_nameLabel.Text = "Фамилия:";
            // 
            // first_nameLabel
            // 
            first_nameLabel.AutoSize = true;
            first_nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            first_nameLabel.Location = new System.Drawing.Point(12, 126);
            first_nameLabel.Name = "first_nameLabel";
            first_nameLabel.Size = new System.Drawing.Size(51, 24);
            first_nameLabel.TabIndex = 4;
            first_nameLabel.Text = "Имя:";
            // 
            // middle_nameLabel
            // 
            middle_nameLabel.AutoSize = true;
            middle_nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            middle_nameLabel.Location = new System.Drawing.Point(11, 170);
            middle_nameLabel.Name = "middle_nameLabel";
            middle_nameLabel.Size = new System.Drawing.Size(103, 24);
            middle_nameLabel.TabIndex = 6;
            middle_nameLabel.Text = "Отчество:";
            // 
            // data_rojdeniaLabel
            // 
            data_rojdeniaLabel.AutoSize = true;
            data_rojdeniaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            data_rojdeniaLabel.Location = new System.Drawing.Point(12, 214);
            data_rojdeniaLabel.Name = "data_rojdeniaLabel";
            data_rojdeniaLabel.Size = new System.Drawing.Size(156, 24);
            data_rojdeniaLabel.TabIndex = 8;
            data_rojdeniaLabel.Text = "Дата Рождения:";
            // 
            // mesto_rojdeniaLabel
            // 
            mesto_rojdeniaLabel.AutoSize = true;
            mesto_rojdeniaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            mesto_rojdeniaLabel.Location = new System.Drawing.Point(12, 253);
            mesto_rojdeniaLabel.Name = "mesto_rojdeniaLabel";
            mesto_rojdeniaLabel.Size = new System.Drawing.Size(170, 24);
            mesto_rojdeniaLabel.TabIndex = 10;
            mesto_rojdeniaLabel.Text = "Место Рождения:";
            // 
            // positionLabel
            // 
            positionLabel.AutoSize = true;
            positionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            positionLabel.Location = new System.Drawing.Point(12, 294);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new System.Drawing.Size(117, 24);
            positionLabel.TabIndex = 12;
            positionLabel.Text = "Должность:";
            // 
            // registrationLabel
            // 
            registrationLabel.AutoSize = true;
            registrationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            registrationLabel.Location = new System.Drawing.Point(12, 338);
            registrationLabel.Name = "registrationLabel";
            registrationLabel.Size = new System.Drawing.Size(101, 24);
            registrationLabel.TabIndex = 14;
            registrationLabel.Text = "Прописка:";
            // 
            // seriaandnumberpasportaLabel
            // 
            seriaandnumberpasportaLabel.AutoSize = true;
            seriaandnumberpasportaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            seriaandnumberpasportaLabel.Location = new System.Drawing.Point(11, 383);
            seriaandnumberpasportaLabel.Name = "seriaandnumberpasportaLabel";
            seriaandnumberpasportaLabel.Size = new System.Drawing.Size(238, 24);
            seriaandnumberpasportaLabel.TabIndex = 16;
            seriaandnumberpasportaLabel.Text = "Серия и номер паспорта:";
            // 
            // obrazovanieLabel
            // 
            obrazovanieLabel.AutoSize = true;
            obrazovanieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            obrazovanieLabel.Location = new System.Drawing.Point(13, 427);
            obrazovanieLabel.Name = "obrazovanieLabel";
            obrazovanieLabel.Size = new System.Drawing.Size(137, 24);
            obrazovanieLabel.TabIndex = 18;
            obrazovanieLabel.Text = "Образование:";
            // 
            // nomer_dogovoraLabel
            // 
            nomer_dogovoraLabel.AutoSize = true;
            nomer_dogovoraLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nomer_dogovoraLabel.Location = new System.Drawing.Point(12, 463);
            nomer_dogovoraLabel.Name = "nomer_dogovoraLabel";
            nomer_dogovoraLabel.Size = new System.Drawing.Size(165, 24);
            nomer_dogovoraLabel.TabIndex = 20;
            nomer_dogovoraLabel.Text = "Номер договора:";
            // 
            // nomer_prikazaLabel
            // 
            nomer_prikazaLabel.AutoSize = true;
            nomer_prikazaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nomer_prikazaLabel.Location = new System.Drawing.Point(14, 504);
            nomer_prikazaLabel.Name = "nomer_prikazaLabel";
            nomer_prikazaLabel.Size = new System.Drawing.Size(151, 24);
            nomer_prikazaLabel.TabIndex = 22;
            nomer_prikazaLabel.Text = "Номер приказа:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(200, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сотрудник";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hrDataSet
            // 
            this.hrDataSet.DataSetName = "hrDataSet";
            this.hrDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "employee";
            this.employeeBindingSource.DataSource = this.hrDataSet;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.advanced_trainingTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.employeeTableAdapter = this.employeeTableAdapter;
            this.tableAdapterManager.encouragementTableAdapter = null;
            this.tableAdapterManager.hiring_and_firingTableAdapter = null;
            this.tableAdapterManager.hospitalsTableAdapter = null;
            this.tableAdapterManager.otdelTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Automated_workstation_of_the_personnel_department.hrDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vacationTableAdapter = null;
            // 
            // last_nameTextBox
            // 
            this.last_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "last_name", true));
            this.last_nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.last_nameTextBox.Location = new System.Drawing.Point(114, 80);
            this.last_nameTextBox.Name = "last_nameTextBox";
            this.last_nameTextBox.Size = new System.Drawing.Size(438, 29);
            this.last_nameTextBox.TabIndex = 3;
            // 
            // first_nameTextBox
            // 
            this.first_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "first_name", true));
            this.first_nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.first_nameTextBox.Location = new System.Drawing.Point(69, 126);
            this.first_nameTextBox.Name = "first_nameTextBox";
            this.first_nameTextBox.Size = new System.Drawing.Size(483, 29);
            this.first_nameTextBox.TabIndex = 5;
            // 
            // middle_nameTextBox
            // 
            this.middle_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "middle_name", true));
            this.middle_nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.middle_nameTextBox.Location = new System.Drawing.Point(114, 170);
            this.middle_nameTextBox.Name = "middle_nameTextBox";
            this.middle_nameTextBox.Size = new System.Drawing.Size(438, 29);
            this.middle_nameTextBox.TabIndex = 7;
            // 
            // data_rojdeniaDateTimePicker
            // 
            this.data_rojdeniaDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.data_rojdeniaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.employeeBindingSource, "data_rojdenia", true));
            this.data_rojdeniaDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.data_rojdeniaDateTimePicker.Location = new System.Drawing.Point(171, 214);
            this.data_rojdeniaDateTimePicker.Name = "data_rojdeniaDateTimePicker";
            this.data_rojdeniaDateTimePicker.Size = new System.Drawing.Size(381, 29);
            this.data_rojdeniaDateTimePicker.TabIndex = 9;
            // 
            // mesto_rojdeniaTextBox
            // 
            this.mesto_rojdeniaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "mesto_rojdenia", true));
            this.mesto_rojdeniaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mesto_rojdeniaTextBox.Location = new System.Drawing.Point(188, 253);
            this.mesto_rojdeniaTextBox.Name = "mesto_rojdeniaTextBox";
            this.mesto_rojdeniaTextBox.Size = new System.Drawing.Size(364, 29);
            this.mesto_rojdeniaTextBox.TabIndex = 11;
            // 
            // positionTextBox
            // 
            this.positionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "position", true));
            this.positionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.positionTextBox.Location = new System.Drawing.Point(135, 294);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(417, 29);
            this.positionTextBox.TabIndex = 13;
            // 
            // registrationTextBox
            // 
            this.registrationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "registration", true));
            this.registrationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrationTextBox.Location = new System.Drawing.Point(119, 338);
            this.registrationTextBox.Name = "registrationTextBox";
            this.registrationTextBox.Size = new System.Drawing.Size(433, 29);
            this.registrationTextBox.TabIndex = 15;
            // 
            // seriaandnumberpasportaTextBox
            // 
            this.seriaandnumberpasportaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "seriaandnumberpasporta", true));
            this.seriaandnumberpasportaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seriaandnumberpasportaTextBox.Location = new System.Drawing.Point(255, 383);
            this.seriaandnumberpasportaTextBox.Name = "seriaandnumberpasportaTextBox";
            this.seriaandnumberpasportaTextBox.Size = new System.Drawing.Size(297, 29);
            this.seriaandnumberpasportaTextBox.TabIndex = 17;
            // 
            // obrazovanieTextBox
            // 
            this.obrazovanieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "obrazovanie", true));
            this.obrazovanieTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.obrazovanieTextBox.Location = new System.Drawing.Point(156, 424);
            this.obrazovanieTextBox.Name = "obrazovanieTextBox";
            this.obrazovanieTextBox.Size = new System.Drawing.Size(396, 29);
            this.obrazovanieTextBox.TabIndex = 19;
            // 
            // nomer_dogovoraTextBox
            // 
            this.nomer_dogovoraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "nomer_dogovora", true));
            this.nomer_dogovoraTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nomer_dogovoraTextBox.Location = new System.Drawing.Point(183, 463);
            this.nomer_dogovoraTextBox.Name = "nomer_dogovoraTextBox";
            this.nomer_dogovoraTextBox.Size = new System.Drawing.Size(369, 29);
            this.nomer_dogovoraTextBox.TabIndex = 21;
            // 
            // nomer_prikazaTextBox
            // 
            this.nomer_prikazaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "nomer_prikaza", true));
            this.nomer_prikazaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nomer_prikazaTextBox.Location = new System.Drawing.Point(171, 504);
            this.nomer_prikazaTextBox.Name = "nomer_prikazaTextBox";
            this.nomer_prikazaTextBox.Size = new System.Drawing.Size(381, 29);
            this.nomer_prikazaTextBox.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(15, 553);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 37);
            this.button1.TabIndex = 24;
            this.button1.Text = "Первая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(146, 554);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 36);
            this.button2.TabIndex = 25;
            this.button2.Text = "Предыдущая";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(294, 554);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 36);
            this.button3.TabIndex = 26;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(440, 554);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 36);
            this.button4.TabIndex = 27;
            this.button4.Text = "Сохранить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(16, 605);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(95, 38);
            this.button5.TabIndex = 28;
            this.button5.Text = "Последняя";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(146, 605);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(111, 38);
            this.button6.TabIndex = 29;
            this.button6.Text = "Следующая";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(294, 605);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(106, 38);
            this.button7.TabIndex = 30;
            this.button7.Text = "Удалить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(440, 605);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(103, 38);
            this.button8.TabIndex = 31;
            this.button8.Text = "Поиск и фильтрация";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Сотрудник
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 655);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(nomer_prikazaLabel);
            this.Controls.Add(this.nomer_prikazaTextBox);
            this.Controls.Add(nomer_dogovoraLabel);
            this.Controls.Add(this.nomer_dogovoraTextBox);
            this.Controls.Add(obrazovanieLabel);
            this.Controls.Add(this.obrazovanieTextBox);
            this.Controls.Add(seriaandnumberpasportaLabel);
            this.Controls.Add(this.seriaandnumberpasportaTextBox);
            this.Controls.Add(registrationLabel);
            this.Controls.Add(this.registrationTextBox);
            this.Controls.Add(positionLabel);
            this.Controls.Add(this.positionTextBox);
            this.Controls.Add(mesto_rojdeniaLabel);
            this.Controls.Add(this.mesto_rojdeniaTextBox);
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
            this.Name = "Сотрудник";
            this.Text = "Сотрудник";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hrDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private hrDataSet hrDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private hrDataSetTableAdapters.employeeTableAdapter employeeTableAdapter;
        private hrDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox last_nameTextBox;
        private System.Windows.Forms.TextBox first_nameTextBox;
        private System.Windows.Forms.TextBox middle_nameTextBox;
        private System.Windows.Forms.DateTimePicker data_rojdeniaDateTimePicker;
        private System.Windows.Forms.TextBox mesto_rojdeniaTextBox;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.TextBox registrationTextBox;
        private System.Windows.Forms.TextBox seriaandnumberpasportaTextBox;
        private System.Windows.Forms.TextBox obrazovanieTextBox;
        private System.Windows.Forms.TextBox nomer_dogovoraTextBox;
        private System.Windows.Forms.TextBox nomer_prikazaTextBox;
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