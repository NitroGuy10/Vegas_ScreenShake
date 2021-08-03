
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.shakeSpeedSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // applyBtn
            // 
            this.applyBtn.Location = new System.Drawing.Point(217, 350);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(190, 66);
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
            this.shakeIntensityLabel.Location = new System.Drawing.Point(15, 257);
            this.shakeIntensityLabel.Name = "shakeIntensityLabel";
            this.shakeIntensityLabel.Size = new System.Drawing.Size(80, 13);
            this.shakeIntensityLabel.TabIndex = 8;
            this.shakeIntensityLabel.Text = "Shake Intensity";
            // 
            // shakeSpeedSlider
            // 
            this.shakeSpeedSlider.Location = new System.Drawing.Point(101, 209);
            this.shakeSpeedSlider.Maximum = 60;
            this.shakeSpeedSlider.Minimum = 6;
            this.shakeSpeedSlider.Name = "shakeSpeedSlider";
            this.shakeSpeedSlider.Size = new System.Drawing.Size(187, 45);
            this.shakeSpeedSlider.TabIndex = 9;
            this.shakeSpeedSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.shakeSpeedSlider.Value = 6;
            this.shakeSpeedSlider.Scroll += new System.EventHandler(this.shakeSpeedSlider_Scroll);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(295, 209);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 428);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
    }
}

