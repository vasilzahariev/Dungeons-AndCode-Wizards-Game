using System;

namespace DungeonsAndCodeWizardsGame
{
    partial class GameForm
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
            this.Console = new System.Windows.Forms.RichTextBox();
            this.JoinPartyBtn = new System.Windows.Forms.Button();
            this.AddItemToPoolBtn = new System.Windows.Forms.Button();
            this.PickUpItemBtn = new System.Windows.Forms.Button();
            this.UseItemBtn = new System.Windows.Forms.Button();
            this.UseItemOnBtn = new System.Windows.Forms.Button();
            this.GiveCharacterItemBtn = new System.Windows.Forms.Button();
            this.AttackBtn = new System.Windows.Forms.Button();
            this.HealBtn = new System.Windows.Forms.Button();
            this.EndTurnBtn = new System.Windows.Forms.Button();
            this.BackToMenuBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Console
            // 
            this.Console.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Console.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Console.Location = new System.Drawing.Point(12, 477);
            this.Console.Name = "Console";
            this.Console.ReadOnly = true;
            this.Console.Size = new System.Drawing.Size(511, 161);
            this.Console.TabIndex = 5;
            this.Console.Text = "Welcome to Dungeons And Code Wizards Game!\n";
            // 
            // JoinPartyBtn
            // 
            this.JoinPartyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JoinPartyBtn.Location = new System.Drawing.Point(12, 12);
            this.JoinPartyBtn.Name = "JoinPartyBtn";
            this.JoinPartyBtn.Size = new System.Drawing.Size(233, 73);
            this.JoinPartyBtn.TabIndex = 6;
            this.JoinPartyBtn.Text = "Join Party";
            this.JoinPartyBtn.UseVisualStyleBackColor = true;
            this.JoinPartyBtn.Click += new System.EventHandler(this.JoinPartyBtn_Click);
            // 
            // AddItemToPoolBtn
            // 
            this.AddItemToPoolBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddItemToPoolBtn.Location = new System.Drawing.Point(290, 12);
            this.AddItemToPoolBtn.Name = "AddItemToPoolBtn";
            this.AddItemToPoolBtn.Size = new System.Drawing.Size(233, 73);
            this.AddItemToPoolBtn.TabIndex = 7;
            this.AddItemToPoolBtn.Text = "Add Item To Pool";
            this.AddItemToPoolBtn.UseVisualStyleBackColor = true;
            this.AddItemToPoolBtn.Click += new System.EventHandler(this.AddItemToPoolBtn_Click);
            // 
            // PickUpItemBtn
            // 
            this.PickUpItemBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PickUpItemBtn.Location = new System.Drawing.Point(12, 91);
            this.PickUpItemBtn.Name = "PickUpItemBtn";
            this.PickUpItemBtn.Size = new System.Drawing.Size(233, 73);
            this.PickUpItemBtn.TabIndex = 8;
            this.PickUpItemBtn.Text = "Pick Up Item";
            this.PickUpItemBtn.UseVisualStyleBackColor = true;
            this.PickUpItemBtn.Click += new System.EventHandler(this.PickUpItemBtn_Click);
            // 
            // UseItemBtn
            // 
            this.UseItemBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UseItemBtn.Location = new System.Drawing.Point(290, 91);
            this.UseItemBtn.Name = "UseItemBtn";
            this.UseItemBtn.Size = new System.Drawing.Size(233, 73);
            this.UseItemBtn.TabIndex = 9;
            this.UseItemBtn.Text = "Use Item";
            this.UseItemBtn.UseVisualStyleBackColor = true;
            // 
            // UseItemOnBtn
            // 
            this.UseItemOnBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UseItemOnBtn.Location = new System.Drawing.Point(12, 170);
            this.UseItemOnBtn.Name = "UseItemOnBtn";
            this.UseItemOnBtn.Size = new System.Drawing.Size(233, 73);
            this.UseItemOnBtn.TabIndex = 10;
            this.UseItemOnBtn.Text = "Use Item On";
            this.UseItemOnBtn.UseVisualStyleBackColor = true;
            // 
            // GiveCharacterItemBtn
            // 
            this.GiveCharacterItemBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GiveCharacterItemBtn.Location = new System.Drawing.Point(290, 170);
            this.GiveCharacterItemBtn.Name = "GiveCharacterItemBtn";
            this.GiveCharacterItemBtn.Size = new System.Drawing.Size(233, 73);
            this.GiveCharacterItemBtn.TabIndex = 11;
            this.GiveCharacterItemBtn.Text = "Give Character Item";
            this.GiveCharacterItemBtn.UseVisualStyleBackColor = true;
            // 
            // AttackBtn
            // 
            this.AttackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AttackBtn.Location = new System.Drawing.Point(12, 249);
            this.AttackBtn.Name = "AttackBtn";
            this.AttackBtn.Size = new System.Drawing.Size(233, 73);
            this.AttackBtn.TabIndex = 12;
            this.AttackBtn.Text = "Attack";
            this.AttackBtn.UseVisualStyleBackColor = true;
            // 
            // HealBtn
            // 
            this.HealBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HealBtn.Location = new System.Drawing.Point(290, 249);
            this.HealBtn.Name = "HealBtn";
            this.HealBtn.Size = new System.Drawing.Size(233, 73);
            this.HealBtn.TabIndex = 13;
            this.HealBtn.Text = "Heal";
            this.HealBtn.UseVisualStyleBackColor = true;
            // 
            // EndTurnBtn
            // 
            this.EndTurnBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndTurnBtn.Location = new System.Drawing.Point(64, 356);
            this.EndTurnBtn.Name = "EndTurnBtn";
            this.EndTurnBtn.Size = new System.Drawing.Size(199, 73);
            this.EndTurnBtn.TabIndex = 14;
            this.EndTurnBtn.Text = "End Turn";
            this.EndTurnBtn.UseVisualStyleBackColor = true;
            // 
            // BackToMenuBtn
            // 
            this.BackToMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackToMenuBtn.Location = new System.Drawing.Point(280, 356);
            this.BackToMenuBtn.Name = "BackToMenuBtn";
            this.BackToMenuBtn.Size = new System.Drawing.Size(199, 73);
            this.BackToMenuBtn.TabIndex = 15;
            this.BackToMenuBtn.Text = "Back To Menu";
            this.BackToMenuBtn.UseVisualStyleBackColor = true;
            this.BackToMenuBtn.Click += new System.EventHandler(this.BackToMenuBtn_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 650);
            this.Controls.Add(this.BackToMenuBtn);
            this.Controls.Add(this.EndTurnBtn);
            this.Controls.Add(this.HealBtn);
            this.Controls.Add(this.AttackBtn);
            this.Controls.Add(this.GiveCharacterItemBtn);
            this.Controls.Add(this.UseItemOnBtn);
            this.Controls.Add(this.UseItemBtn);
            this.Controls.Add(this.PickUpItemBtn);
            this.Controls.Add(this.AddItemToPoolBtn);
            this.Controls.Add(this.JoinPartyBtn);
            this.Controls.Add(this.Console);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GameForm";
            this.Text = "Game";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox Console;
        private System.Windows.Forms.Button JoinPartyBtn;
        private System.Windows.Forms.Button AddItemToPoolBtn;
        private System.Windows.Forms.Button PickUpItemBtn;
        private System.Windows.Forms.Button UseItemBtn;
        private System.Windows.Forms.Button UseItemOnBtn;
        private System.Windows.Forms.Button GiveCharacterItemBtn;
        private System.Windows.Forms.Button AttackBtn;
        private System.Windows.Forms.Button HealBtn;
        private System.Windows.Forms.Button EndTurnBtn;
        private System.Windows.Forms.Button BackToMenuBtn;
    }
}