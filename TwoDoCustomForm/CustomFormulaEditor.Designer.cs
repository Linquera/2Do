namespace TwoDoCustomForm
{
    partial class CustomFormulaEditor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.TxtFormula = new System.Windows.Forms.TextBox();
            this.btnEditor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(4, 4);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(79, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "------------------------";
            // 
            // TxtFormula
            // 
            this.TxtFormula.Location = new System.Drawing.Point(109, 1);
            this.TxtFormula.Name = "TxtFormula";
            this.TxtFormula.Size = new System.Drawing.Size(125, 20);
            this.TxtFormula.TabIndex = 1;
            // 
            // btnEditor
            // 
            this.btnEditor.Location = new System.Drawing.Point(234, 0);
            this.btnEditor.Name = "btnEditor";
            this.btnEditor.Size = new System.Drawing.Size(27, 23);
            this.btnEditor.TabIndex = 2;
            this.btnEditor.Text = "...";
            this.btnEditor.UseVisualStyleBackColor = true;
            // 
            // CustomFormulaEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEditor);
            this.Controls.Add(this.TxtFormula);
            this.Controls.Add(this.lblName);
            this.Name = "CustomFormulaEditor";
            this.Size = new System.Drawing.Size(263, 23);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox TxtFormula;
        private System.Windows.Forms.Button btnEditor;
    }
}
