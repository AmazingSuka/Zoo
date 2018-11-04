using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooPark
{
    class Design
    {
        public void DataGridDesign(params DataGridView[] dataGrids)
        {
            foreach (DataGridView dg in dataGrids)
            {
                dg.BorderStyle = BorderStyle.None;
                dg.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
                dg.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                dg.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
                dg.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
                dg.BackgroundColor = Color.White;
                dg.EnableHeadersVisualStyles = false;
                dg.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                dg.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
                dg.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
        }
    }
}
