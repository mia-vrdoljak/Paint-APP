using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Signature_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Width = 950;
            this.Height = 700;
            bm = new Bitmap(Pic.Width, Pic.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            Pic.Image = bm;
        }

        Bitmap bm;
        Graphics g;
        bool paint = false;
        Point px, py;
        Pen p = new Pen(Color.Black, 1);
        Pen erase = new Pen(Color.White, 10);
        int index;
        int x, y, sX, sY, cX, cY;

        ColorDialog cd = new ColorDialog();
        Color new_color;

        private void Pic_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;

            cX = e.X;
            cY = e.Y;
        }

        private void Pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                if(index == 1)
                {
                    px = e.Location;
                    g.DrawLine(p, px, py);
                    py = px;
                }
                if (index == 2)
                {
                    px = e.Location;
                    g.DrawLine(erase, px, py);
                    py = px;
                }
            }

            Pic.Refresh();

            x = e.X;
            y = e.Y;
            sX = e.X - cX;
            sY = e.Y - cY;
        }

        private void Pic_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;

            sX = x - cX;
            sY = y - cY;

            if (index == 3)
            {
                g.DrawRectangle(p, cX, cY, sX, sY);
            }
            if (index == 4)
            {
                g.DrawEllipse(p, cX, cY, sX, sY);
            }
            if (index == 5)
            {
                g.DrawLine(p, cX, cY, x, y);
            }
            if (index == 7)
            {
                TextBox textBox = new TextBox();
                Point location = Pic.PointToScreen(e.Location);
                PopupForm form = new PopupForm(textBox, location,
                  () => this.Text = textBox.Text);
                form.Show();
            }
        }

        private void BtnLinesize1_Click(object sender, EventArgs e)
        {
            p.Width = 1;
            erase.Width = 10;
        }

        private void BtnLinesize2_Click(object sender, EventArgs e)
        {
            p.Width = 5;
            erase.Width = 20;
        }

        private void BtnLinesize3_Click(object sender, EventArgs e)
        {
            p.Width = 10;
            erase.Width = 30;
        }

        private void BtnPencil_Click(object sender, EventArgs e)
        {
            index = 1;
        }

        private void BtnEraser_Click(object sender, EventArgs e)
        {
            index = 2;
        }

        private void BtnRectangle_Click(object sender, EventArgs e)
        {
            index = 3;
        }

        private void BtnEllipse_Click(object sender, EventArgs e)
        {
            index = 4;
        }
        
        private void BtnLine_Click(object sender, EventArgs e)
        {
            index = 5;
        }

        private void BtnFill_Click(object sender, EventArgs e)
        {
            index = 6;
        }

        private void Pic_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if (paint)
            {
                if (index == 3)
                {
                    g.DrawRectangle(p, cX, cY, sX, sY);
                }
                if (index == 4)
                {
                    g.DrawEllipse(p, cX, cY, sX, sY);
                }
                if (index == 5)
                {
                    g.DrawLine(p, cX, cY, x, y);
                }
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            Pic.Image = bm;
            index = 0;
        }

        private void BtnColorPalet_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            new_color = cd.Color;
            PicCurrentColor.BackColor = cd.Color;
            p.Color = cd.Color;
        }

        static Point set_point(PictureBox pb, Point pt)
        {
            float pX = 1f * pb.Image.Width / pb.Width;
            float pY = 1f * pb.Image.Height / pb.Height;
            return new Point((int)(pt.X * pX), (int)(pt.Y * pY));
        }

        private void BtnTextbox_Click(object sender, EventArgs e)
        {
            /*TextBox txt = new TextBox();

            txt.Name = "DynamicTxt";
            txt.Location = new System.Drawing.Point(20, 20);
            txt.Size = new System.Drawing.Size(200, 20);
            this.Controls.Add(txt);*/

            /*TextBox textbox = new TextBox();
            int count = Pic.Controls.OfType<TextBox>().ToList().Count;
            textbox.Location = new System.Drawing.Point(100, 25 * count);
            textbox.Size = new System.Drawing.Size(80, 20);
            textbox.Name = "txt_" + (count + 1);
            Pic.Controls.Add(textbox);
            Pic.Invalidate();*/

            index = 7;
        }

        private void PicColorPicker_MouseClick(object sender, MouseEventArgs e)
        {
            Point point = set_point(PicColorPicker, e.Location);
            PicCurrentColor.BackColor = ((Bitmap)PicColorPicker.Image).GetPixel(point.X, point.Y);
            new_color = PicCurrentColor.BackColor;
            p.Color = PicCurrentColor.BackColor;
        }

        private void validate(Bitmap bm, Stack<Point>sp, int x, int y, Color old_color, Color new_color)
        {
            Color cx = bm.GetPixel(x, y);
            if(cx == old_color)
            {
                sp.Push(new Point(x, y));
                bm.SetPixel(x, y, new_color);
            }
        }

        public void Fill(Bitmap bm, int x, int y, Color new_clr)
        {
            Color old_color = bm.GetPixel(x, y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));
            bm.SetPixel(x, y, new_clr);
            if (old_color == new_clr)
                return;

            while(pixel.Count > 0)
            {
                Point pt = (Point)pixel.Pop();
                if(pt.X > 0 && pt.Y > 0 && pt.X < bm.Width - 1 && pt.Y < bm.Height - 1)
                {
                    validate(bm, pixel, pt.X-1, pt.Y, old_color, new_clr);
                    validate(bm, pixel, pt.X, pt.Y-1, old_color, new_clr);
                    validate(bm, pixel, pt.X+1, pt.Y, old_color, new_clr);
                    validate(bm, pixel, pt.X, pt.Y+1, old_color, new_clr);
                }
            }
        }

        private void Pic_MouseClick(object sender, MouseEventArgs e)
        {
            if(index == 6)
            {
                Point point = set_point(Pic, e.Location);
                Fill(bm, point.X, point.Y, new_color);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "Image(*.jpg)|*.jpg|(*.*|*.*";
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                Bitmap btm = bm.Clone(new Rectangle(0, 0, Pic.Width, Pic.Height), bm.PixelFormat);
                btm.Save(sfd.FileName, ImageFormat.Jpeg);
                MessageBox.Show("Image saved succesfully!");
            }
        }

        private void BtnUpload_Click(object sender, EventArgs e)/*???Postavi napravljenu sliku, ne postavi malca nego stavi bijelu pozadinu, obe prepoznaje i pise ISPOD njih*/
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if(dr == DialogResult.OK)
            {
                Pic.Image = Image.FromFile(openFileDialog1.FileName);
            }

            /*OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                Pic.Image = new Bitmap(opnfd.FileName);
            }*/
        }

    }

    public class PopupForm : Form
    {
        private Action _onAccept;
        private Control _control;
        private Point _point;

        public PopupForm(Control control, int x, int y, Action onAccept)
          : this(control, new Point(x, y), onAccept)
        {
        }

        public PopupForm(Control control, Point point, Action onAccept)
        {
            if (control == null) throw new ArgumentNullException("control");

            this.FormBorderStyle = FormBorderStyle.None;
            this.ShowInTaskbar = false;
            this.KeyPreview = true;
            _point = point;
            _control = control;
            _onAccept = onAccept;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.Controls.Add(_control);
            _control.Location = new Point(0, 0);
            this.Size = _control.Size;
            this.Location = _point;
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.KeyCode == Keys.Enter)
            {
                _onAccept();
                this.Close();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        protected override void OnDeactivate(EventArgs e)
        {
            base.OnDeactivate(e);
            this.Close();
        }
    }
}
