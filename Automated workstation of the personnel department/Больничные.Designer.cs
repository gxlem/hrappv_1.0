
namespace Automated_workstation_of_the_personnel_department
{
    partial class Больничные
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
            System.Windows.Forms.Label positionLabel;
            System.Windows.Forms.Label data_vihoda_na_bolnichniyLabel;
            System.Windows.Forms.Label data_vihoda_na_rabotuLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Больничные));
            this.label1 = new System.Windows.Forms.Label();
            this.hrDataSet = new Automated_workstation_of_the_personnel_department.hrDataSet();
            this.hospitalsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalsTableAdapter = new Automated_workstation_of_the_personnel_department.hrDataSetTableAdapters.hospitalsTableAdapter();
            this.tableAdapterManager = new Automated_workstation_of_the_personnel_department.hrDataSetTableAdapters.TableAdapterManager();
            this.last_nameTextBox = new System.Windows.Forms.TextBox();
            this.first_nameTextBox = new System.Windows.Forms.TextBox();
            this.middle_nameTextBox = new System.Windows.Forms.TextBox();
            this.data_rojdeniaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.data_vihoda_na_bolnichniyDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.data_vihoda_na_rabotuDateTimePicker = new System.Windows.Forms.DateTimePicker();
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
            positionLabel = new System.Windows.Forms.Label();
            data_vihoda_na_bolnichniyLabel = new System.Windows.Forms.Label();
            data_vihoda_na_rabotuLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hrDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // last_nameLabel
            // 
            last_nameLabel.AutoSize = true;
            last_nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            last_nameLabel.Location = new System.Drawing.Point(12, 73);
            last_nameLabel.Name = "last_nameLabel";
            last_nameLabel.Size = new System.Drawing.Size(96, 24);
            last_nameLabel.TabIndex = 2;
            last_nameLabel.Text = "Фамилия:";
            // 
            // first_nameLabel
            // 
            first_nameLabel.AutoSize = true;
            first_nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            first_nameLabel.Location = new System.Drawing.Point(12, 122);
            first_nameLabel.Name = "first_nameLabel";
            first_nameLabel.Size = new System.Drawing.Size(51, 24);
            first_nameLabel.TabIndex = 4;
            first_nameLabel.Text = "Имя:";
            // 
            // middle_nameLabel
            // 
            middle_nameLabel.AutoSize = true;
            middle_nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            middle_nameLabel.Location = new System.Drawing.Point(11, 176);
            middle_nameLabel.Name = "middle_nameLabel";
            middle_nameLabel.Size = new System.Drawing.Size(103, 24);
            middle_nameLabel.TabIndex = 6;
            middle_nameLabel.Text = "Отчество:";
            // 
            // data_rojdeniaLabel
            // 
            data_rojdeniaLabel.AutoSize = true;
            data_rojdeniaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            data_rojdeniaLabel.Location = new System.Drawing.Point(12, 218);
            data_rojdeniaLabel.Name = "data_rojdeniaLabel";
            data_rojdeniaLabel.Size = new System.Drawing.Size(156, 24);
            data_rojdeniaLabel.TabIndex = 8;
            data_rojdeniaLabel.Text = "Дата Рождения:";
            // 
            // positionLabel
            // 
            positionLabel.AutoSize = true;
            positionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            positionLabel.Location = new System.Drawing.Point(12, 264);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new System.Drawing.Size(117, 24);
            positionLabel.TabIndex = 10;
            positionLabel.Text = "Должность:";
            // 
            // data_vihoda_na_bolnichniyLabel
            // 
            data_vihoda_na_bolnichniyLabel.AutoSize = true;
            data_vihoda_na_bolnichniyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            data_vihoda_na_bolnichniyLabel.Location = new System.Drawing.Point(12, 308);
            data_vihoda_na_bolnichniyLabel.Name = "data_vihoda_na_bolnichniyLabel";
            data_vihoda_na_bolnichniyLabel.Size = new System.Drawing.Size(272, 24);
            data_vihoda_na_bolnichniyLabel.TabIndex = 12;
            data_vihoda_na_bolnichniyLabel.Text = "Дата выхода на больничный:";
            // 
            // data_vihoda_na_rabotuLabel
            // 
            data_vihoda_na_rabotuLabel.AutoSize = true;
            data_vihoda_na_rabotuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            data_vihoda_na_rabotuLabel.Location = new System.Drawing.Point(12, 354);
            data_vihoda_na_rabotuLabel.Name = "data_vihoda_na_rabotuLabel";
            data_vihoda_na_rabotuLabel.Size = new System.Drawing.Size(224, 24);
            data_vihoda_na_rabotuLabel.TabIndex = 14;
            data_vihoda_na_rabotuLabel.Text = "Дата выхода на работу:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(249, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Больничные";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hrDataSet
            // 
            this.hrDataSet.DataSetName = "hrDataSet";
            this.hrDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hospitalsBindingSource
            // 
            this.hospitalsBindingSource.DataMember = "hospitals";
            this.hospitalsBindingSource.DataSource = this.hrDataSet;
            // 
            // hospitalsTableAdapter
            // 
            this.hospitalsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.advanced_trainingTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.employeeTableAdapter = null;
            this.tableAdapterManager.encouragementTableAdapter = null;
            this.tableAdapterManager.hiring_and_firingTableAdapter = null;
            this.tableAdapterManager.hospitalsTableAdapter = this.hospitalsTableAdapter;
            this.tableAdapterManager.otdelTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Automated_workstation_of_the_personnel_department.hrDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vacationTableAdapter = null;
            // 
            // last_nameTextBox
            // 
            this.last_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hospitalsBindingSource, "last_name", true));
            this.last_nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.last_nameTextBox.Location = new System.Drawing.Point(114, 70);
            this.last_nameTextBox.Name = "last_nameTextBox";
            this.last_nameTextBox.Size = new System.Drawing.Size(463, 29);
            this.last_nameTextBox.TabIndex = 3;
            // 
            // first_nameTextBox
            // 
            this.first_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hospitalsBindingSource, "first_name", true));
            this.first_nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.first_nameTextBox.Location = new System.Drawing.Point(69, 122);
            this.first_nameTextBox.Name = "first_nameTextBox";
            this.first_nameTextBox.Size = new System.Drawing.Size(508, 29);
            this.first_nameTextBox.TabIndex = 5;
            // 
            // middle_nameTextBox
            // 
            this.middle_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hospitalsBindingSource, "middle_name", true));
            this.middle_nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.middle_nameTextBox.Location = new System.Drawing.Point(121, 176);
            this.middle_nameTextBox.Name = "middle_nameTextBox";
            this.middle_nameTextBox.Size = new System.Drawing.Size(456, 29);
            this.middle_nameTextBox.TabIndex = 7;
            // 
            // data_rojdeniaDateTimePicker
            // 
            this.data_rojdeniaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.hospitalsBindingSource, "data_rojdenia", true));
            this.data_rojdeniaDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.data_rojdeniaDateTimePicker.Location = new System.Drawing.Point(174, 218);
            this.data_rojdeniaDateTimePicker.Name = "data_rojdeniaDateTimePicker";
            this.data_rojdeniaDateTimePicker.Size = new System.Drawing.Size(403, 29);
            this.data_rojdeniaDateTimePicker.TabIndex = 9;
            // 
            // positionTextBox
            // 
            this.positionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hospitalsBindingSource, "position", true));
            this.positionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.positionTextBox.Location = new System.Drawing.Point(132, 264);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(445, 29);
            this.positionTextBox.TabIndex = 11;
            // 
            // data_vihoda_na_bolnichniyDateTimePicker
            // 
            this.data_vihoda_na_bolnichniyDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.data_vihoda_na_bolnichniyDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.hospitalsBindingSource, "data_vihoda_na_bolnichniy", true));
            this.data_vihoda_na_bolnichniyDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.data_vihoda_na_bolnichniyDateTimePicker.Location = new System.Drawing.Point(290, 308);
            this.data_vihoda_na_bolnichniyDateTimePicker.Name = "data_vihoda_na_bolnichniyDateTimePicker";
            this.data_vihoda_na_bolnichniyDateTimePicker.Size = new System.Drawing.Size(287, 29);
            this.data_vihoda_na_bolnichniyDateTimePicker.TabIndex = 13;
            // 
            // data_vihoda_na_rabotuDateTimePicker
            // 
            this.data_vihoda_na_rabotuDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.hospitalsBindingSource, "data_vihoda_na_rabotu", true));
            this.data_vihoda_na_rabotuDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.data_vihoda_na_rabotuDateTimePicker.Location = new System.Drawing.Point(242, 358);
            this.data_vihoda_na_rabotuDateTimePicker.Name = "data_vihoda_na_rabotuDateTimePicker";
            this.data_vihoda_na_rabotuDateTimePicker.Size = new System.Drawing.Size(335, 29);
            this.data_vihoda_na_rabotuDateTimePicker.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 39);
            this.button1.TabIndex = 16;
            this.button1.Text = "Первая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(174, 404);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 39);
            this.button2.TabIndex = 17;
            this.button2.Text = "Предыдущая";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(320, 404);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 39);
            this.button3.TabIndex = 18;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(459, 404);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 39);
            this.button4.TabIndex = 19;
            this.button4.Text = "Сохранить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(12, 459);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(117, 40);
            this.button5.TabIndex = 20;
            this.button5.Text = "Последняя";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(174, 459);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(110, 40);
            this.button6.TabIndex = 21;
            this.button6.Text = "Следующая";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(320, 459);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(111, 40);
            this.button7.TabIndex = 22;
            this.button7.Text = "Удалить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(459, 459);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(110, 40);
            this.button8.TabIndex = 23;
            this.button8.Text = "Поиск и фильтрация";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Больничные
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 511);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(data_vihoda_na_rabotuLabel);
            this.Controls.Add(this.data_vihoda_na_rabotuDateTimePicker);
            this.Controls.Add(data_vihoda_na_bolnichniyLabel);
            this.Controls.Add(this.data_vihoda_na_bolnichniyDateTimePicker);
            this.Controls.Add(positionLabel);
            this.Controls.Add(this.positionTextBox);
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
            this.Name = "Больничные";
            this.Text = "Больничные";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hrDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private hrDataSet hrDataSet;
        private System.Windows.Forms.BindingSource hospitalsBindingSource;
        private hrDataSetTableAdapters.hospitalsTableAdapter hospitalsTableAdapter;
        private hrDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox last_nameTextBox;
        private System.Windows.Forms.TextBox first_nameTextBox;
        private System.Windows.Forms.TextBox middle_nameTextBox;
        private System.Windows.Forms.DateTimePicker data_rojdeniaDateTimePicker;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.DateTimePicker data_vihoda_na_bolnichniyDateTimePicker;
        private System.Windows.Forms.DateTimePicker data_vihoda_na_rabotuDateTimePicker;
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