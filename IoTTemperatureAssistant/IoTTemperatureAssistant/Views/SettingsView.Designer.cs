namespace IoTTemperatureAssistant.Views
{
    partial class SettingsView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsView));
            this.lbCity = new System.Windows.Forms.Label();
            this.lbSize = new System.Windows.Forms.Label();
            this.lbHeight = new System.Windows.Forms.Label();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.nuSize = new System.Windows.Forms.NumericUpDown();
            this.nuHeight = new System.Windows.Forms.NumericUpDown();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.nuEnergyPricing = new System.Windows.Forms.NumericUpDown();
            this.lbEnergyPricing = new System.Windows.Forms.Label();
            this.nuSurfaceOfWall = new System.Windows.Forms.NumericUpDown();
            this.nuThicknessOfWall = new System.Windows.Forms.NumericUpDown();
            this.lbHeatConduction = new System.Windows.Forms.Label();
            this.lbSurfaceOfWall = new System.Windows.Forms.Label();
            this.lbThicknessOfWall = new System.Windows.Forms.Label();
            this.nuHeatConduction = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nuSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuEnergyPricing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuSurfaceOfWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuThicknessOfWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuHeatConduction)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Location = new System.Drawing.Point(42, 58);
            this.lbCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(35, 20);
            this.lbCity.TabIndex = 0;
            this.lbCity.Text = "City";
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Location = new System.Drawing.Point(42, 126);
            this.lbSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(40, 20);
            this.lbSize.TabIndex = 1;
            this.lbSize.Text = "Size";
            // 
            // lbHeight
            // 
            this.lbHeight.AutoSize = true;
            this.lbHeight.Location = new System.Drawing.Point(42, 182);
            this.lbHeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHeight.Name = "lbHeight";
            this.lbHeight.Size = new System.Drawing.Size(56, 20);
            this.lbHeight.TabIndex = 2;
            this.lbHeight.Text = "Height";
            // 
            // tbCity
            // 
            this.tbCity.AutoCompleteCustomSource.AddRange(new string[] {
            "Budapest",
            "Győr",
            "Szeged",
            "Debrecen",
            "Miskolc",
            "Pécs",
            "Sopron",
            "Nyíregyháza",
            "Paks",
            "Szekszárd",
            "Békéscsaba",
            "Veszprém",
            "Balatonfüred",
            "Siófok",
            "Zalaegerszeg"});
            this.tbCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.tbCity.Location = new System.Drawing.Point(186, 54);
            this.tbCity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(620, 26);
            this.tbCity.TabIndex = 3;
            // 
            // nuSize
            // 
            this.nuSize.Location = new System.Drawing.Point(186, 123);
            this.nuSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nuSize.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nuSize.Name = "nuSize";
            this.nuSize.Size = new System.Drawing.Size(180, 26);
            this.nuSize.TabIndex = 6;
            // 
            // nuHeight
            // 
            this.nuHeight.DecimalPlaces = 2;
            this.nuHeight.Location = new System.Drawing.Point(186, 178);
            this.nuHeight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nuHeight.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nuHeight.Name = "nuHeight";
            this.nuHeight.Size = new System.Drawing.Size(180, 26);
            this.nuHeight.TabIndex = 7;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(316, 348);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(112, 35);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(462, 348);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 35);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // nuEnergyPricing
            // 
            this.nuEnergyPricing.DecimalPlaces = 2;
            this.nuEnergyPricing.Location = new System.Drawing.Point(186, 235);
            this.nuEnergyPricing.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nuEnergyPricing.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nuEnergyPricing.Name = "nuEnergyPricing";
            this.nuEnergyPricing.Size = new System.Drawing.Size(180, 26);
            this.nuEnergyPricing.TabIndex = 10;
            // 
            // lbEnergyPricing
            // 
            this.lbEnergyPricing.AutoSize = true;
            this.lbEnergyPricing.Location = new System.Drawing.Point(42, 238);
            this.lbEnergyPricing.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEnergyPricing.Name = "lbEnergyPricing";
            this.lbEnergyPricing.Size = new System.Drawing.Size(110, 20);
            this.lbEnergyPricing.TabIndex = 11;
            this.lbEnergyPricing.Text = "Energy Pricing";
            // 
            // nuSurfaceOfWall
            // 
            this.nuSurfaceOfWall.DecimalPlaces = 2;
            this.nuSurfaceOfWall.Location = new System.Drawing.Point(628, 178);
            this.nuSurfaceOfWall.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nuSurfaceOfWall.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nuSurfaceOfWall.Name = "nuSurfaceOfWall";
            this.nuSurfaceOfWall.Size = new System.Drawing.Size(180, 26);
            this.nuSurfaceOfWall.TabIndex = 12;
            // 
            // nuThicknessOfWall
            // 
            this.nuThicknessOfWall.DecimalPlaces = 2;
            this.nuThicknessOfWall.Location = new System.Drawing.Point(628, 235);
            this.nuThicknessOfWall.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nuThicknessOfWall.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nuThicknessOfWall.Name = "nuThicknessOfWall";
            this.nuThicknessOfWall.Size = new System.Drawing.Size(180, 26);
            this.nuThicknessOfWall.TabIndex = 14;
            // 
            // lbHeatConduction
            // 
            this.lbHeatConduction.AutoSize = true;
            this.lbHeatConduction.Location = new System.Drawing.Point(441, 126);
            this.lbHeatConduction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHeatConduction.Name = "lbHeatConduction";
            this.lbHeatConduction.Size = new System.Drawing.Size(129, 20);
            this.lbHeatConduction.TabIndex = 15;
            this.lbHeatConduction.Text = "Heat Conduction";
            // 
            // lbSurfaceOfWall
            // 
            this.lbSurfaceOfWall.AutoSize = true;
            this.lbSurfaceOfWall.Location = new System.Drawing.Point(441, 178);
            this.lbSurfaceOfWall.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSurfaceOfWall.Name = "lbSurfaceOfWall";
            this.lbSurfaceOfWall.Size = new System.Drawing.Size(113, 20);
            this.lbSurfaceOfWall.TabIndex = 16;
            this.lbSurfaceOfWall.Text = "Surface of wall";
            // 
            // lbThicknessOfWall
            // 
            this.lbThicknessOfWall.AutoSize = true;
            this.lbThicknessOfWall.Location = new System.Drawing.Point(441, 238);
            this.lbThicknessOfWall.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbThicknessOfWall.Name = "lbThicknessOfWall";
            this.lbThicknessOfWall.Size = new System.Drawing.Size(128, 20);
            this.lbThicknessOfWall.TabIndex = 18;
            this.lbThicknessOfWall.Text = "Thickness of wall";
            // 
            // nuHeatConduction
            // 
            this.nuHeatConduction.DecimalPlaces = 2;
            this.nuHeatConduction.Location = new System.Drawing.Point(628, 115);
            this.nuHeatConduction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nuHeatConduction.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nuHeatConduction.Name = "nuHeatConduction";
            this.nuHeatConduction.Size = new System.Drawing.Size(180, 26);
            this.nuHeatConduction.TabIndex = 19;
            // 
            // SettingsView
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(903, 422);
            this.Controls.Add(this.nuHeatConduction);
            this.Controls.Add(this.lbThicknessOfWall);
            this.Controls.Add(this.lbSurfaceOfWall);
            this.Controls.Add(this.lbHeatConduction);
            this.Controls.Add(this.nuThicknessOfWall);
            this.Controls.Add(this.nuSurfaceOfWall);
            this.Controls.Add(this.lbEnergyPricing);
            this.Controls.Add(this.nuEnergyPricing);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.nuHeight);
            this.Controls.Add(this.nuSize);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.lbHeight);
            this.Controls.Add(this.lbSize);
            this.Controls.Add(this.lbCity);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SettingsView";
            this.Text = "SettingsView";
            this.Load += new System.EventHandler(this.SettingsView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nuSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuEnergyPricing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuSurfaceOfWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuThicknessOfWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuHeatConduction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Label lbHeight;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.NumericUpDown nuSize;
        private System.Windows.Forms.NumericUpDown nuHeight;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown nuEnergyPricing;
        private System.Windows.Forms.Label lbEnergyPricing;
        private System.Windows.Forms.NumericUpDown nuSurfaceOfWall;
        private System.Windows.Forms.NumericUpDown nuThicknessOfWall;
        private System.Windows.Forms.Label lbHeatConduction;
        private System.Windows.Forms.Label lbSurfaceOfWall;
        private System.Windows.Forms.Label lbThicknessOfWall;
        private System.Windows.Forms.NumericUpDown nuHeatConduction;
    }
}