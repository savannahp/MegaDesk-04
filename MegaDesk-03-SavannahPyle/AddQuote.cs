using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static MegaDesk_03_SavannahPyle.Desk;

namespace MegaDesk_03_SavannahPyle
{
    public partial class AddQuote : Form
    {
        private void cancelQuote(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }
        public AddQuote()
        {
            InitializeComponent();
        }
   

        private void drawersUpDown_ValueChanged(object sender, EventArgs e)
        {
            //Desk desk = new Desk();
            //desk.NumDrawers = (int)drawersUpDown.Value;
        }

        private void numericDepth_ValueChanged(object sender, EventArgs e)
        {
            //Desk desk = new Desk();
            //desk.Depth = (int)numericDepth.Value;
            //took forevr to realize I needed to cast it
        }

        private void numericWidth_ValueChanged(object sender, EventArgs e)
        {
            //Desk desk = new Desk();
            //desk.Width = (int)numericWidth.Value;
        }

    
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            //DeskQuote desk = new DeskQuote();
            //desk.Name = txtName.Text;
        }

        private void rushDaysUpDown_ValueChanged(object sender, EventArgs e)
        {
            //DeskQuote desk = new DeskQuote();
            //desk.Rush = (int)rushDaysUpDown.Value;
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {

        }

        private void exitAdd_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Desk desk = new Desk();
            desk.Depth = (int)numericDepth.Value;
            desk.Width = (int)numericWidth.Value;
            desk.NumDrawers = (int)drawersUpDown.Value;
            desk.SelectMaterial((string)comboBox1.Text);

            DeskQuote quote = new DeskQuote();
            quote.Name = txtName.Text;
            quote.Rush = (int)rushDaysUpDown.Value;
            quote.desk = desk;
            int quotePrice = quote.calculateQuote();

            StreamWriter writer = new StreamWriter("quotes.txt", true);
            writer.Write(comboBox1.Text + ",");
            writer.Write(quote.Name + ",");
            writer.Write(DateTime.Now.ToString() + ",");
            writer.Write(desk.Width.ToString() + ",");
            writer.Write(desk.Depth.ToString() + ",");
            writer.Write(desk.NumDrawers.ToString() + ",");
            writer.Write(quotePrice.ToString() + "\n");
            writer.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        
    }
}
