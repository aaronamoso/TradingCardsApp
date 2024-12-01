using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradingCardsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

            // Optionally log the path for debugging
            Console.WriteLine(imagePath);
        }
        catch (FileNotFoundException ex)
        {
            MessageBox.Show($"Image file not found: {selectedPlayer.PhotoPath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        labelPlayerName.Text = selectedPlayer.Name;
        labelPlayerTeam.Text = selectedPlayer.Team;
        labelPlayerStats.Text = $"Points: {selectedPlayer.Stat1}, Assists: {selectedPlayer.Stat2}, Rebounds: {selectedPlayer.Stat3}, Steals: {selectedPlayer.Stat4}";
        SetCardColor(selectedPlayer);
    }
        }

        private void SetCardColor(Player player)
        {
            // Change border color based on team
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
            // Add the new player to the player list
            PlayerData.AddPlayer(newPlayer);

            // Refresh the player list
            RefreshPlayerList();
        }

        private void buttonRemovePlayer_Click(object sender, EventArgs e)
        {
            if (listBoxPlayers.SelectedItem is Player selectedPlayer)
            {
                PlayerData.RemovePlayer(selectedPlayer);
                RefreshPlayerList();
            }
        }
        private void RefreshPlayerList()
        {
            listBoxPlayers.DataSource = null;
            listBoxPlayers.DataSource = PlayerData.Players;
            listBoxPlayers.DisplayMember = "Name";
        }

        private void panelCard_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
