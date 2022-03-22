using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace ChildTest.TestBlog;

public class BlogAppService :
    CrudAppService<Blog, BlogDto, Guid, PagedAndSortedResultRequestDto,
        CreateBlogDto, UpdateBlogDto>,
    IBlogAppService
{
    public BlogAppService(IRepository<Blog, Guid> repository) : base(repository)
    {
    }
}