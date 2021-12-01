using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c_sharp_Tic_Tac_Toe
{
    public partial class Setup_form : Form
    {
        public Setup_form()
        {
            InitializeComponent();
        }
        
        //background colors of character setup
        private void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if (e.Row == e.Column)
                using (SolidBrush brush = new SolidBrush(Color.LightBlue))
                    e.Graphics.FillRectangle(brush, e.CellBounds);
            else
                using (SolidBrush brush = new SolidBrush(Color.IndianRed))
                    e.Graphics.FillRectangle(brush, e.CellBounds);
        }
    }
}
