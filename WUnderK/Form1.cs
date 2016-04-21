using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;

namespace WUnderK
{
    public partial class Form1 : Form
    {
        //Used for drag & drop when moving the window
        private bool bMouseDown;
        private Point PLastLocation;
        //Boolean that holds the transparency
        public static bool bTransparent;
        //Boolean that holds the stay on top feature
        public static bool bStayOnTop;
        //Boolean that holds temperature unit (C or F). C = true
        public static bool bUnit;
        //5 mins default to check for weather changes
        public static int intTimer = 5;
        //Background and Forefront colors
        public static Color BackgroundColor;
        public static Color ForefrontColor;
        //The options form
        public static frmOptions frmBox;
        //Weather Underground API key. A must.
        public static string strWUKey = "";
        //Initial City tells you to click options.
        public static string strCity = "Click Options";
        //State or Country
        public static string strStateOrCountry;
        //All the values that WU returns
        public static double doCelsiusTemperature;
        public static double doFahrenheitTemperature;
        public static string strWeather="";
        public static string strHumidity;
        public static string strWindDir;
        public static double doWindMPH;
        public static double doWindKPH;
        public static string strWind;
        public static string strPressure_in, strPressure_mb, strPressure_trend;
        public static string strPressure;
        public static string strFeelsLike;
        public static string strVisibility;
        public static string strUV;
        public static string strPrecip;
        public static string strFC1, strFC2, strFC3, strFC4;
        public static string strForecast1, strForecast2, strForecast3, strForecast4;

        //Update the details pane with the values from the API call
        private void UpdateDetailsAndForecastPane()
        {
            lblWeather.Text = "Weather: " + strWeather;
            lblHumidity.Text = "Relative humidity: " + strHumidity;
            lblWind.Text = "Wind: " + strWind;
            lblPressure.Text = "Pressure:" + strPressure;
            lblWind.Text = "Wind: " + strWind;
            lblPressure.Text = "Pressure: " + strPressure;
            lblFeelsLike.Text = "Feels like: " + strFeelsLike;
            lblVisibility.Text = "Visibility: " + strVisibility;
            lblUV.Text = "UV Index: " + strUV;
            lblPrecip.Text = "Precipitation: " + strPrecip;
            string strWeatherPic = strWeather.ToUpper();
            //Remove the following adjectives
            strWeatherPic = strWeatherPic.Replace("LIGHT ", "");
            strWeatherPic = strWeatherPic.Replace("HEAVY ", "");
            strWeatherPic = strWeatherPic.Replace("PATCHES OF ", "");
            strWeatherPic = strWeatherPic.Replace("SHALLOW ", "");
            strWeatherPic = strWeatherPic.Replace("PARTIAL ", "");
            strWeatherPic = strWeatherPic.Replace("PARTLY ", "");
            strWeatherPic = strWeatherPic.Replace("MOSTLY ", "");
            strWeatherPic = strWeatherPic.Replace("FREEZING ", "");
            //Depending on what's left, choose a picture from the resources
            switch (strWeatherPic)
            {
                case "DRIZZLE":
                case "RAIN":
                case "RAIN MIST":
                case "RAIN SHOWERS":
                case "THUNDERSTORMS AND RAIN":
                    pbWeatherImage.Image = ((System.Drawing.Image)(Properties.Resources._05_rainy));
                    break;
                case "SNOW":
                case "SNOW GRAINS":
                case "LOW DRIFTING SNOW":
                case "BLOWING SNOW":
                case "SNOW SHOWERS":
                case "SNOW BLOWING SNOW MIST":
                case "THUNDERSTORMS AND SNOW":
                    pbWeatherImage.Image = ((System.Drawing.Image)(Properties.Resources._2_snowing));
                    break;
                case "CLOUDY":
                case "OVERCAST":
                    pbWeatherImage.Image = ((System.Drawing.Image)(Properties.Resources._3_cloudy));
                    break;
                case "SCATTERED CLOUDS":
                    pbWeatherImage.Image = ((System.Drawing.Image)(Properties.Resources._4_few_clouds));
                    break;
                case "CLEAR":
                    pbWeatherImage.Image = ((System.Drawing.Image)(Properties.Resources._1_sunny));
                    break;
                default:
                    pbWeatherImage.Image = ((System.Drawing.Image)(Properties.Resources._4_few_clouds));
                    break;
            }
            lblFC1.Text = strFC1;
            lblFC2.Text = strFC2;
            lblFC3.Text = strFC3;
            lblFC4.Text = strFC4;
            lblForecast1.Text = strForecast1;
            lblForecast2.Text = strForecast2;
            lblForecast3.Text = strForecast3;
            lblForecast4.Text = strForecast4;
        }

        public Form1()
        {
            InitializeComponent();
        }

