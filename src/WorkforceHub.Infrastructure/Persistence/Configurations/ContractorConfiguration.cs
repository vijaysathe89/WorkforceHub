using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkforceHub.Domain.Entities;

namespace WorkforceHub.Infrastructure.Persistence.Configurations;

public class ContractorConfiguration : IEntityTypeConfiguration<Contractor>
{
    public void Configure(EntityTypeBuilder<Contractor> builder)
    {
        builder.ToTable("Contractors");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.ContractorCode)
            .HasMaxLength(20)
            .IsRequired();

        builder.Property(x => x.BusinessName)
            .HasMaxLength(200)
            .IsRequired();

        builder.Property(x => x.ContactPerson)
            .HasMaxLength(150)
            .IsRequired();

        builder.Property(x => x.MobileNumber)
            .HasMaxLength(15)
            .IsRequired();

        builder.Property(x => x.Email)
            .HasMaxLength(150);

        builder.Property(x => x.Address)
            .HasMaxLength(500);
    }
}