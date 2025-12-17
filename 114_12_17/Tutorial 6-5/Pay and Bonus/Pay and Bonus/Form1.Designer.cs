namespace Pay_and_Bonus
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除所使用的資源。
        /// </summary>
        /// <param name="disposing">若為 true，表示應該釋放受控資源；否則只釋放非受控資源。</param>
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
        /// 初始化表單元件的方法。
        ///
        /// 註解(繁體中文)：
        /// 這個方法由 Visual Studio 設計工具自動產生，用來建立並配置所有 UI 元件。
        /// 以下變更內容：
        /// 1) 將所有元件的 Text 屬性改為繁體中文。
        /// 2) 將所有元件的 Font 設為 Microsoft JhengHei (微軟正黑體)，字型大小為 18。
        /// 3) 適度調整每個元件的 Size 與 Location，以便在較大的字型下仍保持良好排列。
        /// 4) 每個元件前加入繁體中文註解，說明其用途與設定重點。
        ///
        /// 注意：不要修改其他程式邏輯（例如事件處理器的名稱或簽章）。
        /// </summary>
        private void InitializeComponent()
        {
            // 建立並設定總薪資提示標籤
            this.grossPayPromptLabel = new System.Windows.Forms.Label();
            // 建立並設定獎金提示標籤
            this.bonusPromptLabel = new System.Windows.Forms.Label();
            // 建立並設定總薪資輸入欄位
            this.grossPayTextBox = new System.Windows.Forms.TextBox();
            // 建立並設定獎金輸入欄位
            this.bonusTextBox = new System.Windows.Forms.TextBox();
            // 建立並設定輸出說明標籤（例如：退休金提撥）
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            // 建立並設定顯示提撥金額的標籤（有邊框，置中）
            this.contributionLabel = new System.Windows.Forms.Label();
            // 建立並設定計算按鈕
            this.calculateButton = new System.Windows.Forms.Button();
            // 建立並設定結束按鈕
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // grossPayPromptLabel
            // 總薪資的提示文字，改為繁體中文並使用 18pt 字型，禁用 AutoSize 並自訂大小以配合字型
            // 
            this.grossPayPromptLabel.AutoSize = false;
            this.grossPayPromptLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grossPayPromptLabel.Location = new System.Drawing.Point(20, 18);
            this.grossPayPromptLabel.Name = "grossPayPromptLabel";
            this.grossPayPromptLabel.Size = new System.Drawing.Size(200, 34);
            this.grossPayPromptLabel.TabIndex = 0;
            this.grossPayPromptLabel.Text = "總薪資：";
            this.grossPayPromptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bonusPromptLabel
            // 獎金的提示文字，改為繁體中文並使用 18pt 字型
            // 
            this.bonusPromptLabel.AutoSize = false;
            this.bonusPromptLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bonusPromptLabel.Location = new System.Drawing.Point(20, 68);
            this.bonusPromptLabel.Name = "bonusPromptLabel";
            this.bonusPromptLabel.Size = new System.Drawing.Size(200, 34);
            this.bonusPromptLabel.TabIndex = 1;
            this.bonusPromptLabel.Text = "獎金金額：";
            this.bonusPromptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grossPayTextBox
            // 總薪資輸入欄位，字型放大以利顯示，調整高度以配合字型
            // 
            this.grossPayTextBox.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grossPayTextBox.Location = new System.Drawing.Point(230, 16);
            this.grossPayTextBox.Name = "grossPayTextBox";
            this.grossPayTextBox.Size = new System.Drawing.Size(200, 39);
            this.grossPayTextBox.TabIndex = 2;
            // 
            // bonusTextBox
            // 獎金輸入欄位，字型放大以利顯示，調整高度以配合字型
            // 
            this.bonusTextBox.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bonusTextBox.Location = new System.Drawing.Point(230, 66);
            this.bonusTextBox.Name = "bonusTextBox";
            this.bonusTextBox.Size = new System.Drawing.Size(200, 39);
            this.bonusTextBox.TabIndex = 3;
            // 
            // outputDescriptionLabel
            // 輸出說明（例如：退休金提撥），改為繁體中文並使用較大字型
            // 
            this.outputDescriptionLabel.AutoSize = false;
            this.outputDescriptionLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.outputDescriptionLabel.Location = new System.Drawing.Point(20, 116);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(200, 34);
            this.outputDescriptionLabel.TabIndex = 4;
            this.outputDescriptionLabel.Text = "退休金提撥：";
            this.outputDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // contributionLabel
            // 顯示計算結果的標籤，保留固定邊框並置中顯示文字，字型也放大
            // 
            this.contributionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contributionLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.contributionLabel.Location = new System.Drawing.Point(230, 112);
            this.contributionLabel.Name = "contributionLabel";
            this.contributionLabel.Size = new System.Drawing.Size(200, 42);
            this.contributionLabel.TabIndex = 5;
            this.contributionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateButton
            // 計算按鈕，改為繁體中文文字，字型 18，並增加按鈕大小以利顯示
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.calculateButton.Location = new System.Drawing.Point(60, 170);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(140, 50);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "計算提撥";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 結束按鈕，改為繁體中文並使用相同字型大小
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exitButton.Location = new System.Drawing.Point(260, 170);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(140, 50);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "結束";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 設定表單標題為繁體中文，並調整表單整體大小以容納較大字型的元件
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 240);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.contributionLabel);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.bonusTextBox);
            this.Controls.Add(this.grossPayTextBox);
            this.Controls.Add(this.bonusPromptLabel);
            this.Controls.Add(this.grossPayPromptLabel);
            this.Name = "Form1";
            this.Text = "薪資與獎金";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label grossPayPromptLabel;
        private System.Windows.Forms.Label bonusPromptLabel;
        private System.Windows.Forms.TextBox grossPayTextBox;
        private System.Windows.Forms.TextBox bonusTextBox;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.Label contributionLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
    }
}

