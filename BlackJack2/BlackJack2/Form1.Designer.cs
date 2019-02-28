namespace BlackJack2
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
            this.P1HitButton = new System.Windows.Forms.Button();
            this.P1StandButton = new System.Windows.Forms.Button();
            this.PlayerOneListBox = new System.Windows.Forms.ListBox();
            this.PlayerOneScoreBox = new System.Windows.Forms.TextBox();
            this.PlayerTwoScoreBox = new System.Windows.Forms.TextBox();
            this.PlayerTwoListBox = new System.Windows.Forms.ListBox();
            this.P2StandButton = new System.Windows.Forms.Button();
            this.P2HitButton = new System.Windows.Forms.Button();
            this.PlayerThreeScoreBox = new System.Windows.Forms.TextBox();
            this.PlayerThreeListBox = new System.Windows.Forms.ListBox();
            this.P3StandButton = new System.Windows.Forms.Button();
            this.P3HitButton = new System.Windows.Forms.Button();
            this.PlayerFourScoreBox = new System.Windows.Forms.TextBox();
            this.PlayerFourListBox = new System.Windows.Forms.ListBox();
            this.P4StandButton = new System.Windows.Forms.Button();
            this.P4HitButton = new System.Windows.Forms.Button();
            this.DealerScoreBox = new System.Windows.Forms.TextBox();
            this.DealerListBox = new System.Windows.Forms.ListBox();
            this.DealerStartButton = new System.Windows.Forms.Button();
            this.DealerLabel = new System.Windows.Forms.Label();
            this.AddPlayerTextBox = new System.Windows.Forms.TextBox();
            this.AddPlayerLabel = new System.Windows.Forms.Label();
            this.AddPlayerButton = new System.Windows.Forms.Button();
            this.PlayerOneNameTextBox = new System.Windows.Forms.TextBox();
            this.PlayerFourNameTextBox = new System.Windows.Forms.TextBox();
            this.PlayerThreeNameTextBox = new System.Windows.Forms.TextBox();
            this.PlayerTwoNameTextBox = new System.Windows.Forms.TextBox();
            this.DealButton = new System.Windows.Forms.Button();
            this.FinishedAddingPlayersButton = new System.Windows.Forms.Button();
            this.DealerContinueButton = new System.Windows.Forms.Button();
            this.P1MoneyBox = new System.Windows.Forms.TextBox();
            this.P2MoneyBox = new System.Windows.Forms.TextBox();
            this.P3MoneyBox = new System.Windows.Forms.TextBox();
            this.P4MoneyBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.NewGameButton = new System.Windows.Forms.Button();
            this.NewRoundButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // P1HitButton
            // 
            this.P1HitButton.Enabled = false;
            this.P1HitButton.Location = new System.Drawing.Point(0, 163);
            this.P1HitButton.Name = "P1HitButton";
            this.P1HitButton.Size = new System.Drawing.Size(75, 23);
            this.P1HitButton.TabIndex = 1;
            this.P1HitButton.Text = "Hit";
            this.P1HitButton.UseVisualStyleBackColor = true;
            this.P1HitButton.Click += new System.EventHandler(this.P1HitButton_Click);
            // 
            // P1StandButton
            // 
            this.P1StandButton.Enabled = false;
            this.P1StandButton.Location = new System.Drawing.Point(81, 163);
            this.P1StandButton.Name = "P1StandButton";
            this.P1StandButton.Size = new System.Drawing.Size(75, 23);
            this.P1StandButton.TabIndex = 2;
            this.P1StandButton.Text = "Stand";
            this.P1StandButton.UseVisualStyleBackColor = true;
            this.P1StandButton.Click += new System.EventHandler(this.P1StandButton_Click);
            // 
            // PlayerOneListBox
            // 
            this.PlayerOneListBox.FormattingEnabled = true;
            this.PlayerOneListBox.Location = new System.Drawing.Point(22, 32);
            this.PlayerOneListBox.Name = "PlayerOneListBox";
            this.PlayerOneListBox.Size = new System.Drawing.Size(125, 56);
            this.PlayerOneListBox.TabIndex = 3;
            // 
            // PlayerOneScoreBox
            // 
            this.PlayerOneScoreBox.Location = new System.Drawing.Point(81, 94);
            this.PlayerOneScoreBox.Name = "PlayerOneScoreBox";
            this.PlayerOneScoreBox.ReadOnly = true;
            this.PlayerOneScoreBox.Size = new System.Drawing.Size(56, 20);
            this.PlayerOneScoreBox.TabIndex = 4;
            // 
            // PlayerTwoScoreBox
            // 
            this.PlayerTwoScoreBox.Location = new System.Drawing.Point(254, 94);
            this.PlayerTwoScoreBox.Name = "PlayerTwoScoreBox";
            this.PlayerTwoScoreBox.Size = new System.Drawing.Size(56, 20);
            this.PlayerTwoScoreBox.TabIndex = 9;
            // 
            // PlayerTwoListBox
            // 
            this.PlayerTwoListBox.FormattingEnabled = true;
            this.PlayerTwoListBox.Location = new System.Drawing.Point(197, 32);
            this.PlayerTwoListBox.Name = "PlayerTwoListBox";
            this.PlayerTwoListBox.Size = new System.Drawing.Size(125, 56);
            this.PlayerTwoListBox.TabIndex = 8;
            // 
            // P2StandButton
            // 
            this.P2StandButton.Enabled = false;
            this.P2StandButton.Location = new System.Drawing.Point(254, 163);
            this.P2StandButton.Name = "P2StandButton";
            this.P2StandButton.Size = new System.Drawing.Size(75, 23);
            this.P2StandButton.TabIndex = 7;
            this.P2StandButton.Text = "Stand";
            this.P2StandButton.UseVisualStyleBackColor = true;
            this.P2StandButton.Click += new System.EventHandler(this.P2StandButton_Click);
            // 
            // P2HitButton
            // 
            this.P2HitButton.Enabled = false;
            this.P2HitButton.Location = new System.Drawing.Point(173, 163);
            this.P2HitButton.Name = "P2HitButton";
            this.P2HitButton.Size = new System.Drawing.Size(75, 23);
            this.P2HitButton.TabIndex = 6;
            this.P2HitButton.Text = "Hit";
            this.P2HitButton.UseVisualStyleBackColor = true;
            this.P2HitButton.Click += new System.EventHandler(this.P2HitButton_Click);
            // 
            // PlayerThreeScoreBox
            // 
            this.PlayerThreeScoreBox.Location = new System.Drawing.Point(427, 94);
            this.PlayerThreeScoreBox.Name = "PlayerThreeScoreBox";
            this.PlayerThreeScoreBox.Size = new System.Drawing.Size(56, 20);
            this.PlayerThreeScoreBox.TabIndex = 14;
            // 
            // PlayerThreeListBox
            // 
            this.PlayerThreeListBox.FormattingEnabled = true;
            this.PlayerThreeListBox.Location = new System.Drawing.Point(370, 32);
            this.PlayerThreeListBox.Name = "PlayerThreeListBox";
            this.PlayerThreeListBox.Size = new System.Drawing.Size(125, 56);
            this.PlayerThreeListBox.TabIndex = 13;
            // 
            // P3StandButton
            // 
            this.P3StandButton.Enabled = false;
            this.P3StandButton.Location = new System.Drawing.Point(427, 163);
            this.P3StandButton.Name = "P3StandButton";
            this.P3StandButton.Size = new System.Drawing.Size(75, 23);
            this.P3StandButton.TabIndex = 12;
            this.P3StandButton.Text = "Stand";
            this.P3StandButton.UseVisualStyleBackColor = true;
            this.P3StandButton.Click += new System.EventHandler(this.P3StandButton_Click);
            // 
            // P3HitButton
            // 
            this.P3HitButton.Enabled = false;
            this.P3HitButton.Location = new System.Drawing.Point(346, 163);
            this.P3HitButton.Name = "P3HitButton";
            this.P3HitButton.Size = new System.Drawing.Size(75, 23);
            this.P3HitButton.TabIndex = 11;
            this.P3HitButton.Text = "Hit";
            this.P3HitButton.UseVisualStyleBackColor = true;
            this.P3HitButton.Click += new System.EventHandler(this.P3HitButton_Click);
            // 
            // PlayerFourScoreBox
            // 
            this.PlayerFourScoreBox.Location = new System.Drawing.Point(610, 94);
            this.PlayerFourScoreBox.Name = "PlayerFourScoreBox";
            this.PlayerFourScoreBox.Size = new System.Drawing.Size(56, 20);
            this.PlayerFourScoreBox.TabIndex = 19;
            // 
            // PlayerFourListBox
            // 
            this.PlayerFourListBox.FormattingEnabled = true;
            this.PlayerFourListBox.Location = new System.Drawing.Point(554, 32);
            this.PlayerFourListBox.Name = "PlayerFourListBox";
            this.PlayerFourListBox.Size = new System.Drawing.Size(125, 56);
            this.PlayerFourListBox.TabIndex = 18;
            // 
            // P4StandButton
            // 
            this.P4StandButton.Enabled = false;
            this.P4StandButton.Location = new System.Drawing.Point(614, 163);
            this.P4StandButton.Name = "P4StandButton";
            this.P4StandButton.Size = new System.Drawing.Size(75, 23);
            this.P4StandButton.TabIndex = 17;
            this.P4StandButton.Text = "Stand";
            this.P4StandButton.UseVisualStyleBackColor = true;
            this.P4StandButton.Click += new System.EventHandler(this.P4StandButton_Click);
            // 
            // P4HitButton
            // 
            this.P4HitButton.Enabled = false;
            this.P4HitButton.Location = new System.Drawing.Point(533, 163);
            this.P4HitButton.Name = "P4HitButton";
            this.P4HitButton.Size = new System.Drawing.Size(75, 23);
            this.P4HitButton.TabIndex = 16;
            this.P4HitButton.Text = "Hit";
            this.P4HitButton.UseVisualStyleBackColor = true;
            this.P4HitButton.Click += new System.EventHandler(this.P4HitButton_Click);
            // 
            // DealerScoreBox
            // 
            this.DealerScoreBox.Location = new System.Drawing.Point(337, 375);
            this.DealerScoreBox.Name = "DealerScoreBox";
            this.DealerScoreBox.Size = new System.Drawing.Size(56, 20);
            this.DealerScoreBox.TabIndex = 24;
            // 
            // DealerListBox
            // 
            this.DealerListBox.FormattingEnabled = true;
            this.DealerListBox.Location = new System.Drawing.Point(297, 302);
            this.DealerListBox.Name = "DealerListBox";
            this.DealerListBox.Size = new System.Drawing.Size(125, 56);
            this.DealerListBox.TabIndex = 23;
            // 
            // DealerStartButton
            // 
            this.DealerStartButton.Enabled = false;
            this.DealerStartButton.Location = new System.Drawing.Point(309, 398);
            this.DealerStartButton.Name = "DealerStartButton";
            this.DealerStartButton.Size = new System.Drawing.Size(99, 26);
            this.DealerStartButton.TabIndex = 21;
            this.DealerStartButton.Text = "Start Dealer Turn";
            this.DealerStartButton.UseVisualStyleBackColor = true;
            this.DealerStartButton.Click += new System.EventHandler(this.DealerStartButton_Click);
            // 
            // DealerLabel
            // 
            this.DealerLabel.AutoSize = true;
            this.DealerLabel.Location = new System.Drawing.Point(334, 286);
            this.DealerLabel.Name = "DealerLabel";
            this.DealerLabel.Size = new System.Drawing.Size(38, 13);
            this.DealerLabel.TabIndex = 20;
            this.DealerLabel.Text = "Dealer";
            // 
            // AddPlayerTextBox
            // 
            this.AddPlayerTextBox.Location = new System.Drawing.Point(604, 337);
            this.AddPlayerTextBox.Name = "AddPlayerTextBox";
            this.AddPlayerTextBox.Size = new System.Drawing.Size(100, 20);
            this.AddPlayerTextBox.TabIndex = 25;
            // 
            // AddPlayerLabel
            // 
            this.AddPlayerLabel.AutoSize = true;
            this.AddPlayerLabel.Location = new System.Drawing.Point(611, 321);
            this.AddPlayerLabel.Name = "AddPlayerLabel";
            this.AddPlayerLabel.Size = new System.Drawing.Size(55, 13);
            this.AddPlayerLabel.TabIndex = 26;
            this.AddPlayerLabel.Text = "AddPlayer";
            // 
            // AddPlayerButton
            // 
            this.AddPlayerButton.Enabled = false;
            this.AddPlayerButton.Location = new System.Drawing.Point(614, 372);
            this.AddPlayerButton.Name = "AddPlayerButton";
            this.AddPlayerButton.Size = new System.Drawing.Size(75, 23);
            this.AddPlayerButton.TabIndex = 27;
            this.AddPlayerButton.Text = "Add";
            this.AddPlayerButton.UseVisualStyleBackColor = true;
            this.AddPlayerButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AddPlayerButton_MouseClick);
            // 
            // PlayerOneNameTextBox
            // 
            this.PlayerOneNameTextBox.Location = new System.Drawing.Point(57, 6);
            this.PlayerOneNameTextBox.Name = "PlayerOneNameTextBox";
            this.PlayerOneNameTextBox.ReadOnly = true;
            this.PlayerOneNameTextBox.Size = new System.Drawing.Size(56, 20);
            this.PlayerOneNameTextBox.TabIndex = 28;
            // 
            // PlayerFourNameTextBox
            // 
            this.PlayerFourNameTextBox.Location = new System.Drawing.Point(590, 6);
            this.PlayerFourNameTextBox.Name = "PlayerFourNameTextBox";
            this.PlayerFourNameTextBox.ReadOnly = true;
            this.PlayerFourNameTextBox.Size = new System.Drawing.Size(56, 20);
            this.PlayerFourNameTextBox.TabIndex = 29;
            // 
            // PlayerThreeNameTextBox
            // 
            this.PlayerThreeNameTextBox.Location = new System.Drawing.Point(403, 6);
            this.PlayerThreeNameTextBox.Name = "PlayerThreeNameTextBox";
            this.PlayerThreeNameTextBox.ReadOnly = true;
            this.PlayerThreeNameTextBox.Size = new System.Drawing.Size(56, 20);
            this.PlayerThreeNameTextBox.TabIndex = 30;
            // 
            // PlayerTwoNameTextBox
            // 
            this.PlayerTwoNameTextBox.Location = new System.Drawing.Point(230, 6);
            this.PlayerTwoNameTextBox.Name = "PlayerTwoNameTextBox";
            this.PlayerTwoNameTextBox.ReadOnly = true;
            this.PlayerTwoNameTextBox.Size = new System.Drawing.Size(56, 20);
            this.PlayerTwoNameTextBox.TabIndex = 31;
            // 
            // DealButton
            // 
            this.DealButton.Enabled = false;
            this.DealButton.Location = new System.Drawing.Point(323, 238);
            this.DealButton.Name = "DealButton";
            this.DealButton.Size = new System.Drawing.Size(75, 23);
            this.DealButton.TabIndex = 32;
            this.DealButton.Text = "Deal";
            this.DealButton.UseVisualStyleBackColor = true;
            this.DealButton.Click += new System.EventHandler(this.DealButton_Click);
            // 
            // FinishedAddingPlayersButton
            // 
            this.FinishedAddingPlayersButton.Enabled = false;
            this.FinishedAddingPlayersButton.Location = new System.Drawing.Point(599, 419);
            this.FinishedAddingPlayersButton.Name = "FinishedAddingPlayersButton";
            this.FinishedAddingPlayersButton.Size = new System.Drawing.Size(105, 34);
            this.FinishedAddingPlayersButton.TabIndex = 33;
            this.FinishedAddingPlayersButton.Text = "Finished Adding Players";
            this.FinishedAddingPlayersButton.UseVisualStyleBackColor = true;
            this.FinishedAddingPlayersButton.Click += new System.EventHandler(this.FinishedAddingPlayersButton_Click);
            // 
            // DealerContinueButton
            // 
            this.DealerContinueButton.Enabled = false;
            this.DealerContinueButton.Location = new System.Drawing.Point(323, 430);
            this.DealerContinueButton.Name = "DealerContinueButton";
            this.DealerContinueButton.Size = new System.Drawing.Size(75, 23);
            this.DealerContinueButton.TabIndex = 34;
            this.DealerContinueButton.Text = "Continue";
            this.DealerContinueButton.UseVisualStyleBackColor = true;
            this.DealerContinueButton.Click += new System.EventHandler(this.DealerContinueButton_Click);
            // 
            // P1MoneyBox
            // 
            this.P1MoneyBox.Location = new System.Drawing.Point(81, 121);
            this.P1MoneyBox.Name = "P1MoneyBox";
            this.P1MoneyBox.Size = new System.Drawing.Size(56, 20);
            this.P1MoneyBox.TabIndex = 35;
            // 
            // P2MoneyBox
            // 
            this.P2MoneyBox.Location = new System.Drawing.Point(254, 121);
            this.P2MoneyBox.Name = "P2MoneyBox";
            this.P2MoneyBox.Size = new System.Drawing.Size(56, 20);
            this.P2MoneyBox.TabIndex = 36;
            // 
            // P3MoneyBox
            // 
            this.P3MoneyBox.Location = new System.Drawing.Point(427, 121);
            this.P3MoneyBox.Name = "P3MoneyBox";
            this.P3MoneyBox.Size = new System.Drawing.Size(56, 20);
            this.P3MoneyBox.TabIndex = 37;
            // 
            // P4MoneyBox
            // 
            this.P4MoneyBox.Location = new System.Drawing.Point(610, 121);
            this.P4MoneyBox.Name = "P4MoneyBox";
            this.P4MoneyBox.Size = new System.Drawing.Size(56, 20);
            this.P4MoneyBox.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Score";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Money";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Money";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(213, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Score";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(382, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Money";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(386, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Score";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(565, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "Money";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(569, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 46;
            this.label9.Text = "Score";
            // 
            // NewGameButton
            // 
            this.NewGameButton.Location = new System.Drawing.Point(610, 276);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.Size = new System.Drawing.Size(75, 23);
            this.NewGameButton.TabIndex = 48;
            this.NewGameButton.Text = "New Game";
            this.NewGameButton.UseVisualStyleBackColor = true;
            this.NewGameButton.Click += new System.EventHandler(this.NewGameButton_Click);
            // 
            // NewRoundButton
            // 
            this.NewRoundButton.Location = new System.Drawing.Point(496, 276);
            this.NewRoundButton.Name = "NewRoundButton";
            this.NewRoundButton.Size = new System.Drawing.Size(75, 23);
            this.NewRoundButton.TabIndex = 49;
            this.NewRoundButton.Text = "New Round";
            this.NewRoundButton.UseVisualStyleBackColor = true;
            this.NewRoundButton.Click += new System.EventHandler(this.NewRoundButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(574, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "< or >";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(641, 398);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 13);
            this.label10.TabIndex = 51;
            this.label10.Text = "or";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 482);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NewRoundButton);
            this.Controls.Add(this.NewGameButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.P4MoneyBox);
            this.Controls.Add(this.P3MoneyBox);
            this.Controls.Add(this.P2MoneyBox);
            this.Controls.Add(this.P1MoneyBox);
            this.Controls.Add(this.DealerContinueButton);
            this.Controls.Add(this.FinishedAddingPlayersButton);
            this.Controls.Add(this.DealButton);
            this.Controls.Add(this.PlayerTwoNameTextBox);
            this.Controls.Add(this.PlayerThreeNameTextBox);
            this.Controls.Add(this.PlayerFourNameTextBox);
            this.Controls.Add(this.PlayerOneNameTextBox);
            this.Controls.Add(this.AddPlayerButton);
            this.Controls.Add(this.AddPlayerLabel);
            this.Controls.Add(this.AddPlayerTextBox);
            this.Controls.Add(this.DealerScoreBox);
            this.Controls.Add(this.DealerListBox);
            this.Controls.Add(this.DealerStartButton);
            this.Controls.Add(this.DealerLabel);
            this.Controls.Add(this.PlayerFourScoreBox);
            this.Controls.Add(this.PlayerFourListBox);
            this.Controls.Add(this.P4StandButton);
            this.Controls.Add(this.P4HitButton);
            this.Controls.Add(this.PlayerThreeScoreBox);
            this.Controls.Add(this.PlayerThreeListBox);
            this.Controls.Add(this.P3StandButton);
            this.Controls.Add(this.P3HitButton);
            this.Controls.Add(this.PlayerTwoScoreBox);
            this.Controls.Add(this.PlayerTwoListBox);
            this.Controls.Add(this.P2StandButton);
            this.Controls.Add(this.P2HitButton);
            this.Controls.Add(this.PlayerOneScoreBox);
            this.Controls.Add(this.PlayerOneListBox);
            this.Controls.Add(this.P1StandButton);
            this.Controls.Add(this.P1HitButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button P1HitButton;
        private System.Windows.Forms.Button P1StandButton;
        private System.Windows.Forms.ListBox PlayerOneListBox;
        private System.Windows.Forms.TextBox PlayerOneScoreBox;
        private System.Windows.Forms.TextBox PlayerTwoScoreBox;
        private System.Windows.Forms.ListBox PlayerTwoListBox;
        private System.Windows.Forms.Button P2StandButton;
        private System.Windows.Forms.Button P2HitButton;
        private System.Windows.Forms.TextBox PlayerThreeScoreBox;
        private System.Windows.Forms.ListBox PlayerThreeListBox;
        private System.Windows.Forms.Button P3StandButton;
        private System.Windows.Forms.Button P3HitButton;
        private System.Windows.Forms.TextBox PlayerFourScoreBox;
        private System.Windows.Forms.ListBox PlayerFourListBox;
        private System.Windows.Forms.Button P4StandButton;
        private System.Windows.Forms.Button P4HitButton;
        private System.Windows.Forms.TextBox DealerScoreBox;
        private System.Windows.Forms.ListBox DealerListBox;
        private System.Windows.Forms.Button DealerStartButton;
        private System.Windows.Forms.Label DealerLabel;
        private System.Windows.Forms.TextBox AddPlayerTextBox;
        private System.Windows.Forms.Label AddPlayerLabel;
        private System.Windows.Forms.Button AddPlayerButton;
        private System.Windows.Forms.TextBox PlayerOneNameTextBox;
        private System.Windows.Forms.TextBox PlayerFourNameTextBox;
        private System.Windows.Forms.TextBox PlayerThreeNameTextBox;
        private System.Windows.Forms.TextBox PlayerTwoNameTextBox;
        private System.Windows.Forms.Button DealButton;
        private System.Windows.Forms.Button FinishedAddingPlayersButton;
        private System.Windows.Forms.Button DealerContinueButton;
        private System.Windows.Forms.TextBox P1MoneyBox;
        private System.Windows.Forms.TextBox P2MoneyBox;
        private System.Windows.Forms.TextBox P3MoneyBox;
        private System.Windows.Forms.TextBox P4MoneyBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button NewGameButton;
        private System.Windows.Forms.Button NewRoundButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
    }
}

