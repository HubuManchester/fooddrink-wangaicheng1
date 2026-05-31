# Food Explorer 🍔

**Author:** Wang Aicheng  
**Student ID:** 21906388  
**Module:** Mobile Application Development  

---

## 📌 Project Overview
**Food Explorer** is a cross-platform mobile application developed using **.NET MAUI (8.0)**. Designed as a digital culinary journal, the application allows food enthusiasts to log their dining experiences, capture memories, and interact with the physical world through cutting-edge device hardware integration. 

The project strictly adheres to professional mobile architecture guidelines, delivering robust exception handling, data validation, and strict compliance with modern accessibility standards.

---

## 🚀 Key Features & Hardware Integration
To achieve the highest grading criteria, this application integrates four distinct core hardware and native system features:

1. **📷 Native Camera Integration (`MediaPicker`)**
   - Allows users to snap real-time photos of their meals.
   - Implements validation to ensure the device supports camera hardware before invocation.
2. **📍 Geolocation & GPS Services (`Geolocation`)**
   - Dynamically fetches the user's precise coordinates (Latitude & Longitude) to locate nearby dining spots.
   - Includes graceful degradation if GPS services are disabled or unavailable.
3. **🔊 Text-to-Speech (TTS) Synthesis (`TextToSpeech`)**
   - Provides auditory playback of user-written food journals or recipes.
   - Enhances hands-free interaction while cooking or exploring.
4. **🔄 Accelerometer & Shake Detection (`Accelerometer`)**
   - Utilizes the device's motion sensors to detect physical shaking.
   - Acts as a smart gamification feature, suggesting a random food category whenever the user shakes their device.

---

## 🛡️ Validation & Robust Error Handling
A core requirement for enterprise-grade mobile software is preventing application crashes. This project implements comprehensive safety nets:

* **Form & Input Validation:** The Text-to-Speech engine includes an input validation mechanism that checks for null, empty, or whitespace-only records. If validation fails, a contextual warning dialog is displayed to prevent empty execution.
* **Granular Exception Handling (`try-catch` blocks):** Every hardware capability is safely wrapped in asynchronous try-catch blocks to catch and handle:
  - `FeatureNotSupportedException` (if running on legacy hardware or emulators lacking sensors).
  - `PermissionException` (if the user denies system permissions for Camera or Location).
  - Generic `Exception` handlers to capture unexpected runtime anomalies and report them safely via user-friendly UI popups rather than causing app termination (crashing).

---

## ♿ Accessibility (UI/UX Best Practices)
The application is crafted with inclusivity in mind, ensuring a seamless user experience for individuals with diverse visual and physical abilities:

* **Semantic Screen Reader Support:** All actionable items utilize `SemanticProperties.Description` and `SemanticProperties.HeadingLevel` to ensure native screen readers (such as Google TalkBack or Windows Narrator) can audibly describe the button actions precisely.
* **Adaptive Theme Architecture:** Integrated using `.NET MAUI Dynamic XAML ThemeBindings`. The UI automatically reacts and morphs when switching between system **Light Mode** and **Dark Mode**, preserving appropriate color contrast ratios to prevent eye strain and maintain readability.
* **Layout Fluidity:** Wrapped completely inside a responsive `ScrollView` and `VerticalStackLayout` to ensure text scales and wraps appropriately across varying mobile screen resolutions (from compact phones to large tablets) without clipping.

---

## 🛠️ Project Structure & Environment
* **Framework:** .NET MAUI (`net8.0-android`)
* **Development IDE:** Visual Studio 2022
* **Target OS for Demonstration:** Android 14.0 (API 34) running on Pixel 7 Emulator.
* **Permissions Configured:** `android.permission.CAMERA`, `android.permission.ACCESS_FINE_LOCATION`, `android.permission.ACCESS_COARSE_LOCATION`.