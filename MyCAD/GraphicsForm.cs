﻿using MyCAD.Methods;
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
        ContextMenuStrip contextMenuStrip1;
        ToolStripMenuItem cancelMenuItem;
        private void InitializeContextMenu()
        {
            // Khởi tạo ContextMenuStrip
            contextMenuStrip1 = new ContextMenuStrip();

            // Khởi tạo MenuItem "Cancel"
            cancelMenuItem = new ToolStripMenuItem("Cancel");
            cancelMenuItem.Click += cancelToolStripMenuItem_Click;

            // Thêm MenuItem "Cancel" vào ContextMenuStrip
            contextMenuStrip1.Items.Add(cancelMenuItem);
        }
        public GraphicsForm()
        {
            InitializeComponent();
        }
        private LinkedList<Entities.Point> points = new LinkedList<Entities.Point>();
        private LinkedList<Entities.Line> lines = new LinkedList<Entities.Line>();
        private LinkedList<Entities.Circle> circles = new LinkedList<Entities.Circle>();
        private LinkedList<Entities.Ellipse> ellipses = new LinkedList<Entities.Ellipse>();
        private Vector3 currentPosition;
        private Vector3 firstPoint;
        private Vector3 secondPoint;
        private int ClickNum = 1;
        private int DrawIndex = -1;
        private bool active_drawing = false;
        private void drawing_MouseMove(object sender, MouseEventArgs e)
        {
            currentPosition = PointToCartesian(e.Location);
            label1.Text = string.Format("{0}, {1}", e.Location.X, e.Location.Y);
            label2.Text = string.Format("{0,0:F3}, {1,0:F3}", currentPosition.X, currentPosition.Y);
            drawing.Refresh();
        }

        //Convert system point to world point
        private Vector3 PointToCartesian(Point point)
        {
            return new Vector3(Pixel_to_Mn(point.X), Pixel_to_Mn(drawing.Height - point.Y));
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

        private void drawing_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                if(active_drawing)
                {
                    switch(DrawIndex)
                    {
                        case 0:
                            points.AddLast(new Entities.Point(currentPosition));
                            break;
                        case 1://line
                            switch (ClickNum)
                            {
                                case 1:   
                                    firstPoint = currentPosition;
                                    points.AddLast(new Entities.Point(currentPosition));
                                    ClickNum++;
                                    break;
                                case 2:
                                    lines.AddLast(new Entities.Line(firstPoint, currentPosition));
                                    points.AddLast(new Entities.Point(currentPosition));
                                    firstPoint = currentPosition;
                                    break;
                            }
                            break;
                        case 2://circle
                            switch (ClickNum)
                            {
                                case 1:
                                    firstPoint = currentPosition;
                                    points.AddLast(new Entities.Point(currentPosition));
                                    ClickNum++;
                                    break;
                                case 2:
                                    double r = firstPoint.DistanceFrom(currentPosition);
                                    circles.AddLast(new Entities.Circle(firstPoint, r));
                                    points.AddLast(new Entities.Point(currentPosition));
                                    ClickNum = 1;
                                    break;
                            }
                            break;
                        case 3://Ellipes
                            switch (ClickNum)
                            {
                                case 1:
                                    firstPoint = currentPosition;
                                    ClickNum++;
                                    break;
                                case 2:
                                    secondPoint = currentPosition;
                                    ClickNum++;
                                    break;
                                case 3:
                                    Entities.Ellipse ellipse = Method.GetEllipse(firstPoint, secondPoint,currentPosition);
                                    ellipses.AddLast(ellipse);
                                    ClickNum = 1;
                                    active_drawing = false;
                                    drawing.Cursor = Cursors.Default;
                                    break;
                            }
                            break;
                    }
                    drawing.Refresh();
                }
            }
            if (e.Button == MouseButtons.Right)
            {
                // Hiển thị ContextMenuStrip tại vị trí của chuột
                contextMenuStrip1.Show(this, e.Location);
            }
        }

        private void drawing_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SetParameters(Pixel_to_Mn(drawing.Height));
            Pen pen = new Pen(Color.Blue, 1.0f);
            Pen extpen = new Pen(Color.Gray, 1.0f);
            //Draw all points
            if(points.Count > 0)
            {
                foreach(Entities.Point p in points)
                {
                    e.Graphics.DrawPoint(new Pen(Color.Red, 0), p);
                }
            }
            //Draw all lines
            if(lines.Count > 0)
            {
                foreach(Entities.Line line in lines)
                {
                    e.Graphics.DrawLine(pen, line);
                }     
            }
            if(circles.Count > 0)
            {
                foreach(Entities.Circle circle in circles)
                {
                    e.Graphics.DrawCircle(pen, circle);
                }
            }
            //Draw all ellipse
            if (ellipses.Count > 0)
            {
                foreach (Entities.Ellipse elp in ellipses)
                {
                    e.Graphics.DrawEllipse(pen, elp);
                }
            }
            //Draw line extended
            switch (DrawIndex)
            {
                case 1:
                    if(ClickNum == 2)
                    {
                        Entities.Line line = new Entities.Line(firstPoint, currentPosition);
                        e.Graphics.DrawLine(extpen, line);
                    }
                    break;
                case 2:
                    if(ClickNum == 2)
                    {
                        Entities.Line line = new Entities.Line(firstPoint, currentPosition);
                        e.Graphics.DrawLine(extpen, line);
                        double r = firstPoint.DistanceFrom(currentPosition);
                        Entities.Circle circle = new Entities.Circle(firstPoint, r);
                        e.Graphics.DrawCircle(extpen, circle);
                    }
                    break;
                case 3:
                    switch (ClickNum) {
                        case 2:
                            Entities.Line line = new Entities.Line(firstPoint, currentPosition);
                            e.Graphics.DrawLine(extpen, line);
                            break;
                        case 3:
                            Entities.Line line1 = new Entities.Line(firstPoint, currentPosition);
                            e.Graphics.DrawLine(extpen, line1);
                            Entities.Ellipse elp = Method.GetEllipse(firstPoint, secondPoint, currentPosition);
                            e.Graphics.DrawEllipse(extpen, elp);
                            break;
                    }
                    break;
            }
            //Test line line intersection
            if (lines.Count > 0)
            {
                foreach (Entities.Line l1 in lines)
                {
                    foreach (Entities.Line l2 in lines)
                    {
                        Vector3 v = Methods.Method.LineLineIntersection(l1, l2,true);
                        Entities.Point p = new Entities.Point(v);
                        e.Graphics.DrawPoint(new Pen(Color.Red, 0), p);
                    }
                }
            }
        }

        private void pointBtn_Click(object sender, EventArgs e)
        {
            DrawIndex = 0;
            active_drawing = true;
            drawing.Cursor = Cursors.Cross;
        }

        private void lineBtn_Click(object sender, EventArgs e)
        {
            DrawIndex = 1;
            active_drawing = true;
            drawing.Cursor = Cursors.Cross;
        }

        private void circleBtn_Click(object sender, EventArgs e)
        {
            DrawIndex = 2;
            active_drawing = true;
            drawing.Cursor = Cursors.Cross;
        }

        private void ellipseBtn_Click(object sender, EventArgs e)
        {
            DrawIndex = 3;
            active_drawing = true;
            drawing.Cursor = Cursors.Cross;
        }
        private void CancelAll()
        {
            DrawIndex = -1;
            active_drawing = false;
            drawing.Cursor = Cursors.Default;
            ClickNum = 1;
        }
        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CancelAll();
        }

        private void GraphicsForm_Load(object sender, EventArgs e)
        {
            InitializeContextMenu();
            this.ContextMenuStrip = contextMenuStrip1;
        }
    }
}
