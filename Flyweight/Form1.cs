using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flyweight
{
    public partial class Form1 : Form
    {
        Flyweight images;

        public Form1()
        {
            InitializeComponent();

            images = new Flyweight();
            Random rnd = new Random();

            pictureBox1.Image = images.GetImage((Pictures)rnd.Next(0, 4));
            pictureBox2.Image = images.GetImage((Pictures)rnd.Next(0, 4));
            pictureBox3.Image = images.GetImage((Pictures)rnd.Next(0, 4));
            pictureBox4.Image = images.GetImage((Pictures)rnd.Next(0, 4));
            pictureBox5.Image = images.GetImage((Pictures)rnd.Next(0, 4));
            pictureBox6.Image = images.GetImage((Pictures)rnd.Next(0, 4));
            pictureBox7.Image = images.GetImage((Pictures)rnd.Next(0, 4));
            pictureBox8.Image = images.GetImage((Pictures)rnd.Next(0, 4));
            pictureBox9.Image = images.GetImage((Pictures)rnd.Next(0, 4));
        }
    }
}
