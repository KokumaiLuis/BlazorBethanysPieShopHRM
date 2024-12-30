# Blazor Study Project

This repository contains a Blazor application built as part of my study journey through an course on Blazor development. This project is not a professional application but a learning exercise to understand Blazor concepts and features. 

## Overview

The application was developed using **.NET 8** and **Visual Studio 2022 Community Edition**. It explores various aspects of Blazor development, including hosting models, components, interactivity, data access, form creation, and JavaScript integration.

## Screenshots

![Employee Overview](screenshots/employee-overview.png)
*Employee Overview Page*

![Add Employee Form](screenshots/add-employee-form.png)
*Add Employee Form*

![Map Integration](screenshots/map-component.png)
*Map Integration Component*

## Features

Here are the key features and concepts implemented in the project:

### Blazor Hosting Models and Render Modes
- Understand and implement **Server-side Rendering** and **WebAssembly (WASM)** hosting models.
- Explore **Streaming Rendering** for optimized component loading.

### Blazor Components
- Create custom components such as an **Employee Overview** and **Employee Detail**.
- Add interactivity using events and parameters.
- Use **RenderFragment** to create reusable UI.
- Handle errors in components with **Error Boundaries**.
- Dynamically load components and widgets on the homepage.

### Layouts and Navigation
- Build a custom layout for consistent UI.
- Add navigation between pages and components.

### Data Access with EF Core
- Configure **Entity Framework Core** for database access.
- Perform database migrations and seed initial data.
- Implement repositories and services for data handling.
- Display large datasets using the **Virtualize Component** and **QuickGrid Component**.

### Form Creation and Validation
- Create forms using **Data Binding** and **EditForm**.
- Develop complex forms for editing and adding employees.
- Implement data validation for user input.
- Add image upload functionality.

### Client-Side Interactivity with Blazor WASM
- Implement client-side rendering with **Blazor WebAssembly**.
- Connect to an external API and use **Minimal API**.
- Store data locally using **Blazored LocalStorage**.
- Utilize **Auto Render Mode** for dynamic rendering.

### JavaScript Integration
- Invoke JavaScript functions from Blazor components.
- Wrap JavaScript components in a **Razor Class Library** for reuse.

## Getting Started

### Prerequisites
- .NET 8 SDK
- Visual Studio 2022 Community Edition

### Setup
1. Clone the repository:
   ```bash
   git clone <repository-url>
   ```
2. Open the solution in Visual Studio 2022.
3. Restore NuGet packages and build the project.
4. Run the application in your preferred hosting mode.

## License

This project is licensed under the MIT License. Feel free to use, modify, and share as needed.

---

Thank you for checking out my study project! Feedback and suggestions are always welcome.
