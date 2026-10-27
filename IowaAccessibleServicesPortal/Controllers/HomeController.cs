using IowaAccessibleServicesPortal.Models;
using IowaAccessibleServicesPortal.Services;
using Microsoft.AspNetCore.Mvc;

namespace IowaAccessibleServicesPortal.Controllers;
public class HomeController(IRequestRepository repository) : Controller
{
    public IActionResult Index(string status = "All", string search = "")
    {
        var all = repository.All();
        var valid = new[] { "All", "Submitted", "In progress", "Completed" };
        if (!valid.Contains(status)) status = "All";
        search = (search ?? "").Trim();
        var filtered = all.Where(r =>
            (status == "All" || r.Status == status) &&
            (search.Length == 0 || r.Service.Contains(search, StringComparison.OrdinalIgnoreCase)
             || r.Name.Contains(search, StringComparison.OrdinalIgnoreCase)
             || r.Id.ToString().Contains(search)));
        return View(new DashboardViewModel {
            Requests = filtered.OrderByDescending(r => r.CreatedUtc).ToList(),
            StatusFilter = status, Search = search, Total = all.Count,
            Open = all.Count(r => r.Status != "Completed"),
            Completed = all.Count(r => r.Status == "Completed")
        });
    }

    [HttpGet] public IActionResult Create() => View(new ServiceRequest());

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(ServiceRequest model)
    {
        var allowed = new[] { "Account access", "Application status", "Technical support" };
        if (!allowed.Contains(model.Service))
            ModelState.AddModelError(nameof(model.Service), "Select a valid service type.");
        if (!ModelState.IsValid) return View(model);
        repository.Add(model);
        TempData["Success"] = $"Request #{model.Id} was submitted successfully.";
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Error() => View();
}
