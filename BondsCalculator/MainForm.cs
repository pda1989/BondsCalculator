using System;
using System.Reflection;
using System.Windows.Forms;

namespace BondsCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var version = Assembly.GetEntryAssembly().GetName().Version;
            versionLabel.Text = "Version " + version;
        }

        private void valueChanged(object sender, EventArgs e)
        {
            profitabilityDataGridView.Rows.Clear();

            for (decimal i = minpriceNumericUpDown.Value; i <= 100; i+= stepNumericUpDown.Value)
            {
                var price = i;
                var buy = nominalNumericUpDown.Value * i / 100 + aciNumericUpDown.Value;
                var sell = nominalNumericUpDown.Value + couponNumericUpDown.Value;
                var profitability = 0M;
                try
                {
                    profitability = (sell - buy) / buy * 100 / redemptionNumericUpDown.Value * Convert.ToDecimal(daysComboBox.Text);
                }
                catch (Exception) { }
                profitabilityDataGridView.Rows.Add(i, buy, sell, sell - buy, Math.Round(profitability, 2));
            }
        }
    }
}
