using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using FontAwesome.Sharp;
using System;


namespace PresentationA.Controls
{
    public class DataGridPadre : DataGridView
    {
        public DataGridPadre()
        {
            this.EnableHeadersVisualStyles = false;
            
            this.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(242, 103, 34);
            this.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 12, FontStyle.Bold);
            this.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            this.DefaultCellStyle.SelectionBackColor = Color.FromArgb(80, 43, 26);
            this.DefaultCellStyle.SelectionForeColor = Color.White;
            this.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            this.BorderStyle = BorderStyle.FixedSingle;
            this.AllowUserToAddRows = false;
            this.AllowUserToDeleteRows = false;
            this.AllowUserToOrderColumns = true;
            this.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            this.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(242, 103, 34);
            this.Font = new Font("Century Gothic", 12, FontStyle.Regular);
            this.GridColor = Color.FromArgb(242, 103, 34);
            this.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.BackgroundColor = Color.White;
            
        }
        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            if (this.DesignMode) this.Invalidate();
        }
    }
}
