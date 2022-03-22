using System.Collections.Generic;

namespace ChildTest.TestBlog;

public class UpdateBlogDto
{
    public string Name { get; set; }
    public List<UpdatePostDto> Posts { get; set; }
}