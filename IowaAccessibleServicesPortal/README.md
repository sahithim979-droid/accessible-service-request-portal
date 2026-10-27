# Accessible Service Request Portal (Portfolio Demonstration)

**ASP.NET Core MVC / C# / Razor / HTML5 / CSS / JavaScript**

A fictional state-service-inspired portal, created independently as a code sample for a senior full-stack .NET role. **Not an Iowa government product or official service.** All supplied names and email addresses are fictional sample data.

## Features
- MVC separation: controller, strongly typed view models, repository abstraction, Razor views
- Searchable/status-filtered request dashboard with metrics and accessible table
- New request form with server validation, anti-forgery token and post/redirect/get
- Responsive UI, focus indicators, skip link, semantic regions, label/error associations and accessible status messages
- No JavaScript dependency for core functionality; small progressive-enhancement script
- Central CSS design tokens and a Sass source copy
- GitHub Actions example pipeline for .NET build (adaptable to Azure DevOps)

## Run
```bash
dotnet restore
dotnet run
```
Open the local URL printed by the .NET CLI. Requires **.NET 8 SDK**.

## Portfolio positioning
**What this sample shows:** ASP.NET Core MVC, C#, Razor UI composition, HTML5, responsive CSS, JavaScript progressive enhancement, server-side validation, baseline accessibility-oriented implementation, design-token-driven interface.

**What it does NOT demonstrate:** ASP.NET Web Forms, SQL Server integration, production authentication, protection of sensitive data, completion of axe/JAWS testing, formal WCAG training, certification, verified WCAG 2.1 AA/Section 508 conformance, or production deployments. Don't claim these based on this project.

The repository uses an **in-memory demo repository**; data is reset on restart and is shared across visitors. **Do not deploy it publicly for collection of real personal information**. For production use add user authentication and authorization, persistent database with migrations, encryption/key management, audit logging, rate limiting, privacy review and tests.

## Design system vs component library
The sample's design tokens define color, spacing and interaction patterns. This is a **small UI foundation**, not a mature enterprise design system. A full design system also includes design principles, usage guidance, accessibility requirements, governance, versioning and a component strategy. Bootstrap/Material provide reusable components, not by themselves an organization's full design-system governance.

## Accessibility evaluation
See [ACCESSIBILITY_TEST_PLAN.md](ACCESSIBILITY_TEST_PLAN.md). Code includes a number of WCAG-oriented techniques, but **compliance is not verified** without testing with assistive technology, automated checks and manual review.

## Suggested screenshots for portfolio
1. Dashboard at desktop width.
2. Dashboard at 375px mobile width.
3. Form with required-field errors visible and keyboard focus.

## Resume bullet (only after you personally build/test and can explain it)
> Developed a responsive ASP.NET Core MVC service-request demonstration using C#, Razor, semantic HTML, CSS design tokens and progressive-enhancement JavaScript; implemented server-side validation, search/filter workflows, and accessibility-oriented form patterns.
