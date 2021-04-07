### Asp Net Core OData Api. 

## Queries
- /odata/$metadata
````
<?xml  version="1.0"  encoding="utf-8"?>
<edmx:Edmx  Version="4.0"  xmlns:edmx="http://docs.oasis-open.org/odata/ns/edmx">
<edmx:DataServices>
<Schema  Namespace="asp_odata_api.Models"  xmlns="http://docs.oasis-open.org/odata/ns/edm">
<EntityType  Name="Product">
````
- /odata/products
````
{

"@odata.context": "https://localhost:44362/odata/$metadata#Products",
	"value": [
		{
		"Id": 1,
		"Name": "Cracking the Coding Interview",
		"Quantity": 10,
		"Price": 24.45,
		"CategoryId": 1
		},
	....
````
- /odata/products(3)
````
{
	"@odata.context": "https://localhost:44362/odata/$metadata#Products/$entity",
	"Id": 3,
	"Name": "Samsung J7 Prime",
	"Quantity": 100,
	"Price": 1799.0,
	"CategoryId": 2
	}
````
- /odata/products?$select=Name,Price
````
{
	"Name": "Cracking the Coding Interview",
	"Price": 24.45
	},
	{
	"Name": "Clean Code",
	"Price": 35.0
	},
	....
````
- odata/products?$top=2
- odata/products?$skip=1
- odata/products?$orderby=Price
- ...
