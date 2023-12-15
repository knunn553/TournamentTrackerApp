namespace TrackerUI
{
    partial class CreateTournamentForm
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
            headingLabel = new Label();
            tournamentNameValue = new TextBox();
            tournamentNameLabel = new Label();
            entryFeeValue = new TextBox();
            entryFeeLabel = new Label();
            selectTeamDropDown = new ComboBox();
            selectTeamLabel = new Label();
            createTeamLinkLabel = new LinkLabel();
            addTeamButton = new Button();
            createPrizeButton = new Button();
            createPrizeLabel = new Label();
            tournamentTeamsListBox = new ListBox();
            tournamentPlayersLabel = new Label();
            editPrizesLabel = new Label();
            prizesListBox = new ListBox();
            deleteSelectedPrizeButton = new Button();
            deleteSelectedPlayerButton = new Button();
            createTournamentButton = new Button();
            SuspendLayout();
            // 
            // headingLabel
            // 
            headingLabel.AutoSize = true;
            headingLabel.Font = new Font("Impact", 25.875F, FontStyle.Regular, GraphicsUnit.Point);
            headingLabel.Location = new Point(3, -1);
            headingLabel.Name = "headingLabel";
            headingLabel.Size = new Size(582, 85);
            headingLabel.TabIndex = 7;
            headingLabel.Text = "Create Tournament";
            // 
            // tournamentNameValue
            // 
            tournamentNameValue.Location = new Point(269, 125);
            tournamentNameValue.Name = "tournamentNameValue";
            tournamentNameValue.Size = new Size(376, 53);
            tournamentNameValue.TabIndex = 10;
            // 
            // tournamentNameLabel
            // 
            tournamentNameLabel.AutoSize = true;
            tournamentNameLabel.Font = new Font("Impact", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentNameLabel.Location = new Point(26, 125);
            tournamentNameLabel.Name = "tournamentNameLabel";
            tournamentNameLabel.Size = new Size(132, 53);
            tournamentNameLabel.TabIndex = 9;
            tournamentNameLabel.Text = "Name:";
            // 
            // entryFeeValue
            // 
            entryFeeValue.Location = new Point(269, 216);
            entryFeeValue.Name = "entryFeeValue";
            entryFeeValue.Size = new Size(376, 53);
            entryFeeValue.TabIndex = 12;
            // 
            // entryFeeLabel
            // 
            entryFeeLabel.AutoSize = true;
            entryFeeLabel.Font = new Font("Impact", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            entryFeeLabel.Location = new Point(26, 216);
            entryFeeLabel.Name = "entryFeeLabel";
            entryFeeLabel.Size = new Size(189, 53);
            entryFeeLabel.TabIndex = 11;
            entryFeeLabel.Text = "Entry Fee:";
            // 
            // selectTeamDropDown
            // 
            selectTeamDropDown.FormattingEnabled = true;
            selectTeamDropDown.Location = new Point(269, 312);
            selectTeamDropDown.Name = "selectTeamDropDown";
            selectTeamDropDown.Size = new Size(377, 53);
            selectTeamDropDown.TabIndex = 14;
            selectTeamDropDown.SelectedIndexChanged += selectTeamDropDown_SelectedIndexChanged;
            // 
            // selectTeamLabel
            // 
            selectTeamLabel.AutoSize = true;
            selectTeamLabel.Font = new Font("Impact", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            selectTeamLabel.Location = new Point(26, 312);
            selectTeamLabel.Name = "selectTeamLabel";
            selectTeamLabel.Size = new Size(246, 53);
            selectTeamLabel.TabIndex = 13;
            selectTeamLabel.Text = "Select Team:";
            // 
            // createTeamLinkLabel
            // 
            createTeamLinkLabel.AutoSize = true;
            createTeamLinkLabel.Font = new Font("Impact", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            createTeamLinkLabel.Location = new Point(41, 365);
            createTeamLinkLabel.Name = "createTeamLinkLabel";
            createTeamLinkLabel.Size = new Size(206, 34);
            createTeamLinkLabel.TabIndex = 15;
            createTeamLinkLabel.TabStop = true;
            createTeamLinkLabel.Text = "Create New Team";
            createTeamLinkLabel.LinkClicked += linkLabel1_LinkClicked;
            // 
            // addTeamButton
            // 
            addTeamButton.BackColor = SystemColors.ControlLight;
            addTeamButton.FlatAppearance.BorderColor = Color.Red;
            addTeamButton.FlatAppearance.MouseDownBackColor = Color.Red;
            addTeamButton.FlatAppearance.MouseOverBackColor = Color.Gray;
            addTeamButton.FlatStyle = FlatStyle.Flat;
            addTeamButton.Location = new Point(269, 417);
            addTeamButton.Name = "addTeamButton";
            addTeamButton.Size = new Size(377, 55);
            addTeamButton.TabIndex = 16;
            addTeamButton.Text = "Add Team";
            addTeamButton.UseVisualStyleBackColor = false;
            addTeamButton.Click += addTeamButton_Click;
            // 
            // createPrizeButton
            // 
            createPrizeButton.BackColor = SystemColors.ControlLight;
            createPrizeButton.FlatAppearance.BorderColor = Color.Red;
            createPrizeButton.FlatAppearance.MouseDownBackColor = Color.Red;
            createPrizeButton.FlatAppearance.MouseOverBackColor = Color.Gray;
            createPrizeButton.FlatStyle = FlatStyle.Flat;
            createPrizeButton.Location = new Point(269, 487);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(376, 55);
            createPrizeButton.TabIndex = 17;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = false;
            // 
            // createPrizeLabel
            // 
            createPrizeLabel.AutoSize = true;
            createPrizeLabel.Font = new Font("Impact", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            createPrizeLabel.Location = new Point(26, 489);
            createPrizeLabel.Name = "createPrizeLabel";
            createPrizeLabel.Size = new Size(243, 53);
            createPrizeLabel.TabIndex = 18;
            createPrizeLabel.Text = "Create Prize:";
            // 
            // tournamentTeamsListBox
            // 
            tournamentTeamsListBox.FormattingEnabled = true;
            tournamentTeamsListBox.ItemHeight = 45;
            tournamentTeamsListBox.Location = new Point(685, 103);
            tournamentTeamsListBox.Name = "tournamentTeamsListBox";
            tournamentTeamsListBox.Size = new Size(456, 139);
            tournamentTeamsListBox.TabIndex = 19;
            // 
            // tournamentPlayersLabel
            // 
            tournamentPlayersLabel.AutoSize = true;
            tournamentPlayersLabel.Font = new Font("Impact", 25.875F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentPlayersLabel.Location = new Point(657, -1);
            tournamentPlayersLabel.Name = "tournamentPlayersLabel";
            tournamentPlayersLabel.Size = new Size(484, 85);
            tournamentPlayersLabel.TabIndex = 20;
            tournamentPlayersLabel.Text = "Teams / Players";
            // 
            // editPrizesLabel
            // 
            editPrizesLabel.AutoSize = true;
            editPrizesLabel.Font = new Font("Impact", 25.875F, FontStyle.Regular, GraphicsUnit.Point);
            editPrizesLabel.Location = new Point(674, 290);
            editPrizesLabel.Name = "editPrizesLabel";
            editPrizesLabel.Size = new Size(324, 85);
            editPrizesLabel.TabIndex = 22;
            editPrizesLabel.Text = "Edit Prizes";
            editPrizesLabel.Click += editPrizesLabel_Click;
            // 
            // prizesListBox
            // 
            prizesListBox.FormattingEnabled = true;
            prizesListBox.ItemHeight = 45;
            prizesListBox.Location = new Point(685, 378);
            prizesListBox.Name = "prizesListBox";
            prizesListBox.Size = new Size(456, 139);
            prizesListBox.TabIndex = 21;
            // 
            // deleteSelectedPrizeButton
            // 
            deleteSelectedPrizeButton.BackColor = SystemColors.ControlLight;
            deleteSelectedPrizeButton.FlatAppearance.BorderColor = Color.Red;
            deleteSelectedPrizeButton.FlatAppearance.MouseDownBackColor = Color.Red;
            deleteSelectedPrizeButton.FlatAppearance.MouseOverBackColor = Color.Gray;
            deleteSelectedPrizeButton.FlatStyle = FlatStyle.Flat;
            deleteSelectedPrizeButton.Font = new Font("Impact", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            deleteSelectedPrizeButton.Location = new Point(731, 523);
            deleteSelectedPrizeButton.Name = "deleteSelectedPrizeButton";
            deleteSelectedPrizeButton.Size = new Size(377, 45);
            deleteSelectedPrizeButton.TabIndex = 24;
            deleteSelectedPrizeButton.Text = "Delete Prize";
            deleteSelectedPrizeButton.UseVisualStyleBackColor = false;
            // 
            // deleteSelectedPlayerButton
            // 
            deleteSelectedPlayerButton.BackColor = SystemColors.ControlLight;
            deleteSelectedPlayerButton.FlatAppearance.BorderColor = Color.Red;
            deleteSelectedPlayerButton.FlatAppearance.MouseDownBackColor = Color.Red;
            deleteSelectedPlayerButton.FlatAppearance.MouseOverBackColor = Color.Gray;
            deleteSelectedPlayerButton.FlatStyle = FlatStyle.Flat;
            deleteSelectedPlayerButton.Font = new Font("Impact", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            deleteSelectedPlayerButton.Location = new Point(731, 248);
            deleteSelectedPlayerButton.Name = "deleteSelectedPlayerButton";
            deleteSelectedPlayerButton.Size = new Size(377, 45);
            deleteSelectedPlayerButton.TabIndex = 25;
            deleteSelectedPlayerButton.Text = "Delete Player";
            deleteSelectedPlayerButton.UseVisualStyleBackColor = false;
            // 
            // createTournamentButton
            // 
            createTournamentButton.BackColor = SystemColors.ControlLight;
            createTournamentButton.FlatAppearance.BorderColor = Color.Red;
            createTournamentButton.FlatAppearance.MouseDownBackColor = Color.Red;
            createTournamentButton.FlatAppearance.MouseOverBackColor = Color.Gray;
            createTournamentButton.FlatStyle = FlatStyle.Flat;
            createTournamentButton.Location = new Point(26, 618);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(1115, 55);
            createTournamentButton.TabIndex = 26;
            createTournamentButton.Text = "Submit Created Tournament";
            createTournamentButton.UseVisualStyleBackColor = false;
            // 
            // CreateTournamentForm
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1158, 685);
            Controls.Add(createTournamentButton);
            Controls.Add(deleteSelectedPlayerButton);
            Controls.Add(deleteSelectedPrizeButton);
            Controls.Add(editPrizesLabel);
            Controls.Add(prizesListBox);
            Controls.Add(tournamentPlayersLabel);
            Controls.Add(tournamentTeamsListBox);
            Controls.Add(createPrizeLabel);
            Controls.Add(createPrizeButton);
            Controls.Add(addTeamButton);
            Controls.Add(createTeamLinkLabel);
            Controls.Add(selectTeamDropDown);
            Controls.Add(selectTeamLabel);
            Controls.Add(entryFeeValue);
            Controls.Add(entryFeeLabel);
            Controls.Add(tournamentNameValue);
            Controls.Add(tournamentNameLabel);
            Controls.Add(headingLabel);
            Font = new Font("Impact", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "CreateTournamentForm";
            Text = "Create Tournament";
            Load += CreateTournamentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headingLabel;
        private TextBox tournamentNameValue;
        private Label tournamentNameLabel;
        private TextBox entryFeeValue;
        private Label entryFeeLabel;
        private ComboBox selectTeamDropDown;
        private Label selectTeamLabel;
        private LinkLabel createTeamLinkLabel;
        private Button addTeamButton;
        private Button createPrizeButton;
        private Label createPrizeLabel;
        private ListBox tournamentTeamsListBox;
        private Label tournamentPlayersLabel;
        private Label editPrizesLabel;
        private ListBox prizesListBox;
        private Button button1;
        private Button deleteSelectedPrizeButton;
        private Button deleteSelectedPlayerButton;
        private Button createTournamentButton;
    }
}