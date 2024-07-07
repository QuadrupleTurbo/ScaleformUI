using CitizenFX.Core.UI;
using System.Drawing;
using Font = CitizenFX.Core.UI.Font;

namespace ScaleformUI
{
    public class TextTimerBar : TimerBarBase
    {
        public string Caption { get; set; }
        public Color CaptionColor { get; set; } = Colors.White;
        public Font CaptionFont { get; set; } = Font.ChaletLondon;
        public bool Enabled;
        public TextTimerBar(string label, string text) : base(label)
        {
            Caption = text;
        }
        public TextTimerBar(string label, string text, Font labelFont) : base(label, labelFont)
        {
            Caption = text;
        }
        public TextTimerBar(string label, string text, Font labelFont, Font captionFont) : base(label, labelFont)
        {
            Caption = text;
            CaptionFont = captionFont;
        }
        public TextTimerBar(string label, string text, Color captionColor) : base(label)
        {
            Caption = text;
            CaptionColor = captionColor;
        }
        public TextTimerBar(string label, string text, Color captionColor, Font labelFont) : base(label, labelFont)
        {
            Caption = text;
            CaptionColor = captionColor;
        }
        public TextTimerBar(string label, string text, Color captionColor, Font labelFont, Font captionFont) : base(label, labelFont)
        {
            Caption = text;
            CaptionColor = captionColor;
            CaptionFont = captionFont;
        }

        public override void Draw(int interval)
        {
            SizeF resolutionMaintainRatio = ScreenTools.ResolutionMaintainRatio;
            PointF pointF = ScreenTools.SafezoneBounds;
            base.Draw(interval);
            new UIResText(this.Caption, new PointF((float)(int)resolutionMaintainRatio.Width - pointF.X - 160f, (float)(int)resolutionMaintainRatio.Height - pointF.Y - (float)(502 + 4 * interval)), 0.5f, this.CaptionColor, base.LabelFont, Alignment.Left).Draw();
        }
    }
}
