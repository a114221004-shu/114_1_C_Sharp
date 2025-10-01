namespace Tutorial_homework1
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
            headPictureBox = new PictureBox();
            tailPictureBox = new PictureBox();
            showheadsButton = new Button();
            exitButton = new Button();
            showtailsButton = new Button();
            ((System.ComponentModel.ISupportInitialize)headPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tailPictureBox).BeginInit();
            SuspendLayout();
            // 
            // headPictureBox
            // 
            headPictureBox.Image = Properties.Resources.Heads1;
            headPictureBox.Location = new Point(55, 47);
            headPictureBox.Name = "headPictureBox";
            headPictureBox.Size = new Size(312, 224);
            headPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            headPictureBox.TabIndex = 0;
            headPictureBox.TabStop = false;
            headPictureBox.Click += headPictureBox_Click;
            // 
            // tailPictureBox
            // 
            tailPictureBox.Image = Properties.Resources.Tails1;
            tailPictureBox.Location = new Point(433, 47);
            tailPictureBox.Name = "tailPictureBox";
            tailPictureBox.Size = new Size(312, 224);
            tailPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            tailPictureBox.TabIndex = 1;
            tailPictureBox.TabStop = false;
            tailPictureBox.Click += tailPictureBox_Click;
            // 
            // showheadsButton
            // 
            showheadsButton.BackColor = SystemColors.ActiveBorder;
            showheadsButton.Font = new Font("新細明體", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 136);
            showheadsButton.Location = new Point(30, 310);
            showheadsButton.Name = "showheadsButton";
            showheadsButton.Size = new Size(221, 74);
            showheadsButton.TabIndex = 2;
            showheadsButton.Text = "Show Heads";
            showheadsButton.UseVisualStyleBackColor = false;
            showheadsButton.Click += showheadsButton_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = SystemColors.ActiveBorder;
            exitButton.Font = new Font("新細明體", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 136);
            exitButton.Location = new Point(546, 310);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(221, 74);
            exitButton.TabIndex = 3;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // showtailsButton
            // 
            showtailsButton.BackColor = SystemColors.ActiveBorder;
            showtailsButton.Font = new Font("新細明體", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 136);
            showtailsButton.Location = new Point(294, 310);
            showtailsButton.Name = "showtailsButton";
            showtailsButton.Size = new Size(221, 74);
            showtailsButton.TabIndex = 4;
            showtailsButton.Text = "Show Tails";
            showtailsButton.UseVisualStyleBackColor = false;
            showtailsButton.Click += showtailsButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(showtailsButton);
            Controls.Add(exitButton);
            Controls.Add(showheadsButton);
            Controls.Add(tailPictureBox);
            Controls.Add(headPictureBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)headPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)tailPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox headPictureBox;
        private PictureBox tailPictureBox;
        private Button showheadsButton;
        private Button exitButton;
        private Button showtailsButton;
    }
}
