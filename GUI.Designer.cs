
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
            this.xCheckBox = new System.Windows.Forms.CheckBox();
            this.yCheckBox = new System.Windows.Forms.CheckBox();
            this.rotationIntensitySlider = new System.Windows.Forms.TrackBar();
            this.rotationSpeedSlider = new System.Windows.Forms.TrackBar();
            this.rotationIntensityTextBox = new System.Windows.Forms.TextBox();
            this.rotationSpeedTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.shakeSpeedSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shakeIntensitySlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationIntensitySlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationSpeedSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // applyBtn
            // 
            this.applyBtn.Location = new System.Drawing.Point(9, 329);
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
            this.rotationSpeedLabel.Location = new System.Drawing.Point(14, 126);
            this.rotationSpeedLabel.Name = "rotationSpeedLabel";
            this.rotationSpeedLabel.Size = new System.Drawing.Size(81, 13);
            this.rotationSpeedLabel.TabIndex = 5;
            this.rotationSpeedLabel.Text = "Rotation Speed";
            // 
            // rotationIntensityLabel
            // 
            this.rotationIntensityLabel.AutoSize = true;
            this.rotationIntensityLabel.Location = new System.Drawing.Point(6, 158);
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
            // xCheckBox
            // 
            this.xCheckBox.AutoSize = true;
            this.xCheckBox.Checked = true;
            this.xCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.xCheckBox.Location = new System.Drawing.Point(177, 278);
            this.xCheckBox.Name = "xCheckBox";
            this.xCheckBox.Size = new System.Drawing.Size(33, 17);
            this.xCheckBox.TabIndex = 16;
            this.xCheckBox.Text = "X";
            this.xCheckBox.UseVisualStyleBackColor = true;
            // 
            // yCheckBox
            // 
            this.yCheckBox.AutoSize = true;
            this.yCheckBox.Checked = true;
            this.yCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.yCheckBox.Location = new System.Drawing.Point(216, 278);
            this.yCheckBox.Name = "yCheckBox";
            this.yCheckBox.Size = new System.Drawing.Size(33, 17);
            this.yCheckBox.TabIndex = 17;
            this.yCheckBox.Text = "Y";
            this.yCheckBox.UseVisualStyleBackColor = true;
            // 
            // rotationIntensitySlider
            // 
            this.rotationIntensitySlider.Location = new System.Drawing.Point(101, 158);
            this.rotationIntensitySlider.Maximum = 300;
            this.rotationIntensitySlider.Name = "rotationIntensitySlider";
            this.rotationIntensitySlider.Size = new System.Drawing.Size(187, 45);
            this.rotationIntensitySlider.TabIndex = 19;
            this.rotationIntensitySlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.rotationIntensitySlider.Value = 10;
            this.rotationIntensitySlider.Scroll += new System.EventHandler(this.rotationIntensitySlider_Scroll);
            // 
            // rotationSpeedSlider
            // 
            this.rotationSpeedSlider.Location = new System.Drawing.Point(101, 126);
            this.rotationSpeedSlider.Maximum = 70;
            this.rotationSpeedSlider.Minimum = 1;
            this.rotationSpeedSlider.Name = "rotationSpeedSlider";
            this.rotationSpeedSlider.Size = new System.Drawing.Size(187, 45);
            this.rotationSpeedSlider.TabIndex = 20;
            this.rotationSpeedSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.rotationSpeedSlider.Value = 15;
            this.rotationSpeedSlider.Scroll += new System.EventHandler(this.rotationSpeedSlider_Scroll);
            // 
            // rotationIntensityTextBox
            // 
            this.rotationIntensityTextBox.Location = new System.Drawing.Point(294, 158);
            this.rotationIntensityTextBox.Name = "rotationIntensityTextBox";
            this.rotationIntensityTextBox.Size = new System.Drawing.Size(100, 20);
            this.rotationIntensityTextBox.TabIndex = 21;
            this.rotationIntensityTextBox.Text = ".01";
            this.rotationIntensityTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rotationIntensityTextBox_KeyDown);
            // 
            // rotationSpeedTextBox
            // 
            this.rotationSpeedTextBox.Location = new System.Drawing.Point(294, 126);
            this.rotationSpeedTextBox.Name = "rotationSpeedTextBox";
            this.rotationSpeedTextBox.Size = new System.Drawing.Size(100, 20);
            this.rotationSpeedTextBox.TabIndex = 22;
            this.rotationSpeedTextBox.Text = "0.15";
            this.rotationSpeedTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rotationSpeedTextBox_KeyDown);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 392);
            this.Controls.Add(this.rotationSpeedTextBox);
            this.Controls.Add(this.rotationIntensityTextBox);
            this.Controls.Add(this.rotationIntensitySlider);
            this.Controls.Add(this.yCheckBox);
            this.Controls.Add(this.xCheckBox);
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
            this.Controls.Add(this.rotationSpeedSlider);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GUI";
            this.Text = "NitroGuy\'s ScreenShake (v1.0)";
            ((System.ComponentModel.ISupportInitialize)(this.shakeSpeedSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shakeIntensitySlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationIntensitySlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationSpeedSlider)).EndInit();
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
        private System.Windows.Forms.CheckBox xCheckBox;
        private System.Windows.Forms.CheckBox yCheckBox;
        private System.Windows.Forms.TrackBar rotationIntensitySlider;
        private System.Windows.Forms.TrackBar rotationSpeedSlider;
        private System.Windows.Forms.TextBox rotationIntensityTextBox;
        private System.Windows.Forms.TextBox rotationSpeedTextBox;
    }
}

