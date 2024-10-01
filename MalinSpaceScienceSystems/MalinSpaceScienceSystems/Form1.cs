using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using System.ServiceModel;
namespace MalinSpaceScienceSystems

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeLanguageComboBox();
            SetInitialSettings();

        }
        private void InitializeLanguageComboBox()
        {
            comboBoxLanguage.Items.AddRange(new string[] { "English", "French", "German" });
            comboBoxLanguage.SelectedIndex = 0; // Default to English
        }

        // Set initial settings for the form
        private void SetInitialSettings()
        {
            this.BackColor = Color.White; // Default background color
            labelTitle.ForeColor = Color.Black; // Default label color
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            // Clear previous error message
            textBoxErrorHandler.Text = string.Empty;

            try
            {
                // Retrieve inputs
                double velocity = Convert.ToDouble(textBoxStarVelocity.Text);
                double distance = Convert.ToDouble(textBoxStarDistance.Text);
                double mass = Convert.ToDouble(textBoxStarMass.Text);
                double luminosity = Convert.ToDouble(textBoxStarLuminosity.Text);

                // Perform calculations (example calculations)
                textBoxResultVelocity.Text = (velocity * 1.1).ToString(); // Example calculation
                textBoxResultDistance.Text = (distance * 1.2).ToString(); // Example calculation
                textBoxResultMass.Text = (mass * 1.3).ToString(); // Example calculation
                textBoxResultLuminosity.Text = (luminosity * 1.4).ToString(); // Example calculation
            }
            catch (Exception ex)
            {
                // Display error message
                textBoxErrorHandler.Text = "Error: " + ex.Message;
            }

        }

        private void buttonBackgroundColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color; // Change background color
            }
        }

        private void buttonFontCustomization_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                if (fontDialog1.ShowDialog() == DialogResult.OK)
                {
                    ChangeFont(this, fontDialog1.Font); // Change font for all controls
                }
            }
        }

        // Recursive method to change the font for all controls
        private void ChangeFont(Control control, Font font)
        {
            // Skip changing the font if the control is labelTitle
            if (control == labelTitle) return;

            control.Font = font; // Set the font for the current control

            // Recursively set the font for all child controls
            foreach (Control child in control.Controls)
            {
                ChangeFont(child, font);
            }
        }
        // CheckBox CheckedChanged event for day/night mode
        private void checkBoxNightMode_CheckedChanged(object sender, EventArgs e)
        {
            // Change background color based on night mode status
            if (checkBoxNightMode.Checked)
            {
                this.BackColor = Color.Black; // Set form background to black
                ChangeFontColor(Color.White); // Change font color to white
                ChangeControlBackColor(Color.Black); // Change background color to black for all controls
            }
            else
            {
                this.BackColor = Color.White; // Set form background to white
                ChangeFontColor(Color.Black); // Change font color to black
                ChangeControlBackColor(Color.White); // Change background color to white for all controls
            }

        }


        // Method to change the font color of all controls on the form
        private void ChangeFontColor(Color color)
        {
            // Recursively change font color for all controls
            ChangeControlFontColor(this, color);
        }
        // Method to change the background color of all controls in the form
        private void ChangeControlBackColor(Color color)
        {
            // Change the background color for all controls
            ChangeControlBackColorRecursive(this, color);
        }
        // Recursive method to change the background color of a control and its children
        private void ChangeControlBackColorRecursive(Control control, Color color)
        {
            // Change the background color of the current control
            control.BackColor = color; // Set the background color

            // If the control has children, iterate through its children
            if (control.HasChildren)
            {
                foreach (Control child in control.Controls)
                {
                    ChangeControlBackColorRecursive(child, color); // Recursively apply background color to child controls
                }
            }
        }

        // Method to change the font color of all controls on the form
        private void ChangeControlFontColor(Control control, Color color)
        {
            // Change the font color of the current control if it supports ForeColor
            if (control is Label || control is TextBox || control is ComboBox || control is CheckBox || control is Button)
            {
                control.ForeColor = color;
            }

            // If the control is a GroupBox or Panel, recurse through its children
            if (control.HasChildren)
            {
                foreach (Control child in control.Controls)
                {
                    ChangeControlFontColor(child, color); // Recursively apply the font color to child controls
                }
            }
        }
       

        // Dictionary to hold language strings for easy management
        private readonly Dictionary<string, Dictionary<string, string>> languageStrings = new Dictionary<string, Dictionary<string, string>>
            {
                { "English", new Dictionary<string, string>()
                    {
                        { "Title", "Malin Space Science Systems" },
                        { "InputSection", "Input Section" },
                        { "OutputSection", "Output Section" },
                        { "SettingsPanel", "Settings Panel" },
                        { "ErrorMessagingArea", "Error Messaging Area" },
                        { "StarVelocity", "Star Velocity" },
                        { "StarDistance", "Star Distance" },
                        { "StarLuminosity", "Star Luminosity" },
                        { "StarMass", "Star Mass" },
                        { "ResultVelocity", "Result Velocity" },
                        { "ResultDistance", "Result Distance" },
                        { "ResultLuminosity", "Result Luminosity" },
                        { "ResultMass", "Result Mass" },
                        { "ButtonCalculate", "Calculate" },
                        { "ButtonClear", "Clear" },
                        { "ButtonBackgroundColor", "Background Color" },
                        { "ButtonFontCustomization", "Font Customization" },
                        { "CheckBoxNightMode", "Day/Night Mode" }
                    }
                },
                { "French", new Dictionary<string, string>()
                    {
                        { "Title", "Systèmes de Science Spatiale Malin" },
                        { "InputSection", "Section d'entrée" },
                        { "OutputSection", "Section de sortie" },
                        { "SettingsPanel", "Panneau des paramètres" },
                        { "ErrorMessagingArea", "Zone de messagerie d'erreur" },
                        { "StarVelocity", "Vitesse de l'étoile" },
                        { "StarDistance", "Distance de l'étoile" },
                        { "StarLuminosity", "Luminosité de l'étoile" },
                        { "StarMass", "Masse de l'étoile" },
                        { "ResultVelocity", "Résultat Vitesse" },
                        { "ResultDistance", "Résultat Distance" },
                        { "ResultLuminosity", "Résultat Luminosité" },
                        { "ResultMass", "Résultat Masse" },
                        { "ButtonCalculate", "Calculer" },
                        { "ButtonClear", "Effacer" },
                        { "ButtonBackgroundColor", "Couleur de fond" },
                        { "ButtonFontCustomization", "Personnalisation des polices" },
                        { "CheckBoxNightMode", "Mode Jour/Nuit" }
                    }
                },
                { "German", new Dictionary<string, string>()
                    {
                        { "Title", "Malin Weltraumwissenschaftssysteme" },
                        { "InputSection", "Eingabebereich" },
                        { "OutputSection", "Ausgabebereich" },
                        { "SettingsPanel", "Einstellungen Panel" },
                        { "ErrorMessagingArea", "Fehlermeldungsbereich" },
                        { "StarVelocity", "Sternengeschwindigkeit" },
                        { "StarDistance", "Sterndistanz" },
                        { "StarLuminosity", "Sternleuchtkraft" },
                        { "StarMass", "Sternmasse" },
                        { "ResultVelocity", "Ergebnis Geschwindigkeit" },
                        { "ResultDistance", "Ergebnis Distanz" },
                        { "ResultLuminosity", "Ergebnis Leuchtkraft" },
                        { "ResultMass", "Ergebnis Masse" },
                        { "ButtonCalculate", "Berechnen" },
                        { "ButtonClear", "Löschen" },
                        { "ButtonBackgroundColor", "Hintergrundfarbe" },
                        { "ButtonFontCustomization", "Schriftanpassung" },
                        { "CheckBoxNightMode", "Tag/Nacht Modus" }
                    }
                }
            };

        // ComboBox SelectedIndexChanged event for language selectio
        private void comboBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if SelectedItem is not null before dereferencing it
            if (comboBoxLanguage.SelectedItem is string selectedLanguage) // Ensure selectedLanguage is a string
            {
                // Update labels, buttons, and checkboxes based on selected language
                if (languageStrings.ContainsKey(selectedLanguage)) // Check for key existence
                {
                    // Update title
                    labelTitle.Text = languageStrings[selectedLanguage]["Title"]; // Ensure you have "Title" in your dictionary for each language

                    // Update other labels
                    labelInputSection.Text = languageStrings[selectedLanguage]["InputSection"];
                    labelOutputSection.Text = languageStrings[selectedLanguage]["OutputSection"];
                    labelSettingsPanel.Text = languageStrings[selectedLanguage]["SettingsPanel"];
                    labelErrorMessagingArea.Text = languageStrings[selectedLanguage]["ErrorMessagingArea"];
                    labelStarVelocity.Text = languageStrings[selectedLanguage]["StarVelocity"];
                    labelStarDistance.Text = languageStrings[selectedLanguage]["StarDistance"];
                    labelStarLuminosity.Text = languageStrings[selectedLanguage]["StarLuminosity"];
                    labelStarMass.Text = languageStrings[selectedLanguage]["StarMass"];
                    labelResultVelocity.Text = languageStrings[selectedLanguage]["ResultVelocity"];
                    labelResultDistance.Text = languageStrings[selectedLanguage]["ResultDistance"];
                    labelResultLuminosity.Text = languageStrings[selectedLanguage]["ResultLuminosity"];
                    labelResultMass.Text = languageStrings[selectedLanguage]["ResultMass"];

                    // Update buttons
                    buttonCalculate.Text = languageStrings[selectedLanguage]["ButtonCalculate"];
                    buttonClear.Text = languageStrings[selectedLanguage]["ButtonClear"];
                    buttonBackgroundColor.Text = languageStrings[selectedLanguage]["ButtonBackgroundColor"];
                    buttonFontCustomization.Text = languageStrings[selectedLanguage]["ButtonFontCustomization"];

                    // Update checkbox
                    checkBoxNightMode.Text = languageStrings[selectedLanguage]["CheckBoxNightMode"];
                }
            }
        }
        

        private void buttonClear_Click(object sender, EventArgs e)
        {
            // Call the method to clear all text boxes
            ClearTextBoxes(this);
        }
        // Method to clear all text boxes in the form
        private void ClearTextBoxes(Control control)
        {
            foreach (Control child in control.Controls)
            {
                // Check if the control is a TextBox
                if (child is TextBox textBox)
                {
                    textBox.Clear(); // Clear the text box
                }

                // If the control has children, call the method recursively
                if (child.HasChildren)
                {
                    ClearTextBoxes(child); // Recursively clear text boxes in child controls
                }
            }
        }
    }
}

