using System.ComponentModel.DataAnnotations;

namespace IowaAccessibleServicesPortal.Models;

public class ServiceRequest
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Enter your name.")]
    [StringLength(80)]
    [Display(Name = "Your name")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Enter an email address.")]
    [EmailAddress(ErrorMessage = "Enter a valid email address.")]
    [StringLength(200)]
    [Display(Name = "Email address")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Select a service type.")]
    [Display(Name = "Service type")]
    public string Service { get; set; } = string.Empty;

    [Required(ErrorMessage = "Describe your request.")]
    [StringLength(1000, MinimumLength = 10,
        ErrorMessage = "Enter between 10 and 1000 characters.")]
    [Display(Name = "Request details")]
    public string Details { get; set; } = string.Empty;

    public string Status { get; set; } = "Submitted";
    public DateTime CreatedUtc { get; set; } = DateTime.UtcNow;
}
