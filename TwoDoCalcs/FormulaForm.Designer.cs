namespace TwoDoCalcs
{
    partial class FormulaForm
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
            this.fMinPAtk = new TwoDoCustomForm.CustomFormulaEditor();
            this.fMinMAtk = new TwoDoCustomForm.CustomFormulaEditor();
            this.fMaxPAtk = new TwoDoCustomForm.CustomFormulaEditor();
            this.fPDamage = new TwoDoCustomForm.CustomFormulaEditor();
            this.fMaxMAtk = new TwoDoCustomForm.CustomFormulaEditor();
            this.fMDamage = new TwoDoCustomForm.CustomFormulaEditor();
            this.SuspendLayout();
            // 
            // fMinPAtk
            // 
            this.fMinPAtk.LabelText = "Min Physical Attack";
            this.fMinPAtk.Location = new System.Drawing.Point(3, 41);
            this.fMinPAtk.Name = "fMinPAtk";
            this.fMinPAtk.Size = new System.Drawing.Size(264, 23);
            this.fMinPAtk.TabIndex = 1;
            // 
            // fMinMAtk
            //             
            this.fMinMAtk.LabelText = "Min Magical Attack";
            this.fMinMAtk.Location = new System.Drawing.Point(308, 40);
            this.fMinMAtk.Name = "fMinMAtk";
            this.fMinMAtk.Size = new System.Drawing.Size(263, 23);
            this.fMinMAtk.TabIndex = 4;
            // 
            // fMaxPAtk
            // 
            this.fMaxPAtk.LabelText = "Max Physical Attack";
            this.fMaxPAtk.Location = new System.Drawing.Point(3, 69);
            this.fMaxPAtk.Name = "fMaxPAtk";
            this.fMaxPAtk.Size = new System.Drawing.Size(264, 23);
            this.fMaxPAtk.TabIndex = 2;
            // 
            // fPDamage
            //             
            this.fPDamage.LabelText = "Physical Damage";
            this.fPDamage.Location = new System.Drawing.Point(3, 98);
            this.fPDamage.Name = "fPDamage";
            this.fPDamage.Size = new System.Drawing.Size(264, 23);
            this.fPDamage.TabIndex = 3;
            // 
            // fMaxMAtk
            // 
            this.fMaxMAtk.LabelText = "Max Magical Attack";
            this.fMaxMAtk.Location = new System.Drawing.Point(308, 69);
            this.fMaxMAtk.Name = "fMaxMAtk";
            this.fMaxMAtk.Size = new System.Drawing.Size(263, 23);
            this.fMaxMAtk.TabIndex = 5;
            // 
            // fMDamage
            // 
            
            this.fMDamage.LabelText = "Magical Damage";
            this.fMDamage.Location = new System.Drawing.Point(308, 98);
            this.fMDamage.Name = "fMDamage";
            this.fMDamage.Size = new System.Drawing.Size(263, 23);
            this.fMDamage.TabIndex = 6;
            // 
            // FormulaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 500);
            this.Controls.Add(this.fMDamage);
            this.Controls.Add(this.fMaxMAtk);
            this.Controls.Add(this.fMinMAtk);
            this.Controls.Add(this.fPDamage);
            this.Controls.Add(this.fMaxPAtk);
            this.Controls.Add(this.fMinPAtk);
            this.Name = "FormulaForm";
            this.Text = "FomulaForm";
            this.ResumeLayout(false);

        }

        #endregion

        private TwoDoCustomForm.CustomFormulaEditor fMinPAtk;
        private TwoDoCustomForm.CustomFormulaEditor fMinMAtk;
        private TwoDoCustomForm.CustomFormulaEditor fMaxPAtk;
        private TwoDoCustomForm.CustomFormulaEditor fPDamage;
        private TwoDoCustomForm.CustomFormulaEditor fMaxMAtk;
        private TwoDoCustomForm.CustomFormulaEditor fMDamage;
    }
}