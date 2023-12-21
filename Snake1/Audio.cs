using System;
using System.Collections.Generic;
using System.Windows.Media;

namespace Snake1
{
    public static class Audio
    {
        public readonly static MediaPlayer GameOver = LoadAudio("MissionFailed.mp3");
        public readonly static MediaPlayer GameLoop = LoadAudio("Battotai - Phonk Remix.mp3");
        public readonly static MediaPlayer BMP = LoadAudio("A Song of the BMP Driver.mp3");
        public readonly static MediaPlayer Sidtrus = LoadAudio("Sidtrus - Slap Bass.mp3");
        public readonly static MediaPlayer Geiger = LoadAudio("geiger-counter.mp3");
        

        public readonly static List<MediaPlayer> bgm = new()
        {
            BMP, Sidtrus, GameLoop
        };

        private static MediaPlayer LoadAudio(string filename, 
            double volume = 1, bool repeat = false, bool autoReset = true)
        {
            MediaPlayer player = new();
            player.Open(new Uri($"Assets/{filename}", UriKind.Relative));

            if (autoReset)
            {
                player.MediaEnded += Player_MediaEnded;
            }

            return player;
        }

        private static void Player_MediaEnded(object sender, EventArgs e)
        {
            MediaPlayer m = sender as MediaPlayer;
            m.Stop();
            m.Position = new TimeSpan(0);
        }

        private static void PlayerRepear_MediaEnded(object sender, EventArgs e)
        {
            MediaPlayer m = sender as MediaPlayer;
            m.Play();
            m.Position = new TimeSpan(0);
        }
    }
}
