using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steve
{
    public partial class Steve : Form
    {
        #region Member Variables..
        #endregion Member Variables..

        #region Constructors..
        public Steve()
        {
            InitializeComponent();

            int r = DoThing();
        }
        #endregion Constructors..

        private int DoThing()
        {
            return 0;
        }

        #region Methods..
        #endregion Methods
    }
}
