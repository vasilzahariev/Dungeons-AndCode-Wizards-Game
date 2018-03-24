namespace DungeonsAndCodeWizardsGame.Forms
{
    partial class PickUpItemForm
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
            this.CharacterNameText = new System.Windows.Forms.RichTextBox();
            this.CharacterNameResult = new System.Windows.Forms.RichTextBox();
            this.AddItemToPoolSubmit = new System.Windows.Forms.Button();
            this.AddItemToPoolCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CharacterNameText
            // 
            this.CharacterNameText.BackColor = System.Drawing.SystemColors.Control;
            this.CharacterNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CharacterNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharacterNameText.Location = new System.Drawing.Point(12, 95);
            this.CharacterNameText.Name = "CharacterNameText";
            this.CharacterNameText.Size = new System.Drawing.Size(215, 43);
            this.CharacterNameText.TabIndex = 0;
            this.CharacterNameText.Text = "Character Name:";
            // 
            // CharacterNameResult
            // 
            this.CharacterNameResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharacterNameResult.Location = new System.Drawing.Point(233, 95);
            this.CharacterNameResult.Name = "CharacterNameResult";
            this.CharacterNameResult.Size = new System.Drawing.Size(212, 43);
            this.CharacterNameResult.TabIndex = 1;
            this.CharacterNameResult.Text = "";
            // 
            // AddItemToPoolSubmit
            // 
            this.AddItemToPoolSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddItemToPoolSubmit.Location = new System.Drawing.Point(12, 230);
            this.AddItemToPoolSubmit.Name = "AddItemToPoolSubmit";
            this.AddItemToPoolSubmit.Size = new System.Drawing.Size(162, 66);
            this.AddItemToPoolSubmit.TabIndex = 8;
            this.AddItemToPoolSubmit.Text = "Submit";
            this.AddItemToPoolSubmit.UseVisualStyleBackColor = true;
            this.AddItemToPoolSubmit.Click += new System.EventHandler(this.AddItemToPoolSubmit_Click);
            // 
            // AddItemToPoolCancel
            // 
            this.AddItemToPoolCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddItemToPoolCancel.Location = new System.Drawing.Point(283, 230);
            this.AddItemToPoolCancel.Name = "AddItemToPoolCancel";
            this.AddItemToPoolCancel.Size = new System.Drawing.Size(162, 66);
            this.AddItemToPoolCancel.TabIndex = 9;
            this.AddItemToPoolCancel.Text = "Cancel";
            this.AddItemToPoolCancel.UseVisualStyleBackColor = true;
            this.AddItemToPoolCancel.Click += new System.EventHandler(this.AddItemToPoolCancel_Click);
            // 
            // PickUpItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 308);
            this.Controls.Add(this.AddItemToPoolCancel);
            this.Controls.Add(this.AddItemToPoolSubmit);
            this.Controls.Add(this.CharacterNameResult);
            this.Controls.Add(this.CharacterNameText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PickUpItemForm";
            this.Text = "Pick Up Item";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox CharacterNameText;
        private System.Windows.Forms.Button AddItemToPoolSubmit;
        private System.Windows.Forms.Button AddItemToPoolCancel;
        public System.Windows.Forms.RichTextBox CharacterNameResult;
    }
}