# Food Explorer 

**Author:** Wang Aicheng
**Module:** 6G6Z0014 - Mobile Computing

## Overview
Food Explorer is a cross-platform mobile application developed using the .NET MAUI framework. Centered around the "Food and Drink" theme, this app serves as a digital companion for food enthusiasts to log their culinary journeys, discover local dining spots, and explore exciting recipes. 

## Development Plan & Features
To ensure a high-quality user experience and fulfill the assessment criteria, the following features and technical implementations are planned:

* **UI/UX & Accessibility:** * A clean and uncluttered user interface designed strictly with XAML.
  * Implementation of accessibility best practices referencing WCAG guidelines, including semantic labeling for screen readers and support for light/dark themes.

* **Specialist Mobile Hardware Integration:** * **Camera:** To allow users to capture and save images of their meals.
  * **Geolocation:** To determine the user's current coordinates and help find nearby restaurants.
  * **Accelerometer / Shake:** A fun "Shake" feature that suggests a random recipe or restaurant when the device is shaken.
  * **Text-to-Speech:** To read out recipe steps audibly, further enhancing the app's accessibility.

* **Validation & Error Handling:** * Robust input validation for all user forms to prevent empty submissions.
  * Comprehensive error handling (e.g., catching permission errors when accessing hardware) to ensure the app does not crash.

* **Deployment:** * The application is designed to be fully functional and scale correctly across multiple platforms, primarily targeting Android devices and Windows machines.