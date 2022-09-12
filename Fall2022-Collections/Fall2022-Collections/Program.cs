// Collections

//Arrays!
//fixed, and of a particular type
//indexed at 0, meaning numbered starting with 0
var students = new string[13]; //creates an empty array with 5 slots to fill.
// variable = new type[length]; genereic template
var instructors = new string[] {"Davis","Gavin","","",""}; // because there are 5 things listed, the array's 
// varaible = new type[] {comma separated values}
//In C# -  an array's length and type cannot change.period..

// change the value at a slot in an array
// name = value; general aspect
// array[index] = value;
students[7] = "Ashley";
// Student at index seven is updated to say "Ashley"
// student at index seven is not the seventh student -> 8th student
// 0 1 2 3 4 5 6 7 (8)
// first thing in the list -> array[0]
// last thing in the list -> array[array.length -1]
Console.WriteLine(students.Length); // prints the number of slots that the student array has



// Lists
// dynamic size, still must be of one type (data type)
// indexed at 0, similar to arrays
var groceries = new List<string>(); // sets ups a new list , starts with no values within, its count is 0
groceries.Add("Pizza"); // our list contains 1 item, (index = 0)
groceries.Add("bananas"); // our list contains 2 items (banana has an index = 1)
groceries.Add("grapes"); // index = 2
groceries.Add("potatoes");// Index = 3
Console.WriteLine(groceries[0]);

// Remove items from an array
// list.Remove(item to remove);
groceries.Remove("bananas");
Console.WriteLine(groceries.Count);
Console.WriteLine(groceries[1]);

// RemoveAt -> give index to remove
//groceries.RemoveAt(1); // removes the second item in the list

groceries.Insert(1, "bananas"); // shift items after this index up by 1, adds bananas to list
Console.WriteLine(groceries.Count);
Console.WriteLine(groceries[1]);

Console.WriteLine(groceries);
// how do we print out this list !?!?!?!?

// Foreach Loops !
// loops that run once for each item in a collection
// rather than speciically having an index(i) like previous loops, we have an object that we can look at and engage with

// Foreach((data type)type item in collection){
//  code to run on the item
// }
foreach(var grocery in groceries)
{
    Console.WriteLine(grocery);
}
foreach (var grocery in instructors) // grocery is a naming convention 
{
    Console.WriteLine(grocery);
}
// sometimes its nice to have access to the index of a particular item as well as the item itseld.so, 
// of a foreach loo[ using a for loop
// same example as above, but with a for loop:
// collection.length if array, collection.count if list
for (var i = 0 ; i <= instructors.Length - 1 ; i++)
{
    Console.WriteLine(instructors[i]);
}
// the same thing above is below but different format 
for (var i = 0; i < instructors.Length; i++) 
{
    Console.WriteLine(instructors[i]);
}
// instructors[i] in a for loop is the same as the var instructor in a foreach loop

// Dictionaries
// collections of key value pairs
// keys - how we access elements
//values - the values we get in return

var weather = new Dictionary<string, float>();
weather["Atlanta"] = 82.3f; // Key -> Atlanta value -> 82.3f
weather["Cleveland"] = 71f;
Console.WriteLine(weather["Atlanta"]); // accessing the value at "atlanta'

Console.WriteLine(weather.Count);

// report is a keyvaluepair object, meaning we have access to both the keys and values as we go through wach item in our weather dictionary 
foreach (var report in weather)
{
    Console.WriteLine("City " + report.Key);
}
foreach (var report in weather)
{
    Console.WriteLine("Temp " + report.Value);
}
foreach (var report in weather)
{
    Console.WriteLine("city & Temp " + report);
}






