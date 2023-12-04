namespace TrackerUI
{
    partial class CreatePrizeForm
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
            prizePercentLabel = new Label();
            prizeAmountLabel = new Label();
            placeNameLabel = new Label();
            placeNumberLabel = new Label();
            placeNumberValue = new TextBox();
            placeNameValue = new TextBox();
            prizeAmountValue = new TextBox();
            prizePercentValue = new TextBox();
            createPrizeLabel = new Label();
            orLabel = new Label();
            createPrizeButton = new Button();
            SuspendLayout();
            // 
            // prizePercentLabel
            // 
            prizePercentLabel.AutoSize = true;
            prizePercentLabel.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            prizePercentLabel.Location = new Point(12, 309);
            prizePercentLabel.Name = "prizePercentLabel";
            prizePercentLabel.Size = new Size(242, 39);
            prizePercentLabel.TabIndex = 34;
            prizePercentLabel.Text = "Prize Percentage:";
            // 
            // prizeAmountLabel
            // 
            prizeAmountLabel.AutoSize = true;
            prizeAmountLabel.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            prizeAmountLabel.Location = new Point(62, 200);
            prizeAmountLabel.Name = "prizeAmountLabel";
            prizeAmountLabel.Size = new Size(192, 39);
            prizeAmountLabel.TabIndex = 33;
            prizeAmountLabel.Text = "Prize Amount:";
            // 
            // placeNameLabel
            // 
            placeNameLabel.AutoSize = true;
            placeNameLabel.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            placeNameLabel.Location = new Point(79, 158);
            placeNameLabel.Name = "placeNameLabel";
            placeNameLabel.Size = new Size(175, 39);
            placeNameLabel.TabIndex = 32;
            placeNameLabel.Text = "Place Name:";
            // 
            // placeNumberLabel
            // 
            placeNumberLabel.AutoSize = true;
            placeNumberLabel.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            placeNumberLabel.Location = new Point(50, 113);
            placeNumberLabel.Name = "placeNumberLabel";
            placeNumberLabel.Size = new Size(204, 39);
            placeNumberLabel.TabIndex = 29;
            placeNumberLabel.Text = "Place Number:";
            // 
            // placeNumberValue
            // 
            placeNumberValue.Location = new Point(260, 113);
            placeNumberValue.Name = "placeNumberValue";
            placeNumberValue.Size = new Size(245, 39);
            placeNumberValue.TabIndex = 27;
            // 
            // placeNameValue
            // 
            placeNameValue.Location = new Point(260, 158);
            placeNameValue.Name = "placeNameValue";
            placeNameValue.Size = new Size(245, 39);
            placeNameValue.TabIndex = 28;
            // 
            // prizeAmountValue
            // 
            prizeAmountValue.Location = new Point(260, 203);
            prizeAmountValue.Name = "prizeAmountValue";
            prizeAmountValue.Size = new Size(245, 39);
            prizeAmountValue.TabIndex = 30;
            prizeAmountValue.Text = "0";
            // 
            // prizePercentValue
            // 
            prizePercentValue.Location = new Point(260, 312);
            prizePercentValue.Name = "prizePercentValue";
            prizePercentValue.Size = new Size(245, 39);
            prizePercentValue.TabIndex = 31;
            prizePercentValue.Text = "0";
            // 
            // createPrizeLabel
            // 
            createPrizeLabel.AutoSize = true;
            createPrizeLabel.Font = new Font("Impact", 25.875F, FontStyle.Regular, GraphicsUnit.Point);
            createPrizeLabel.Location = new Point(12, 9);
            createPrizeLabel.Name = "createPrizeLabel";
            createPrizeLabel.Size = new Size(376, 85);
            createPrizeLabel.TabIndex = 35;
            createPrizeLabel.Text = "Create Prize";
            // 
            // orLabel
            // 
            orLabel.AutoSize = true;
            orLabel.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            orLabel.Location = new Point(222, 255);
            orLabel.Name = "orLabel";
            orLabel.Size = new Size(51, 39);
            orLabel.TabIndex = 36;
            orLabel.Text = "OR";
            // 
            // createPrizeButton
            // 
            createPrizeButton.BackColor = SystemColors.ControlLight;
            createPrizeButton.FlatAppearance.BorderColor = Color.Red;
            createPrizeButton.FlatAppearance.MouseDownBackColor = Color.Red;
            createPrizeButton.FlatAppearance.MouseOverBackColor = Color.Gray;
            createPrizeButton.FlatStyle = FlatStyle.Flat;
            createPrizeButton.Location = new Point(12, 383);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(493, 55);
            createPrizeButton.TabIndex = 37;
            createPrizeButton.Text = "Submit Created Prize";
            createPrizeButton.UseVisualStyleBackColor = false;
            createPrizeButton.Click += createPrizeButton_Click;
            // 
            // CreatePrizeForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(516, 450);
            Controls.Add(createPrizeButton);
            Controls.Add(orLabel);
            Controls.Add(createPrizeLabel);
            Controls.Add(prizePercentLabel);
            Controls.Add(prizeAmountLabel);
            Controls.Add(placeNameLabel);
            Controls.Add(placeNumberLabel);
            Controls.Add(placeNumberValue);
            Controls.Add(placeNameValue);
            Controls.Add(prizeAmountValue);
            Controls.Add(prizePercentValue);
            Name = "CreatePrizeForm";
            Text = "Create Prize";
            Load += CreatePrizeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label prizePercentLabel;
        private Label prizeAmountLabel;
        private Label placeNameLabel;
        private Label placeNumberLabel;
        private TextBox placeNumberValue;
        private TextBox placeNameValue;
        private TextBox prizeAmountValue;
        private TextBox prizePercentValue;
        private Label createPrizeLabel;
        private Label orLabel;
        private Button createPrizeButton;
    }
}