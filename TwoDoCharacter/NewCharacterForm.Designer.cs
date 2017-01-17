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
            this.TabCharacter = new System.Windows.Forms.TabControl();
            this.TabElements = new System.Windows.Forms.TabPage();
            this.cbStrongAttack = new System.Windows.Forms.ComboBox();
            this.cbBaseElement = new System.Windows.Forms.ComboBox();
            this.cbBaseAttack = new System.Windows.Forms.ComboBox();
            this.lblStrongAttack = new System.Windows.Forms.Label();
            this.gpResistances = new System.Windows.Forms.GroupBox();
            this.cbPoisonRes = new System.Windows.Forms.ComboBox();
            this.cbGhostRes = new System.Windows.Forms.ComboBox();
            this.cbDarkRes = new System.Windows.Forms.ComboBox();
            this.cbIceRes = new System.Windows.Forms.ComboBox();
            this.cbPsyRes = new System.Windows.Forms.ComboBox();
            this.cbLigthRes = new System.Windows.Forms.ComboBox();
            this.cbEarthRes = new System.Windows.Forms.ComboBox();
            this.cbNeutralRes = new System.Windows.Forms.ComboBox();
            this.cbThunderRes = new System.Windows.Forms.ComboBox();
            this.cbWaterRes = new System.Windows.Forms.ComboBox();
            this.cbWindRes = new System.Windows.Forms.ComboBox();
            this.cbFireRes = new System.Windows.Forms.ComboBox();
            this.pbPoison = new System.Windows.Forms.PictureBox();
            this.pbNeutral = new System.Windows.Forms.PictureBox();
            this.pbIce = new System.Windows.Forms.PictureBox();
            this.pbGhost = new System.Windows.Forms.PictureBox();
            this.pbPsych = new System.Windows.Forms.PictureBox();
            this.pbThunder = new System.Windows.Forms.PictureBox();
            this.pbDark = new System.Windows.Forms.PictureBox();
            this.pbLigth = new System.Windows.Forms.PictureBox();
            this.pbEarth = new System.Windows.Forms.PictureBox();
            this.pbWind = new System.Windows.Forms.PictureBox();
            this.pbWater = new System.Windows.Forms.PictureBox();
            this.pbFire = new System.Windows.Forms.PictureBox();
            this.lblElementType = new System.Windows.Forms.Label();
            this.lblBaseAtk = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picChar)).BeginInit();
            this.pnlAttributes.SuspendLayout();
            this.TabCharacter.SuspendLayout();
            this.TabElements.SuspendLayout();
            this.gpResistances.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoison)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNeutral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGhost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPsych)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThunder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLigth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEarth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWater)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFire)).BeginInit();
            this.SuspendLayout();
            // 
            // picChar
            // 
            this.picChar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picChar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            // TabCharacter
            // 
            this.TabCharacter.Controls.Add(this.TabElements);
            this.TabCharacter.Location = new System.Drawing.Point(5, 224);
            this.TabCharacter.Name = "TabCharacter";
            this.TabCharacter.SelectedIndex = 0;
            this.TabCharacter.Size = new System.Drawing.Size(483, 217);
            this.TabCharacter.TabIndex = 13;
            // 
            // TabElements
            // 
            this.TabElements.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.TabElements.Controls.Add(this.cbStrongAttack);
            this.TabElements.Controls.Add(this.cbBaseElement);
            this.TabElements.Controls.Add(this.cbBaseAttack);
            this.TabElements.Controls.Add(this.lblStrongAttack);
            this.TabElements.Controls.Add(this.gpResistances);
            this.TabElements.Controls.Add(this.lblElementType);
            this.TabElements.Controls.Add(this.lblBaseAtk);
            this.TabElements.Location = new System.Drawing.Point(4, 22);
            this.TabElements.Name = "TabElements";
            this.TabElements.Padding = new System.Windows.Forms.Padding(3);
            this.TabElements.Size = new System.Drawing.Size(475, 191);
            this.TabElements.TabIndex = 0;
            this.TabElements.Text = "Elements";
            // 
            // cbStrongAttack
            // 
            this.cbStrongAttack.FormattingEnabled = true;
            this.cbStrongAttack.Location = new System.Drawing.Point(9, 146);
            this.cbStrongAttack.Name = "cbStrongAttack";
            this.cbStrongAttack.Size = new System.Drawing.Size(79, 21);
            this.cbStrongAttack.TabIndex = 22;
            // 
            // cbBaseElement
            // 
            this.cbBaseElement.FormattingEnabled = true;
            this.cbBaseElement.Location = new System.Drawing.Point(9, 30);
            this.cbBaseElement.Name = "cbBaseElement";
            this.cbBaseElement.Size = new System.Drawing.Size(79, 21);
            this.cbBaseElement.TabIndex = 22;
            // 
            // cbBaseAttack
            // 
            this.cbBaseAttack.FormattingEnabled = true;
            this.cbBaseAttack.Location = new System.Drawing.Point(9, 85);
            this.cbBaseAttack.Name = "cbBaseAttack";
            this.cbBaseAttack.Size = new System.Drawing.Size(79, 21);
            this.cbBaseAttack.TabIndex = 22;
            // 
            // lblStrongAttack
            // 
            this.lblStrongAttack.AutoSize = true;
            this.lblStrongAttack.ForeColor = System.Drawing.Color.White;
            this.lblStrongAttack.Location = new System.Drawing.Point(6, 126);
            this.lblStrongAttack.Name = "lblStrongAttack";
            this.lblStrongAttack.Size = new System.Drawing.Size(72, 13);
            this.lblStrongAttack.TabIndex = 2;
            this.lblStrongAttack.Text = "Strong Attack";
            // 
            // gpResistances
            // 
            this.gpResistances.Controls.Add(this.cbPoisonRes);
            this.gpResistances.Controls.Add(this.cbGhostRes);
            this.gpResistances.Controls.Add(this.cbDarkRes);
            this.gpResistances.Controls.Add(this.cbIceRes);
            this.gpResistances.Controls.Add(this.cbPsyRes);
            this.gpResistances.Controls.Add(this.cbLigthRes);
            this.gpResistances.Controls.Add(this.cbEarthRes);
            this.gpResistances.Controls.Add(this.cbNeutralRes);
            this.gpResistances.Controls.Add(this.cbThunderRes);
            this.gpResistances.Controls.Add(this.cbWaterRes);
            this.gpResistances.Controls.Add(this.cbWindRes);
            this.gpResistances.Controls.Add(this.cbFireRes);
            this.gpResistances.Controls.Add(this.pbPoison);
            this.gpResistances.Controls.Add(this.pbNeutral);
            this.gpResistances.Controls.Add(this.pbIce);
            this.gpResistances.Controls.Add(this.pbGhost);
            this.gpResistances.Controls.Add(this.pbPsych);
            this.gpResistances.Controls.Add(this.pbThunder);
            this.gpResistances.Controls.Add(this.pbDark);
            this.gpResistances.Controls.Add(this.pbLigth);
            this.gpResistances.Controls.Add(this.pbEarth);
            this.gpResistances.Controls.Add(this.pbWind);
            this.gpResistances.Controls.Add(this.pbWater);
            this.gpResistances.Controls.Add(this.pbFire);
            this.gpResistances.ForeColor = System.Drawing.Color.White;
            this.gpResistances.Location = new System.Drawing.Point(108, 3);
            this.gpResistances.Name = "gpResistances";
            this.gpResistances.Size = new System.Drawing.Size(364, 178);
            this.gpResistances.TabIndex = 1;
            this.gpResistances.TabStop = false;
            this.gpResistances.Text = "Resistances";
            // 
            // cbPoisonRes
            // 
            this.cbPoisonRes.FormattingEnabled = true;
            this.cbPoisonRes.Location = new System.Drawing.Point(282, 142);
            this.cbPoisonRes.Name = "cbPoisonRes";
            this.cbPoisonRes.Size = new System.Drawing.Size(64, 21);
            this.cbPoisonRes.TabIndex = 23;
            // 
            // cbGhostRes
            // 
            this.cbGhostRes.FormattingEnabled = true;
            this.cbGhostRes.Location = new System.Drawing.Point(282, 103);
            this.cbGhostRes.Name = "cbGhostRes";
            this.cbGhostRes.Size = new System.Drawing.Size(64, 21);
            this.cbGhostRes.TabIndex = 23;
            // 
            // cbDarkRes
            // 
            this.cbDarkRes.FormattingEnabled = true;
            this.cbDarkRes.Location = new System.Drawing.Point(167, 142);
            this.cbDarkRes.Name = "cbDarkRes";
            this.cbDarkRes.Size = new System.Drawing.Size(64, 21);
            this.cbDarkRes.TabIndex = 23;
            // 
            // cbIceRes
            // 
            this.cbIceRes.FormattingEnabled = true;
            this.cbIceRes.Location = new System.Drawing.Point(167, 103);
            this.cbIceRes.Name = "cbIceRes";
            this.cbIceRes.Size = new System.Drawing.Size(64, 21);
            this.cbIceRes.TabIndex = 23;
            // 
            // cbPsyRes
            // 
            this.cbPsyRes.FormattingEnabled = true;
            this.cbPsyRes.Location = new System.Drawing.Point(282, 64);
            this.cbPsyRes.Name = "cbPsyRes";
            this.cbPsyRes.Size = new System.Drawing.Size(64, 21);
            this.cbPsyRes.TabIndex = 23;
            // 
            // cbLigthRes
            // 
            this.cbLigthRes.FormattingEnabled = true;
            this.cbLigthRes.Location = new System.Drawing.Point(53, 142);
            this.cbLigthRes.Name = "cbLigthRes";
            this.cbLigthRes.Size = new System.Drawing.Size(64, 21);
            this.cbLigthRes.TabIndex = 23;
            // 
            // cbEarthRes
            // 
            this.cbEarthRes.FormattingEnabled = true;
            this.cbEarthRes.Location = new System.Drawing.Point(167, 64);
            this.cbEarthRes.Name = "cbEarthRes";
            this.cbEarthRes.Size = new System.Drawing.Size(64, 21);
            this.cbEarthRes.TabIndex = 23;
            // 
            // cbNeutralRes
            // 
            this.cbNeutralRes.FormattingEnabled = true;
            this.cbNeutralRes.Location = new System.Drawing.Point(281, 24);
            this.cbNeutralRes.Name = "cbNeutralRes";
            this.cbNeutralRes.Size = new System.Drawing.Size(64, 21);
            this.cbNeutralRes.TabIndex = 23;
            // 
            // cbThunderRes
            // 
            this.cbThunderRes.FormattingEnabled = true;
            this.cbThunderRes.Location = new System.Drawing.Point(53, 103);
            this.cbThunderRes.Name = "cbThunderRes";
            this.cbThunderRes.Size = new System.Drawing.Size(64, 21);
            this.cbThunderRes.TabIndex = 23;
            // 
            // cbWaterRes
            // 
            this.cbWaterRes.FormattingEnabled = true;
            this.cbWaterRes.Location = new System.Drawing.Point(166, 24);
            this.cbWaterRes.Name = "cbWaterRes";
            this.cbWaterRes.Size = new System.Drawing.Size(64, 21);
            this.cbWaterRes.TabIndex = 23;
            // 
            // cbWindRes
            // 
            this.cbWindRes.FormattingEnabled = true;
            this.cbWindRes.Location = new System.Drawing.Point(53, 64);
            this.cbWindRes.Name = "cbWindRes";
            this.cbWindRes.Size = new System.Drawing.Size(64, 21);
            this.cbWindRes.TabIndex = 23;
            // 
            // cbFireRes
            // 
            this.cbFireRes.FormattingEnabled = true;
            this.cbFireRes.Location = new System.Drawing.Point(52, 24);
            this.cbFireRes.Name = "cbFireRes";
            this.cbFireRes.Size = new System.Drawing.Size(64, 21);
            this.cbFireRes.TabIndex = 23;
            // 
            // pbPoison
            // 
            this.pbPoison.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPoison.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPoison.Location = new System.Drawing.Point(244, 136);
            this.pbPoison.Name = "pbPoison";
            this.pbPoison.Size = new System.Drawing.Size(32, 33);
            this.pbPoison.TabIndex = 21;
            this.pbPoison.TabStop = false;
            // 
            // pbNeutral
            // 
            this.pbNeutral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbNeutral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbNeutral.Location = new System.Drawing.Point(244, 19);
            this.pbNeutral.Name = "pbNeutral";
            this.pbNeutral.Size = new System.Drawing.Size(32, 33);
            this.pbNeutral.TabIndex = 20;
            this.pbNeutral.TabStop = false;
            // 
            // pbIce
            // 
            this.pbIce.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbIce.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbIce.Location = new System.Drawing.Point(129, 97);
            this.pbIce.Name = "pbIce";
            this.pbIce.Size = new System.Drawing.Size(32, 33);
            this.pbIce.TabIndex = 19;
            this.pbIce.TabStop = false;
            // 
            // pbGhost
            // 
            this.pbGhost.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbGhost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbGhost.Location = new System.Drawing.Point(244, 97);
            this.pbGhost.Name = "pbGhost";
            this.pbGhost.Size = new System.Drawing.Size(32, 33);
            this.pbGhost.TabIndex = 18;
            this.pbGhost.TabStop = false;
            // 
            // pbPsych
            // 
            this.pbPsych.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPsych.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPsych.Location = new System.Drawing.Point(244, 58);
            this.pbPsych.Name = "pbPsych";
            this.pbPsych.Size = new System.Drawing.Size(32, 33);
            this.pbPsych.TabIndex = 17;
            this.pbPsych.TabStop = false;
            // 
            // pbThunder
            // 
            this.pbThunder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbThunder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbThunder.Location = new System.Drawing.Point(15, 97);
            this.pbThunder.Name = "pbThunder";
            this.pbThunder.Size = new System.Drawing.Size(32, 33);
            this.pbThunder.TabIndex = 16;
            this.pbThunder.TabStop = false;
            // 
            // pbDark
            // 
            this.pbDark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbDark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDark.Location = new System.Drawing.Point(129, 136);
            this.pbDark.Name = "pbDark";
            this.pbDark.Size = new System.Drawing.Size(32, 33);
            this.pbDark.TabIndex = 15;
            this.pbDark.TabStop = false;
            // 
            // pbLigth
            // 
            this.pbLigth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLigth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbLigth.Location = new System.Drawing.Point(15, 136);
            this.pbLigth.Name = "pbLigth";
            this.pbLigth.Size = new System.Drawing.Size(32, 33);
            this.pbLigth.TabIndex = 14;
            this.pbLigth.TabStop = false;
            // 
            // pbEarth
            // 
            this.pbEarth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbEarth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbEarth.Location = new System.Drawing.Point(129, 58);
            this.pbEarth.Name = "pbEarth";
            this.pbEarth.Size = new System.Drawing.Size(32, 33);
            this.pbEarth.TabIndex = 13;
            this.pbEarth.TabStop = false;
            // 
            // pbWind
            // 
            this.pbWind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbWind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbWind.Location = new System.Drawing.Point(15, 58);
            this.pbWind.Name = "pbWind";
            this.pbWind.Size = new System.Drawing.Size(32, 33);
            this.pbWind.TabIndex = 12;
            this.pbWind.TabStop = false;
            // 
            // pbWater
            // 
            this.pbWater.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbWater.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbWater.Location = new System.Drawing.Point(129, 19);
            this.pbWater.Name = "pbWater";
            this.pbWater.Size = new System.Drawing.Size(32, 33);
            this.pbWater.TabIndex = 11;
            this.pbWater.TabStop = false;
            // 
            // pbFire
            // 
            this.pbFire.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbFire.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFire.Location = new System.Drawing.Point(14, 19);
            this.pbFire.Name = "pbFire";
            this.pbFire.Size = new System.Drawing.Size(32, 33);
            this.pbFire.TabIndex = 10;
            this.pbFire.TabStop = false;
            // 
            // lblElementType
            // 
            this.lblElementType.AutoSize = true;
            this.lblElementType.ForeColor = System.Drawing.Color.White;
            this.lblElementType.Location = new System.Drawing.Point(6, 11);
            this.lblElementType.Name = "lblElementType";
            this.lblElementType.Size = new System.Drawing.Size(45, 13);
            this.lblElementType.TabIndex = 0;
            this.lblElementType.Text = "Element";
            // 
            // lblBaseAtk
            // 
            this.lblBaseAtk.AutoSize = true;
            this.lblBaseAtk.ForeColor = System.Drawing.Color.White;
            this.lblBaseAtk.Location = new System.Drawing.Point(6, 66);
            this.lblBaseAtk.Name = "lblBaseAtk";
            this.lblBaseAtk.Size = new System.Drawing.Size(65, 13);
            this.lblBaseAtk.TabIndex = 0;
            this.lblBaseAtk.Text = "Base Attack";
            // 
            // NewCharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.TabCharacter);
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
            this.TabCharacter.ResumeLayout(false);
            this.TabElements.ResumeLayout(false);
            this.TabElements.PerformLayout();
            this.gpResistances.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPoison)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNeutral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGhost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPsych)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThunder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLigth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEarth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWater)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFire)).EndInit();
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
        private System.Windows.Forms.TabControl TabCharacter;
        private System.Windows.Forms.TabPage TabElements;
        private System.Windows.Forms.Label lblBaseAtk;
        private System.Windows.Forms.Label lblStrongAttack;
        private System.Windows.Forms.GroupBox gpResistances;
        private System.Windows.Forms.PictureBox pbPoison;
        private System.Windows.Forms.PictureBox pbNeutral;
        private System.Windows.Forms.PictureBox pbIce;
        private System.Windows.Forms.PictureBox pbGhost;
        private System.Windows.Forms.PictureBox pbPsych;
        private System.Windows.Forms.PictureBox pbThunder;
        private System.Windows.Forms.PictureBox pbDark;
        private System.Windows.Forms.PictureBox pbLigth;
        private System.Windows.Forms.PictureBox pbEarth;
        private System.Windows.Forms.PictureBox pbWind;
        private System.Windows.Forms.PictureBox pbWater;
        private System.Windows.Forms.PictureBox pbFire;
        private System.Windows.Forms.ComboBox cbStrongAttack;
        private System.Windows.Forms.ComboBox cbBaseAttack;
        private System.Windows.Forms.ComboBox cbPoisonRes;
        private System.Windows.Forms.ComboBox cbGhostRes;
        private System.Windows.Forms.ComboBox cbDarkRes;
        private System.Windows.Forms.ComboBox cbIceRes;
        private System.Windows.Forms.ComboBox cbPsyRes;
        private System.Windows.Forms.ComboBox cbLigthRes;
        private System.Windows.Forms.ComboBox cbEarthRes;
        private System.Windows.Forms.ComboBox cbNeutralRes;
        private System.Windows.Forms.ComboBox cbThunderRes;
        private System.Windows.Forms.ComboBox cbWaterRes;
        private System.Windows.Forms.ComboBox cbWindRes;
        private System.Windows.Forms.ComboBox cbFireRes;
        private System.Windows.Forms.ComboBox cbBaseElement;
        private System.Windows.Forms.Label lblElementType;

    }
}