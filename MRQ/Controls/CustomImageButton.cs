using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;

namespace MRQ.Controls
{
    public class CustomImageButton : ImageButton
    {
        public CustomImageButton()
        {
            Pressed += OnPressed;
            Released += OnReleased;
        }

        private async void OnPressed(object? sender, EventArgs e) // Mark `sender` as nullable
        {
            if (sender is ImageButton button)
            {
                await button.ScaleTo(0.8, 50, Easing.CubicOut);
            }
        }

        private async void OnReleased(object? sender, EventArgs e) // Mark `sender` as nullable
        {
            if (sender is ImageButton button)
            {
                await button.ScaleTo(1.0, 50, Easing.CubicIn);
            }
        }
    }
}
