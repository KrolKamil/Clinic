namespace Clinic
{
    partial class DisplayMenu
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
            this.title = new System.Windows.Forms.Label();
            this.new_patient_btn = new System.Windows.Forms.Button();
            this.patient_registration_btn = new System.Windows.Forms.Button();
            this.show_register_btn = new System.Windows.Forms.Button();
            this.show_doctor_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(77, 25);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(334, 38);
            this.title.TabIndex = 0;
            this.title.Text = "Menedżer Przychodni";
            // 
            // new_patient_btn
            // 
            this.new_patient_btn.Location = new System.Drawing.Point(3, 188);
            this.new_patient_btn.Name = "new_patient_btn";
            this.new_patient_btn.Size = new System.Drawing.Size(504, 67);
            this.new_patient_btn.TabIndex = 1;
            this.new_patient_btn.Text = "Dodaj Pacjenta Do Bazy";
            this.new_patient_btn.UseVisualStyleBackColor = true;
            this.new_patient_btn.Click += new System.EventHandler(this.new_patient_btn_Click);
            // 
            // patient_registration_btn
            // 
            this.patient_registration_btn.Location = new System.Drawing.Point(3, 93);
            this.patient_registration_btn.Name = "patient_registration_btn";
            this.patient_registration_btn.Size = new System.Drawing.Size(504, 62);
            this.patient_registration_btn.TabIndex = 2;
            this.patient_registration_btn.Text = "Zarejestruj Pacjenta";
            this.patient_registration_btn.UseVisualStyleBackColor = true;
            this.patient_registration_btn.Click += new System.EventHandler(this.patient_registration_btn_Click);
            // 
            // show_register_btn
            // 
            this.show_register_btn.Location = new System.Drawing.Point(3, 281);
            this.show_register_btn.Name = "show_register_btn";
            this.show_register_btn.Size = new System.Drawing.Size(504, 65);
            this.show_register_btn.TabIndex = 3;
            this.show_register_btn.Text = "Pokaż Rejestracje";
            this.show_register_btn.UseVisualStyleBackColor = true;
            this.show_register_btn.Click += new System.EventHandler(this.show_register_btn_Click);
            // 
            // show_doctor_btn
            // 
            this.show_doctor_btn.Location = new System.Drawing.Point(3, 363);
            this.show_doctor_btn.Name = "show_doctor_btn";
            this.show_doctor_btn.Size = new System.Drawing.Size(504, 65);
            this.show_doctor_btn.TabIndex = 4;
            this.show_doctor_btn.Text = "Zarządzaj Lekarzem";
            this.show_doctor_btn.UseVisualStyleBackColor = true;
            this.show_doctor_btn.Click += new System.EventHandler(this.show_doctor_btn_Click);
            // 
            // DisplayMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.show_doctor_btn);
            this.Controls.Add(this.show_register_btn);
            this.Controls.Add(this.patient_registration_btn);
            this.Controls.Add(this.new_patient_btn);
            this.Controls.Add(this.title);
            this.Name = "DisplayMenu";
            this.Size = new System.Drawing.Size(510, 700);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button new_patient_btn;
        private System.Windows.Forms.Button patient_registration_btn;
        private System.Windows.Forms.Button show_register_btn;
        private System.Windows.Forms.Button show_doctor_btn;
    }
}
