using SimpleWeather.Controls;
using SimpleWeather.Location;
using SimpleWeather.Utils;
using SimpleWeather.UWP.Controls;
using SimpleWeather.UWP.Helpers;
using SimpleWeather.WeatherData;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace SimpleWeather.UWP.Main
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LocationSearchPage : CustomPage, IBackRequestedPage, IDisposable
    {
        private CancellationTokenSource cts = new CancellationTokenSource();
        private WeatherManager wm;
        public ObservableCollection<LocationQueryViewModel> LocationQuerys { get; private set; }
        private ProgressRing LoadingRing { get { return Location?.ProgressRing; } }

        public LocationSearchPage()
        {
            this.InitializeComponent();

            wm = WeatherManager.GetInstance();

            LocationQuerys = new ObservableCollection<LocationQueryViewModel>();

            // CommandBar
            CommandBarLabel = App.ResLoader.GetString("Nav_Locations/Label");
            PrimaryCommands = new List<ICommandBarElement>(0);
        }

        public Task<bool> OnBackRequested()
        {
            if (Frame.CanGoBack) Frame.GoBack(); else Frame.Navigate(typeof(LocationsPage));

            var tcs = new TaskCompletionSource<bool>();
            tcs.SetResult(true);

            return tcs.Task;
        }

        public void Dispose()
        {
            cts?.Dispose();
        }

        private DispatcherTimer timer;

        private void EnableControls(bool enable)
        {
            if (LoadingRing != null)
                LoadingRing.IsActive = !enable;
        }

        private void Location_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            // user is typing: reset already started timer (if existing)
            if (timer != null && timer.IsEnabled)
                timer.Stop();

            if (String.IsNullOrWhiteSpace(sender.Text))
            {
                // Cancel pending searches
                cts?.Cancel();
                cts = new CancellationTokenSource();
                // Hide flyout if query is empty or null
                LocationQuerys.Clear();
                sender.IsSuggestionListOpen = false;
            }
            else
            {
                timer = new DispatcherTimer()
                {
                    Interval = TimeSpan.FromMilliseconds(1000)
                };
                timer.Tick += async (t, e) =>
                {
                    if (!String.IsNullOrWhiteSpace(sender.Text) && args.Reason == AutoSuggestionBoxTextChangeReason.UserInput)
                    {
                        String query = sender.Text;

                        // Cancel pending searches
                        cts?.Cancel();
                        cts = new CancellationTokenSource();
                        var ctsToken = cts.Token;

                        await Task.Run(async () =>
                        {
                            if (ctsToken.IsCancellationRequested) return;

                            ObservableCollection<LocationQueryViewModel> results;

                            try
                            {
                                results = await AsyncTask.RunAsync(wm.GetLocations(query));
                            }
                            catch (WeatherException ex)
                            {
                                await AsyncTask.RunOnUIThread(() =>
                                {
                                    ShowSnackbar(Snackbar.Make(ex.Message, SnackbarDuration.Short));
                                }).ConfigureAwait(false);
                                results = new ObservableCollection<LocationQueryViewModel>() { new LocationQueryViewModel() };
                            }

                            if (ctsToken.IsCancellationRequested) return;

                            // Refresh list
                            await AsyncTask.RunOnUIThread(() =>
                            {
                                LocationQuerys = results;
                                sender.ItemsSource = null;
                                sender.ItemsSource = LocationQuerys;
                                sender.IsSuggestionListOpen = true;
                            }).ConfigureAwait(false);
                        }).ConfigureAwait(true);
                    }
                    else if (String.IsNullOrWhiteSpace(sender.Text))
                    {
                        // Cancel pending searches
                        cts?.Cancel();
                        cts = new CancellationTokenSource();
                        // Hide flyout if query is empty or null
                        await AsyncTask.RunOnUIThread(() =>
                        {
                            LocationQuerys.Clear();
                            sender.IsSuggestionListOpen = false;
                        }).ConfigureAwait(true);
                    }

                    timer.Stop();
                };
                timer.Start();
            }
        }

        private void Location_SuggestionChosen(AutoSuggestBox sender, AutoSuggestBoxSuggestionChosenEventArgs args)
        {
            if (args.SelectedItem is LocationQueryViewModel theChosenOne)
            {
                if (String.IsNullOrEmpty(theChosenOne.LocationQuery))
                    sender.Text = String.Empty;
                else
                    sender.Text = theChosenOne.LocationName;
            }

            sender.IsSuggestionListOpen = false;
        }

        private async void Location_QuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
        {
            LocationQueryViewModel query_vm = null;

            if (args.ChosenSuggestion != null)
            {
                // User selected an item from the suggestion list, take an action on it here.
                var theChosenOne = args.ChosenSuggestion as LocationQueryViewModel;

                if (!String.IsNullOrEmpty(theChosenOne.LocationQuery))
                    query_vm = theChosenOne;
                else
                    query_vm = new LocationQueryViewModel();
            }
            else if (!String.IsNullOrEmpty(args.QueryText))
            {
                // Use args.QueryText to determine what to do.
                var queryText = args.QueryText;
                query_vm = await Task.Run(async () =>
                {
                    ObservableCollection<LocationQueryViewModel> results;

                    try
                    {
                        results = await AsyncTask.RunAsync(wm.GetLocations(queryText));
                    }
                    catch (WeatherException ex)
                    {
                        await AsyncTask.RunOnUIThread(() =>
                        {
                            ShowSnackbar(Snackbar.Make(ex.Message, SnackbarDuration.Short));
                        }).ConfigureAwait(false);
                        results = new ObservableCollection<LocationQueryViewModel>() { new LocationQueryViewModel() };
                    }

                    var result = results.FirstOrDefault();
                    if (result != null && !String.IsNullOrWhiteSpace(result.LocationQuery))
                    {
                        await AsyncTask.RunOnUIThread(() =>
                        {
                            sender.Text = result.LocationName;
                        }).ConfigureAwait(false);
                        return result;
                    }
                    else
                    {
                        return new LocationQueryViewModel();
                    }
                }).ConfigureAwait(true);
            }
            else if (String.IsNullOrWhiteSpace(args.QueryText))
            {
                // Stop since there is no valid query
                return;
            }

            if (String.IsNullOrWhiteSpace(query_vm.LocationQuery))
            {
                // Stop since there is no valid query
                return;
            }

            // Cancel other tasks
            cts?.Cancel();
            cts = new CancellationTokenSource();
            var ctsToken = cts.Token;

            await AsyncTask.RunOnUIThread(() =>
            {
                EnableControls(false);
            }).ConfigureAwait(false);

            if (ctsToken.IsCancellationRequested)
            {
                await AsyncTask.RunOnUIThread(() =>
                {
                    EnableControls(true);
                }).ConfigureAwait(false);
                return;
            }

            String country_code = query_vm?.LocationCountry;
            if (!String.IsNullOrWhiteSpace(country_code))
                country_code = country_code.ToLower();

            if (WeatherAPI.NWS.Equals(Settings.API) && !("usa".Equals(country_code) || "us".Equals(country_code)))
            {
                await AsyncTask.RunOnUIThread(() =>
                {
                    ShowSnackbar(Snackbar.Make(App.ResLoader.GetString("Error_WeatherUSOnly"), SnackbarDuration.Short));
                    EnableControls(true);
                }).ConfigureAwait(false);
                return;
            }

            // Need to get FULL location data for HERE API
            // Data provided is incomplete
            if (WeatherAPI.Here.Equals(query_vm.LocationSource)
                    && query_vm.LocationLat == -1 && query_vm.LocationLong == -1
                    && query_vm.LocationTZLong == null)
            {
                try
                {
                    query_vm = await AsyncTask.RunAsync(
                        new HERE.HERELocationProvider().GetLocationFromLocID(query_vm.LocationQuery, query_vm.WeatherSource));
                }
                catch (WeatherException ex)
                {
                    await AsyncTask.RunOnUIThread(() =>
                    {
                        ShowSnackbar(Snackbar.Make(ex.Message, SnackbarDuration.Short));
                        EnableControls(true);
                    }).ConfigureAwait(false);
                    return;
                }
            }
            else if (WeatherAPI.BingMaps.Equals(query_vm.LocationSource)
                    && query_vm.LocationLat == -1 && query_vm.LocationLong == -1
                    && query_vm.LocationTZLong == null)
            {
                try
                {
                    query_vm = await AsyncTask.RunAsync(
                        new Bing.BingMapsLocationProvider().GetLocationFromAddress(query_vm.LocationQuery, query_vm.WeatherSource));
                }
                catch (WeatherException ex)
                {
                    await AsyncTask.RunOnUIThread(() =>
                    {
                        ShowSnackbar(Snackbar.Make(ex.Message, SnackbarDuration.Short));
                        EnableControls(true);
                    }).ConfigureAwait(false);
                    return;
                }
            }

            // Check if location already exists
            var locData = await Settings.GetLocationData();
            if (locData.Any(l => l.query == query_vm.LocationQuery))
            {
                await AsyncTask.RunOnUIThread(() =>
                {
                    if (Frame.CanGoBack) Frame.GoBack(); else Frame.Navigate(typeof(LocationsPage));
                }).ConfigureAwait(false);
                return;
            }

            if (ctsToken.IsCancellationRequested)
            {
                await AsyncTask.RunOnUIThread(() =>
                {
                    EnableControls(true);
                }).ConfigureAwait(false);
                return;
            }

            var location = new LocationData(query_vm);
            if (!location.IsValid())
            {
                await AsyncTask.RunOnUIThread(() =>
                {
                    ShowSnackbar(Snackbar.Make(App.ResLoader.GetString("WError_NoWeather"), SnackbarDuration.Short));
                    EnableControls(true);
                }).ConfigureAwait(false);
                return;
            }
            var weather = await Settings.GetWeatherData(location.query);
            if (weather == null)
            {
                try
                {
                    weather = await AsyncTask.RunAsync(wm.GetWeather(location));
                }
                catch (WeatherException wEx)
                {
                    weather = null;
                    await AsyncTask.RunOnUIThread(() =>
                    {
                        ShowSnackbar(Snackbar.Make(wEx.Message, SnackbarDuration.Short));
                    }).ConfigureAwait(false);
                }
            }

            if (weather == null)
            {
                await AsyncTask.RunOnUIThread(() =>
                {
                    EnableControls(true);
                }).ConfigureAwait(false);
                return;
            }

            // We got our data so disable controls just in case
            await AsyncTask.RunOnUIThread(() =>
            {
                sender.IsSuggestionListOpen = false;
            }).ConfigureAwait(false);

            // Save data
            await Settings.AddLocation(location);
            if (wm.SupportsAlerts && weather.weather_alerts != null)
                await Settings.SaveWeatherAlerts(location, weather.weather_alerts);
            await Settings.SaveWeatherData(weather);
            await Settings.SaveWeatherForecasts(new Forecasts(weather.query, weather.forecast, weather.txt_forecast));
            await Settings.SaveWeatherForecasts(location, weather.hr_forecast == null ? null :
                weather.hr_forecast.Select(f => new HourlyForecasts(weather.query, f)));

            var panelView = new LocationPanelViewModel(weather)
            {
                LocationData = location
            };

            // Hide add locations panel
            await AsyncTask.RunOnUIThread(() =>
            {
                EnableControls(true);
                if (Frame.CanGoBack) Frame.GoBack(); else Frame.Navigate(typeof(LocationsPage));
            }).ConfigureAwait(false);
        }
    }
}