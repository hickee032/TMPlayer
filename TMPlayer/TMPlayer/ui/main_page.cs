using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMPlayer.ui {
    public partial class main_page : Form {

        public const string UC_HOMEUSER = "UcVideo";

        public main_page() {
            InitializeComponent();
        }

        private void M_btnVideo_Click(object sender, EventArgs e) {

            controllView(new UcVideo(), UC_HOMEUSER);
        }

        private void trayIcon_MouseDoubleClick(object sender, MouseEventArgs e) {
            this.Visible = true;
            this.ShowIcon=true;
            trayIcon.Visible = false;
        }

        #region basic_setting_func
        public void controllView(UserControl uc, string viewName) {

            pnl_content.Controls.Clear();

            if (!pnl_content.Controls.ContainsKey(viewName)) {
                uc.Dock = DockStyle.Fill;
                pnl_content.Controls.Add(uc);
            }
        }

        #endregion

        #region title_bar_btn
        private void mainClose_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void mainSmaller_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }
        private void main_btnTray_Click(object sender, EventArgs e) {
            this.Visible = false;
            this.ShowIcon = false;
            trayIcon.Visible = true;
        }
        #endregion

        #region title_bar_mouse_move
        private bool onClick;
        private Point startPoint = new Point(0, 0);

        private void panel_tbar_MouseDown(object sender, MouseEventArgs e) {
            onClick = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void panel_tbar_MouseMove(object sender, MouseEventArgs e) {
            if (onClick) {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void panel_tbar_MouseUp(object sender, MouseEventArgs e) {
            onClick = false;
        }
        #endregion
    }
}
