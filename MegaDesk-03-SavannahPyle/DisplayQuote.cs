using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_03_SavannahPyle
{
    public partial class DisplayQuote : Form
    {
        public DisplayQuote()
        {
            InitializeComponent();
        }

        private void exitDisplay_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }
    }
}
