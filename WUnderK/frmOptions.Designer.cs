namespace WUnderK
{
    partial class frmOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOptions));
            this.gbColors = new System.Windows.Forms.GroupBox();
            this.btnFFColor = new System.Windows.Forms.Button();
            this.btnBGColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.cbTransparent = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbStayOnTop = new System.Windows.Forms.CheckBox();
            this.neInterval = new System.Windows.Forms.NumericUpDown();
            this.lblInterval = new System.Windows.Forms.Label();
            this.gbMisc = new System.Windows.Forms.GroupBox();
            this.llblCopyright = new System.Windows.Forms.LinkLabel();
            this.gbLocation = new System.Windows.Forms.GroupBox();
            this.lblExample = new System.Windows.Forms.Label();
            this.tbStateOrCountry = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.lblStateOrCountry = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbAPIKey = new System.Windows.Forms.GroupBox();
            this.lblEnterAPI = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAPIKey = new System.Windows.Forms.TextBox();
            this.gbTemperature = new System.Windows.Forms.GroupBox();
            this.rbImperial = new System.Windows.Forms.RadioButton();
            this.rbMetric = new System.Windows.Forms.RadioButton();
            this.gbColors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.neInterval)).BeginInit();
            this.gbMisc.SuspendLayout();
            this.gbLocation.SuspendLayout();
            this.gbAPIKey.SuspendLayout();
            this.gbTemperature.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbColors
            // 
            this.gbColors.Controls.Add(this.btnFFColor);
            this.gbColors.Controls.Add(this.btnBGColor);
            this.gbColors.Location = new System.Drawing.Point(151, 12);
            this.gbColors.Name = "gbColors";
            this.gbColors.Size = new System.Drawing.Size(137, 111);
            this.gbColors.TabIndex = 0;
            this.gbColors.TabStop = false;
            this.gbColors.Text = "  < Colors >  ";
            // 
            // btnFFColor
            // 
            this.btnFFColor.Location = new System.Drawing.Point(11, 68);
            this.btnFFColor.Name = "btnFFColor";
            this.btnFFColor.Size = new System.Drawing.Size(100, 30);
            this.btnFFColor.TabIndex = 7;
            this.btnFFColor.Text = "FF Color";
            this.btnFFColor.UseVisualStyleBackColor = true;
            this.btnFFColor.Click += new System.EventHandler(this.btnFFColor_Click);
            // 
            // btnBGColor
            // 
            this.btnBGColor.Location = new System.Drawing.Point(11, 22);
            this.btnBGColor.Name = "btnBGColor";
            this.btnBGColor.Size = new System.Drawing.Size(100, 30);
            this.btnBGColor.TabIndex = 6;
            this.btnBGColor.Text = "BG Color";
            this.btnBGColor.UseVisualStyleBackColor = true;
            this.btnBGColor.Click += new System.EventHandler(this.btnBGColor_Click);
            // 
            // colorDialog1
            // 
            this.colorDialog1.AllowFullOpen = false;
            // 
            // cbTransparent
            // 
            this.cbTransparent.AutoSize = true;
            this.cbTransparent.Location = new System.Drawing.Point(16, 49);
            this.cbTransparent.Name = "cbTransparent";
            this.cbTransparent.Size = new System.Drawing.Size(83, 17);
            this.cbTransparent.TabIndex = 3;
            this.cbTransparent.Text = "Transparent";
            this.cbTransparent.UseVisualStyleBackColor = true;
            this.cbTransparent.Click += new System.EventHandler(this.cbTransparent_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(139, 295);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(220, 295);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbStayOnTop
            // 
            this.cbStayOnTop.AutoSize = true;
            this.cbStayOnTop.Location = new System.Drawing.Point(16, 81);
            this.cbStayOnTop.Name = "cbStayOnTop";
            this.cbStayOnTop.Size = new System.Drawing.Size(86, 17);
            this.cbStayOnTop.TabIndex = 6;
            this.cbStayOnTop.Text = "Stay On Top";
            this.cbStayOnTop.UseVisualStyleBackColor = true;
            this.cbStayOnTop.Click += new System.EventHandler(this.cbStayOnTop_Click);
            // 
            // neInterval
            // 
            this.neInterval.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.neInterval.Location = new System.Drawing.Point(16, 19);
            this.neInterval.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.neInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.neInterval.Name = "neInterval";
            this.neInterval.Size = new System.Drawing.Size(40, 20);
            this.neInterval.TabIndex = 7;
            this.neInterval.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Location = new System.Drawing.Point(62, 22);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(87, 13);
            this.lblInterval.TabIndex = 8;
            this.lblInterval.Text = "Interval (minutes)";
            // 
            // gbMisc
            // 
            this.gbMisc.Controls.Add(this.neInterval);
            this.gbMisc.Controls.Add(this.cbStayOnTop);
            this.gbMisc.Controls.Add(this.lblInterval);
            this.gbMisc.Controls.Add(this.cbTransparent);
            this.gbMisc.Location = new System.Drawing.Point(294, 12);
            this.gbMisc.Name = "gbMisc";
            this.gbMisc.Size = new System.Drawing.Size(166, 111);
            this.gbMisc.TabIndex = 9;
            this.gbMisc.TabStop = false;
            this.gbMisc.Text = "  < Misc >  ";
            // 
            // llblCopyright
            // 
            this.llblCopyright.AutoSize = true;
            this.llblCopyright.Location = new System.Drawing.Point(403, 295);
            this.llblCopyright.Name = "llblCopyright";
            this.llblCopyright.Size = new System.Drawing.Size(57, 13);
            this.llblCopyright.TabIndex = 11;
            this.llblCopyright.TabStop = true;
            this.llblCopyright.Text = "K.Andreev";
            this.llblCopyright.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblCopyright_LinkClicked);
            // 
            // gbLocation
            // 
            this.gbLocation.Controls.Add(this.lblExample);
            this.gbLocation.Controls.Add(this.tbStateOrCountry);
            this.gbLocation.Controls.Add(this.tbCity);
            this.gbLocation.Controls.Add(this.lblStateOrCountry);
            this.gbLocation.Controls.Add(this.label1);
            this.gbLocation.Location = new System.Drawing.Point(17, 129);
            this.gbLocation.Name = "gbLocation";
            this.gbLocation.Size = new System.Drawing.Size(197, 147);
            this.gbLocation.TabIndex = 12;
            this.gbLocation.TabStop = false;
            this.gbLocation.Text = "  < City, State or Country>  ";
            // 
            // lblExample
            // 
            this.lblExample.AutoSize = true;
            this.lblExample.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExample.Location = new System.Drawing.Point(14, 114);
            this.lblExample.Name = "lblExample";
            this.lblExample.Size = new System.Drawing.Size(177, 13);
            this.lblExample.TabIndex = 4;
            this.lblExample.Text = "Example: Allentown, NJ or Rome, IT";
            // 
            // tbStateOrCountry
            // 
            this.tbStateOrCountry.Location = new System.Drawing.Point(14, 87);
            this.tbStateOrCountry.Name = "tbStateOrCountry";
            this.tbStateOrCountry.Size = new System.Drawing.Size(43, 20);
            this.tbStateOrCountry.TabIndex = 3;
            this.tbStateOrCountry.Text = "NJ";
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(14, 48);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(158, 20);
            this.tbCity.TabIndex = 2;
            this.tbCity.Text = "Allentown";
            // 
            // lblStateOrCountry
            // 
            this.lblStateOrCountry.AutoSize = true;
            this.lblStateOrCountry.Location = new System.Drawing.Point(11, 71);
            this.lblStateOrCountry.Name = "lblStateOrCountry";
            this.lblStateOrCountry.Size = new System.Drawing.Size(86, 13);
            this.lblStateOrCountry.TabIndex = 1;
            this.lblStateOrCountry.Text = "State or Country:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "City:";
            // 
            // gbAPIKey
            // 
            this.gbAPIKey.Controls.Add(this.lblEnterAPI);
            this.gbAPIKey.Controls.Add(this.linkLabel1);
            this.gbAPIKey.Controls.Add(this.label3);
            this.gbAPIKey.Controls.Add(this.label2);
            this.gbAPIKey.Controls.Add(this.tbAPIKey);
            this.gbAPIKey.Location = new System.Drawing.Point(220, 129);
            this.gbAPIKey.Name = "gbAPIKey";
            this.gbAPIKey.Size = new System.Drawing.Size(240, 147);
            this.gbAPIKey.TabIndex = 13;
            this.gbAPIKey.TabStop = false;
            this.gbAPIKey.Text = "  < WUnderground API Key >  ";
            // 
            // lblEnterAPI
            // 
            this.lblEnterAPI.AutoSize = true;
            this.lblEnterAPI.Location = new System.Drawing.Point(6, 29);
            this.lblEnterAPI.Name = "lblEnterAPI";
            this.lblEnterAPI.Size = new System.Drawing.Size(76, 13);
            this.lblEnterAPI.TabIndex = 4;
            this.lblEnterAPI.Text = "Enter API Key:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(10, 114);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(223, 13);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://www.wunderground.com/weather/api";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Register for free from the link below.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "This app won\'t work without an API key. ";
            // 
            // tbAPIKey
            // 
            this.tbAPIKey.Location = new System.Drawing.Point(6, 48);
            this.tbAPIKey.Name = "tbAPIKey";
            this.tbAPIKey.Size = new System.Drawing.Size(220, 20);
            this.tbAPIKey.TabIndex = 0;
            // 
            // gbTemperature
            // 
            this.gbTemperature.Controls.Add(this.rbImperial);
            this.gbTemperature.Controls.Add(this.rbMetric);
            this.gbTemperature.Location = new System.Drawing.Point(12, 12);
            this.gbTemperature.Name = "gbTemperature";
            this.gbTemperature.Size = new System.Drawing.Size(133, 111);
            this.gbTemperature.TabIndex = 14;
            this.gbTemperature.TabStop = false;
            this.gbTemperature.Text = "  < Units >  ";
            // 
            // rbImperial
            // 
            this.rbImperial.AutoSize = true;
            this.rbImperial.Location = new System.Drawing.Point(11, 68);
            this.rbImperial.Name = "rbImperial";
            this.rbImperial.Size = new System.Drawing.Size(61, 17);
            this.rbImperial.TabIndex = 1;
            this.rbImperial.Text = "Imperial";
            this.rbImperial.UseVisualStyleBackColor = true;
            this.rbImperial.Click += new System.EventHandler(this.rbFahrenheit_Click);
            // 
            // rbMetric
            // 
            this.rbMetric.AutoSize = true;
            this.rbMetric.Checked = true;
            this.rbMetric.Location = new System.Drawing.Point(11, 29);
            this.rbMetric.Name = "rbMetric";
            this.rbMetric.Size = new System.Drawing.Size(54, 17);
            this.rbMetric.TabIndex = 0;
            this.rbMetric.TabStop = true;
            this.rbMetric.Text = "Metric";
            this.rbMetric.UseVisualStyleBackColor = true;
            this.rbMetric.Click += new System.EventHandler(this.rbCelsius_Click);
            // 
            // frmOptions
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 338);
            this.Controls.Add(this.gbTemperature);
            this.Controls.Add(this.gbAPIKey);
            this.Controls.Add(this.gbLocation);
            this.Controls.Add(this.llblCopyright);
            this.Controls.Add(this.gbMisc);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.gbColors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOptions";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.frmOptions_Load);
            this.gbColors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.neInterval)).EndInit();
            this.gbMisc.ResumeLayout(false);
            this.gbMisc.PerformLayout();
            this.gbLocation.ResumeLayout(false);
            this.gbLocation.PerformLayout();
            this.gbAPIKey.ResumeLayout(false);
            this.gbAPIKey.PerformLayout();
            this.gbTemperature.ResumeLayout(false);
            this.gbTemperature.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbColors;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.CheckBox cbTransparent;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox cbStayOnTop;
        private System.Windows.Forms.Button btnBGColor;
        private System.Windows.Forms.NumericUpDown neInterval;
        private System.Windows.Forms.Label lblInterval;
        private System.Windows.Forms.GroupBox gbMisc;
        private System.Windows.Forms.LinkLabel llblCopyright;
        private System.Windows.Forms.GroupBox gbLocation;
        private System.Windows.Forms.Label lblExample;
        private System.Windows.Forms.TextBox tbStateOrCountry;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.Label lblStateOrCountry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbAPIKey;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAPIKey;
        private System.Windows.Forms.Button btnFFColor;
        private System.Windows.Forms.GroupBox gbTemperature;
        private System.Windows.Forms.RadioButton rbImperial;
        private System.Windows.Forms.RadioButton rbMetric;
        private System.Windows.Forms.Label lblEnterAPI;
    }
}