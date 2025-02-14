namespace NBTExplorer.Windows
{
    partial class SaveDialogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveDialogForm));
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LittleEndianButton = new System.Windows.Forms.RadioButton();
            this.BigEndianButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EntityButton = new System.Windows.Forms.RadioButton();
            this.LevelButton = new System.Windows.Forms.RadioButton();
            this.NoneButton = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Location = new System.Drawing.Point(95, 66);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.Location = new System.Drawing.Point(176, 66);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Endianness";
            // 
            // LittleEndianButton
            // 
            this.LittleEndianButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LittleEndianButton.AutoSize = true;
            this.LittleEndianButton.Location = new System.Drawing.Point(166, 11);
            this.LittleEndianButton.Name = "LittleEndianButton";
            this.LittleEndianButton.Size = new System.Drawing.Size(83, 17);
            this.LittleEndianButton.TabIndex = 3;
            this.LittleEndianButton.TabStop = true;
            this.LittleEndianButton.Text = "Little Endian";
            this.LittleEndianButton.UseVisualStyleBackColor = true;
            this.LittleEndianButton.CheckedChanged += new System.EventHandler(this.LittleEndianButton_CheckedChanged);
            // 
            // BigEndianButton
            // 
            this.BigEndianButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BigEndianButton.AutoSize = true;
            this.BigEndianButton.Location = new System.Drawing.Point(84, 11);
            this.BigEndianButton.Name = "BigEndianButton";
            this.BigEndianButton.Size = new System.Drawing.Size(76, 17);
            this.BigEndianButton.TabIndex = 4;
            this.BigEndianButton.TabStop = true;
            this.BigEndianButton.Text = "Big Endian";
            this.BigEndianButton.UseVisualStyleBackColor = true;
            this.BigEndianButton.CheckedChanged += new System.EventHandler(this.BigEndianButton_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Header";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.NoneButton);
            this.panel1.Controls.Add(this.LevelButton);
            this.panel1.Controls.Add(this.EntityButton);
            this.panel1.Location = new System.Drawing.Point(79, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 24);
            this.panel1.TabIndex = 6;
            // 
            // EntityButton
            // 
            this.EntityButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EntityButton.AutoSize = true;
            this.EntityButton.Location = new System.Drawing.Point(115, 4);
            this.EntityButton.Name = "EntityButton";
            this.EntityButton.Size = new System.Drawing.Size(51, 17);
            this.EntityButton.TabIndex = 0;
            this.EntityButton.TabStop = true;
            this.EntityButton.Text = "Entity";
            this.EntityButton.UseVisualStyleBackColor = true;
            this.EntityButton.CheckedChanged += new System.EventHandler(this.EntityButton_CheckedChanged);
            // 
            // LevelButton
            // 
            this.LevelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LevelButton.AutoSize = true;
            this.LevelButton.Location = new System.Drawing.Point(58, 4);
            this.LevelButton.Name = "LevelButton";
            this.LevelButton.Size = new System.Drawing.Size(51, 17);
            this.LevelButton.TabIndex = 1;
            this.LevelButton.TabStop = true;
            this.LevelButton.Text = "Level";
            this.LevelButton.UseVisualStyleBackColor = true;
            this.LevelButton.CheckedChanged += new System.EventHandler(this.LevelButton_CheckedChanged);
            // 
            // NoneButton
            // 
            this.NoneButton.AutoSize = true;
            this.NoneButton.Location = new System.Drawing.Point(3, 4);
            this.NoneButton.Name = "NoneButton";
            this.NoneButton.Size = new System.Drawing.Size(51, 17);
            this.NoneButton.TabIndex = 2;
            this.NoneButton.TabStop = true;
            this.NoneButton.Text = "None";
            this.NoneButton.UseVisualStyleBackColor = true;
            this.NoneButton.CheckedChanged += new System.EventHandler(this.NoneButton_CheckedChanged);
            // 
            // SaveDialogForm
            // 
            this.AcceptButton = this.SaveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 101);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BigEndianButton);
            this.Controls.Add(this.LittleEndianButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(279, 140);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(279, 140);
            this.Name = "SaveDialogForm";
            this.ShowInTaskbar = false;
            this.Text = "Select save format";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SaveDialogForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton LittleEndianButton;
        private System.Windows.Forms.RadioButton BigEndianButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton NoneButton;
        private System.Windows.Forms.RadioButton LevelButton;
        private System.Windows.Forms.RadioButton EntityButton;
    }
}