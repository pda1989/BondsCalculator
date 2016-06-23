namespace BondsCalculator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.couponNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.aciNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.redemptionNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.profitabilityDataGridView = new System.Windows.Forms.DataGridView();
            this.PriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProfitColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProfitabilityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nominalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.maxpriceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.minpriceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.daysComboBox = new System.Windows.Forms.ComboBox();
            this.stepNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.couponNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aciNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redemptionNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profitabilityDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nominalNumericUpDown)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxpriceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minpriceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // couponNumericUpDown
            // 
            this.couponNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.couponNumericUpDown.DecimalPlaces = 2;
            this.couponNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.couponNumericUpDown.Location = new System.Drawing.Point(83, 48);
            this.couponNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.couponNumericUpDown.Name = "couponNumericUpDown";
            this.couponNumericUpDown.Size = new System.Drawing.Size(85, 20);
            this.couponNumericUpDown.TabIndex = 1;
            this.couponNumericUpDown.ValueChanged += new System.EventHandler(this.valueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nominal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Coupon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ACI";
            // 
            // aciNumericUpDown
            // 
            this.aciNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aciNumericUpDown.DecimalPlaces = 2;
            this.aciNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.aciNumericUpDown.Location = new System.Drawing.Point(83, 74);
            this.aciNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.aciNumericUpDown.Name = "aciNumericUpDown";
            this.aciNumericUpDown.Size = new System.Drawing.Size(85, 20);
            this.aciNumericUpDown.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Redemption";
            // 
            // redemptionNumericUpDown
            // 
            this.redemptionNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.redemptionNumericUpDown.Location = new System.Drawing.Point(83, 100);
            this.redemptionNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.redemptionNumericUpDown.Name = "redemptionNumericUpDown";
            this.redemptionNumericUpDown.Size = new System.Drawing.Size(85, 20);
            this.redemptionNumericUpDown.TabIndex = 6;
            this.redemptionNumericUpDown.ValueChanged += new System.EventHandler(this.valueChanged);
            // 
            // profitabilityDataGridView
            // 
            this.profitabilityDataGridView.AllowUserToAddRows = false;
            this.profitabilityDataGridView.AllowUserToDeleteRows = false;
            this.profitabilityDataGridView.AllowUserToResizeRows = false;
            this.profitabilityDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.profitabilityDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.profitabilityDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.profitabilityDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.profitabilityDataGridView.ColumnHeadersHeight = 30;
            this.profitabilityDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PriceColumn,
            this.BuyColumn,
            this.SellColumn,
            this.ProfitColumn,
            this.ProfitabilityColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.profitabilityDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.profitabilityDataGridView.Location = new System.Drawing.Point(12, 176);
            this.profitabilityDataGridView.MultiSelect = false;
            this.profitabilityDataGridView.Name = "profitabilityDataGridView";
            this.profitabilityDataGridView.ReadOnly = true;
            this.profitabilityDataGridView.RowHeadersVisible = false;
            this.profitabilityDataGridView.Size = new System.Drawing.Size(360, 561);
            this.profitabilityDataGridView.TabIndex = 8;
            // 
            // PriceColumn
            // 
            this.PriceColumn.HeaderText = "Price";
            this.PriceColumn.Name = "PriceColumn";
            this.PriceColumn.ReadOnly = true;
            // 
            // BuyColumn
            // 
            this.BuyColumn.HeaderText = "Buy";
            this.BuyColumn.Name = "BuyColumn";
            this.BuyColumn.ReadOnly = true;
            // 
            // SellColumn
            // 
            this.SellColumn.HeaderText = "Sell";
            this.SellColumn.Name = "SellColumn";
            this.SellColumn.ReadOnly = true;
            // 
            // ProfitColumn
            // 
            this.ProfitColumn.HeaderText = "Profit";
            this.ProfitColumn.Name = "ProfitColumn";
            this.ProfitColumn.ReadOnly = true;
            // 
            // ProfitabilityColumn
            // 
            this.ProfitabilityColumn.HeaderText = "Profitability";
            this.ProfitabilityColumn.Name = "ProfitabilityColumn";
            this.ProfitabilityColumn.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Profitability";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.nominalNumericUpDown);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.couponNumericUpDown);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.redemptionNumericUpDown);
            this.groupBox1.Controls.Add(this.aciNumericUpDown);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 139);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bond";
            // 
            // nominalNumericUpDown
            // 
            this.nominalNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nominalNumericUpDown.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nominalNumericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nominalNumericUpDown.Location = new System.Drawing.Point(83, 22);
            this.nominalNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nominalNumericUpDown.Name = "nominalNumericUpDown";
            this.nominalNumericUpDown.Size = new System.Drawing.Size(85, 20);
            this.nominalNumericUpDown.TabIndex = 8;
            this.nominalNumericUpDown.ThousandsSeparator = true;
            this.nominalNumericUpDown.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nominalNumericUpDown.ValueChanged += new System.EventHandler(this.valueChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(360, 145);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.maxpriceNumericUpDown);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.minpriceNumericUpDown);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.daysComboBox);
            this.groupBox2.Controls.Add(this.stepNumericUpDown);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(183, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(174, 139);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // maxpriceNumericUpDown
            // 
            this.maxpriceNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maxpriceNumericUpDown.DecimalPlaces = 2;
            this.maxpriceNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.maxpriceNumericUpDown.Location = new System.Drawing.Point(83, 74);
            this.maxpriceNumericUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.maxpriceNumericUpDown.Name = "maxpriceNumericUpDown";
            this.maxpriceNumericUpDown.Size = new System.Drawing.Size(85, 20);
            this.maxpriceNumericUpDown.TabIndex = 9;
            this.maxpriceNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.maxpriceNumericUpDown.ValueChanged += new System.EventHandler(this.valueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Max. price";
            // 
            // minpriceNumericUpDown
            // 
            this.minpriceNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.minpriceNumericUpDown.DecimalPlaces = 2;
            this.minpriceNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.minpriceNumericUpDown.Location = new System.Drawing.Point(83, 48);
            this.minpriceNumericUpDown.Name = "minpriceNumericUpDown";
            this.minpriceNumericUpDown.Size = new System.Drawing.Size(85, 20);
            this.minpriceNumericUpDown.TabIndex = 7;
            this.minpriceNumericUpDown.Value = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.minpriceNumericUpDown.ValueChanged += new System.EventHandler(this.valueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Min. price";
            // 
            // daysComboBox
            // 
            this.daysComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.daysComboBox.FormattingEnabled = true;
            this.daysComboBox.Items.AddRange(new object[] {
            "365",
            "366"});
            this.daysComboBox.Location = new System.Drawing.Point(83, 21);
            this.daysComboBox.Name = "daysComboBox";
            this.daysComboBox.Size = new System.Drawing.Size(85, 21);
            this.daysComboBox.TabIndex = 6;
            this.daysComboBox.Text = "365";
            this.daysComboBox.SelectedIndexChanged += new System.EventHandler(this.valueChanged);
            // 
            // stepNumericUpDown
            // 
            this.stepNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stepNumericUpDown.DecimalPlaces = 2;
            this.stepNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.stepNumericUpDown.Location = new System.Drawing.Point(83, 100);
            this.stepNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.stepNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.stepNumericUpDown.Name = "stepNumericUpDown";
            this.stepNumericUpDown.Size = new System.Drawing.Size(85, 20);
            this.stepNumericUpDown.TabIndex = 1;
            this.stepNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.stepNumericUpDown.ValueChanged += new System.EventHandler(this.valueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Price step";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Days per year";
            // 
            // versionLabel
            // 
            this.versionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.versionLabel.AutoEllipsis = true;
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(12, 740);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.versionLabel.Size = new System.Drawing.Size(62, 13);
            this.versionLabel.TabIndex = 12;
            this.versionLabel.Text = "Version info";
            this.versionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(220, 740);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(151, 13);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "pokhlebaev.dmitry@gmail.com";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 762);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.profitabilityDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "MainForm";
            this.Text = "Bonds Calculator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.couponNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aciNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redemptionNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profitabilityDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nominalNumericUpDown)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxpriceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minpriceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown couponNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown aciNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown redemptionNumericUpDown;
        private System.Windows.Forms.DataGridView profitabilityDataGridView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox daysComboBox;
        private System.Windows.Forms.NumericUpDown stepNumericUpDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown minpriceNumericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfitColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfitabilityColumn;
        private System.Windows.Forms.NumericUpDown nominalNumericUpDown;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.NumericUpDown maxpriceNumericUpDown;
        private System.Windows.Forms.Label label7;
    }
}

