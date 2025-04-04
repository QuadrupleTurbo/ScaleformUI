﻿using ScaleformUI.Elements;

namespace ScaleformUI.Menu
{
    public delegate void StatChanged(int value);
    public class UIMenuStatsItem : UIMenuItem
    {
        private int _value;

        public int Value
        {
            get => _value;
            set
            {
                _value = value;
                SetValue(_value);
            }
        }
        public int Type { get; private set; }
        private SColor sliderColor;
        public SColor SliderColor
        {
            get => sliderColor;
            set
            {
                sliderColor = value;
            }
        }

        public event StatChanged OnStatChanged;

        public UIMenuStatsItem(string text) : this(text, "", 0, SColor.HUD_Freemode)
        {
        }

        public UIMenuStatsItem(string text, string subtitle, int value, SColor color) : base(text, subtitle)
        {
            _itemId = 5;
            Type = 0;
            _value = value;
            sliderColor = color;
        }

        public void SetValue(int value)
        {
            if (Parent != null && Parent.Visible)
                Parent.SendItemToScaleform(Parent.MenuItems.IndexOf(this), true);
            OnStatChanged?.Invoke(value);
        }

        public override void SetLeftBadge(BadgeIcon badge)
        {
            throw new Exception("UIMenuStatsItem cannot have a left badge.");
        }
        public override void SetRightBadge(BadgeIcon badge)
        {
            throw new Exception("UIMenuStatsItem cannot have a right badge.");
        }
        public override void SetRightLabel(string text)
        {
            throw new Exception("UIMenuStatsItem cannot have a right label.");
        }
    }
}
