namespace Tutorial_homework2
{
    partial class Form1
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
            label1 = new Label();
            eightPictureBox = new PictureBox();
            thirteenPictureBox = new PictureBox();
            twoPictureBox = new PictureBox();
            onePictureBox = new PictureBox();
            elevenPictureBox = new PictureBox();
            shownameLabel = new Label();
            exitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)eightPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)thirteenPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)twoPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)onePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)elevenPictureBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("新細明體", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label1.Location = new Point(229, 40);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(1007, 87);
            label1.TabIndex = 0;
            label1.Text = "Click a Card to See Its Name";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // eightPictureBox
            // 
            eightPictureBox.Image = Properties.Resources._8_Diamonds;
            eightPictureBox.Location = new Point(15, 131);
            eightPictureBox.Margin = new Padding(4);
            eightPictureBox.Name = "eightPictureBox";
            eightPictureBox.Size = new Size(291, 335);
            eightPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            eightPictureBox.TabIndex = 1;
            eightPictureBox.TabStop = false;
            eightPictureBox.Click += eightPictureBox_Click;
            // 
            // thirteenPictureBox
            // 
            thirteenPictureBox.Image = Properties.Resources.King_Spades;
            thirteenPictureBox.Location = new Point(578, 131);
            thirteenPictureBox.Margin = new Padding(4);
            thirteenPictureBox.Name = "thirteenPictureBox";
            thirteenPictureBox.Size = new Size(291, 335);
            thirteenPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            thirteenPictureBox.TabIndex = 2;
            thirteenPictureBox.TabStop = false;
            thirteenPictureBox.Click += thirteenPictureBox_Click;
            // 
            // twoPictureBox
            // 
            twoPictureBox.Image = Properties.Resources._2_Clubs;
            twoPictureBox.Location = new Point(293, 131);
            twoPictureBox.Margin = new Padding(4);
            twoPictureBox.Name = "twoPictureBox";
            twoPictureBox.Size = new Size(291, 335);
            twoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            twoPictureBox.TabIndex = 3;
            twoPictureBox.TabStop = false;
            twoPictureBox.Click += twoPictureBox_Click;
            // 
            // onePictureBox
            // 
            onePictureBox.Image = Properties.Resources.Ace_Spades;
            onePictureBox.Location = new Point(860, 131);
            onePictureBox.Margin = new Padding(4);
            onePictureBox.Name = "onePictureBox";
            onePictureBox.Size = new Size(291, 335);
            onePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            onePictureBox.TabIndex = 4;
            onePictureBox.TabStop = false;
            onePictureBox.Click += onePictureBox_Click;
            // 
            // elevenPictureBox
            // 
            elevenPictureBox.Image = Properties.Resources.Joker_Black;
            elevenPictureBox.Location = new Point(1144, 131);
            elevenPictureBox.Margin = new Padding(4);
            elevenPictureBox.Name = "elevenPictureBox";
            elevenPictureBox.Size = new Size(291, 335);
            elevenPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            elevenPictureBox.TabIndex = 5;
            elevenPictureBox.TabStop = false;
            elevenPictureBox.Click += elevenPictureBox_Click;
            // 
            // shownameLabel
            // 
            shownameLabel.BorderStyle = BorderStyle.FixedSingle;
            shownameLabel.Font = new Font("新細明體", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 136);
            shownameLabel.Location = new Point(15, 481);
            shownameLabel.Margin = new Padding(4, 0, 4, 0);
            shownameLabel.Name = "shownameLabel";
            shownameLabel.Size = new Size(1420, 67);
            shownameLabel.TabIndex = 6;
            shownameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            exitButton.BackColor = SystemColors.ActiveBorder;
            exitButton.Font = new Font("新細明體", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 136);
            exitButton.Location = new Point(578, 567);
            exitButton.Margin = new Padding(4);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(291, 69);
            exitButton.TabIndex = 7;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1450, 650);
            Controls.Add(exitButton);
            Controls.Add(shownameLabel);
            Controls.Add(elevenPictureBox);
            Controls.Add(onePictureBox);
            Controls.Add(twoPictureBox);
            Controls.Add(thirteenPictureBox);
            Controls.Add(eightPictureBox);
            Controls.Add(label1);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Card Identifier";
            ((System.ComponentModel.ISupportInitialize)eightPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)thirteenPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)twoPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)onePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)elevenPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private PictureBox eightPictureBox;
        private PictureBox thirteenPictureBox;
        private PictureBox twoPictureBox;
        private PictureBox onePictureBox;
        private PictureBox elevenPictureBox;
        private Label shownameLabel;
        private Button exitButton;
    }
}
