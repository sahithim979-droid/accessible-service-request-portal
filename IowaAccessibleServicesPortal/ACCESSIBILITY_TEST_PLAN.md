# Accessibility testing plan — NOT a conformance certificate

Target for evaluation: WCAG 2.1 Level AA and applicable Section 508 requirements.

## Implemented as code
- Semantic landmarks, one page-level heading and meaningful nested headings
- Skip-to-content link, visible keyboard focus, and keyboard-operable native controls
- Text labels, required-state indication, error text and associated descriptions
- Server-side form validation, CSRF antiforgery protection and PRG on successful submission
- Status announcement on submission and a result count after a filtered request
- Native data table with caption and header scopes; horizontally scrollable region for small screens
- Responsive layout, reduced-motion support and design tokens

## Execute before claiming compliance
- [ ] Run axe DevTools or axe-core on dashboard, blank form, invalid form, and successful submission.
- [ ] Navigate every screen with keyboard only (Tab, Shift+Tab, Enter, Space, arrows, focus visibility, skip link).
- [ ] Test JAWS with Chrome/Edge and NVDA with Firefox; verify labels, errors, headings, table navigation and announcements.
- [ ] Check 200% and 400% zoom/reflow, narrow mobile viewport, and high contrast/forced colors.
- [ ] Measure all text, controls, status and focus indicator color contrast.
- [ ] Check WCAG 2.1 AA success criteria individually and log failures, reproduction steps, severity, remediation and retest results.
- [ ] Review whether agency Section 508 policy adds requirements; obtain independent review as appropriate.

**Do not claim that automated tools or this checklist alone prove WCAG or Section 508 compliance.**
