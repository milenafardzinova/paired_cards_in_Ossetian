namespace project_paired_cards_in_Ossetian
{
    partial class FormLevelSelect
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
            this.buttonEasyLevel = new System.Windows.Forms.Button();
            this.buttonMiddleLevel = new System.Windows.Forms.Button();
            this.buttonDifficult = new System.Windows.Forms.Button();
            this.labelLevelSelect = new System.Windows.Forms.Label();
            this.pictureBoxBackground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEasyLevel
            // 
            this.buttonEasyLevel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEasyLevel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonEasyLevel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEasyLevel.Location = new System.Drawing.Point(406, 147);
            this.buttonEasyLevel.Name = "buttonEasyLevel";
            this.buttonEasyLevel.Size = new System.Drawing.Size(271, 55);
            this.buttonEasyLevel.TabIndex = 10;
            this.buttonEasyLevel.Text = "Легкий / Æнцон";
            this.buttonEasyLevel.UseVisualStyleBackColor = false;
            this.buttonEasyLevel.Click += new System.EventHandler(this.LevelSelectBotton_Click);
            // 
            // buttonMiddleLevel
            // 
            this.buttonMiddleLevel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonMiddleLevel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonMiddleLevel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMiddleLevel.Location = new System.Drawing.Point(406, 248);
            this.buttonMiddleLevel.Name = "buttonMiddleLevel";
            this.buttonMiddleLevel.Size = new System.Drawing.Size(271, 55);
            this.buttonMiddleLevel.TabIndex = 11;
            this.buttonMiddleLevel.Text = "Средний / Астӕуккаг";
            this.buttonMiddleLevel.UseVisualStyleBackColor = false;
            this.buttonMiddleLevel.Click += new System.EventHandler(this.LevelSelectBotton_Click);
            // 
            // buttonDifficult
            // 
            this.buttonDifficult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDifficult.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonDifficult.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDifficult.Location = new System.Drawing.Point(406, 351);
            this.buttonDifficult.Name = "buttonDifficult";
            this.buttonDifficult.Size = new System.Drawing.Size(271, 55);
            this.buttonDifficult.TabIndex = 12;
            this.buttonDifficult.Text = "Сложный / Зын";
            this.buttonDifficult.UseVisualStyleBackColor = false;
            this.buttonDifficult.Click += new System.EventHandler(this.LevelSelectBotton_Click);
            // 
            // labelLevelSelect
            // 
            this.labelLevelSelect.AutoSize = true;
            this.labelLevelSelect.BackColor = System.Drawing.Color.Transparent;
            this.labelLevelSelect.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLevelSelect.ForeColor = System.Drawing.Color.Black;
            this.labelLevelSelect.Location = new System.Drawing.Point(343, 79);
            this.labelLevelSelect.Name = "labelLevelSelect";
            this.labelLevelSelect.Size = new System.Drawing.Size(436, 26);
            this.labelLevelSelect.TabIndex = 13;
            this.labelLevelSelect.Text = "Уровень сложности / Зындзинады ӕмвӕзад";
            // 
            // pictureBoxBackground
            // 
            this.pictureBoxBackground.BackgroundImage = global::project_paired_cards_in_Ossetian.Properties.Resources.lake;
            this.pictureBoxBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxBackground.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxBackground.Name = "pictureBoxBackground";
            this.pictureBoxBackground.Size = new System.Drawing.Size(1089, 631);
            this.pictureBoxBackground.TabIndex = 8;
            this.pictureBoxBackground.TabStop = false;
            // 
            // FormLevelSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 631);
            this.Controls.Add(this.labelLevelSelect);
            this.Controls.Add(this.buttonDifficult);
            this.Controls.Add(this.buttonMiddleLevel);
            this.Controls.Add(this.buttonEasyLevel);
            this.Controls.Add(this.pictureBoxBackground);
            this.Name = "FormLevelSelect";
            this.Text = "FormLevelSelect";
            this.Load += new System.EventHandler(this.FormLevelSelect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBackground;
        private System.Windows.Forms.Button buttonEasyLevel;
        private System.Windows.Forms.Button buttonMiddleLevel;
        private System.Windows.Forms.Button buttonDifficult;
        private System.Windows.Forms.Label labelLevelSelect;
    }
}