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
            HeaderLabel = new Label();
            placeNumberValue = new TextBox();
            placeNumberLAbel = new Label();
            placeNameValue = new TextBox();
            placeNameLabel = new Label();
            prizeAmountValue = new TextBox();
            prizeAmountLabel = new Label();
            prizePercentageValue = new TextBox();
            prizePercentageLabel = new Label();
            orLabel = new Label();
            createPrizeButton = new Button();
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
            HeaderLabel.Size = new Size(267, 62);
            HeaderLabel.TabIndex = 12;
            HeaderLabel.Text = "Create Prize";
            // 
            // placeNumberValue
            // 
            placeNumberValue.Location = new Point(248, 84);
            placeNumberValue.Name = "placeNumberValue";
            placeNumberValue.Size = new Size(125, 43);
            placeNumberValue.TabIndex = 14;
            placeNumberValue.TextChanged += firstNameValue_TextChanged;
            // 
            // placeNumberLAbel
            // 
            placeNumberLAbel.AutoSize = true;
            placeNumberLAbel.Font = new Font("Segoe UI Light", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            placeNumberLAbel.ForeColor = Color.SteelBlue;
            placeNumberLAbel.Location = new Point(12, 81);
            placeNumberLAbel.Name = "placeNumberLAbel";
            placeNumberLAbel.Size = new Size(230, 46);
            placeNumberLAbel.TabIndex = 13;
            placeNumberLAbel.Text = "Place Number:";
            // 
            // placeNameValue
            // 
            placeNameValue.Location = new Point(215, 143);
            placeNameValue.Name = "placeNameValue";
            placeNameValue.Size = new Size(125, 43);
            placeNameValue.TabIndex = 16;
            // 
            // placeNameLabel
            // 
            placeNameLabel.AutoSize = true;
            placeNameLabel.Font = new Font("Segoe UI Light", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            placeNameLabel.ForeColor = Color.SteelBlue;
            placeNameLabel.Location = new Point(12, 140);
            placeNameLabel.Name = "placeNameLabel";
            placeNameLabel.Size = new Size(197, 46);
            placeNameLabel.TabIndex = 15;
            placeNameLabel.Text = "Place Name:";
            // 
            // prizeAmountValue
            // 
            prizeAmountValue.Location = new Point(248, 202);
            prizeAmountValue.Name = "prizeAmountValue";
            prizeAmountValue.Size = new Size(125, 43);
            prizeAmountValue.TabIndex = 18;
            prizeAmountValue.Text = "0";
            // 
            // prizeAmountLabel
            // 
            prizeAmountLabel.AutoSize = true;
            prizeAmountLabel.Font = new Font("Segoe UI Light", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            prizeAmountLabel.ForeColor = Color.SteelBlue;
            prizeAmountLabel.Location = new Point(12, 199);
            prizeAmountLabel.Name = "prizeAmountLabel";
            prizeAmountLabel.Size = new Size(220, 46);
            prizeAmountLabel.TabIndex = 17;
            prizeAmountLabel.Text = "Prize Amount:";
            // 
            // prizePercentageValue
            // 
            prizePercentageValue.Location = new Point(280, 321);
            prizePercentageValue.Name = "prizePercentageValue";
            prizePercentageValue.Size = new Size(125, 43);
            prizePercentageValue.TabIndex = 20;
            prizePercentageValue.Text = "0";
            prizePercentageValue.TextChanged += prizePercentageValue_TextChanged;
            // 
            // prizePercentageLabel
            // 
            prizePercentageLabel.AutoSize = true;
            prizePercentageLabel.Font = new Font("Segoe UI Light", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            prizePercentageLabel.ForeColor = Color.SteelBlue;
            prizePercentageLabel.Location = new Point(12, 318);
            prizePercentageLabel.Name = "prizePercentageLabel";
            prizePercentageLabel.Size = new Size(262, 46);
            prizePercentageLabel.TabIndex = 19;
            prizePercentageLabel.Text = "Prize Percentage:";
            // 
            // orLabel
            // 
            orLabel.AutoSize = true;
            orLabel.Font = new Font("Segoe UI Light", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            orLabel.ForeColor = Color.SteelBlue;
            orLabel.Location = new Point(167, 261);
            orLabel.Name = "orLabel";
            orLabel.Size = new Size(93, 46);
            orLabel.TabIndex = 21;
            orLabel.Text = "-OR-";
            // 
            // createPrizeButton
            // 
            createPrizeButton.FlatAppearance.BorderColor = Color.Gray;
            createPrizeButton.FlatAppearance.BorderSize = 2;
            createPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createPrizeButton.FlatStyle = FlatStyle.Flat;
            createPrizeButton.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            createPrizeButton.ForeColor = Color.SteelBlue;
            createPrizeButton.Location = new Point(104, 406);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(217, 54);
            createPrizeButton.TabIndex = 22;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            createPrizeButton.Click += createPrizeButton_Click;
            // 
            // CreatePrizeForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(441, 505);
            Controls.Add(createPrizeButton);
            Controls.Add(orLabel);
            Controls.Add(prizePercentageValue);
            Controls.Add(prizePercentageLabel);
            Controls.Add(prizeAmountValue);
            Controls.Add(prizeAmountLabel);
            Controls.Add(placeNameValue);
            Controls.Add(placeNameLabel);
            Controls.Add(placeNumberValue);
            Controls.Add(placeNumberLAbel);
            Controls.Add(HeaderLabel);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.SteelBlue;
            Margin = new Padding(6);
            Name = "CreatePrizeForm";
            Text = "Create Prize";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HeaderLabel;
        private TextBox placeNumberValue;
        private Label placeNumberLAbel;
        private TextBox placeNameValue;
        private Label placeNameLabel;
        private TextBox prizeAmountValue;
        private Label prizeAmountLabel;
        private TextBox prizePercentageValue;
        private Label prizePercentageLabel;
        private Label orLabel;
        private Button createPrizeButton;
    }
}