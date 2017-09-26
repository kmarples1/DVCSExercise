<Query Kind="Program">
  <Connection>
    <ID>3b1e65cc-a714-45a8-8e63-faa5a963518d</ID>
    <Persist>true</Persist>
    <Server>.\</Server>
    <Database>NorthwindExtended</Database>
  </Connection>
</Query>

void Main()
{
	//Produce a list of all the Products by Category for Northwind Traders
	var result = from cat in context.Categories // the query starts with the Database Entity
				 orderby cat.CategoryName
				 select new ProductCategory // defined below
				 {
				 	Name = cat.CategoryName,
					Description = cat.Description,
					Picture = cat.Picture,
					Products = from item in cat.Products // build subquery off of the cat item
							   orderby item.ProductName // filter down more
				 			   where item.Discontinued == false
							   select new ProductInfo
							   {
							   		ID = item.ProductID,
									Name = item.ProductName,
									QuantityPerUnit = item.QuantityPerUnit, 
									Price = item.UnitPrice, 
									InStock = item.UnitsInStock
							   }
				 };
	result.Dump();
}
// Define other methods and classes here:

public class ProductCategory // DTO some are built in, but the IEnumerable is not a built in datatype (we defined it ourselves)
{
	// Properties for Name/Description/Picture/Products
	
	public string Name { get; set; }
	public string Description { get; set; }
	public byte[] Picture { get; set; }
	public IEnumerable<ProductInfo> Products { get; set; }
}

public class ProductInfo // POCO - datatypes are built in datatypes of the CLR (in the C# language)
{
	public int ID { get; set; }
	public string Name { get; set; }
	public string QuantityPerUnit { get; set; }
	public decimal? Price { get; set; }
	public short? InStock { get; set; }
}