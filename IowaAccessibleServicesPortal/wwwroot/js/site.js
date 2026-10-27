// Progressive enhancement: the core dashboard, filters, and form work without JavaScript.
// Move focus to the error introduction after a failed POST for keyboard/screen-reader users.
document.addEventListener('DOMContentLoaded', () => {
  const errorIntro = document.querySelector('.error-intro');
  if (errorIntro) {
    errorIntro.setAttribute('tabindex', '-1');
    errorIntro.focus();
  }
});
