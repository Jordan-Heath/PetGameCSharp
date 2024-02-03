namespace PetGameApp
{
    public partial class MainForm : Form
    {
        private void InitializeComponent()
        {
            feedButton = new Button();
            playButton = new Button();
            sleepButton = new Button();
            petPictureBox = new PictureBox();
            hungerLabel = new Label();
            happinessLabel = new Label();
            energyLabel = new Label();
            bioButton = new Button();
            ((System.ComponentModel.ISupportInitialize)petPictureBox).BeginInit();
            SuspendLayout();
            // 
            // feedButton
            // 
            feedButton.Location = new Point(102, 351);
            feedButton.Name = "feedButton";
            feedButton.Size = new Size(75, 23);
            feedButton.TabIndex = 0;
            feedButton.Text = "Feed";
            feedButton.UseVisualStyleBackColor = true;
            feedButton.Click += FeedButton_Click;
            // 
            // playButton
            // 
            playButton.Location = new Point(247, 351);
            playButton.Name = "playButton";
            playButton.Size = new Size(75, 23);
            playButton.TabIndex = 1;
            playButton.Text = "Play";
            playButton.UseVisualStyleBackColor = true;
            playButton.Click += PlayButton_Click;
            // 
            // sleepButton
            // 
            sleepButton.Location = new Point(391, 351);
            sleepButton.Name = "sleepButton";
            sleepButton.Size = new Size(75, 23);
            sleepButton.TabIndex = 2;
            sleepButton.Text = "Sleep";
            sleepButton.UseVisualStyleBackColor = true;
            sleepButton.Click += SleepButton_Click;
            // 
            // petPictureBox
            // 
            petPictureBox.Location = new Point(102, 85);
            petPictureBox.Name = "petPictureBox";
            petPictureBox.Size = new Size(364, 184);
            petPictureBox.TabIndex = 3;
            petPictureBox.TabStop = false;
            // 
            // hungerLabel
            // 
            hungerLabel.AutoSize = true;
            hungerLabel.Location = new Point(498, 85);
            hungerLabel.Name = "hungerLabel";
            hungerLabel.Size = new Size(38, 15);
            hungerLabel.TabIndex = 4;
            hungerLabel.Text = "label1";
            // 
            // happinessLabel
            // 
            happinessLabel.AutoSize = true;
            happinessLabel.Location = new Point(498, 122);
            happinessLabel.Name = "happinessLabel";
            happinessLabel.Size = new Size(38, 15);
            happinessLabel.TabIndex = 5;
            happinessLabel.Text = "label2";
            // 
            // energyLabel
            // 
            energyLabel.AutoSize = true;
            energyLabel.Location = new Point(498, 158);
            energyLabel.Name = "energyLabel";
            energyLabel.Size = new Size(38, 15);
            energyLabel.TabIndex = 6;
            energyLabel.Text = "label3";
            // 
            // bioButton
            // 
            bioButton.Location = new Point(30, 22);
            bioButton.Name = "bioButton";
            bioButton.Size = new Size(75, 23);
            bioButton.TabIndex = 7;
            bioButton.Text = "View Bio";
            bioButton.UseVisualStyleBackColor = true;
            bioButton.Click += BioButton_Click;
            // 
            // MainForm
            // 
            ClientSize = new Size(624, 441);
            Controls.Add(bioButton);
            Controls.Add(energyLabel);
            Controls.Add(happinessLabel);
            Controls.Add(hungerLabel);
            Controls.Add(petPictureBox);
            Controls.Add(sleepButton);
            Controls.Add(playButton);
            Controls.Add(feedButton);
            Name = "MainForm";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)petPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }
    }
}