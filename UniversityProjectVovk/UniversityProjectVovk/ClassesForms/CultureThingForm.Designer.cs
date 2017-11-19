namespace UniversityProjectVovk.ClassesForms
{
    partial class CultureThingForm
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
            this.DescriptionText = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 165);
            this.button1.Size = new System.Drawing.Size(186, 23);
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // DescriptionText
            // 
            this.DescriptionText.Location = new System.Drawing.Point(8, 88);
            this.DescriptionText.Name = "DescriptionText";
            this.DescriptionText.Size = new System.Drawing.Size(171, 66);
            this.DescriptionText.TabIndex = 10;
            this.DescriptionText.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Description";
            // 
            // CultureThingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(186, 188);
            this.Controls.Add(this.DescriptionText);
            this.Controls.Add(this.label3);
            this.Name = "CultureThingForm";
            this.Text = "CultureThingForm";
            this.Load += new System.EventHandler(this.CultureThingForm_Load);
            this.Controls.SetChildIndex(this.PurposeText, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.DescriptionText, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox DescriptionText;
        private System.Windows.Forms.Label label3;
    }
}