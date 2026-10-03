using Cosmos.System.Graphics;
using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Cosmos.System.Graphics;
using Sys = Cosmos.System;
using System.Security.Cryptography;
using System.Threading;
using Cosmos.Core.IOGroup;

namespace Cosmosvirtual
{


    class graf
    {
        public static Canvas canvas;
        public static Bitmap bitmap;

        public static void drawWindows(int x, int y)
        {


            Pen pb = new Pen(Color.FromArgb(0, 0, 0));
            Pen pw = new Pen(Color.FromArgb(255, 255, 255));
            Rectangle r = new Rectangle(x, y, 200, 200);
            Rectangle r1 = new Rectangle(x, y, 200, 20);
            canvas.DrawFilledRectangle(pw, x, y, 400, 400);
            canvas.DrawRectangle(pb, x, y, 400, 400);
            canvas.DrawFilledRectangle(pb, x, y, 400, 20);
            canvas.DrawRectangle(pw, x, y, 400, 20);
        }
        public static void movetop(int x, int y)
        {

            drawWindows(x, y);


        }
        public static void starts()
        {


            canvas = FullScreenCanvas.GetFullScreenCanvas();
            Sys.MouseManager.ScreenWidth = (uint)1020;
            Sys.MouseManager.ScreenHeight = (uint)798;



        }
        public static void displays()
        {

            canvas.Display();


        }
        public static void cls(Color c)
        {


            canvas.Clear(c);

        }

    }


    public class Kernel : Sys.Kernel
    {
        static int x = 0; static int y = 0;
        protected override void BeforeRun()
        {
            Console.WriteLine("Cosmos booted successfully. Type a line of text to get it echoed back.");
        }

        protected override void Run()
        {
            while (true)
            {
                graf.starts();
                graf.cls(Color.White);
                tests.mainLoop();
                while (true)
                {
                    Thread.Sleep(200);





                    ;

                }
            }


        }
    }





    class tests



    {


        public static void mainLoop()
        {
            //


            double[] dcos = { 1.0000, 0.9807, 0.9238, 0.8314, 0.7071, 0.5555, 0.3826, 0.1950, 0.0000, -0.195, -0.382, -0.555, -0.707, -0.831, -0.923, -0.980, -1.000, -0.980, -0.923, -0.831, -0.707, -0.555, -0.382, -0.195, -0.000, 0.1950, 0.3826, 0.5555, 0.7071, 0.8314, 0.9238, 0.9807, 1.0000, 0.00 };

            double[] dsin = { 0.0000, 0.1950, 0.3826, 0.5555, 0.7071, 0.8314, 0.9238, 0.9807, 1.0000, 0.9807, 0.9238, 0.8314, 0.7071, 0.5555, 0.3826, 0.1950, 0.0000, -0.195, -0.382, -0.555, -0.707, -0.831, -0.923, -0.980, -1.000, -0.980, -0.923, -0.831, -0.707, -0.555, -0.382, -0.195, 0.0000, 0.00 };
            Pen ppp = new Pen(Color.FromArgb(0, 0, 0));

            for (int a = 0; a < 32; a++) graf.canvas.DrawLine(ppp,(int)(dsin[a] * 150.00) + 250, (int)(dcos[a] * 150.00) + 250,(int)(dsin[a + 1] * 150.00) + 250, (int)(dcos[a + 1] * 150.00) + 250);

            graf.displays();
        }

    }





}
