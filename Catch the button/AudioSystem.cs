using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Catch_the_button {
    class AudioSystem {
        static SoundPlayer hit = new SoundPlayer();
        static SoundPlayer miss = new SoundPlayer();
        static SoundPlayer levelup = new SoundPlayer();
        static SoundPlayer gamestart = new SoundPlayer();
        static internal void Init() {
            hit.SoundLocation = "./resources/hit.wav";
            miss.SoundLocation = "./resources/miss.wav";
            levelup.SoundLocation = "./resources/levelup.wav";
            gamestart.SoundLocation = "./resources/game-start.wav";

            hit.Load();
            miss.Load();
            levelup.Load();
            gamestart.Load();
        }
        static internal void Hit() {
            hit.Play();
        }
        static internal void Miss() {
            miss.Play();
        }
        static internal void LevelUp() {
            levelup.Play();
        }
        static internal void Play() {
            gamestart.Play();
        }
    }
}
