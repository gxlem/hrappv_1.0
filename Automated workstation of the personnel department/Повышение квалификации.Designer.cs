
namespace Automated_workstation_of_the_personnel_department
{
    partial class Form7
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
            System.Windows.Forms.Label data_nachalaLabel;
            System.Windows.Forms.Label data_oversLabel;
            System.Windows.Forms.Label documentLabel;
            System.Windows.Forms.Label number_documentLabel;
            System.Windows.Forms.Label mesto_prohojdeniaLabel;
            System.Windows.Forms.Label osnovanieLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.label1 = new System.Windows.Forms.Label();
            this.hrDataSet = new Automated_workstation_of_the_personnel_department.hrDataSet();
            this.advanced_trainingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.advanced_trainingTableAdapter = new Automated_workstation_of_the_personnel_department.hrDataSetTableAdapters.advanced_trainingTableAdapter();
            this.tableAdapterManager = new Automated_workstation_of_the_personnel_department.hrDataSetTableAdapters.TableAdapterManager();
            this.last_nameTextBox = new System.Windows.Forms.TextBox();
            this.first_nameTextBox = new System.Windows.Forms.TextBox();
            this.middle_nameTextBox = new System.Windows.Forms.TextBox();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.data_nachalaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.data_oversDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.documentTextBox = new System.Windows.Forms.TextBox();
            this.number_documentTextBox = new System.Windows.Forms.TextBox();
            this.mesto_prohojdeniaTextBox = new System.Windows.Forms.TextBox();
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
            positionLabel = new System.Windows.Forms.Label();
            data_nachalaLabel = new System.Windows.Forms.Label();
            data_oversLabel = new System.Windows.Forms.Label();
            documentLabel = new System.Windows.Forms.Label();
            number_documentLabel = new System.Windows.Forms.Label();
            mesto_prohojdeniaLabel = new System.Windows.Forms.Label();
            osnovanieLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hrDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advanced_trainingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // last_nameLabel
            // 
            last_nameLabel.AutoSize = true;
            last_nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            last_nameLabel.Location = new System.Drawing.Point(12, 72);
            last_nameLabel.Name = "last_nameLabel";
            last_nameLabel.Size = new System.Drawing.Size(96, 24);
            last_nameLabel.TabIndex = 2;
            last_nameLabel.Text = "Фамилия:";
            // 
            // first_nameLabel
            // 
            first_nameLabel.AutoSize = true;
            first_nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            first_nameLabel.Location = new System.Drawing.Point(12, 113);
            first_nameLabel.Name = "first_nameLabel";
            first_nameLabel.Size = new System.Drawing.Size(51, 24);
            first_nameLabel.TabIndex = 4;
            first_nameLabel.Text = "Имя:";
            // 
            // middle_nameLabel
            // 
            middle_nameLabel.AutoSize = true;
            middle_nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            middle_nameLabel.Location = new System.Drawing.Point(12, 154);
            middle_nameLabel.Name = "middle_nameLabel";
            middle_nameLabel.Size = new System.Drawing.Size(103, 24);
            middle_nameLabel.TabIndex = 6;
            middle_nameLabel.Text = "Отчество:";
            // 
            // positionLabel
            // 
            positionLabel.AutoSize = true;
            positionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            positionLabel.Location = new System.Drawing.Point(12, 203);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new System.Drawing.Size(117, 24);
            positionLabel.TabIndex = 8;
            positionLabel.Text = "Должность:";
            // 
            // data_nachalaLabel
            // 
            data_nachalaLabel.AutoSize = true;
            data_nachalaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            data_nachalaLabel.Location = new System.Drawing.Point(12, 247);
            data_nachalaLabel.Name = "data_nachalaLabel";
            data_nachalaLabel.Size = new System.Drawing.Size(125, 24);
            data_nachalaLabel.TabIndex = 10;
            data_nachalaLabel.Text = "Дата начала:";
            // 
            // data_oversLabel
            // 
            data_oversLabel.AutoSize = true;
            data_oversLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            data_oversLabel.Location = new System.Drawing.Point(12, 294);
            data_oversLabel.Name = "data_oversLabel";
            data_oversLabel.Size = new System.Drawing.Size(174, 24);
            data_oversLabel.TabIndex = 12;
            data_oversLabel.Text = "Дата завершения:";
            // 
            // documentLabel
            // 
            documentLabel.AutoSize = true;
            documentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            documentLabel.Location = new System.Drawing.Point(13, 341);
            documentLabel.Name = "documentLabel";
            documentLabel.Size = new System.Drawing.Size(103, 24);
            documentLabel.TabIndex = 14;
            documentLabel.Text = "Документ:";
            // 
            // number_documentLabel
            // 
            number_documentLabel.AutoSize = true;
            number_documentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            number_documentLabel.Location = new System.Drawing.Point(13, 384);
            number_documentLabel.Name = "number_documentLabel";
            number_documentLabel.Size = new System.Drawing.Size(177, 24);
            number_documentLabel.TabIndex = 16;
            number_documentLabel.Text = "Номер Документа:";
            // 
            // mesto_prohojdeniaLabel
            // 
            mesto_prohojdeniaLabel.AutoSize = true;
            mesto_prohojdeniaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            mesto_prohojdeniaLabel.Location = new System.Drawing.Point(12, 432);
            mesto_prohojdeniaLabel.Name = "mesto_prohojdeniaLabel";
            mesto_prohojdeniaLabel.Size = new System.Drawing.Size(203, 24);
            mesto_prohojdeniaLabel.TabIndex = 18;
            mesto_prohojdeniaLabel.Text = "Место Прохождения:";
            // 
            // osnovanieLabel
            // 
            osnovanieLabel.AutoSize = true;
            osnovanieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            osnovanieLabel.Location = new System.Drawing.Point(13, 481);
            osnovanieLabel.Name = "osnovanieLabel";
            osnovanieLabel.Size = new System.Drawing.Size(116, 24);
            osnovanieLabel.TabIndex = 20;
            osnovanieLabel.Text = "Основание:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(268, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Повышение квалификации";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // hrDataSet
            // 
            this.hrDataSet.DataSetName = "hrDataSet";
            this.hrDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // advanced_trainingBindingSource
            // 
            this.advanced_trainingBindingSource.DataMember = "advanced training";
            this.advanced_trainingBindingSource.DataSource = this.hrDataSet;
            // 
            // advanced_trainingTableAdapter
            // 
            this.advanced_trainingTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.advanced_trainingTableAdapter = this.advanced_trainingTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.employeeTableAdapter = null;
            this.tableAdapterManager.encouragementTableAdapter = null;
            this.tableAdapterManager.hiring_and_firingTableAdapter = null;
            this.tableAdapterManager.hospitalsTableAdapter = null;
            this.tableAdapterManager.otdelTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Automated_workstation_of_the_personnel_department.hrDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vacationTableAdapter = null;
            // 
            // last_nameTextBox
            // 
            this.last_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.advanced_trainingBindingSource, "last_name", true));
            this.last_nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.last_nameTextBox.Location = new System.Drawing.Point(114, 72);
            this.last_nameTextBox.Name = "last_nameTextBox";
            this.last_nameTextBox.Size = new System.Drawing.Size(629, 29);
            this.last_nameTextBox.TabIndex = 3;
            // 
            // first_nameTextBox
            // 
            this.first_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.advanced_trainingBindingSource, "first_name", true));
            this.first_nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.first_nameTextBox.Location = new System.Drawing.Point(69, 113);
            this.first_nameTextBox.Name = "first_nameTextBox";
            this.first_nameTextBox.Size = new System.Drawing.Size(674, 29);
            this.first_nameTextBox.TabIndex = 5;
            // 
            // middle_nameTextBox
            // 
            this.middle_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.advanced_trainingBindingSource, "middle_name", true));
            this.middle_nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.middle_nameTextBox.Location = new System.Drawing.Point(121, 158);
            this.middle_nameTextBox.Name = "middle_nameTextBox";
            this.middle_nameTextBox.Size = new System.Drawing.Size(622, 29);
            this.middle_nameTextBox.TabIndex = 7;
            // 
            // positionTextBox
            // 
            this.positionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.advanced_trainingBindingSource, "position", true));
            this.positionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.positionTextBox.Location = new System.Drawing.Point(135, 203);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(608, 29);
            this.positionTextBox.TabIndex = 9;
            // 
            // data_nachalaDateTimePicker
            // 
            this.data_nachalaDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.data_nachalaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.advanced_trainingBindingSource, "data_nachala", true));
            this.data_nachalaDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.data_nachalaDateTimePicker.Location = new System.Drawing.Point(143, 247);
            this.data_nachalaDateTimePicker.Name = "data_nachalaDateTimePicker";
            this.data_nachalaDateTimePicker.Size = new System.Drawing.Size(600, 29);
            this.data_nachalaDateTimePicker.TabIndex = 11;
            // 
            // data_oversDateTimePicker
            // 
            this.data_oversDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.advanced_trainingBindingSource, "data_overs", true));
            this.data_oversDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.data_oversDateTimePicker.Location = new System.Drawing.Point(192, 294);
            this.data_oversDateTimePicker.Name = "data_oversDateTimePicker";
            this.data_oversDateTimePicker.Size = new System.Drawing.Size(551, 29);
            this.data_oversDateTimePicker.TabIndex = 13;
            // 
            // documentTextBox
            // 
            this.documentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.advanced_trainingBindingSource, "document", true));
            this.documentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.documentTextBox.Location = new System.Drawing.Point(121, 341);
            this.documentTextBox.Name = "documentTextBox";
            this.documentTextBox.Size = new System.Drawing.Size(622, 29);
            this.documentTextBox.TabIndex = 15;
            // 
            // number_documentTextBox
            // 
            this.number_documentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.advanced_trainingBindingSource, "number_document", true));
            this.number_documentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number_documentTextBox.Location = new System.Drawing.Point(192, 384);
            this.number_documentTextBox.Name = "number_documentTextBox";
            this.number_documentTextBox.Size = new System.Drawing.Size(551, 29);
            this.number_documentTextBox.TabIndex = 17;
            // 
            // mesto_prohojdeniaTextBox
            // 
            this.mesto_prohojdeniaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.advanced_trainingBindingSource, "mesto_prohojdenia", true));
            this.mesto_prohojdeniaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mesto_prohojdeniaTextBox.Location = new System.Drawing.Point(221, 432);
            this.mesto_prohojdeniaTextBox.Name = "mesto_prohojdeniaTextBox";
            this.mesto_prohojdeniaTextBox.Size = new System.Drawing.Size(522, 29);
            this.mesto_prohojdeniaTextBox.TabIndex = 19;
            // 
            // osnovanieTextBox
            // 
            this.osnovanieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.advanced_trainingBindingSource, "osnovanie", true));
            this.osnovanieTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.osnovanieTextBox.Location = new System.Drawing.Point(135, 481);
            this.osnovanieTextBox.Name = "osnovanieTextBox";
            this.osnovanieTextBox.Size = new System.Drawing.Size(608, 29);
            this.osnovanieTextBox.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 538);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 41);
            this.button1.TabIndex = 22;
            this.button1.Text = "Первая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(231, 538);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 41);
            this.button2.TabIndex = 23;
            this.button2.Text = "Предыдущая";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(442, 538);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 41);
            this.button3.TabIndex = 24;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(620, 538);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 41);
            this.button4.TabIndex = 25;
            this.button4.Text = "Сохранить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(12, 596);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(139, 40);
            this.button5.TabIndex = 26;
            this.button5.Text = "Последняя";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(231, 596);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(119, 40);
            this.button6.TabIndex = 27;
            this.button6.Text = "Следующая";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(442, 596);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(113, 40);
            this.button7.TabIndex = 28;
            this.button7.Text = "Удалить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(620, 596);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(123, 40);
            this.button8.TabIndex = 29;
            this.button8.Text = "Поиск и фильтрация";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 648);
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
            this.Controls.Add(mesto_prohojdeniaLabel);
            this.Controls.Add(this.mesto_prohojdeniaTextBox);
            this.Controls.Add(number_documentLabel);
            this.Controls.Add(this.number_documentTextBox);
            this.Controls.Add(documentLabel);
            this.Controls.Add(this.documentTextBox);
            this.Controls.Add(data_oversLabel);
            this.Controls.Add(this.data_oversDateTimePicker);
            this.Controls.Add(data_nachalaLabel);
            this.Controls.Add(this.data_nachalaDateTimePicker);
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
            this.Name = "Form7";
            this.Text = "Повышение квалификации";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hrDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advanced_trainingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private hrDataSet hrDataSet;
        private System.Windows.Forms.BindingSource advanced_trainingBindingSource;
        private hrDataSetTableAdapters.advanced_trainingTableAdapter advanced_trainingTableAdapter;
        private hrDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox last_nameTextBox;
        private System.Windows.Forms.TextBox first_nameTextBox;
        private System.Windows.Forms.TextBox middle_nameTextBox;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.DateTimePicker data_nachalaDateTimePicker;
        private System.Windows.Forms.DateTimePicker data_oversDateTimePicker;
        private System.Windows.Forms.TextBox documentTextBox;
        private System.Windows.Forms.TextBox number_documentTextBox;
        private System.Windows.Forms.TextBox mesto_prohojdeniaTextBox;
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