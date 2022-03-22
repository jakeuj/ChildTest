using System;
using Volo.Abp.Application.Dtos;

namespace ChildTest.TestBlog;

public class UpdatePostDto:EntityDto<Guid>
{
    public string Title { get; set; }
    public string Content { get; set; }
    public string Author { get; set; }
}