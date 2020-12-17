﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace SimpleWeather.UWP.Radar
{
    public sealed partial class RadarToolbar : UserControl
    {
        public RadarToolbar()
        {
            this.InitializeComponent();
        }

        private void PlayButton_Checked(object sender, RoutedEventArgs e)
        {
            var button = sender as ToggleButton;
            button.Content = new SymbolIcon(Symbol.Pause);
            OnPlayAnimation?.Invoke(this, EventArgs.Empty);
        }

        private void PlayButton_Unchecked(object sender, RoutedEventArgs e)
        {
            var button = sender as ToggleButton;
            button.Content = new SymbolIcon(Symbol.Play);
            OnPauseAnimation?.Invoke(this, EventArgs.Empty);
        }

        public UIElement MapContainerChild
        {
            get { return MapContainer.Child; }
            set { MapContainer.Child = value; }
        }

        public Visibility ToolbarVisibility
        {
            get { return AnimationToolbar.Visibility; }
            set { AnimationToolbar.Visibility = value; }
        }

        public event EventHandler OnPlayAnimation;
        public event EventHandler OnPauseAnimation;

        public event RangeBaseValueChangedEventHandler OnSliderValueChanged;

        public void UpdateSeekbarRange(int minimumPosition, int maxPosition)
        {
            AnimationSlider.Maximum = Math.Max(maxPosition, 1);
            AnimationSlider.TickFrequency = 1;
            AnimationSlider.TickPlacement = TickPlacement.Inline;
            AnimationSlider.Minimum = minimumPosition;
        }

        public void UpdateTimestamp(int position, long timestamp)
        {
            AnimationSlider.Value = position;

            var dateTime = DateTimeOffset.FromUnixTimeSeconds(timestamp).ToLocalTime();
            TimestampBlock.Text = string.Format("{0} {1}", dateTime.ToString("ddd"), dateTime.ToString("t"));
        }

        private void AnimationSlider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            OnSliderValueChanged?.Invoke(sender, e);
        }
    }
}
