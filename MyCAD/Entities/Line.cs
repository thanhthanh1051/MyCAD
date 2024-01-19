using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCAD.Entities
{
    public class Line
    {
        private Vector3 startPoint;
        private Vector3 endPoint;
        private double thichness;
        public Line(Vector3 startPoint, Vector3 endPoint)
        {
            this.StartPoint = startPoint;
            this.EndPoint = endPoint;
            this.Thickness = 0.0;
        }
        public Line() : this(Vector3.Zero, Vector3.Zero)
        {

        }
        public double Thickness
        {
            get { return thichness; }
            set { thichness = value; }
        }
        public Vector3 StartPoint
        {
            get { return startPoint; }
            set { startPoint = value; }
        }
        public Vector3 EndPoint
        {
            get { return endPoint; }
            set { endPoint = value; }
        }
    }
}
