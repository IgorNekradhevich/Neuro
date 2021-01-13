using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp61
{
    public partial class Form1 : Form
    {
        Graphics holst;
        HolstArray holstArray = new HolstArray(50);

     
        public Form1()
        {
            InitializeComponent();
            holst = pictureBox1.CreateGraphics();
          
        }
        
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Left)
            {
                holst.FillEllipse(new SolidBrush(Color.Black), e.X, e.Y, 3, 3);

                holstArray.DrawPixel(e.Y, e.X);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            holstArray.ClearArray();
            holst.Clear(Color.White);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < holstArray.N; i++)
            {
                for (int j = 0; j < holstArray.N; j++)
                {
                    richTextBox1.Text += holstArray.arr[i, j].ToString();
                }
                richTextBox1.Text += "\n\r";
            }
        }
    }
}
