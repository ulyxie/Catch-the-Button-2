using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Catch_the_button {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e) {
            Game.Start();
        }

        private void Form1_Load(object sender, EventArgs e) {
            Game.Init(ptsCount, hp, Menu, button, this, timeleft, milestone);
            Leaderboard.Init(ldrboard, this, highscore);
            button.Parent = stats.Parent = this;
        }

        private void quit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button_MouseEnter(object sender, EventArgs e) {
            button.BackColor = Color.FromArgb(240, 240, 240);
        }

        private void button_MouseLeave(object sender, EventArgs e) {
            button.BackColor = Color.FromArgb(211, 211, 211);
        }

        private void Main_KeyDown(object sender, KeyEventArgs e) {
            switch (e.KeyCode) {
                case Keys.Escape:
                    Game.Stop();
                    break;
                default:
                    break;
            }
        }

        private void button_MouseDown(object sender, MouseEventArgs e) {
            Game.Hit();
        }

        private void Main_MouseDown(object sender, MouseEventArgs e) {
            Game.Hit(obj: sender);
        }
    }
}
