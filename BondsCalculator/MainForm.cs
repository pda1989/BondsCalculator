using System;
using System.Windows.Forms;

namespace BondsCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void valueChanged(object sender, EventArgs e)
        {
            profitabilityDataGridView.Rows.Clear();

            for (decimal i = minpriceNumericUpDown.Value; i <= 100; i+= stepNumericUpDown.Value)
            {
                var price = i;
                var buy = Convert.ToDecimal(nominalComboBox.Text) * i / 100 + aciNumericUpDown.Value;
                var sell = Convert.ToDecimal(nominalComboBox.Text) + couponNumericUpDown.Value;
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
