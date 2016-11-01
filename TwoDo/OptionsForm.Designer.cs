namespace TwoDo
{
    partial class OptionsForm
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
            this.gbLanguage = new System.Windows.Forms.GroupBox();
            this.rbPortuguese = new System.Windows.Forms.RadioButton();
            this.rbEnglish = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbLanguage.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLanguage
            // 
            this.gbLanguage.Controls.Add(this.rbPortuguese);
            this.gbLanguage.Controls.Add(this.rbEnglish);
            this.gbLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLanguage.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.gbLanguage.Location = new System.Drawing.Point(12, 35);
            this.gbLanguage.Name = "gbLanguage";
            this.gbLanguage.Size = new System.Drawing.Size(476, 50);
            this.gbLanguage.TabIndex = 0;
            this.gbLanguage.TabStop = false;
            this.gbLanguage.Text = "Language";
            // 
            // rbPortuguese
            // 
            this.rbPortuguese.AutoSize = true;
            this.rbPortuguese.Location = new System.Drawing.Point(97, 19);
            this.rbPortuguese.Name = "rbPortuguese";
            this.rbPortuguese.Size = new System.Drawing.Size(79, 17);
            this.rbPortuguese.TabIndex = 1;
            this.rbPortuguese.TabStop = true;
            this.rbPortuguese.Text = "Portuguese";
            this.rbPortuguese.UseVisualStyleBackColor = true;
            // 
            // rbEnglish
            // 
            this.rbEnglish.AutoSize = true;
            this.rbEnglish.Location = new System.Drawing.Point(6, 19);
            this.rbEnglish.Name = "rbEnglish";
            this.rbEnglish.Size = new System.Drawing.Size(59, 17);
            this.rbEnglish.TabIndex = 0;
            this.rbEnglish.TabStop = true;
            this.rbEnglish.Text = "English";
            this.rbEnglish.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(413, 115);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbLanguage);
            this.Name = "OptionsForm";
            this.Text = "OptionsForm";
            this.gbLanguage.ResumeLayout(false);
            this.gbLanguage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLanguage;
        private System.Windows.Forms.RadioButton rbPortuguese;
        private System.Windows.Forms.RadioButton rbEnglish;
        private System.Windows.Forms.Button btnSave;

    }
}