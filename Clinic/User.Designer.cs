namespace Clinic
{
    partial class User
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
            this.back_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.name_input = new System.Windows.Forms.TextBox();
            this.surname_input = new System.Windows.Forms.TextBox();
            this.pesel_input = new System.Windows.Forms.TextBox();
            this.telephone_input = new System.Windows.Forms.TextBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dodaj Nowego Pacjenta";
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(9, 410);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 23);
            this.back_btn.TabIndex = 1;
            this.back_btn.Text = "Powrót";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Imie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nazwisko";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Pesel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Numer Telefonu";
            // 
            // name_input
            // 
            this.name_input.Location = new System.Drawing.Point(50, 108);
            this.name_input.Name = "name_input";
            this.name_input.Size = new System.Drawing.Size(135, 22);
            this.name_input.TabIndex = 6;
            // 
            // surname_input
            // 
            this.surname_input.Location = new System.Drawing.Point(50, 163);
            this.surname_input.Name = "surname_input";
            this.surname_input.Size = new System.Drawing.Size(135, 22);
            this.surname_input.TabIndex = 7;
            // 
            // pesel_input
            // 
            this.pesel_input.Location = new System.Drawing.Point(50, 216);
            this.pesel_input.Name = "pesel_input";
            this.pesel_input.Size = new System.Drawing.Size(135, 22);
            this.pesel_input.TabIndex = 8;
            // 
            // telephone_input
            // 
            this.telephone_input.Location = new System.Drawing.Point(50, 279);
            this.telephone_input.Name = "telephone_input";
            this.telephone_input.Size = new System.Drawing.Size(135, 22);
            this.telephone_input.TabIndex = 9;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(308, 410);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 23);
            this.add_btn.TabIndex = 10;
            this.add_btn.Text = "Dodaj";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.telephone_input);
            this.Controls.Add(this.pesel_input);
            this.Controls.Add(this.surname_input);
            this.Controls.Add(this.name_input);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.label1);
            this.Name = "User";
            this.Size = new System.Drawing.Size(386, 442);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox name_input;
        private System.Windows.Forms.TextBox surname_input;
        private System.Windows.Forms.TextBox pesel_input;
        private System.Windows.Forms.TextBox telephone_input;
        private System.Windows.Forms.Button add_btn;
    }
}
