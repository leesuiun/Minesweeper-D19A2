using System;
using System.Collections.Generic;
using System.Text;

namespace Minesweeper
{
    public class State
    {
        int flag = 0;//Tong so min quanh o nay (0-->8); val=-1 co min
        int state = 0;//Danh dau trang thai 0:dong, 1: mo, -1 dat co
        public int FLG { get { return flag; } set { flag = value; } }
        public int STA { get { return state; } set { state = value; } }
    }
}
