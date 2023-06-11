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
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category
            {
                Id = Guid.Parse("00B6575F-5640-4080-9DD3-7FE43B04F1E1"),
                Name = "Yapay Zeka",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CreatedBy = "Admin Test"
            },
            new Category
            {
                Id = Guid.Parse("044B2971-89A5-4596-8DA3-87BCA0C4A7B2"),
                Name = "VR ve Ar Teknolojileri",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CreatedBy = "Admin Test"
            });
        }
    }
}
