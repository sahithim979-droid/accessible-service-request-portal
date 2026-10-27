using IowaAccessibleServicesPortal.Models;
namespace IowaAccessibleServicesPortal.Services;

// DEMO ONLY: No persistent storage, authentication or PII security controls.
public class InMemoryRequestRepository : IRequestRepository
{
    private readonly List<ServiceRequest> _requests =
    [
        new() { Id = 1001, Name = "Alex Morgan", Email = "alex@example.org", Service = "Account access", Details = "I need help signing in to the service portal.", Status = "In progress", CreatedUtc = DateTime.UtcNow.AddDays(-5) },
        new() { Id = 1002, Name = "Jordan Lee", Email = "jordan@example.org", Service = "Application status", Details = "Please help me find my existing application.", Status = "Completed", CreatedUtc = DateTime.UtcNow.AddDays(-3) },
        new() { Id = 1003, Name = "Taylor Casey", Email = "taylor@example.org", Service = "Technical support", Details = "A form is not loading on my computer.", Status = "Submitted", CreatedUtc = DateTime.UtcNow.AddDays(-1) }
    ];
    private readonly object _sync = new();
    public IReadOnlyList<ServiceRequest> All()
    {
        lock (_sync) return _requests.Select(x => new ServiceRequest {
            Id = x.Id, Name = x.Name, Email = x.Email, Service = x.Service,
            Details = x.Details, Status = x.Status, CreatedUtc = x.CreatedUtc
        }).ToList();
    }
    public void Add(ServiceRequest request)
    {
        lock (_sync)
        {
            request.Id = _requests.Max(x => x.Id) + 1;
            _requests.Add(request);
        }
    }
}
