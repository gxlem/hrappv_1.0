
namespace Automated_workstation_of_the_personnel_department
{
    partial class Authorization_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization_frm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Input_btn = new System.Windows.Forms.Button();
            this.Log_txt = new System.Windows.Forms.TextBox();
            this.Pass_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль";
            // 
            // Input_btn
            // 
            this.Input_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Input_btn.Location = new System.Drawing.Point(126, 216);
            this.Input_btn.Name = "Input_btn";
            this.Input_btn.Size = new System.Drawing.Size(174, 71);
            this.Input_btn.TabIndex = 2;
            this.Input_btn.Text = "Войти в приложение";
            this.Input_btn.UseVisualStyleBackColor = true;
            this.Input_btn.Click += new System.EventHandler(this.Input_btn_Click);
            // 
            // Log_txt
            // 
            this.Log_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Log_txt.Location = new System.Drawing.Point(100, 38);
            this.Log_txt.Name = "Log_txt";
            this.Log_txt.Size = new System.Drawing.Size(249, 29);
            this.Log_txt.TabIndex = 3;
            // 
            // Pass_txt
            // 
            this.Pass_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pass_txt.Location = new System.Drawing.Point(100, 119);
            this.Pass_txt.Name = "Pass_txt";
            this.Pass_txt.PasswordChar = '*';
            this.Pass_txt.Size = new System.Drawing.Size(249, 29);
            this.Pass_txt.TabIndex = 4;
            // 
            // Authorization_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 342);
            this.Controls.Add(this.Pass_txt);
            this.Controls.Add(this.Log_txt);
            this.Controls.Add(this.Input_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Authorization_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Для входа введите логин и пароль";
            this.Load += new System.EventHandler(this.Authorization_frm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Input_btn;
        private System.Windows.Forms.TextBox Log_txt;
        private System.Windows.Forms.TextBox Pass_txt;
    }
}