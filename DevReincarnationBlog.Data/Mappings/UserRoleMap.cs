using DevReincarnationBlog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevReincarnationBlog.Data.Mappings
{
    public class UserRoleMap : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            // Primary key
            builder.HasKey(r => new { r.UserId, r.RoleId });

            // Maps to the AspNetUserRoles table
            builder.ToTable("AspNetUserRoles");

            builder.HasData(new AppUserRole
            {
                UserId = Guid.Parse("C871CE76-CFAC-45EA-B95C-A7DEC9EF236A"),
                RoleId = Guid.Parse("3E48D1BC-5F79-41CD-8A9A-532140199F99")
            },
            new AppUserRole
            {
                UserId = Guid.Parse("1427B0E0-6E51-43E1-AD3E-040256330040"),
                RoleId = Guid.Parse("989C2C1F-8FF7-4A22-925B-72275757A07D")
            });
        }
    }
}
