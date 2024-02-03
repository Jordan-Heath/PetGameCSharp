using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetGameApp
{
    public partial class PetBioForm : Form
    {
        private void InitializeComponent()
        {
            nameLabel = new Label();
            petPictureBox = new PictureBox();
            experienceBar = new ProgressBar();
            levelLabel = new Label();
            attributesTableLayoutPanel = new TableLayoutPanel();
            strengthLabel = new Label();
            dexterityLabel = new Label();
            constitutionLabel = new Label();
            intelligenceLabel = new Label();
            wisdomLabel = new Label();
            charismaLabel = new Label();
            strengthValueLabel = new Label();
            dexterityValueLabel = new Label();
            constitutionValueLabel = new Label();
            intelligenceValueLabel = new Label();
            wisdomValueLabel = new Label();
            charismaValueLabel = new Label();
            descriptionLabel = new Label();
            ((ISupportInitialize)petPictureBox).BeginInit();
            attributesTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(89, 47);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(67, 15);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "NameLabel";
            // 
            // petPictureBox
            // 
            petPictureBox.Location = new Point(89, 92);
            petPictureBox.Name = "petPictureBox";
            petPictureBox.Size = new Size(100, 50);
            petPictureBox.TabIndex = 2;
            petPictureBox.TabStop = false;
            // 
            // experienceBar
            // 
            experienceBar.Location = new Point(89, 340);
            experienceBar.Name = "experienceBar";
            experienceBar.Size = new Size(446, 23);
            experienceBar.Step = 1;
            experienceBar.TabIndex = 4;
            experienceBar.Value = 50;
            // 
            // levelLabel
            // 
            levelLabel.AutoSize = true;
            levelLabel.Location = new Point(89, 322);
            levelLabel.Name = "levelLabel";
            levelLabel.Size = new Size(62, 15);
            levelLabel.TabIndex = 5;
            levelLabel.Text = "LevelLabel";
            // 
            // attributesTableLayoutPanel
            // 
            attributesTableLayoutPanel.ColumnCount = 2;
            attributesTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            attributesTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            attributesTableLayoutPanel.Controls.Add(strengthLabel, 0, 0);
            attributesTableLayoutPanel.Controls.Add(dexterityLabel, 0, 1);
            attributesTableLayoutPanel.Controls.Add(constitutionLabel, 0, 2);
            attributesTableLayoutPanel.Controls.Add(intelligenceLabel, 0, 3);
            attributesTableLayoutPanel.Controls.Add(wisdomLabel, 0, 4);
            attributesTableLayoutPanel.Controls.Add(charismaLabel, 0, 5);
            attributesTableLayoutPanel.Controls.Add(strengthValueLabel, 1, 0);
            attributesTableLayoutPanel.Controls.Add(dexterityValueLabel, 1, 1);
            attributesTableLayoutPanel.Controls.Add(constitutionValueLabel, 1, 2);
            attributesTableLayoutPanel.Controls.Add(intelligenceValueLabel, 1, 3);
            attributesTableLayoutPanel.Controls.Add(wisdomValueLabel, 1, 4);
            attributesTableLayoutPanel.Controls.Add(charismaValueLabel, 1, 5);
            attributesTableLayoutPanel.Location = new Point(322, 47);
            attributesTableLayoutPanel.Name = "attributesTableLayoutPanel";
            attributesTableLayoutPanel.RowCount = 6;
            attributesTableLayoutPanel.RowStyles.Add(new RowStyle());
            attributesTableLayoutPanel.RowStyles.Add(new RowStyle());
            attributesTableLayoutPanel.RowStyles.Add(new RowStyle());
            attributesTableLayoutPanel.RowStyles.Add(new RowStyle());
            attributesTableLayoutPanel.RowStyles.Add(new RowStyle());
            attributesTableLayoutPanel.RowStyles.Add(new RowStyle());
            attributesTableLayoutPanel.Size = new Size(213, 126);
            attributesTableLayoutPanel.TabIndex = 6;
            // 
            // strengthLabel
            // 
            strengthLabel.AutoSize = true;
            strengthLabel.Location = new Point(3, 0);
            strengthLabel.Name = "strengthLabel";
            strengthLabel.Size = new Size(52, 15);
            strengthLabel.TabIndex = 0;
            strengthLabel.Text = "Strength";
            // 
            // dexterityLabel
            // 
            dexterityLabel.AutoSize = true;
            dexterityLabel.Location = new Point(3, 15);
            dexterityLabel.Name = "dexterityLabel";
            dexterityLabel.Size = new Size(54, 15);
            dexterityLabel.TabIndex = 1;
            dexterityLabel.Text = "Dexterity";
            // 
            // constitutionLabel
            // 
            constitutionLabel.AutoSize = true;
            constitutionLabel.Location = new Point(3, 30);
            constitutionLabel.Name = "constitutionLabel";
            constitutionLabel.Size = new Size(73, 15);
            constitutionLabel.TabIndex = 2;
            constitutionLabel.Text = "Constitution";
            // 
            // intelligenceLabel
            // 
            intelligenceLabel.AutoSize = true;
            intelligenceLabel.Location = new Point(3, 45);
            intelligenceLabel.Name = "intelligenceLabel";
            intelligenceLabel.Size = new Size(68, 15);
            intelligenceLabel.TabIndex = 3;
            intelligenceLabel.Text = "Intelligence";
            // 
            // wisdomLabel
            // 
            wisdomLabel.AutoSize = true;
            wisdomLabel.Location = new Point(3, 60);
            wisdomLabel.Name = "wisdomLabel";
            wisdomLabel.Size = new Size(51, 15);
            wisdomLabel.TabIndex = 4;
            wisdomLabel.Text = "Wisdom";
            // 
            // charismaLabel
            // 
            charismaLabel.AutoSize = true;
            charismaLabel.Location = new Point(3, 75);
            charismaLabel.Name = "charismaLabel";
            charismaLabel.Size = new Size(57, 15);
            charismaLabel.TabIndex = 5;
            charismaLabel.Text = "Charisma";
            // 
            // strengthValueLabel
            // 
            strengthValueLabel.AutoSize = true;
            strengthValueLabel.Location = new Point(82, 0);
            strengthValueLabel.Name = "strengthValueLabel";
            strengthValueLabel.Size = new Size(107, 15);
            strengthValueLabel.TabIndex = 6;
            strengthValueLabel.Text = "strengthValueLabel";
            // 
            // dexterityValueLabel
            // 
            dexterityValueLabel.AutoSize = true;
            dexterityValueLabel.Location = new Point(82, 15);
            dexterityValueLabel.Name = "dexterityValueLabel";
            dexterityValueLabel.Size = new Size(110, 15);
            dexterityValueLabel.TabIndex = 7;
            dexterityValueLabel.Text = "DexterityValueLabel";
            // 
            // constitutionValueLabel
            // 
            constitutionValueLabel.AutoSize = true;
            constitutionValueLabel.Location = new Point(82, 30);
            constitutionValueLabel.Name = "constitutionValueLabel";
            constitutionValueLabel.Size = new Size(129, 15);
            constitutionValueLabel.TabIndex = 8;
            constitutionValueLabel.Text = "ConstitutionValueLabel";
            // 
            // intelligenceValueLabel
            // 
            intelligenceValueLabel.AutoSize = true;
            intelligenceValueLabel.Location = new Point(82, 45);
            intelligenceValueLabel.Name = "intelligenceValueLabel";
            intelligenceValueLabel.Size = new Size(124, 15);
            intelligenceValueLabel.TabIndex = 9;
            intelligenceValueLabel.Text = "IntelligenceValueLabel";
            // 
            // wisdomValueLabel
            // 
            wisdomValueLabel.AutoSize = true;
            wisdomValueLabel.Location = new Point(82, 60);
            wisdomValueLabel.Name = "wisdomValueLabel";
            wisdomValueLabel.Size = new Size(107, 15);
            wisdomValueLabel.TabIndex = 10;
            wisdomValueLabel.Text = "WisdomValueLabel";
            // 
            // charismaValueLabel
            // 
            charismaValueLabel.AutoSize = true;
            charismaValueLabel.Location = new Point(82, 75);
            charismaValueLabel.Name = "charismaValueLabel";
            charismaValueLabel.Size = new Size(113, 15);
            charismaValueLabel.TabIndex = 11;
            charismaValueLabel.Text = "CharismaValueLabel";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(89, 185);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(95, 15);
            descriptionLabel.TabIndex = 7;
            descriptionLabel.Text = "DescriptionLabel";
            // 
            // PetBioForm
            // 
            ClientSize = new Size(624, 441);
            Controls.Add(descriptionLabel);
            Controls.Add(attributesTableLayoutPanel);
            Controls.Add(levelLabel);
            Controls.Add(experienceBar);
            Controls.Add(petPictureBox);
            Controls.Add(nameLabel);
            Name = "PetBioForm";
            ((ISupportInitialize)petPictureBox).EndInit();
            attributesTableLayoutPanel.ResumeLayout(false);
            attributesTableLayoutPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void PetBioForm_Load(object sender, EventArgs e)
        {
        }
    }
}
