namespace UniversityProjectVovk.ClassesForms
{
    partial class LiteratureForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.AutorText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 148);
            this.button1.Size = new System.Drawing.Size(189, 23);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Autor";
            // 
            // AutorText
            // 
            this.AutorText.Location = new System.Drawing.Point(57, 119);
            this.AutorText.Name = "AutorText";
            this.AutorText.Size = new System.Drawing.Size(122, 20);
            this.AutorText.TabIndex = 14;
            // 
            // LiteratureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 171);
            this.Controls.Add(this.AutorText);
            this.Controls.Add(this.label4);
            this.Name = "LiteratureForm";
            this.Text = "LiteratureForm";
            this.Load += new System.EventHandler(this.LiteratureForm_Load);
            this.Controls.SetChildIndex(this.PurposeText, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.MatherialText, 0);
            this.Controls.SetChildIndex(this.OwnerText, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.AutorText, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AutorText;
    }
}