﻿using SimpleWeather.Icons;
using System;
using System.Linq;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Documents;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace SimpleWeather.UWP.Preferences
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Settings_Credits : Page
    {
        public Settings_Credits()
        {
            this.InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            IconCreditsContainer.Children.Clear();

            var providers = SimpleLibrary.GetInstance().GetIconProviders().Values
                .Cast<WeatherIconProvider>();

            foreach (var provider in providers)
            {
                var textBlock = new RichTextBlock()
                {
                    FontSize = 16,
                    Padding = new Windows.UI.Xaml.Thickness(0, 10, 0, 10),
                    HorizontalAlignment = Windows.UI.Xaml.HorizontalAlignment.Left
                };

                var title = new Paragraph();
                title.Inlines.Add(new Run()
                {
                    Text = provider.DisplayName
                });
                var subtitle = new Paragraph() { FontSize = 13 };
                if (provider.AttributionLink != null)
                {
                    var link = new Hyperlink()
                    {
                        NavigateUri = provider.AttributionLink,
                    };
                    link.Inlines.Add(new Run()
                    {
                        Text = provider.AuthorName
                    });
                    subtitle.Inlines.Add(link);
                }
                else
                {
                    subtitle.Inlines.Add(new Run()
                    {
                        Text = provider.AuthorName
                    });
                }

                textBlock.Blocks.Add(title);
                textBlock.Blocks.Add(subtitle);

                IconCreditsContainer.Children.Add(textBlock);
            }
        }
    }
}
