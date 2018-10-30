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
            ((System.ComponentModel.ISupportInitialize)(this.nuSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Location = new System.Drawing.Point(28, 38);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(24, 13);
            this.lbCity.TabIndex = 0;
            this.lbCity.Text = "City";
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Location = new System.Drawing.Point(28, 77);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(27, 13);
            this.lbSize.TabIndex = 1;
            this.lbSize.Text = "Size";
            // 
            // lbHeight
            // 
            this.lbHeight.AutoSize = true;
            this.lbHeight.Location = new System.Drawing.Point(28, 116);
            this.lbHeight.Name = "lbHeight";
            this.lbHeight.Size = new System.Drawing.Size(38, 13);
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
            this.tbCity.Location = new System.Drawing.Point(86, 35);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(158, 20);
            this.tbCity.TabIndex = 3;
            // 
            // nuSize
            // 
            this.nuSize.Location = new System.Drawing.Point(86, 75);
            this.nuSize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nuSize.Name = "nuSize";
            this.nuSize.Size = new System.Drawing.Size(120, 20);
            this.nuSize.TabIndex = 6;
            // 
            // nuHeight
            // 
            this.nuHeight.DecimalPlaces = 2;
            this.nuHeight.Location = new System.Drawing.Point(86, 114);
            this.nuHeight.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nuHeight.Name = "nuHeight";
            this.nuHeight.Size = new System.Drawing.Size(120, 20);
            this.nuHeight.TabIndex = 7;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(74, 172);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(155, 172);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // SettingsView
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(312, 243);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.nuHeight);
            this.Controls.Add(this.nuSize);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.lbHeight);
            this.Controls.Add(this.lbSize);
            this.Controls.Add(this.lbCity);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsView";
            this.Text = "SettingsView";
            ((System.ComponentModel.ISupportInitialize)(this.nuSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuHeight)).EndInit();
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
    }
}