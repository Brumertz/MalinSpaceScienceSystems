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
            textBoxStarRestWaveLength = new TextBox();
            labelStarMass = new Label();
            labelStarLuminosity = new Label();
            labelStarDistance = new Label();
            labelStarVelocity = new Label();
            labelInputSection = new Label();
            ButtonCalculate = new Button();
            textBoxBlackHoleMass = new TextBox();
            textBoxCelsius = new TextBox();
            textBoxParallaxAngle = new TextBox();
            textBoxObservedWaveLength = new TextBox();
            groupBox2 = new GroupBox();
            ButtonClear = new Button();
            labelResultMass = new Label();
            labelOutputSection = new Label();
            labelResultLuminosity = new Label();
            textBoxResultEventHorizon = new TextBox();
            labelResultDistance = new Label();
            textBoxResultKelvin = new TextBox();
            labelResultVelocity = new Label();
            textBoxResultDistance = new TextBox();
            textBoxResultVelocity = new TextBox();
            groupBox3 = new GroupBox();
            labelSettingsPanel = new Label();
            ButtonFontCustomization = new Button();
            ButtonBackgroundColor = new Button();
            CheckBoxNightMode = new CheckBox();
            groupBox4 = new GroupBox();
            labelErrorMessagingArea = new Label();
            textBoxErrorHandler = new TextBox();
            bindingSource1 = new BindingSource(components);
            ComboBoxLanguage = new ComboBox();
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
            groupBox1.Controls.Add(textBoxStarRestWaveLength);
            groupBox1.Controls.Add(labelStarMass);
            groupBox1.Controls.Add(labelStarLuminosity);
            groupBox1.Controls.Add(labelStarDistance);
            groupBox1.Controls.Add(labelStarVelocity);
            groupBox1.Controls.Add(labelInputSection);
            groupBox1.Controls.Add(ButtonCalculate);
            groupBox1.Controls.Add(textBoxBlackHoleMass);
            groupBox1.Controls.Add(textBoxCelsius);
            groupBox1.Controls.Add(textBoxParallaxAngle);
            groupBox1.Controls.Add(textBoxObservedWaveLength);
            groupBox1.Location = new Point(113, 137);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(384, 273);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Input Section";
            // 
            // textBoxStarRestWaveLength
            // 
            textBoxStarRestWaveLength.Location = new Point(247, 36);
            textBoxStarRestWaveLength.Margin = new Padding(3, 4, 3, 4);
            textBoxStarRestWaveLength.Name = "textBoxStarRestWaveLength";
            textBoxStarRestWaveLength.Size = new Size(97, 27);
            textBoxStarRestWaveLength.TabIndex = 14;
            textBoxStarRestWaveLength.TextAlign = HorizontalAlignment.Center;
            // 
            // labelStarMass
            // 
            labelStarMass.AutoSize = true;
            labelStarMass.Location = new Point(18, 160);
            labelStarMass.Name = "labelStarMass";
            labelStarMass.Size = new Size(72, 20);
            labelStarMass.TabIndex = 13;
            labelStarMass.Text = "Star Mass";
            // 
            // labelStarLuminosity
            // 
            labelStarLuminosity.AutoSize = true;
            labelStarLuminosity.Location = new Point(18, 121);
            labelStarLuminosity.Name = "labelStarLuminosity";
            labelStarLuminosity.Size = new Size(110, 20);
            labelStarLuminosity.TabIndex = 12;
            labelStarLuminosity.Text = "Star Luminosity";
            // 
            // labelStarDistance
            // 
            labelStarDistance.AutoSize = true;
            labelStarDistance.Location = new Point(18, 79);
            labelStarDistance.Name = "labelStarDistance";
            labelStarDistance.Size = new Size(96, 20);
            labelStarDistance.TabIndex = 11;
            labelStarDistance.Text = "Star Distance";
            // 
            // labelStarVelocity
            // 
            labelStarVelocity.AutoSize = true;
            labelStarVelocity.Location = new Point(21, 40);
            labelStarVelocity.Name = "labelStarVelocity";
            labelStarVelocity.Size = new Size(91, 20);
            labelStarVelocity.TabIndex = 10;
            labelStarVelocity.Text = "Star Velocity";
            // 
            // labelInputSection
            // 
            labelInputSection.AutoSize = true;
            labelInputSection.Location = new Point(7, 0);
            labelInputSection.Name = "labelInputSection";
            labelInputSection.Size = new Size(100, 20);
            labelInputSection.TabIndex = 6;
            labelInputSection.Text = "Input Section ";
            // 
            // buttonCalculate
            // 
            ButtonCalculate.Location = new Point(133, 215);
            ButtonCalculate.Margin = new Padding(3, 4, 3, 4);
            ButtonCalculate.Name = "buttonCalculate";
            ButtonCalculate.Size = new Size(95, 35);
            ButtonCalculate.TabIndex = 9;
            ButtonCalculate.Text = "Calculate";
            ButtonCalculate.UseVisualStyleBackColor = true;
            ButtonCalculate.Click += ButtonCalculate_Click;
            // 
            // textBoxBlackHoleMass
            // 
            textBoxBlackHoleMass.Location = new Point(247, 149);
            textBoxBlackHoleMass.Margin = new Padding(3, 4, 3, 4);
            textBoxBlackHoleMass.Name = "textBoxBlackHoleMass";
            textBoxBlackHoleMass.Size = new Size(97, 27);
            textBoxBlackHoleMass.TabIndex = 8;
            textBoxBlackHoleMass.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxCelsius
            // 
            textBoxCelsius.Location = new Point(247, 111);
            textBoxCelsius.Margin = new Padding(3, 4, 3, 4);
            textBoxCelsius.Name = "textBoxCelsius";
            textBoxCelsius.Size = new Size(97, 27);
            textBoxCelsius.TabIndex = 7;
            textBoxCelsius.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxParallaxAngle
            // 
            textBoxParallaxAngle.Location = new Point(247, 68);
            textBoxParallaxAngle.Margin = new Padding(3, 4, 3, 4);
            textBoxParallaxAngle.Name = "textBoxParallaxAngle";
            textBoxParallaxAngle.Size = new Size(97, 27);
            textBoxParallaxAngle.TabIndex = 1;
            textBoxParallaxAngle.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxObservedWaveLength
            // 
            textBoxObservedWaveLength.Location = new Point(133, 34);
            textBoxObservedWaveLength.Margin = new Padding(3, 4, 3, 4);
            textBoxObservedWaveLength.Name = "textBoxObservedWaveLength";
            textBoxObservedWaveLength.Size = new Size(97, 27);
            textBoxObservedWaveLength.TabIndex = 0;
            textBoxObservedWaveLength.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ButtonClear);
            groupBox2.Controls.Add(labelResultMass);
            groupBox2.Controls.Add(labelOutputSection);
            groupBox2.Controls.Add(labelResultLuminosity);
            groupBox2.Controls.Add(textBoxResultEventHorizon);
            groupBox2.Controls.Add(labelResultDistance);
            groupBox2.Controls.Add(textBoxResultKelvin);
            groupBox2.Controls.Add(labelResultVelocity);
            groupBox2.Controls.Add(textBoxResultDistance);
            groupBox2.Controls.Add(textBoxResultVelocity);
            groupBox2.Location = new Point(509, 137);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(361, 273);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Output Section";
            // 
            // buttonClear
            // 
            ButtonClear.Location = new Point(141, 215);
            ButtonClear.Margin = new Padding(3, 4, 3, 4);
            ButtonClear.Name = "buttonClear";
            ButtonClear.Size = new Size(95, 35);
            ButtonClear.TabIndex = 14;
            ButtonClear.Text = "Clear";
            ButtonClear.UseVisualStyleBackColor = true;
            ButtonClear.Click += buttonClear_Click;
            // 
            // labelResultMass
            // 
            labelResultMass.AutoSize = true;
            labelResultMass.Location = new Point(13, 160);
            labelResultMass.Name = "labelResultMass";
            labelResultMass.Size = new Size(86, 20);
            labelResultMass.TabIndex = 17;
            labelResultMass.Text = "Result Mass";
            // 
            // labelOutputSection
            // 
            labelOutputSection.AutoSize = true;
            labelOutputSection.Location = new Point(7, 0);
            labelOutputSection.Name = "labelOutputSection";
            labelOutputSection.Size = new Size(112, 20);
            labelOutputSection.TabIndex = 10;
            labelOutputSection.Text = "Output Section ";
            // 
            // labelResultLuminosity
            // 
            labelResultLuminosity.AutoSize = true;
            labelResultLuminosity.Location = new Point(13, 121);
            labelResultLuminosity.Name = "labelResultLuminosity";
            labelResultLuminosity.Size = new Size(124, 20);
            labelResultLuminosity.TabIndex = 16;
            labelResultLuminosity.Text = "Result Luminosity";
            // 
            // textBoxResultEventHorizon
            // 
            textBoxResultEventHorizon.Location = new Point(227, 156);
            textBoxResultEventHorizon.Margin = new Padding(3, 4, 3, 4);
            textBoxResultEventHorizon.Name = "textBoxResultEventHorizon";
            textBoxResultEventHorizon.ReadOnly = true;
            textBoxResultEventHorizon.Size = new Size(98, 27);
            textBoxResultEventHorizon.TabIndex = 7;
            textBoxResultEventHorizon.TextAlign = HorizontalAlignment.Center;
            // 
            // labelResultDistance
            // 
            labelResultDistance.AutoSize = true;
            labelResultDistance.Location = new Point(13, 79);
            labelResultDistance.Name = "labelResultDistance";
            labelResultDistance.Size = new Size(110, 20);
            labelResultDistance.TabIndex = 15;
            labelResultDistance.Text = "Result Distance";
            // 
            // textBoxResultKelvin
            // 
            textBoxResultKelvin.Location = new Point(227, 113);
            textBoxResultKelvin.Margin = new Padding(3, 4, 3, 4);
            textBoxResultKelvin.Name = "textBoxResultKelvin";
            textBoxResultKelvin.ReadOnly = true;
            textBoxResultKelvin.Size = new Size(98, 27);
            textBoxResultKelvin.TabIndex = 6;
            textBoxResultKelvin.TextAlign = HorizontalAlignment.Center;
            // 
            // labelResultVelocity
            // 
            labelResultVelocity.AutoSize = true;
            labelResultVelocity.Location = new Point(15, 40);
            labelResultVelocity.Name = "labelResultVelocity";
            labelResultVelocity.Size = new Size(105, 20);
            labelResultVelocity.TabIndex = 14;
            labelResultVelocity.Text = "Result Velocity";
            // 
            // textBoxResultDistance
            // 
            textBoxResultDistance.Location = new Point(227, 75);
            textBoxResultDistance.Margin = new Padding(3, 4, 3, 4);
            textBoxResultDistance.Name = "textBoxResultDistance";
            textBoxResultDistance.ReadOnly = true;
            textBoxResultDistance.Size = new Size(98, 27);
            textBoxResultDistance.TabIndex = 3;
            textBoxResultDistance.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxResultVelocity
            // 
            textBoxResultVelocity.Location = new Point(227, 36);
            textBoxResultVelocity.Margin = new Padding(3, 4, 3, 4);
            textBoxResultVelocity.Name = "textBoxResultVelocity";
            textBoxResultVelocity.ReadOnly = true;
            textBoxResultVelocity.Size = new Size(98, 27);
            textBoxResultVelocity.TabIndex = 2;
            textBoxResultVelocity.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(labelSettingsPanel);
            groupBox3.Controls.Add(ButtonFontCustomization);
            groupBox3.Controls.Add(ButtonBackgroundColor);
            groupBox3.Controls.Add(CheckBoxNightMode);
            groupBox3.Location = new Point(175, 423);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(650, 161);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Settings Panel ";
            // 
            // labelSettingsPanel
            // 
            labelSettingsPanel.AutoSize = true;
            labelSettingsPanel.Location = new Point(7, 0);
            labelSettingsPanel.Name = "labelSettingsPanel";
            labelSettingsPanel.Size = new Size(101, 20);
            labelSettingsPanel.TabIndex = 10;
            labelSettingsPanel.Text = "Settings Panel";
            // 
            // buttonFontCustomization
            // 
            ButtonFontCustomization.Location = new Point(216, 100);
            ButtonFontCustomization.Margin = new Padding(3, 4, 3, 4);
            ButtonFontCustomization.Name = "buttonFontCustomization";
            ButtonFontCustomization.Size = new Size(159, 31);
            ButtonFontCustomization.TabIndex = 6;
            ButtonFontCustomization.Text = "Font Customization";
            ButtonFontCustomization.UseVisualStyleBackColor = true;
            ButtonFontCustomization.Click += ButtonFontCustomization_Click;
            // 
            // buttonBackgroundColor
            // 
            ButtonBackgroundColor.Location = new Point(216, 45);
            ButtonBackgroundColor.Margin = new Padding(3, 4, 3, 4);
            ButtonBackgroundColor.Name = "buttonBackgroundColor";
            ButtonBackgroundColor.Size = new Size(159, 31);
            ButtonBackgroundColor.TabIndex = 5;
            ButtonBackgroundColor.Text = "Background Color";
            ButtonBackgroundColor.UseVisualStyleBackColor = true;
            ButtonBackgroundColor.Click += ButtonBackgroundColor_Click;
            // 
            // checkBoxNightMode
            // 
            CheckBoxNightMode.AutoSize = true;
            CheckBoxNightMode.Location = new Point(31, 76);
            CheckBoxNightMode.Margin = new Padding(3, 4, 3, 4);
            CheckBoxNightMode.Name = "checkBoxNightMode";
            CheckBoxNightMode.Size = new Size(147, 24);
            CheckBoxNightMode.TabIndex = 0;
            CheckBoxNightMode.Text = "Day/Night Mode ";
            CheckBoxNightMode.UseVisualStyleBackColor = true;
            CheckBoxNightMode.CheckedChanged += CheckBoxNightMode_CheckedChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(labelErrorMessagingArea);
            groupBox4.Controls.Add(textBoxErrorHandler);
            groupBox4.Location = new Point(175, 601);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(650, 161);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Error Messaging Area";
            // 
            // labelErrorMessagingArea
            // 
            labelErrorMessagingArea.AutoSize = true;
            labelErrorMessagingArea.Location = new Point(7, 0);
            labelErrorMessagingArea.Name = "labelErrorMessagingArea";
            labelErrorMessagingArea.Size = new Size(151, 20);
            labelErrorMessagingArea.TabIndex = 6;
            labelErrorMessagingArea.Text = "Error Messaging Area";
            // 
            // textBoxErrorHandler
            // 
            textBoxErrorHandler.Location = new Point(21, 41);
            textBoxErrorHandler.Margin = new Padding(3, 4, 3, 4);
            textBoxErrorHandler.Name = "textBoxErrorHandler";
            textBoxErrorHandler.Size = new Size(602, 27);
            textBoxErrorHandler.TabIndex = 0;
            // 
            // comboBoxLanguage
            // 
            ComboBoxLanguage.FormattingEnabled = true;
            ComboBoxLanguage.Location = new Point(736, 99);
            ComboBoxLanguage.Margin = new Padding(3, 4, 3, 4);
            ComboBoxLanguage.Name = "comboBoxLanguage";
            ComboBoxLanguage.Size = new Size(129, 28);
            ComboBoxLanguage.TabIndex = 4;
            ComboBoxLanguage.Text = "Language";
            ComboBoxLanguage.SelectedIndexChanged += comboBoxLanguage_SelectedIndexChanged;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(113, 33);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(607, 50);
            labelTitle.TabIndex = 5;
            labelTitle.Text = "Malin Space Science Systems";
            labelTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 783);
            Controls.Add(labelTitle);
            Controls.Add(ComboBoxLanguage);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
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
        private TextBox textBoxParallaxAngle;
        private TextBox textBoxObservedWaveLength;
        private TextBox textBoxResultDistance;
        private TextBox textBoxResultVelocity;
        private BindingSource bindingSource1;
        private TextBox textBoxBlackHoleMass;
        private TextBox textBoxCelsius;
        private TextBox textBoxResultEventHorizon;
        private TextBox textBoxResultKelvin;
        private ComboBox ComboBoxLanguage;
        private CheckBox CheckBoxNightMode;
        private BindingSource bindingSource2;
        private Button ButtonFontCustomization;
        private Button ButtonBackgroundColor;
        private ColorDialog colorDialog1;
        private FontDialog fontDialog1;
        private TextBox textBoxErrorHandler;
        private Label labelTitle;
        private Button ButtonCalculate;
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
        private Button ButtonClear;
        private TextBox textBoxStarRestWaveLength;
    }
}
