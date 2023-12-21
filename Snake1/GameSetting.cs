using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake1
{
    public static class GameSetting
    {
        public static int BoostSpeed { get; set; } = 40;
        public static int ShakeDuration { get; set; } = 2000;
        public static double WasteDensity { get; set; } = .05;
        public static bool WasteFatality {  get; set; } = true;
    }
}
