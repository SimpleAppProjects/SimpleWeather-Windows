using SimpleWeather.Controls;
using SimpleWeather.Location;
using SimpleWeather.Utils;
using SimpleWeather.UWP.Controls;
using SimpleWeather.UWP.Helpers;
using SimpleWeather.WeatherData;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409
namespace SimpleWeather.UWP.Setup
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SetupLocationsPage : Page, IDisposable, IPageVerification, ISnackbarManager
    {
        private CancellationTokenSource cts = new CancellationTokenSource();

        private WeatherManager wm;

        public ObservableCollection<LocationQueryViewModel> LocationQuerys { get; set; }

        public SetupLocationsPage()
        {
            this.InitializeComponent();

            this.SizeChanged += SetupPage_SizeChanged;

            wm = WeatherManager.GetInstance();

            // Views
            LocationQuerys = new ObservableCollection<LocationQueryViewModel>();
        }

        private SnackbarManager SnackMgr;

        public void InitSnackManager()
        {
            if (SnackMgr == null)
            {
                SnackMgr = new SnackbarManager(Content as Panel);
            }
        }

        public void ShowSnackbar(Snackbar snackbar)
        {
            SnackMgr?.Show(snackbar);
        }

        public void DismissAllSnackbars()
        {
            SnackMgr?.DismissAll();
        }

        public void UnloadSnackManager()
        {
            DismissAllSnackbars();
            SnackMgr = null;
        }

        private void SetupPage_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            ResizeControls();
        }

        private void ResizeControls()
        {
            if (MainPanel != null)
            {
                if (this.ActualWidth > 640)
                    Location.Width = ActualWidth / 2;
                else
                    Location.Width = double.NaN;

                if (this.ActualHeight > 480)
                    AppLogo.Height = 150;
                else
                    AppLogo.Height = 100;
            }
        }

        public void Dispose()
        {
            cts.Dispose();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            InitSnackManager();
            Restore();
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            base.OnNavigatedFrom(e);
            UnloadSnackManager();
        }

        private DispatcherTimer timer;

        private void Location_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            // user is typing: reset already started timer (if existing)
            if (timer != null && timer.IsEnabled)
                timer.Stop();

            if (String.IsNullOrEmpty(sender.Text))
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
                var queryText = args.QueryText;
                if (cts.Token.IsCancellationRequested)
                {
                    EnableControls(true);
                    return;
                }

                // Use args.QueryText to determine what to do.
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

                    if (cts.Token.IsCancellationRequested)
                    {
                        await AsyncTask.RunOnUIThread(() =>
                        {
                            EnableControls(true);
                        }).ConfigureAwait(false);
                        return new LocationQueryViewModel();
                    }

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
                }, cts.Token).ConfigureAwait(true);
            }
            else if (String.IsNullOrWhiteSpace(args.QueryText))
            {
                // Stop since there is no valid query
                return;
            }

            if (String.IsNullOrWhiteSpace(query_vm?.LocationQuery))
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
                LoadingRing.IsActive = true;
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

            // Weather Data
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

            if (ctsToken.IsCancellationRequested)
            {
                await AsyncTask.RunOnUIThread(() =>
                {
                    EnableControls(true);
                }).ConfigureAwait(false);
                return;
            }

            Weather weather = await Settings.GetWeatherData(location.query);
            if (weather == null)
            {
                if (ctsToken.IsCancellationRequested)
                {
                    await AsyncTask.RunOnUIThread(() =>
                    {
                        EnableControls(true);
                    }).ConfigureAwait(false);
                    return;
                }

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

            if (ctsToken.IsCancellationRequested)
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
                EnableControls(false);
                sender.IsSuggestionListOpen = false;
            }).ConfigureAwait(false);

            // Save weather data
            await Settings.DeleteLocations();
            await Settings.AddLocation(location);
            if (wm.SupportsAlerts && weather.weather_alerts != null)
                await Settings.SaveWeatherAlerts(location, weather.weather_alerts);
            await Settings.SaveWeatherData(weather);
            await Settings.SaveWeatherForecasts(new Forecasts(weather.query, weather.forecast, weather.txt_forecast));
            await Settings.SaveWeatherForecasts(location, weather.hr_forecast == null ? null :
                weather.hr_forecast.Select(f => new HourlyForecasts(weather.query, f)));

            // If we're using search
            // make sure gps feature is off
            Settings.FollowGPS = false;
            Settings.WeatherLoaded = true;

            await AsyncTask.RunOnUIThread(() =>
            {
                SetupPage.Instance.Location = location;
                SetupPage.Instance.Next();
            }).ConfigureAwait(false);
        }

        private void EnableControls(bool Enable)
        {
            Location.IsEnabled = Enable;
            GPSButton.IsEnabled = Enable;
            LoadingRing.IsActive = !Enable;
        }

        private void Restore()
        {
            var mainPanel = FindName(nameof(MainPanel)) as FrameworkElement;
            mainPanel.Visibility = Visibility.Visible;

            // Sizing
            ResizeControls();

            // Set HERE as default API
            Settings.API = WeatherAPI.Here;
            wm.UpdateAPI();

            if (String.IsNullOrWhiteSpace(wm.GetAPIKey()))
            {
                // If (internal) key doesn't exist, fallback to Yahoo
                Settings.API = WeatherAPI.Yahoo;
                wm.UpdateAPI();
                Settings.UsePersonalKey = true;
                Settings.KeyVerified = false;
            }
            else
            {
                // If key exists, go ahead
                Settings.UsePersonalKey = false;
                Settings.KeyVerified = true;
            }
        }

        private async void GPS_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Button button = sender as Button;
                button.IsEnabled = false;
                LoadingRing.IsActive = true;

                // Cancel other tasks
                cts?.Cancel();
                cts = new CancellationTokenSource();
                var ctsToken = cts.Token;

                ctsToken.ThrowIfCancellationRequested();

                var geoStatus = GeolocationAccessStatus.Unspecified;

                try
                {
                    // Catch error in case dialog is dismissed
                    geoStatus = await Geolocator.RequestAccessAsync();
                }
                catch (Exception ex)
                {
                    Logger.WriteLine(LoggerLevel.Error, ex, "SetupPage: error requesting location permission");
                    System.Diagnostics.Debug.WriteLine(ex.StackTrace);
                }

                ctsToken.ThrowIfCancellationRequested();

                Geolocator geolocal = new Geolocator() { DesiredAccuracyInMeters = 5000, ReportInterval = 900000, MovementThreshold = 1600 };
                Geoposition geoPos = null;

                switch (geoStatus)
                {
                    case GeolocationAccessStatus.Allowed:
                        try
                        {
                            geoPos = await geolocal.GetGeopositionAsync(TimeSpan.FromMinutes(15), TimeSpan.FromSeconds(10));
                        }
                        catch (Exception ex)
                        {
                            Logger.WriteLine(LoggerLevel.Error, ex, "SetupPage: error getting geolocation");

                            await AsyncTask.RunOnUIThread(() =>
                            {
                                if (Windows.Web.WebError.GetStatus(ex.HResult) > Windows.Web.WebErrorStatus.Unknown)
                                    ShowSnackbar(Snackbar.Make(App.ResLoader.GetString("WError_NetworkError"), SnackbarDuration.Short));
                                else
                                    ShowSnackbar(Snackbar.Make(App.ResLoader.GetString("Error_Location"), SnackbarDuration.Short));
                            }).ConfigureAwait(true);
                        }
                        break;

                    case GeolocationAccessStatus.Denied:
                        await AsyncTask.RunOnUIThread(() =>
                        {
                            var snackbar = Snackbar.Make(App.ResLoader.GetString("Msg_LocDeniedSettings"), SnackbarDuration.Long);
                            snackbar.SetAction(App.ResLoader.GetString("Label_Settings"), async () =>
                            {
                                await Windows.System.Launcher.LaunchUriAsync(new Uri("ms-settings:privacy-location"));
                            });
                            ShowSnackbar(snackbar);
                            Settings.FollowGPS = false;
                        }).ConfigureAwait(true);
                        break;

                    case GeolocationAccessStatus.Unspecified:
                    default:
                        await AsyncTask.RunOnUIThread(() =>
                        {
                            ShowSnackbar(Snackbar.Make(App.ResLoader.GetString("Error_Location"), SnackbarDuration.Short));
                            Settings.FollowGPS = false;
                        }).ConfigureAwait(true);
                        break;
                }

                // Access to location granted
                if (geoPos != null)
                {
                    LocationQueryViewModel view = null;

                    ctsToken.ThrowIfCancellationRequested();

                    await AsyncTask.RunOnUIThread(() =>
                    {
                        button.IsEnabled = false;
                    }).ConfigureAwait(false);

                    await Task.Run(async () =>
                    {
                        ctsToken.ThrowIfCancellationRequested();

                        try
                        {
                            view = await AsyncTask.RunAsync(wm.GetLocation(geoPos));

                            if (String.IsNullOrEmpty(view.LocationQuery))
                                view = new LocationQueryViewModel();
                        }
                        catch (WeatherException wEx)
                        {
                            view = new LocationQueryViewModel();
                            await AsyncTask.RunOnUIThread(() =>
                            {
                                ShowSnackbar(Snackbar.Make(wEx.Message, SnackbarDuration.Short));
                            }).ConfigureAwait(false);
                        }
                    }).ConfigureAwait(false);

                    if (String.IsNullOrWhiteSpace(view.LocationQuery))
                    {
                        // Stop since there is no valid query
                        await AsyncTask.RunOnUIThread(() =>
                        {
                            EnableControls(true);
                        }).ConfigureAwait(false);
                        return;
                    }

                    ctsToken.ThrowIfCancellationRequested();

                    String country_code = view?.LocationCountry;
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

                    // Weather Data
                    var location = new LocationData(view, geoPos);
                    if (!location.IsValid())
                    {
                        await AsyncTask.RunOnUIThread(() =>
                        {
                            ShowSnackbar(Snackbar.Make(App.ResLoader.GetString("WError_NoWeather"), SnackbarDuration.Short));
                            EnableControls(true);
                        }).ConfigureAwait(false);
                        return;
                    }

                    ctsToken.ThrowIfCancellationRequested();

                    Weather weather = await Settings.GetWeatherData(location.query);
                    if (weather == null)
                    {
                        ctsToken.ThrowIfCancellationRequested();

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

                    ctsToken.ThrowIfCancellationRequested();

                    // We got our data so disable controls just in case
                    await AsyncTask.RunOnUIThread(() =>
                    {
                        EnableControls(false);
                    }).ConfigureAwait(false);

                    // Save weather data
                    Settings.SaveLastGPSLocData(location);
                    await Settings.DeleteLocations();
                    await Settings.AddLocation(new LocationData(view));
                    if (wm.SupportsAlerts && weather.weather_alerts != null)
                        await Settings.SaveWeatherAlerts(location, weather.weather_alerts);
                    await Settings.SaveWeatherData(weather);
                    await Settings.SaveWeatherForecasts(new Forecasts(weather.query, weather.forecast, weather.txt_forecast));
                    await Settings.SaveWeatherForecasts(location, weather.hr_forecast == null ? null :
                        weather.hr_forecast.Select(f => new HourlyForecasts(weather.query, f)));

                    Settings.FollowGPS = true;
                    Settings.WeatherLoaded = true;

                    await AsyncTask.RunOnUIThread(() =>
                    {
                        SetupPage.Instance.Location = location;
                        SetupPage.Instance.Next();
                    }).ConfigureAwait(false);
                }
                else
                {
                    await AsyncTask.RunOnUIThread(() =>
                    {
                        EnableControls(true);
                    }).ConfigureAwait(false);
                }
            }
            catch (OperationCanceledException)
            {
                // Restore controls
                await AsyncTask.RunOnUIThread(() =>
                {
                    EnableControls(true);
                }).ConfigureAwait(false);
                Settings.FollowGPS = false;
                Settings.WeatherLoaded = false;
            }
        }

        public bool CanContinue()
        {
            return SetupPage.Instance.Location != null && SetupPage.Instance.Location.IsValid();
        }
    }
}