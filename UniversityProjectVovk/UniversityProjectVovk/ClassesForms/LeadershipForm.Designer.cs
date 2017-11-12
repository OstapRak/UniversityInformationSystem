namespace UniversityProjectVovk.ClassesForms
{
    partial class LeadershipForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.SubordinatesText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button11.Location = new System.Drawing.Point(0, 239);
            this.button11.Size = new System.Drawing.Size(204, 23);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Subordinates:";
            // 
            // SubordinatesText
            // 
            this.SubordinatesText.Location = new System.Drawing.Point(15, 128);
            this.SubordinatesText.Name = "SubordinatesText";
            this.SubordinatesText.Size = new System.Drawing.Size(177, 105);
            this.SubordinatesText.TabIndex = 11;
            this.SubordinatesText.Text = "";
            // 
            // LeadershipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 262);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SubordinatesText);
            this.Name = "LeadershipForm";
            this.Text = "LeadershipForm";
            this.Load += new System.EventHandler(this.LeadershipForm_Load);
            this.Controls.SetChildIndex(this.positionText, 0);
            this.Controls.SetChildIndex(this.sallaryText, 0);
            this.Controls.SetChildIndex(this.button11, 0);
            this.Controls.SetChildIndex(this.firstNameText, 0);
            this.Controls.SetChildIndex(this.secondNameText, 0);
            this.Controls.SetChildIndex(this.SubordinatesText, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox SubordinatesText;
    }
}