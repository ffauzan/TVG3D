using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;


namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        bool loaded = false;
        int beginX, beginY, beginZ, endX, endY, endZ;
        Vector3 Begin, End, p, q, r, s, q2, r2, s2, p2;
        float angle = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void updateRotLine()
        {
            beginX = Convert.ToInt32(BeginX.Text);
            beginY = Convert.ToInt32(BeginY.Text);
            beginZ = Convert.ToInt32(BeginZ.Text);

            endX = Convert.ToInt32(EndX.Text);
            endY = Convert.ToInt32(EndY.Text);
            endZ = Convert.ToInt32(EndZ.Text);

            p = new Vector3(50, 30, -5);
            q = new Vector3(55, 25, -10);
            r = new Vector3(55, 25, 0);
            s = new Vector3(45, 25, -5);

            Begin = new Vector3(beginX, beginY, beginZ);
            End = new Vector3(endX, endY, endZ);
        }

       

        private Vector3 RotasiY(Vector3 titik, double sudut)
        {
            double cosx = Math.Cos(sudut);              
            double sinx = Math.Sin(sudut);

            double newx = (titik.X * cosx) - (titik.Z * sinx);
            double newz = (titik.X * sinx) + (titik.Z * cosx);

            titik.X = (float)newx;
            titik.Z = (float)newz;
            return titik;
        }

        private Vector3 RotasiX(Vector3 titik, double sudut)
        {
            double cosx = Math.Cos(sudut);              //rotasi terhadap sumbu X
            double sinx = Math.Sin(sudut);

            double newz = (titik.Z * cosx) - (titik.Y * sinx);
            double newy = (titik.Z * sinx) + (titik.Y * cosx);

            titik.Z = (float)newz;
            titik.Y = (float)newy;
            return titik;
        }

        private Vector3 RotasiZ(Vector3 titik, double sudut)
        {
            double cosx = Math.Cos(sudut);              //rotasi terhadap sumbu Z
            double sinx = Math.Sin(sudut);

            double newx = (titik.X * cosx) - (titik.Y * sinx);
            double newy = (titik.X * sinx) + (titik.Y * cosx);

            titik.X = (float)newx;
            titik.Y = (float)newy;
            return titik;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            angle -= 5;
            glControl1.Invalidate();
            label4.Text = angle.ToString();
        }

        private Vector3 rotasi(float sudutt, Vector3 point)
        {
            
            point -= End;
            Vector3 AB = End - Begin;


            double sudut1 = Math.Atan(AB.Y / AB.Z);

            AB = RotasiX(AB, sudut1);


            point = RotasiX(point, sudut1);


            double sudut2 = Math.Atan(AB.X / AB.Z);

            point = RotasiY(point, sudut2);


            double sudut3 = (Math.PI / 180) * sudutt;

            point = RotasiZ(point, -sudut3);


            point = RotasiY(point, -sudut2);

            point = RotasiX(point, -sudut1);

            point += End;                  

            return point;

        }


        private void DrawRotLine(Vector3 begin, Vector3 end)
        {
            GL.Begin(PrimitiveType.Lines);
            GL.Color3(Color.Brown);
            GL.Vertex3(begin);
            GL.Vertex3(end);
            GL.End();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            angle += 5;
            glControl1.Invalidate();
            label4.Text = angle.ToString();
        }

       

        private void drawObject2()
        {
            
            GL.Begin(PrimitiveType.LineLoop);
            GL.Color3(Color.DarkOrchid);
            GL.Vertex3(p2);
            GL.Vertex3(q2);
            GL.Vertex3(r2);
            GL.Vertex3(s2);
            GL.Vertex3(p2);
            GL.Vertex3(r2);
            GL.Vertex3(q2);
            GL.Vertex3(s2);
            GL.End();
            
        }

        private void glControl1_Paint(object sender, PaintEventArgs e)
        {
            if (!loaded) // Play nice
                return;

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
            

            SetupCoordinate();

            DrawRotLine(Begin, End);

            p2 = rotasi(angle, p);
            q2 = rotasi(angle, q);
            r2 = rotasi(angle, r);
            s2 = rotasi(angle, s);

            drawObject2();

            glControl1.SwapBuffers();
        }

        private void EndY_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            updateRotLine();
            glControl1.Invalidate();
        }

        private void SetupCoordinate()
        {
            GL.Rotate(-30.0, 1, 0, 0);
            GL.Rotate(135.0, 0, 1, 0);
            GL.Scale(0.01, 0.01, 0.01);
            GL.Translate(0, -20, 0);


            GL.Begin(PrimitiveType.Lines);
            GL.Color3(Color.Red);
            GL.Vertex3(0, 0, 0);
            GL.Vertex3(100, 0, 0);
            GL.End();

            GL.Begin(PrimitiveType.Lines);
            GL.Color3(Color.Green);
            GL.Vertex3(0, 0, 0);
            GL.Vertex3(0, 100, 0);
            GL.End();

            GL.Begin(PrimitiveType.Lines);
            GL.Color3(Color.Blue);
            GL.Vertex3(0, 0, 0);
            GL.Vertex3(0, 0, 100);
            GL.End();
        }

       

        private void SetupViewport()
        {
            int w = glControl1.Width;
            int h = glControl1.Height;
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(0, w, 0, h, -100, 100); // Bottom-left corner pixel has coordinate (0, 0)
            GL.Viewport(0, 0, w, h); // Use all of the glControl painting area
        }

        private void glControl1_Load(object sender, EventArgs e)
        {
            loaded = true;
            GL.ClearColor(Color.SkyBlue);
            //SetupViewport();
            
            

            GL.Rotate(-30.0, 1, 0, 0);
            GL.Rotate(135.0, 0, 1, 0);
        }

        private void glControl1_Resize(object sender, EventArgs e)
        {
            if (!loaded)
                return;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BeginX.Text = "10";
            BeginY.Text = "20";
            BeginZ.Text = "5";

            EndX.Text = "15";
            EndY.Text = "40";
            EndZ.Text = "0";
           

        }
    }
}
