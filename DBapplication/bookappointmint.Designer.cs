
namespace DBapplication
{
    partial class bookappointmint
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
            this.daycomboBox = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.appointmentcomboBox = new System.Windows.Forms.ComboBox();
            this.departmentcombobox = new System.Windows.Forms.ComboBox();
            this.doctorcomboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bookbutton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // daycomboBox
            // 
            this.daycomboBox.FormattingEnabled = true;
            this.daycomboBox.Location = new System.Drawing.Point(165, 154);
            this.daycomboBox.Name = "daycomboBox";
            this.daycomboBox.Size = new System.Drawing.Size(121, 24);
            this.daycomboBox.TabIndex = 0;
            this.daycomboBox.SelectedIndexChanged += new System.EventHandler(this.daycomboBox_SelectedIndexChanged);
            // 
            // appointmentcomboBox
            // 
            this.appointmentcomboBox.FormattingEnabled = true;
            this.appointmentcomboBox.Location = new System.Drawing.Point(165, 202);
            this.appointmentcomboBox.Name = "appointmentcomboBox";
            this.appointmentcomboBox.Size = new System.Drawing.Size(121, 24);
            this.appointmentcomboBox.TabIndex = 1;
            // 
            // departmentcombobox
            // 
            this.departmentcombobox.FormattingEnabled = true;
            this.departmentcombobox.Location = new System.Drawing.Point(165, 36);
            this.departmentcombobox.Name = "departmentcombobox";
            this.departmentcombobox.Size = new System.Drawing.Size(121, 24);
            this.departmentcombobox.TabIndex = 3;
            this.departmentcombobox.SelectedIndexChanged += new System.EventHandler(this.departmentcombobox_SelectedIndexChanged);
            // 
            // doctorcomboBox
            // 
            this.doctorcomboBox.FormattingEnabled = true;
            this.doctorcomboBox.Location = new System.Drawing.Point(165, 97);
            this.doctorcomboBox.Name = "doctorcomboBox";
            this.doctorcomboBox.Size = new System.Drawing.Size(121, 24);
            this.doctorcomboBox.TabIndex = 4;
            this.doctorcomboBox.SelectedIndexChanged += new System.EventHandler(this.doctorcomboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "choose your doctor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "choose department";
            // 
            // bookbutton
            // 
            this.bookbutton.Location = new System.Drawing.Point(84, 316);
            this.bookbutton.Name = "bookbutton";
            this.bookbutton.Size = new System.Drawing.Size(88, 30);
            this.bookbutton.TabIndex = 12;
            this.bookbutton.Text = "book ";
            this.bookbutton.UseVisualStyleBackColor = true;
            this.bookbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "choose day";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "choose appointment";
            // 
            // bookappointmint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bookbutton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.doctorcomboBox);
            this.Controls.Add(this.departmentcombobox);
            this.Controls.Add(this.appointmentcomboBox);
            this.Controls.Add(this.daycomboBox);
            this.Name = "bookappointmint";
            this.Text = "bookappointmint";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox daycomboBox;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ComboBox appointmentcomboBox;
        private System.Windows.Forms.ComboBox departmentcombobox;
        private System.Windows.Forms.ComboBox doctorcomboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bookbutton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}