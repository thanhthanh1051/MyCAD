using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCAD
{
    public static class GraphicsExtension
    {
        private static float Height;
        public static void SetParameters(this System.Drawing.Graphics graphics, float height)
        {
            Height = height;
        }
        public static void SetTransform(this System.Drawing.Graphics graphics)
        {
            graphics.PageUnit = System.Drawing.GraphicsUnit.Millimeter;
            graphics.TranslateTransform(0, Height);
            graphics.ScaleTransform(1.0f, -1.0f );
        }
        public static void DrawPoint(this System.Drawing.Graphics graphics, System.Drawing.Pen pen, Entities.Point point)
        {
            graphics.SetTransform();
            System.Drawing.PointF p = point.Position.ToPointF;
            graphics.DrawEllipse(pen, p.X-1, p.Y-1, 2, 2);
            graphics.ResetTransform();
        }
        public static void DrawLine(this System.Drawing.Graphics graphics, System.Drawing.Pen pen, Entities.Line line)
        {
            graphics.SetTransform();
            graphics.DrawLine(pen, line.StartPoint.ToPointF, line.EndPoint.ToPointF);
            graphics.ResetTransform();
        }
        public static void DrawCircle(this System.Drawing.Graphics graphics, System.Drawing.Pen pen, Entities.Circle circle)
        {
            float x = (float)(circle.Center.X - circle.Radius);
            float y = (float)(circle.Center.Y - circle.Radius);
            float d = (float)circle.Diameter;
            graphics.SetTransform();
            graphics.DrawEllipse(pen, x, y, d, d);
            graphics.ResetTransform();
        }
        public static void DrawEllipse(this System.Drawing.Graphics graphics, System.Drawing.Pen pen, Entities.Ellipse ellipse)
        {
            SetTransform(graphics);
            graphics.TranslateTransform(ellipse.Center.ToPointF.X, ellipse.Center.ToPointF.Y);
            graphics.RotateTransform((float)ellipse.Rotation);
            graphics.DrawEllipse(pen, -(float)ellipse.MajorAxis, -(float)ellipse.MinorAxis,(float)ellipse.MajorAxis*2, (float)ellipse.MinorAxis * 2);
            graphics.ResetTransform();
        }
    }
}
