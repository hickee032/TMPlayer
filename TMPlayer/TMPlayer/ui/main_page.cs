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
        public main_page() {
            InitializeComponent();
        }

        private void mainClose_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void mainSmaller_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }
        private void main_btnTray_Click(object sender, EventArgs e) {
            this.Visible= false;
            this.ShowIcon = false;
            trayIcon.Visible = true;
        }

        private void trayIcon_MouseDoubleClick(object sender, MouseEventArgs e) {
            this.Visible = true;
            this.ShowIcon=true;
            trayIcon.Visible = false;
        }
    }
}
