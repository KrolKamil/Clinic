namespace Clinic
{
    partial class Doctor
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
            this.doctor_box = new System.Windows.Forms.ListBox();
            this.doctor_spec_box = new System.Windows.Forms.ListBox();
            this.all_spec_box = new System.Windows.Forms.ListBox();
            this.available_room_box = new System.Windows.Forms.ListBox();
            this.doctor_room_box = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.add_doctor_btn = new System.Windows.Forms.Button();
            this.surname_input = new System.Windows.Forms.TextBox();
            this.name_input = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.delete_doctor_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.add_spec_btn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.add_room_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Edycja Lekarza";
            // 
            // doctor_box
            // 
            this.doctor_box.FormattingEnabled = true;
            this.doctor_box.ItemHeight = 16;
            this.doctor_box.Location = new System.Drawing.Point(212, 55);
            this.doctor_box.Name = "doctor_box";
            this.doctor_box.Size = new System.Drawing.Size(282, 340);
            this.doctor_box.TabIndex = 6;
            this.doctor_box.SelectedIndexChanged += new System.EventHandler(this.doctor_box_SelectedIndexChanged);
            // 
            // doctor_spec_box
            // 
            this.doctor_spec_box.FormattingEnabled = true;
            this.doctor_spec_box.ItemHeight = 16;
            this.doctor_spec_box.Location = new System.Drawing.Point(4, 215);
            this.doctor_spec_box.Name = "doctor_spec_box";
            this.doctor_spec_box.Size = new System.Drawing.Size(99, 180);
            this.doctor_spec_box.TabIndex = 8;
            // 
            // all_spec_box
            // 
            this.all_spec_box.FormattingEnabled = true;
            this.all_spec_box.ItemHeight = 16;
            this.all_spec_box.Location = new System.Drawing.Point(109, 215);
            this.all_spec_box.Name = "all_spec_box";
            this.all_spec_box.Size = new System.Drawing.Size(99, 180);
            this.all_spec_box.TabIndex = 9;
            // 
            // available_room_box
            // 
            this.available_room_box.FormattingEnabled = true;
            this.available_room_box.ItemHeight = 16;
            this.available_room_box.Location = new System.Drawing.Point(291, 461);
            this.available_room_box.Name = "available_room_box";
            this.available_room_box.Size = new System.Drawing.Size(203, 180);
            this.available_room_box.TabIndex = 10;
            // 
            // doctor_room_box
            // 
            this.doctor_room_box.FormattingEnabled = true;
            this.doctor_room_box.ItemHeight = 16;
            this.doctor_room_box.Location = new System.Drawing.Point(3, 461);
            this.doctor_room_box.Name = "doctor_room_box";
            this.doctor_room_box.Size = new System.Drawing.Size(222, 36);
            this.doctor_room_box.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Posiadane";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(120, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Wszystkie";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Specjalizacje";
            // 
            // add_doctor_btn
            // 
            this.add_doctor_btn.Location = new System.Drawing.Point(106, 131);
            this.add_doctor_btn.Name = "add_doctor_btn";
            this.add_doctor_btn.Size = new System.Drawing.Size(100, 23);
            this.add_doctor_btn.TabIndex = 15;
            this.add_doctor_btn.Text = "Dodaj";
            this.add_doctor_btn.UseVisualStyleBackColor = true;
            this.add_doctor_btn.Click += new System.EventHandler(this.add_doctor_btn_Click);
            // 
            // surname_input
            // 
            this.surname_input.Location = new System.Drawing.Point(16, 103);
            this.surname_input.Name = "surname_input";
            this.surname_input.Size = new System.Drawing.Size(190, 22);
            this.surname_input.TabIndex = 19;
            // 
            // name_input
            // 
            this.name_input.Location = new System.Drawing.Point(16, 55);
            this.name_input.Name = "name_input";
            this.name_input.Size = new System.Drawing.Size(190, 22);
            this.name_input.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Nazwisko";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Imie";
            // 
            // delete_doctor_btn
            // 
            this.delete_doctor_btn.Location = new System.Drawing.Point(394, 401);
            this.delete_doctor_btn.Name = "delete_doctor_btn";
            this.delete_doctor_btn.Size = new System.Drawing.Size(100, 23);
            this.delete_doctor_btn.TabIndex = 20;
            this.delete_doctor_btn.Text = "Usuń";
            this.delete_doctor_btn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-1, 438);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Przydzielony Pokój";
            // 
            // add_spec_btn
            // 
            this.add_spec_btn.Location = new System.Drawing.Point(108, 401);
            this.add_spec_btn.Name = "add_spec_btn";
            this.add_spec_btn.Size = new System.Drawing.Size(100, 23);
            this.add_spec_btn.TabIndex = 22;
            this.add_spec_btn.Text = "Dodaj";
            this.add_spec_btn.UseVisualStyleBackColor = true;
            this.add_spec_btn.Click += new System.EventHandler(this.add_spec_btn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(287, 438);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Dostępne Pokoje";
            // 
            // add_room_btn
            // 
            this.add_room_btn.Location = new System.Drawing.Point(394, 647);
            this.add_room_btn.Name = "add_room_btn";
            this.add_room_btn.Size = new System.Drawing.Size(100, 23);
            this.add_room_btn.TabIndex = 24;
            this.add_room_btn.Text = "Przydziel";
            this.add_room_btn.UseVisualStyleBackColor = true;
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(0, 674);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 23);
            this.back_btn.TabIndex = 25;
            this.back_btn.Text = "Powrót";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.add_room_btn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.add_spec_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.delete_doctor_btn);
            this.Controls.Add(this.surname_input);
            this.Controls.Add(this.name_input);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.add_doctor_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.doctor_room_box);
            this.Controls.Add(this.available_room_box);
            this.Controls.Add(this.all_spec_box);
            this.Controls.Add(this.doctor_spec_box);
            this.Controls.Add(this.doctor_box);
            this.Controls.Add(this.label1);
            this.Name = "Doctor";
            this.Size = new System.Drawing.Size(510, 700);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox doctor_box;
        private System.Windows.Forms.ListBox doctor_spec_box;
        private System.Windows.Forms.ListBox all_spec_box;
        private System.Windows.Forms.ListBox available_room_box;
        private System.Windows.Forms.ListBox doctor_room_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button add_doctor_btn;
        private System.Windows.Forms.TextBox surname_input;
        private System.Windows.Forms.TextBox name_input;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button delete_doctor_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button add_spec_btn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button add_room_btn;
        private System.Windows.Forms.Button back_btn;
    }
}
