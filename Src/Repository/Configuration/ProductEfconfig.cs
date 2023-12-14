using Microsoft.EntityFrameworkCore;

namespace Repository.Configuration
{
    public class ProductEfconfig : IEntityTypeConfiguration<Domain.Models.Product.Product>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Domain.Models.Product.Product> builder)
        {
            builder.Property(a => a.Name).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Price).IsRequired();
           
            builder.HasQueryFilter(a => a.IsDeleted == false);
        }
    }
}
