using System;
using System.Windows.Forms;

namespace PetGameApp
{
    public partial class MainForm : Form
    {
        private Pet pet;

        public MainForm()
        {
            InitializeComponent();
            InitializePet();
            UpdateStatus();
        }

        private void InitializePet()
        {
            pet = new Pet(50, 50, 50); // Initial pet stats
            pet.OnStatusChanged += UpdateStatusEvent;
        }

        private void UpdateStatus()
        {
            hungerLabel.Text = $"Hunger: {pet.Hunger}";
            happinessLabel.Text = $"Happiness: {pet.Happiness}";
            energyLabel.Text = $"Energy: {pet.Energy}";

            petPictureBox.Image = pet.Image;

            if (!pet.IsAlive)
            {
                pet.Die();
                MessageBox.Show("Your pet has passed away. Game over!");
                Close();
            }
        }

        private void UpdateStatusEvent(object sender, EventArgs e)
        {
            Invoke(new MethodInvoker(UpdateStatus));
        }

        private void BioButton_Click(object sender, EventArgs e)
        {
            OpenPetBioForm();
        }

        private void FeedButton_Click(object sender, EventArgs e)
        {
            pet.Feed();
            UpdateStatus();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            pet.Play();
            UpdateStatus();
        }

        private void SleepButton_Click(object sender, EventArgs e)
        {
            pet.Sleep();
            UpdateStatus();
        }

        private void OpenPetBioForm()
        {
            var bioForm = new PetBioForm(pet);
            bioForm.Show();

            /*
            using (var bioForm = new PetBioForm(pet))
            {
                bioForm.ShowDialog();
            }*/
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            pet.OnStatusChanged -= UpdateStatusEvent;
            base.OnFormClosed(e);
        }

        private Button feedButton;
        private Button playButton;
        private Button sleepButton;
        private PictureBox petPictureBox;
        private Label hungerLabel;
        private Label happinessLabel;
        private Label energyLabel;
        private Button bioButton;
    }
}
