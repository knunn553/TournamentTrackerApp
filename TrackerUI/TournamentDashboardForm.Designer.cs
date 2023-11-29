namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            tournamentDashboardLabel = new Label();
            loadExistingTournamentButton = new Button();
            loadExistingTournamentLabel = new Label();
            createTournamentButton = new Button();
            loadExistingTournamentDropBox = new ComboBox();
            SuspendLayout();
            // 
            // tournamentDashboardLabel
            // 
            tournamentDashboardLabel.AutoSize = true;
            tournamentDashboardLabel.Font = new Font("Impact", 25.875F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentDashboardLabel.Location = new Point(12, 9);
            tournamentDashboardLabel.Name = "tournamentDashboardLabel";
            tournamentDashboardLabel.Size = new Size(701, 85);
            tournamentDashboardLabel.TabIndex = 36;
            tournamentDashboardLabel.Text = "Tournament Dashboard";
            // 
            // loadExistingTournamentButton
            // 
            loadExistingTournamentButton.BackColor = SystemColors.ControlLight;
            loadExistingTournamentButton.FlatAppearance.BorderColor = Color.Red;
            loadExistingTournamentButton.FlatAppearance.MouseDownBackColor = Color.Red;
            loadExistingTournamentButton.FlatAppearance.MouseOverBackColor = Color.Gray;
            loadExistingTournamentButton.FlatStyle = FlatStyle.Flat;
            loadExistingTournamentButton.Location = new Point(402, 175);
            loadExistingTournamentButton.Name = "loadExistingTournamentButton";
            loadExistingTournamentButton.Size = new Size(290, 46);
            loadExistingTournamentButton.TabIndex = 40;
            loadExistingTournamentButton.Text = "Load Tournament";
            loadExistingTournamentButton.UseVisualStyleBackColor = false;
            // 
            // loadExistingTournamentLabel
            // 
            loadExistingTournamentLabel.AutoSize = true;
            loadExistingTournamentLabel.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            loadExistingTournamentLabel.Location = new Point(39, 120);
            loadExistingTournamentLabel.Name = "loadExistingTournamentLabel";
            loadExistingTournamentLabel.Size = new Size(357, 39);
            loadExistingTournamentLabel.TabIndex = 39;
            loadExistingTournamentLabel.Text = "Load Existing Tournament:";
            // 
            // createTournamentButton
            // 
            createTournamentButton.BackColor = SystemColors.ControlLight;
            createTournamentButton.FlatAppearance.BorderColor = Color.Red;
            createTournamentButton.FlatAppearance.MouseDownBackColor = Color.Red;
            createTournamentButton.FlatAppearance.MouseOverBackColor = Color.Gray;
            createTournamentButton.FlatStyle = FlatStyle.Flat;
            createTournamentButton.Location = new Point(402, 227);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(290, 52);
            createTournamentButton.TabIndex = 41;
            createTournamentButton.Text = "Create New Tournament";
            createTournamentButton.UseVisualStyleBackColor = false;
            // 
            // loadExistingTournamentDropBox
            // 
            loadExistingTournamentDropBox.FormattingEnabled = true;
            loadExistingTournamentDropBox.Location = new Point(402, 123);
            loadExistingTournamentDropBox.Name = "loadExistingTournamentDropBox";
            loadExistingTournamentDropBox.Size = new Size(290, 40);
            loadExistingTournamentDropBox.TabIndex = 42;
            // 
            // TournamentDashboardForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(715, 293);
            Controls.Add(loadExistingTournamentDropBox);
            Controls.Add(createTournamentButton);
            Controls.Add(loadExistingTournamentButton);
            Controls.Add(loadExistingTournamentLabel);
            Controls.Add(tournamentDashboardLabel);
            Name = "TournamentDashboardForm";
            Text = "Tournament Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tournamentDashboardLabel;
        private Button loadExistingTournamentButton;
        private Label loadExistingTournamentLabel;
        private Button createTournamentButton;
        private ComboBox loadExistingTournamentDropBox;
    }
}