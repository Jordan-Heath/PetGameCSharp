// Pet.cs
using System;
using System.Timers;
using Timer = System.Timers.Timer;

namespace PetGameApp
{
    public class Pet
    {
        private Timer TickTimer;

        private string name;
        private string description;

        private int hunger;
        private int happiness;
        private int energy;

        private int experience;
        private int level;

        private int strength;
        private int dexterity;
        private int constitution;
        private int intelligence;
        private int wisdom;
        private int charisma;

        public event EventHandler OnStatusChanged;

        #region properties

        public bool IsAlive
        {
            get { return Hunger > 0 && Happiness > 0 && Energy > 0; }
        }

        public bool IsHealthy
        {
            get { return Hunger > 50 && Happiness > 50 && Energy > 50; }
        }

        public Image Image
        {
            get
            {
                if (!IsAlive)
                {
                    return Properties.Resources.dead_pet; // Return the image for a dead pet
                } 
                else if (!IsHealthy)
                {
                    return Properties.Resources.sad_pet; // Return the image for a sad pet
                }
                else
                {
                    return Properties.Resources.happy_pet; // Return the image for a happy pet
                }
            }
        }

        public string Name { get { return name; } set { name = value; } }
        public string Description { get { return description; } set { description = value; } }

        public int Hunger
        {
            get { return hunger; }
            private set { hunger = Math.Min(Math.Max(value, 0), 100); } //0 <= X <= 100
        }

        public int Happiness
        {
            get { return happiness; }
            private set { happiness = Math.Min(Math.Max(value, 0), 100); } //0 <= X <= 100
        }

        public int Energy
        {
            get { return energy; }
            private set { energy = Math.Min(Math.Max(value, 0), 100); } //0 <= X <= 100
        }

        public int Experience 
        { 
            get { return experience; } 
            set 
            { 
                experience = value;
                if (experience > level*10) 
                {
                    LevelUp();
                }
            } 
        }
        public int ExperiencePercentage
        {
            get
            {
                double percentage = ((double)Experience / (level * 10)) * 100;
                return (int)percentage;
            }
        }

        public int Level { get { return level; } }

        public int Strength { get => strength;}
        public int Dexterity { get => dexterity; }
        public int Constitution { get => constitution; }
        public int Intelligence { get => intelligence; }
        public int Wisdom { get => wisdom; }
        public int Charisma { get => charisma; }



        #endregion properties

        #region constructor

        public Pet(int initialHunger, int initialHappiness, int initialEnergy)
        {
            name = "Zeus";
            description = "A pesky little friend";

            hunger = initialHunger;
            happiness = initialHappiness;
            energy = initialEnergy;

            experience = 0;
            level = 1;

            // Set up the timer to decay needs every 5 seconds (adjust as needed)
            TickTimer = new Timer(Convert.ToDouble(Properties.Resources.TickTimer));
            TickTimer.Elapsed += TickTimer_Elapsed;
            TickTimer.AutoReset = true;
            TickTimer.Start();
        }

        #endregion constructor

        #region methods

        private void TickTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            // Decay the pet's needs over time
            Hunger -= Convert.ToInt16(Properties.Resources.HungerDecayRate);
            Happiness -= Convert.ToInt16(Properties.Resources.HappinessDecayRate);
            Energy -= Convert.ToInt16(Properties.Resources.EnergyDecayRate);

            //gain experience
            Experience++;

            //update page
            OnStatusChanged?.Invoke(this, EventArgs.Empty);
        }

        public void Feed()
        {
            Hunger += 10;
        }

        public void Play()
        {
            Happiness += 10;
        }

        public void Sleep()
        {
            Energy += 10;
        }

        public void LevelUp()
        {
            experience -= level * 10;
            level++;

            Random random = new Random();

            for (int i = 1; i < level; i++)
            {
                // Generate a random number to determine which attribute to increase
                int randomAttribute = random.Next(1, 7); // Generates a random number between 1 and 6

                // Increase the corresponding attribute based on the random number
                switch (randomAttribute)
                {
                    case 1:
                        strength++;
                        break;
                    case 2:
                        dexterity++;
                        break;
                    case 3:
                        constitution++;
                        break;
                    case 4:
                        intelligence++;
                        break;
                    case 5:
                        wisdom++;
                        break;
                    case 6:
                        charisma++;
                        break;
                    default:
                        // Handle unexpected case
                        break;
                }
            }
        }

        public void Die()
        {
            if (!IsAlive)
            {
                //nullify OnStatusChanged?
                OnStatusChanged = null;
                TickTimer?.Stop();
            }
        }

        #endregion methods
    }
}
