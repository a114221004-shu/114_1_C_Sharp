namespace South_America
{
    partial class Form1
    {
        /// <summary>
        /// 必需的設計器變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的資源。
        /// </summary>
        /// <param name="disposing">如果應釋放託管資源，則為 true；否則為 false。</param>
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
        /// 設計器支援所需的方法 - 請勿使用程式碼編輯器修改此方法的內容。
        /// 以下為 InitializeComponent 的實作，會建立表單中的所有元件並設定其屬性。
        /// 我在這裡加入繁體中文的詳細註解，說明每個元件的用途與屬性變更，並將所有可見文字設為繁體中文，字型大小設為 18。
        /// 注意：其他程式邏輯與控制項名稱皆保持不變。
        /// </summary>
        private void InitializeComponent()
        {
            this.countriesListBox = new System.Windows.Forms.ListBox();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.getCountriesButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // countriesListBox
            // 
            this.countriesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countriesListBox.FormattingEnabled = true;
            this.countriesListBox.ItemHeight = 40;
            this.countriesListBox.Location = new System.Drawing.Point(173, 147);
            this.countriesListBox.Name = "countriesListBox";
            this.countriesListBox.Size = new System.Drawing.Size(684, 364);
            this.countriesListBox.TabIndex = 0;
            this.countriesListBox.SelectedIndexChanged += new System.EventHandler(this.countriesListBox_SelectedIndexChanged);
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputDescriptionLabel.Location = new System.Drawing.Point(166, 65);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(239, 40);
            this.outputDescriptionLabel.TabIndex = 1;
            this.outputDescriptionLabel.Text = "南美洲的國家";
            // 
            // getCountriesButton
            // 
            this.getCountriesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getCountriesButton.Location = new System.Drawing.Point(173, 544);
            this.getCountriesButton.Name = "getCountriesButton";
            this.getCountriesButton.Size = new System.Drawing.Size(214, 75);
            this.getCountriesButton.TabIndex = 2;
            this.getCountriesButton.Text = "取得國家";
            this.getCountriesButton.UseVisualStyleBackColor = true;
            this.getCountriesButton.Click += new System.EventHandler(this.getCountriesButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(634, 544);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(214, 75);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 683);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.getCountriesButton);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.countriesListBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "南美洲";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox countriesListBox;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.Button getCountriesButton;
        private System.Windows.Forms.Button exitButton;
    }
}
