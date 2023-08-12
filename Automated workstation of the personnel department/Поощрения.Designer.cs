
namespace Automated_workstation_of_the_personnel_department
{
    partial class Поощрения
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
            System.Windows.Forms.Label positionLabel;
            System.Windows.Forms.Label vid_poshreniaLabel;
            System.Windows.Forms.Label osnovanieLabel;
            System.Windows.Forms.Label dataLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Поощрения));
            this.label1 = new System.Windows.Forms.Label();
            this.hrDataSet = new Automated_workstation_of_the_personnel_department.hrDataSet();
            this.encouragementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.encouragementTableAdapter = new Automated_workstation_of_the_personnel_department.hrDataSetTableAdapters.encouragementTableAdapter();
            this.tableAdapterManager = new Automated_workstation_of_the_personnel_department.hrDataSetTableAdapters.TableAdapterManager();
            this.last_nameTextBox = new System.Windows.Forms.TextBox();
            this.first_nameTextBox = new System.Windows.Forms.TextBox();
            this.middle_nameTextBox = new System.Windows.Forms.TextBox();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.vid_poshreniaTextBox = new System.Windows.Forms.TextBox();
            this.osnovanieTextBox = new System.Windows.Forms.TextBox();
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
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
            positionLabel = new System.Windows.Forms.Label();
            vid_poshreniaLabel = new System.Windows.Forms.Label();
            osnovanieLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hrDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.encouragementBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // last_nameLabel
            // 
            last_nameLabel.AutoSize = true;
            last_nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            last_nameLabel.Location = new System.Drawing.Point(12, 89);
            last_nameLabel.Name = "last_nameLabel";
            last_nameLabel.Size = new System.Drawing.Size(96, 24);
            last_nameLabel.TabIndex = 2;
            last_nameLabel.Text = "Фамилия:";
            last_nameLabel.Click += new System.EventHandler(this.last_nameLabel_Click);
            // 
            // first_nameLabel
            // 
            first_nameLabel.AutoSize = true;
            first_nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            first_nameLabel.Location = new System.Drawing.Point(12, 143);
            first_nameLabel.Name = "first_nameLabel";
            first_nameLabel.Size = new System.Drawing.Size(51, 24);
            first_nameLabel.TabIndex = 6;
            first_nameLabel.Text = "Имя:";
            // 
            // middle_nameLabel
            // 
            middle_nameLabel.AutoSize = true;
            middle_nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            middle_nameLabel.Location = new System.Drawing.Point(12, 201);
            middle_nameLabel.Name = "middle_nameLabel";
            middle_nameLabel.Size = new System.Drawing.Size(103, 24);
            middle_nameLabel.TabIndex = 8;
            middle_nameLabel.Text = "Отчество:";
            middle_nameLabel.Click += new System.EventHandler(this.middle_nameLabel_Click);
            // 
            // positionLabel
            // 
            positionLabel.AutoSize = true;
            positionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            positionLabel.Location = new System.Drawing.Point(11, 252);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new System.Drawing.Size(117, 24);
            positionLabel.TabIndex = 10;
            positionLabel.Text = "Должность:";
            // 
            // vid_poshreniaLabel
            // 
            vid_poshreniaLabel.AutoSize = true;
            vid_poshreniaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            vid_poshreniaLabel.Location = new System.Drawing.Point(13, 305);
            vid_poshreniaLabel.Name = "vid_poshreniaLabel";
            vid_poshreniaLabel.Size = new System.Drawing.Size(157, 24);
            vid_poshreniaLabel.TabIndex = 12;
            vid_poshreniaLabel.Text = "Вид Поощрения:";
            // 
            // osnovanieLabel
            // 
            osnovanieLabel.AutoSize = true;
            osnovanieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            osnovanieLabel.Location = new System.Drawing.Point(12, 361);
            osnovanieLabel.Name = "osnovanieLabel";
            osnovanieLabel.Size = new System.Drawing.Size(116, 24);
            osnovanieLabel.TabIndex = 14;
            osnovanieLabel.Text = "Основание:";
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataLabel.Location = new System.Drawing.Point(12, 414);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(59, 24);
            dataLabel.TabIndex = 16;
            dataLabel.Text = "Дата:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(272, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поощрения";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hrDataSet
            // 
            this.hrDataSet.DataSetName = "hrDataSet";
            this.hrDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // encouragementBindingSource
            // 
            this.encouragementBindingSource.DataMember = "encouragement";
            this.encouragementBindingSource.DataSource = this.hrDataSet;
            // 
            // encouragementTableAdapter
            // 
            this.encouragementTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.advanced_trainingTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.employeeTableAdapter = null;
            this.tableAdapterManager.encouragementTableAdapter = this.encouragementTableAdapter;
            this.tableAdapterManager.hiring_and_firingTableAdapter = null;
            this.tableAdapterManager.hospitalsTableAdapter = null;
            this.tableAdapterManager.otdelTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Automated_workstation_of_the_personnel_department.hrDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vacationTableAdapter = null;
            // 
            // last_nameTextBox
            // 
            this.last_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.encouragementBindingSource, "last_name", true));
            this.last_nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.last_nameTextBox.Location = new System.Drawing.Point(114, 89);
            this.last_nameTextBox.Name = "last_nameTextBox";
            this.last_nameTextBox.Size = new System.Drawing.Size(511, 29);
            this.last_nameTextBox.TabIndex = 3;
            // 
            // first_nameTextBox
            // 
            this.first_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.encouragementBindingSource, "first_name", true));
            this.first_nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.first_nameTextBox.Location = new System.Drawing.Point(69, 140);
            this.first_nameTextBox.Name = "first_nameTextBox";
            this.first_nameTextBox.Size = new System.Drawing.Size(556, 29);
            this.first_nameTextBox.TabIndex = 7;
            // 
            // middle_nameTextBox
            // 
            this.middle_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.encouragementBindingSource, "middle_name", true));
            this.middle_nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.middle_nameTextBox.Location = new System.Drawing.Point(121, 201);
            this.middle_nameTextBox.Name = "middle_nameTextBox";
            this.middle_nameTextBox.Size = new System.Drawing.Size(504, 29);
            this.middle_nameTextBox.TabIndex = 9;
            // 
            // positionTextBox
            // 
            this.positionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.encouragementBindingSource, "position", true));
            this.positionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.positionTextBox.Location = new System.Drawing.Point(134, 252);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(491, 29);
            this.positionTextBox.TabIndex = 11;
            // 
            // vid_poshreniaTextBox
            // 
            this.vid_poshreniaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.encouragementBindingSource, "vid_poshrenia", true));
            this.vid_poshreniaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vid_poshreniaTextBox.Location = new System.Drawing.Point(176, 305);
            this.vid_poshreniaTextBox.Name = "vid_poshreniaTextBox";
            this.vid_poshreniaTextBox.Size = new System.Drawing.Size(449, 29);
            this.vid_poshreniaTextBox.TabIndex = 13;
            // 
            // osnovanieTextBox
            // 
            this.osnovanieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.encouragementBindingSource, "osnovanie", true));
            this.osnovanieTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.osnovanieTextBox.Location = new System.Drawing.Point(134, 361);
            this.osnovanieTextBox.Name = "osnovanieTextBox";
            this.osnovanieTextBox.Size = new System.Drawing.Size(491, 29);
            this.osnovanieTextBox.TabIndex = 15;
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.encouragementBindingSource, "data", true));
            this.dataDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataDateTimePicker.Location = new System.Drawing.Point(77, 416);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(548, 29);
            this.dataDateTimePicker.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(17, 466);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 39);
            this.button1.TabIndex = 18;
            this.button1.Text = "Первая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(176, 466);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 39);
            this.button2.TabIndex = 19;
            this.button2.Text = "Предыдущая";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(344, 466);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 39);
            this.button3.TabIndex = 20;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(512, 466);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 39);
            this.button4.TabIndex = 21;
            this.button4.Text = "Сохранить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(17, 523);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(111, 38);
            this.button5.TabIndex = 22;
            this.button5.Text = "Последняя";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(176, 523);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(116, 38);
            this.button6.TabIndex = 23;
            this.button6.Text = "Следующая";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(344, 523);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(117, 38);
            this.button7.TabIndex = 24;
            this.button7.Text = "Удалить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(512, 523);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(113, 38);
            this.button8.TabIndex = 25;
            this.button8.Text = "Поиск и фильтрация";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Поощрения
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 581);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(dataLabel);
            this.Controls.Add(this.dataDateTimePicker);
            this.Controls.Add(osnovanieLabel);
            this.Controls.Add(this.osnovanieTextBox);
            this.Controls.Add(vid_poshreniaLabel);
            this.Controls.Add(this.vid_poshreniaTextBox);
            this.Controls.Add(positionLabel);
            this.Controls.Add(this.positionTextBox);
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
            this.Name = "Поощрения";
            this.Text = "Поощрения";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hrDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.encouragementBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private hrDataSet hrDataSet;
        private System.Windows.Forms.BindingSource encouragementBindingSource;
        private hrDataSetTableAdapters.encouragementTableAdapter encouragementTableAdapter;
        private hrDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox last_nameTextBox;
        private System.Windows.Forms.TextBox first_nameTextBox;
        private System.Windows.Forms.TextBox middle_nameTextBox;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.TextBox vid_poshreniaTextBox;
        private System.Windows.Forms.TextBox osnovanieTextBox;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
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