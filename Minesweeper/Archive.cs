using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
// Code upload By www.ShareCode.org
namespace Minesweeper
{
    public partial class Archive : UserControl
    {
        public int state;
        public string name = "Anonymous";

        public Archive()
        {
            InitializeComponent();
        }

        private void Archive_Load(object sender, EventArgs e)
        {
            lbTitle.Text = "You have best practice on";
            switch (state)
            {
                case 1:
                    {
                        lbTitle.Text += " beginner";
                        break;
                    }
                case 2:
                    {
                        lbTitle.Text += " intermediate";
                        break;
                    }
                case 3:
                    {
                        lbTitle.Text += " expert";
                        break;
                    }
            }
            lbTitle.Text += " level";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            name=txtName.Text;
        }
    }
}
// Code upload By www.ShareCode.org