        //Check weather, forecast and update the main pane, details and forecast pane
        private void timer1_Tick(object sender, EventArgs e)
        {
            CheckWUWeather();
            CheckWUForecast();
            UpdateMainPane();
            UpdateDetailsAndForecastPane();
        }

        //Initial values when the app starts
        //If already configured, get the values from the %userprofile% file
        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Properties.Settings.Default.BGColor;
            ForeColor = Properties.Settings.Default.FFColor;
            BackgroundColor = BackColor;
            ForefrontColor = ForeColor;
            Height = 110;
            Width = 180;            
            AllowTransparency = Properties.Settings.Default.Transparent;            
            intTimer = Properties.Settings.Default.Interval;
            timer1.Interval = intTimer * 1000 * 60;
            ShowInTaskbar = false;
            bTransparent = Properties.Settings.Default.Transparent;
            bUnit = Properties.Settings.Default.Units;
            bStayOnTop = Properties.Settings.Default.StayOnTop;
            TopMost = true;
            strWUKey = Properties.Settings.Default.WUAPIKey;
            strCity = Properties.Settings.Default.City;
            strStateOrCountry = Properties.Settings.Default.StateCountry;
            lblCity.Parent = pbWeatherImage;
            lblCity.BackColor = Color.Transparent;
            lblTemperature.Parent = pbWeatherImage;
            lblTemperature.BackColor = Color.Transparent;
            if (CheckWUWeather())
            {
                CheckWUForecast();
                UpdateMainPane();
                UpdateDetailsAndForecastPane();
            } else
            {
                MessageBox.Show("Click on Options for initial configuration.");
            }            
        }
        //Methods for dealing with the side buttons (options, minimize, close, move)
        private void pbMinimize_MouseEnter(object sender, EventArgs e)
        {
            pbMinimize.Image = ((System.Drawing.Image)(Properties.Resources.min_on));
        }

        private void pbMinimize_MouseLeave(object sender, EventArgs e)
        {
            pbMinimize.Image = ((System.Drawing.Image)(Properties.Resources.min_off));
        }

        private void pbExit_MouseEnter(object sender, EventArgs e)
        {
            pbExit.Image = ((System.Drawing.Image)(Properties.Resources.close_on));
        }

