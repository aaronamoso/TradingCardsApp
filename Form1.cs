using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace TradingCardsApp
{
    public partial class Form1 : Form
    {
        public BindingList<Player> Players { get; set; }

        public Form1()
        {
            InitializeComponent();
            Players = PlayerData.Players; // Bind to existing static data
            listBoxPlayers.DataSource = Players;
            listBoxPlayers.DisplayMember = "Name";

            // Set up data bindings for UI elements
            labelPlayerName.DataBindings.Add("Text", Players, "Name");
            labelPlayerTeam.DataBindings.Add("Text", Players, "Team");
            labelPlayerStats.DataBindings.Add("Text", Players, "Stat1");
            pictureBoxPlayer.DataBindings.Add("Image", Players, "PhotoPath", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void listBoxPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPlayers.SelectedItem is Player selectedPlayer)
            {
                try
                {
                    // Combine the application's startup path with the relative image path
                    string imagePath = Path.Combine(Application.StartupPath, selectedPlayer.PhotoPath);

                    // Load the image into the PictureBox
                    pictureBoxPlayer.Load(imagePath); // Use PictureBox.Load method
                    Console.WriteLine(imagePath); // Optional debug log
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show($"Image file not found: {selectedPlayer.PhotoPath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Set the card color based on team
                SetCardColor(selectedPlayer);
            }
        }

        private void SetCardColor(Player player)
        {
            if (player.Team == "Lakers")
                panelCard.BackColor = Color.Yellow;
            else if (player.Team == "Warriors")
                panelCard.BackColor = Color.LightBlue;
            else
                panelCard.BackColor = Color.LightGreen;
        }

        private void buttonAddPlayer_Click(object sender, EventArgs e)
        {
            Player newPlayer = new Player
            {
                Name = "New Player",
                Team = "Team C",
                PhotoPath = "images/default.jpg",
                Stat1 = 10,
                Stat2 = 5,
                Stat3 = 7,
                Stat4 = 3
            };

            // Add the new player to the player list (BindingList automatically updates the UI)
            Players.Add(newPlayer); // No need for explicit data refresh
        }

        private void buttonRemovePlayer_Click(object sender, EventArgs e)
        {
            if (listBoxPlayers.SelectedItem is Player selectedPlayer)
            {
                Players.Remove(selectedPlayer); // BindingList updates UI automatically
            }
        }
    }
}
