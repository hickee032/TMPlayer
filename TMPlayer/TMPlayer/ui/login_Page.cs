using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMPlayer.ui;

namespace TMPlayer {
    public partial class login_Page : Form {
        public login_Page() {
            InitializeComponent();
        }

        //Button Event
        private void btnLogin_Click(object sender, EventArgs e) {

            if (tbxUsername.Text.Length == 0) {

            }

            Console.WriteLine(tbxUsername.Text);
            Console.WriteLine(tbxPass.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        #region login_win_mouse_move

        private bool onClick;
        private Point startPoint = new Point(0, 0);

        private void login_Page_MouseDown(object sender, MouseEventArgs e) {

            onClick = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void login_Page_MouseMove(object sender, MouseEventArgs e) {
            if (onClick) {
                        Point p = PointToScreen(e.Location);
                       Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
                  }
            }

        private void login_Page_MouseUp(object sender, MouseEventArgs e) {
            onClick = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e) {
            onClick = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e) {
            if (onClick) {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e) {
            onClick = false;
        }

        #endregion

    }
}
