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
            HeaderLabel = new Label();
            tournamentName = new Label();
            roundLabel = new Label();
            roundDropDown = new ComboBox();
            unplayedOnlyCheckBox = new CheckBox();
            matchupListBox = new ListBox();
            teamOneName = new Label();
            teamTwoName = new Label();
            teamOneScoreLabel = new Label();
            teamOneScoreValue = new TextBox();
            teamTwoScoreValue = new TextBox();
            teamTwoScoreLabel = new Label();
            vsLabel = new Label();
            scoreButton = new Button();
            SuspendLayout();
            // 
            // HeaderLabel
            // 
            HeaderLabel.AutoSize = true;
            HeaderLabel.BackColor = Color.White;
            HeaderLabel.Font = new Font("Segoe UI Light", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            HeaderLabel.ForeColor = Color.SteelBlue;
            HeaderLabel.Location = new Point(12, 9);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(271, 62);
            HeaderLabel.TabIndex = 0;
            HeaderLabel.Text = "Tournament:";
            HeaderLabel.Click += HeaderLabel_Click;
            // 
            // tournamentName
            // 
            tournamentName.AutoSize = true;
            tournamentName.BackColor = Color.White;
            tournamentName.Font = new Font("Segoe UI Light", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentName.ForeColor = Color.SteelBlue;
            tournamentName.Location = new Point(289, 9);
            tournamentName.Name = "tournamentName";
            tournamentName.Size = new Size(135, 62);
            tournamentName.TabIndex = 1;
            tournamentName.Text = "None";
            // 
            // roundLabel
            // 
            roundLabel.AutoSize = true;
            roundLabel.Font = new Font("Segoe UI Light", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            roundLabel.ForeColor = Color.SteelBlue;
            roundLabel.Location = new Point(22, 90);
            roundLabel.Name = "roundLabel";
            roundLabel.Size = new Size(121, 46);
            roundLabel.TabIndex = 2;
            roundLabel.Text = "Round:";
            // 
            // roundDropDown
            // 
            roundDropDown.ForeColor = Color.SteelBlue;
            roundDropDown.FormattingEnabled = true;
            roundDropDown.Location = new Point(149, 93);
            roundDropDown.Name = "roundDropDown";
            roundDropDown.Size = new Size(228, 45);
            roundDropDown.TabIndex = 3;
            // 
            // unplayedOnlyCheckBox
            // 
            unplayedOnlyCheckBox.AutoSize = true;
            unplayedOnlyCheckBox.FlatStyle = FlatStyle.Flat;
            unplayedOnlyCheckBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            unplayedOnlyCheckBox.ForeColor = Color.SteelBlue;
            unplayedOnlyCheckBox.Location = new Point(149, 158);
            unplayedOnlyCheckBox.Name = "unplayedOnlyCheckBox";
            unplayedOnlyCheckBox.Size = new Size(183, 35);
            unplayedOnlyCheckBox.TabIndex = 4;
            unplayedOnlyCheckBox.Text = "Unplayed Only";
            unplayedOnlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // matchupListBox
            // 
            matchupListBox.BorderStyle = BorderStyle.FixedSingle;
            matchupListBox.FormattingEnabled = true;
            matchupListBox.ItemHeight = 37;
            matchupListBox.Location = new Point(22, 217);
            matchupListBox.Name = "matchupListBox";
            matchupListBox.Size = new Size(355, 261);
            matchupListBox.TabIndex = 5;
            // 
            // teamOneName
            // 
            teamOneName.AutoSize = true;
            teamOneName.Font = new Font("Segoe UI Light", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            teamOneName.ForeColor = Color.SteelBlue;
            teamOneName.Location = new Point(401, 158);
            teamOneName.Name = "teamOneName";
            teamOneName.Size = new Size(199, 46);
            teamOneName.TabIndex = 6;
            teamOneName.Text = "<team one>";
            teamOneName.Click += teamOneName_Click;
            // 
            // teamTwoName
            // 
            teamTwoName.AutoSize = true;
            teamTwoName.Font = new Font("Segoe UI Light", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            teamTwoName.ForeColor = Color.SteelBlue;
            teamTwoName.Location = new Point(401, 331);
            teamTwoName.Name = "teamTwoName";
            teamTwoName.Size = new Size(197, 46);
            teamTwoName.TabIndex = 7;
            teamTwoName.Text = "<team two>";
            // 
            // teamOneScoreLabel
            // 
            teamOneScoreLabel.AutoSize = true;
            teamOneScoreLabel.Font = new Font("Segoe UI Light", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            teamOneScoreLabel.ForeColor = Color.SteelBlue;
            teamOneScoreLabel.Location = new Point(403, 204);
            teamOneScoreLabel.Name = "teamOneScoreLabel";
            teamOneScoreLabel.Size = new Size(106, 46);
            teamOneScoreLabel.TabIndex = 8;
            teamOneScoreLabel.Text = "Score:";
            // 
            // teamOneScoreValue
            // 
            teamOneScoreValue.Location = new Point(524, 207);
            teamOneScoreValue.Name = "teamOneScoreValue";
            teamOneScoreValue.Size = new Size(125, 43);
            teamOneScoreValue.TabIndex = 9;
            // 
            // teamTwoScoreValue
            // 
            teamTwoScoreValue.Location = new Point(524, 380);
            teamTwoScoreValue.Name = "teamTwoScoreValue";
            teamTwoScoreValue.Size = new Size(125, 43);
            teamTwoScoreValue.TabIndex = 11;
            teamTwoScoreValue.TextChanged += teamTwoScoreValue_TextChanged;
            // 
            // teamTwoScoreLabel
            // 
            teamTwoScoreLabel.AutoSize = true;
            teamTwoScoreLabel.Font = new Font("Segoe UI Light", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            teamTwoScoreLabel.ForeColor = Color.SteelBlue;
            teamTwoScoreLabel.Location = new Point(403, 377);
            teamTwoScoreLabel.Name = "teamTwoScoreLabel";
            teamTwoScoreLabel.Size = new Size(106, 46);
            teamTwoScoreLabel.TabIndex = 10;
            teamTwoScoreLabel.Text = "Score:";
            // 
            // vsLabel
            // 
            vsLabel.AutoSize = true;
            vsLabel.Font = new Font("Segoe UI Light", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            vsLabel.ForeColor = Color.SteelBlue;
            vsLabel.Location = new Point(485, 269);
            vsLabel.Name = "vsLabel";
            vsLabel.Size = new Size(85, 46);
            vsLabel.TabIndex = 12;
            vsLabel.Text = "-VS-";
            vsLabel.Click += VSLabel_Click;
            // 
            // scoreButton
            // 
            scoreButton.FlatAppearance.BorderColor = Color.Gray;
            scoreButton.FlatAppearance.BorderSize = 2;
            scoreButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            scoreButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            scoreButton.FlatStyle = FlatStyle.Flat;
            scoreButton.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            scoreButton.ForeColor = Color.SteelBlue;
            scoreButton.Location = new Point(671, 269);
            scoreButton.Name = "scoreButton";
            scoreButton.Size = new Size(123, 54);
            scoreButton.TabIndex = 13;
            scoreButton.Text = "Score";
            scoreButton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(853, 517);
            Controls.Add(scoreButton);
            Controls.Add(vsLabel);
            Controls.Add(teamTwoScoreValue);
            Controls.Add(teamTwoScoreLabel);
            Controls.Add(teamOneScoreValue);
            Controls.Add(teamOneScoreLabel);
            Controls.Add(teamTwoName);
            Controls.Add(teamOneName);
            Controls.Add(matchupListBox);
            Controls.Add(unplayedOnlyCheckBox);
            Controls.Add(roundDropDown);
            Controls.Add(roundLabel);
            Controls.Add(tournamentName);
            Controls.Add(HeaderLabel);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "TournamentViewerForm";
            Text = "Tournament Viewer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HeaderLabel;
        private Label tournamentName;
        private Label roundLabel;
        private ComboBox roundDropDown;
        private CheckBox unplayedOnlyCheckBox;
        private ListBox matchupListBox;
        private Label teamOneName;
        private Label teamTwoName;
        private Label teamOneScoreLabel;
        private TextBox teamOneScoreValue;
        private TextBox teamTwoScoreValue;
        private Label teamTwoScoreLabel;
        private Label vsLabel;
        private Button scoreButton;
    }
}