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
    public class ImageMap : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasData(new Image
            {
                    Id = Guid.Parse("B8A7BB31-7655-47EB-9D59-72C0BE1C8C06"),
                    FileName = "images/testimage",
                    FileType = "jpg",
                    CreatedDate = DateTime.Now,
                    CreatedBy = "Admin Test",
                    IsDeleted = false
            },
            new Image
            {
                    Id = Guid.Parse("558C3495-E0BB-4824-BCBF-A48B08263CFE"),
                    FileName = "images/testimage2",
                    FileType = "jpg",
                    CreatedDate = DateTime.Now,
                    CreatedBy = "Admin Test",
                    IsDeleted = false
            });
        }
    }
}
