namespace How_Much_Insurance
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.insuranceLabel = new System.Windows.Forms.Label();
            this.costButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(90, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "建築物價錢：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(135, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "保險金額：";
            // 
            // costTextBox
            // 
            this.costTextBox.Font = new System.Drawing.Font("新細明體", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.costTextBox.Location = new System.Drawing.Point(385, 83);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(296, 60);
            this.costTextBox.TabIndex = 2;
            // 
            // insuranceLabel
            // 
            this.insuranceLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.insuranceLabel.Font = new System.Drawing.Font("新細明體", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.insuranceLabel.Location = new System.Drawing.Point(385, 181);
            this.insuranceLabel.Name = "insuranceLabel";
            this.insuranceLabel.Size = new System.Drawing.Size(296, 57);
            this.insuranceLabel.TabIndex = 3;
            this.insuranceLabel.Text = "\r\n";
            // 
            // costButton
            // 
            this.costButton.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.costButton.Location = new System.Drawing.Point(98, 327);
            this.costButton.Name = "costButton";
            this.costButton.Size = new System.Drawing.Size(187, 71);
            this.costButton.TabIndex = 4;
            this.costButton.Text = "計算";
            this.costButton.UseVisualStyleBackColor = true;
            this.costButton.Click += new System.EventHandler(this.costButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exitButton.Location = new System.Drawing.Point(506, 327);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(187, 71);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.clearButton.Location = new System.Drawing.Point(301, 327);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(187, 71);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "清除";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.costButton);
            this.Controls.Add(this.insuranceLabel);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "計算保險費";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.Label insuranceLabel;
        private System.Windows.Forms.Button costButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
    }
}

