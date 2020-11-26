using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp5
{
    
    class TransparentGrid : DataGridView      // class name then ': DataGridView'
    {
        protected override void PaintBackground(Graphics graphics, Rectangle clipBounds, Rectangle gridBounds)
        {
            base.PaintBackground(graphics, clipBounds, gridBounds); Rectangle rectSource =
                new Rectangle(this.Location.X, this.Location.Y, this.Width, this.Height);
            Rectangle rectDest = new Rectangle(0, 0, rectSource.Width, rectSource.Height);
            Bitmap b = new Bitmap(Parent.ClientRectangle.Width, Parent.ClientRectangle.Height);
            Graphics.FromImage(b).DrawImage(this.Parent.BackgroundImage, Parent.ClientRectangle);
            graphics.DrawImage(b, rectDest, rectSource, GraphicsUnit.Pixel);
            SetCellsTransparent();
        }
        public void SetCellsTransparent()
        {
            this.EnableHeadersVisualStyles = true;
            this.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255,Color.Black);
            this.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, Color.Silver);
            this.DefaultCellStyle.BackColor = Color.FromArgb(255, Color.Silver);
            this.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, Color.Silver);
            //foreach (DataGridViewColumn col in this.Columns)
            //{
            //    col.DefaultCellStyle.BackColor = Color.Transparent;
            //    col.DefaultCellStyle.SelectionBackColor = Color.Transparent;
            //}
        }
    }
}
