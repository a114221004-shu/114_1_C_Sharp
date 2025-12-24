namespace Q1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.computerLabel = new System.Windows.Forms.Label();
            this.playerLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.stoneButton = new System.Windows.Forms.Button();
            this.paperButton = new System.Windows.Forms.Button();
            this.scissorButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.playerPictureBox = new System.Windows.Forms.PictureBox();
            this.paper_computerPictureBox = new System.Windows.Forms.PictureBox();
            this.scissor_computerPictureBox = new System.Windows.Forms.PictureBox();
            this.stone_computerPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paper_computerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scissor_computerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stone_computerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // computerLabel
            // 
            this.computerLabel.AutoSize = true;
            this.computerLabel.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.computerLabel.Location = new System.Drawing.Point(133, 65);
            this.computerLabel.Name = "computerLabel";
            this.computerLabel.Size = new System.Drawing.Size(126, 36);
            this.computerLabel.TabIndex = 0;
            this.computerLabel.Text = "電腦出";
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.playerLabel.Location = new System.Drawing.Point(503, 65);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(126, 36);
            this.playerLabel.TabIndex = 1;
            this.playerLabel.Text = "玩家出";
            // 
            // resultLabel
            // 
            this.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultLabel.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.resultLabel.Location = new System.Drawing.Point(173, 338);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(444, 62);
            this.resultLabel.TabIndex = 2;
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stoneButton
            // 
            this.stoneButton.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.stoneButton.Location = new System.Drawing.Point(64, 453);
            this.stoneButton.Name = "stoneButton";
            this.stoneButton.Size = new System.Drawing.Size(164, 62);
            this.stoneButton.TabIndex = 3;
            this.stoneButton.Text = "石頭";
            this.stoneButton.UseVisualStyleBackColor = true;
            this.stoneButton.Click += new System.EventHandler(this.stoneButton_Click);
            // 
            // paperButton
            // 
            this.paperButton.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.paperButton.Location = new System.Drawing.Point(312, 453);
            this.paperButton.Name = "paperButton";
            this.paperButton.Size = new System.Drawing.Size(164, 62);
            this.paperButton.TabIndex = 4;
            this.paperButton.Text = "布";
            this.paperButton.UseVisualStyleBackColor = true;
            this.paperButton.Click += new System.EventHandler(this.paperButton_Click);
            // 
            // scissorButton
            // 
            this.scissorButton.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.scissorButton.Location = new System.Drawing.Point(558, 453);
            this.scissorButton.Name = "scissorButton";
            this.scissorButton.Size = new System.Drawing.Size(164, 62);
            this.scissorButton.TabIndex = 5;
            this.scissorButton.Text = "剪刀";
            this.scissorButton.UseVisualStyleBackColor = true;
            this.scissorButton.Click += new System.EventHandler(this.scissorButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exitButton.Location = new System.Drawing.Point(220, 564);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(339, 62);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "遊戲結束";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // playerPictureBox
            // 
            this.playerPictureBox.Image = global::Q1.Properties.Resources.paper_player;
            this.playerPictureBox.Location = new System.Drawing.Point(446, 140);
            this.playerPictureBox.Name = "playerPictureBox";
            this.playerPictureBox.Size = new System.Drawing.Size(253, 147);
            this.playerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerPictureBox.TabIndex = 9;
            this.playerPictureBox.TabStop = false;
            // 
            // paper_computerPictureBox
            // 
            this.paper_computerPictureBox.Image = global::Q1.Properties.Resources.paper_computer;
            this.paper_computerPictureBox.Location = new System.Drawing.Point(67, 140);
            this.paper_computerPictureBox.Name = "paper_computerPictureBox";
            this.paper_computerPictureBox.Size = new System.Drawing.Size(253, 147);
            this.paper_computerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.paper_computerPictureBox.TabIndex = 7;
            this.paper_computerPictureBox.TabStop = false;
            // 
            // scissor_computerPictureBox
            // 
            this.scissor_computerPictureBox.Image = global::Q1.Properties.Resources.scissor_computer;
            this.scissor_computerPictureBox.Location = new System.Drawing.Point(64, 140);
            this.scissor_computerPictureBox.Name = "scissor_computerPictureBox";
            this.scissor_computerPictureBox.Size = new System.Drawing.Size(253, 147);
            this.scissor_computerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.scissor_computerPictureBox.TabIndex = 10;
            this.scissor_computerPictureBox.TabStop = false;
            // 
            // stone_computerPictureBox
            // 
            this.stone_computerPictureBox.Image = global::Q1.Properties.Resources.stone_computer;
            this.stone_computerPictureBox.Location = new System.Drawing.Point(67, 140);
            this.stone_computerPictureBox.Name = "stone_computerPictureBox";
            this.stone_computerPictureBox.Size = new System.Drawing.Size(253, 147);
            this.stone_computerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.stone_computerPictureBox.TabIndex = 11;
            this.stone_computerPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 667);
            this.Controls.Add(this.stone_computerPictureBox);
            this.Controls.Add(this.scissor_computerPictureBox);
            this.Controls.Add(this.playerPictureBox);
            this.Controls.Add(this.paper_computerPictureBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.scissorButton);
            this.Controls.Add(this.paperButton);
            this.Controls.Add(this.stoneButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.playerLabel);
            this.Controls.Add(this.computerLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paper_computerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scissor_computerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stone_computerPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label computerLabel;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button stoneButton;
        private System.Windows.Forms.Button paperButton;
        private System.Windows.Forms.Button scissorButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox paper_computerPictureBox;
        private System.Windows.Forms.PictureBox playerPictureBox;
        private System.Windows.Forms.PictureBox scissor_computerPictureBox;
        private System.Windows.Forms.PictureBox stone_computerPictureBox;
    }
}

