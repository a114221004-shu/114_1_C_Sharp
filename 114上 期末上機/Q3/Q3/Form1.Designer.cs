namespace Q3
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
            this.number1Label = new System.Windows.Forms.Label();
            this.number5Label = new System.Windows.Forms.Label();
            this.number4Label = new System.Windows.Forms.Label();
            this.number3Label = new System.Windows.Forms.Label();
            this.number2Label = new System.Windows.Forms.Label();
            this.numberButton = new System.Windows.Forms.Button();
            this.opennumberButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // number1Label
            // 
            this.number1Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.number1Label.Font = new System.Drawing.Font("新細明體", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.number1Label.Location = new System.Drawing.Point(107, 85);
            this.number1Label.Name = "number1Label";
            this.number1Label.Size = new System.Drawing.Size(143, 90);
            this.number1Label.TabIndex = 0;
            this.number1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // number5Label
            // 
            this.number5Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.number5Label.Font = new System.Drawing.Font("新細明體", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.number5Label.Location = new System.Drawing.Point(896, 85);
            this.number5Label.Name = "number5Label";
            this.number5Label.Size = new System.Drawing.Size(143, 90);
            this.number5Label.TabIndex = 1;
            this.number5Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // number4Label
            // 
            this.number4Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.number4Label.Font = new System.Drawing.Font("新細明體", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.number4Label.Location = new System.Drawing.Point(706, 85);
            this.number4Label.Name = "number4Label";
            this.number4Label.Size = new System.Drawing.Size(143, 90);
            this.number4Label.TabIndex = 2;
            this.number4Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // number3Label
            // 
            this.number3Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.number3Label.Font = new System.Drawing.Font("新細明體", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.number3Label.Location = new System.Drawing.Point(504, 85);
            this.number3Label.Name = "number3Label";
            this.number3Label.Size = new System.Drawing.Size(143, 90);
            this.number3Label.TabIndex = 3;
            this.number3Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // number2Label
            // 
            this.number2Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.number2Label.Font = new System.Drawing.Font("新細明體", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.number2Label.Location = new System.Drawing.Point(307, 85);
            this.number2Label.Name = "number2Label";
            this.number2Label.Size = new System.Drawing.Size(143, 90);
            this.number2Label.TabIndex = 4;
            this.number2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numberButton
            // 
            this.numberButton.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.numberButton.Location = new System.Drawing.Point(55, 227);
            this.numberButton.Name = "numberButton";
            this.numberButton.Size = new System.Drawing.Size(232, 96);
            this.numberButton.TabIndex = 5;
            this.numberButton.Text = "產生號碼";
            this.numberButton.UseVisualStyleBackColor = true;
            this.numberButton.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // opennumberButton
            // 
            this.opennumberButton.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.opennumberButton.Location = new System.Drawing.Point(471, 227);
            this.opennumberButton.Name = "opennumberButton";
            this.opennumberButton.Size = new System.Drawing.Size(232, 96);
            this.opennumberButton.TabIndex = 6;
            this.opennumberButton.Text = "開獎號碼";
            this.opennumberButton.UseVisualStyleBackColor = true;
            this.opennumberButton.Click += new System.EventHandler(this.opennumberButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exitButton.Location = new System.Drawing.Point(909, 227);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(232, 96);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 36;
            this.listBox1.Location = new System.Drawing.Point(55, 369);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(609, 364);
            this.listBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 850);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.opennumberButton);
            this.Controls.Add(this.numberButton);
            this.Controls.Add(this.number2Label);
            this.Controls.Add(this.number3Label);
            this.Controls.Add(this.number4Label);
            this.Controls.Add(this.number5Label);
            this.Controls.Add(this.number1Label);
            this.Name = "Form1";
            this.Text = "樂透號碼產生器";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label number1Label;
        private System.Windows.Forms.Label number5Label;
        private System.Windows.Forms.Label number4Label;
        private System.Windows.Forms.Label number3Label;
        private System.Windows.Forms.Label number2Label;
        private System.Windows.Forms.Button numberButton;
        private System.Windows.Forms.Button opennumberButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListBox listBox1;
    }
}

