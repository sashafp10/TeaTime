using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TeaTime
{
    public partial class TimeProgress : UserControl
    {
        #region -- Constructors --

        public TimeProgress()
        {
            InitializeComponent();
        }

        #endregion

        #region -- Properties --


        private TimeSpan time;
        /// <summary>
        /// Get or set time to show
        /// </summary>
        public TimeSpan Time
        {
            get
            {
                return time;
            }
 
            set
            {
                time = value;
            }
        }

        private int interval;
        /// <summary>
        /// Get or set timer interval in miliseconds
        /// </summary>
        public int Interval
        {
            get
            {
                return interval;
            } 
            
            set
            {
                interval = value;
                tmrMain.Stop();
                tmrMain.Interval = interval;
                if (tmrMain.Enabled)
                    tmrMain.Start();
            }
        }

        #endregion

        #region -- Methods --

        #region - Public -

        #endregion

        #region - Private -

        #endregion

        #endregion

        #region -- Event Handlers --

        #endregion
    }
}
