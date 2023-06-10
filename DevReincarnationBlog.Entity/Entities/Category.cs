using DevReincarnationBlog.Core.Entities;

namespace DevReincarnationBlog.Entity.Entities
{
    public class Category : EntityBase
    {
        public string Name { get; set; }
        public ICollection<Article> Articles { get; set; }
    }
}
