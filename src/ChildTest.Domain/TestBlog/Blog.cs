using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities;

namespace ChildTest.TestBlog;

public class Blog : AggregateRoot<Guid>
{
    public string Name { get; set; }
    public List<Post> Posts { get; set; }
}