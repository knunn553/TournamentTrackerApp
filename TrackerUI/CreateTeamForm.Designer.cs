namespace TrackerUI
{
    partial class CreateTeamForm
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
            createTeamLabel = new Label();
            teamMemberLabel = new Label();
            teamNameLabel = new Label();
            teamNameValue = new TextBox();
            selectTeamMemberDropBox = new ComboBox();
            addTeamMemberButton = new Button();
            addMemberGroupBox = new GroupBox();
            firstNameValue = new TextBox();
            lastNameValue = new TextBox();
            memberEmailValue = new TextBox();
            memberPhoneNumberValue = new TextBox();
            firstNameLabel = new Label();
            lastNameLabel = new Label();
            memberEmailLabel = new Label();
            memberPhoneNumberLabel = new Label();
            addNewTeamMemberButton = new Button();
            teamMembersListBox = new ListBox();
            deleteTeamMemberButton = new Button();
            createTeamButton = new Button();
            addMemberGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // createTeamLabel
            // 
            createTeamLabel.AutoSize = true;
            createTeamLabel.Font = new Font("Impact", 25.875F, FontStyle.Regular, GraphicsUnit.Point);
            createTeamLabel.Location = new Point(12, 9);
            createTeamLabel.Name = "createTeamLabel";
            createTeamLabel.Size = new Size(390, 85);
            createTeamLabel.TabIndex = 8;
            createTeamLabel.Text = "Create Team";
            // 
            // teamMemberLabel
            // 
            teamMemberLabel.AutoSize = true;
            teamMemberLabel.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            teamMemberLabel.Location = new Point(37, 179);
            teamMemberLabel.Name = "teamMemberLabel";
            teamMemberLabel.Size = new Size(208, 39);
            teamMemberLabel.TabIndex = 10;
            teamMemberLabel.Text = "Team Member:";
            // 
            // teamNameLabel
            // 
            teamNameLabel.AutoSize = true;
            teamNameLabel.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            teamNameLabel.Location = new Point(71, 122);
            teamNameLabel.Name = "teamNameLabel";
            teamNameLabel.Size = new Size(174, 39);
            teamNameLabel.TabIndex = 11;
            teamNameLabel.Text = "Team Name:";
            // 
            // teamNameValue
            // 
            teamNameValue.BorderStyle = BorderStyle.FixedSingle;
            teamNameValue.Location = new Point(279, 126);
            teamNameValue.Name = "teamNameValue";
            teamNameValue.Size = new Size(283, 39);
            teamNameValue.TabIndex = 12;
            // 
            // selectTeamMemberDropBox
            // 
            selectTeamMemberDropBox.FormattingEnabled = true;
            selectTeamMemberDropBox.Location = new Point(279, 178);
            selectTeamMemberDropBox.Name = "selectTeamMemberDropBox";
            selectTeamMemberDropBox.Size = new Size(283, 40);
            selectTeamMemberDropBox.TabIndex = 15;
            // 
            // addTeamMemberButton
            // 
            addTeamMemberButton.BackColor = SystemColors.ControlLight;
            addTeamMemberButton.FlatAppearance.BorderColor = Color.Red;
            addTeamMemberButton.FlatAppearance.MouseDownBackColor = Color.Red;
            addTeamMemberButton.FlatAppearance.MouseOverBackColor = Color.Gray;
            addTeamMemberButton.FlatStyle = FlatStyle.Flat;
            addTeamMemberButton.Location = new Point(24, 233);
            addTeamMemberButton.Name = "addTeamMemberButton";
            addTeamMemberButton.Size = new Size(538, 43);
            addTeamMemberButton.TabIndex = 17;
            addTeamMemberButton.Text = "Add Existing Team Member";
            addTeamMemberButton.UseVisualStyleBackColor = false;
            // 
            // addMemberGroupBox
            // 
            addMemberGroupBox.Controls.Add(addNewTeamMemberButton);
            addMemberGroupBox.Controls.Add(memberPhoneNumberLabel);
            addMemberGroupBox.Controls.Add(memberEmailLabel);
            addMemberGroupBox.Controls.Add(lastNameLabel);
            addMemberGroupBox.Controls.Add(firstNameLabel);
            addMemberGroupBox.Controls.Add(firstNameValue);
            addMemberGroupBox.Controls.Add(lastNameValue);
            addMemberGroupBox.Controls.Add(memberEmailValue);
            addMemberGroupBox.Controls.Add(memberPhoneNumberValue);
            addMemberGroupBox.Location = new Point(24, 304);
            addMemberGroupBox.Name = "addMemberGroupBox";
            addMemberGroupBox.Size = new Size(538, 278);
            addMemberGroupBox.TabIndex = 18;
            addMemberGroupBox.TabStop = false;
            addMemberGroupBox.Text = "Add New Member";
            // 
            // firstNameValue
            // 
            firstNameValue.Location = new Point(249, 48);
            firstNameValue.Name = "firstNameValue";
            firstNameValue.Size = new Size(283, 39);
            firstNameValue.TabIndex = 20;
            // 
            // lastNameValue
            // 
            lastNameValue.Location = new Point(249, 93);
            lastNameValue.Name = "lastNameValue";
            lastNameValue.Size = new Size(283, 39);
            lastNameValue.TabIndex = 21;
            // 
            // memberEmailValue
            // 
            memberEmailValue.Location = new Point(249, 138);
            memberEmailValue.Name = "memberEmailValue";
            memberEmailValue.Size = new Size(283, 39);
            memberEmailValue.TabIndex = 22;
            // 
            // memberPhoneNumberValue
            // 
            memberPhoneNumberValue.Location = new Point(249, 183);
            memberPhoneNumberValue.Name = "memberPhoneNumberValue";
            memberPhoneNumberValue.Size = new Size(283, 39);
            memberPhoneNumberValue.TabIndex = 23;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            firstNameLabel.Location = new Point(61, 45);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(160, 39);
            firstNameLabel.TabIndex = 22;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameLabel.Location = new Point(65, 93);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(156, 39);
            lastNameLabel.TabIndex = 24;
            lastNameLabel.Text = "Last Name:";
            // 
            // memberEmailLabel
            // 
            memberEmailLabel.AutoSize = true;
            memberEmailLabel.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            memberEmailLabel.Location = new Point(128, 138);
            memberEmailLabel.Name = "memberEmailLabel";
            memberEmailLabel.Size = new Size(93, 39);
            memberEmailLabel.TabIndex = 25;
            memberEmailLabel.Text = "Email:";
            // 
            // memberPhoneNumberLabel
            // 
            memberPhoneNumberLabel.AutoSize = true;
            memberPhoneNumberLabel.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            memberPhoneNumberLabel.Location = new Point(9, 183);
            memberPhoneNumberLabel.Name = "memberPhoneNumberLabel";
            memberPhoneNumberLabel.Size = new Size(214, 39);
            memberPhoneNumberLabel.TabIndex = 26;
            memberPhoneNumberLabel.Text = "Phone Number:";
            // 
            // addNewTeamMemberButton
            // 
            addNewTeamMemberButton.BackColor = SystemColors.ControlLight;
            addNewTeamMemberButton.FlatAppearance.BorderColor = Color.Red;
            addNewTeamMemberButton.FlatAppearance.MouseDownBackColor = Color.Red;
            addNewTeamMemberButton.FlatAppearance.MouseOverBackColor = Color.Gray;
            addNewTeamMemberButton.FlatStyle = FlatStyle.Flat;
            addNewTeamMemberButton.Location = new Point(6, 228);
            addNewTeamMemberButton.Name = "addNewTeamMemberButton";
            addNewTeamMemberButton.Size = new Size(526, 43);
            addNewTeamMemberButton.TabIndex = 19;
            addNewTeamMemberButton.Text = "Add New Team Member";
            addNewTeamMemberButton.UseVisualStyleBackColor = false;
            // 
            // teamMembersListBox
            // 
            teamMembersListBox.FormattingEnabled = true;
            teamMembersListBox.ItemHeight = 32;
            teamMembersListBox.Location = new Point(590, 126);
            teamMembersListBox.Name = "teamMembersListBox";
            teamMembersListBox.Size = new Size(456, 388);
            teamMembersListBox.TabIndex = 27;
            // 
            // deleteTeamMemberButton
            // 
            deleteTeamMemberButton.BackColor = SystemColors.ControlLight;
            deleteTeamMemberButton.FlatAppearance.BorderColor = Color.Red;
            deleteTeamMemberButton.FlatAppearance.MouseDownBackColor = Color.Red;
            deleteTeamMemberButton.FlatAppearance.MouseOverBackColor = Color.Gray;
            deleteTeamMemberButton.FlatStyle = FlatStyle.Flat;
            deleteTeamMemberButton.Location = new Point(590, 532);
            deleteTeamMemberButton.Name = "deleteTeamMemberButton";
            deleteTeamMemberButton.Size = new Size(456, 43);
            deleteTeamMemberButton.TabIndex = 27;
            deleteTeamMemberButton.Text = "Delete Selected Member";
            deleteTeamMemberButton.UseVisualStyleBackColor = false;
            // 
            // createTeamButton
            // 
            createTeamButton.BackColor = SystemColors.ControlLight;
            createTeamButton.FlatAppearance.BorderColor = Color.Red;
            createTeamButton.FlatAppearance.MouseDownBackColor = Color.Red;
            createTeamButton.FlatAppearance.MouseOverBackColor = Color.Gray;
            createTeamButton.FlatStyle = FlatStyle.Flat;
            createTeamButton.Location = new Point(30, 581);
            createTeamButton.Name = "createTeamButton";
            createTeamButton.Size = new Size(1016, 64);
            createTeamButton.TabIndex = 28;
            createTeamButton.Text = "Create Team";
            createTeamButton.UseVisualStyleBackColor = false;
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1069, 657);
            Controls.Add(createTeamButton);
            Controls.Add(deleteTeamMemberButton);
            Controls.Add(teamMembersListBox);
            Controls.Add(addMemberGroupBox);
            Controls.Add(addTeamMemberButton);
            Controls.Add(selectTeamMemberDropBox);
            Controls.Add(teamNameValue);
            Controls.Add(teamNameLabel);
            Controls.Add(teamMemberLabel);
            Controls.Add(createTeamLabel);
            Name = "CreateTeamForm";
            Text = "Create Team";
            Load += CreateTeamForm_Load;
            addMemberGroupBox.ResumeLayout(false);
            addMemberGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label createTeamLabel;
        private Label teamMemberLabel;
        private Label teamNameLabel;
        private TextBox teamNameValue;
        private ComboBox selectTeamMemberDropBox;
        private Button addTeamMemberButton;
        private GroupBox addMemberGroupBox;
        private Label memberPhoneNumberLabel;
        private Label memberEmailLabel;
        private Label lastNameLabel;
        private Label firstNameLabel;
        private TextBox firstNameValue;
        private TextBox lastNameValue;
        private TextBox memberEmailValue;
        private TextBox memberPhoneNumberValue;
        private Button addNewTeamMemberButton;
        private ListBox teamMembersListBox;
        private Button deleteTeamMemberButton;
        private Button createTeamButton;
    }
}