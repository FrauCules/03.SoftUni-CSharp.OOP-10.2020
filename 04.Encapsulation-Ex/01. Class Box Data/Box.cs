﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace _01._Class_Box_Data
{
    public class Box
    {
        private double length;
        private double width;
        private double height;
        
        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length 
        {
            get
            {
                return this.length;
            }
            private set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }

                this.length = value;
            } 
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }

                this.width = value;
            }
        }
        public double Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }

                this.height = value;
            }
        }

        public double SurfaceArea()
        {
            // 2lw + 2lh + 2wh
            return 2*(length * height + length * width + width * height);
        }

        public double LateralSurfaceArea()
        {
            // 2lh + 2wh
            return 2 * (length * height + width * height);
        }

        public double Volume()
        {
            // lwh
            return length * width * height;
        }
    }
}
