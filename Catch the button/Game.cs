using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace Catch_the_button {
    class Game {
        static internal int points;
        static bool status = false;
        static bool first = true;
        static int miss;
        static Random rng = new Random();
        static Stopwatch stpwch = new Stopwatch();
        static Timer timer;
        static Timer etaUpdater;
        static Timer formResetter;
        static Label pts;
        static Label hp;
        static Panel menu;
        static Label btn;
        static Form frm;
        static Label eta;
        static Panel[] hp_indicators = new Panel[5];
        static int delay = 2000;
        static internal void Init(Label opts, Label ohp, Panel omenu, Label obutton,
            Form oform, Label oeta) {
            pts = opts;
            hp = ohp;
            menu = omenu;
            btn = obutton;
            frm = oform;
            eta = oeta;
            SetTimers();
        }
        static internal void HealthInit(Panel ohp1, Panel ohp2, Panel ohp3, Panel ohp4) {
            hp_indicators[0] = ohp1;
            hp_indicators[1] = ohp2;
            hp_indicators[2] = ohp3;
            hp_indicators[3] = ohp4;
            hp_indicators[4] = ohp4;
        }
        static private void SetTimers() {
            timer = new Timer();
            timer.Interval = delay;
            timer.Tick += Tmr_Tick;
            timer.Enabled = true;
            timer.Stop();

            etaUpdater = new Timer();
            etaUpdater.Interval = 20;
            etaUpdater.Tick += Updater_Tick;
            etaUpdater.Enabled = true;
            etaUpdater.Stop();

            formResetter = new Timer();
            formResetter.Interval = 200;
            formResetter.Tick += formResetter_Tick;
            formResetter.Enabled = true;
            formResetter.Stop();
        }

        static private void Tmr_Tick(object sender, EventArgs e) {
            Hit(new System.Timers.Timer());
        }
        static private void Updater_Tick(object sender, EventArgs e) {
            eta.Text = $"New Position in: {(delay - stpwch.ElapsedMilliseconds)}ms/{delay}ms";
        }
        static private void formResetter_Tick(object sender, EventArgs e) {
            frm.BackColor = Color.FromArgb(240, 240, 240);
            formResetter.Stop();
        }
        static internal void Start() { //pressed button start
            points = miss = 0;
            delay = 2000;
            btn.Visible = btn.Enabled = true;
            menu.Visible = menu.Enabled = false;
            btn.Size = new Size(50, 50);
            btn.Location = new Point((frm.Width - btn.Width) / 2, (frm.Height - btn.Height) / 2);
            status = true;
            timer.Interval = delay;
            
        }
        static void Go() { //first button hit
            timer.Start();
            stpwch.Start();
            etaUpdater.Start();
            newPos();
        }
        static internal void Hit(object obj = null) {
            if (!status) return; 
            if (first) {
                Go();
                first = false;
                return;
            }
            if (stpwch.ElapsedMilliseconds < 500 && !(obj is Form || obj is System.Timers.Timer)) {
                points += 2;
                if (points % 20 == 0) {
                    delay -= 200;
                }
            }
            else if (stpwch.ElapsedMilliseconds >= 500 && !(obj is Form || obj is System.Timers.Timer)) {
                points++;
                if (points % 20 == 0) {
                    delay -= 200;
                }
            }
            else if (obj is System.Timers.Timer || obj is Form) {
                points--;
                miss++;
                formResetter.Start();
                frm.BackColor = Color.FromArgb(240, 200, 200);
            }
            UpdateText();
            if (miss > 3) {
                Stop();
                return;
            }
            stpwch.Restart();
            resetTimer();
            newPos();
        }
        static internal void Stop() {
            stpwch.Stop();
            timer.Stop();
            etaUpdater.Stop();
            first = true;
            status = false;

            Leaderboard.Write();
            Leaderboard.Output();

            points = miss = 0;
            delay = 2000;
            UpdateText();
            btn.Visible = btn.Enabled = false;
            menu.Visible = menu.Enabled = true;
            eta.Text = "New Position in: ...";
        }
        static private void UpdateText() {
            pts.Text = "Points: " + points;
            hp.Text = "HP: "+(3 - miss).ToString();
        }
        static void newPos() {
            btn.Location = new Point(
                rng.Next(frm.ClientSize.Width - btn.Width),
                rng.Next(40, frm.ClientSize.Height - btn.Height));
        }

        static private void resetTimer() {
            timer.Stop();
            timer.Interval = delay;
            timer.Start();

            etaUpdater.Stop();
            etaUpdater.Start();
        }
    }
}
