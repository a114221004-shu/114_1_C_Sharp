namespace RadioButtonDemo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.coffeeRadioButton = new System.Windows.Forms.RadioButton();
            this.milkteaRadioButton = new System.Windows.Forms.RadioButton();
            this.redteaRadioButton = new System.Windows.Forms.RadioButton();
            this.juiceRadioButton = new System.Windows.Forms.RadioButton();
            this.jellyRadioButton = new System.Windows.Forms.RadioButton();
            this.hanRadioButton = new System.Windows.Forms.RadioButton();
            this.tunaRadioButton = new System.Windows.Forms.RadioButton();
            this.sendButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.jellyRadioButton);
            this.groupBox1.Controls.Add(this.hanRadioButton);
            this.groupBox1.Controls.Add(this.tunaRadioButton);
            this.groupBox1.Font = new System.Drawing.Font("華康新特明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(629, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 483);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "三明治";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.juiceRadioButton);
            this.groupBox2.Controls.Add(this.redteaRadioButton);
            this.groupBox2.Controls.Add(this.milkteaRadioButton);
            this.groupBox2.Controls.Add(this.coffeeRadioButton);
            this.groupBox2.Font = new System.Drawing.Font("華康新特明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(62, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(425, 505);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "飲料";
            // 
            // coffeeRadioButton
            // 
            this.coffeeRadioButton.AutoSize = true;
            this.coffeeRadioButton.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.coffeeRadioButton.Location = new System.Drawing.Point(72, 88);
            this.coffeeRadioButton.Name = "coffeeRadioButton";
            this.coffeeRadioButton.Size = new System.Drawing.Size(122, 44);
            this.coffeeRadioButton.TabIndex = 1;
            this.coffeeRadioButton.TabStop = true;
            this.coffeeRadioButton.Text = "咖啡";
            this.coffeeRadioButton.UseVisualStyleBackColor = true;
            // 
            // milkteaRadioButton
            // 
            this.milkteaRadioButton.AutoSize = true;
            this.milkteaRadioButton.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.milkteaRadioButton.Location = new System.Drawing.Point(72, 190);
            this.milkteaRadioButton.Name = "milkteaRadioButton";
            this.milkteaRadioButton.Size = new System.Drawing.Size(122, 44);
            this.milkteaRadioButton.TabIndex = 4;
            this.milkteaRadioButton.TabStop = true;
            this.milkteaRadioButton.Text = "奶茶";
            this.milkteaRadioButton.UseVisualStyleBackColor = true;
            // 
            // redteaRadioButton
            // 
            this.redteaRadioButton.AutoSize = true;
            this.redteaRadioButton.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.redteaRadioButton.Location = new System.Drawing.Point(72, 290);
            this.redteaRadioButton.Name = "redteaRadioButton";
            this.redteaRadioButton.Size = new System.Drawing.Size(122, 44);
            this.redteaRadioButton.TabIndex = 5;
            this.redteaRadioButton.TabStop = true;
            this.redteaRadioButton.Text = "紅茶";
            this.redteaRadioButton.UseVisualStyleBackColor = true;
            // 
            // juiceRadioButton
            // 
            this.juiceRadioButton.AutoSize = true;
            this.juiceRadioButton.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.juiceRadioButton.Location = new System.Drawing.Point(72, 382);
            this.juiceRadioButton.Name = "juiceRadioButton";
            this.juiceRadioButton.Size = new System.Drawing.Size(122, 44);
            this.juiceRadioButton.TabIndex = 6;
            this.juiceRadioButton.TabStop = true;
            this.juiceRadioButton.Text = "果汁";
            this.juiceRadioButton.UseVisualStyleBackColor = true;
            // 
            // jellyRadioButton
            // 
            this.jellyRadioButton.AutoSize = true;
            this.jellyRadioButton.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.jellyRadioButton.Location = new System.Drawing.Point(43, 87);
            this.jellyRadioButton.Name = "jellyRadioButton";
            this.jellyRadioButton.Size = new System.Drawing.Size(242, 44);
            this.jellyRadioButton.TabIndex = 14;
            this.jellyRadioButton.TabStop = true;
            this.jellyRadioButton.Text = "果醬三明治";
            this.jellyRadioButton.UseVisualStyleBackColor = true;
            // 
            // hanRadioButton
            // 
            this.hanRadioButton.AutoSize = true;
            this.hanRadioButton.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.hanRadioButton.Location = new System.Drawing.Point(43, 300);
            this.hanRadioButton.Name = "hanRadioButton";
            this.hanRadioButton.Size = new System.Drawing.Size(242, 44);
            this.hanRadioButton.TabIndex = 13;
            this.hanRadioButton.TabStop = true;
            this.hanRadioButton.Text = "火腿三明治";
            this.hanRadioButton.UseVisualStyleBackColor = true;
            // 
            // tunaRadioButton
            // 
            this.tunaRadioButton.AutoSize = true;
            this.tunaRadioButton.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tunaRadioButton.Location = new System.Drawing.Point(43, 196);
            this.tunaRadioButton.Name = "tunaRadioButton";
            this.tunaRadioButton.Size = new System.Drawing.Size(242, 44);
            this.tunaRadioButton.TabIndex = 12;
            this.tunaRadioButton.TabStop = true;
            this.tunaRadioButton.Text = "鮪魚三明治";
            this.tunaRadioButton.UseVisualStyleBackColor = true;
            // 
            // sendButton
            // 
            this.sendButton.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sendButton.Location = new System.Drawing.Point(189, 656);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(201, 72);
            this.sendButton.TabIndex = 9;
            this.sendButton.Text = "送出訂單";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exitButton.Location = new System.Drawing.Point(694, 656);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(201, 72);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 770);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton jellyRadioButton;
        private System.Windows.Forms.RadioButton hanRadioButton;
        private System.Windows.Forms.RadioButton tunaRadioButton;
        private System.Windows.Forms.RadioButton juiceRadioButton;
        private System.Windows.Forms.RadioButton redteaRadioButton;
        private System.Windows.Forms.RadioButton milkteaRadioButton;
        private System.Windows.Forms.RadioButton coffeeRadioButton;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button exitButton;
    }
}

