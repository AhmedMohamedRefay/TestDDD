using LINQTest;
using System;
using System.ComponentModel.DataAnnotations;

var x=new List<int> { 1,2,3 ,0,-1,1};
var linQueryExpression=from num in x where num > 1 select num; //Linq Query Expression
var res = x.Where(x => x > 1);          // deferred excusion
var result = x.Where(x => x > 1).ToList(); // immediate excusion
foreach (var item in result)
    Console.WriteLine(item);
#region SetOperation
//Console.WriteLine("--------------------------------");

//x.Add(11);
//foreach (var item in result)
//    Console.WriteLine(item);
//Console.WriteLine("----------Take----------------------");

//var sk =x.Take(10);
//foreach (var item in sk)
//    Console.WriteLine(item);
//Console.WriteLine("------------Take While--------------------");

//var tw = x.TakeWhile(x=>x<2);
//foreach (var item in tw)
//    Console.WriteLine(item);


//Console.WriteLine("------------Skip While--------------------");

//var skw = x.SkipWhile(x => x <3);
//foreach (var item in skw)
//    Console.WriteLine(item);


//Console.WriteLine("------------chunks--------------------");

//var chun = x.Chunk(4);
//foreach (var item in chun)
//{
//    foreach (var it in item)
//        Console.WriteLine(it);
//    Console.WriteLine(".................");
//}
//Console.WriteLine("------------Distinuct--------------------");

//var dia = x.Distinct();
//foreach (var item in dia)
//{

//        Console.WriteLine(item);

//}
//Console.WriteLine("------------Intersect--------------------");

// var list2=new List<int> { 3,2,1,0,5,6};
//var qur=x.Intersect(list2);
//foreach (var item in qur)
//{

//    Console.WriteLine(item);

//}

//Console.WriteLine("------------Union--------------------");


//var qury = x.Union(list2);
//foreach (var item in qury)
//{

//    Console.WriteLine(item);

//}
#endregion
#region OrderBy

//linQueryExpression = from num in x where num > 1 orderby num descending select num ; // order using expression
//res = x.Where(x => x > 1).OrderByDescending(y=>y); // order using linq


//Console.WriteLine("------------------------------------------");



//var studentList = new List<Student>
//{
//    new Student("ahmed","cs",23),
//    new Student("hassan","it",22),
//    new Student("mostafa","mm",23),
//    new Student("mostafa","is",24),
//    new Student("mody","is",21),
//};

//var query= studentList.Where(x=>x.Age>21).OrderBy(y=>y.Name).ThenBy(y=>y.Department).Select(e=>new { EmpName=e.Name,EmpAge=e.Age,EmpDep=e.Department});

////foreach (var student in query)
////    Console.WriteLine($"Name={student.EmpName}, Deparmtent={student.EmpDep} , Age={student.EmpAge}");

//studentList.Add(new Student("mohsen", "it", 33));
//foreach (var student in query)
//    Console.WriteLine($"Name={student.EmpName}, Deparmtent={student.EmpDep} , Age={student.EmpAge}");
//Console.WriteLine("--------------------------------");
// Quentifier Mehod {Any(),All(),Contain()}
#endregion
#region JoinLinq
//var customers = new List<Customer>
//            {
//                new Customer { Id = 1, Name = "Alice" },
//                new Customer { Id = 2, Name = "Bob" },
//                new Customer { Id = 3, Name = "John" }
//            };
//var orders = new List<Order>
//            {
//                new Order { OrderId = 101, CustomerId = 1 },
//                new Order { OrderId = 102, CustomerId = 2 },
//                new Order { OrderId = 103, CustomerId = 1 },
//                new Order { OrderId = 104, CustomerId = 3 }
//            };


//var resultJoin = from customer in customers
//             join order in orders on customer.Id equals order.CustomerId
//             select new { CustomerName = customer.Name, OrderId = order.OrderId };
//foreach (var item in resultJoin)
//{
//    Console.WriteLine($"Customer: {item.CustomerName}, Order ID: {item.OrderId}");
//}
#endregion

var deparments = new List<Deparment>
{

    new Deparment(1,"HR"),
    new Deparment(2,"IT"),
    new Deparment(3,"Account"),
    new Deparment(4,"Developemt")
};

var employees = new List<Student>
{
    new Student("hassan","HR",23,1),
     new Student("Hazem","HR",23,1),
    new Student("ahmed","IT",22,2),
    new Student("Tarek","IT",22,2),
    new Student("Mody","Account",27,3),
    new Student("Ibrahim","Developemt",29,4),
};
Console.WriteLine("-------------------Linq Expression----------");
// join using linq expression
var result_join = from employee in employees
             join depart in deparments on employee.DepartmentId
             equals depart.Id
             select new { EmployeeName=employee.Name, depart.Name };
foreach (var item in result_join)
    Console.WriteLine(item);

// join using linq method
Console.WriteLine("---------Linq Method-------------");
var linq_join = employees.Join(deparments, e => e.DepartmentId, d => d.Id, (x, y) => new { EmpName=x.Name,DepName= y.Name });
foreach (var item in linq_join)
    Console.WriteLine(item);


// grouping
Console.WriteLine("-----------grouping-----------");
var result_group = from employee in employees
                   join depart in deparments on employee.DepartmentId
                   equals depart.Id
                   group employee by depart.Name;

foreach (var item in result_group)
{
    var join=string.Join(",",item.Select(x=> x.Name));
    Console.WriteLine($"{item.Key},{join}");
}