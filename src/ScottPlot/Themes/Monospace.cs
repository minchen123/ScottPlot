﻿using System.Drawing;

namespace ScottPlot.Themes
{
    public class Monospace : Default
    {
        public override string TitleFontName => Drawing.InstalledFont.Monospace();
        public override string AxisLabelFontName => Drawing.InstalledFont.Monospace();
        public override string TickLabelFontName => Drawing.InstalledFont.Monospace();
    }
}
