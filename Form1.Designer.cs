namespace TradingCardsApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxPlayers = new System.Windows.Forms.ListBox();
            this.pictureBoxPlayer = new System.Windows.Forms.PictureBox();
            this.labelPlayerName = new System.Windows.Forms.Label();
            this.labelPlayerTeam = new System.Windows.Forms.Label();
            this.labelPlayerStats = new System.Windows.Forms.Label();
            this.buttonAddPlayer = new System.Windows.Forms.Button();
            this.buttonRemovePlayer = new System.Windows.Forms.Button();
            this.panelCard = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxPlayers
            // 
            this.listBoxPlayers.FormattingEnabled = true;
            this.listBoxPlayers.Location = new System.Drawing.Point(12, 12);
            this.listBoxPlayers.Name = "listBoxPlayers";
            this.listBoxPlayers.Size = new System.Drawing.Size(200, 290);
            this.listBoxPlayers.TabIndex = 0;
            this.listBoxPlayers.SelectedIndexChanged += new System.EventHandler(this.listBoxPlayers_SelectedIndexChanged);
            // 
            // pictureBoxPlayer
            // 
            this.pictureBoxPlayer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPlayer.Location = new System.Drawing.Point(220, 12);
            this.pictureBoxPlayer.Name = "pictureBoxPlayer";
            this.pictureBoxPlayer.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxPlayer.TabIndex = 1;
            this.pictureBoxPlayer.TabStop = false;
            // 
            // labelPlayerName
            // 
            this.labelPlayerName.AutoSize = true;
            this.labelPlayerName.Location = new System.Drawing.Point(220, 170);
            this.labelPlayerName.Name = "labelPlayerName";
            this.labelPlayerName.Size = new System.Drawing.Size(35, 13);
            this.labelPlayerName.TabIndex = 2;
            this.labelPlayerName.Text = "label1";
            // 
            // labelPlayerTeam
            // 
            this.labelPlayerTeam.AutoSize = true;
            this.labelPlayerTeam.Location = new System.Drawing.Point(220, 190);
            this.labelPlayerTeam.Name = "labelPlayerTeam";
            this.labelPlayerTeam.Size = new System.Drawing.Size(35, 13);
            this.labelPlayerTeam.TabIndex = 3;
            this.labelPlayerTeam.Text = "label1";
            // 
            // labelPlayerStats
            // 
            this.labelPlayerStats.AutoSize = true;
            this.labelPlayerStats.Location = new System.Drawing.Point(220, 210);
            this.labelPlayerStats.Name = "labelPlayerStats";
            this.labelPlayerStats.Size = new System.Drawing.Size(35, 13);
            this.labelPlayerStats.TabIndex = 4;
            this.labelPlayerStats.Text = "label1";
            // 
            // buttonAddPlayer
            // 
            this.buttonAddPlayer.Location = new System.Drawing.Point(12, 320);
            this.buttonAddPlayer.Name = "buttonAddPlayer";
            this.buttonAddPlayer.Size = new System.Drawing.Size(75, 30);
            this.buttonAddPlayer.TabIndex = 5;
            this.buttonAddPlayer.Text = "Add Player";
            this.buttonAddPlayer.UseVisualStyleBackColor = true;
            this.buttonAddPlayer.Click += new System.EventHandler(this.buttonAddPlayer_Click);
            // 
            // buttonRemovePlayer
            // 
            this.buttonRemovePlayer.Location = new System.Drawing.Point(100, 320);
            this.buttonRemovePlayer.Name = "buttonRemovePlayer";
            this.buttonRemovePlayer.Size = new System.Drawing.Size(100, 30);
            this.buttonRemovePlayer.TabIndex = 6;
            this.buttonRemovePlayer.Text = "Remove Player";
            this.buttonRemovePlayer.UseVisualStyleBackColor = true;
            this.buttonRemovePlayer.Click += new System.EventHandler(this.buttonRemovePlayer_Click);
            // 
            // panelCard
            // 
            this.panelCard.BackColor = System.Drawing.Color.MediumPurple;
            this.panelCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCard.Location = new System.Drawing.Point(400, 12);
            this.panelCard.Name = "panelCard";
            this.panelCard.Size = new System.Drawing.Size(300, 300);
            this.panelCard.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 450);
            this.Controls.Add(this.panelCard);
            this.Controls.Add(this.buttonRemovePlayer);
            this.Controls.Add(this.buttonAddPlayer);
            this.Controls.Add(this.labelPlayerStats);
            this.Controls.Add(this.labelPlayerTeam);
            this.Controls.Add(this.labelPlayerName);
            this.Controls.Add(this.pictureBoxPlayer);
            this.Controls.Add(this.listBoxPlayers);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPlayers;
        private System.Windows.Forms.PictureBox pictureBoxPlayer;
        private System.Windows.Forms.Label labelPlayerTeam;
        private System.Windows.Forms.Label labelPlayerStats;
        private System.Windows.Forms.Label labelPlayerName;
        private System.Windows.Forms.Button buttonAddPlayer;
        private System.Windows.Forms.Button buttonRemovePlayer;
        private System.Windows.Forms.Panel panelCard;
    }
}

