using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catch_the_button {
    public partial class LeaderDialog : Form {
        int points;
        Form mainForm;
        public LeaderDialog(int points, Form mainForm) {
            InitializeComponent();
            this.points = points;
            this.mainForm = mainForm;
        }

        private void Form2_Load(object sender, EventArgs e) {
            this.Location = new Point(
                mainForm.Left+mainForm.Width/2-this.Width/2,
                mainForm.Top + mainForm.Height / 2 - this.Height / 2);
            score.Text = $"Your score is: {points}";
        }

        private void submit_Click(object sender, EventArgs e) {
            if (name.Text == "") { this.Close(); return; };
            LeaderboardEntry newEntry = new LeaderboardEntry(name.Text.Replace(":", ""), points);
            Leaderboard.Leaderboards.Add(newEntry);
            this.Close();
        }

        private void LeaderDialog_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) submit_Click(null, null);
        }
    }
}
