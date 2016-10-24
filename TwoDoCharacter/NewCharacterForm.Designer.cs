namespace TwoDoCharacter
{
    partial class NewCharacterForm
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
            this.picChar = new System.Windows.Forms.PictureBox();
            this.btnSelectImg = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlAttributes = new System.Windows.Forms.Panel();
            this.txtVit = new System.Windows.Forms.TextBox();
            this.txtDex = new System.Windows.Forms.TextBox();
            this.txtInt = new System.Windows.Forms.TextBox();
            this.txtStr = new System.Windows.Forms.TextBox();
            this.txtBaseHP = new System.Windows.Forms.TextBox();
            this.txtBaseMP = new System.Windows.Forms.TextBox();
            this.txtLuck = new System.Windows.Forms.TextBox();
            this.txtMinLevel = new System.Windows.Forms.TextBox();
            this.lblMinLevel = new System.Windows.Forms.Label();
            this.lblInteligence = new System.Windows.Forms.Label();
            this.lblVitality = new System.Windows.Forms.Label();
            this.lblLuck = new System.Windows.Forms.Label();
            this.lblDexterity = new System.Windows.Forms.Label();
            this.lblBaseMp = new System.Windows.Forms.Label();
            this.lblBaseHp = new System.Windows.Forms.Label();
            this.lblStrength = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAdvanced = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.picChar)).BeginInit();
            this.pnlAttributes.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picChar
            // 
            this.picChar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picChar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picChar.Location = new System.Drawing.Point(5, 31);
            this.picChar.Name = "picChar";
            this.picChar.Size = new System.Drawing.Size(160, 160);
            this.picChar.TabIndex = 0;
            this.picChar.TabStop = false;
            // 
            // btnSelectImg
            // 
            this.btnSelectImg.Location = new System.Drawing.Point(5, 194);
            this.btnSelectImg.Name = "btnSelectImg";
            this.btnSelectImg.Size = new System.Drawing.Size(160, 24);
            this.btnSelectImg.TabIndex = 10;
            this.btnSelectImg.Text = "Select Image ...";
            this.btnSelectImg.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.SystemColors.Window;
            this.lblName.Location = new System.Drawing.Point(168, 38);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // pnlAttributes
            // 
            this.pnlAttributes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.pnlAttributes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAttributes.Controls.Add(this.txtVit);
            this.pnlAttributes.Controls.Add(this.txtDex);
            this.pnlAttributes.Controls.Add(this.txtInt);
            this.pnlAttributes.Controls.Add(this.txtStr);
            this.pnlAttributes.Controls.Add(this.txtBaseHP);
            this.pnlAttributes.Controls.Add(this.txtBaseMP);
            this.pnlAttributes.Controls.Add(this.txtLuck);
            this.pnlAttributes.Controls.Add(this.txtMinLevel);
            this.pnlAttributes.Controls.Add(this.lblMinLevel);
            this.pnlAttributes.Controls.Add(this.lblInteligence);
            this.pnlAttributes.Controls.Add(this.lblVitality);
            this.pnlAttributes.Controls.Add(this.lblLuck);
            this.pnlAttributes.Controls.Add(this.lblDexterity);
            this.pnlAttributes.Controls.Add(this.lblBaseMp);
            this.pnlAttributes.Controls.Add(this.lblBaseHp);
            this.pnlAttributes.Controls.Add(this.lblStrength);
            this.pnlAttributes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlAttributes.Location = new System.Drawing.Point(168, 65);
            this.pnlAttributes.Name = "pnlAttributes";
            this.pnlAttributes.Size = new System.Drawing.Size(320, 126);
            this.pnlAttributes.TabIndex = 3;
            // 
            // txtVit
            // 
            this.txtVit.Location = new System.Drawing.Point(70, 97);
            this.txtVit.MaxLength = 10;
            this.txtVit.Name = "txtVit";
            this.txtVit.Size = new System.Drawing.Size(80, 20);
            this.txtVit.TabIndex = 4;
            // 
            // txtDex
            // 
            this.txtDex.Location = new System.Drawing.Point(70, 67);
            this.txtDex.MaxLength = 10;
            this.txtDex.Name = "txtDex";
            this.txtDex.Size = new System.Drawing.Size(80, 20);
            this.txtDex.TabIndex = 3;
            // 
            // txtInt
            // 
            this.txtInt.Location = new System.Drawing.Point(70, 37);
            this.txtInt.MaxLength = 10;
            this.txtInt.Name = "txtInt";
            this.txtInt.Size = new System.Drawing.Size(80, 20);
            this.txtInt.TabIndex = 2;
            // 
            // txtStr
            // 
            this.txtStr.Location = new System.Drawing.Point(70, 7);
            this.txtStr.MaxLength = 10;
            this.txtStr.Name = "txtStr";
            this.txtStr.Size = new System.Drawing.Size(80, 20);
            this.txtStr.TabIndex = 1;
            // 
            // txtBaseHP
            // 
            this.txtBaseHP.Location = new System.Drawing.Point(228, 7);
            this.txtBaseHP.MaxLength = 10;
            this.txtBaseHP.Name = "txtBaseHP";
            this.txtBaseHP.Size = new System.Drawing.Size(80, 20);
            this.txtBaseHP.TabIndex = 5;
            // 
            // txtBaseMP
            // 
            this.txtBaseMP.Location = new System.Drawing.Point(228, 37);
            this.txtBaseMP.MaxLength = 10;
            this.txtBaseMP.Name = "txtBaseMP";
            this.txtBaseMP.Size = new System.Drawing.Size(80, 20);
            this.txtBaseMP.TabIndex = 6;
            // 
            // txtLuck
            // 
            this.txtLuck.Location = new System.Drawing.Point(228, 67);
            this.txtLuck.MaxLength = 10;
            this.txtLuck.Name = "txtLuck";
            this.txtLuck.Size = new System.Drawing.Size(80, 20);
            this.txtLuck.TabIndex = 7;
            // 
            // txtMinLevel
            // 
            this.txtMinLevel.Location = new System.Drawing.Point(228, 97);
            this.txtMinLevel.MaxLength = 10;
            this.txtMinLevel.Name = "txtMinLevel";
            this.txtMinLevel.Size = new System.Drawing.Size(80, 20);
            this.txtMinLevel.TabIndex = 7;
            // 
            // lblMinLevel
            // 
            this.lblMinLevel.AutoSize = true;
            this.lblMinLevel.ForeColor = System.Drawing.SystemColors.Window;
            this.lblMinLevel.Location = new System.Drawing.Point(171, 100);
            this.lblMinLevel.Name = "lblMinLevel";
            this.lblMinLevel.Size = new System.Drawing.Size(56, 13);
            this.lblMinLevel.TabIndex = 12;
            this.lblMinLevel.Text = "Min. Level";
            // 
            // lblInteligence
            // 
            this.lblInteligence.AutoSize = true;
            this.lblInteligence.ForeColor = System.Drawing.SystemColors.Window;
            this.lblInteligence.Location = new System.Drawing.Point(7, 40);
            this.lblInteligence.Name = "lblInteligence";
            this.lblInteligence.Size = new System.Drawing.Size(59, 13);
            this.lblInteligence.TabIndex = 11;
            this.lblInteligence.Text = "Inteligence";
            // 
            // lblVitality
            // 
            this.lblVitality.AutoSize = true;
            this.lblVitality.ForeColor = System.Drawing.SystemColors.Window;
            this.lblVitality.Location = new System.Drawing.Point(7, 100);
            this.lblVitality.Name = "lblVitality";
            this.lblVitality.Size = new System.Drawing.Size(37, 13);
            this.lblVitality.TabIndex = 10;
            this.lblVitality.Text = "Vitality";
            // 
            // lblLuck
            // 
            this.lblLuck.AutoSize = true;
            this.lblLuck.ForeColor = System.Drawing.SystemColors.Window;
            this.lblLuck.Location = new System.Drawing.Point(171, 70);
            this.lblLuck.Name = "lblLuck";
            this.lblLuck.Size = new System.Drawing.Size(31, 13);
            this.lblLuck.TabIndex = 9;
            this.lblLuck.Text = "Luck";
            // 
            // lblDexterity
            // 
            this.lblDexterity.AutoSize = true;
            this.lblDexterity.ForeColor = System.Drawing.SystemColors.Window;
            this.lblDexterity.Location = new System.Drawing.Point(7, 70);
            this.lblDexterity.Name = "lblDexterity";
            this.lblDexterity.Size = new System.Drawing.Size(48, 13);
            this.lblDexterity.TabIndex = 8;
            this.lblDexterity.Text = "Dexterity";
            // 
            // lblBaseMp
            // 
            this.lblBaseMp.AutoSize = true;
            this.lblBaseMp.ForeColor = System.Drawing.SystemColors.Window;
            this.lblBaseMp.Location = new System.Drawing.Point(171, 40);
            this.lblBaseMp.Name = "lblBaseMp";
            this.lblBaseMp.Size = new System.Drawing.Size(50, 13);
            this.lblBaseMp.TabIndex = 7;
            this.lblBaseMp.Text = "Base MP";
            // 
            // lblBaseHp
            // 
            this.lblBaseHp.AutoSize = true;
            this.lblBaseHp.ForeColor = System.Drawing.SystemColors.Window;
            this.lblBaseHp.Location = new System.Drawing.Point(171, 10);
            this.lblBaseHp.Name = "lblBaseHp";
            this.lblBaseHp.Size = new System.Drawing.Size(49, 13);
            this.lblBaseHp.TabIndex = 6;
            this.lblBaseHp.Text = "Base HP";
            // 
            // lblStrength
            // 
            this.lblStrength.AutoSize = true;
            this.lblStrength.ForeColor = System.Drawing.SystemColors.Window;
            this.lblStrength.Location = new System.Drawing.Point(7, 10);
            this.lblStrength.Name = "lblStrength";
            this.lblStrength.Size = new System.Drawing.Size(47, 13);
            this.lblStrength.TabIndex = 5;
            this.lblStrength.Text = "Strength";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(226, 36);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(262, 20);
            this.txtName.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(413, 195);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnAdvanced
            // 
            this.btnAdvanced.Location = new System.Drawing.Point(239, 195);
            this.btnAdvanced.Name = "btnAdvanced";
            this.btnAdvanced.Size = new System.Drawing.Size(80, 23);
            this.btnAdvanced.TabIndex = 12;
            this.btnAdvanced.Text = "Advanced";
            this.btnAdvanced.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(5, 225);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(483, 253);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(475, 227);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // NewCharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnAdvanced);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.pnlAttributes);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnSelectImg);
            this.Controls.Add(this.picChar);
            this.Name = "NewCharacterForm";
            this.Text = "NewCharacterForm";
            ((System.ComponentModel.ISupportInitialize)(this.picChar)).EndInit();
            this.pnlAttributes.ResumeLayout(false);
            this.pnlAttributes.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picChar;
        private System.Windows.Forms.Button btnSelectImg;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pnlAttributes;
        private System.Windows.Forms.Label lblStrength;
        private System.Windows.Forms.Label lblMinLevel;
        private System.Windows.Forms.Label lblInteligence;
        private System.Windows.Forms.Label lblVitality;
        private System.Windows.Forms.Label lblLuck;
        private System.Windows.Forms.Label lblDexterity;
        private System.Windows.Forms.Label lblBaseMp;
        private System.Windows.Forms.Label lblBaseHp;
        private System.Windows.Forms.TextBox txtVit;
        private System.Windows.Forms.TextBox txtDex;
        private System.Windows.Forms.TextBox txtInt;
        private System.Windows.Forms.TextBox txtStr;
        private System.Windows.Forms.TextBox txtBaseHP;
        private System.Windows.Forms.TextBox txtBaseMP;
        private System.Windows.Forms.TextBox txtLuck;
        private System.Windows.Forms.TextBox txtMinLevel;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAdvanced;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;

    }
}