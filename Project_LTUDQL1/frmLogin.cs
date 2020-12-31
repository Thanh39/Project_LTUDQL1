using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_LTUDQL1
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            PictureBox btn = sender as PictureBox;
            btn.BackColor = Color.RoyalBlue;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            PictureBox btn = sender as PictureBox;
            btn.BackColor = Color.Transparent;
        }

        private void EventHover(object sender, EventArgs e)
        {
            PictureBox btn = sender as PictureBox;
            btn.BackColor = Color.RoyalBlue;
        }

        private void EventLeave(object sender, EventArgs e)
        {
            PictureBox btn = sender as PictureBox;
            btn.BackColor = Color.Transparent;
        }

        private void btnMiniMum_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMiniMum_MouseHover(object sender, EventArgs e)
        {
            PictureBox btn = sender as PictureBox;
            btn.BackColor = Color.RoyalBlue;
        }

        private void btnMiniMum_MouseLeave(object sender, EventArgs e)
        {
            PictureBox btn = sender as PictureBox;
            btn.BackColor = Color.Transparent;
        }
        int mouseX, mouseY = 0;
        bool mouseDown;

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseDown)
            {
                mouseX = MousePosition.X - 200;
                mouseY = MousePosition.Y - 40;

                this.SetDesktopLocation(mouseX, mouseY);
            }    
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangKy f2 = new frmDangKy();
            f2.ShowDialog();
            this.Close();
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

    }
}
