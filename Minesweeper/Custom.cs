using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace Minesweeper
{
    public partial class Custom : Form
    {
        public frmMinesweeper  mainform = null;
        public int cusHeight = 9;
        public int cusWidth = 9;
        public int mines = 10;
        public Custom()
        {
            InitializeComponent();
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            cusHeight = Convert.ToInt32(this.txtHeight.Text);
            if (cusHeight < 9)cusHeight = 9;
            if (cusHeight > 30) cusHeight = 30;

            cusWidth = Convert.ToInt32(this.txtWidth.Text);
            if (cusWidth < 9 ) cusWidth = 9;
            if (cusWidth > 24) cusWidth = 24;

            mines = Convert.ToInt32(this.txtMines.Text);
            //if (mines > 99) mines = 99;//Download source code tai Sharecode.vn
            if (mines >= (cusHeight * cusWidth)/2) mines = (cusHeight > cusWidth) ? cusHeight*2 : cusWidth*2;
            if (mines < 10) mines = 10;
        }

        private void Custom_Load(object sender, EventArgs e)
        {
            this.txtHeight.Text = mainform.bMines_Height.ToString();
            this.txtWidth.Text = mainform.bMines_Width.ToString();
            this.txtMines.Text = mainform.mines.ToString();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}