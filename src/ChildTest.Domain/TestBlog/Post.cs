using System;
using Volo.Abp.Domain.Entities;

namespace ChildTest.TestBlog;

public class Post:Entity<Guid>
{
    public string Title { get; set; }
    public string Content { get; set; }
    public string Author { get; set; }
    public Guid BlogId { get; set; }
    public Blog Blog { get; set; }
}