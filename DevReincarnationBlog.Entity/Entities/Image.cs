﻿using DevReincarnationBlog.Core.Entities;

namespace DevReincarnationBlog.Entity.Entities
{
    public class Image : EntityBase, IEntityBase
    {
        public string FileName { get; set; }
        public string FileType { get; set; }
        public ICollection<Article> Articles { get; set; }
    }
}