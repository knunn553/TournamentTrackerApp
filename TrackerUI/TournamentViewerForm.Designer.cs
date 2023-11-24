namespace TrackerUI
{
    partial class TournamentViewerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            headerLabel = new Label();
            tournamentName = new Label();
            roundLabel = new Label();
            roundDropDown = new ComboBox();
            unplayedOnlyCheckbox = new CheckBox();
            matchupListBox = new ListBox();
            teamOneName = new Label();
            teamOneScoreLabel = new Label();
            teamOneScoreValue = new TextBox();
            teamTwoScoreValue = new TextBox();
            teamTwoScoreLabel = new Label();
            teamTwoNameLabel = new Label();
            submitFinalScoreButton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Location = new Point(12, 9);
            headerLabel.Margin = new Padding(2, 0, 2, 0);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(372, 53);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "TournamentTracker";
            headerLabel.Click += label1_Click;
            // 
            // tournamentName
            // 
            tournamentName.AutoSize = true;
            tournamentName.Location = new Point(11, 62);
            tournamentName.Margin = new Padding(2, 0, 2, 0);
            tournamentName.Name = "tournamentName";
            tournamentName.Size = new Size(168, 53);
            tournamentName.TabIndex = 1;
            tournamentName.Text = "<name>";
            // 
            // roundLabel
            // 
            roundLabel.AutoSize = true;
            roundLabel.Font = new Font("Impact", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            roundLabel.Location = new Point(11, 161);
            roundLabel.Name = "roundLabel";
            roundLabel.Size = new Size(134, 53);
            roundLabel.TabIndex = 2;
            roundLabel.Text = "Round";
            // 
            // roundDropDown
            // 
            roundDropDown.FormattingEnabled = true;
            roundDropDown.Location = new Point(152, 158);
            roundDropDown.Name = "roundDropDown";
            roundDropDown.Size = new Size(242, 61);
            roundDropDown.TabIndex = 3;
            // 
            // unplayedOnlyCheckbox
            // 
            unplayedOnlyCheckbox.AutoSize = true;
            unplayedOnlyCheckbox.Font = new Font("Impact", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            unplayedOnlyCheckbox.Location = new Point(47, 225);
            unplayedOnlyCheckbox.Name = "unplayedOnlyCheckbox";
            unplayedOnlyCheckbox.Size = new Size(302, 57);
            unplayedOnlyCheckbox.TabIndex = 4;
            unplayedOnlyCheckbox.Text = "Unplayed Only";
            unplayedOnlyCheckbox.UseVisualStyleBackColor = true;
            // 
            // matchupListBox
            // 
            matchupListBox.FormattingEnabled = true;
            matchupListBox.ItemHeight = 53;
            matchupListBox.Location = new Point(12, 288);
            matchupListBox.Name = "matchupListBox";
            matchupListBox.Size = new Size(382, 428);
            matchupListBox.TabIndex = 5;
            // 
            // teamOneName
            // 
            teamOneName.AutoSize = true;
            teamOneName.Font = new Font("Impact", 28.125F, FontStyle.Regular, GraphicsUnit.Point);
            teamOneName.Location = new Point(558, 116);
            teamOneName.Name = "teamOneName";
            teamOneName.Size = new Size(591, 93);
            teamOneName.TabIndex = 6;
            teamOneName.Text = "<team one name>";
            teamOneName.Click += label1_Click_1;
            // 
            // teamOneScoreLabel
            // 
            teamOneScoreLabel.AutoSize = true;
            teamOneScoreLabel.Font = new Font("Impact", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            teamOneScoreLabel.Location = new Point(681, 225);
            teamOneScoreLabel.Name = "teamOneScoreLabel";
            teamOneScoreLabel.Size = new Size(125, 53);
            teamOneScoreLabel.TabIndex = 7;
            teamOneScoreLabel.Text = "Score";
            // 
            // teamOneScoreValue
            // 
            teamOneScoreValue.Location = new Point(812, 222);
            teamOneScoreValue.Name = "teamOneScoreValue";
            teamOneScoreValue.Size = new Size(200, 60);
            teamOneScoreValue.TabIndex = 8;
            // 
            // teamTwoScoreValue
            // 
            teamTwoScoreValue.Location = new Point(812, 439);
            teamTwoScoreValue.Name = "teamTwoScoreValue";
            teamTwoScoreValue.Size = new Size(200, 60);
            teamTwoScoreValue.TabIndex = 11;
            // 
            // teamTwoScoreLabel
            // 
            teamTwoScoreLabel.AutoSize = true;
            teamTwoScoreLabel.Font = new Font("Impact", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            teamTwoScoreLabel.Location = new Point(681, 442);
            teamTwoScoreLabel.Name = "teamTwoScoreLabel";
            teamTwoScoreLabel.Size = new Size(125, 53);
            teamTwoScoreLabel.TabIndex = 10;
            teamTwoScoreLabel.Text = "Score";
            // 
            // teamTwoNameLabel
            // 
            teamTwoNameLabel.AutoSize = true;
            teamTwoNameLabel.Font = new Font("Impact", 28.125F, FontStyle.Regular, GraphicsUnit.Point);
            teamTwoNameLabel.Location = new Point(558, 333);
            teamTwoNameLabel.Name = "teamTwoNameLabel";
            teamTwoNameLabel.Size = new Size(587, 93);
            teamTwoNameLabel.TabIndex = 9;
            teamTwoNameLabel.Text = "<team two name>";
            // 
            // submitFinalScoreButton
            // 
            submitFinalScoreButton.BackColor = SystemColors.ControlLight;
            submitFinalScoreButton.FlatAppearance.BorderColor = Color.Red;
            submitFinalScoreButton.FlatAppearance.MouseDownBackColor = Color.Red;
            submitFinalScoreButton.FlatAppearance.MouseOverBackColor = Color.Gray;
            submitFinalScoreButton.FlatStyle = FlatStyle.Flat;
            submitFinalScoreButton.Location = new Point(548, 576);
            submitFinalScoreButton.Name = "submitFinalScoreButton";
            submitFinalScoreButton.Size = new Size(601, 72);
            submitFinalScoreButton.TabIndex = 12;
            submitFinalScoreButton.Text = "Submit Final Score";
            submitFinalScoreButton.UseVisualStyleBackColor = false;
            // 
            // TournamentViewerForm
            // 
            AutoScaleDimensions = new SizeF(21F, 53F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1292, 745);
            Controls.Add(submitFinalScoreButton);
            Controls.Add(teamTwoScoreValue);
            Controls.Add(teamTwoScoreLabel);
            Controls.Add(teamTwoNameLabel);
            Controls.Add(teamOneScoreValue);
            Controls.Add(teamOneScoreLabel);
            Controls.Add(teamOneName);
            Controls.Add(matchupListBox);
            Controls.Add(unplayedOnlyCheckbox);
            Controls.Add(roundDropDown);
            Controls.Add(roundLabel);
            Controls.Add(tournamentName);
            Controls.Add(headerLabel);
            Font = new Font("Impact", 16.125F, FontStyle.Italic, GraphicsUnit.Point);
            ForeColor = SystemColors.ActiveCaptionText;
            Margin = new Padding(5);
            Name = "TournamentViewerForm";
            Text = "TournamentViewer";
            Load += TournamentViewerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private Label tournamentName;
        private Label roundLabel;
        private ComboBox roundDropDown;
        private CheckBox unplayedOnlyCheckbox;
        private ListBox matchupListBox;
        private Label teamOneName;
        private Label teamOneScoreLabel;
        private TextBox teamOneScoreValue;
        private TextBox teamTwoScoreValue;
        private Label teamTwoScoreLabel;
        private Label teamTwoNameLabel;
        private Button submitFinalScoreButton;
    }
}
