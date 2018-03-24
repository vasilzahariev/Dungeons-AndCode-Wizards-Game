namespace DungeonsAndCodeWizardsGame
{
    partial class JoinPartyForm
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
            this.FactionText = new System.Windows.Forms.RichTextBox();
            this.CharacterTypeText = new System.Windows.Forms.RichTextBox();
            this.NameText = new System.Windows.Forms.RichTextBox();
            this.JoinPartySubmit = new System.Windows.Forms.Button();
            this.JoinPartyCancel = new System.Windows.Forms.Button();
            this.FactionResult = new System.Windows.Forms.TextBox();
            this.CharacterTypeResult = new System.Windows.Forms.TextBox();
            this.NameResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FactionText
            // 
            this.FactionText.BackColor = System.Drawing.SystemColors.Control;
            this.FactionText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FactionText.Enabled = false;
            this.FactionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FactionText.Location = new System.Drawing.Point(108, 28);
            this.FactionText.Name = "FactionText";
            this.FactionText.Size = new System.Drawing.Size(121, 36);
            this.FactionText.TabIndex = 0;
            this.FactionText.Text = "Faction:";
            // 
            // CharacterTypeText
            // 
            this.CharacterTypeText.BackColor = System.Drawing.SystemColors.Control;
            this.CharacterTypeText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CharacterTypeText.Enabled = false;
            this.CharacterTypeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharacterTypeText.Location = new System.Drawing.Point(12, 92);
            this.CharacterTypeText.Name = "CharacterTypeText";
            this.CharacterTypeText.Size = new System.Drawing.Size(217, 36);
            this.CharacterTypeText.TabIndex = 2;
            this.CharacterTypeText.Text = "Character Type: ";
            // 
            // NameText
            // 
            this.NameText.BackColor = System.Drawing.SystemColors.Control;
            this.NameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameText.Enabled = false;
            this.NameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameText.Location = new System.Drawing.Point(108, 155);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(121, 36);
            this.NameText.TabIndex = 3;
            this.NameText.Text = "Name: ";
            // 
            // JoinPartySubmit
            // 
            this.JoinPartySubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JoinPartySubmit.Location = new System.Drawing.Point(12, 230);
            this.JoinPartySubmit.Name = "JoinPartySubmit";
            this.JoinPartySubmit.Size = new System.Drawing.Size(162, 66);
            this.JoinPartySubmit.TabIndex = 6;
            this.JoinPartySubmit.Text = "Submit";
            this.JoinPartySubmit.UseVisualStyleBackColor = true;
            this.JoinPartySubmit.Click += new System.EventHandler(this.JoinPartySubmit_Click);
            // 
            // JoinPartyCancel
            // 
            this.JoinPartyCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JoinPartyCancel.Location = new System.Drawing.Point(283, 230);
            this.JoinPartyCancel.Name = "JoinPartyCancel";
            this.JoinPartyCancel.Size = new System.Drawing.Size(162, 66);
            this.JoinPartyCancel.TabIndex = 7;
            this.JoinPartyCancel.Text = "Cancel";
            this.JoinPartyCancel.UseVisualStyleBackColor = true;
            this.JoinPartyCancel.Click += new System.EventHandler(this.JoinPartyCancel_Click);
            // 
            // FactionResult
            // 
            this.FactionResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FactionResult.Location = new System.Drawing.Point(235, 28);
            this.FactionResult.Name = "FactionResult";
            this.FactionResult.Size = new System.Drawing.Size(176, 38);
            this.FactionResult.TabIndex = 8;
            // 
            // CharacterTypeResult
            // 
            this.CharacterTypeResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharacterTypeResult.Location = new System.Drawing.Point(235, 92);
            this.CharacterTypeResult.Name = "CharacterTypeResult";
            this.CharacterTypeResult.Size = new System.Drawing.Size(176, 38);
            this.CharacterTypeResult.TabIndex = 9;
            // 
            // NameResult
            // 
            this.NameResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameResult.Location = new System.Drawing.Point(235, 155);
            this.NameResult.Name = "NameResult";
            this.NameResult.Size = new System.Drawing.Size(176, 38);
            this.NameResult.TabIndex = 10;
            // 
            // JoinPartyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 308);
            this.Controls.Add(this.NameResult);
            this.Controls.Add(this.CharacterTypeResult);
            this.Controls.Add(this.FactionResult);
            this.Controls.Add(this.JoinPartyCancel);
            this.Controls.Add(this.JoinPartySubmit);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.CharacterTypeText);
            this.Controls.Add(this.FactionText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "JoinPartyForm";
            this.Text = "Join Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox FactionText;
        private System.Windows.Forms.RichTextBox CharacterTypeText;
        private System.Windows.Forms.RichTextBox NameText;
        private System.Windows.Forms.Button JoinPartySubmit;
        private System.Windows.Forms.Button JoinPartyCancel;
        public System.Windows.Forms.TextBox FactionResult;
        public System.Windows.Forms.TextBox CharacterTypeResult;
        public System.Windows.Forms.TextBox NameResult;
    }
}