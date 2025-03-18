using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace mh.datasource
{
    public static class MhSounds
    {
        public static SoundPlayer bgMusic = new SoundPlayer(@"sounds\mh_bg_music.wav");
        public static SoundPlayer menuHover = new SoundPlayer(@"sounds\mh_menu_hover.wav");
        public static SoundPlayer menuNormal = new SoundPlayer(@"sounds\mh_menu_normal.wav");
        public static SoundPlayer menuMain = new SoundPlayer(@"sounds\mh_menu_main.wav");
    }
}
