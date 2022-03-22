using AutoMapper;

namespace ChildTest.TestBlog;

public class BlogProfile:Profile
{
    public BlogProfile()
    {
        CreateMap<Blog, BlogDto>();
        CreateMap<CreateBlogDto, Blog>();
        CreateMap<UpdateBlogDto, Blog>();
        CreateMap<Post, PostDto>();
        CreateMap<CreatePostDto, Post>();
        CreateMap<UpdatePostDto, Post>();
    }
}