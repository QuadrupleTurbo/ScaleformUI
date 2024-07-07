﻿
using System.Drawing;
using Font = CitizenFX.Core.UI.Font;

namespace ScaleformUI
{
    public class ProgressTimerBar : TimerBarBase
    {
        /// <summary>
        /// Bar percentage. Goes from 0 to 1.
        /// </summary>
        public float Percentage { get; set; }

        public Color BackgroundColor { get; set; }
        public Color ForegroundColor { get; set; }

        private UIResRectangle _background;
        private UIResRectangle _foreground;

        public ProgressTimerBar(string label)
            : base(label, CitizenFX.Core.UI.Font.ChaletLondon)
        {
            this.BackgroundColor = Colors.DarkRed;
            this.ForegroundColor = Colors.Red;
            this._background = new UIResRectangle(new PointF(0f, 0f), new SizeF(150f, 15f), this.BackgroundColor);
            this._foreground = new UIResRectangle(new PointF(0f, 0f), new SizeF(0f, 15f), this.ForegroundColor);
        }

        public ProgressTimerBar(string label, CitizenFX.Core.UI.Font labelFont)
            : base(label, labelFont)
        {
            this.BackgroundColor = Colors.DarkRed;
            this.ForegroundColor = Colors.Red;
            this._background = new UIResRectangle(new PointF(0f, 0f), new SizeF(150f, 15f), this.BackgroundColor);
            this._foreground = new UIResRectangle(new PointF(0f, 0f), new SizeF(0f, 15f), this.ForegroundColor);
        }

        public ProgressTimerBar(string label, Color background, Color foreground)
            : base(label, CitizenFX.Core.UI.Font.ChaletLondon)
        {
            this.BackgroundColor = background;
            this.ForegroundColor = foreground;
            this._background = new UIResRectangle(new PointF(0f, 0f), new SizeF(150f, 15f), this.BackgroundColor);
            this._foreground = new UIResRectangle(new PointF(0f, 0f), new SizeF(0f, 15f), this.ForegroundColor);
        }

        public ProgressTimerBar(string label, Color background, Color foreground, CitizenFX.Core.UI.Font labelFont)
            : base(label, labelFont)
        {
            this.BackgroundColor = background;
            this.ForegroundColor = foreground;
            this._background = new UIResRectangle(new PointF(0f, 0f), new SizeF(150f, 15f), this.BackgroundColor);
            this._foreground = new UIResRectangle(new PointF(0f, 0f), new SizeF(0f, 15f), this.ForegroundColor);
        }

        public override void Draw(int interval)
        {
            SizeF resolutionMaintainRatio = ScreenTools.ResolutionMaintainRatio;
            PointF pointF = ScreenTools.SafezoneBounds;
            base.Draw(interval);

            var start = new PointF((int)res.Width - safe.X - 160, (int)res.Height - safe.Y - (488 + (4 * interval)));

            _background.Position = start;
            _foreground.Position = start;

            _foreground.Size = new SizeF(150 * Percentage, 15);
            
            // In case someone decides to change colors while drawing..
            _background.Color = BackgroundColor;
            _foreground.Color = ForegroundColor;

            _background.Draw();
            _foreground.Draw();
        }
    }
}
