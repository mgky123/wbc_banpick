using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WBCtest.Properties;

namespace WBCtest
{
    public partial class Form1 : Form
    {
        private Control _last=null;
        private Button _btn = null;
        private int banban = 0;
        private int selectBan = 1;

        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (banban == 0)
            {


                if (selectBan == 0)
                {
                    if (_last == null)
                    {
                        MessageBox.Show("밴 할 케릭터를 선택해주세요.");
                    }
                    else
                    {
                        _last.Focus();

                        if (this.pictureBox1.Image == null)
                        {
                            this.pictureBox1.Image = _last.BackgroundImage;
                            _btn = (Button)this.ActiveControl;
                            _btn.Image = global::WBCtest.Properties.Resources.black4;
                        }
                        else
                        {
                            if (this.pictureBox2.Image == null)
                            {
                                if (this.pictureBox1.Image == _last.BackgroundImage)
                                {
                                    MessageBox.Show("이미 밴된 케릭터 입니다.");
                                }
                                else
                                {
                                    this.pictureBox2.Image = _last.BackgroundImage;
                                    _btn = (Button)this.ActiveControl;
                                    _btn.Image = global::WBCtest.Properties.Resources.black4;
                                }
                            }
                            else
                            {
                                if (this.pictureBox3.Image == null)
                                {
                                    if (this.pictureBox1.Image == _last.BackgroundImage || this.pictureBox2.Image == _last.BackgroundImage)
                                    {
                                        MessageBox.Show("이미 밴된 케릭터 입니다.");
                                    }
                                    else
                                    {
                                        this.pictureBox3.Image = _last.BackgroundImage;
                                        _btn = (Button)this.ActiveControl;
                                        _btn.Image = global::WBCtest.Properties.Resources.black4;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("밴이 완료되었습니다.");
                                }
                            }
                        }
                    }
                }
                else
                { //1밴2픽
                    if (_last == null)
                    {
                        MessageBox.Show("밴 할 케릭터를 선택해주세요.");
                    }
                    else
                    {
                        _last.Focus();

                        if (this.pictureBox1.Image == null)
                        {
                            this.pictureBox1.Image = _last.BackgroundImage;
                            _btn = (Button)this.ActiveControl;
                            _btn.Image = global::WBCtest.Properties.Resources.black4;
                        }
                        else
                        {
                            if (this.pictureBox2.Image == null)
                            {
                                if (this.pictureBox4.Image == null || this.pictureBox5.Image == null)
                                {
                                    MessageBox.Show("픽을 먼저 해주세요.");
                                }
                                else if (this.pictureBox4.Image == _last.BackgroundImage || this.pictureBox5.Image == _last.BackgroundImage)
                                {
                                    MessageBox.Show("이미 픽된 케릭터입니다.");
                                }
                                else if (this.pictureBox1.Image == _last.BackgroundImage)
                                {
                                    MessageBox.Show("이미 밴된 케릭터입니다.");
                                }
                                else
                                {
                                    this.pictureBox2.Image = _last.BackgroundImage;
                                    _btn = (Button)this.ActiveControl;
                                    _btn.Image = global::WBCtest.Properties.Resources.black4;
                                }
                            }
                            else
                            {
                                if (this.pictureBox3.Image == null)
                                {
                                    if (this.pictureBox6.Image == null || this.pictureBox7.Image == null)
                                    {
                                        MessageBox.Show("픽을 먼저 해주세요.");
                                    }
                                    else if (this.pictureBox4.Image == _last.BackgroundImage || this.pictureBox5.Image == _last.BackgroundImage || this.pictureBox6.Image == _last.BackgroundImage || this.pictureBox7.Image == _last.BackgroundImage)
                                    {
                                        MessageBox.Show("이미 픽된 케릭터입니다.");
                                    }
                                    else if (this.pictureBox1.Image == _last.BackgroundImage || this.pictureBox2.Image == _last.BackgroundImage)
                                    {
                                        MessageBox.Show("이미 밴된 케릭터입니다.");
                                    }
                                    else
                                    {
                                        this.pictureBox3.Image = _last.BackgroundImage;
                                        _btn = (Button)this.ActiveControl;
                                        _btn.Image = global::WBCtest.Properties.Resources.black4;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("밴이 완료되었습니다.");
                                }
                            }
                        }
                    }
                }
            }
            else {
                MessageBox.Show("밴이 꺼져있습니다.");
            }
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Image = null;
            this.pictureBox2.Image = null;
            this.pictureBox3.Image = null;
            this.pictureBox4.Image = null;
            this.pictureBox5.Image = null;
            this.pictureBox6.Image = null;
            this.pictureBox7.Image = null;
            this.pictureBox8.Image = null;
            this.pictureBox9.Image = null;
            for (int i = 0; i < 34; i++) {
                _btn = (Button)flowLayoutPanel1.Controls[i];
                _btn.Image = null;
            }
            this.flowLayoutPanel1.Focus();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (banban == 1)
            {
                if (_last == null)
                {
                    MessageBox.Show("픽 할 케릭터를 선택해주세요.");
                }
                else
                {
                    _last.Focus();

                        if (this.pictureBox1.Image == _last.BackgroundImage || this.pictureBox2.Image == _last.BackgroundImage || this.pictureBox3.Image == _last.BackgroundImage)
                        {
                            MessageBox.Show("이미 밴된 케릭터입니다.");
                        }
                        else
                        {
                            if (this.pictureBox4.Image == null)
                            {
                                this.pictureBox4.Image = _last.BackgroundImage;
                                _btn = (Button)this.ActiveControl;
                                _btn.Image = global::WBCtest.Properties.Resources.black4;
                            }
                            else
                            {
                                if (this.pictureBox5.Image == null)
                                {
                                    if (this.pictureBox4.Image == _last.BackgroundImage)
                                    {
                                        MessageBox.Show("이미 픽된 케릭터 입니다.");
                                    }
                                    else
                                    {
                                        this.pictureBox5.Image = _last.BackgroundImage;
                                        _btn = (Button)this.ActiveControl;
                                        _btn.Image = global::WBCtest.Properties.Resources.black4;
                                    }
                                }
                                else
                                {
                                    if (this.pictureBox6.Image == null)
                                    {
                                        if (this.pictureBox4.Image == _last.BackgroundImage || this.pictureBox5.Image == _last.BackgroundImage)
                                        {
                                            MessageBox.Show("이미 픽된 케릭터 입니다.");
                                        }
                                        else
                                        {
                                            this.pictureBox6.Image = _last.BackgroundImage;
                                            _btn = (Button)this.ActiveControl;
                                            _btn.Image = global::WBCtest.Properties.Resources.black4;
                                        }
                                    }
                                    else
                                    {
                                        if (this.pictureBox7.Image == null)
                                        {
                                            if (this.pictureBox4.Image == _last.BackgroundImage || this.pictureBox5.Image == _last.BackgroundImage || this.pictureBox6.Image == _last.BackgroundImage)
                                            {
                                                MessageBox.Show("이미 픽된 케릭터 입니다.");
                                            }
                                            else
                                            {
                                                this.pictureBox7.Image = _last.BackgroundImage;
                                                _btn = (Button)this.ActiveControl;
                                                _btn.Image = global::WBCtest.Properties.Resources.black4;
                                            }
                                        }
                                        else
                                        {
                                            if (this.pictureBox8.Image == null)
                                            {
                                                if (this.pictureBox4.Image == _last.BackgroundImage || this.pictureBox5.Image == _last.BackgroundImage || this.pictureBox6.Image == _last.BackgroundImage || this.pictureBox7.Image == _last.BackgroundImage)
                                                {
                                                    MessageBox.Show("이미 픽된 케릭터 입니다.");
                                                }
                                                else
                                                {
                                                    this.pictureBox8.Image = _last.BackgroundImage;
                                                    _btn = (Button)this.ActiveControl;
                                                    _btn.Image = global::WBCtest.Properties.Resources.black4;
                                                }
                                            }
                                            else
                                            {
                                                if (this.pictureBox9.Image == null)
                                                {
                                                    if (this.pictureBox4.Image == _last.BackgroundImage || this.pictureBox5.Image == _last.BackgroundImage || this.pictureBox6.Image == _last.BackgroundImage || this.pictureBox7.Image == _last.BackgroundImage || this.pictureBox8.Image == _last.BackgroundImage)
                                                    {
                                                        MessageBox.Show("이미 픽된 케릭터 입니다.");
                                                    }
                                                    else
                                                    {
                                                        this.pictureBox9.Image = _last.BackgroundImage;
                                                        _btn = (Button)this.ActiveControl;
                                                        _btn.Image = global::WBCtest.Properties.Resources.black4;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                    }
                }
            }
            else
            {
                if (selectBan == 0)
                {
                    if (_last == null)
                    {
                        MessageBox.Show("픽 할 케릭터를 선택해주세요.");
                    }
                    else
                    {
                        _last.Focus();

                        if (this.pictureBox1.Image == null || this.pictureBox2.Image == null || this.pictureBox3.Image == null)
                        {
                            MessageBox.Show("밴을 먼저 해주세요.");
                        }
                        else
                        {
                            if (this.pictureBox1.Image == _last.BackgroundImage || this.pictureBox2.Image == _last.BackgroundImage || this.pictureBox3.Image == _last.BackgroundImage)
                            {
                                MessageBox.Show("이미 밴된 케릭터입니다.");
                            }
                            else
                            {
                                if (this.pictureBox4.Image == null)
                                {
                                    this.pictureBox4.Image = _last.BackgroundImage;
                                    _btn = (Button)this.ActiveControl;
                                    _btn.Image = global::WBCtest.Properties.Resources.black4;
                                }
                                else
                                {
                                    if (this.pictureBox5.Image == null)
                                    {
                                        if (this.pictureBox4.Image == _last.BackgroundImage)
                                        {
                                            MessageBox.Show("이미 픽된 케릭터 입니다.");
                                        }
                                        else
                                        {
                                            this.pictureBox5.Image = _last.BackgroundImage;
                                            _btn = (Button)this.ActiveControl;
                                            _btn.Image = global::WBCtest.Properties.Resources.black4;
                                        }
                                    }
                                    else
                                    {
                                        if (this.pictureBox6.Image == null)
                                        {
                                            if (this.pictureBox4.Image == _last.BackgroundImage || this.pictureBox5.Image == _last.BackgroundImage)
                                            {
                                                MessageBox.Show("이미 픽된 케릭터 입니다.");
                                            }
                                            else
                                            {
                                                this.pictureBox6.Image = _last.BackgroundImage;
                                                _btn = (Button)this.ActiveControl;
                                                _btn.Image = global::WBCtest.Properties.Resources.black4;
                                            }
                                        }
                                        else
                                        {
                                            if (this.pictureBox7.Image == null)
                                            {
                                                if (this.pictureBox4.Image == _last.BackgroundImage || this.pictureBox5.Image == _last.BackgroundImage || this.pictureBox6.Image == _last.BackgroundImage)
                                                {
                                                    MessageBox.Show("이미 픽된 케릭터 입니다.");
                                                }
                                                else
                                                {
                                                    this.pictureBox7.Image = _last.BackgroundImage;
                                                    _btn = (Button)this.ActiveControl;
                                                    _btn.Image = global::WBCtest.Properties.Resources.black4;
                                                }
                                            }
                                            else
                                            {
                                                if (this.pictureBox8.Image == null)
                                                {
                                                    if (this.pictureBox4.Image == _last.BackgroundImage || this.pictureBox5.Image == _last.BackgroundImage || this.pictureBox6.Image == _last.BackgroundImage || this.pictureBox7.Image == _last.BackgroundImage)
                                                    {
                                                        MessageBox.Show("이미 픽된 케릭터 입니다.");
                                                    }
                                                    else
                                                    {
                                                        this.pictureBox8.Image = _last.BackgroundImage;
                                                        _btn = (Button)this.ActiveControl;
                                                        _btn.Image = global::WBCtest.Properties.Resources.black4;
                                                    }
                                                }
                                                else
                                                {
                                                    if (this.pictureBox9.Image == null)
                                                    {
                                                        if (this.pictureBox4.Image == _last.BackgroundImage || this.pictureBox5.Image == _last.BackgroundImage || this.pictureBox6.Image == _last.BackgroundImage || this.pictureBox7.Image == _last.BackgroundImage || this.pictureBox8.Image == _last.BackgroundImage)
                                                        {
                                                            MessageBox.Show("이미 픽된 케릭터 입니다.");
                                                        }
                                                        else
                                                        {
                                                            this.pictureBox9.Image = _last.BackgroundImage;
                                                            _btn = (Button)this.ActiveControl;
                                                            _btn.Image = global::WBCtest.Properties.Resources.black4;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                else//1픽2밴
                {
                    if (_last == null)
                    {
                        MessageBox.Show("픽 할 케릭터를 선택해주세요.");
                    }
                    else
                    {
                        _last.Focus();
                        if (this.pictureBox1.Image == null)
                        {
                            MessageBox.Show("밴을 먼저해주세요.");
                        }
                        else
                        {
                            if (this.pictureBox1.Image == _last.BackgroundImage)
                            {
                                MessageBox.Show("이미 밴된 케릭터입니다.");
                            }
                            else if (this.pictureBox4.Image == null)
                            {
                                this.pictureBox4.Image = _last.BackgroundImage;
                                _btn = (Button)this.ActiveControl;
                                _btn.Image = global::WBCtest.Properties.Resources.black4;
                            }
                            else if (this.pictureBox5.Image == null)
                            {
                                if (this.pictureBox4.Image == _last.BackgroundImage)
                                {
                                    MessageBox.Show("이미 픽된 케릭터입니다.");
                                }
                                else
                                {
                                    this.pictureBox5.Image = _last.BackgroundImage;
                                    _btn = (Button)this.ActiveControl;
                                    _btn.Image = global::WBCtest.Properties.Resources.black4;
                                }
                            }
                            else
                            {
                                if (this.pictureBox2.Image == null)
                                {
                                    MessageBox.Show("밴을 먼저해주세요.");
                                }
                                else
                                {
                                    if (this.pictureBox1.Image == _last.BackgroundImage || this.pictureBox2.Image == _last.BackgroundImage)
                                    {
                                        MessageBox.Show("이미 밴된 케릭터 입니다.");
                                    }
                                    else if (this.pictureBox4.Image == _last.BackgroundImage || this.pictureBox5.Image == _last.BackgroundImage)
                                    {
                                        MessageBox.Show("이미 픽된 케릭터 입니다.");
                                    }
                                    else if (this.pictureBox6.Image == null)
                                    {
                                        this.pictureBox6.Image = _last.BackgroundImage;
                                        _btn = (Button)this.ActiveControl;
                                        _btn.Image = global::WBCtest.Properties.Resources.black4;
                                    }
                                    else if (this.pictureBox7.Image == null)
                                    {
                                        if (this.pictureBox6.Image == _last.BackgroundImage)
                                        {
                                            MessageBox.Show("이미 픽된 케릭터 입니다.");
                                        }
                                        else
                                        {
                                            this.pictureBox7.Image = _last.BackgroundImage;
                                            _btn = (Button)this.ActiveControl;
                                            _btn.Image = global::WBCtest.Properties.Resources.black4;
                                        }
                                    }
                                    else
                                    {
                                        if (this.pictureBox3.Image == null)
                                        {
                                            MessageBox.Show("밴을 먼저해주세요.");
                                        }
                                        else
                                        {
                                            if (this.pictureBox1.Image == _last.BackgroundImage || this.pictureBox2.Image == _last.BackgroundImage || this.pictureBox3.Image == _last.BackgroundImage)
                                            {
                                                MessageBox.Show("이미 밴된 케릭터 입니다.");
                                            }
                                            else if (this.pictureBox4.Image == _last.BackgroundImage || this.pictureBox5.Image == _last.BackgroundImage || this.pictureBox6.Image == _last.BackgroundImage || this.pictureBox7.Image == _last.BackgroundImage)
                                            {
                                                MessageBox.Show("이미 픽된 케릭터 입니다.");
                                            }
                                            else if (this.pictureBox8.Image == null)
                                            {
                                                this.pictureBox8.Image = _last.BackgroundImage;
                                                _btn = (Button)this.ActiveControl;
                                                _btn.Image = global::WBCtest.Properties.Resources.black4;
                                            }
                                            else if (this.pictureBox9.Image == null)
                                            {
                                                if (this.pictureBox8.Image == _last.BackgroundImage)
                                                {
                                                    MessageBox.Show("이미 픽된 케릭터 입니다.");
                                                }
                                                else
                                                {
                                                    this.pictureBox9.Image = _last.BackgroundImage;
                                                    _btn = (Button)this.ActiveControl;
                                                    _btn.Image = global::WBCtest.Properties.Resources.black4;
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("픽이 완료되었습니다.");
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (banban == 0)
            {
                if (this.pictureBox1.Image == null || this.pictureBox2.Image == null || this.pictureBox3.Image == null || this.pictureBox4.Image == null || this.pictureBox5.Image == null || this.pictureBox6.Image == null || this.pictureBox7.Image == null || this.pictureBox8.Image == null || this.pictureBox9.Image == null)
                {
                    MessageBox.Show("먼저 밴픽을 해주세요.");
                }
                else
                {
                    this.Visible = false;
                    Form2 dlg = new Form2(this);
                    dlg.ShowDialog();
                    this.Visible = true;
                }
            }
            else {
                this.Visible = false;
                Form2 dlg = new Form2(this);
                dlg.ShowDialog();
                this.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            _last = (Control)sender;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _last = (Control)sender;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _last = (Control)sender;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            _last = (Control)sender;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            _last = (Control)sender;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            _last = (Control)sender;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            _last = (Control)sender;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            _last = (Control)sender;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            _last = (Control)sender;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            _last = (Control)sender;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            _last = (Control)sender;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            _last = (Control)sender;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            _last = (Control)sender;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            _last = (Control)sender;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            _last = (Control)sender;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            _last = (Control)sender;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            _last = (Control)sender;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            _last = (Control)sender;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            _last = (Control)sender;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            _last = (Control)sender;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            _last = (Control)sender;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            _last = (Control)sender;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            _last = (Control)sender;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            _last = (Control)sender;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            _last = (Control)sender;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            _last = (Control)sender;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            _last = (Control)sender;
        }

        private void button44_Click(object sender, EventArgs e)
        {
            _last = (Control)sender;
        }

        private void button43_Click(object sender, EventArgs e)
        {
            _last = (Control)sender;
        }

        private void button42_Click(object sender, EventArgs e)
        {
            _last = (Control)sender;
        }

        private void button41_Click(object sender, EventArgs e)
        {
            _last = (Control)sender;
        }

        private void button40_Click(object sender, EventArgs e)
        {
            _last = (Control)sender;
        }

        private void button39_Click(object sender, EventArgs e)
        {
            _last = (Control)sender;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            _last = (Control)sender;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            for (int i = 0; i < 34; i++) {
                string ttag = (string)this.flowLayoutPanel1.Controls[i].Tag;
                if(ttag.Contains(this.textBox1.Text))
                {
                    this.flowLayoutPanel1.Controls[i].Show();   
                }
                else {
                    this.flowLayoutPanel1.Controls[i].Hide();
                }
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Image = null;
            this.pictureBox2.Image = null;
            this.pictureBox3.Image = null;
            this.pictureBox4.Image = null;
            this.pictureBox5.Image = null;
            this.pictureBox6.Image = null;
            this.pictureBox7.Image = null;
            this.pictureBox8.Image = null;
            this.pictureBox9.Image = null;
            for (int i = 0; i < 34; i++)
            {
                _btn = (Button)flowLayoutPanel1.Controls[i];
                _btn.Image = null;
            }
            this.flowLayoutPanel1.Focus();
            if (selectBan == 0) {
                selectBan = 1;
                MessageBox.Show("1밴2픽으로 변경되었습니다");
            }
            else if (selectBan == 1) {
                selectBan = 0;
                MessageBox.Show("3밴6픽으로 변경되었습니다");
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Image = null;
            this.pictureBox2.Image = null;
            this.pictureBox3.Image = null;
            this.pictureBox4.Image = null;
            this.pictureBox5.Image = null;
            this.pictureBox6.Image = null;
            this.pictureBox7.Image = null;
            this.pictureBox8.Image = null;
            this.pictureBox9.Image = null;
            for (int i = 0; i < 34; i++)
            {
                _btn = (Button)flowLayoutPanel1.Controls[i];
                _btn.Image = null;
            }
            this.flowLayoutPanel1.Focus();
            if (banban == 1)
            {
                MessageBox.Show("Ban mode ON");
                banban = 0;
            }
            else {
                MessageBox.Show("Ban mode OFF");
                banban = 1;
            }
        }
    }
}
