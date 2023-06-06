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
            teamNameLabel = new Label();
            HeaderLabel = new Label();
            teamNameValue = new TextBox();
            addMemberButton = new Button();
            selectTeamMemberDropDown = new ComboBox();
            selectTeamMemberLabel = new Label();
            createNewMemberGroupBox = new GroupBox();
            createMemberButton = new Button();
            phoneNumberValue = new TextBox();
            phoneNumberLabel = new Label();
            emailValue = new TextBox();
            emailLabel = new Label();
            lastNameValue = new TextBox();
            lastNameLabel = new Label();
            firstNameValue = new TextBox();
            firstNameLabel = new Label();
            teamMembersListBox = new ListBox();
            removeSelectedPlayersButton = new Button();
            createTeamButton = new Button();
            createNewMemberGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // teamNameLabel
            // 
            teamNameLabel.AutoSize = true;
            teamNameLabel.Font = new Font("Segoe UI Light", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            teamNameLabel.ForeColor = Color.SteelBlue;
            teamNameLabel.Location = new Point(22, 93);
            teamNameLabel.Name = "teamNameLabel";
            teamNameLabel.Size = new Size(189, 46);
            teamNameLabel.TabIndex = 12;
            teamNameLabel.Text = "Team Name";
            // 
            // HeaderLabel
            // 
            HeaderLabel.AutoSize = true;
            HeaderLabel.BackColor = Color.White;
            HeaderLabel.Font = new Font("Segoe UI Light", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            HeaderLabel.ForeColor = Color.SteelBlue;
            HeaderLabel.Location = new Point(12, 9);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(272, 62);
            HeaderLabel.TabIndex = 11;
            HeaderLabel.Text = "Create Team";
            // 
            // teamNameValue
            // 
            teamNameValue.Location = new Point(22, 142);
            teamNameValue.Name = "teamNameValue";
            teamNameValue.Size = new Size(373, 43);
            teamNameValue.TabIndex = 13;
            // 
            // addMemberButton
            // 
            addMemberButton.FlatAppearance.BorderColor = Color.Gray;
            addMemberButton.FlatAppearance.BorderSize = 2;
            addMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            addMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            addMemberButton.FlatStyle = FlatStyle.Flat;
            addMemberButton.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            addMemberButton.ForeColor = Color.SteelBlue;
            addMemberButton.Location = new Point(97, 299);
            addMemberButton.Name = "addMemberButton";
            addMemberButton.Size = new Size(217, 54);
            addMemberButton.TabIndex = 20;
            addMemberButton.Text = "Add Member";
            addMemberButton.UseVisualStyleBackColor = true;
            addMemberButton.Click += addMemberButton_Click;
            // 
            // selectTeamMemberDropDown
            // 
            selectTeamMemberDropDown.ForeColor = Color.SteelBlue;
            selectTeamMemberDropDown.FormattingEnabled = true;
            selectTeamMemberDropDown.Location = new Point(22, 248);
            selectTeamMemberDropDown.Name = "selectTeamMemberDropDown";
            selectTeamMemberDropDown.Size = new Size(373, 45);
            selectTeamMemberDropDown.TabIndex = 19;
            // 
            // selectTeamMemberLabel
            // 
            selectTeamMemberLabel.AutoSize = true;
            selectTeamMemberLabel.Font = new Font("Segoe UI Light", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            selectTeamMemberLabel.ForeColor = Color.SteelBlue;
            selectTeamMemberLabel.Location = new Point(22, 199);
            selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            selectTeamMemberLabel.Size = new Size(315, 46);
            selectTeamMemberLabel.TabIndex = 18;
            selectTeamMemberLabel.Text = "Select Team Member";
            // 
            // createNewMemberGroupBox
            // 
            createNewMemberGroupBox.Controls.Add(createMemberButton);
            createNewMemberGroupBox.Controls.Add(phoneNumberValue);
            createNewMemberGroupBox.Controls.Add(phoneNumberLabel);
            createNewMemberGroupBox.Controls.Add(emailValue);
            createNewMemberGroupBox.Controls.Add(emailLabel);
            createNewMemberGroupBox.Controls.Add(lastNameValue);
            createNewMemberGroupBox.Controls.Add(lastNameLabel);
            createNewMemberGroupBox.Controls.Add(firstNameValue);
            createNewMemberGroupBox.Controls.Add(firstNameLabel);
            createNewMemberGroupBox.Location = new Point(22, 377);
            createNewMemberGroupBox.Name = "createNewMemberGroupBox";
            createNewMemberGroupBox.Size = new Size(373, 332);
            createNewMemberGroupBox.TabIndex = 21;
            createNewMemberGroupBox.TabStop = false;
            createNewMemberGroupBox.Text = "Add New Member";
            // 
            // createMemberButton
            // 
            createMemberButton.FlatAppearance.BorderColor = Color.Gray;
            createMemberButton.FlatAppearance.BorderSize = 2;
            createMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createMemberButton.FlatStyle = FlatStyle.Flat;
            createMemberButton.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            createMemberButton.ForeColor = Color.SteelBlue;
            createMemberButton.Location = new Point(66, 259);
            createMemberButton.Name = "createMemberButton";
            createMemberButton.Size = new Size(240, 48);
            createMemberButton.TabIndex = 21;
            createMemberButton.Text = "Create Member";
            createMemberButton.UseVisualStyleBackColor = true;
            createMemberButton.Click += createMemberButton_Click;
            // 
            // phoneNumberValue
            // 
            phoneNumberValue.Location = new Point(192, 210);
            phoneNumberValue.Name = "phoneNumberValue";
            phoneNumberValue.Size = new Size(125, 43);
            phoneNumberValue.TabIndex = 17;
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Font = new Font("Segoe UI Light", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            phoneNumberLabel.ForeColor = Color.SteelBlue;
            phoneNumberLabel.Location = new Point(6, 207);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(170, 46);
            phoneNumberLabel.TabIndex = 16;
            phoneNumberLabel.Text = "Phone No:";
            // 
            // emailValue
            // 
            emailValue.Location = new Point(192, 153);
            emailValue.Name = "emailValue";
            emailValue.Size = new Size(125, 43);
            emailValue.TabIndex = 15;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI Light", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            emailLabel.ForeColor = Color.SteelBlue;
            emailLabel.Location = new Point(6, 150);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(104, 46);
            emailLabel.TabIndex = 14;
            emailLabel.Text = "Email:";
            // 
            // lastNameValue
            // 
            lastNameValue.Location = new Point(192, 98);
            lastNameValue.Name = "lastNameValue";
            lastNameValue.Size = new Size(125, 43);
            lastNameValue.TabIndex = 13;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI Light", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameLabel.ForeColor = Color.SteelBlue;
            lastNameLabel.Location = new Point(6, 95);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(179, 46);
            lastNameLabel.TabIndex = 12;
            lastNameLabel.Text = "Last Name:";
            lastNameLabel.Click += lastNameLabel_Click;
            // 
            // firstNameValue
            // 
            firstNameValue.Location = new Point(192, 42);
            firstNameValue.Name = "firstNameValue";
            firstNameValue.Size = new Size(125, 43);
            firstNameValue.TabIndex = 11;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI Light", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            firstNameLabel.ForeColor = Color.SteelBlue;
            firstNameLabel.Location = new Point(6, 39);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(180, 46);
            firstNameLabel.TabIndex = 10;
            firstNameLabel.Text = "First Name:";
            // 
            // teamMembersListBox
            // 
            teamMembersListBox.BorderStyle = BorderStyle.FixedSingle;
            teamMembersListBox.FormattingEnabled = true;
            teamMembersListBox.ItemHeight = 37;
            teamMembersListBox.Location = new Point(475, 100);
            teamMembersListBox.Name = "teamMembersListBox";
            teamMembersListBox.Size = new Size(355, 520);
            teamMembersListBox.TabIndex = 22;
            // 
            // removeSelectedPlayersButton
            // 
            removeSelectedPlayersButton.FlatAppearance.BorderColor = Color.Gray;
            removeSelectedPlayersButton.FlatAppearance.BorderSize = 2;
            removeSelectedPlayersButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            removeSelectedPlayersButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            removeSelectedPlayersButton.FlatStyle = FlatStyle.Flat;
            removeSelectedPlayersButton.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            removeSelectedPlayersButton.ForeColor = Color.SteelBlue;
            removeSelectedPlayersButton.Location = new Point(521, 655);
            removeSelectedPlayersButton.Name = "removeSelectedPlayersButton";
            removeSelectedPlayersButton.Size = new Size(258, 54);
            removeSelectedPlayersButton.TabIndex = 23;
            removeSelectedPlayersButton.Text = "Remove Member";
            removeSelectedPlayersButton.UseVisualStyleBackColor = true;
            removeSelectedPlayersButton.Click += removeSelectedPlayersButton_Click;
            // 
            // createTeamButton
            // 
            createTeamButton.FlatAppearance.BorderColor = Color.Gray;
            createTeamButton.FlatAppearance.BorderSize = 2;
            createTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createTeamButton.FlatStyle = FlatStyle.Flat;
            createTeamButton.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            createTeamButton.ForeColor = Color.SteelBlue;
            createTeamButton.Location = new Point(275, 742);
            createTeamButton.Name = "createTeamButton";
            createTeamButton.Size = new Size(342, 54);
            createTeamButton.TabIndex = 26;
            createTeamButton.Text = "Create Team";
            createTeamButton.UseVisualStyleBackColor = true;
            createTeamButton.Click += createTeamButton_Click;
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(883, 832);
            Controls.Add(createTeamButton);
            Controls.Add(removeSelectedPlayersButton);
            Controls.Add(teamMembersListBox);
            Controls.Add(createNewMemberGroupBox);
            Controls.Add(addMemberButton);
            Controls.Add(selectTeamMemberDropDown);
            Controls.Add(selectTeamMemberLabel);
            Controls.Add(teamNameValue);
            Controls.Add(teamNameLabel);
            Controls.Add(HeaderLabel);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.SteelBlue;
            Margin = new Padding(6);
            Name = "CreateTeamForm";
            Text = "Create Team";
            createNewMemberGroupBox.ResumeLayout(false);
            createNewMemberGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label teamNameLabel;
        private Label HeaderLabel;
        private TextBox teamNameValue;
        private Button addMemberButton;
        private ComboBox selectTeamMemberDropDown;
        private Label selectTeamMemberLabel;
        private GroupBox createNewMemberGroupBox;
        private TextBox lastNameValue;
        private Label lastNameLabel;
        private TextBox firstNameValue;
        private Label firstNameLabel;
        private TextBox emailValue;
        private Label emailLabel;
        private TextBox phoneNumberValue;
        private Label phoneNumberLabel;
        private Button createMemberButton;
        private ListBox teamMembersListBox;
        private Button removeSelectedPlayersButton;
        private Button createTeamButton;
    }
}