        private void pbExit_MouseLeave(object sender, EventArgs e)
        {
            pbExit.Image = ((System.Drawing.Image)(Properties.Resources.close_off));
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pbOptions_MouseEnter(object sender, EventArgs e)
        {
            pbOptions.Image = ((System.Drawing.Image)(Properties.Resources.options_on));
        }

        private void pbOptions_MouseLeave(object sender, EventArgs e)
        {
            pbOptions.Image = ((System.Drawing.Image)(Properties.Resources.options_off));
        }

        private void pbMove_MouseEnter(object sender, EventArgs e)
        {
            pbMove.Image = ((System.Drawing.Image)(Properties.Resources.hand_on));
        }

        private void pbMove_MouseLeave(object sender, EventArgs e)
        {
            pbMove.Image = ((System.Drawing.Image)(Properties.Resources.hand_off));
        }

        private void pbMove_MouseDown(object sender, MouseEventArgs e)
        {
            bMouseDown = true;
            PLastLocation = e.Location;
        }
        //When moving the app
        private void pbMove_MouseMove(object sender, MouseEventArgs e)
        {
            if (bMouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - PLastLocation.X) + e.X, (this.Location.Y - PLastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void pbMove_MouseUp(object sender, MouseEventArgs e)
        {
            bMouseDown = false;
        }

        private void pbOptions_Click(object sender, EventArgs e)
        {
            frmOptions frmBox = new frmOptions();
            frmBox.ShowDialog();
        }

        //Updates the main pane with the values from the API call
        private void UpdateMainPane()
        {
            if (bTransparent)
            {
                TransparencyKey = BackgroundColor;
            }
            else TransparencyKey = Color.Empty;
            if (bStayOnTop)
            {
                TopMost = true;
            }
            else TopMost = false;
            if (bUnit)
            {
                lblTemperature.Text = Convert.ToInt32(doCelsiusTemperature).ToString() + "°";
            }
            else lblTemperature.Text = Convert.ToInt32(doFahrenheitTemperature).ToString() + "°";
            BackColor = BackgroundColor;
            lblTemperature.ForeColor = ForefrontColor;
            lblCity.ForeColor = ForefrontColor;
            lblCity.Text = strCity;
            timer1.Interval = intTimer * 1000 * 60;
            timer1.Enabled = true;
            UpdateDetailsAndForecastPane();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            UpdateMainPane();
        }
        //When minimized in tray
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
                Hide();
        }

        //Sends API to WU and returns JSON for the current weather
        public static bool CheckWUWeather()
        {
            bool bResult = true;
            WebClient wc = new WebClient();
            try
            {
                string strURL = "http://api.wunderground.com/api/" + strWUKey +
                    "/conditions/q/" + strStateOrCountry + "/" + strCity + ".json";
                string strJSON = wc.DownloadString(strURL);
                WUWeatherClass objWU = JsonConvert.DeserializeObject<WUWeatherClass>(strJSON);
                if (objWU.response.error == null)
                {
                    strCity = objWU.current_observation.display_location.city;
                    doCelsiusTemperature = objWU.current_observation.temp_c;
                    doFahrenheitTemperature = objWU.current_observation.temp_f;
                    strWeather = objWU.current_observation.weather;
                    strHumidity = objWU.current_observation.relative_humidity;
                    strWindDir = objWU.current_observation.wind_dir;
                    doWindMPH = objWU.current_observation.wind_mph;
                    doWindKPH = objWU.current_observation.wind_kph;
                    strWind = strWindDir + " " + Convert.ToInt32(doWindMPH).ToString() + "mph/" + Convert.ToInt32(doWindKPH).ToString() + "kph";
                    strPressure_in = objWU.current_observation.pressure_in;
                    strPressure_mb = objWU.current_observation.pressure_mb;
                    strPressure_trend = objWU.current_observation.pressure_trend;
                    strPressure = strPressure_in + "in/" + strPressure_mb + "mb " + strPressure_trend;
                    strFeelsLike = objWU.current_observation.feelslike_f + "F/" + objWU.current_observation.feelslike_c + "C";
                    strVisibility = objWU.current_observation.visibility_mi + "mi/" + objWU.current_observation.visibility_km + "km";
                    strUV = objWU.current_observation.UV;
                    strPrecip = objWU.current_observation.precip_today_string;
                }
                else
                {
                    MessageBox.Show(objWU.response.error.description);
                    bResult = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            wc.Dispose();
            return bResult;
        }

        //Sends API to WU and returns JSON for the forecast
        public static bool CheckWUForecast()
        {
            bool bResult = true;
            WebClient wc = new WebClient();
            try
            {
                string strURL = "http://api.wunderground.com/api/" + strWUKey +
                    "/forecast/q/" + strStateOrCountry + "/" + strCity + ".json";
                string strJSON = wc.DownloadString(strURL);
                WUForecastClass objWU = JsonConvert.DeserializeObject<WUForecastClass>(strJSON, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
                strFC1 = objWU.forecast.txt_forecast.forecastday[0].title;
                strFC2 = objWU.forecast.txt_forecast.forecastday[1].title;
                strFC3 = objWU.forecast.txt_forecast.forecastday[2].title;
                strFC4 = objWU.forecast.txt_forecast.forecastday[3].title;
                if (bUnit)
                {
                    strForecast1 = objWU.forecast.txt_forecast.forecastday[0].fcttext_metric;
                    strForecast2 = objWU.forecast.txt_forecast.forecastday[1].fcttext_metric;
                    strForecast3 = objWU.forecast.txt_forecast.forecastday[2].fcttext_metric;
                    strForecast4 = objWU.forecast.txt_forecast.forecastday[3].fcttext_metric;
                } else
                {
                    strForecast1 = objWU.forecast.txt_forecast.forecastday[0].fcttext;
                    strForecast2 = objWU.forecast.txt_forecast.forecastday[1].fcttext;
                    strForecast3 = objWU.forecast.txt_forecast.forecastday[2].fcttext;
                    strForecast4 = objWU.forecast.txt_forecast.forecastday[3].fcttext;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            wc.Dispose();
            return bResult;
        }
        //Dealing with details and forecast buttons
        private void pbDetails_MouseEnter(object sender, EventArgs e)
        {
            pbDetailsButton.Image = ((System.Drawing.Image)(Properties.Resources.details_on));
        }

        private void pbForecast_MouseEnter(object sender, EventArgs e)
        {
            pbForecastButton.Image = ((System.Drawing.Image)(Properties.Resources.forecast_on));
        }

        private void pbForecast_MouseLeave(object sender, EventArgs e)
        {
            pbForecastButton.Image = ((System.Drawing.Image)(Properties.Resources.forecast_off));
        }

        private void pbForecastButton_Click(object sender, EventArgs e)
        {            
            if (Width == 625)
            {
                Width = 180;                
                return;
            }
            if (Width == 180)
            {
                Width = 625;
            }
        }

        private void pbDetails_MouseLeave(object sender, EventArgs e)
        {
            pbDetailsButton.Image = ((System.Drawing.Image)(Properties.Resources.details_off));
        }

        private void pbDetails_Click(object sender, EventArgs e)
        {
            if (Height == 230)
            {
                Height = 110;
                paDetails.Location = new Point(3, 115);
                pbDetailsButton.Location = new Point(3, 93);
                pbForecastButton.Location = new Point(137, 93);
                return;
            }
            if (Height == 110)
            {
                Height = 230;
                paDetails.Location = new Point(3, 93);
                pbDetailsButton.Location = new Point(3, 205);
                pbForecastButton.Location = new Point(137, 205);
            }
        }
    }
}
