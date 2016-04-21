namespace WUnderK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl1min = new System.Windows.Forms.Label();
            this.lbl2min = new System.Windows.Forms.Label();
            this.lbl3min = new System.Windows.Forms.Label();
            this.lbl4min = new System.Windows.Forms.Label();
            this.lbl5min = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pbForecastButton = new System.Windows.Forms.PictureBox();
            this.pbDetailsButton = new System.Windows.Forms.PictureBox();
            this.pbMove = new System.Windows.Forms.PictureBox();
            this.pbOptions = new System.Windows.Forms.PictureBox();
            this.pbMinimize = new System.Windows.Forms.PictureBox();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.lblCity = new System.Windows.Forms.Label();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.paDetails = new System.Windows.Forms.Panel();
            this.lblPrecip = new System.Windows.Forms.Label();
            this.lblUV = new System.Windows.Forms.Label();
            this.lblVisibility = new System.Windows.Forms.Label();
            this.lblFeelsLike = new System.Windows.Forms.Label();
            this.lblPressure = new System.Windows.Forms.Label();
            this.lblWind = new System.Windows.Forms.Label();
            this.lblHumidity = new System.Windows.Forms.Label();
            this.lblWeather = new System.Windows.Forms.Label();
            this.pbDetailsPane = new System.Windows.Forms.PictureBox();
            this.pbWeatherImage = new System.Windows.Forms.PictureBox();
            this.paForecast = new System.Windows.Forms.Panel();
            this.lblForecast1 = new System.Windows.Forms.Label();
            this.lblFC2 = new System.Windows.Forms.Label();
            this.lblForecast2 = new System.Windows.Forms.Label();
            this.lblFC3 = new System.Windows.Forms.Label();
            this.lblForecast3 = new System.Windows.Forms.Label();
            this.lblForecast4 = new System.Windows.Forms.Label();
            this.lblFC4 = new System.Windows.Forms.Label();
            this.lblFC1 = new System.Windows.Forms.Label();
            this.pbForecast = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbForecastButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetailsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.paDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetailsPane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWeatherImage)).BeginInit();
            this.paForecast.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbForecast)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl1min
            // 
            this.lbl1min.AutoSize = true;
            this.lbl1min.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1min.ForeColor = System.Drawing.Color.Yellow;
            this.lbl1min.Location = new System.Drawing.Point(12, 63);
            this.lbl1min.Name = "lbl1min";
            this.lbl1min.Size = new System.Drawing.Size(0, 9);
            this.lbl1min.TabIndex = 4;
            // 
            // lbl2min
            // 
            this.lbl2min.AutoSize = true;
            this.lbl2min.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2min.ForeColor = System.Drawing.Color.Yellow;
            this.lbl2min.Location = new System.Drawing.Point(32, 63);
            this.lbl2min.Name = "lbl2min";
            this.lbl2min.Size = new System.Drawing.Size(0, 9);
            this.lbl2min.TabIndex = 5;
            // 
            // lbl3min
            // 
            this.lbl3min.AutoSize = true;
            this.lbl3min.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3min.ForeColor = System.Drawing.Color.Yellow;
            this.lbl3min.Location = new System.Drawing.Point(52, 63);
            this.lbl3min.Name = "lbl3min";
            this.lbl3min.Size = new System.Drawing.Size(0, 9);
            this.lbl3min.TabIndex = 6;
            // 
            // lbl4min
            // 
            this.lbl4min.AutoSize = true;
            this.lbl4min.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4min.ForeColor = System.Drawing.Color.Yellow;
            this.lbl4min.Location = new System.Drawing.Point(72, 63);
            this.lbl4min.Name = "lbl4min";
            this.lbl4min.Size = new System.Drawing.Size(0, 9);
            this.lbl4min.TabIndex = 7;
            // 
            // lbl5min
            // 
            this.lbl5min.AutoSize = true;
            this.lbl5min.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5min.ForeColor = System.Drawing.Color.Yellow;
            this.lbl5min.Location = new System.Drawing.Point(92, 63);
            this.lbl5min.Name = "lbl5min";
            this.lbl5min.Size = new System.Drawing.Size(0, 9);
            this.lbl5min.TabIndex = 8;
            // 
            // pbForecastButton
            // 
            this.pbForecastButton.Image = global::WUnderK.Properties.Resources.forecast_off;
            this.pbForecastButton.Location = new System.Drawing.Point(137, 93);
            this.pbForecastButton.Name = "pbForecastButton";
            this.pbForecastButton.Size = new System.Drawing.Size(15, 15);
            this.pbForecastButton.TabIndex = 27;
            this.pbForecastButton.TabStop = false;
            this.toolTip1.SetToolTip(this.pbForecastButton, "Forecast");
            this.pbForecastButton.Click += new System.EventHandler(this.pbForecastButton_Click);
            this.pbForecastButton.MouseEnter += new System.EventHandler(this.pbForecast_MouseEnter);
            this.pbForecastButton.MouseLeave += new System.EventHandler(this.pbForecast_MouseLeave);
            // 
            // pbDetailsButton
            // 
            this.pbDetailsButton.Image = global::WUnderK.Properties.Resources.details_off;
            this.pbDetailsButton.Location = new System.Drawing.Point(3, 93);
            this.pbDetailsButton.Name = "pbDetailsButton";
            this.pbDetailsButton.Size = new System.Drawing.Size(15, 15);
            this.pbDetailsButton.TabIndex = 16;
            this.pbDetailsButton.TabStop = false;
            this.toolTip1.SetToolTip(this.pbDetailsButton, "Details");
            this.pbDetailsButton.Click += new System.EventHandler(this.pbDetails_Click);
            this.pbDetailsButton.MouseEnter += new System.EventHandler(this.pbDetails_MouseEnter);
            this.pbDetailsButton.MouseLeave += new System.EventHandler(this.pbDetails_MouseLeave);
            // 
            // pbMove
            // 
            this.pbMove.Image = global::WUnderK.Properties.Resources.hand_off;
            this.pbMove.Location = new System.Drawing.Point(154, 58);
            this.pbMove.Name = "pbMove";
            this.pbMove.Size = new System.Drawing.Size(20, 20);
            this.pbMove.TabIndex = 12;
            this.pbMove.TabStop = false;
            this.toolTip1.SetToolTip(this.pbMove, "Move");
            this.pbMove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbMove_MouseDown);
            this.pbMove.MouseEnter += new System.EventHandler(this.pbMove_MouseEnter);
            this.pbMove.MouseLeave += new System.EventHandler(this.pbMove_MouseLeave);
            this.pbMove.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbMove_MouseMove);
            this.pbMove.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbMove_MouseUp);
            // 
            // pbOptions
            // 
            this.pbOptions.Image = global::WUnderK.Properties.Resources.options_off;
            this.pbOptions.Location = new System.Drawing.Point(155, 33);
            this.pbOptions.Name = "pbOptions";
            this.pbOptions.Size = new System.Drawing.Size(15, 15);
            this.pbOptions.TabIndex = 11;
            this.pbOptions.TabStop = false;
            this.toolTip1.SetToolTip(this.pbOptions, "Options");
            this.pbOptions.Click += new System.EventHandler(this.pbOptions_Click);
            this.pbOptions.MouseEnter += new System.EventHandler(this.pbOptions_MouseEnter);
            this.pbOptions.MouseLeave += new System.EventHandler(this.pbOptions_MouseLeave);
            // 
            // pbMinimize
            // 
            this.pbMinimize.Image = global::WUnderK.Properties.Resources.min_off;
            this.pbMinimize.Location = new System.Drawing.Point(155, 17);
            this.pbMinimize.Name = "pbMinimize";
            this.pbMinimize.Size = new System.Drawing.Size(15, 15);
            this.pbMinimize.TabIndex = 10;
            this.pbMinimize.TabStop = false;
            this.toolTip1.SetToolTip(this.pbMinimize, "Minimize");
            this.pbMinimize.Click += new System.EventHandler(this.pbMinimize_Click);
            this.pbMinimize.MouseEnter += new System.EventHandler(this.pbMinimize_MouseEnter);
            this.pbMinimize.MouseLeave += new System.EventHandler(this.pbMinimize_MouseLeave);
            // 
            // pbExit
            // 
            this.pbExit.Image = global::WUnderK.Properties.Resources.close_off;
            this.pbExit.Location = new System.Drawing.Point(155, 1);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(15, 15);
            this.pbExit.TabIndex = 9;
            this.pbExit.TabStop = false;
            this.toolTip1.SetToolTip(this.pbExit, "Exit");
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            this.pbExit.MouseEnter += new System.EventHandler(this.pbExit_MouseEnter);
            this.pbExit.MouseLeave += new System.EventHandler(this.pbExit_MouseLeave);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "WUnderK";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.BackColor = System.Drawing.Color.Transparent;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.Color.White;
            this.lblCity.Location = new System.Drawing.Point(5, 65);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(101, 20);
            this.lblCity.TabIndex = 14;
            this.lblCity.Text = "Click Options";
            // 
            // lblTemperature
            // 
            this.lblTemperature.BackColor = System.Drawing.Color.Transparent;
            this.lblTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperature.ForeColor = System.Drawing.Color.White;
            this.lblTemperature.Location = new System.Drawing.Point(80, 1);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTemperature.Size = new System.Drawing.Size(75, 31);
            this.lblTemperature.TabIndex = 15;
            this.lblTemperature.Text = "---°";
            this.lblTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // paDetails
            // 
            this.paDetails.Controls.Add(this.lblPrecip);
            this.paDetails.Controls.Add(this.lblUV);
            this.paDetails.Controls.Add(this.lblVisibility);
            this.paDetails.Controls.Add(this.lblFeelsLike);
            this.paDetails.Controls.Add(this.lblPressure);
            this.paDetails.Controls.Add(this.lblWind);
            this.paDetails.Controls.Add(this.lblHumidity);
            this.paDetails.Controls.Add(this.lblWeather);
            this.paDetails.Controls.Add(this.pbDetailsPane);
            this.paDetails.Location = new System.Drawing.Point(3, 115);
            this.paDetails.Name = "paDetails";
            this.paDetails.Size = new System.Drawing.Size(150, 110);
            this.paDetails.TabIndex = 26;
            // 
            // lblPrecip
            // 
            this.lblPrecip.AutoSize = true;
            this.lblPrecip.BackColor = System.Drawing.Color.DarkBlue;
            this.lblPrecip.ForeColor = System.Drawing.Color.Yellow;
            this.lblPrecip.Location = new System.Drawing.Point(3, 97);
            this.lblPrecip.Name = "lblPrecip";
            this.lblPrecip.Size = new System.Drawing.Size(35, 13);
            this.lblPrecip.TabIndex = 8;
            this.lblPrecip.Text = "label1";
            // 
            // lblUV
            // 
            this.lblUV.AutoSize = true;
            this.lblUV.BackColor = System.Drawing.Color.DarkBlue;
            this.lblUV.ForeColor = System.Drawing.Color.Yellow;
            this.lblUV.Location = new System.Drawing.Point(3, 82);
            this.lblUV.Name = "lblUV";
            this.lblUV.Size = new System.Drawing.Size(35, 13);
            this.lblUV.TabIndex = 7;
            this.lblUV.Text = "label1";
            // 
            // lblVisibility
            // 
            this.lblVisibility.AutoSize = true;
            this.lblVisibility.BackColor = System.Drawing.Color.DarkBlue;
            this.lblVisibility.ForeColor = System.Drawing.Color.Yellow;
            this.lblVisibility.Location = new System.Drawing.Point(3, 69);
            this.lblVisibility.Name = "lblVisibility";
            this.lblVisibility.Size = new System.Drawing.Size(35, 13);
            this.lblVisibility.TabIndex = 6;
            this.lblVisibility.Text = "label1";
            // 
            // lblFeelsLike
            // 
            this.lblFeelsLike.AutoSize = true;
            this.lblFeelsLike.BackColor = System.Drawing.Color.DarkBlue;
            this.lblFeelsLike.ForeColor = System.Drawing.Color.Yellow;
            this.lblFeelsLike.Location = new System.Drawing.Point(3, 56);
            this.lblFeelsLike.Name = "lblFeelsLike";
            this.lblFeelsLike.Size = new System.Drawing.Size(35, 13);
            this.lblFeelsLike.TabIndex = 5;
            this.lblFeelsLike.Text = "label1";
            // 
            // lblPressure
            // 
            this.lblPressure.AutoSize = true;
            this.lblPressure.BackColor = System.Drawing.Color.DarkBlue;
            this.lblPressure.ForeColor = System.Drawing.Color.Yellow;
            this.lblPressure.Location = new System.Drawing.Point(3, 43);
            this.lblPressure.Name = "lblPressure";
            this.lblPressure.Size = new System.Drawing.Size(35, 13);
            this.lblPressure.TabIndex = 4;
            this.lblPressure.Text = "label1";
            // 
            // lblWind
            // 
            this.lblWind.AutoSize = true;
            this.lblWind.BackColor = System.Drawing.Color.DarkBlue;
            this.lblWind.ForeColor = System.Drawing.Color.Yellow;
            this.lblWind.Location = new System.Drawing.Point(3, 30);
            this.lblWind.Name = "lblWind";
            this.lblWind.Size = new System.Drawing.Size(35, 13);
            this.lblWind.TabIndex = 3;
            this.lblWind.Text = "label1";
            // 
            // lblHumidity
            // 
            this.lblHumidity.AutoSize = true;
            this.lblHumidity.BackColor = System.Drawing.Color.DarkBlue;
            this.lblHumidity.ForeColor = System.Drawing.Color.Yellow;
            this.lblHumidity.Location = new System.Drawing.Point(3, 17);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(35, 13);
            this.lblHumidity.TabIndex = 2;
            this.lblHumidity.Text = "label1";
            // 
            // lblWeather
            // 
            this.lblWeather.AutoSize = true;
            this.lblWeather.BackColor = System.Drawing.Color.DarkBlue;
            this.lblWeather.ForeColor = System.Drawing.Color.Yellow;
            this.lblWeather.Location = new System.Drawing.Point(3, 4);
            this.lblWeather.Name = "lblWeather";
            this.lblWeather.Size = new System.Drawing.Size(35, 13);
            this.lblWeather.TabIndex = 1;
            this.lblWeather.Text = "label1";
            // 
            // pbDetailsPane
            // 
            this.pbDetailsPane.BackColor = System.Drawing.Color.DarkBlue;
            this.pbDetailsPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbDetailsPane.Location = new System.Drawing.Point(0, 0);
            this.pbDetailsPane.Name = "pbDetailsPane";
            this.pbDetailsPane.Size = new System.Drawing.Size(150, 110);
            this.pbDetailsPane.TabIndex = 0;
            this.pbDetailsPane.TabStop = false;
            // 
            // pbWeatherImage
            // 
            this.pbWeatherImage.Image = global::WUnderK.Properties.Resources._4_few_clouds;
            this.pbWeatherImage.Location = new System.Drawing.Point(3, 1);
            this.pbWeatherImage.Name = "pbWeatherImage";
            this.pbWeatherImage.Size = new System.Drawing.Size(150, 90);
            this.pbWeatherImage.TabIndex = 13;
            this.pbWeatherImage.TabStop = false;
            // 
            // paForecast
            // 
            this.paForecast.Controls.Add(this.lblForecast1);
            this.paForecast.Controls.Add(this.lblFC2);
            this.paForecast.Controls.Add(this.lblForecast2);
            this.paForecast.Controls.Add(this.lblFC3);
            this.paForecast.Controls.Add(this.lblForecast3);
            this.paForecast.Controls.Add(this.lblForecast4);
            this.paForecast.Controls.Add(this.lblFC4);
            this.paForecast.Controls.Add(this.lblFC1);
            this.paForecast.Controls.Add(this.pbForecast);
            this.paForecast.Location = new System.Drawing.Point(180, 1);
            this.paForecast.Name = "paForecast";
            this.paForecast.Size = new System.Drawing.Size(437, 107);
            this.paForecast.TabIndex = 28;
            // 
            // lblForecast1
            // 
            this.lblForecast1.AutoSize = true;
            this.lblForecast1.BackColor = System.Drawing.Color.Purple;
            this.lblForecast1.ForeColor = System.Drawing.Color.Yellow;
            this.lblForecast1.Location = new System.Drawing.Point(1, 14);
            this.lblForecast1.Name = "lblForecast1";
            this.lblForecast1.Size = new System.Drawing.Size(0, 13);
            this.lblForecast1.TabIndex = 12;
            // 
            // lblFC2
            // 
            this.lblFC2.AutoSize = true;
            this.lblFC2.BackColor = System.Drawing.Color.Purple;
            this.lblFC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFC2.ForeColor = System.Drawing.Color.Yellow;
            this.lblFC2.Location = new System.Drawing.Point(1, 27);
            this.lblFC2.Name = "lblFC2";
            this.lblFC2.Size = new System.Drawing.Size(0, 13);
            this.lblFC2.TabIndex = 11;
            // 
            // lblForecast2
            // 
            this.lblForecast2.AutoSize = true;
            this.lblForecast2.BackColor = System.Drawing.Color.Purple;
            this.lblForecast2.ForeColor = System.Drawing.Color.Yellow;
            this.lblForecast2.Location = new System.Drawing.Point(1, 40);
            this.lblForecast2.Name = "lblForecast2";
            this.lblForecast2.Size = new System.Drawing.Size(0, 13);
            this.lblForecast2.TabIndex = 10;
            // 
            // lblFC3
            // 
            this.lblFC3.AutoSize = true;
            this.lblFC3.BackColor = System.Drawing.Color.Purple;
            this.lblFC3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFC3.ForeColor = System.Drawing.Color.Yellow;
            this.lblFC3.Location = new System.Drawing.Point(1, 53);
            this.lblFC3.Name = "lblFC3";
            this.lblFC3.Size = new System.Drawing.Size(410, 13);
            this.lblFC3.TabIndex = 9;
            this.lblFC3.Text = "Click on Options and enter the City, State or Country and your API key.";
            // 
            // lblForecast3
            // 
            this.lblForecast3.AutoSize = true;
            this.lblForecast3.BackColor = System.Drawing.Color.Purple;
            this.lblForecast3.ForeColor = System.Drawing.Color.Yellow;
            this.lblForecast3.Location = new System.Drawing.Point(1, 66);
            this.lblForecast3.Name = "lblForecast3";
            this.lblForecast3.Size = new System.Drawing.Size(0, 13);
            this.lblForecast3.TabIndex = 8;
            // 
            // lblForecast4
            // 
            this.lblForecast4.AutoSize = true;
            this.lblForecast4.BackColor = System.Drawing.Color.Purple;
            this.lblForecast4.ForeColor = System.Drawing.Color.Yellow;
            this.lblForecast4.Location = new System.Drawing.Point(1, 92);
            this.lblForecast4.Name = "lblForecast4";
            this.lblForecast4.Size = new System.Drawing.Size(0, 13);
            this.lblForecast4.TabIndex = 6;
            // 
            // lblFC4
            // 
            this.lblFC4.AutoSize = true;
            this.lblFC4.BackColor = System.Drawing.Color.Purple;
            this.lblFC4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFC4.ForeColor = System.Drawing.Color.Yellow;
            this.lblFC4.Location = new System.Drawing.Point(1, 79);
            this.lblFC4.Name = "lblFC4";
            this.lblFC4.Size = new System.Drawing.Size(0, 13);
            this.lblFC4.TabIndex = 5;
            // 
            // lblFC1
            // 
            this.lblFC1.AutoSize = true;
            this.lblFC1.BackColor = System.Drawing.Color.Purple;
            this.lblFC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFC1.ForeColor = System.Drawing.Color.Yellow;
            this.lblFC1.Location = new System.Drawing.Point(1, 1);
            this.lblFC1.Name = "lblFC1";
            this.lblFC1.Size = new System.Drawing.Size(0, 13);
            this.lblFC1.TabIndex = 2;
            // 
            // pbForecast
            // 
            this.pbForecast.BackColor = System.Drawing.Color.Purple;
            this.pbForecast.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbForecast.Location = new System.Drawing.Point(0, 0);
            this.pbForecast.Name = "pbForecast";
            this.pbForecast.Size = new System.Drawing.Size(437, 107);
            this.pbForecast.TabIndex = 1;
            this.pbForecast.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(625, 240);
            this.Controls.Add(this.paForecast);
            this.Controls.Add(this.pbForecastButton);
            this.Controls.Add(this.paDetails);
            this.Controls.Add(this.pbDetailsButton);
            this.Controls.Add(this.lblTemperature);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.pbWeatherImage);
            this.Controls.Add(this.pbMove);
            this.Controls.Add(this.pbOptions);
            this.Controls.Add(this.pbMinimize);
            this.Controls.Add(this.pbExit);
            this.Controls.Add(this.lbl5min);
            this.Controls.Add(this.lbl4min);
            this.Controls.Add(this.lbl3min);
            this.Controls.Add(this.lbl2min);
            this.Controls.Add(this.lbl1min);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pbForecastButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetailsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.paDetails.ResumeLayout(false);
            this.paDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetailsPane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWeatherImage)).EndInit();
            this.paForecast.ResumeLayout(false);
            this.paForecast.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbForecast)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl1min;
        private System.Windows.Forms.Label lbl2min;
        private System.Windows.Forms.Label lbl3min;
        private System.Windows.Forms.Label lbl4min;
        private System.Windows.Forms.Label lbl5min;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.PictureBox pbMinimize;
        private System.Windows.Forms.PictureBox pbOptions;
        private System.Windows.Forms.PictureBox pbMove;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.PictureBox pbWeatherImage;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.PictureBox pbDetailsButton;
        private System.Windows.Forms.Panel paDetails;
        private System.Windows.Forms.Label lblPrecip;
        private System.Windows.Forms.Label lblUV;
        private System.Windows.Forms.Label lblVisibility;
        private System.Windows.Forms.Label lblFeelsLike;
        private System.Windows.Forms.Label lblPressure;
        private System.Windows.Forms.Label lblWind;
        private System.Windows.Forms.Label lblHumidity;
        private System.Windows.Forms.Label lblWeather;
        private System.Windows.Forms.PictureBox pbDetailsPane;
        private System.Windows.Forms.PictureBox pbForecastButton;
        private System.Windows.Forms.Panel paForecast;
        private System.Windows.Forms.Label lblForecast1;
        private System.Windows.Forms.Label lblFC2;
        private System.Windows.Forms.Label lblForecast2;
        private System.Windows.Forms.Label lblFC3;
        private System.Windows.Forms.Label lblForecast3;
        private System.Windows.Forms.Label lblForecast4;
        private System.Windows.Forms.Label lblFC4;
        private System.Windows.Forms.Label lblFC1;
        private System.Windows.Forms.PictureBox pbForecast;
    }
}

