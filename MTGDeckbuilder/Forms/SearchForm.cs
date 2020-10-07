using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTGDeckbuilder.Forms
{
    public partial class SearchForm : Form
    {
        private bool _optionsVisible;
        public SearchForm()
        {
            InitializeComponent();
            panelSearchOptions.Visible = _optionsVisible;
        }

        private void btnAdvancedOptions_Click(object sender, EventArgs e)
        {
            _optionsVisible = !_optionsVisible;
            SetPanelSearchOptionsVisible(_optionsVisible);
        }

        private void SetPanelSearchOptionsVisible(bool optionsVisible)
        {
            panelSearchOptions.Visible = optionsVisible;
        }
    }
}
