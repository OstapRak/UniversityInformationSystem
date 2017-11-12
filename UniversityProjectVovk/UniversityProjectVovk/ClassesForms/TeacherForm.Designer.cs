namespace UniversityProjectVovk.ClassesForms
{
    partial class TeacherForm
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
            this.SpecialityText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button11.Location = new System.Drawing.Point(0, 150);
            this.button11.Size = new System.Drawing.Size(197, 23);
            // 
            // SpecialityText
            // 
            this.SpecialityText.Location = new System.Drawing.Point(89, 117);
            this.SpecialityText.Name = "SpecialityText";
            this.SpecialityText.Size = new System.Drawing.Size(100, 20);
            this.SpecialityText.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Speciality";
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 173);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SpecialityText);
            this.Name = "TeacherForm";
            this.Text = "TeacherForm";
            this.Load += new System.EventHandler(this.TeacherForm_Load);
            this.Controls.SetChildIndex(this.button11, 0);
            this.Controls.SetChildIndex(this.firstNameText, 0);
            this.Controls.SetChildIndex(this.secondNameText, 0);
            this.Controls.SetChildIndex(this.SpecialityText, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SpecialityText;
        private System.Windows.Forms.Label label5;
    }
}