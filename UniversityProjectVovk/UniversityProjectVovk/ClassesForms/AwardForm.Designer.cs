namespace UniversityProjectVovk.ClassesForms
{
    partial class AwardForm
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
            this.PresentText = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 268);
            this.button1.Size = new System.Drawing.Size(190, 23);
            // 
            // PresentText
            // 
            this.PresentText.Location = new System.Drawing.Point(8, 204);
            this.PresentText.Name = "PresentText";
            this.PresentText.Size = new System.Drawing.Size(170, 58);
            this.PresentText.TabIndex = 13;
            this.PresentText.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Present";
            // 
            // AwardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 291);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PresentText);
            this.Name = "AwardForm";
            this.Text = "AwardForm";
            this.Load += new System.EventHandler(this.AwardForm_Load);
            this.Controls.SetChildIndex(this.DescriptionText, 0);
            this.Controls.SetChildIndex(this.PurposeText, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.PersonText, 0);
            this.Controls.SetChildIndex(this.PresentText, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox PresentText;
        private System.Windows.Forms.Label label5;
    }
}