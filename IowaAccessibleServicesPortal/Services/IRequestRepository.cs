using IowaAccessibleServicesPortal.Models;
namespace IowaAccessibleServicesPortal.Services;
public interface IRequestRepository
{
    IReadOnlyList<ServiceRequest> All();
    void Add(ServiceRequest request);
}
