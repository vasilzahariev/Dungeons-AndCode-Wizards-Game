namespace DungeonsAndCodeWizardsGame
{
    partial class ErrorForm
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
            this.ProblemOutputer = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ProblemOutputer
            // 
            this.ProblemOutputer.BackColor = System.Drawing.SystemColors.Control;
            this.ProblemOutputer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProblemOutputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProblemOutputer.Location = new System.Drawing.Point(12, 12);
            this.ProblemOutputer.Name = "ProblemOutputer";
            this.ProblemOutputer.ReadOnly = true;
            this.ProblemOutputer.Size = new System.Drawing.Size(310, 52);
            this.ProblemOutputer.TabIndex = 0;
            this.ProblemOutputer.Text = "Problem:";
            // 
            // ErrorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 76);
            this.Controls.Add(this.ProblemOutputer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ErrorForm";
            this.Text = "Error";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox ProblemOutputer;
    }
}