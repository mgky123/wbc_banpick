using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WBCtest
{
    public partial class Form2 : Form
    {
        Form1 frm1;
        public Form2()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TransparencyKey = Color.Turquoise;
            this.BackColor = Color.Turquoise;
            this.TopMost = true;
        }
        public Form2(Form1 _form) {
            InitializeComponent();
            frm1 = _form;
            this.FormBorderStyle = FormBorderStyle.None;
            this.TransparencyKey = Color.Turquoise;
            this.BackColor = Color.Turquoise;
            this.button1.BackgroundImage = frm1.pictureBox1.Image;
            this.button2.BackgroundImage = frm1.pictureBox2.Image;
            this.button3.BackgroundImage = frm1.pictureBox3.Image;
            this.button4.BackgroundImage = frm1.pictureBox4.Image;
            this.button5.BackgroundImage = frm1.pictureBox5.Image;
            this.button8.BackgroundImage = frm1.pictureBox6.Image;
            this.button7.BackgroundImage = frm1.pictureBox7.Image;
            this.button10.BackgroundImage = frm1.pictureBox8.Image;
            this.button9.BackgroundImage = frm1.pictureBox9.Image;
            this.TopMost = true;
        }
        
        
        private Point mCurrentPosition = new Point(0, 0); //

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
                mCurrentPosition = new Point(-e.X, -e.Y);

        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(
                    this.Location.X + (mCurrentPosition.X + e.X),
                    this.Location.Y + (mCurrentPosition.Y + e.Y));// 마우스의 이동치를 Form Location에 반영한다.
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Image == null)
            {
                button4.Image = global::WBCtest.Properties.Resources.die;
            }
            else
            {
                button4.Image = null;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Image == null)
            {
                button5.Image = global::WBCtest.Properties.Resources.die;
            }
            else
            {
                button5.Image = null;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Image == null)
            {
                button8.Image = global::WBCtest.Properties.Resources.die;
            }
            else
            {
                button8.Image = null;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Image == null)
            {
                button7.Image = global::WBCtest.Properties.Resources.die;
            }
            else
            {
                button7.Image = null;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button10.Image == null)
            {
                button10.Image = global::WBCtest.Properties.Resources.die;
            }
            else
            {
                button10.Image = null;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Image == null)
            {
                button9.Image = global::WBCtest.Properties.Resources.die;
            }
            else
            {
                button9.Image = null;
            }
        }
       
    }
}
