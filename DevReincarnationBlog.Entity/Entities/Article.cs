﻿using DevReincarnationBlog.Core.Entities;

namespace DevReincarnationBlog.Entity.Entities
{
    public class Article:EntityBase,IEntityBase
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int ViewCount { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
        public Image Image { get; set; }

       
    }
}