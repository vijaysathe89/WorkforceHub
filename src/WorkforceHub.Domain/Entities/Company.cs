using WorkforceHub.Domain.Common;

namespace WorkforceHub.Domain.Entities;

public class Company : BaseEntity
{
    public Guid ContractorId { get; set; }
    public string CompanyCode { get; set; } = string.Empty;
    public string CompanyName { get; set; } = string.Empty;
    public string ContactPerson { get; set; } = string.Empty;
    public string MobileNumber { get; set; } = string.Empty;
    public string? Email { get; set; }
    public string? Address { get; set; }
}