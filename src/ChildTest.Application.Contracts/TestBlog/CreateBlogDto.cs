using System.Collections.Generic;

namespace ChildTest.TestBlog;

public class CreateBlogDto
{
    public string Name { get; set; }
    public List<CreatePostDto> Posts { get; set; }
}