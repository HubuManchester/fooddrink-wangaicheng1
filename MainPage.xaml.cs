using Microsoft.Maui.Media;
using Microsoft.Maui.Devices.Sensors;

namespace FoodExplorer;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    // Feature 1: Camera Integration (Hardware criterion)
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
            // Validation & Error Handling
            await DisplayAlert("Error", $"Unable to open camera: {ex.Message}", "Close");
        }
    }

    // Feature 2: Geolocation Integration (Hardware criterion)
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
}