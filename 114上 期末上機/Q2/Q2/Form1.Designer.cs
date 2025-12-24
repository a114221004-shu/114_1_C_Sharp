namespace Q2
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
            this.oilGroupBox = new System.Windows.Forms.GroupBox();
            this.lubeCheckbox = new System.Windows.Forms.CheckBox();
            this.oilchangeCheckBox = new System.Windows.Forms.CheckBox();
            this.WashGroupBox = new System.Windows.Forms.GroupBox();
            this.transCheckBox = new System.Windows.Forms.CheckBox();
            this.radiatorCheckBox = new System.Windows.Forms.CheckBox();
            this.OtherGroupBox = new System.Windows.Forms.GroupBox();
            this.tireCheckBox = new System.Windows.Forms.CheckBox();
            this.mufflerCheckBox = new System.Windows.Forms.CheckBox();
            this.inspectCheckBox = new System.Windows.Forms.CheckBox();
            this.PartsHoursGroupBox = new System.Windows.Forms.GroupBox();
            this.labelParts = new System.Windows.Forms.Label();
            this.labelHours = new System.Windows.Forms.Label();
            this.partsTextbox = new System.Windows.Forms.TextBox();
            this.hoursTextbox = new System.Windows.Forms.TextBox();
            this.SummaryGroupBox = new System.Windows.Forms.GroupBox();
            this.servicelaborLabel = new System.Windows.Forms.Label();
            this.partscostLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.txtServiceLabor = new System.Windows.Forms.TextBox();
            this.txtPartsCost = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.oilGroupBox.SuspendLayout();
            this.WashGroupBox.SuspendLayout();
            this.OtherGroupBox.SuspendLayout();
            this.PartsHoursGroupBox.SuspendLayout();
            this.SummaryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // oilGroupBox
            // 
            this.oilGroupBox.Controls.Add(this.lubeCheckbox);
            this.oilGroupBox.Controls.Add(this.oilchangeCheckBox);
            this.oilGroupBox.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.oilGroupBox.Location = new System.Drawing.Point(12, 29);
            this.oilGroupBox.Name = "oilGroupBox";
            this.oilGroupBox.Size = new System.Drawing.Size(479, 179);
            this.oilGroupBox.TabIndex = 0;
            this.oilGroupBox.TabStop = false;
            this.oilGroupBox.Text = "機油和潤滑";
            // 
            // lubeCheckbox
            // 
            this.lubeCheckbox.AutoSize = true;
            this.lubeCheckbox.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lubeCheckbox.Location = new System.Drawing.Point(27, 107);
            this.lubeCheckbox.Name = "lubeCheckbox";
            this.lubeCheckbox.Size = new System.Drawing.Size(356, 49);
            this.lubeCheckbox.TabIndex = 1;
            this.lubeCheckbox.Text = "潤滑保養 (NT$540)";
            this.lubeCheckbox.UseVisualStyleBackColor = true;
            // 
            // oilchangeCheckBox
            // 
            this.oilchangeCheckBox.AutoSize = true;
            this.oilchangeCheckBox.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.oilchangeCheckBox.Location = new System.Drawing.Point(27, 52);
            this.oilchangeCheckBox.Name = "oilchangeCheckBox";
            this.oilchangeCheckBox.Size = new System.Drawing.Size(356, 49);
            this.oilchangeCheckBox.TabIndex = 0;
            this.oilchangeCheckBox.Text = "更換機油 (NT$780)";
            this.oilchangeCheckBox.UseVisualStyleBackColor = true;
            // 
            // WashGroupBox
            // 
            this.WashGroupBox.Controls.Add(this.transCheckBox);
            this.WashGroupBox.Controls.Add(this.radiatorCheckBox);
            this.WashGroupBox.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.WashGroupBox.Location = new System.Drawing.Point(582, 42);
            this.WashGroupBox.Name = "WashGroupBox";
            this.WashGroupBox.Size = new System.Drawing.Size(526, 201);
            this.WashGroupBox.TabIndex = 1;
            this.WashGroupBox.TabStop = false;
            this.WashGroupBox.Text = "清洗服務";
            // 
            // transCheckBox
            // 
            this.transCheckBox.AutoSize = true;
            this.transCheckBox.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.transCheckBox.Location = new System.Drawing.Point(47, 122);
            this.transCheckBox.Name = "transCheckBox";
            this.transCheckBox.Size = new System.Drawing.Size(421, 49);
            this.transCheckBox.TabIndex = 1;
            this.transCheckBox.Text = "變速箱清洗 (NT$2,400)";
            this.transCheckBox.UseVisualStyleBackColor = true;
            // 
            // radiatorCheckBox
            // 
            this.radiatorCheckBox.AutoSize = true;
            this.radiatorCheckBox.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radiatorCheckBox.Location = new System.Drawing.Point(47, 54);
            this.radiatorCheckBox.Name = "radiatorCheckBox";
            this.radiatorCheckBox.Size = new System.Drawing.Size(356, 49);
            this.radiatorCheckBox.TabIndex = 0;
            this.radiatorCheckBox.Text = "水箱清洗 (NT$900)";
            this.radiatorCheckBox.UseVisualStyleBackColor = true;
            // 
            // OtherGroupBox
            // 
            this.OtherGroupBox.Controls.Add(this.tireCheckBox);
            this.OtherGroupBox.Controls.Add(this.mufflerCheckBox);
            this.OtherGroupBox.Controls.Add(this.inspectCheckBox);
            this.OtherGroupBox.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.OtherGroupBox.Location = new System.Drawing.Point(57, 214);
            this.OtherGroupBox.Name = "OtherGroupBox";
            this.OtherGroupBox.Size = new System.Drawing.Size(458, 276);
            this.OtherGroupBox.TabIndex = 2;
            this.OtherGroupBox.TabStop = false;
            this.OtherGroupBox.Text = "其他服務";
            // 
            // tireCheckBox
            // 
            this.tireCheckBox.AutoSize = true;
            this.tireCheckBox.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tireCheckBox.Location = new System.Drawing.Point(13, 204);
            this.tireCheckBox.Name = "tireCheckBox";
            this.tireCheckBox.Size = new System.Drawing.Size(356, 49);
            this.tireCheckBox.TabIndex = 2;
            this.tireCheckBox.Text = "輪胎換位 (NT$600)";
            this.tireCheckBox.UseVisualStyleBackColor = true;
            // 
            // mufflerCheckBox
            // 
            this.mufflerCheckBox.AutoSize = true;
            this.mufflerCheckBox.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mufflerCheckBox.Location = new System.Drawing.Point(13, 135);
            this.mufflerCheckBox.Name = "mufflerCheckBox";
            this.mufflerCheckBox.Size = new System.Drawing.Size(421, 49);
            this.mufflerCheckBox.TabIndex = 1;
            this.mufflerCheckBox.Text = "更換消音器 (NT$3,000)";
            this.mufflerCheckBox.UseVisualStyleBackColor = true;
            // 
            // inspectCheckBox
            // 
            this.inspectCheckBox.AutoSize = true;
            this.inspectCheckBox.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.inspectCheckBox.Location = new System.Drawing.Point(13, 63);
            this.inspectCheckBox.Name = "inspectCheckBox";
            this.inspectCheckBox.Size = new System.Drawing.Size(284, 49);
            this.inspectCheckBox.TabIndex = 0;
            this.inspectCheckBox.Text = "檢驗 (NT$450)";
            this.inspectCheckBox.UseVisualStyleBackColor = true;
            // 
            // PartsHoursGroupBox
            // 
            this.PartsHoursGroupBox.Controls.Add(this.labelParts);
            this.PartsHoursGroupBox.Controls.Add(this.labelHours);
            this.PartsHoursGroupBox.Controls.Add(this.partsTextbox);
            this.PartsHoursGroupBox.Controls.Add(this.hoursTextbox);
            this.PartsHoursGroupBox.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PartsHoursGroupBox.Location = new System.Drawing.Point(600, 249);
            this.PartsHoursGroupBox.Name = "PartsHoursGroupBox";
            this.PartsHoursGroupBox.Size = new System.Drawing.Size(508, 241);
            this.PartsHoursGroupBox.TabIndex = 3;
            this.PartsHoursGroupBox.TabStop = false;
            this.PartsHoursGroupBox.Text = "零件和工時";
            // 
            // labelParts
            // 
            this.labelParts.AutoSize = true;
            this.labelParts.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelParts.Location = new System.Drawing.Point(77, 70);
            this.labelParts.Name = "labelParts";
            this.labelParts.Size = new System.Drawing.Size(186, 45);
            this.labelParts.TabIndex = 0;
            this.labelParts.Text = "零件(NT$)";
            // 
            // labelHours
            // 
            this.labelHours.AutoSize = true;
            this.labelHours.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelHours.Location = new System.Drawing.Point(61, 149);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(233, 45);
            this.labelHours.TabIndex = 1;
            this.labelHours.Text = "工時數 (小時)";
            this.labelHours.Click += new System.EventHandler(this.labelHours_Click);
            // 
            // partsTextbox
            // 
            this.partsTextbox.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.partsTextbox.Location = new System.Drawing.Point(330, 60);
            this.partsTextbox.Name = "partsTextbox";
            this.partsTextbox.Size = new System.Drawing.Size(150, 55);
            this.partsTextbox.TabIndex = 2;
            // 
            // hoursTextbox
            // 
            this.hoursTextbox.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.hoursTextbox.Location = new System.Drawing.Point(330, 146);
            this.hoursTextbox.Name = "hoursTextbox";
            this.hoursTextbox.Size = new System.Drawing.Size(120, 55);
            this.hoursTextbox.TabIndex = 3;
            // 
            // SummaryGroupBox
            // 
            this.SummaryGroupBox.Controls.Add(this.servicelaborLabel);
            this.SummaryGroupBox.Controls.Add(this.partscostLabel);
            this.SummaryGroupBox.Controls.Add(this.taxLabel);
            this.SummaryGroupBox.Controls.Add(this.totalLabel);
            this.SummaryGroupBox.Controls.Add(this.txtServiceLabor);
            this.SummaryGroupBox.Controls.Add(this.txtPartsCost);
            this.SummaryGroupBox.Controls.Add(this.txtTax);
            this.SummaryGroupBox.Controls.Add(this.txtTotal);
            this.SummaryGroupBox.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SummaryGroupBox.Location = new System.Drawing.Point(88, 523);
            this.SummaryGroupBox.Name = "SummaryGroupBox";
            this.SummaryGroupBox.Size = new System.Drawing.Size(800, 420);
            this.SummaryGroupBox.TabIndex = 4;
            this.SummaryGroupBox.TabStop = false;
            this.SummaryGroupBox.Text = "費用摘要";
            // 
            // servicelaborLabel
            // 
            this.servicelaborLabel.AutoSize = true;
            this.servicelaborLabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.servicelaborLabel.Location = new System.Drawing.Point(52, 85);
            this.servicelaborLabel.Name = "servicelaborLabel";
            this.servicelaborLabel.Size = new System.Drawing.Size(200, 45);
            this.servicelaborLabel.TabIndex = 0;
            this.servicelaborLabel.Text = "服務與工資";
            // 
            // partscostLabel
            // 
            this.partscostLabel.AutoSize = true;
            this.partscostLabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.partscostLabel.Location = new System.Drawing.Point(52, 145);
            this.partscostLabel.Name = "partscostLabel";
            this.partscostLabel.Size = new System.Drawing.Size(92, 45);
            this.partscostLabel.TabIndex = 1;
            this.partscostLabel.Text = "零件";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.taxLabel.Location = new System.Drawing.Point(52, 219);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(197, 45);
            this.taxLabel.TabIndex = 2;
            this.taxLabel.Text = "稅金 (零件)";
            this.taxLabel.Click += new System.EventHandler(this.labelTax_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.totalLabel.Location = new System.Drawing.Point(62, 291);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(128, 45);
            this.totalLabel.TabIndex = 3;
            this.totalLabel.Text = "總費用";
            // 
            // txtServiceLabor
            // 
            this.txtServiceLabor.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtServiceLabor.Location = new System.Drawing.Point(252, 81);
            this.txtServiceLabor.Name = "txtServiceLabor";
            this.txtServiceLabor.ReadOnly = true;
            this.txtServiceLabor.Size = new System.Drawing.Size(420, 55);
            this.txtServiceLabor.TabIndex = 4;
            // 
            // txtPartsCost
            // 
            this.txtPartsCost.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPartsCost.Location = new System.Drawing.Point(252, 142);
            this.txtPartsCost.Name = "txtPartsCost";
            this.txtPartsCost.ReadOnly = true;
            this.txtPartsCost.Size = new System.Drawing.Size(420, 55);
            this.txtPartsCost.TabIndex = 5;
            // 
            // txtTax
            // 
            this.txtTax.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTax.Location = new System.Drawing.Point(252, 217);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(420, 55);
            this.txtTax.TabIndex = 6;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTotal.Location = new System.Drawing.Point(252, 291);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(420, 55);
            this.txtTotal.TabIndex = 7;
            // 
            // calcButton
            // 
            this.calcButton.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.calcButton.Location = new System.Drawing.Point(70, 1033);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(180, 50);
            this.calcButton.TabIndex = 5;
            this.calcButton.Text = "計算總額";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.clearButton.Location = new System.Drawing.Point(331, 1033);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(160, 50);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "清除";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exitButton.Location = new System.Drawing.Point(616, 1033);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(160, 50);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 1143);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.SummaryGroupBox);
            this.Controls.Add(this.PartsHoursGroupBox);
            this.Controls.Add(this.OtherGroupBox);
            this.Controls.Add(this.WashGroupBox);
            this.Controls.Add(this.oilGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "汽車維修服務";
            this.oilGroupBox.ResumeLayout(false);
            this.oilGroupBox.PerformLayout();
            this.WashGroupBox.ResumeLayout(false);
            this.WashGroupBox.PerformLayout();
            this.OtherGroupBox.ResumeLayout(false);
            this.OtherGroupBox.PerformLayout();
            this.PartsHoursGroupBox.ResumeLayout(false);
            this.PartsHoursGroupBox.PerformLayout();
            this.SummaryGroupBox.ResumeLayout(false);
            this.SummaryGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox oilGroupBox;
        private System.Windows.Forms.CheckBox lubeCheckbox;
        private System.Windows.Forms.CheckBox oilchangeCheckBox;
        private System.Windows.Forms.GroupBox WashGroupBox;
        private System.Windows.Forms.CheckBox transCheckBox;
        private System.Windows.Forms.CheckBox radiatorCheckBox;
        private System.Windows.Forms.GroupBox OtherGroupBox;
        private System.Windows.Forms.CheckBox tireCheckBox;
        private System.Windows.Forms.CheckBox mufflerCheckBox;
        private System.Windows.Forms.CheckBox inspectCheckBox;
        private System.Windows.Forms.GroupBox PartsHoursGroupBox;
        private System.Windows.Forms.Label labelParts;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.TextBox partsTextbox;
        private System.Windows.Forms.TextBox hoursTextbox;
        private System.Windows.Forms.GroupBox SummaryGroupBox;
        private System.Windows.Forms.Label servicelaborLabel;
        private System.Windows.Forms.Label partscostLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox txtServiceLabor;
        private System.Windows.Forms.TextBox txtPartsCost;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

