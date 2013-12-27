using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeRunners
{
    public partial class Options : Form
    {
        #region Is Home
        private bool _ishome = false;
        private bool _isHome
        {
            get { return _ishome; }
            set
            {
                if (_ishome != value)
                {
                    _ishome = value;
                    toggleControls();
                }
            }
        }
        public Options isHome()
        {
            this._isHome = true;
            return this;
        }
        #endregion

        private void toggleControls()
        {
            //hide controls not to be used outside of home menu.

        }

        public Options()
        {
            InitializeComponent();
        }
    }
}
