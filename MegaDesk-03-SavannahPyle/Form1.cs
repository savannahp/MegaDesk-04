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
    public partial class MainMenu : Form
    {

        

        public MainMenu()
        {
            InitializeComponent();

            //Desk materials;


        

        /* var materials = new List<Desk>DesktopMaterial;
           materials = Enum.GetValues(typeof(Desk.DesktopMaterial))
                .Cast<Desk>DesktopMaterial
                .ToList();
           com DesktopMaterial.DataSource = materials;
           comDesktopMaterial.SelectIndex = -1;

        comboBox1.DataSource = materials;
        */
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AddNewQuote_Click(object sender, EventArgs e)
        {
            AddQuote addNewQuoteForm = new AddQuote();
            addNewQuoteForm.Tag = this;
            addNewQuoteForm.Show(this);
            Hide();
        }

        private void ViewQuotes_Click(object sender, EventArgs e)
        {
            ViewAllQuotes viewAllQuotesForm = new ViewAllQuotes();
            viewAllQuotesForm.Tag = this;
            viewAllQuotesForm.Show(this);
            Hide();
        }

        private void SearchQuotes_Click(object sender, EventArgs e)
        {
            SearchQuotes searchQuotesForm = new SearchQuotes();
            searchQuotesForm.Tag = this;
            searchQuotesForm.Show(this);
            Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
