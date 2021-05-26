using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Linq;

namespace Catch_the_button {
    class Leaderboard {
        static internal List<LeaderboardEntry> Leaderboards = new List<LeaderboardEntry>();
        static internal LeaderboardEntry highscore = new LeaderboardEntry("",0);
        static RichTextBox LeaderObject;
        static Form form;
        static Label highscoreLabel;
        static string filename = "leaderboards.txt";
        static string root = "./resources/";
        static string path = root+filename;

        static internal void Init(RichTextBox leaderObject, Form form, Label highscoreLabel) {
            LeaderObject = leaderObject;
            Leaderboard.form = form;
            Leaderboard.highscoreLabel = highscoreLabel;

            byte stat = Read();
            if (stat == 1) return;
            Output();
        }

        static internal byte Read() {
            if (!Directory.Exists(root)) Directory.CreateDirectory(root);
            if (!File.Exists(path)) { LeaderObject.Text = "Leaderboards not found"; File.Create(path); return 1; }
            if (File.ReadAllLines(path).Length <1) { LeaderObject.Text = "Leaderboards empty. Be the first to place a record"; File.Create(path); return 1; }
            string[] preformat = Sort(File.ReadAllLines(path));
            Leaderboards.Clear();
            for (int i = 0; i < preformat.Length; i++) {
                string[] pars = preformat[i].Split(':');
                LeaderboardEntry formatted = new LeaderboardEntry(pars[0], Int32.Parse(pars[1]));
                Leaderboards.Add(formatted);
            }
            FindHighScore();
            return 0;
        }
        static internal string[] Sort(string[] input) {
            SortedDictionary<Int32, string> carry = new SortedDictionary<Int32, string>();
            for (int i = 0; i < input.Length; i++) {
                string[] pars = input[i].Split(':');
                carry[Int32.Parse(pars[1])] = pars[0];
            }
            int j = 0;
            foreach (KeyValuePair<Int32, string> item in carry) {
                input[j] = $"{item.Value}:{item.Key}";
                j++;
            }
            return input.Reverse().ToArray();
        }

        static private void FindHighScore() {
            foreach (LeaderboardEntry entry in Leaderboards) {
                if (entry.points > highscore.points) highscore = entry;
            }
            highscoreLabel.Text = $"{highscore.name}: {highscore.points}";
        }

        static internal void Output(RichTextBox leaderboardObj = null) {
            if (leaderboardObj != null) {
                int count = Leaderboards.Count > 5 ? 5 : Leaderboards.Count;
                string output = "";
                for (int i = 0; i < count; i++) {
                    output += Leaderboards[i] + "\n";
                }
                leaderboardObj.Text = output.Substring(0, output.Length - 1);
            }
            else {
                string[] lines = new string[Leaderboards.Count];
                for (int i = 0; i< Leaderboards.Count; i++) {
                    lines[i] = $"{Leaderboards[i].name}: {Leaderboards[i].points}";
                }
                LeaderObject.Lines = lines;
            }
        }
        static internal void Write() {
            Form leaderboardDialog = new LeaderDialog(Game.points, form);
            leaderboardDialog.ShowDialog();
            string leaderboardtxt = "";
            foreach (LeaderboardEntry entry in Leaderboards) {
                leaderboardtxt += $"{entry.name}:{entry.points}\n";
            }
            File.WriteAllText(path, leaderboardtxt.Substring(0, leaderboardtxt.Length - 1));
            Read();
        }
    }
    class LeaderboardEntry {
        internal string name;
        internal int points;
        public LeaderboardEntry(string name, int points) {
            this.name = name;
            this.points = points;
        }
    }
}
