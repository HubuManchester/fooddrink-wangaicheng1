using Microsoft.Maui.Media;
using Microsoft.Maui.Devices.Sensors;

namespace FoodExplorer;

public partial class MainPage : ContentPage
{
    // A list of random food suggestions for the Shake feature
    private readonly string[] randomFoods = { "Pizza 🍕", "Sushi 🍣", "Tacos 🌮", "Burger 🍔", "Salad 🥗", "Pasta 🍝" };

    public MainPage()
    {
        InitializeComponent();

        // Start listening to the Accelerometer for Shake events when the page loads
        if (Accelerometer.Default.IsSupported)
        {
            Accelerometer.Default.ShakeDetected += Accelerometer_ShakeDetected;
            Accelerometer.Default.Start(SensorSpeed.Default);
        }
    }

    // Feature 4: Accelerometer Shake Detection (Hardware criterion - Unique usage)
    private void Accelerometer_ShakeDetected(object sender, EventArgs e)
    {
        // Must run on the Main Thread to update UI
        MainThread.BeginInvokeOnMainThread(async () =>
        {
            Random rnd = new Random();
            int index = rnd.Next(randomFoods.Length);
            string suggestion = randomFoods[index];

            await DisplayAlert("Food Suggestion!", $"How about trying some {suggestion}?", "Yum!");
        });
    }

    // Stop listening when the page is closed to save battery
    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        if (Accelerometer.Default.IsSupported && Accelerometer.Default.IsMonitoring)
        {
            Accelerometer.Default.ShakeDetected -= Accelerometer_ShakeDetected;
            Accelerometer.Default.Stop();
        }
    }

    // Feature 1: Camera Integration
    private async void OnCameraBtnClicked(object sender, EventArgs e)
    {
        try
        {
            if (MediaPicker.Default.IsCaptureSupported)
            {
                FileResult photo = await MediaPicker.Default.CapturePhotoAsync();
                if (photo != null)
                {
                    await DisplayAlert("Success", $"Photo captured: {photo.FileName}", "OK");
                }
            }
            else
            {
                await DisplayAlert("Not Supported", "Your device does not support camera capture.", "OK");
            }
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", $"Unable to open camera: {ex.Message}", "Close");
        }
    }

    // Feature 2: Geolocation Integration
    private async void OnLocationBtnClicked(object sender, EventArgs e)
    {
        try
        {
            Location location = await Geolocation.Default.GetLastKnownLocationAsync();
            if (location != null)
            {
                await DisplayAlert("Current Location", $"Latitude: {location.Latitude}\nLongitude: {location.Longitude}", "Great");
            }
            else
            {
                await DisplayAlert("Notice", "Cannot determine location. Please check your GPS.", "OK");
            }
        }
        catch (FeatureNotSupportedException)
        {
            await DisplayAlert("Error", "This device does not support geolocation.", "Close");
        }
        catch (PermissionException)
        {
            await DisplayAlert("Permission Denied", "Please allow location permissions in your device settings.", "Close");
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", $"Failed to get location: {ex.Message}", "Close");
        }
    }

    // Feature 3: Text-to-Speech & Validation
    private async void OnSpeakBtnClicked(object sender, EventArgs e)
    {
        string textToRead = FoodNoteEntry.Text;

        if (string.IsNullOrWhiteSpace(textToRead))
        {
            await DisplayAlert("Validation Error", "Please enter some text before reading aloud. Do not leave the box blank.", "OK");
            return;
        }

        try
        {
            await TextToSpeech.Default.SpeakAsync(textToRead);
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", $"Text-to-speech failed: {ex.Message}", "Close");
        }
    }
}