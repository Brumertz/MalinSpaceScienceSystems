namespace MalinSpaceScienceSystems
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            labelStarMass = new Label();
            labelStarLuminosity = new Label();
            labelStarDistance = new Label();
            labelStarVelocity = new Label();
            labelInputSection = new Label();
            buttonCalculate = new Button();
            textBoxStarMass = new TextBox();
            textBoxStarLuminosity = new TextBox();
            textBoxStarDistance = new TextBox();
            textBoxStarVelocity = new TextBox();
            groupBox2 = new GroupBox();
            buttonClear = new Button();
            labelResultMass = new Label();
            labelOutputSection = new Label();
            labelResultLuminosity = new Label();
            textBoxResultMass = new TextBox();
            labelResultDistance = new Label();
            textBoxResultLuminosity = new TextBox();
            labelResultVelocity = new Label();
            textBoxResultDistance = new TextBox();
            textBoxResultVelocity = new TextBox();
            groupBox3 = new GroupBox();
            labelSettingsPanel = new Label();
            buttonFontCustomization = new Button();
            buttonBackgroundColor = new Button();
            checkBoxNightMode = new CheckBox();
            groupBox4 = new GroupBox();
            labelErrorMessagingArea = new Label();
            textBoxErrorHandler = new TextBox();
            bindingSource1 = new BindingSource(components);
            comboBoxLanguage = new ComboBox();
            bindingSource2 = new BindingSource(components);
            colorDialog1 = new ColorDialog();
            fontDialog1 = new FontDialog();
            labelTitle = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelStarMass);
            groupBox1.Controls.Add(labelStarLuminosity);
            groupBox1.Controls.Add(labelStarDistance);
            groupBox1.Controls.Add(labelStarVelocity);
            groupBox1.Controls.Add(labelInputSection);
            groupBox1.Controls.Add(buttonCalculate);
            groupBox1.Controls.Add(textBoxStarMass);
            groupBox1.Controls.Add(textBoxStarLuminosity);
            groupBox1.Controls.Add(textBoxStarDistance);
            groupBox1.Controls.Add(textBoxStarVelocity);
            groupBox1.Location = new Point(99, 103);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(336, 205);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Input Section";
            // 
            // labelStarMass
            // 
            labelStarMass.AutoSize = true;
            labelStarMass.Location = new Point(16, 120);
            labelStarMass.Name = "labelStarMass";
            labelStarMass.Size = new Size(57, 15);
            labelStarMass.TabIndex = 13;
            labelStarMass.Text = "Star Mass";
            // 
            // labelStarLuminosity
            // 
            labelStarLuminosity.AutoSize = true;
            labelStarLuminosity.Location = new Point(16, 91);
            labelStarLuminosity.Name = "labelStarLuminosity";
            labelStarLuminosity.Size = new Size(89, 15);
            labelStarLuminosity.TabIndex = 12;
            labelStarLuminosity.Text = "Star Luminosity";
            // 
            // labelStarDistance
            // 
            labelStarDistance.AutoSize = true;
            labelStarDistance.Location = new Point(16, 59);
            labelStarDistance.Name = "labelStarDistance";
            labelStarDistance.Size = new Size(75, 15);
            labelStarDistance.TabIndex = 11;
            labelStarDistance.Text = "Star Distance";
            // 
            // labelStarVelocity
            // 
            labelStarVelocity.AutoSize = true;
            labelStarVelocity.Location = new Point(18, 30);
            labelStarVelocity.Name = "labelStarVelocity";
            labelStarVelocity.Size = new Size(71, 15);
            labelStarVelocity.TabIndex = 10;
            labelStarVelocity.Text = "Star Velocity";
            // 
            // labelInputSection
            // 
            labelInputSection.AutoSize = true;
            labelInputSection.Location = new Point(6, 0);
            labelInputSection.Name = "labelInputSection";
            labelInputSection.Size = new Size(80, 15);
            labelInputSection.TabIndex = 6;
            labelInputSection.Text = "Input Section ";
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(116, 161);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(83, 26);
            buttonCalculate.TabIndex = 9;
            buttonCalculate.Text = "Calculate";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // textBoxStarMass
            // 
            textBoxStarMass.Location = new Point(216, 112);
            textBoxStarMass.Name = "textBoxStarMass";
            textBoxStarMass.Size = new Size(85, 23);
            textBoxStarMass.TabIndex = 8;
            textBoxStarMass.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxStarLuminosity
            // 
            textBoxStarLuminosity.Location = new Point(216, 83);
            textBoxStarLuminosity.Name = "textBoxStarLuminosity";
            textBoxStarLuminosity.Size = new Size(85, 23);
            textBoxStarLuminosity.TabIndex = 7;
            textBoxStarLuminosity.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxStarDistance
            // 
            textBoxStarDistance.Location = new Point(216, 51);
            textBoxStarDistance.Name = "textBoxStarDistance";
            textBoxStarDistance.Size = new Size(85, 23);
            textBoxStarDistance.TabIndex = 1;
            textBoxStarDistance.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxStarVelocity
            // 
            textBoxStarVelocity.Location = new Point(216, 25);
            textBoxStarVelocity.Name = "textBoxStarVelocity";
            textBoxStarVelocity.Size = new Size(85, 23);
            textBoxStarVelocity.TabIndex = 0;
            textBoxStarVelocity.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonClear);
            groupBox2.Controls.Add(labelResultMass);
            groupBox2.Controls.Add(labelOutputSection);
            groupBox2.Controls.Add(labelResultLuminosity);
            groupBox2.Controls.Add(textBoxResultMass);
            groupBox2.Controls.Add(labelResultDistance);
            groupBox2.Controls.Add(textBoxResultLuminosity);
            groupBox2.Controls.Add(labelResultVelocity);
            groupBox2.Controls.Add(textBoxResultDistance);
            groupBox2.Controls.Add(textBoxResultVelocity);
            groupBox2.Location = new Point(445, 103);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(316, 205);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Output Section";
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(123, 161);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(83, 26);
            buttonClear.TabIndex = 14;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // labelResultMass
            // 
            labelResultMass.AutoSize = true;
            labelResultMass.Location = new Point(11, 120);
            labelResultMass.Name = "labelResultMass";
            labelResultMass.Size = new Size(69, 15);
            labelResultMass.TabIndex = 17;
            labelResultMass.Text = "Result Mass";
            // 
            // labelOutputSection
            // 
            labelOutputSection.AutoSize = true;
            labelOutputSection.Location = new Point(6, 0);
            labelOutputSection.Name = "labelOutputSection";
            labelOutputSection.Size = new Size(90, 15);
            labelOutputSection.TabIndex = 10;
            labelOutputSection.Text = "Output Section ";
            // 
            // labelResultLuminosity
            // 
            labelResultLuminosity.AutoSize = true;
            labelResultLuminosity.Location = new Point(11, 91);
            labelResultLuminosity.Name = "labelResultLuminosity";
            labelResultLuminosity.Size = new Size(101, 15);
            labelResultLuminosity.TabIndex = 16;
            labelResultLuminosity.Text = "Result Luminosity";
            // 
            // textBoxResultMass
            // 
            textBoxResultMass.Location = new Point(199, 117);
            textBoxResultMass.Name = "textBoxResultMass";
            textBoxResultMass.ReadOnly = true;
            textBoxResultMass.Size = new Size(86, 23);
            textBoxResultMass.TabIndex = 7;
            textBoxResultMass.TextAlign = HorizontalAlignment.Center;
            // 
            // labelResultDistance
            // 
            labelResultDistance.AutoSize = true;
            labelResultDistance.Location = new Point(11, 59);
            labelResultDistance.Name = "labelResultDistance";
            labelResultDistance.Size = new Size(87, 15);
            labelResultDistance.TabIndex = 15;
            labelResultDistance.Text = "Result Distance";
            // 
            // textBoxResultLuminosity
            // 
            textBoxResultLuminosity.Location = new Point(199, 85);
            textBoxResultLuminosity.Name = "textBoxResultLuminosity";
            textBoxResultLuminosity.ReadOnly = true;
            textBoxResultLuminosity.Size = new Size(86, 23);
            textBoxResultLuminosity.TabIndex = 6;
            textBoxResultLuminosity.TextAlign = HorizontalAlignment.Center;
            // 
            // labelResultVelocity
            // 
            labelResultVelocity.AutoSize = true;
            labelResultVelocity.Location = new Point(13, 30);
            labelResultVelocity.Name = "labelResultVelocity";
            labelResultVelocity.Size = new Size(83, 15);
            labelResultVelocity.TabIndex = 14;
            labelResultVelocity.Text = "Result Velocity";
            // 
            // textBoxResultDistance
            // 
            textBoxResultDistance.Location = new Point(199, 56);
            textBoxResultDistance.Name = "textBoxResultDistance";
            textBoxResultDistance.ReadOnly = true;
            textBoxResultDistance.Size = new Size(86, 23);
            textBoxResultDistance.TabIndex = 3;
            textBoxResultDistance.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxResultVelocity
            // 
            textBoxResultVelocity.Location = new Point(199, 27);
            textBoxResultVelocity.Name = "textBoxResultVelocity";
            textBoxResultVelocity.ReadOnly = true;
            textBoxResultVelocity.Size = new Size(86, 23);
            textBoxResultVelocity.TabIndex = 2;
            textBoxResultVelocity.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(labelSettingsPanel);
            groupBox3.Controls.Add(buttonFontCustomization);
            groupBox3.Controls.Add(buttonBackgroundColor);
            groupBox3.Controls.Add(checkBoxNightMode);
            groupBox3.Location = new Point(153, 317);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(569, 121);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Settings Panel ";
            // 
            // labelSettingsPanel
            // 
            labelSettingsPanel.AutoSize = true;
            labelSettingsPanel.Location = new Point(6, 0);
            labelSettingsPanel.Name = "labelSettingsPanel";
            labelSettingsPanel.Size = new Size(81, 15);
            labelSettingsPanel.TabIndex = 10;
            labelSettingsPanel.Text = "Settings Panel";
            // 
            // buttonFontCustomization
            // 
            buttonFontCustomization.Location = new Point(189, 75);
            buttonFontCustomization.Name = "buttonFontCustomization";
            buttonFontCustomization.Size = new Size(139, 23);
            buttonFontCustomization.TabIndex = 6;
            buttonFontCustomization.Text = "Font Customization";
            buttonFontCustomization.UseVisualStyleBackColor = true;
            buttonFontCustomization.Click += buttonFontCustomization_Click;
            // 
            // buttonBackgroundColor
            // 
            buttonBackgroundColor.Location = new Point(189, 34);
            buttonBackgroundColor.Name = "buttonBackgroundColor";
            buttonBackgroundColor.Size = new Size(139, 23);
            buttonBackgroundColor.TabIndex = 5;
            buttonBackgroundColor.Text = "Background Color";
            buttonBackgroundColor.UseVisualStyleBackColor = true;
            buttonBackgroundColor.Click += buttonBackgroundColor_Click;
            // 
            // checkBoxNightMode
            // 
            checkBoxNightMode.AutoSize = true;
            checkBoxNightMode.Location = new Point(27, 57);
            checkBoxNightMode.Name = "checkBoxNightMode";
            checkBoxNightMode.Size = new Size(118, 19);
            checkBoxNightMode.TabIndex = 0;
            checkBoxNightMode.Text = "Day/Night Mode ";
            checkBoxNightMode.UseVisualStyleBackColor = true;
            checkBoxNightMode.CheckedChanged += checkBoxNightMode_CheckedChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(labelErrorMessagingArea);
            groupBox4.Controls.Add(textBoxErrorHandler);
            groupBox4.Location = new Point(153, 451);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(569, 121);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Error Messaging Area";
            // 
            // labelErrorMessagingArea
            // 
            labelErrorMessagingArea.AutoSize = true;
            labelErrorMessagingArea.Location = new Point(6, 0);
            labelErrorMessagingArea.Name = "labelErrorMessagingArea";
            labelErrorMessagingArea.Size = new Size(119, 15);
            labelErrorMessagingArea.TabIndex = 6;
            labelErrorMessagingArea.Text = "Error Messaging Area";
            // 
            // textBoxErrorHandler
            // 
            textBoxErrorHandler.Location = new Point(18, 31);
            textBoxErrorHandler.Name = "textBoxErrorHandler";
            textBoxErrorHandler.Size = new Size(527, 23);
            textBoxErrorHandler.TabIndex = 0;
            // 
            // comboBoxLanguage
            // 
            comboBoxLanguage.FormattingEnabled = true;
            comboBoxLanguage.Location = new Point(644, 74);
            comboBoxLanguage.Name = "comboBoxLanguage";
            comboBoxLanguage.Size = new Size(113, 23);
            comboBoxLanguage.TabIndex = 4;
            comboBoxLanguage.Text = "Language";
            comboBoxLanguage.SelectedIndexChanged += comboBoxLanguage_SelectedIndexChanged;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(99, 25);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(489, 40);
            labelTitle.TabIndex = 5;
            labelTitle.Text = "Malin Space Science Systems";
            labelTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 587);
            Controls.Add(labelTitle);
            Controls.Add(comboBoxLanguage);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private TextBox textBoxStarDistance;
        private TextBox textBoxStarVelocity;
        private TextBox textBoxResultDistance;
        private TextBox textBoxResultVelocity;
        private BindingSource bindingSource1;
        private TextBox textBoxStarMass;
        private TextBox textBoxStarLuminosity;
        private TextBox textBoxResultMass;
        private TextBox textBoxResultLuminosity;
        private ComboBox comboBoxLanguage;
        private CheckBox checkBoxNightMode;
        private BindingSource bindingSource2;
        private Button buttonFontCustomization;
        private Button buttonBackgroundColor;
        private ColorDialog colorDialog1;
        private FontDialog fontDialog1;
        private TextBox textBoxErrorHandler;
        private Label labelTitle;
        private Button buttonCalculate;
        private Label labelInputSection;
        private Label labelOutputSection;
        private Label labelSettingsPanel;
        private Label labelErrorMessagingArea;
        private Label labelStarMass;
        private Label labelStarLuminosity;
        private Label labelStarDistance;
        private Label labelStarVelocity;
        private Label labelResultMass;
        private Label labelResultLuminosity;
        private Label labelResultDistance;
        private Label labelResultVelocity;
        private Button buttonClear;
    }
}
