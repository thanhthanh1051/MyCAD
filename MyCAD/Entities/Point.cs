using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCAD.Entities
{
    public class Point
    {
        private Vector3 position;
        private double thinkness;

        public Point()
        {
            this.Position = Vector3.Zero;
            this.thinkness = 0.0 ;
        }
        public Point(Vector3 position)
        {
            this.Position = position;
        }
        public double Thinckness
        {
            get
            {
                return thinkness;
            }
            set
            {
                thinkness = value;
            }
        }
        public Vector3 Position
        {
            get
            {
                return position;
            }
            set
            {
                position = value;
            }
        }
    }
}
