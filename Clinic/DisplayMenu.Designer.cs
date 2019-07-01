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
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(19, 18);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(346, 39);
            this.title.TabIndex = 0;
            this.title.Text = "Menedżer Przychodni";
            // 
            // new_patient_btn
            // 
            this.new_patient_btn.Location = new System.Drawing.Point(3, 127);
            this.new_patient_btn.Name = "new_patient_btn";
            this.new_patient_btn.Size = new System.Drawing.Size(380, 37);
            this.new_patient_btn.TabIndex = 1;
            this.new_patient_btn.Text = "Dodaj Pacjenta Do Bazy";
            this.new_patient_btn.UseVisualStyleBackColor = true;
            this.new_patient_btn.Click += new System.EventHandler(this.new_patient_btn_Click);
            // 
            // patient_registration_btn
            // 
            this.patient_registration_btn.Location = new System.Drawing.Point(3, 84);
            this.patient_registration_btn.Name = "patient_registration_btn";
            this.patient_registration_btn.Size = new System.Drawing.Size(380, 37);
            this.patient_registration_btn.TabIndex = 2;
            this.patient_registration_btn.Text = "Zarejestruj Pacjenta";
            this.patient_registration_btn.UseVisualStyleBackColor = true;
            // 
            // DisplayMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.patient_registration_btn);
            this.Controls.Add(this.new_patient_btn);
            this.Controls.Add(this.title);
            this.Name = "DisplayMenu";
            this.Size = new System.Drawing.Size(386, 442);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button new_patient_btn;
        private System.Windows.Forms.Button patient_registration_btn;
    }
}
