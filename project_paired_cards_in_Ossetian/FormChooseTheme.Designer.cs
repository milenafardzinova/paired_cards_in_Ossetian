namespace project_paired_cards_in_Ossetian
{
    partial class FormChooseTheme
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonAnimals = new System.Windows.Forms.Button();
            this.buttonFood = new System.Windows.Forms.Button();
            this.labelThemeTitle = new System.Windows.Forms.Label();
            this.pictureBoxBackground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBoxName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(773, 76);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(261, 30);
            this.textBoxName.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(769, 33);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(175, 22);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Ваше имя / Дæ ном";
            // 
            // buttonAnimals
            // 
            this.buttonAnimals.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAnimals.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonAnimals.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAnimals.Location = new System.Drawing.Point(404, 295);
            this.buttonAnimals.Name = "buttonAnimals";
            this.buttonAnimals.Size = new System.Drawing.Size(271, 55);
            this.buttonAnimals.TabIndex = 4;
            this.buttonAnimals.Text = "Животные / Цæрæгойтæ";
            this.buttonAnimals.UseVisualStyleBackColor = false;
            this.buttonAnimals.Click += new System.EventHandler(this.ThemeButton_Click);
            // 
            // buttonFood
            // 
            this.buttonFood.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonFood.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonFood.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFood.Location = new System.Drawing.Point(404, 370);
            this.buttonFood.Name = "buttonFood";
            this.buttonFood.Size = new System.Drawing.Size(271, 55);
            this.buttonFood.TabIndex = 5;
            this.buttonFood.Text = "Еда / Хæринаг";
            this.buttonFood.UseMnemonic = false;
            this.buttonFood.UseVisualStyleBackColor = false;
            this.buttonFood.Click += new System.EventHandler(this.ThemeButton_Click);
            // 
            // labelThemeTitle
            // 
            this.labelThemeTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelThemeTitle.AutoSize = true;
            this.labelThemeTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelThemeTitle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelThemeTitle.Location = new System.Drawing.Point(400, 259);
            this.labelThemeTitle.Name = "labelThemeTitle";
            this.labelThemeTitle.Size = new System.Drawing.Size(261, 22);
            this.labelThemeTitle.TabIndex = 6;
            this.labelThemeTitle.Text = "Выберите тему / Темæ равзар";
            // 
            // pictureBoxBackground
            // 
            this.pictureBoxBackground.BackgroundImage = global::project_paired_cards_in_Ossetian.Properties.Resources.wastirji;
            this.pictureBoxBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxBackground.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxBackground.Name = "pictureBoxBackground";
            this.pictureBoxBackground.Size = new System.Drawing.Size(1089, 650);
            this.pictureBoxBackground.TabIndex = 7;
            this.pictureBoxBackground.TabStop = false;
            // 
            // FormChooseTheme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1089, 650);
            this.Controls.Add(this.labelThemeTitle);
            this.Controls.Add(this.buttonFood);
            this.Controls.Add(this.buttonAnimals);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.pictureBoxBackground);
            this.Name = "FormChooseTheme";
            this.Text = "Выбор темы / Темæ æвзарын";
            this.Load += new System.EventHandler(this.FormChooseTheme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonAnimals;
        private System.Windows.Forms.Button buttonFood;
        private System.Windows.Forms.Label labelThemeTitle;
        private System.Windows.Forms.PictureBox pictureBoxBackground;
    }
}

