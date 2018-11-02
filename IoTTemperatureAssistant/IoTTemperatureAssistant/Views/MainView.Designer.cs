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
            this.lbInsideTempLabel = new System.Windows.Forms.Label();
            this.lbInsideTemp = new System.Windows.Forms.Label();
            this.InsideTimer = new System.Windows.Forms.Timer(this.components);
            this.lbOutsideTempLabel = new System.Windows.Forms.Label();
            this.lbOutsideTemp = new System.Windows.Forms.Label();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnSettings = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.lbCityLabel = new System.Windows.Forms.Label();
            this.lbCity = new System.Windows.Forms.Label();
            this.OutsideTimer = new System.Windows.Forms.Timer(this.components);
            this.settingsModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbInsideTempLabel
            // 
            this.lbInsideTempLabel.AutoSize = true;
            this.lbInsideTempLabel.Location = new System.Drawing.Point(45, 18);
            this.lbInsideTempLabel.Name = "lbInsideTempLabel";
            this.lbInsideTempLabel.Size = new System.Drawing.Size(114, 13);
            this.lbInsideTempLabel.TabIndex = 0;
            this.lbInsideTempLabel.Text = "Inside temperature (°C)";
            // 
            // lbInsideTemp
            // 
            this.lbInsideTemp.AutoSize = true;
            this.lbInsideTemp.Location = new System.Drawing.Point(83, 41);
            this.lbInsideTemp.Name = "lbInsideTemp";
            this.lbInsideTemp.Size = new System.Drawing.Size(0, 13);
            this.lbInsideTemp.TabIndex = 1;
            // 
            // InsideTimer
            // 
            this.InsideTimer.Enabled = true;
            this.InsideTimer.Interval = 150000;
            this.InsideTimer.Tick += new System.EventHandler(this.InsideTimer_Tick);
            // 
            // lbOutsideTempLabel
            // 
            this.lbOutsideTempLabel.AutoSize = true;
            this.lbOutsideTempLabel.Location = new System.Drawing.Point(45, 66);
            this.lbOutsideTempLabel.Name = "lbOutsideTempLabel";
            this.lbOutsideTempLabel.Size = new System.Drawing.Size(122, 13);
            this.lbOutsideTempLabel.TabIndex = 2;
            this.lbOutsideTempLabel.Text = "Outside temperature (°C)";
            // 
            // lbOutsideTemp
            // 
            this.lbOutsideTemp.AutoSize = true;
            this.lbOutsideTemp.Location = new System.Drawing.Point(83, 90);
            this.lbOutsideTemp.Name = "lbOutsideTemp";
            this.lbOutsideTemp.Size = new System.Drawing.Size(0, 13);
            this.lbOutsideTemp.TabIndex = 3;
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(48, 124);
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
            this.chart.Size = new System.Drawing.Size(1154, 435);
            this.chart.TabIndex = 4;
            this.chart.Text = "chart1";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(392, 18);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(392, 47);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
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
            this.btnSettings.Location = new System.Drawing.Point(521, 18);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(75, 23);
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
            // lbCityLabel
            // 
            this.lbCityLabel.AutoSize = true;
            this.lbCityLabel.Location = new System.Drawing.Point(741, 18);
            this.lbCityLabel.Name = "lbCityLabel";
            this.lbCityLabel.Size = new System.Drawing.Size(27, 13);
            this.lbCityLabel.TabIndex = 9;
            this.lbCityLabel.Text = "City:";
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Location = new System.Drawing.Point(795, 18);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(0, 13);
            this.lbCity.TabIndex = 10;
            // 
            // OutsideTimer
            // 
            this.OutsideTimer.Enabled = true;
            this.OutsideTimer.Interval = 300000;
            this.OutsideTimer.Tick += new System.EventHandler(this.OutsideTimer_Tick);
            // 
            // settingsModelBindingSource
            // 
            this.settingsModelBindingSource.DataSource = typeof(IoTTemperatureAssistant.Models.SettingsModel);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 588);
            this.Controls.Add(this.lbCity);
            this.Controls.Add(this.lbCityLabel);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.lbOutsideTemp);
            this.Controls.Add(this.lbOutsideTempLabel);
            this.Controls.Add(this.lbInsideTemp);
            this.Controls.Add(this.lbInsideTempLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainView";
            this.Text = "Temperature Assistant";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbInsideTempLabel;
        private System.Windows.Forms.Label lbInsideTemp;
        private System.Windows.Forms.Timer InsideTimer;
        private System.Windows.Forms.Label lbOutsideTempLabel;
        private System.Windows.Forms.Label lbOutsideTemp;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnSettings;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.Label lbCityLabel;
        private System.Windows.Forms.BindingSource settingsModelBindingSource;
        private System.Windows.Forms.Timer OutsideTimer;
    }
}

