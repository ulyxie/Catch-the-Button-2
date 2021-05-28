using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Catch_the_button {
    class AudioSystem {
        static SoundPlayer hit = new SoundPlayer("./resources/hit.wav");
        static SoundPlayer miss = new SoundPlayer("./resources/miss.wav");
        static internal void Hit() {
            hit.Play();
        }
        static internal void Miss() {
            miss.Play();
        }
    }
}
