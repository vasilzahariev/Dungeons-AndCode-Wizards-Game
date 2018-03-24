namespace DungeonsAndCodeWizardsGame.Forms
{
    partial class AddItemToPoolForm
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
            this.ItemTypeGroup = new System.Windows.Forms.GroupBox();
            this.HealthPotion = new System.Windows.Forms.RadioButton();
            this.PoisonPotion = new System.Windows.Forms.RadioButton();
            this.ArmorRepairKit = new System.Windows.Forms.RadioButton();
            this.AddItemToPoolSubmit = new System.Windows.Forms.Button();
            this.AddItemToPoolCancel = new System.Windows.Forms.Button();
            this.ItemTypeGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemTypeGroup
            // 
            this.ItemTypeGroup.Controls.Add(this.ArmorRepairKit);
            this.ItemTypeGroup.Controls.Add(this.PoisonPotion);
            this.ItemTypeGroup.Controls.Add(this.HealthPotion);
            this.ItemTypeGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ItemTypeGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemTypeGroup.Location = new System.Drawing.Point(105, 12);
            this.ItemTypeGroup.Name = "ItemTypeGroup";
            this.ItemTypeGroup.Size = new System.Drawing.Size(239, 182);
            this.ItemTypeGroup.TabIndex = 1;
            this.ItemTypeGroup.TabStop = false;
            this.ItemTypeGroup.Text = "Item Type";
            // 
            // HealthPotion
            // 
            this.HealthPotion.AutoSize = true;
            this.HealthPotion.Location = new System.Drawing.Point(6, 37);
            this.HealthPotion.Name = "HealthPotion";
            this.HealthPotion.Size = new System.Drawing.Size(188, 35);
            this.HealthPotion.TabIndex = 2;
            this.HealthPotion.TabStop = true;
            this.HealthPotion.Text = "HealthPotion";
            this.HealthPotion.UseVisualStyleBackColor = true;
            // 
            // PoisonPotion
            // 
            this.PoisonPotion.AutoSize = true;
            this.PoisonPotion.Location = new System.Drawing.Point(6, 78);
            this.PoisonPotion.Name = "PoisonPotion";
            this.PoisonPotion.Size = new System.Drawing.Size(192, 35);
            this.PoisonPotion.TabIndex = 3;
            this.PoisonPotion.TabStop = true;
            this.PoisonPotion.Text = "PoisonPotion";
            this.PoisonPotion.UseVisualStyleBackColor = true;
            // 
            // ArmorRepairKit
            // 
            this.ArmorRepairKit.AutoSize = true;
            this.ArmorRepairKit.Location = new System.Drawing.Point(6, 119);
            this.ArmorRepairKit.Name = "ArmorRepairKit";
            this.ArmorRepairKit.Size = new System.Drawing.Size(231, 35);
            this.ArmorRepairKit.TabIndex = 4;
            this.ArmorRepairKit.TabStop = true;
            this.ArmorRepairKit.Text = "Armor Repair Kit";
            this.ArmorRepairKit.UseVisualStyleBackColor = true;
            // 
            // AddItemToPoolSubmit
            // 
            this.AddItemToPoolSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddItemToPoolSubmit.Location = new System.Drawing.Point(12, 230);
            this.AddItemToPoolSubmit.Name = "AddItemToPoolSubmit";
            this.AddItemToPoolSubmit.Size = new System.Drawing.Size(162, 66);
            this.AddItemToPoolSubmit.TabIndex = 7;
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
            this.AddItemToPoolCancel.TabIndex = 8;
            this.AddItemToPoolCancel.Text = "Cancel";
            this.AddItemToPoolCancel.UseVisualStyleBackColor = true;
            this.AddItemToPoolCancel.Click += new System.EventHandler(this.AddItemToPoolCancel_Click);
            // 
            // AddItemToPoolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 308);
            this.Controls.Add(this.AddItemToPoolCancel);
            this.Controls.Add(this.AddItemToPoolSubmit);
            this.Controls.Add(this.ItemTypeGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddItemToPoolForm";
            this.Text = "Add Item To Pool";
            this.ItemTypeGroup.ResumeLayout(false);
            this.ItemTypeGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.RadioButton HealthPotion;
        public System.Windows.Forms.RadioButton PoisonPotion;
        public System.Windows.Forms.RadioButton ArmorRepairKit;
        public System.Windows.Forms.GroupBox ItemTypeGroup;
        private System.Windows.Forms.Button AddItemToPoolSubmit;
        private System.Windows.Forms.Button AddItemToPoolCancel;
    }
}