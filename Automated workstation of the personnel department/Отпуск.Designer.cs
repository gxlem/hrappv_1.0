
namespace Automated_workstation_of_the_personnel_department
{
    partial class Отпуск
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
            System.Windows.Forms.Label vid_otpuskaLabel;
            System.Windows.Forms.Label number_of_vacation_daysLabel;
            System.Windows.Forms.Label release_date_in_vacationLabel;
            System.Windows.Forms.Label release_date_from_workLabel;
            System.Windows.Forms.Label osnovanieLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Отпуск));
            this.label1 = new System.Windows.Forms.Label();
            this.hrDataSet = new Automated_workstation_of_the_personnel_department.hrDataSet();
            this.vacationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vacationTableAdapter = new Automated_workstation_of_the_personnel_department.hrDataSetTableAdapters.vacationTableAdapter();
            this.tableAdapterManager = new Automated_workstation_of_the_personnel_department.hrDataSetTableAdapters.TableAdapterManager();
            this.vid_otpuskaTextBox = new System.Windows.Forms.TextBox();
            this.number_of_vacation_daysTextBox = new System.Windows.Forms.TextBox();
            this.release_date_in_vacationDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.release_date_from_workDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.osnovanieTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            vid_otpuskaLabel = new System.Windows.Forms.Label();
            number_of_vacation_daysLabel = new System.Windows.Forms.Label();
            release_date_in_vacationLabel = new System.Windows.Forms.Label();
            release_date_from_workLabel = new System.Windows.Forms.Label();
            osnovanieLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hrDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // vid_otpuskaLabel
            // 
            vid_otpuskaLabel.AutoSize = true;
            vid_otpuskaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            vid_otpuskaLabel.Location = new System.Drawing.Point(12, 88);
            vid_otpuskaLabel.Name = "vid_otpuskaLabel";
            vid_otpuskaLabel.Size = new System.Drawing.Size(125, 24);
            vid_otpuskaLabel.TabIndex = 2;
            vid_otpuskaLabel.Text = "Вид отпуска:";
            // 
            // number_of_vacation_daysLabel
            // 
            number_of_vacation_daysLabel.AutoSize = true;
            number_of_vacation_daysLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            number_of_vacation_daysLabel.Location = new System.Drawing.Point(12, 137);
            number_of_vacation_daysLabel.Name = "number_of_vacation_daysLabel";
            number_of_vacation_daysLabel.Size = new System.Drawing.Size(247, 24);
            number_of_vacation_daysLabel.TabIndex = 4;
            number_of_vacation_daysLabel.Text = "Количество дней отпуска:";
            // 
            // release_date_in_vacationLabel
            // 
            release_date_in_vacationLabel.AutoSize = true;
            release_date_in_vacationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            release_date_in_vacationLabel.Location = new System.Drawing.Point(12, 180);
            release_date_in_vacationLabel.Name = "release_date_in_vacationLabel";
            release_date_in_vacationLabel.Size = new System.Drawing.Size(212, 24);
            release_date_in_vacationLabel.TabIndex = 6;
            release_date_in_vacationLabel.Text = "Дата выхода в отпуск:";
            // 
            // release_date_from_workLabel
            // 
            release_date_from_workLabel.AutoSize = true;
            release_date_from_workLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            release_date_from_workLabel.Location = new System.Drawing.Point(12, 231);
            release_date_from_workLabel.Name = "release_date_from_workLabel";
            release_date_from_workLabel.Size = new System.Drawing.Size(224, 24);
            release_date_from_workLabel.TabIndex = 8;
            release_date_from_workLabel.Text = "Дата выхода на работу:";
            // 
            // osnovanieLabel
            // 
            osnovanieLabel.AutoSize = true;
            osnovanieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            osnovanieLabel.Location = new System.Drawing.Point(12, 276);
            osnovanieLabel.Name = "osnovanieLabel";
            osnovanieLabel.Size = new System.Drawing.Size(116, 24);
            osnovanieLabel.TabIndex = 10;
            osnovanieLabel.Text = "Основание:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(165, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Отпуск";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hrDataSet
            // 
            this.hrDataSet.DataSetName = "hrDataSet";
            this.hrDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vacationBindingSource
            // 
            this.vacationBindingSource.DataMember = "vacation";
            this.vacationBindingSource.DataSource = this.hrDataSet;
            // 
            // vacationTableAdapter
            // 
            this.vacationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.advanced_trainingTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.employeeTableAdapter = null;
            this.tableAdapterManager.encouragementTableAdapter = null;
            this.tableAdapterManager.hiring_and_firingTableAdapter = null;
            this.tableAdapterManager.hospitalsTableAdapter = null;
            this.tableAdapterManager.otdelTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Automated_workstation_of_the_personnel_department.hrDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vacationTableAdapter = this.vacationTableAdapter;
            // 
            // vid_otpuskaTextBox
            // 
            this.vid_otpuskaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vacationBindingSource, "vid_otpuska", true));
            this.vid_otpuskaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vid_otpuskaTextBox.Location = new System.Drawing.Point(141, 88);
            this.vid_otpuskaTextBox.Name = "vid_otpuskaTextBox";
            this.vid_otpuskaTextBox.Size = new System.Drawing.Size(407, 29);
            this.vid_otpuskaTextBox.TabIndex = 3;
            // 
            // number_of_vacation_daysTextBox
            // 
            this.number_of_vacation_daysTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vacationBindingSource, "number_of_vacation_days", true));
            this.number_of_vacation_daysTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number_of_vacation_daysTextBox.Location = new System.Drawing.Point(265, 137);
            this.number_of_vacation_daysTextBox.Name = "number_of_vacation_daysTextBox";
            this.number_of_vacation_daysTextBox.Size = new System.Drawing.Size(283, 29);
            this.number_of_vacation_daysTextBox.TabIndex = 5;
            // 
            // release_date_in_vacationDateTimePicker
            // 
            this.release_date_in_vacationDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vacationBindingSource, "release_date_in_vacation", true));
            this.release_date_in_vacationDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.release_date_in_vacationDateTimePicker.Location = new System.Drawing.Point(230, 176);
            this.release_date_in_vacationDateTimePicker.Name = "release_date_in_vacationDateTimePicker";
            this.release_date_in_vacationDateTimePicker.Size = new System.Drawing.Size(318, 29);
            this.release_date_in_vacationDateTimePicker.TabIndex = 7;
            // 
            // release_date_from_workDateTimePicker
            // 
            this.release_date_from_workDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vacationBindingSource, "release_date_from_work", true));
            this.release_date_from_workDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.release_date_from_workDateTimePicker.Location = new System.Drawing.Point(242, 231);
            this.release_date_from_workDateTimePicker.Name = "release_date_from_workDateTimePicker";
            this.release_date_from_workDateTimePicker.Size = new System.Drawing.Size(306, 29);
            this.release_date_from_workDateTimePicker.TabIndex = 9;
            // 
            // osnovanieTextBox
            // 
            this.osnovanieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vacationBindingSource, "osnovanie", true));
            this.osnovanieTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.osnovanieTextBox.Location = new System.Drawing.Point(134, 276);
            this.osnovanieTextBox.Name = "osnovanieTextBox";
            this.osnovanieTextBox.Size = new System.Drawing.Size(414, 29);
            this.osnovanieTextBox.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(16, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 35);
            this.button1.TabIndex = 12;
            this.button1.Text = "Первая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(154, 336);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 37);
            this.button2.TabIndex = 13;
            this.button2.Text = "Предыдущая";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(301, 335);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 37);
            this.button3.TabIndex = 14;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(448, 336);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 35);
            this.button4.TabIndex = 15;
            this.button4.Text = "Сохранить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(16, 391);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(92, 38);
            this.button5.TabIndex = 16;
            this.button5.Text = "Последняя";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(154, 391);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(95, 38);
            this.button6.TabIndex = 17;
            this.button6.Text = "Следующая";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(301, 391);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(102, 38);
            this.button7.TabIndex = 18;
            this.button7.Text = "Удалить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(448, 391);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 37);
            this.button8.TabIndex = 19;
            this.button8.Text = "Поиск и фильтрация";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Отпуск
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 450);
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
            this.Controls.Add(release_date_from_workLabel);
            this.Controls.Add(this.release_date_from_workDateTimePicker);
            this.Controls.Add(release_date_in_vacationLabel);
            this.Controls.Add(this.release_date_in_vacationDateTimePicker);
            this.Controls.Add(number_of_vacation_daysLabel);
            this.Controls.Add(this.number_of_vacation_daysTextBox);
            this.Controls.Add(vid_otpuskaLabel);
            this.Controls.Add(this.vid_otpuskaTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Отпуск";
            this.Text = "Отпуск";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hrDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private hrDataSet hrDataSet;
        private System.Windows.Forms.BindingSource vacationBindingSource;
        private hrDataSetTableAdapters.vacationTableAdapter vacationTableAdapter;
        private hrDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox vid_otpuskaTextBox;
        private System.Windows.Forms.TextBox number_of_vacation_daysTextBox;
        private System.Windows.Forms.DateTimePicker release_date_in_vacationDateTimePicker;
        private System.Windows.Forms.DateTimePicker release_date_from_workDateTimePicker;
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