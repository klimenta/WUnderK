using System;
using System.Windows.Forms;

namespace WUnderK
{
    public partial class frmOptions : Form
    {
        bool bChangeTransparency;
        bool bChangeStayOnTop = true;             

        public frmOptions()
        {
            InitializeComponent();
        }

        private void frmOptions_Load(object sender, EventArgs e)
        {
            GetFormProperty();
        }
        //Get the values from the initial screen
        private void GetFormProperty()
        {
            btnBGColor.BackColor = Form1.BackgroundColor;
            btnFFColor.BackColor = Form1.ForefrontColor;
            cbTransparent.Checked = Form1.bTransparent;
            bChangeTransparency = Form1.bTransparent;
            cbStayOnTop.Checked = Form1.bStayOnTop;
            bChangeStayOnTop = Form1.bStayOnTop;
            neInterval.Value = Form1.intTimer;
            tbAPIKey.Text = Form1.strWUKey;
            rbMetric.Checked = Form1.bUnit;
            rbImperial.Checked = !Form1.bUnit;
            tbCity.Text = Form1.strCity;
            tbStateOrCountry.Text = Form1.strStateOrCountry;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            GetFormProperty();
            Close();
        }
        //Sets the values if changes are made and saves then under %userprofile%
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (bChangeTransparency)
            {
                Form1.bTransparent = true;
            }
            else Form1.bTransparent = false;

            if (bChangeStayOnTop)
            {
                Form1.bStayOnTop = true;                
            }
            else Form1.bStayOnTop = false;       
                                 
            Form1.BackgroundColor = btnBGColor.BackColor;
            Form1.ForefrontColor = btnFFColor.BackColor;
            Form1.intTimer = Decimal.ToInt32(neInterval.Value);
            Form1.strWUKey = tbAPIKey.Text.Trim();
            Form1.strCity = tbCity.Text.Trim();
            Form1.strStateOrCountry = tbStateOrCountry.Text.Trim();
            if (Form1.CheckWUWeather() && Form1.CheckWUForecast())
            {
                Properties.Settings.Default.Units = Form1.bUnit;
                Properties.Settings.Default.City = tbCity.Text.Trim();
                Properties.Settings.Default.StateCountry = tbStateOrCountry.Text.Trim();
                Properties.Settings.Default.Interval = Decimal.ToInt32(neInterval.Value);
                Properties.Settings.Default.Transparent = bChangeTransparency;
                Properties.Settings.Default.StayOnTop = bChangeStayOnTop;
                Properties.Settings.Default.WUAPIKey = tbAPIKey.Text.Trim();
                Properties.Settings.Default.BGColor = btnBGColor.BackColor;
                Properties.Settings.Default.FFColor = btnFFColor.BackColor;
                Properties.Settings.Default.Save();
                Close();
            }
        }

        private void cbTransparent_Click(object sender, EventArgs e)
        {
            bChangeTransparency = !bChangeTransparency;
        }

        private void btnBGColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                btnBGColor.BackColor = colorDialog1.Color;
            }
        }

        private void cbStayOnTop_Click(object sender, EventArgs e)
        {
            bChangeStayOnTop = !bChangeStayOnTop;
        }

        private void llblCopyright_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://blog.iandreev.com");
        }

        private void btnFFColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                btnFFColor.BackColor = colorDialog1.Color;
            }
        }

        private void rbCelsius_Click(object sender, EventArgs e)
        {            
            Form1.bUnit = true;
        }

        private void rbFahrenheit_Click(object sender, EventArgs e)
        {         
            Form1.bUnit = false;
        }
    }
}
