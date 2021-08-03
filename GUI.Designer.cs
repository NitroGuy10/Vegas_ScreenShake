
namespace ScreenShake
{
    partial class GUI
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
            this.applyBtn = new System.Windows.Forms.Button();
            this.defaultSettingsBtn = new System.Windows.Forms.Button();
            this.seedBox = new System.Windows.Forms.TextBox();
            this.seedLabel = new System.Windows.Forms.Label();
            this.randomSeedLabel = new System.Windows.Forms.Label();
            this.rotationSpeedLabel = new System.Windows.Forms.Label();
            this.rotationIntensityLabel = new System.Windows.Forms.Label();
            this.shakeSpeedLabel = new System.Windows.Forms.Label();
            this.shakeIntensityLabel = new System.Windows.Forms.Label();
            this.shakeSpeedSlider = new System.Windows.Forms.TrackBar();
            this.shakeSpeedTextBox = new System.Windows.Forms.TextBox();
            this.shakeIntensitySlider = new System.Windows.Forms.TrackBar();
            this.shakeIntensityTextBox = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.shakeSpeedSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shakeIntensitySlider)).BeginInit();
            this.SuspendLayout();
            // 
            // applyBtn
            // 
            this.applyBtn.Location = new System.Drawing.Point(12, 363);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(395, 53);
            this.applyBtn.TabIndex = 0;
            this.applyBtn.Text = "Apply";
            this.applyBtn.UseVisualStyleBackColor = true;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // defaultSettingsBtn
            // 
            this.defaultSettingsBtn.Location = new System.Drawing.Point(12, 12);
            this.defaultSettingsBtn.Name = "defaultSettingsBtn";
            this.defaultSettingsBtn.Size = new System.Drawing.Size(144, 42);
            this.defaultSettingsBtn.TabIndex = 1;
            this.defaultSettingsBtn.Text = "Use Default Settings";
            this.defaultSettingsBtn.UseVisualStyleBackColor = true;
            this.defaultSettingsBtn.Click += new System.EventHandler(this.defaultSettingsBtn_Click);
            // 
            // seedBox
            // 
            this.seedBox.Location = new System.Drawing.Point(101, 69);
            this.seedBox.Name = "seedBox";
            this.seedBox.Size = new System.Drawing.Size(187, 20);
            this.seedBox.TabIndex = 2;
            this.seedBox.Text = "0";
            // 
            // seedLabel
            // 
            this.seedLabel.AutoSize = true;
            this.seedLabel.Location = new System.Drawing.Point(63, 72);
            this.seedLabel.Name = "seedLabel";
            this.seedLabel.Size = new System.Drawing.Size(32, 13);
            this.seedLabel.TabIndex = 3;
            this.seedLabel.Text = "Seed";
            // 
            // randomSeedLabel
            // 
            this.randomSeedLabel.AutoSize = true;
            this.randomSeedLabel.Location = new System.Drawing.Point(294, 72);
            this.randomSeedLabel.Name = "randomSeedLabel";
            this.randomSeedLabel.Size = new System.Drawing.Size(92, 13);
            this.randomSeedLabel.TabIndex = 4;
            this.randomSeedLabel.Text = "0 for random seed";
            // 
            // rotationSpeedLabel
            // 
            this.rotationSpeedLabel.AutoSize = true;
            this.rotationSpeedLabel.Location = new System.Drawing.Point(14, 133);
            this.rotationSpeedLabel.Name = "rotationSpeedLabel";
            this.rotationSpeedLabel.Size = new System.Drawing.Size(81, 13);
            this.rotationSpeedLabel.TabIndex = 5;
            this.rotationSpeedLabel.Text = "Rotation Speed";
            // 
            // rotationIntensityLabel
            // 
            this.rotationIntensityLabel.AutoSize = true;
            this.rotationIntensityLabel.Location = new System.Drawing.Point(6, 164);
            this.rotationIntensityLabel.Name = "rotationIntensityLabel";
            this.rotationIntensityLabel.Size = new System.Drawing.Size(89, 13);
            this.rotationIntensityLabel.TabIndex = 6;
            this.rotationIntensityLabel.Text = "Rotation Intensity";
            // 
            // shakeSpeedLabel
            // 
            this.shakeSpeedLabel.AutoSize = true;
            this.shakeSpeedLabel.Location = new System.Drawing.Point(23, 209);
            this.shakeSpeedLabel.Name = "shakeSpeedLabel";
            this.shakeSpeedLabel.Size = new System.Drawing.Size(72, 13);
            this.shakeSpeedLabel.TabIndex = 7;
            this.shakeSpeedLabel.Text = "Shake Speed";
            // 
            // shakeIntensityLabel
            // 
            this.shakeIntensityLabel.AutoSize = true;
            this.shakeIntensityLabel.Location = new System.Drawing.Point(15, 241);
            this.shakeIntensityLabel.Name = "shakeIntensityLabel";
            this.shakeIntensityLabel.Size = new System.Drawing.Size(80, 13);
            this.shakeIntensityLabel.TabIndex = 8;
            this.shakeIntensityLabel.Text = "Shake Intensity";
            // 
            // shakeSpeedSlider
            // 
            this.shakeSpeedSlider.Location = new System.Drawing.Point(101, 209);
            this.shakeSpeedSlider.Maximum = 600;
            this.shakeSpeedSlider.Minimum = 6;
            this.shakeSpeedSlider.Name = "shakeSpeedSlider";
            this.shakeSpeedSlider.Size = new System.Drawing.Size(187, 45);
            this.shakeSpeedSlider.TabIndex = 9;
            this.shakeSpeedSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.shakeSpeedSlider.Value = 6;
            this.shakeSpeedSlider.Scroll += new System.EventHandler(this.shakeSpeedSlider_Scroll);
            // 
            // shakeSpeedTextBox
            // 
            this.shakeSpeedTextBox.Location = new System.Drawing.Point(294, 209);
            this.shakeSpeedTextBox.Name = "shakeSpeedTextBox";
            this.shakeSpeedTextBox.Size = new System.Drawing.Size(100, 20);
            this.shakeSpeedTextBox.TabIndex = 10;
            this.shakeSpeedTextBox.Text = "8";
            this.shakeSpeedTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.shakeSpeedTextBox_KeyDown);
            // 
            // shakeIntensitySlider
            // 
            this.shakeIntensitySlider.Location = new System.Drawing.Point(101, 241);
            this.shakeIntensitySlider.Maximum = 100;
            this.shakeIntensitySlider.Minimum = 1;
            this.shakeIntensitySlider.Name = "shakeIntensitySlider";
            this.shakeIntensitySlider.Size = new System.Drawing.Size(187, 45);
            this.shakeIntensitySlider.TabIndex = 13;
            this.shakeIntensitySlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.shakeIntensitySlider.Value = 5;
            this.shakeIntensitySlider.Scroll += new System.EventHandler(this.shakeIntensitySlider_Scroll);
            // 
            // shakeIntensityTextBox
            // 
            this.shakeIntensityTextBox.Location = new System.Drawing.Point(294, 241);
            this.shakeIntensityTextBox.Name = "shakeIntensityTextBox";
            this.shakeIntensityTextBox.Size = new System.Drawing.Size(100, 20);
            this.shakeIntensityTextBox.TabIndex = 14;
            this.shakeIntensityTextBox.Text = "0.2";
            this.shakeIntensityTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.shakeIntensityTextBox_KeyDown);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(51, 326);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(33, 17);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "X";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(90, 326);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(33, 17);
            this.checkBox2.TabIndex = 17;
            this.checkBox2.Text = "Y";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point(129, 326);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(66, 17);
            this.checkBox3.TabIndex = 18;
            this.checkBox3.Text = "Rotation";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 428);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.shakeIntensityTextBox);
            this.Controls.Add(this.shakeIntensitySlider);
            this.Controls.Add(this.shakeSpeedTextBox);
            this.Controls.Add(this.shakeSpeedSlider);
            this.Controls.Add(this.shakeIntensityLabel);
            this.Controls.Add(this.shakeSpeedLabel);
            this.Controls.Add(this.rotationIntensityLabel);
            this.Controls.Add(this.rotationSpeedLabel);
            this.Controls.Add(this.randomSeedLabel);
            this.Controls.Add(this.seedLabel);
            this.Controls.Add(this.seedBox);
            this.Controls.Add(this.defaultSettingsBtn);
            this.Controls.Add(this.applyBtn);
            this.Name = "GUI";
            this.Text = "NitroGuy\'s ScreenShake";
            ((System.ComponentModel.ISupportInitialize)(this.shakeSpeedSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shakeIntensitySlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button applyBtn;
        private System.Windows.Forms.Button defaultSettingsBtn;
        private System.Windows.Forms.TextBox seedBox;
        private System.Windows.Forms.Label seedLabel;
        private System.Windows.Forms.Label randomSeedLabel;
        private System.Windows.Forms.Label rotationSpeedLabel;
        private System.Windows.Forms.Label rotationIntensityLabel;
        private System.Windows.Forms.Label shakeSpeedLabel;
        private System.Windows.Forms.Label shakeIntensityLabel;
        private System.Windows.Forms.TrackBar shakeSpeedSlider;
        private System.Windows.Forms.TextBox shakeSpeedTextBox;
        private System.Windows.Forms.TrackBar shakeIntensitySlider;
        private System.Windows.Forms.TextBox shakeIntensityTextBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
    }
}

