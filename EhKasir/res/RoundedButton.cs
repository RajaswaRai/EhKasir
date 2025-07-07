using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class RoundedButton : Button
{
    public int BorderRadius { get; set; } = 20;
    public Color BackgroundColor { get; set; } = Color.MediumSlateBlue;
    public Color BorderColor { get; set; } = Color.Purple;
    public int BorderSize { get; set; } = 2;

    public RoundedButton()
    {
        this.FlatStyle = FlatStyle.Flat;
        this.FlatAppearance.BorderSize = 0;
        this.BackColor = BackgroundColor;
        this.ForeColor = Color.White;
    }

    protected override void OnPaint(PaintEventArgs pevent)
    {
        base.OnPaint(pevent);
        Graphics g = pevent.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;

        Rectangle rectSurface = this.ClientRectangle;
        Rectangle rectBorder = Rectangle.Inflate(rectSurface, -BorderSize, -BorderSize);

        using (GraphicsPath pathSurface = GetFigurePath(rectSurface, BorderRadius))
        using (GraphicsPath pathBorder = GetFigurePath(rectBorder, BorderRadius - BorderSize))
        using (Pen penBorder = new Pen(BorderColor, BorderSize))
        {
            this.Region = new Region(pathSurface);
            if (BorderSize > 0)
                g.DrawPath(penBorder, pathBorder);
        }
    }

    private GraphicsPath GetFigurePath(Rectangle rect, int radius)
    {
        GraphicsPath path = new GraphicsPath();
        float curveSize = radius * 2F;
        path.StartFigure();
        path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
        path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
        path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
        path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
        path.CloseFigure();
        return path;
    }
}
