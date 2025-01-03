# Blazor Study Project

## Navigation
- [Overview](#overview)
- [Screenshots](#screenshots)
- [Features](#features)
  - [Blazor Hosting Models and Render Modes](#blazor-hosting-models-and-render-modes)
  - [Blazor Components](#blazor-components)
  - [Layouts and Navigation](#layouts-and-navigation)
  - [Data Access with EF Core](#data-access-with-ef-core)
  - [Form Creation and Validation](#form-creation-and-validation)
  - [Client-Side Interactivity with Blazor WASM](#client-side-interactivity-with-blazor-wasm)
  - [JavaScript Integration](#javascript-integration)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Setup](#setup)
- [License](#license)

---

This repository contains a Blazor application built as part of my study journey through an course on Blazor development. This project is not a professional application but a learning exercise to understand Blazor concepts and features.

## Overview

The application was developed using **.NET 8** and **Visual Studio 2022 Community Edition**. It explores various aspects of Blazor development, including hosting models, components, interactivity, data access, form creation, and JavaScript integration.

## Screenshots

![Home Overview](screenshots/home_page.png)
*Home Page*

![Employees Page](screenshots/employees_page.png)
*Employees Form*

![Employees Quick View](screenshots/quick_view_popup.png)
*Quick View Popup*

![Full Details 1](screenshots/employee_full_details_page_1.png)
*Employee Full Detail 1*

![Full Details 2](screenshots/employee_full_details_page_2.png)
*Employee Full Detail 2*

![Employee Edit](screenshots/employee_edit_page.png)
*Employee Edit Page*

![Employee Add](screenshots/employee_add_page.png)
*Employee Add Page*

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
