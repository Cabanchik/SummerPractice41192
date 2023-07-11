using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace SummerPractice4119
{
    public partial class Form1 : Form
    {
        Circle circle;
        Circle circle1;
        Circle circle2;
        Rectangle sas;
        public static Timer timer;
        Circle circle3;
        bool started = false;
        Graphics g;
        public delegate void ListHandler();
        public delegate void Stoppin();
        public static event Stoppin rectStop;
        public static event ListHandler sasun;
        public Form1()
        {
            InitializeComponent();
            g = panelMain.CreateGraphics();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (!started)
            {

                sas = new Rectangle(250, 70, g);
                sas.Moving = true;
                started = true;
                timer = new Timer();
                timer.Interval = 25;
                //sas.rectangleStop += circleRun;
                timer.Tick += sas.MoveTimerEventX;
                timer.Start();
                sas.rectangleStop += circle.StartOrder;
                //sas.rectangleStop += circle1.StartOrder;
                //sas.rectangleStop += circle2.StartOrder;
                //sas.rectangleStop += circle3.StartOrder;
            }
        }
        public void circleRun()
        {
            //timer.Tick -= sas.MoveTimerEventX;
            //timer.Stop();
            ////circle.StartOrder();
            //circle1.StartOrder();
            //circle2.StartOrder();
            //circle3.StartOrder();
        }
        

        private void panelMain_Click(object sender, EventArgs e)
        {
            circle = new Circle(600, 100, 20, panelMain.CreateGraphics(),1);
            //circle1 = new Circle(500, 250, 20, panelMain.CreateGraphics(),1);
            //circle2 = new Circle(200, 50, 20, panelMain.CreateGraphics(),-1);
            //circle3 = new Circle(20, 250, 20, panelMain.CreateGraphics(),-1);
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {
            if (started)
            {
                circle.Show(e.Graphics);
            }
        }
    }
}
