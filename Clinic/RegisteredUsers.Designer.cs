namespace Clinic
{
    partial class RegisteredUsers
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
            this.register_box = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista Rejestracji";
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(3, 524);
            this.back_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 23);
            this.back_btn.TabIndex = 8;
            this.back_btn.Text = "Powrót";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // register_box
            // 
            this.register_box.FormattingEnabled = true;
            this.register_box.ItemHeight = 16;
            this.register_box.Location = new System.Drawing.Point(17, 41);
            this.register_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.register_box.Name = "register_box";
            this.register_box.Size = new System.Drawing.Size(352, 468);
            this.register_box.TabIndex = 9;
            // 
            // RegisteredUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.register_box);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RegisteredUsers";
            this.Size = new System.Drawing.Size(387, 550);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.ListBox register_box;
    }
}
