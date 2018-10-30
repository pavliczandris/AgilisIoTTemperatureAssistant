namespace IoTTemperatureAssistant
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lbInsideTempLabel = new System.Windows.Forms.Label();
            this.lbInsideTemp = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lbOutsideTempLabel = new System.Windows.Forms.Label();
            this.lbOutsideTemp = new System.Windows.Forms.Label();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
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
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
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
            chartArea3.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart.Legends.Add(legend3);
            this.chart.Location = new System.Drawing.Point(48, 124);
            this.chart.Name = "chart";
            series5.BorderWidth = 2;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.Red;
            series5.Legend = "Legend1";
            series5.Name = "Inside";
            series5.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            series5.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series6.BorderWidth = 2;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Color = System.Drawing.Color.Blue;
            series6.Legend = "Legend1";
            series6.Name = "Outside";
            series6.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            this.chart.Series.Add(series5);
            this.chart.Series.Add(series6);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 588);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.lbOutsideTemp);
            this.Controls.Add(this.lbOutsideTempLabel);
            this.Controls.Add(this.lbInsideTemp);
            this.Controls.Add(this.lbInsideTempLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbInsideTempLabel;
        private System.Windows.Forms.Label lbInsideTemp;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lbOutsideTempLabel;
        private System.Windows.Forms.Label lbOutsideTemp;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

