namespace UniversityProjectVovk.ClassesForms
{
    partial class StudentForm
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
            this.IsPay = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.YearText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button11.Location = new System.Drawing.Point(0, 110);
            this.button11.Size = new System.Drawing.Size(195, 23);
            // 
            // IsPay
            // 
            this.IsPay.AutoSize = true;
            this.IsPay.Location = new System.Drawing.Point(15, 65);
            this.IsPay.Name = "IsPay";
            this.IsPay.Size = new System.Drawing.Size(54, 17);
            this.IsPay.TabIndex = 5;
            this.IsPay.Text = "Is pay";
            this.IsPay.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Year of entry";
            // 
            // YearText
            // 
            this.YearText.Location = new System.Drawing.Point(89, 82);
            this.YearText.Name = "YearText";
            this.YearText.Size = new System.Drawing.Size(100, 20);
            this.YearText.TabIndex = 7;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 133);
            this.Controls.Add(this.YearText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IsPay);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.Controls.SetChildIndex(this.button11, 0);
            this.Controls.SetChildIndex(this.firstNameText, 0);
            this.Controls.SetChildIndex(this.secondNameText, 0);
            this.Controls.SetChildIndex(this.IsPay, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.YearText, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.CheckBox IsPay;
        private System.Windows.Forms.Label label3;
        protected System.Windows.Forms.TextBox YearText;
    }
}