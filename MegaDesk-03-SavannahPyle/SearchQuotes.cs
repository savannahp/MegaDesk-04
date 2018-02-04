using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace MegaDesk_03_SavannahPyle
{
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
        }

        private void exitSearch_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            StreamReader reader = new StreamReader("quotes.txt");
            string quoteLine = reader.ReadLine();
            listBox1.Items.Add("Material\t" + "Name\t" + "Date\t\t\t" + "Width\t" + "Depth\t" + "Drawers\t" + "Quote");
            while (quoteLine != null)
            {
                String[] strings = quoteLine.Split(',');
                string bigString = "";
                if (strings[0] == comboBox1.Text)
                {
                    foreach (string value in strings)
                    {
                        bigString += (value + "\t");
                    }

                    listBox1.Items.Add(bigString);
                }
                quoteLine = reader.ReadLine();
            }
            reader.Close();
        }
    }
}
