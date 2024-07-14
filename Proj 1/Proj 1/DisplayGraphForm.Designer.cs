namespace Proj_1
{
    partial class DisplayGraphForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.RectangleAnnotation rectangleAnnotation1 = new System.Windows.Forms.DataVisualization.Charting.RectangleAnnotation();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.UpdatedateTimePicker_startDate = new System.Windows.Forms.DateTimePicker();
            this.UpdatedateTimePicker_endDate = new System.Windows.Forms.DateTimePicker();
            this.chart_stock = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button_Update = new System.Windows.Forms.Button();
            this.PatternButton = new System.Windows.Forms.Button();
            this.aCandleStickPatterns = new System.Windows.Forms.ComboBox();
            this.aCandleStickBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart_stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCandleStickBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // UpdatedateTimePicker_startDate
            // 
            this.UpdatedateTimePicker_startDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdatedateTimePicker_startDate.Location = new System.Drawing.Point(1085, 67);
            this.UpdatedateTimePicker_startDate.Name = "UpdatedateTimePicker_startDate";
            this.UpdatedateTimePicker_startDate.Size = new System.Drawing.Size(252, 22);
            this.UpdatedateTimePicker_startDate.TabIndex = 4;
            this.UpdatedateTimePicker_startDate.Value = new System.DateTime(2023, 6, 15, 15, 9, 0, 0);
            // 
            // UpdatedateTimePicker_endDate
            // 
            this.UpdatedateTimePicker_endDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdatedateTimePicker_endDate.Location = new System.Drawing.Point(1085, 109);
            this.UpdatedateTimePicker_endDate.Name = "UpdatedateTimePicker_endDate";
            this.UpdatedateTimePicker_endDate.Size = new System.Drawing.Size(252, 22);
            this.UpdatedateTimePicker_endDate.TabIndex = 5;
            this.UpdatedateTimePicker_endDate.Value = new System.DateTime(2023, 7, 15, 15, 9, 0, 0);
            // 
            // chart_stock
            // 
            this.chart_stock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            rectangleAnnotation1.BackColor = System.Drawing.Color.Blue;
            rectangleAnnotation1.ForeColor = System.Drawing.Color.DarkOrchid;
            rectangleAnnotation1.Name = "RectangleAnnotation1";
            rectangleAnnotation1.ShadowColor = System.Drawing.Color.Maroon;
            rectangleAnnotation1.Text = "RectangleAnnotation1";
            this.chart_stock.Annotations.Add(rectangleAnnotation1);
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.Name = "area_OHLC";
            chartArea2.Name = "area_Volume";
            this.chart_stock.ChartAreas.Add(chartArea1);
            this.chart_stock.ChartAreas.Add(chartArea2);
            this.chart_stock.DataSource = this.aCandleStickBindingSource;
            legend1.Alignment = System.Drawing.StringAlignment.Far;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsDockedInsideChartArea = false;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend_stock";
            this.chart_stock.Legends.Add(legend1);
            this.chart_stock.Location = new System.Drawing.Point(12, 244);
            this.chart_stock.Name = "chart_stock";
            series1.ChartArea = "area_OHLC";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            series1.CustomProperties = "PriceDownColor=Red, PriceUpColor=Green";
            series1.IsVisibleInLegend = false;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend_stock";
            series1.Name = "series_OHLC";
            series1.XValueMember = "date";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series1.YValueMembers = "high, low, open, close";
            series1.YValuesPerPoint = 4;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.ChartArea = "area_Volume";
            series2.Legend = "Legend_stock";
            series2.Name = "series_Volume";
            series2.XValueMember = "date";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series2.YValueMembers = "volume";
            this.chart_stock.Series.Add(series1);
            this.chart_stock.Series.Add(series2);
            this.chart_stock.Size = new System.Drawing.Size(1325, 500);
            this.chart_stock.TabIndex = 9;
            this.chart_stock.Text = "chart1";
            // 
            // button_Update
            // 
            this.button_Update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Update.Location = new System.Drawing.Point(1138, 155);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(111, 46);
            this.button_Update.TabIndex = 10;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // PatternButton
            // 
            this.PatternButton.Location = new System.Drawing.Point(597, 120);
            this.PatternButton.Name = "PatternButton";
            this.PatternButton.Size = new System.Drawing.Size(101, 31);
            this.PatternButton.TabIndex = 11;
            this.PatternButton.Text = "Pattern Button";
            this.PatternButton.UseVisualStyleBackColor = true;
            this.PatternButton.Click += new System.EventHandler(this.PatternButton_Click);
            // 
            // aCandleStickPatterns
            // 
            this.aCandleStickPatterns.FormattingEnabled = true;
            this.aCandleStickPatterns.Location = new System.Drawing.Point(597, 70);
            this.aCandleStickPatterns.Name = "aCandleStickPatterns";
            this.aCandleStickPatterns.Size = new System.Drawing.Size(121, 24);
            this.aCandleStickPatterns.TabIndex = 12;
            // 
            // aCandleStickBindingSource
            // 
            this.aCandleStickBindingSource.DataSource = typeof(Proj_1.aCandleStick);
            // 
            // DisplayGraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 756);
            this.Controls.Add(this.aCandleStickPatterns);
            this.Controls.Add(this.PatternButton);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.chart_stock);
            this.Controls.Add(this.UpdatedateTimePicker_endDate);
            this.Controls.Add(this.UpdatedateTimePicker_startDate);
            this.Name = "DisplayGraphForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart_stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCandleStickBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DateTimePicker UpdatedateTimePicker_startDate;
        private System.Windows.Forms.DateTimePicker UpdatedateTimePicker_endDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn openDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn highDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn closeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_stock;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.BindingSource aCandleStickBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button PatternButton;
        private System.Windows.Forms.ComboBox aCandleStickPatterns;
    }
}

