﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCAD
{
    public class Vector3
    {
        private double x,y,z;
        public double X
        {
            get { return x; }
            set { x = value; }
        }
        public double Y
        {
            get { return y; }
            set { y = value; }
        }
        public double Z
        {
            get { return z; }
            set { z = value; }
        }
        public Vector3(double x, double y)
        {
            this.X = x;
            this.Y = y;
            this.Z = 0.0;
        }
        public Vector3(double x, double y, double z):this(x,y)
        {
            this.Z =  z;
        }
        public static Vector3 Zero
        {
            get
            {
                return new Vector3(0.0,0.0,0.0);
            }
        }
        public System.Drawing.PointF ToPointF
        {
            get
            {
                return new System.Drawing.PointF((float)X, (float)Y);
            }
        }
    }
}
