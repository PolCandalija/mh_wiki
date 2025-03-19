using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Media;

namespace mh.datasource
{
    public static class MhSounds
    {
        public static MediaPlayer menuHover = CreateMediaPlayer(@"sounds\mh_menu_hover.wav", 0.05);
        public static MediaPlayer menuNormal = CreateMediaPlayer(@"sounds\mh_menu_normal.wav", 0.3);
        public static MediaPlayer menuMain = CreateMediaPlayer(@"sounds\mh_menu_main.wav", 0.3);
        public static MediaPlayer rare = CreateMediaPlayer(@"sounds\mh_rare.wav", 0.3);
        public static MediaPlayer weapon = CreateMediaPlayer(@"sounds\mh_weapon3.wav", 0.2);
        public static MediaPlayer armor = CreateMediaPlayer(@"sounds\mh_armor3.wav", 0.5);
        public static MediaPlayer bgMusic = new MediaPlayer();
        static MhSounds()
        {
            SetupBackgroundMusic(@"sounds\mh_bg_music.wav", 0.25);
        }

        private static MediaPlayer CreateMediaPlayer(string path, double volume)
        {
            MediaPlayer player = new MediaPlayer();
            player.Open(new Uri(path, UriKind.RelativeOrAbsolute));
            player.Volume = volume;
            return player;
        }

        public static void PlaySound(MediaPlayer player)
        {
            player.Position = TimeSpan.Zero;
            player.Play();
        }

        private static void SetupBackgroundMusic(string path, double volume)
        {
            bgMusic.Open(new Uri(path, UriKind.RelativeOrAbsolute));
            bgMusic.Volume = volume;
            bgMusic.MediaEnded += (s, e) => // Evento para hacer un bucle
            {
                bgMusic.Position = TimeSpan.Zero;
                bgMusic.Play();
            };
        }

        public static void PlayBackgroundMusic()
        {
            bgMusic.Play();
        }
    }
}
