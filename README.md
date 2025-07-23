# MauiShares

A .NET MAUI application designed to practice and demonstrate **Bindable Properties** implementation through a custom file sharing interface. This project showcases how to create reusable custom controls with bindable properties that can be easily customized and bound to ViewModels.

## Project Overview

MauiShares is an educational project focused on mastering Bindable Properties in .NET MAUI. The application simulates a file sharing service where users can upload and share files. The main highlight is the `UploadView` custom control, which demonstrates various types of bindable properties including:

- **Color Properties**: For customizing background and text colors
- **String Properties**: For dynamic text content
- **Boolean Properties**: For controlling visibility and states
- **Command Properties**: For handling user interactions
- **Object Properties**: For complex data binding scenarios

The project serves as a practical example of how to create flexible, reusable UI components that can be easily integrated into different parts of an application while maintaining clean separation of concerns.

## Project Structure

The project is organized following .NET MAUI best practices:

### Core Components

- **`CustomViews/`**: Contains the main `UploadView` custom control
  - `UploadView.xaml`: XAML layout defining the visual structure
  - `UploadView.xaml.cs`: Code-behind with bindable property implementations

- **`Models/`**: Data models for the application
  - `FileModel.cs`: Represents file entities

- **`ViewModels/`**: MVVM pattern implementation
  - `DashboardViewModel.cs`: Main dashboard logic
  - `FileDetailsViewModel.cs`: File details management

- **`Views/`**: Application pages
  - `DashboardView.xaml/.cs`: Main application dashboard
  - `FileDetailsView.xaml/.cs`: File details and management

- **`Services/`**: Business logic and external services
  - `FileUploadService.cs`: Handles file upload operations

- **`Resources/`**: Application assets
  - `Images/`: Icons and graphics
  - `Raw/`: Lottie animation files (animation1.json, animation2.json, animation3.json)
  - `Styles/`: Application theming and styling

### Key Features Demonstrated

1. **Multiple Bindable Property Types**:
   - Color properties (`ViewBackground`, `TitleColor`, `SubTitleColor`)
   - String properties (`TitleProperty`, `SubTitle`, `LottieFile`)
   - Boolean properties (`ShowOverlay`)
   - Command properties (`UploadCommand`)

2. **Property Change Callbacks**: Each bindable property includes proper change handling to update the UI when values change

3. **Default Values**: Demonstrates how to set meaningful default values for bindable properties

4. **UI State Management**: Shows how to control complex UI states (overlays, animations, loading indicators) through bindable properties

5. **Cross-Platform Compatibility**: Supports Android, iOS, macOS Catalyst, and Windows platforms

## Bindable Properties Implementation

The `UploadView` control showcases the following bindable properties:

```csharp
// Color customization
public Color ViewBackground { get; set; }
public Color TitleColor { get; set; }
public Color SubTitleColor { get; set; }

// Content customization
public string TitleProperty { get; set; }
public string SubTitle { get; set; }
public string LottieFile { get; set; }

// State management
public bool ShowOverlay { get; set; }

// Command binding
public ICommand UploadCommand { get; set; }
```

Each property follows the standard .NET MAUI bindable property pattern with proper registration, default values, and change callbacks.

## Project Images

*Note: This is an educational project focused on learning Bindable Properties in .NET MAUI. Screenshots and visual demonstrations would typically be included here to showcase the different states and customizations possible with the UploadView control.*

### Key Visual Elements:

- **Lottie Animations**: Interactive animations that respond to user taps
- **Dynamic Theming**: Customizable colors and text content
- **Loading Overlays**: Visual feedback during file upload operations
- **Responsive Design**: Adapts to different screen sizes and orientations

## Learning Outcomes

By studying this project, developers will understand:

- How to create custom controls with bindable properties
- Proper implementation of property change callbacks
- Integration of custom controls with MVVM pattern
- Handling complex UI states through data binding
- Best practices for reusable component development in .NET MAUI