Accessible Service Request Portal

About the Project

The Accessible Service Request Portal is a web application I built using ASP.NET Core MVC, C#, HTML, CSS, Sass, and JavaScript.

The idea behind this project was to create a simple, user-friendly application where users can submit service requests and view existing requests in one place.

While building it, I focused on creating a clean interface, making the application responsive across different screen sizes, and following accessibility best practices.

This is a personal portfolio project that demonstrates my approach to front-end development, UI implementation, and working with .NET applications.

Technologies Used

- Backend: C#, ASP.NET Core MVC, .NET 8
- Frontend: HTML5, CSS3, Sass, JavaScript
- UI: Razor Views, CSS Grid, Flexbox
- Architecture: MVC, Repository Pattern
- Tools: Visual Studio, Git, GitHub

What the Application Does

The application provides a simple dashboard where users can view and manage service requests.

Some of the main features include:

- A dashboard that displays service request information
- A form for creating new service requests
- Search and filtering options to find requests
- Form validation to help users enter the required information
- Responsive layouts that work on desktop and mobile devices
- Clear navigation and consistent styling throughout the application

The application currently uses sample data stored in memory, so it doesn't require a database to run.

Front-End and UI Development

One of my main goals with this project was to create an interface that is easy to understand and navigate.

I used HTML, CSS, Sass, and JavaScript to build the front end, with Razor views connecting the interface to the .NET backend.

I paid attention to spacing, typography, layout consistency, and how the interface adjusts to different screen sizes.

I also kept the UI structure simple so that additional features or components can be added later without making the application difficult to maintain.

Accessibility Considerations

Accessibility was an important part of how I approached the UI.

I incorporated several accessibility-focused practices, including:

- Using semantic HTML wherever possible
- Providing labels for form fields
- Supporting keyboard navigation
- Making focus indicators visible
- Displaying validation messages for form errors
- Organizing content with meaningful headings and logical page structure

The goal was to make the interface easier to use for people with different needs and assistive technologies.

I also included an accessibility testing plan in the repository for evaluating the application against WCAG 2.1 AA guidelines.

Note: The project has not yet undergone a complete accessibility audit, so WCAG or Section 508 compliance is not being claimed.

Project Structure

The application follows the ASP.NET Core MVC architecture.

- Controllers: Handle application requests and connect the UI with application logic.
- Models:Define the data used throughout the application.
- Views: Contain the Razor pages and user interface.
- Services: Handle service request data using a repository abstraction.
- wwwroot:Contains the CSS and JavaScript files used by the front end.
- styles: Contains the Sass source files.

This separation helps keep the code organized and easier to understand.

How to Run the Project

You'll need the .NET 8 SDK and either Visual Studio or Visual Studio Code installed.

1. Clone the repository

```bash
git clone https://github.com/sahithim979-droid/accessible-service-request-portal.git
```

2. Open the project directory

```bash
cd accessible-service-request-portal/IowaAccessibleServicesPortal
```

3. Restore the dependencies

```bash
dotnet restore
```

4. Start the application

```bash
dotnet run
```

Once the application starts, open the localhost URL displayed in the terminal.

What I Learned

Working on this project helped me bring together different parts of full-stack development.

It gave me an opportunity to work with ASP.NET Core MVC, connect backend functionality with Razor views, and build a responsive interface using HTML, CSS, and JavaScript.

It also reinforced the importance of considering accessibility early in development rather than treating it as something to address only after the UI is complete.

Future Improvements

There are a few features I'd like to explore further:

- Integrating SQL Server for persistent data storage
- Adding user authentication and authorization
- Building REST APIs for service request management
- Expanding the reusable UI components
- Adding automated accessibility checks
- Setting up CI/CD using Azure DevOps

Project Repository

You can find the source code here:

https://github.com/sahithim979-droid/accessible-service-request-portal

---

This is an independent portfolio project created to demonstrate .NET development, responsive UI implementation, and accessibility-focused design practices. It is not affiliated with the State of Iowa.
