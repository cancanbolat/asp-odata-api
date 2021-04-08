### Asp Net Core OData Api. 

### Controllers and ORMs
- Products => **Entity Framework**
- Categories => **Dapper**
- Customers => **Sql Kata**
---

### Queries
- localhost/odata/$metadata
- localhost/odata/controller?
  - $top=Number
  - $skip=Number
  - $orderby=Column
  - $select=Column
- /odata/controller => **get all**
- /odata/controller(Number) => **get by id**
