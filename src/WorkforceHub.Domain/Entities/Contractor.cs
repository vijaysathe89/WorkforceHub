using WorkforceHub.Domain.Common;
namespace WorkforceHub.Domain.Entities;
public class Contractor : BaseEntity
{
    public string ContractorCode { get; set; } = string.Empty;

    public string BusinessName { get; set; } = string.Empty;

    public string ContactPerson { get; set; } = string.Empty;

    public string MobileNumber { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string Address { get; set; } = string.Empty;
}
