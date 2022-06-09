using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS_UI
{
    public partial class SearchBook : Form
    {
        public SearchBook()
        {
            InitializeComponent();
            HidePanels();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void HidePanels()
        {
            pnlByAuthorSubMenu.Visible = false;
            pnlByBookCodeSubMenu.Visible = false;
            pnlByCategorySubMenu.Visible = false;
            pnlByTitleSubMenu.Visible = false;
        }

        private void TogglePanel(Panel panel)
        {
            HidePanels();
            panel.Visible = !panel.Visible;
        }

        private void buttonByTitle_Click(object sender, EventArgs e)
        {
            TogglePanel(pnlByTitleSubMenu);
        }

        private void btnByAuthor_Click(object sender, EventArgs e)
        {
            TogglePanel(pnlByAuthorSubMenu);
        }

        private void btnByCategory_Click(object sender, EventArgs e)
        {
            TogglePanel(pnlByCategorySubMenu);
        }

        private void btnByBookCode_Click(object sender, EventArgs e)
        {
            TogglePanel(pnlByBookCodeSubMenu);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
        }
    }
}