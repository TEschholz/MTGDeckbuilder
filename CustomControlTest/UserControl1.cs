using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControlTest
{
    public partial class UserControl1 : UserControl
    {
        public Button ButtonPlus;
        public Button ButtonMinus;
        public Button ButtonEdit;
        public UserControl1()
        {
            InitializeComponent();
            ButtonPlus = button1;
            ButtonMinus = button2;
            ButtonEdit = button3;
            panelButtons.Visible = false;
        }
    }
}
