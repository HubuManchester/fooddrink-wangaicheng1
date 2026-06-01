using FoodDrinkApp.Services;

namespace FoodDrinkApp;

public partial class SettingsPage : ContentPage
{
    public SettingsPage()
    {
        InitializeComponent();
        ThemePicker.SelectedIndex = 0;
        LargeTextSwitch.IsToggled = AccessibilityService.LargeTextEnabled;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        LargeTextSwitch.IsToggled = AccessibilityService.LargeTextEnabled;
        ApplyLargeTextState();
    }

    private void OnThemeChanged(object? sender, EventArgs e)
    {
        if (Application.Current is null) return;

        // Dynamic resource map updates according to MMU accessibility assessment requirements
        Application.Current.UserAppTheme = ThemePicker.SelectedIndex switch
        {
            1 => AppTheme.Light,
            2 => AppTheme.Dark,
            _ => AppTheme.Unspecified
        };

        Announce("Theme configuration altered. Resource layout updated.");
    }

    private void OnLargeTextToggled(object? sender, ToggledEventArgs e)
    {
        AccessibilityService.LargeTextEnabled = e.Value;
        ApplyLargeTextState();

        Announce(e.Value
            ? "Large text mode activated. UI components scaling factor expanded."
            : "Large text mode terminated. UI viewport scaled back to basic bounds.");
    }

    private void ApplyLargeTextState()
    {
        // Invoke service-layer iteration code to safely scale all targeted text boundaries
        AccessibilityService.ApplyFontScale(this);

        LargeTextPreviewTitle.Text = AccessibilityService.LargeTextEnabled
            ? "Dynamic Viewport State: Enlarged Scaling"
            : "Dynamic Viewport State: Normal Bounds";

        LargeTextPreviewBody.Text = AccessibilityService.LargeTextEnabled
            ? "Structural text blocks are successfully modified. Main ledger lists and hardware page elements inherit this state automatically."
            : "Toggle the configuration switch matrix to verify on-screen visual scale expansion patterns.";
    }

    private void Announce(string message)
    {
        SettingsStatusLabel.Text = message;

        // Satisfying Screen Reader narration rules using native API announcer layers
        SemanticScreenReader.Announce(message);
    }
}