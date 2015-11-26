///Made by Anjali Ukrani
/// On November 26, 2015
/// Draw Star Program
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawStar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Draw star in different size and place 
        /// </summary>
        /// <param name="x"> x-position of star</param>
        /// <param name="y">y-position of star</param>
        /// <param name="size">size of star</param>
        private void DrawStar(float x, float y, float size)
        {
            Pen yellowPen = new Pen(Color.LightGoldenrodYellow); //tool to create lines
            Graphics formGraphics = this.CreateGraphics();       //to make lines
           
         
            formGraphics.Clear(Color.Black);
            formGraphics.DrawLine(yellowPen, (1 + x) * (size/208), (84 + y) * (size / 195), (84 + x) * (size/208), (84 + y) * (size / 195));
            formGraphics.DrawLine(yellowPen, (84 + x) * (size / 208), (84 + y) * (size/195), (104 + x) * (size / 208), (9 + y) * (size / 195));
            formGraphics.DrawLine(yellowPen, (104 + x) * (size / 208), (9 + y) * (size / 195), (129 + x) * (size / 208), (84 + y) * (size / 195));
            formGraphics.DrawLine(yellowPen, (129 + x) * (size / 208), (84 + y) * (size / 195), (209 + x) * (size / 208), (83 + y) * (size / 195));
            formGraphics.DrawLine(yellowPen, (209 + x) * (size / 208), (83 + y) * (size / 195), (143 + x) * (size / 208), (130 + y) * (size / 195));
            formGraphics.DrawLine(yellowPen, (143 + x) * (size / 208), (130 + y) * (size / 195), (168 + x) * (size / 208), (204 + y) * (size / 195));
            formGraphics.DrawLine(yellowPen, (168 + x) * (size / 208), (204 + y) * (size / 195), (104 + x) * (size / 208), (159 + y) * (size / 195));
            formGraphics.DrawLine(yellowPen, (104 + x) * (size / 208), (159 + y) * (size / 195), (42 + x) * (size / 208), (204 + y) * (size / 195));
            formGraphics.DrawLine(yellowPen, (42 + x) * (size / 208), (204 + y) * (size / 195), (66 + x) * (size / 208), (130 + y) * (size / 195));
            formGraphics.DrawLine(yellowPen, (66 + x) * (size / 208), (130 + y) * (size / 195), (1 + x) * (size / 208), (84 + y) * (size / 195));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            Graphics formGraphics = this.CreateGraphics();
            float x = Convert.ToSingle(xInput.Text);              //holds x value inputed by user
            float y = Convert.ToSingle(yInput.Text);              //holds y value inputed by user
            float size = Convert.ToSingle(sizeInput.Text);        // holds inputed size value
            Pen yellowPen = new Pen(Color.LightGoldenrodYellow);  //Tool to create star


            //go to method: DrawStar
            DrawStar(x, y, size);

        }
    }
}
