using LINQ_Practice;

TernaryOperator ternaryOperator = new TernaryOperator();
ternaryOperator.method_Syntax();

var _db = new DetailsCustomer();

IEnumerable<Customer> customers= _db.AddIEnumerable();

// memory <- all value 

var high = customers.Where(e => e.Revinue>200);

// Filter using condition value 

foreach (var c in high)
{
    Console.WriteLine(c);
}






IQueryable<Customer> customer = _db.GetQueryable();

// memory 0 not assign any value 

var high_ = customer.Where(e=> e.Revinue>200);
// not assign value 


var sel = high_.ToList();
// Select from customer list where revineu > 2000 . this querry direct assign to db 

// now sel save data 


foreach(var c in sel)
{
    Console.WriteLine(c);
}