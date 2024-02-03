// PetBioForm.cs
using System;
using System.Windows.Forms;
using System.Xml;

namespace PetGameApp
{
    public partial class PetBioForm : Form
    {
        private Pet pet;

        public PetBioForm(Pet pet)
        {
            InitializeComponent();
            this.pet = pet;
            this.pet.OnStatusChanged += UpdateStatusEvent;
            InitialiseStatus();
        }

        private void InitialiseStatus()
        {
            nameLabel.Text = pet.Name;
            descriptionLabel.Text = $"Bio: {pet.Description}";
            UpdateStatus();
        }

        private void UpdateStatus()
        {
            petPictureBox.Image = pet.Image;

            levelLabel.Text = $"Level: {pet.Level}";
            experienceBar.Value = pet.ExperiencePercentage;

            strengthValueLabel.Text = $"{pet.Strength}";
            dexterityValueLabel.Text = $"{pet.Dexterity}";
            constitutionValueLabel.Text = $"{pet.Constitution}";
            intelligenceValueLabel.Text = $"{pet.Intelligence}";
            wisdomValueLabel.Text = $"{pet.Wisdom}";
            charismaValueLabel.Text = $"{pet.Charisma}";
        }

        private void UpdateStatusEvent(object sender, EventArgs e)
        {
            Invoke(new MethodInvoker(UpdateStatus));
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            pet.OnStatusChanged -= UpdateStatusEvent;
            base.OnFormClosed(e);
        }

        private Label nameLabel;
        private PictureBox petPictureBox;
        private Label descriptionLabel;

        private ProgressBar experienceBar;
        private Label levelLabel;

        private TableLayoutPanel attributesTableLayoutPanel;
        private Label strengthLabel;
        private Label dexterityLabel;
        private Label constitutionLabel;
        private Label intelligenceLabel;
        private Label wisdomLabel;
        private Label charismaLabel;

        private Label strengthValueLabel;
        private Label dexterityValueLabel;
        private Label constitutionValueLabel;
        private Label intelligenceValueLabel;
        private Label wisdomValueLabel;
        private Label charismaValueLabel;
    }
}
