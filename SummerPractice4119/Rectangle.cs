using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Threading;

namespace SummerPractice4119 
{
    internal class Rectangle 
    {
        private Graphics panel;
        private int width;
        private Dot centre;
        private int height;
        private System.Windows.Forms.Timer moveTimer;
        private bool moving = false;
        public delegate void Runnin();
        public event Runnin rectangleRun;
        public delegate void Stoppin();
        public event Stoppin rectangleStop;
        Thread moveThread;

        public bool Moving { get => moving; set => moving = value; }

        public void rectangleInvokeEvent()
        {
            rectangleRun.Invoke();
        }
        
        public Rectangle(int _x, int _y, Graphics _panel)
        {
            centre = new Dot(_x, _y);
            this.panel = _panel;
            width = 100;
            height = 50;
            moveTimer = new System.Windows.Forms.Timer();
            moveTimer.Interval = 20;
            Show(panel);
        }

        public void RectangleMovingStop()
        {
            Moving = false;
        }
        public void Move(int dx, int dy)
        {
            if (moving == true)
            {
                if (getRectangleX() <= 330 || getRectangleY() <= 170)
                {
                    ////Clear();
                    centre.Move(dx, dy);
                    //Show();
                }
                else
                {
                    rectangleStop.Invoke();
                }
            }
        }
        public void Clear()
        {
            SolidBrush b = new SolidBrush(Color.White);
            panel.FillRectangle(b, centre.GetX(), centre.GetY(), width, height);
        }
        public void Show(Graphics g)
        {
            SolidBrush b = new SolidBrush(Color.Black);
            panel.FillRectangle(b, centre.GetX(), centre.GetY(), width, height);
        }
        public int getRectangleX()
        {
            return centre.GetX();
        }

        public int getRectangleY()
        {
            return centre.GetY();
        }
        public void MoveTimerEventX(Object myObject, EventArgs myEventArgs)
        {
                Move(1, 1);
        }



    }

 
}
