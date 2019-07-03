namespace Clinic
{
    partial class Register
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.specialisations_comboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.user_box = new System.Windows.Forms.ListBox();
            this.doctor_box = new System.Windows.Forms.ListBox();
            this.back_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.date_box = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rejestracja Pacjenta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pacjenci";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(204, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lekarze";
            // 
            // specialisations_comboBox
            // 
            this.specialisations_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.specialisations_comboBox.FormattingEnabled = true;
            this.specialisations_comboBox.Location = new System.Drawing.Point(257, 83);
            this.specialisations_comboBox.Name = "specialisations_comboBox";
            this.specialisations_comboBox.Size = new System.Drawing.Size(121, 24);
            this.specialisations_comboBox.TabIndex = 3;
            this.specialisations_comboBox.SelectedIndexChanged += new System.EventHandler(this.specialisations_comboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(270, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Specjalizacje";
            // 
            // user_box
            // 
            this.user_box.FormattingEnabled = true;
            this.user_box.ItemHeight = 16;
            this.user_box.Location = new System.Drawing.Point(6, 130);
            this.user_box.Name = "user_box";
            this.user_box.Size = new System.Drawing.Size(170, 372);
            this.user_box.TabIndex = 5;
            // 
            // doctor_box
            // 
            this.doctor_box.FormattingEnabled = true;
            this.doctor_box.ItemHeight = 16;
            this.doctor_box.Location = new System.Drawing.Point(208, 133);
            this.doctor_box.Name = "doctor_box";
            this.doctor_box.Size = new System.Drawing.Size(170, 164);
            this.doctor_box.TabIndex = 6;
            this.doctor_box.SelectedIndexChanged += new System.EventHandler(this.doctor_box_SelectedIndexChanged);
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(3, 524);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 23);
            this.back_btn.TabIndex = 7;
            this.back_btn.Text = "Powrót";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(283, 524);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(100, 23);
            this.add_btn.TabIndex = 8;
            this.add_btn.Text = "Zarejestruj";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // date_box
            // 
            this.date_box.FormattingEnabled = true;
            this.date_box.ItemHeight = 16;
            this.date_box.Location = new System.Drawing.Point(208, 338);
            this.date_box.Name = "date_box";
            this.date_box.Size = new System.Drawing.Size(170, 164);
            this.date_box.TabIndex = 9;
            this.date_box.SelectedIndexChanged += new System.EventHandler(this.date_box_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(204, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Data";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.date_box);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.doctor_box);
            this.Controls.Add(this.user_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.specialisations_comboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.Size = new System.Drawing.Size(386, 550);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox specialisations_comboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox user_box;
        private System.Windows.Forms.ListBox doctor_box;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.ListBox date_box;
        private System.Windows.Forms.Label label5;
    }
}
