using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class PicSmileControl : UserControl
    {
        public frmMinesweeper boxMines = null;//Hop chua bom
        const int sizeOfSmile = 25;//Size cua mat cuoi

        //Cac trang thai cua mat cuoi
        public int state;//0: binh thuong, 1: Click vao mang EventControl, 2: Thang, -1: mat, -2 onclick


        public PicSmileControl()
        {
            InitializeComponent();
            this.Size = new Size(sizeOfSmile, sizeOfSmile);
        }

        //Dua hinh mat cuoi len o cac trang thai khac nhau
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            switch (state)
            {
                case 0:
                    {
                        g.DrawImage(Properties.Resources.Smile, 0, 0, sizeOfSmile, sizeOfSmile);
                        break;
                    }
                case 1:
                    {
                        g.DrawImage(Properties.Resources.ClickSmile, 0, 0, sizeOfSmile, sizeOfSmile);
                        break;
                    }
                case 2:
                    {
                        g.DrawImage(Properties.Resources.WinnerSmile, 0, 0, sizeOfSmile, sizeOfSmile);
                        break;
                    }
                case -1:
                    {
                        g.DrawImage(Properties.Resources.LoserSmile, 0, 0, sizeOfSmile, sizeOfSmile);
                        break;
                    }
                case -2:
                    {
                        g.DrawImage(Properties.Resources.OnDownSmile, 0, 0, sizeOfSmile, sizeOfSmile);
                        break;
                    }
            }
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                state = -2;
                this.Refresh();
            }
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            if (e.Button == MouseButtons.Left)
            {
                state = 0;
                this.Refresh();
                this.boxMines.New();
            }
        }
    }
}
