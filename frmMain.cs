using System;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TeaTime
{
    public partial class frmMain : Form
    {
        #region -- Variables --

        private Rectangle smallRect, bigRect, optionsRect;
        private bool isSmall = false;
        private Point mouseDownPosition = new Point(0,0);
        private int rigthBounds = 30;
        private ProgressBar currentActivePB = null;
        private string appCaption = "Tea Time";
        private string _currPhrase;

        #endregion

        #region --Event Handlers --

        public frmMain()
        {
            InitializeComponent();
            
            InitForms();
            InitProgresses();
            InitTimers();
        }

        private void frmMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point p = PointToScreen(new Point(e.X, e.Y));
                Left = p.X - mouseDownPosition.X;
                Top = p.Y - mouseDownPosition.Y;
            }
        }

        private void frmMain_MouseDown(object sender, MouseEventArgs e)
        {
            //remember mouse position
            mouseDownPosition = new Point(e.X, e.Y);
        }

        private void frmMain_MouseUp(object sender, MouseEventArgs e)
        {
            //drop mouse down coordinates
            mouseDownPosition.X = 0;
            mouseDownPosition.Y = 0;
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);

            if (pnlMain.Visible)
            {
                config.AppSettings.Settings["xMain"].Value = Location.X.ToString();
                config.AppSettings.Settings["yMain"].Value = Location.Y.ToString();   
            } 
            else if (pnlOptions.Visible)
            {
                config.AppSettings.Settings["xOptions"].Value = Location.X.ToString();
                config.AppSettings.Settings["yOptions"].Value = Location.Y.ToString();
            }
            else if (pnlSmallProgress.Visible)
            {
                config.AppSettings.Settings["xSmall"].Value = Location.X.ToString();
                config.AppSettings.Settings["ySmall"].Value = Location.Y.ToString();
            }

            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            InitForms();
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            //is small then close. If not small then make small
            if (isSmall && e.KeyCode == Keys.Escape)
                Close();
            else if (!isSmall && e.KeyCode == Keys.Escape)
                tmrMain_Tick(sender, e);

            tmrMain.Stop();
            tmrMain.Start();
        }

        private void frmMain_MouseEnter(object sender, EventArgs e)
        {
            Opacity = 1;
        }

        private void frmMain_MouseLeave(object sender, EventArgs e)
        {
            if (!pnlOptions.Visible)
                Opacity = 0.8;
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            ShowOptions();
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            ShowSmall();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            config.AppSettings.Settings["breakTime"].Value = (int.Parse(txtBy.Text)*60*1000).ToString();
            config.AppSettings.Settings["workTime"].Value = (int.Parse(txtEach.Text)*60*1000).ToString();
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            InitProgresses();
            InitTimers();
            ShowSmall();
        }

        private void btnCancelOptions_Click(object sender, EventArgs e)
        {
            ShowSmall();
        }

        private void btnResetOptions_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите сбросить настройки?", appCaption, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
                config.AppSettings.Settings["breakTime"].Value = (15*60*1000).ToString();
                config.AppSettings.Settings["workTime"].Value = (45*60*1000).ToString();
                config.AppSettings.Settings["xSmall"].Value =
                    (Screen.PrimaryScreen.Bounds.Width - smallRect.Width - rigthBounds).ToString();
                config.AppSettings.Settings["ySmall"].Value =
                    (Screen.PrimaryScreen.Bounds.Height - smallRect.Height - rigthBounds*2).ToString();
                config.AppSettings.Settings["xMain"].Value =
                    (Screen.PrimaryScreen.Bounds.Width/2 - bigRect.Width/2).ToString();
                config.AppSettings.Settings["yMain"].Value =
                    (Screen.PrimaryScreen.Bounds.Height/2 - bigRect.Height/2).ToString();
                config.AppSettings.Settings["xOptions"].Value =
                    (Screen.PrimaryScreen.Bounds.Width - optionsRect.Width - rigthBounds).ToString();
                config.AppSettings.Settings["yOptions"].Value =
                    (Screen.PrimaryScreen.Bounds.Height - optionsRect.Height - rigthBounds*2).ToString();
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
                MessageBox.Show("Настройки сброшены", appCaption);
                InitProgresses();
                InitTimers();
                ShowSmall();
            }
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            ShowSmall();
        }

        #region - Timers work -

        private void tmrMain_Tick(object sender, EventArgs e)
        {
            ShowMessage();
            tmrMain.Enabled = false;
            tmrBreak.Enabled = true;
        }

        private void tmrBreak_Tick(object sender, EventArgs e)
        {
            InitTimers();
            ShowSmall();
            tmrMain.Enabled = true;
            tmrBreak.Enabled = false;
        }

        private void tmrTicker_Tick(object sender, EventArgs e)
        {
            if (currentActivePB != null)
            {
                if (currentActivePB.Value == currentActivePB.Maximum)
                    currentActivePB.Value = 0;
                
                currentActivePB.Value += 1;
            }
        }

        #endregion

        #endregion

        #region -- Methods --

        private void SetTicker(Timer tmr, ProgressBar pb)
        {
            tmrTicker.Interval = (int)Math.Round((double)tmr.Interval/(double)pb.Maximum);
            currentActivePB = pb;
            currentActivePB.Value = 0;
            tmrTicker.Enabled = true;
        }

        /// <summary>
        /// Show options panel
        /// </summary>
        private void ShowOptions()
        {
            Height = optionsRect.Height;
            Top = optionsRect.Y;
            Left = optionsRect.X;
            Width = optionsRect.Width;

            txtBy.Text = TimeSpan.FromMilliseconds(tmrBreak.Interval).TotalMinutes.ToString();
            txtEach.Text = TimeSpan.FromMilliseconds(tmrMain.Interval).TotalMinutes.ToString();

            pnlOptions.Width = Width + 2;
            pnlOptions.Height = Height + 2;

            pnlOptions.Visible = true;
            pnlSmallProgress.Visible = false;
            pnlMain.Visible = false;

            tmrTicker.Enabled = tmrMain.Enabled = tmrBreak.Enabled = false;

            Opacity = 1;

            Activate();
        }

        /// <summary>
        /// Show small panel
        /// </summary>
        private void ShowSmall()
        {
            Height = smallRect.Height;
            Top = smallRect.Y;
            Left = smallRect.X;
            Width = smallRect.Width;

            SetTicker(tmrMain, pbSmall);

            pnlOptions.Visible = false;
            pnlSmallProgress.Visible = true;
            pnlMain.Visible = false;

            tmrMain.Enabled = true;
            tmrBreak.Enabled = false;

            Opacity = 0.8;

            Activate();
        }

        private string CurrPhrase
        {
            get { return _currPhrase; }
            set
            {
                _currPhrase = value;
                label1.Text = value;
            }
        }

        /// <summary>
        /// Show main panel
        /// </summary>
        private void ShowMessage()
        {
            Height = bigRect.Height;
            Top = bigRect.Y;
            Left = bigRect.X;
            Width = bigRect.Width;

            pnlOptions.Visible = false;
            pnlSmallProgress.Visible = false;
            pnlMain.Visible = true;
            CurrPhrase = PhrasesProvider.GetNextPhrase();

            SetTicker(tmrBreak, pbMain);

            tmrMain.Enabled = false;
            tmrBreak.Enabled = true;

            Opacity = 1;

            Activate();
        }

        /// <summary>
        /// Initialize maximums for progress bars for smooth sliding
        /// </summary>
        private void InitProgresses()
        {
            //set progress bars maximum to 1 percent
            pbSmall.Maximum =(int)Math.Round((double)tmrMain.Interval/100);
            pbMain.Maximum = (int)Math.Round((double)tmrBreak.Interval / 100);
        }

        private void txtShowSmallGo_TextChanged(object sender, EventArgs e)
        {
            if (txtShowSmallGo.Text.Equals(CurrPhrase))
            {
                ShowSmall();
                txtShowSmallGo.Text = "";
            }
        }

        /// <summary>
        /// Set save or default values for timers
        /// </summary>
        private void InitTimers()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            try
            {
                tmrBreak.Interval = int.Parse(config.AppSettings.Settings["breakTime"].Value);
                tmrMain.Interval = int.Parse(config.AppSettings.Settings["workTime"].Value);
            } catch
            {
                config.AppSettings.Settings["breakTime"].Value = (45 * 60 * 1000).ToString();
                config.AppSettings.Settings["workTime"].Value = (15 * 60 * 1000).ToString();
            }
        }

        /// <summary>
        /// Set saved or default values for panels
        /// </summary>
        private void InitForms()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);

            //set small rectangle
            smallRect = new Rectangle(1000, 850, 123, 27);
            try
            {
                smallRect.X = int.Parse(config.AppSettings.Settings["xSmall"].Value);
                smallRect.Y = int.Parse(config.AppSettings.Settings["ySmall"].Value);
            }
            catch
            {
                smallRect.X = Screen.PrimaryScreen.Bounds.Width - smallRect.Width - rigthBounds;
                smallRect.Y = Screen.PrimaryScreen.Bounds.Height - smallRect.Height - rigthBounds * 2;
            }

            //set options rectangle
            optionsRect = new Rectangle(170, 70, 120, 64);
            try
            {
                optionsRect.X = int.Parse(config.AppSettings.Settings["xOptions"].Value);
                optionsRect.Y = int.Parse(config.AppSettings.Settings["yOptions"].Value);
            }
            catch
            {
                optionsRect.X = Screen.PrimaryScreen.Bounds.Width - optionsRect.Width - rigthBounds;
                optionsRect.Y = Screen.PrimaryScreen.Bounds.Height - optionsRect.Height - rigthBounds * 2;
            }

            //set big window rectangle
            bigRect = new Rectangle(500, 400, pnlMain.Width, pnlMain.Height);
            try
            {
                bigRect.X = int.Parse(config.AppSettings.Settings["xMain"].Value);
                bigRect.Y = int.Parse(config.AppSettings.Settings["yMain"].Value);
            }
            catch
            {
                bigRect.X = Screen.PrimaryScreen.Bounds.Width / 2 - bigRect.Width / 2;
                bigRect.Y = Screen.PrimaryScreen.Bounds.Height / 2 - bigRect.Height / 2;
            }

            //set panels position
            pnlSmallProgress.Location = pnlMain.Location = pnlOptions.Location = new Point(1, 1);   
        }

        #endregion

    }
}
