using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeCalendar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeButtons();
        }

        private void InitializeButtons()
        {
            /*
            for(int i = 0; i < tableLayoutPanel1.RowCount; i++)
            {
                for(int j = 0; j < tableLayoutPanel1.ColumnCount; j++)
                {
                    tableLayoutPanel1.Controls.Add(new Button(), i, j);
                    Console.WriteLine("{0} {1}", i, j);
                }
            }
             * */
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void doStuffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello!");
        }

        private void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if ((e.Column + e.Row) % 2 == 1)
                e.Graphics.FillRectangle(Brushes.Black, e.CellBounds);
            else
                e.Graphics.FillRectangle(Brushes.White, e.CellBounds);
        }
    }
}
