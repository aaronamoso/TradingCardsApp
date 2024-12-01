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
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).BeginInit();
            this.panelCard.SuspendLayout();
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
            this.pictureBoxPlayer.BackColor = System.Drawing.Color.LightGray;
            this.pictureBoxPlayer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPlayer.Location = new System.Drawing.Point(167, 36);
            this.pictureBoxPlayer.Name = "pictureBoxPlayer";
            this.pictureBoxPlayer.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPlayer.TabIndex = 1;
            this.pictureBoxPlayer.TabStop = false;
            // 
            // labelPlayerName
            // 
            this.labelPlayerName.AutoSize = true;
            this.labelPlayerName.Location = new System.Drawing.Point(68, 205);
            this.labelPlayerName.Name = "labelPlayerName";
            this.labelPlayerName.Size = new System.Drawing.Size(35, 13);
            this.labelPlayerName.TabIndex = 2;
            this.labelPlayerName.Text = "label1";
            // 
            // labelPlayerTeam
            // 
            this.labelPlayerTeam.AutoSize = true;
            this.labelPlayerTeam.Location = new System.Drawing.Point(68, 225);
            this.labelPlayerTeam.Name = "labelPlayerTeam";
            this.labelPlayerTeam.Size = new System.Drawing.Size(35, 13);
            this.labelPlayerTeam.TabIndex = 3;
            this.labelPlayerTeam.Text = "label1";
            // 
            // labelPlayerStats
            // 
            this.labelPlayerStats.AutoSize = true;
            this.labelPlayerStats.Location = new System.Drawing.Point(68, 245);
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
            this.panelCard.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCard.Controls.Add(this.label10);
            this.panelCard.Controls.Add(this.label5);
            this.panelCard.Controls.Add(this.label8);
            this.panelCard.Controls.Add(this.pictureBoxPlayer);
            this.panelCard.Controls.Add(this.label6);
            this.panelCard.Controls.Add(this.label7);
            this.panelCard.Controls.Add(this.label4);
            this.panelCard.Controls.Add(this.label1);
            this.panelCard.Controls.Add(this.labelPlayerName);
            this.panelCard.Controls.Add(this.label3);
            this.panelCard.Controls.Add(this.labelPlayerTeam);
            this.panelCard.Controls.Add(this.labelPlayerStats);
            this.panelCard.Location = new System.Drawing.Point(244, 12);
            this.panelCard.Name = "panelCard";
            this.panelCard.Size = new System.Drawing.Size(376, 290);
            this.panelCard.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "BACKGROUND:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "STATS: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "BUCKS: Green";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "WARRIORS: Blue";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "label1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "TEAM: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "LAKERS: Yellow";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "NAME: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(654, 450);
            this.Controls.Add(this.panelCard);
            this.Controls.Add(this.buttonRemovePlayer);
            this.Controls.Add(this.buttonAddPlayer);
            this.Controls.Add(this.listBoxPlayers);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).EndInit();
            this.panelCard.ResumeLayout(false);
            this.panelCard.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
    }
}

