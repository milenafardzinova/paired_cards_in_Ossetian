namespace project_paired_cards_in_Ossetian
{
    partial class FormGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
            this.dataGridViewField = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.buttonSoundSwitch = new System.Windows.Forms.Button();
            this.pictureBoxBackground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewField
            // 
            this.dataGridViewField.AllowUserToAddRows = false;
            this.dataGridViewField.AllowUserToDeleteRows = false;
            this.dataGridViewField.AllowUserToResizeColumns = false;
            this.dataGridViewField.AllowUserToResizeRows = false;
            this.dataGridViewField.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridViewField.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewField.ColumnHeadersVisible = false;
            this.dataGridViewField.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridViewField.Location = new System.Drawing.Point(12, 65);
            this.dataGridViewField.MultiSelect = false;
            this.dataGridViewField.Name = "dataGridViewField";
            this.dataGridViewField.ReadOnly = true;
            this.dataGridViewField.RowHeadersVisible = false;
            this.dataGridViewField.RowHeadersWidth = 51;
            this.dataGridViewField.RowTemplate.Height = 24;
            this.dataGridViewField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewField.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewField.Size = new System.Drawing.Size(543, 554);
            this.dataGridViewField.TabIndex = 10;
            this.dataGridViewField.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewField_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 105;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 105;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 105;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 105;
            // 
            // buttonSoundSwitch
            // 
            this.buttonSoundSwitch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSoundSwitch.BackgroundImage = global::project_paired_cards_in_Ossetian.Properties.Resources.soundOn;
            this.buttonSoundSwitch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSoundSwitch.Location = new System.Drawing.Point(762, 12);
            this.buttonSoundSwitch.Name = "buttonSoundSwitch";
            this.buttonSoundSwitch.Size = new System.Drawing.Size(70, 70);
            this.buttonSoundSwitch.TabIndex = 11;
            this.buttonSoundSwitch.UseVisualStyleBackColor = true;
            this.buttonSoundSwitch.Click += new System.EventHandler(this.buttonSoundSwitch_Click);
            // 
            // pictureBoxBackground
            // 
            this.pictureBoxBackground.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxBackground.BackgroundImage")));
            this.pictureBoxBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxBackground.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxBackground.Name = "pictureBoxBackground";
            this.pictureBoxBackground.Size = new System.Drawing.Size(1101, 631);
            this.pictureBoxBackground.TabIndex = 12;
            this.pictureBoxBackground.TabStop = false;
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 631);
            this.Controls.Add(this.buttonSoundSwitch);
            this.Controls.Add(this.dataGridViewField);
            this.Controls.Add(this.pictureBoxBackground);
            this.Name = "FormGame";
            this.Text = "FormGame";
            this.Load += new System.EventHandler(this.FormGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewField;
        private System.Windows.Forms.Button buttonSoundSwitch;
        private System.Windows.Forms.PictureBox pictureBoxBackground;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
        private System.Windows.Forms.DataGridViewImageColumn Column3;
        private System.Windows.Forms.DataGridViewImageColumn Column4;
    }
}