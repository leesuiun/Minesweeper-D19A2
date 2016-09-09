using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Minesweeper
{
    public partial class NameArchive : Form
    {
        public int state;
        public string name ;

        public NameArchive()
        {
            InitializeComponent();
        }

        private void NameArchive_Load(object sender, EventArgs e)
        {
            lbTitle.Text = "You have best practice on\n";
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
            lbTitle.Text += "\nPlease enter your name.";
            lbTitle.Left = (this.Width - lbTitle.Width) / 2;
            txtName.Text = "Anonymous";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.name = this.txtName.Text;
            BestTime bst = new BestTime();
            bst.Show();
            this.Close();
            
        }
    }
}