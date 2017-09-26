<Query Kind="Statements">
  <Connection>
    <ID>3b1e65cc-a714-45a8-8e63-faa5a963518d</ID>
    <Persist>true</Persist>
    <Server>.\</Server>
    <Database>NorthwindExtended</Database>
  </Connection>
</Query>

// Get the following from the Orders/OrderDetails for the last month of business data
// OrderDate, OrderID, # Items, Subtotal of all items, total with freight
// Display this information along with the total income for the month and the number of orders processed

var maxDate = Orders.Max(row => row.OrderDate);
maxDate.Value.Month.Dump(); 		//pulls out highest date from all


var lastMonthOrders = from data in Orders
					  where data.OrderDate.Value.Month == maxDate.Value.Month
					  	&& data.OrderDate.Value.Year == maxDate.Value.Year // all of the orders that happened in the particular month
					  orderby data.OrderDate
					  select new
					 {
					 	OrderDate = data.OrderDate,
						OrderID = data.OrderID,
						NumberOfItems = data.OrderDetails.Count(),
						ItemSubtotals = (from item in data.OrderDetails // subquery to breakdown subtotals
					 					select item.UnitPrice * item.Quantity).Sum(), //put equation into brackets and added .Sum() to total statement
						FreightCost = data.Freight,
						Total = data.Freight + (from item in data.OrderDetails select item.UnitPrice * item.Quantity).Sum()
					 };

lastMonthOrders.Dump();
var totalIncome = lastMonthOrders.Sum(x => x.Total);
var count = lastMonthOrders.Count();
totalIncome.Dump("Total Income");
count.Dump("# of Orders Processed");

/*
Orders.Take(5), // get the first 5 orders
Orders.Count(), // finds out total orders
from data in Orders
orderby data.OrderDate descending // newest to oldest
select new
{
	OrderDate = data.OrderDate
}
*/