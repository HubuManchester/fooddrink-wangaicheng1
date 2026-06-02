# Food Explorer 🍔

## 🎓 Academic Metadata
- **Developer Name:** Wang Aicheng
- **Student ID:** 21906388

---

Food Explorer is a .NET MAUI-based "Food and Drink" course project application. The application allows users to log food and drinks, display nutritional summaries, validate user inputs, and demonstrate mobile device hardware capabilities.

## Main Features

- Food and drink list with dynamic search support and item detail pages.
- Add entry form with validation checks for required fields and nutritional values.
- Native camera integration to capture and preview real-time food photography.
- GPS Geolocation services to record dining or purchasing locations.
- Text-to-Speech synthesis to read aloud nutritional summaries and help content.
- Physical vibration and haptic feedback integrations for operational alerts.
- Dynamic support for manually switching themes (Dark/Light mode) and Large Text Mode.
- Complete inclusion of semantic tags, screen reader announcements, and clear validation flags.

## Marking Criteria Coverage

- **UI/UX & Accessibility:** Responsive XAML pages, bottom tab bar navigation, cohesive visual styles, dark mode emulation, semantic descriptions, and screen reader announcements.
- **Mobile Hardware:** Camera integration, Geolocation satellite tracking, Text-to-Speech audio synthesis, physical vibration, and mechanical haptic feedback.
- **Functional Integrity:** Complete operational flow across ledger lists, keyword searching, entry adding, detail views, settings tabs, and hardware demonstration workflows.
- **Validation & Error Handling:** Mandatory entry constraints, numeric value checks, privilege permission errors, and hardware unavailability handling alerts.
- **Code Quality:** Separation of concerns between Models and Services, clear naming conventions, reusable catalog service components, and well-scoped page code-behind files.
- **Deployment:** Cross-platform target compilation supporting both Android and Windows applications via .NET MAUI.
- **GitHub Usage:** Recommendations for continuous commit tracking (e.g., `Add food list`, `Implement hardware page`, `Add input validation`).

## How to Run

Open `FoodDrinkApp.csproj` or `FoodDrinkApp.sln` using Visual Studio 2022 configured with the .NET MAUI workload environment.

Recommended deployment targets:
- Android Emulator
- Windows Machine

Windows Build Command:
```powershell
dotnet build .\FoodDrinkApp.csproj -f net9.0-windows10.0.19041.0
```

Android Build Command:
```powershell
dotnet build .\FoodDrinkApp.csproj -f net9.0-android
```

*Note: This project leverages a structured props redirection script (`Directory.Build.props`) to route intermediate compilation outputs onto `C:\MauiBuild\NutriTrack\`. This effectively avoids the packaging path issues caused by multi-byte or Chinese characters inside the local Android SDK assets toolchains.*

## Screencast Demonstration Checklist

- Articulate the core application concept of "Food Explorer" and its absolute adherence to the "Food and Drink" course theme.
- Demonstrate core functional views: keyword searching, detail records, and adding new item rows.
- Trigger validation constraints: intentionally attempt to submit empty items or illegal numeric entries to show error popups.
- Execute native mobile hardware layers: launch camera photo capture, request GPS satellite coordinates, play Text-to-Speech, and trigger haptic feedback loops.
- Verify user accessibility controls: switch seamlessly between light/dark contrast stylesheets and toggle Large Text Mode to demonstrate cross-page layout reflow.
- Highlight crucial codebase source files: separation of Models and Services, page code-behinds, and platform-specific Android permission descriptors.
- Confirm flawless deployment rendering on both Android and Windows environments.
- Present continuous version control commit histories alongside this comprehensive README overview.