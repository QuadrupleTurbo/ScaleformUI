using CitizenFX.Core.UI;
using System.Drawing;
using Font = CitizenFX.Core.UI.Font;

namespace ScaleformUI
{
    public abstract class TimerBarBase
    {
        public string Label { get; set; }
        public Font LabelFont { get; set; }

        public TimerBarBase(string label, Font font = Font.ChaletLondon)
        {
            Label = label;
            LabelFont = font;
        }

        public virtual void Draw(int interval)
        {
            SizeF resolutionMaintainRatio = ScreenTools.ResolutionMaintainRatio;
            PointF pointF = ScreenTools.SafezoneBounds;
            new UIResText(this.Label, new PointF((float)(int)resolutionMaintainRatio.Width - pointF.X - 180f, (float)(int)resolutionMaintainRatio.Height - pointF.Y - (float)(494 + 4 * interval)), 0.3f, Colors.White, this.LabelFont, Alignment.Right).Draw();
            new Sprite("timerbars", "all_black_bg", new PointF((float)(int)resolutionMaintainRatio.Width - pointF.X - 298f, (float)(int)resolutionMaintainRatio.Height - pointF.Y - (float)(500 + 4 * interval)), new SizeF(300f, 37f), 0f, Color.FromArgb(190, 240, 255, 255)).Draw();
            Screen.Hud.HideComponentThisFrame(HudComponent.AreaName);
            Screen.Hud.HideComponentThisFrame(HudComponent.StreetName);
            Screen.Hud.HideComponentThisFrame(HudComponent.VehicleName);
        }
    }
}
