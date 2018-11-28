namespace IoTTemperatureAssistant
{
    partial class MainView
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.InsideTimer = new System.Windows.Forms.Timer(this.components);
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnSettings = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.lbCity = new System.Windows.Forms.Label();
            this.OutsideTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.nuTempChange = new System.Windows.Forms.NumericUpDown();
            this.lbEstimatedCost = new System.Windows.Forms.Label();
            this.lbEstimatedConsumption = new System.Windows.Forms.Label();
            this.lbAvgOutsideTemp = new System.Windows.Forms.Label();
            this.lbSavingPrediction = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbCost = new System.Windows.Forms.Label();
            this.lbConsumption = new System.Windows.Forms.Label();
            this.lbOutsideTempLabel = new System.Windows.Forms.Label();
            this.lbAvgInsideTemp = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbInsideTemp = new System.Windows.Forms.Label();
            this.lbInsideTempLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CalculationTimer = new System.Windows.Forms.Timer(this.components);
            this.settingsModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbOutsideTemp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuTempChange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // InsideTimer
            // 
            this.InsideTimer.Enabled = true;
            this.InsideTimer.Interval = 5000;
            this.InsideTimer.Tick += new System.EventHandler(this.InsideTimer_Tick);
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(72, 191);
            this.chart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chart.Name = "chart";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "Inside";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Blue;
            series2.Legend = "Legend1";
            series2.Name = "Outside";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            this.chart.Series.Add(series1);
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(1731, 669);
            this.chart.TabIndex = 4;
            this.chart.Text = "chart1";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(72, 36);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 30);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(174, 36);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(81, 30);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(72, 88);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(183, 31);
            this.btnSettings.TabIndex = 7;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Location = new System.Drawing.Point(139, 146);
            this.lbCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(0, 20);
            this.lbCity.TabIndex = 10;
            this.lbCity.Tag = "";
            // 
            // OutsideTimer
            // 
            this.OutsideTimer.Enabled = true;
            this.OutsideTimer.Interval = 10000;
            this.OutsideTimer.Tick += new System.EventHandler(this.OutsideTimer_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nuTempChange);
            this.panel1.Controls.Add(this.lbEstimatedCost);
            this.panel1.Controls.Add(this.lbEstimatedConsumption);
            this.panel1.Controls.Add(this.lbAvgOutsideTemp);
            this.panel1.Controls.Add(this.lbSavingPrediction);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lbCost);
            this.panel1.Controls.Add(this.lbConsumption);
            this.panel1.Controls.Add(this.lbOutsideTempLabel);
            this.panel1.Controls.Add(this.lbAvgInsideTemp);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbOutsideTemp);
            this.panel1.Controls.Add(this.lbInsideTemp);
            this.panel1.Controls.Add(this.lbInsideTempLabel);
            this.panel1.Location = new System.Drawing.Point(280, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1523, 130);
            this.panel1.TabIndex = 11;
            // 
            // nuTempChange
            // 
            this.nuTempChange.DecimalPlaces = 2;
            this.nuTempChange.Location = new System.Drawing.Point(219, 22);
            this.nuTempChange.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nuTempChange.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nuTempChange.Minimum = new decimal(new int[] {
            9999999,
            0,
            0,
            -2147483648});
            this.nuTempChange.Name = "nuTempChange";
            this.nuTempChange.Size = new System.Drawing.Size(93, 26);
            this.nuTempChange.TabIndex = 20;
            this.nuTempChange.ValueChanged += new System.EventHandler(this.nuTempChange_ValueChanged);
            // 
            // lbEstimatedCost
            // 
            this.lbEstimatedCost.AutoSize = true;
            this.lbEstimatedCost.Location = new System.Drawing.Point(1420, 80);
            this.lbEstimatedCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEstimatedCost.Name = "lbEstimatedCost";
            this.lbEstimatedCost.Size = new System.Drawing.Size(0, 20);
            this.lbEstimatedCost.TabIndex = 15;
            // 
            // lbEstimatedConsumption
            // 
            this.lbEstimatedConsumption.AutoSize = true;
            this.lbEstimatedConsumption.Location = new System.Drawing.Point(1140, 80);
            this.lbEstimatedConsumption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEstimatedConsumption.Name = "lbEstimatedConsumption";
            this.lbEstimatedConsumption.Size = new System.Drawing.Size(0, 20);
            this.lbEstimatedConsumption.TabIndex = 15;
            // 
            // lbAvgOutsideTemp
            // 
            this.lbAvgOutsideTemp.AutoSize = true;
            this.lbAvgOutsideTemp.Location = new System.Drawing.Point(862, 80);
            this.lbAvgOutsideTemp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAvgOutsideTemp.Name = "lbAvgOutsideTemp";
            this.lbAvgOutsideTemp.Size = new System.Drawing.Size(0, 20);
            this.lbAvgOutsideTemp.TabIndex = 15;
            // 
            // lbSavingPrediction
            // 
            this.lbSavingPrediction.AutoSize = true;
            this.lbSavingPrediction.Location = new System.Drawing.Point(215, 80);
            this.lbSavingPrediction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSavingPrediction.Name = "lbSavingPrediction";
            this.lbSavingPrediction.Size = new System.Drawing.Size(0, 20);
            this.lbSavingPrediction.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Temperature change (°C):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Saving prediction (HUF):";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1233, 80);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(167, 20);
            this.label14.TabIndex = 14;
            this.label14.Text = "Estimated cost (HUF):";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(901, 80);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(220, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "Estimated constumption (MJ):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(605, 80);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Average outside temperature (°C):";
            // 
            // lbCost
            // 
            this.lbCost.AutoSize = true;
            this.lbCost.Location = new System.Drawing.Point(1420, 24);
            this.lbCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCost.Name = "lbCost";
            this.lbCost.Size = new System.Drawing.Size(0, 20);
            this.lbCost.TabIndex = 13;
            // 
            // lbConsumption
            // 
            this.lbConsumption.AutoSize = true;
            this.lbConsumption.Location = new System.Drawing.Point(1139, 24);
            this.lbConsumption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbConsumption.Name = "lbConsumption";
            this.lbConsumption.Size = new System.Drawing.Size(0, 20);
            this.lbConsumption.TabIndex = 13;
            // 
            // lbOutsideTempLabel
            // 
            this.lbOutsideTempLabel.AutoSize = true;
            this.lbOutsideTempLabel.Location = new System.Drawing.Point(322, 80);
            this.lbOutsideTempLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbOutsideTempLabel.Name = "lbOutsideTempLabel";
            this.lbOutsideTempLabel.Size = new System.Drawing.Size(189, 20);
            this.lbOutsideTempLabel.TabIndex = 14;
            this.lbOutsideTempLabel.Text = "Outside temperature (°C):";
            // 
            // lbAvgInsideTemp
            // 
            this.lbAvgInsideTemp.AutoSize = true;
            this.lbAvgInsideTemp.Location = new System.Drawing.Point(861, 24);
            this.lbAvgInsideTemp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAvgInsideTemp.Name = "lbAvgInsideTemp";
            this.lbAvgInsideTemp.Size = new System.Drawing.Size(0, 20);
            this.lbAvgInsideTemp.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1233, 24);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 20);
            this.label12.TabIndex = 12;
            this.label12.Text = "Cost (HUF):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(901, 24);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Consumption (MJ):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(605, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Average inside temperature (°C):";
            // 
            // lbInsideTemp
            // 
            this.lbInsideTemp.AutoSize = true;
            this.lbInsideTemp.Location = new System.Drawing.Point(519, 24);
            this.lbInsideTemp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbInsideTemp.Name = "lbInsideTemp";
            this.lbInsideTemp.Size = new System.Drawing.Size(0, 20);
            this.lbInsideTemp.TabIndex = 13;
            // 
            // lbInsideTempLabel
            // 
            this.lbInsideTempLabel.AutoSize = true;
            this.lbInsideTempLabel.Location = new System.Drawing.Point(322, 24);
            this.lbInsideTempLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbInsideTempLabel.Name = "lbInsideTempLabel";
            this.lbInsideTempLabel.Size = new System.Drawing.Size(177, 20);
            this.lbInsideTempLabel.TabIndex = 12;
            this.lbInsideTempLabel.Text = "Inside temperature (°C):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "City:";
            // 
            // CalculationTimer
            // 
            this.CalculationTimer.Enabled = true;
            this.CalculationTimer.Interval = 5000;
            this.CalculationTimer.Tick += new System.EventHandler(this.CalculationTimer_Tick);
            // 
            // settingsModelBindingSource
            // 
            this.settingsModelBindingSource.DataSource = typeof(IoTTemperatureAssistant.Models.SettingsModel);
            // 
            // lbOutsideTemp
            // 
            this.lbOutsideTemp.AutoSize = true;
            this.lbOutsideTemp.Location = new System.Drawing.Point(519, 80);
            this.lbOutsideTemp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbOutsideTemp.Name = "lbOutsideTemp";
            this.lbOutsideTemp.Size = new System.Drawing.Size(0, 20);
            this.lbOutsideTemp.TabIndex = 13;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1850, 905);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbCity);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainView";
            this.Text = "Temperature Assistant";
            this.Load += new System.EventHandler(this.MainView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuTempChange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer InsideTimer;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnSettings;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.BindingSource settingsModelBindingSource;
        private System.Windows.Forms.Timer OutsideTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbEstimatedCost;
        private System.Windows.Forms.Label lbEstimatedConsumption;
        private System.Windows.Forms.Label lbAvgOutsideTemp;
        private System.Windows.Forms.Label lbSavingPrediction;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbCost;
        private System.Windows.Forms.Label lbConsumption;
        private System.Windows.Forms.Label lbOutsideTempLabel;
        private System.Windows.Forms.Label lbAvgInsideTemp;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbInsideTemp;
        private System.Windows.Forms.Label lbInsideTempLabel;
        private System.Windows.Forms.Timer CalculationTimer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nuTempChange;
        private System.Windows.Forms.Label lbOutsideTemp;
    }
}

