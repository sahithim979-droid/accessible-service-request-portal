namespace IowaAccessibleServicesPortal.Models;

public class DashboardViewModel
{
    public IReadOnlyList<ServiceRequest> Requests { get; init; } = [];
    public string StatusFilter { get; init; } = "All";
    public string Search { get; init; } = "";
    public int Total { get; init; }
    public int Open { get; init; }
    public int Completed { get; init; }
}
