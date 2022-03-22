# ChildTest
ChildTest

POST /api/app/blog

```
{
  "name": "string",
  "posts": [
    {
      "title": "string",
      "content": "string",
      "author": "string"
    }
  ]
}
```

Responses

```
{
  "name": "string",
  "posts": [
    {
      "title": "string",
      "content": "string",
      "author": "string",
      "blogId": "c1c1da49-dfcc-43c3-1b1a-3a02c281a004",
      "id": "6ae303d7-c50d-8a9a-177c-3a02c281a3d6"
    }
  ],
  "id": "c1c1da49-dfcc-43c3-1b1a-3a02c281a004"
}
```

PUT /api/app/blog?id=c1c1da49-dfcc-43c3-1b1a-3a02c281a004

```
{
  "name": "string",
  "posts": [
    {
      "id": "6ae303d7-c50d-8a9a-177c-3a02c281a3d6",
      "title": "string",
      "content": "string",
      "author": "string"
    }
  ]
}
```

Responses
Error: response status is 500
```
An error occurred while saving the entity changes. See the inner exception for details.
Microsoft.EntityFrameworkCore.DbUpdateException: An error occurred while saving the entity changes. See the inner exception for details.
 ---> Microsoft.Data.SqlClient.SqlException (0x80131904): Violation of PRIMARY KEY constraint 'PK_Posts'. 
 Cannot insert duplicate key in object 'dbo.Posts'. 
 The duplicate key value is (6ae303d7-c50d-8a9a-177c-3a02c281a3d6).
The statement has been terminated.
```
