using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace ChildTest.TestBlog;

public interface IBlogAppService : 
    ICrudAppService< //Defines CRUD methods
        BlogDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting on getting a list of books
        CreateBlogDto, //Used to create a new book
        UpdateBlogDto> //Used to update a book
{
    
}