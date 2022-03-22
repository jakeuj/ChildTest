using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace ChildTest.TestBlog;

public class BlogDto:EntityDto<Guid>
{
    public string Name { get; set; }
    public List<PostDto> Posts { get; set; }
}