using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCAD
{
    public partial class GraphicsForm : Form
    {
        public GraphicsForm()
        {
            InitializeComponent();
        }
        private PointF currentPosition;
        private void drawing_MouseMove(object sender, MouseEventArgs e)
        {
            currentPosition = PointToCartesian(e.Location);
            label1.Text = string.Format("{0}, {1}", e.Location.X, e.Location.Y);
            label2.Text = string.Format("{0,0:F3}, {1,0:F3}", currentPosition.X, currentPosition.Y);
        }

        //Convert system point to world point
        private PointF PointToCartesian(Point point)
        {
            return new PointF(Pixel_to_Mn(point.X), Pixel_to_Mn(drawing.Height - point.Y));
        }

        //Get screen dpi
        private float DPI
        {
            get
            {
                using(var g = CreateGraphics())
                {
                    return g.DpiX;
                }
            }
        }
        //Convert pixels to millimeters
        private float Pixel_to_Mn(float pixel)
        {
            return pixel * 25.4f / DPI;
        }
    }
}
