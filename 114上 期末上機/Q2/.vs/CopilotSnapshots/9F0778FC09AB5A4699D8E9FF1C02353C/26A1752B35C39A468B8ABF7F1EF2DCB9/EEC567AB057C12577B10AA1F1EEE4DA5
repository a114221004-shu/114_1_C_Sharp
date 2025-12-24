using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Q2
{
    public partial class Form1 : Form
    {
        // prices
        private const decimal PRICE_OIL = 780m;
        private const decimal PRICE_LUBE = 540m;
        private const decimal PRICE_RADIATOR = 900m;
        private const decimal PRICE_TRANS = 2400m;
        private const decimal PRICE_INSPECT = 450m;
        private const decimal PRICE_MUFFLER = 3000m;
        private const decimal PRICE_TIRE = 600m;
        private const decimal LABOR_RATE_PER_HOUR = 600m; // NT$600 per hour
        private const decimal TAX_RATE = 0.06m; // 6% for parts only

        public Form1()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
        }

        // Charges calculation methods
        private decimal OilLubeCharges()
        {
            decimal total = 0m;
            if (oilchangeCheckBox.Checked) total += PRICE_OIL;
            if (lubeCheckbox.Checked) total += PRICE_LUBE;
            return total;
        }

        private decimal FlushCharges()
        {
            decimal total = 0m;
            if (radiatorCheckBox.Checked) total += PRICE_RADIATOR;
            if (transCheckBox.Checked) total += PRICE_TRANS;
            return total;
        }

        private decimal MiscCharges()
        {
            decimal total = 0m;
            if (inspectCheckBox.Checked) total += PRICE_INSPECT;
            if (mufflerCheckBox.Checked) total += PRICE_MUFFLER;
            if (tireCheckBox.Checked) total += PRICE_TIRE;
            return total;
        }

        // OtherCharges: parts + labor
        private decimal OtherCharges()
        {
            decimal parts = 0m;
            decimal hours = 0m;
            if (!string.IsNullOrWhiteSpace(partsTextbox.Text))
            {
                decimal.TryParse(partsTextbox.Text, out parts);
                if (parts < 0) parts = 0m;
            }
            if (!string.IsNullOrWhiteSpace(hoursTextbox.Text))
            {
                decimal.TryParse(hoursTextbox.Text, out hours);
                if (hours < 0) hours = 0m;
            }

            decimal laborCost = hours * LABOR_RATE_PER_HOUR;
            return parts + laborCost;
        }

        private decimal TaxCharges()
        {
            decimal parts = 0m;
            if (!string.IsNullOrWhiteSpace(partsTextbox.Text))
            {
                decimal.TryParse(partsTextbox.Text, out parts);
                if (parts < 0) parts = 0m;
            }
            return Math.Round(parts * TAX_RATE, 2);
        }

        private decimal TotalCharges()
        {
            decimal total = 0m;
            total += OilLubeCharges();
            total += FlushCharges();
            total += MiscCharges();
            total += OtherCharges();
            total += TaxCharges();
            return Math.Round(total, 2);
        }

        // Event handlers
        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // compute components
                decimal oilLube = OilLubeCharges();
                decimal flush = FlushCharges();
                decimal misc = MiscCharges();

                // parse parts and hours for display
                decimal parts = 0m;
                decimal hours = 0m;
                if (!string.IsNullOrWhiteSpace(partsTextbox.Text))
                {
                    if (!decimal.TryParse(partsTextbox.Text, out parts) || parts < 0)
                    {
                        MessageBox.Show("請在零件欄位輸入有效的非負數字。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                if (!string.IsNullOrWhiteSpace(hoursTextbox.Text))
                {
                    if (!decimal.TryParse(hoursTextbox.Text, out hours) || hours < 0)
                    {
                        MessageBox.Show("請在工時欄位輸入有效的非負數字。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                decimal laborCost = hours * LABOR_RATE_PER_HOUR;
                decimal serviceAndLabor = oilLube + flush + misc + laborCost;
                decimal tax = TaxCharges();
                decimal totalPartsAndLabor = OtherCharges(); // parts + labor
                decimal total = TotalCharges();

                // display: 服務與工資 (service items + labor), 零件, 稅金, 總費用
                txtServiceLabor.Text = serviceAndLabor.ToString("F2");
                txtPartsCost.Text = parts.ToString("F2");
                txtTax.Text = tax.ToString("F2");
                txtTotal.Text = total.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("發生錯誤: " + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearOilLube();
            ClearFlushes();
            ClearMisc();
            ClearOther();
            ClearFees();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Clear methods
        private void ClearOilLube()
        {
            oilchangeCheckBox.Checked = false;
            lubeCheckbox.Checked = false;
        }

        private void ClearFlushes()
        {
            radiatorCheckBox.Checked = false;
            transCheckBox.Checked = false;
        }

        private void ClearMisc()
        {
            inspectCheckBox.Checked = false;
            mufflerCheckBox.Checked = false;
            tireCheckBox.Checked = false;
        }

        private void ClearOther()
        {
            partsTextbox.Text = string.Empty;
            hoursTextbox.Text = string.Empty;
        }

        private void ClearFees()
        {
            txtServiceLabor.Text = string.Empty;
            txtPartsCost.Text = string.Empty;
            txtTax.Text = string.Empty;
            txtTotal.Text = string.Empty;
        }

        // File save
        private void SaveServiceDetailsToFile()
        {
            string report = BuildReport();
            SaveReportToFile(report);
        }

        // Existing helpers (BuildReport/SaveReportToFile/FormClosing) remain
        private void labelHours_Click(object sender, EventArgs e)
        {
            // no-op
        }

        private void labelTax_Click(object sender, EventArgs e)
        {
            // no-op
        }

        // Build a professional text report of the current invoice
        private string BuildReport()
        {
            var sb = new StringBuilder();
            var now = DateTime.Now;
            sb.AppendLine("========================================");
            sb.AppendLine("            汽車維修服務報表");
            sb.AppendLine("========================================");
            sb.AppendLine($"產生時間: {now:yyyy-MM-dd HH:mm:ss}");
            sb.AppendLine();

            sb.AppendLine("[服務項目]");
            decimal serviceItems = 0m;

            if (oilchangeCheckBox.Checked)
            {
                sb.AppendLine($" - 更換機油: NT${PRICE_OIL:F2}");
                serviceItems += PRICE_OIL;
            }
            if (lubeCheckbox.Checked)
            {
                sb.AppendLine($" - 潤滑保養: NT${PRICE_LUBE:F2}");
                serviceItems += PRICE_LUBE;
            }
            if (radiatorCheckBox.Checked)
            {
                sb.AppendLine($" - 水箱清洗: NT${PRICE_RADIATOR:F2}");
                serviceItems += PRICE_RADIATOR;
            }
            if (transCheckBox.Checked)
            {
                sb.AppendLine($" - 變速箱清洗: NT${PRICE_TRANS:F2}");
                serviceItems += PRICE_TRANS;
            }
            if (inspectCheckBox.Checked)
            {
                sb.AppendLine($" - 檢驗: NT${PRICE_INSPECT:F2}");
                serviceItems += PRICE_INSPECT;
            }
            if (mufflerCheckBox.Checked)
            {
                sb.AppendLine($" - 更換消音器: NT${PRICE_MUFFLER:F2}");
                serviceItems += PRICE_MUFFLER;
            }
            if (tireCheckBox.Checked)
            {
                sb.AppendLine($" - 輪胎換位: NT${PRICE_TIRE:F2}");
                serviceItems += PRICE_TIRE;
            }

            sb.AppendLine();
            sb.AppendLine("[零件與工時]");

            decimal parts = 0m;
            decimal hours = 0m;
            decimal.TryParse(partsTextbox.Text, out parts);
            decimal.TryParse(hoursTextbox.Text, out hours);

            sb.AppendLine($" - 零件金額: NT${parts:F2}");
            sb.AppendLine($" - 工時: {hours} 小時 (費率 NT${LABOR_RATE_PER_HOUR:F2}/小時)");

            decimal laborCost = hours * LABOR_RATE_PER_HOUR;
            sb.AppendLine();

            sb.AppendLine("[計算過程]");
            sb.AppendLine($"  服務項目合計: NT${serviceItems:F2}");
            sb.AppendLine($"  工資 (工時 x 費率): {hours} x NT${LABOR_RATE_PER_HOUR:F2} = NT${laborCost:F2}");
            sb.AppendLine($"  服務與工資小計: NT${(serviceItems + laborCost):F2}");
            sb.AppendLine($"  零件金額: NT${parts:F2}");
            decimal tax = Math.Round(parts * TAX_RATE, 2);
            sb.AppendLine($"  零件稅 ({TAX_RATE:P0}): NT${tax:F2}");
            decimal total = Math.Round(serviceItems + laborCost + parts + tax, 2);
            sb.AppendLine($"  總費用: NT${total:F2}");

            sb.AppendLine();
            sb.AppendLine("[摘要]");
            sb.AppendLine($"  服務與工資: NT${(serviceItems + laborCost):F2}");
            sb.AppendLine($"  零件: NT${parts:F2}");
            sb.AppendLine($"  稅金(零件): NT${tax:F2}");
            sb.AppendLine($"  總費用: NT${total:F2}");

            sb.AppendLine();
            sb.AppendLine("感謝您的使用，請保存此報表以供查詢。");

            return sb.ToString();
        }

        // Show SaveFileDialog and write report to file
        private bool SaveReportToFile(string reportText)
        {
            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "文字檔 (*.txt)|*.txt|所有檔案 (*.*)|*.*";
                sfd.DefaultExt = "txt";
                sfd.FileName = $"RepairReport_{DateTime.Now:yyyyMMdd_HHmmss}.txt";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        File.WriteAllText(sfd.FileName, reportText, Encoding.UTF8);
                        MessageBox.Show($"已儲存報表到: {sfd.FileName}", "儲存完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("儲存檔案時發生錯誤: " + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }

            return false; // user cancelled
        }

        // Handle form closing to ask user whether to save report
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("是否要儲存本次維修明細？", "儲存明細", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel)
            {
                e.Cancel = true; // cancel closing
                return;
            }

            if (result == DialogResult.Yes)
            {
                string report = BuildReport();
                // If user cancels save dialog, ask again whether to quit without saving
                bool saved = SaveReportToFile(report);
                if (!saved)
                {
                    var retry = MessageBox.Show("未儲存報表。確定要在不儲存的情況下離開？", "確認離開", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (retry == DialogResult.No)
                    {
                        e.Cancel = true; // abort close
                    }
                }
            }
            // if No: just exit without saving
        }
    }
}
