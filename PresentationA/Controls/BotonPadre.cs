using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using FontAwesome.Sharp;
using System;


namespace PresentationA.Controls
{
    public class BotonPadre : IconButton
    {
        //Fields
        private int borderSize = 1;
        private int borderRadius = 40;
        private Color borderColor = Color.FromArgb(250, 166, 26);

        //Constructor
        public BotonPadre()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize  = 0;
            this.Size = new Size(150, 40);
            this.ImageAlign = ContentAlignment.MiddleLeft;
            this.TextAlign = ContentAlignment.MiddleCenter;
            this.TextImageRelation = TextImageRelation.Overlay;
            this.Font = new System.Drawing.Font("Century Gothic", 12, FontStyle.Bold);
            this.ForeColor = Color.White;
            this.BackColor = Color.FromArgb(250, 166, 26);
        }
        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width-radius, rect.Height-radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }
        
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            RectangleF rectSurface = new RectangleF(0,0, this.Width,this.Height);
            RectangleF rectBorder = new RectangleF(0, 0, this.Width - 0.8F, this.Height-1);
            using (GraphicsPath pathSurface = GetFigurePath(rectSurface,borderRadius))
            using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius-1f))
            using(Pen penSurface = new Pen(this.Parent.BackColor,2))
            using (Pen penBorder = new Pen(borderColor, 2))
            {
                penBorder.Alignment = PenAlignment.Inset;
                this.Region = new Region(pathSurface);
                pevent.Graphics.DrawPath(penSurface, pathSurface);
                pevent.Graphics.DrawPath(penBorder, pathBorder);
            }
            
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
            
        }
        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            if (this.DesignMode) this.Invalidate();
            
        }
    }
}
