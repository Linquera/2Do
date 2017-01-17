namespace TwoDoCalcs
{
    partial class FormulaBuilderForm
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
            this.txtFormula = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.TabVariables = new System.Windows.Forms.TabControl();
            this.tabVarChar = new System.Windows.Forms.TabPage();
            this.lblLvl = new System.Windows.Forms.Label();
            this.lblVit = new System.Windows.Forms.Label();
            this.lblDex = new System.Windows.Forms.Label();
            this.lblInt = new System.Windows.Forms.Label();
            this.lblStr = new System.Windows.Forms.Label();
            this.tabItem = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnExp = new System.Windows.Forms.Button();
            this.btnRParentesis = new System.Windows.Forms.Button();
            this.btnLParentesis = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.tabEnemy = new System.Windows.Forms.TabPage();
            this.lblEnemyLvl = new System.Windows.Forms.Label();
            this.lblEnemyVit = new System.Windows.Forms.Label();
            this.lblEnemyDex = new System.Windows.Forms.Label();
            this.lblEnemyInt = new System.Windows.Forms.Label();
            this.lblEnemyStr = new System.Windows.Forms.Label();
            this.TabVariables.SuspendLayout();
            this.tabVarChar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabEnemy.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFormula
            // 
            this.txtFormula.Location = new System.Drawing.Point(12, 32);
            this.txtFormula.Name = "txtFormula";
            this.txtFormula.Size = new System.Drawing.Size(401, 20);
            this.txtFormula.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(419, 30);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(50, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // TabVariables
            // 
            this.TabVariables.Controls.Add(this.tabVarChar);
            this.TabVariables.Controls.Add(this.tabItem);
            this.TabVariables.Controls.Add(this.tabEnemy);
            this.TabVariables.Location = new System.Drawing.Point(12, 58);
            this.TabVariables.Name = "TabVariables";
            this.TabVariables.SelectedIndex = 0;
            this.TabVariables.Size = new System.Drawing.Size(357, 174);
            this.TabVariables.TabIndex = 2;
            // 
            // tabVarChar
            // 
            this.tabVarChar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.tabVarChar.Controls.Add(this.lblLvl);
            this.tabVarChar.Controls.Add(this.lblVit);
            this.tabVarChar.Controls.Add(this.lblDex);
            this.tabVarChar.Controls.Add(this.lblInt);
            this.tabVarChar.Controls.Add(this.lblStr);
            this.tabVarChar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabVarChar.Location = new System.Drawing.Point(4, 22);
            this.tabVarChar.Name = "tabVarChar";
            this.tabVarChar.Padding = new System.Windows.Forms.Padding(3);
            this.tabVarChar.Size = new System.Drawing.Size(349, 148);
            this.tabVarChar.TabIndex = 0;
            this.tabVarChar.Text = "Character";
            // 
            // lblLvl
            // 
            this.lblLvl.AutoSize = true;
            this.lblLvl.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblLvl.Location = new System.Drawing.Point(6, 111);
            this.lblLvl.Name = "lblLvl";
            this.lblLvl.Size = new System.Drawing.Size(33, 13);
            this.lblLvl.TabIndex = 4;
            this.lblLvl.Text = "Level";
            // 
            // lblVit
            // 
            this.lblVit.AutoSize = true;
            this.lblVit.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblVit.Location = new System.Drawing.Point(6, 86);
            this.lblVit.Name = "lblVit";
            this.lblVit.Size = new System.Drawing.Size(37, 13);
            this.lblVit.TabIndex = 3;
            this.lblVit.Text = "Vitality";
            // 
            // lblDex
            // 
            this.lblDex.AutoSize = true;
            this.lblDex.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblDex.Location = new System.Drawing.Point(6, 60);
            this.lblDex.Name = "lblDex";
            this.lblDex.Size = new System.Drawing.Size(48, 13);
            this.lblDex.TabIndex = 2;
            this.lblDex.Text = "Dexterity";
            // 
            // lblInt
            // 
            this.lblInt.AutoSize = true;
            this.lblInt.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblInt.Location = new System.Drawing.Point(6, 36);
            this.lblInt.Name = "lblInt";
            this.lblInt.Size = new System.Drawing.Size(59, 13);
            this.lblInt.TabIndex = 1;
            this.lblInt.Text = "Inteligence";
            // 
            // lblStr
            // 
            this.lblStr.AutoSize = true;
            this.lblStr.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblStr.Location = new System.Drawing.Point(6, 12);
            this.lblStr.Name = "lblStr";
            this.lblStr.Size = new System.Drawing.Size(47, 13);
            this.lblStr.TabIndex = 0;
            this.lblStr.Text = "Strength";
            // 
            // tabItem
            // 
            this.tabItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.tabItem.Location = new System.Drawing.Point(4, 22);
            this.tabItem.Name = "tabItem";
            this.tabItem.Padding = new System.Windows.Forms.Padding(3);
            this.tabItem.Size = new System.Drawing.Size(349, 148);
            this.tabItem.TabIndex = 1;
            this.tabItem.Text = "Item";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRandom);
            this.groupBox1.Controls.Add(this.btnExp);
            this.groupBox1.Controls.Add(this.btnRParentesis);
            this.groupBox1.Controls.Add(this.btnLParentesis);
            this.groupBox1.Controls.Add(this.btnDivision);
            this.groupBox1.Controls.Add(this.btnMinus);
            this.groupBox1.Controls.Add(this.btnMultiply);
            this.groupBox1.Controls.Add(this.btnPlus);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(375, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(113, 173);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operations";
            // 
            // btnRandom
            // 
            this.btnRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandom.Location = new System.Drawing.Point(58, 132);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(49, 31);
            this.btnRandom.TabIndex = 4;
            this.btnRandom.Text = "~";
            this.btnRandom.UseVisualStyleBackColor = true;
            // 
            // btnExp
            // 
            this.btnExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExp.Location = new System.Drawing.Point(6, 132);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(49, 31);
            this.btnExp.TabIndex = 4;
            this.btnExp.Text = "  ²";
            this.btnExp.UseVisualStyleBackColor = true;
            // 
            // btnRParentesis
            // 
            this.btnRParentesis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRParentesis.Location = new System.Drawing.Point(58, 95);
            this.btnRParentesis.Name = "btnRParentesis";
            this.btnRParentesis.Size = new System.Drawing.Size(49, 31);
            this.btnRParentesis.TabIndex = 4;
            this.btnRParentesis.Text = ")";
            this.btnRParentesis.UseVisualStyleBackColor = true;
            // 
            // btnLParentesis
            // 
            this.btnLParentesis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLParentesis.Location = new System.Drawing.Point(6, 95);
            this.btnLParentesis.Name = "btnLParentesis";
            this.btnLParentesis.Size = new System.Drawing.Size(49, 31);
            this.btnLParentesis.TabIndex = 4;
            this.btnLParentesis.Text = "(";
            this.btnLParentesis.UseVisualStyleBackColor = true;
            // 
            // btnDivision
            // 
            this.btnDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivision.Location = new System.Drawing.Point(58, 58);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(49, 31);
            this.btnDivision.TabIndex = 4;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.Location = new System.Drawing.Point(58, 21);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(49, 31);
            this.btnMinus.TabIndex = 4;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            // 
            // btnMultiply
            // 
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.Location = new System.Drawing.Point(6, 58);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(49, 31);
            this.btnMultiply.TabIndex = 4;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.Location = new System.Drawing.Point(6, 21);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(49, 31);
            this.btnPlus.TabIndex = 4;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            // 
            // tabEnemy
            // 
            this.tabEnemy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.tabEnemy.Controls.Add(this.lblEnemyLvl);
            this.tabEnemy.Controls.Add(this.lblEnemyVit);
            this.tabEnemy.Controls.Add(this.lblEnemyDex);
            this.tabEnemy.Controls.Add(this.lblEnemyInt);
            this.tabEnemy.Controls.Add(this.lblEnemyStr);
            this.tabEnemy.Location = new System.Drawing.Point(4, 22);
            this.tabEnemy.Name = "tabEnemy";
            this.tabEnemy.Padding = new System.Windows.Forms.Padding(3);
            this.tabEnemy.Size = new System.Drawing.Size(349, 148);
            this.tabEnemy.TabIndex = 2;
            this.tabEnemy.Text = "Enemy";
            // 
            // lblEnemyLvl
            // 
            this.lblEnemyLvl.AutoSize = true;
            this.lblEnemyLvl.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblEnemyLvl.Location = new System.Drawing.Point(6, 111);
            this.lblEnemyLvl.Name = "lblEnemyLvl";
            this.lblEnemyLvl.Size = new System.Drawing.Size(33, 13);
            this.lblEnemyLvl.TabIndex = 9;
            this.lblEnemyLvl.Text = "Level";
            // 
            // lblEnemyVit
            // 
            this.lblEnemyVit.AutoSize = true;
            this.lblEnemyVit.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblEnemyVit.Location = new System.Drawing.Point(6, 86);
            this.lblEnemyVit.Name = "lblEnemyVit";
            this.lblEnemyVit.Size = new System.Drawing.Size(37, 13);
            this.lblEnemyVit.TabIndex = 8;
            this.lblEnemyVit.Text = "Vitality";
            // 
            // lblEnemyDex
            // 
            this.lblEnemyDex.AutoSize = true;
            this.lblEnemyDex.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblEnemyDex.Location = new System.Drawing.Point(6, 60);
            this.lblEnemyDex.Name = "lblEnemyDex";
            this.lblEnemyDex.Size = new System.Drawing.Size(48, 13);
            this.lblEnemyDex.TabIndex = 7;
            this.lblEnemyDex.Text = "Dexterity";
            // 
            // lblEnemyInt
            // 
            this.lblEnemyInt.AutoSize = true;
            this.lblEnemyInt.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblEnemyInt.Location = new System.Drawing.Point(6, 36);
            this.lblEnemyInt.Name = "lblEnemyInt";
            this.lblEnemyInt.Size = new System.Drawing.Size(59, 13);
            this.lblEnemyInt.TabIndex = 6;
            this.lblEnemyInt.Text = "Inteligence";
            // 
            // lblEnemyStr
            // 
            this.lblEnemyStr.AutoSize = true;
            this.lblEnemyStr.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblEnemyStr.Location = new System.Drawing.Point(6, 12);
            this.lblEnemyStr.Name = "lblEnemyStr";
            this.lblEnemyStr.Size = new System.Drawing.Size(47, 13);
            this.lblEnemyStr.TabIndex = 5;
            this.lblEnemyStr.Text = "Strength";
            // 
            // FormulaBuilderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TabVariables);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtFormula);
            this.Name = "FormulaBuilderForm";
            this.Text = "FormulaBuilderForm";
            this.TabVariables.ResumeLayout(false);
            this.tabVarChar.ResumeLayout(false);
            this.tabVarChar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabEnemy.ResumeLayout(false);
            this.tabEnemy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFormula;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TabControl TabVariables;
        private System.Windows.Forms.TabPage tabVarChar;
        private System.Windows.Forms.TabPage tabItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnExp;
        private System.Windows.Forms.Button btnRParentesis;
        private System.Windows.Forms.Button btnLParentesis;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Label lblLvl;
        private System.Windows.Forms.Label lblVit;
        private System.Windows.Forms.Label lblDex;
        private System.Windows.Forms.Label lblInt;
        private System.Windows.Forms.Label lblStr;
        private System.Windows.Forms.TabPage tabEnemy;
        private System.Windows.Forms.Label lblEnemyLvl;
        private System.Windows.Forms.Label lblEnemyVit;
        private System.Windows.Forms.Label lblEnemyDex;
        private System.Windows.Forms.Label lblEnemyInt;
        private System.Windows.Forms.Label lblEnemyStr;
    }
}