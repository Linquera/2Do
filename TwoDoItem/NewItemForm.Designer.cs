namespace TwoDoItem
{
    partial class NewItemForm
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSelectImg = new System.Windows.Forms.Button();
            this.picItem = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.btnAdvanced = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbObtain = new System.Windows.Forms.GroupBox();
            this.chkNotObtainable = new System.Windows.Forms.CheckBox();
            this.chkEvent = new System.Windows.Forms.CheckBox();
            this.chkCraft = new System.Windows.Forms.CheckBox();
            this.chkStory = new System.Windows.Forms.CheckBox();
            this.chkLootOnGround = new System.Windows.Forms.CheckBox();
            this.chkTreasureBox = new System.Windows.Forms.CheckBox();
            this.chkQuest = new System.Windows.Forms.CheckBox();
            this.chkMonsterDrop = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picItem)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbObtain.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(227, 37);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(262, 20);
            this.txtName.TabIndex = 11;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.SystemColors.Window;
            this.lblName.Location = new System.Drawing.Point(169, 39);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "Name";
            // 
            // btnSelectImg
            // 
            this.btnSelectImg.Location = new System.Drawing.Point(6, 195);
            this.btnSelectImg.Name = "btnSelectImg";
            this.btnSelectImg.Size = new System.Drawing.Size(160, 24);
            this.btnSelectImg.TabIndex = 14;
            this.btnSelectImg.Text = "Select Image ...";
            this.btnSelectImg.UseVisualStyleBackColor = true;
            // 
            // picItem
            // 
            this.picItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picItem.Location = new System.Drawing.Point(6, 32);
            this.picItem.Name = "picItem";
            this.picItem.Size = new System.Drawing.Size(160, 160);
            this.picItem.TabIndex = 12;
            this.picItem.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(414, 196);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(6, 23);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(98, 21);
            this.cbCategory.TabIndex = 24;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.ForeColor = System.Drawing.Color.White;
            this.lblCategory.Location = new System.Drawing.Point(3, 7);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 23;
            this.lblCategory.Text = "Category";
            // 
            // btnAdvanced
            // 
            this.btnAdvanced.Location = new System.Drawing.Point(242, 196);
            this.btnAdvanced.Name = "btnAdvanced";
            this.btnAdvanced.Size = new System.Drawing.Size(80, 23);
            this.btnAdvanced.TabIndex = 25;
            this.btnAdvanced.Text = "Advanced";
            this.btnAdvanced.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbObtain);
            this.panel1.Controls.Add(this.lblCategory);
            this.panel1.Controls.Add(this.cbCategory);
            this.panel1.Location = new System.Drawing.Point(172, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 127);
            this.panel1.TabIndex = 26;
            // 
            // gbObtain
            // 
            this.gbObtain.Controls.Add(this.chkNotObtainable);
            this.gbObtain.Controls.Add(this.chkEvent);
            this.gbObtain.Controls.Add(this.chkCraft);
            this.gbObtain.Controls.Add(this.chkStory);
            this.gbObtain.Controls.Add(this.chkLootOnGround);
            this.gbObtain.Controls.Add(this.chkTreasureBox);
            this.gbObtain.Controls.Add(this.chkQuest);
            this.gbObtain.Controls.Add(this.chkMonsterDrop);
            this.gbObtain.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbObtain.Location = new System.Drawing.Point(110, 7);
            this.gbObtain.Name = "gbObtain";
            this.gbObtain.Size = new System.Drawing.Size(204, 113);
            this.gbObtain.TabIndex = 25;
            this.gbObtain.TabStop = false;
            this.gbObtain.Text = "How to Obtain";
            // 
            // chkNotObtainable
            // 
            this.chkNotObtainable.AutoSize = true;
            this.chkNotObtainable.Location = new System.Drawing.Point(91, 88);
            this.chkNotObtainable.Name = "chkNotObtainable";
            this.chkNotObtainable.Size = new System.Drawing.Size(97, 17);
            this.chkNotObtainable.TabIndex = 4;
            this.chkNotObtainable.Text = "Not Obtainable";
            this.chkNotObtainable.UseVisualStyleBackColor = true;
            // 
            // chkEvent
            // 
            this.chkEvent.AutoSize = true;
            this.chkEvent.Location = new System.Drawing.Point(91, 65);
            this.chkEvent.Name = "chkEvent";
            this.chkEvent.Size = new System.Drawing.Size(54, 17);
            this.chkEvent.TabIndex = 4;
            this.chkEvent.Text = "Event";
            this.chkEvent.UseVisualStyleBackColor = true;
            // 
            // chkCraft
            // 
            this.chkCraft.AutoSize = true;
            this.chkCraft.Location = new System.Drawing.Point(6, 88);
            this.chkCraft.Name = "chkCraft";
            this.chkCraft.Size = new System.Drawing.Size(48, 17);
            this.chkCraft.TabIndex = 4;
            this.chkCraft.Text = "Craft";
            this.chkCraft.UseVisualStyleBackColor = true;
            // 
            // chkStory
            // 
            this.chkStory.AutoSize = true;
            this.chkStory.Location = new System.Drawing.Point(6, 19);
            this.chkStory.Name = "chkStory";
            this.chkStory.Size = new System.Drawing.Size(70, 17);
            this.chkStory.TabIndex = 4;
            this.chkStory.Text = "StoryLine";
            this.chkStory.UseVisualStyleBackColor = true;
            // 
            // chkLootOnGround
            // 
            this.chkLootOnGround.AutoSize = true;
            this.chkLootOnGround.Location = new System.Drawing.Point(91, 42);
            this.chkLootOnGround.Name = "chkLootOnGround";
            this.chkLootOnGround.Size = new System.Drawing.Size(78, 17);
            this.chkLootOnGround.TabIndex = 3;
            this.chkLootOnGround.Text = "On Ground";
            this.chkLootOnGround.UseVisualStyleBackColor = true;
            // 
            // chkTreasureBox
            // 
            this.chkTreasureBox.AutoSize = true;
            this.chkTreasureBox.Location = new System.Drawing.Point(6, 65);
            this.chkTreasureBox.Name = "chkTreasureBox";
            this.chkTreasureBox.Size = new System.Drawing.Size(89, 17);
            this.chkTreasureBox.TabIndex = 2;
            this.chkTreasureBox.Text = "Treasure Box";
            this.chkTreasureBox.UseVisualStyleBackColor = true;
            // 
            // chkQuest
            // 
            this.chkQuest.AutoSize = true;
            this.chkQuest.Location = new System.Drawing.Point(6, 42);
            this.chkQuest.Name = "chkQuest";
            this.chkQuest.Size = new System.Drawing.Size(54, 17);
            this.chkQuest.TabIndex = 1;
            this.chkQuest.Text = "Quest";
            this.chkQuest.UseVisualStyleBackColor = true;
            // 
            // chkMonsterDrop
            // 
            this.chkMonsterDrop.AutoSize = true;
            this.chkMonsterDrop.Location = new System.Drawing.Point(91, 19);
            this.chkMonsterDrop.Name = "chkMonsterDrop";
            this.chkMonsterDrop.Size = new System.Drawing.Size(90, 17);
            this.chkMonsterDrop.TabIndex = 0;
            this.chkMonsterDrop.Text = "Monster Drop";
            this.chkMonsterDrop.UseVisualStyleBackColor = true;
            // 
            // NewItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAdvanced);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnSelectImg);
            this.Controls.Add(this.picItem);
            this.Name = "NewItemForm";
            this.Text = "NewItemForm";
            ((System.ComponentModel.ISupportInitialize)(this.picItem)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbObtain.ResumeLayout(false);
            this.gbObtain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnSelectImg;
        private System.Windows.Forms.PictureBox picItem;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Button btnAdvanced;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbObtain;
        private System.Windows.Forms.CheckBox chkNotObtainable;
        private System.Windows.Forms.CheckBox chkEvent;
        private System.Windows.Forms.CheckBox chkCraft;
        private System.Windows.Forms.CheckBox chkStory;
        private System.Windows.Forms.CheckBox chkLootOnGround;
        private System.Windows.Forms.CheckBox chkTreasureBox;
        private System.Windows.Forms.CheckBox chkQuest;
        private System.Windows.Forms.CheckBox chkMonsterDrop;
    }
}