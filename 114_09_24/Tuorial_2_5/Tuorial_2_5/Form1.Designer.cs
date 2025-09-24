namespace Tuorial_2_5
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
            this.cardfacePictureBox = new System.Windows.Forms.PictureBox();
            this.cardbackPictureBox = new System.Windows.Forms.PictureBox();
            this.showbackButton = new System.Windows.Forms.Button();
            this.showfaceButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cardfacePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardbackPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cardfacePictureBox
            // 
            this.cardfacePictureBox.Image = global::Tuorial_2_5.Properties.Resources.Ace_Hearts;
            this.cardfacePictureBox.Location = new System.Drawing.Point(348, 32);
            this.cardfacePictureBox.Name = "cardfacePictureBox";
            this.cardfacePictureBox.Size = new System.Drawing.Size(202, 325);
            this.cardfacePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardfacePictureBox.TabIndex = 1;
            this.cardfacePictureBox.TabStop = false;
            this.cardfacePictureBox.Visible = false;
            this.cardfacePictureBox.Click += new System.EventHandler(this.cardfacePictureBox_Click);
            // 
            // cardbackPictureBox
            // 
            this.cardbackPictureBox.Image = global::Tuorial_2_5.Properties.Resources.Backface_Red;
            this.cardbackPictureBox.Location = new System.Drawing.Point(46, 32);
            this.cardbackPictureBox.Name = "cardbackPictureBox";
            this.cardbackPictureBox.Size = new System.Drawing.Size(202, 325);
            this.cardbackPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardbackPictureBox.TabIndex = 0;
            this.cardbackPictureBox.TabStop = false;
            this.cardbackPictureBox.Visible = false;
            this.cardbackPictureBox.Click += new System.EventHandler(this.cardnackPictureBox_Click);
            // 
            // showbackButton
            // 
            this.showbackButton.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.showbackButton.Location = new System.Drawing.Point(77, 377);
            this.showbackButton.Name = "showbackButton";
            this.showbackButton.Size = new System.Drawing.Size(147, 49);
            this.showbackButton.TabIndex = 2;
            this.showbackButton.Text = "顯示背面";
            this.showbackButton.UseVisualStyleBackColor = true;
            this.showbackButton.Click += new System.EventHandler(this.showbackButton_Click);
            // 
            // showfaceButton
            // 
            this.showfaceButton.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.showfaceButton.Location = new System.Drawing.Point(380, 377);
            this.showfaceButton.Name = "showfaceButton";
            this.showfaceButton.Size = new System.Drawing.Size(147, 49);
            this.showfaceButton.TabIndex = 3;
            this.showfaceButton.Text = "顯示正面";
            this.showfaceButton.UseVisualStyleBackColor = true;
            this.showfaceButton.Click += new System.EventHandler(this.showfaceButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 450);
            this.Controls.Add(this.showfaceButton);
            this.Controls.Add(this.showbackButton);
            this.Controls.Add(this.cardfacePictureBox);
            this.Controls.Add(this.cardbackPictureBox);
            this.Name = "Form1";
            this.Text = "翻轉撲克牌";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cardfacePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardbackPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox cardbackPictureBox;
        private System.Windows.Forms.PictureBox cardfacePictureBox;
        private System.Windows.Forms.Button showbackButton;
        private System.Windows.Forms.Button showfaceButton;
    }
}

