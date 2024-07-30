// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Variable to interpolate
string place = "Coding Dojo";
// Interpolated string, note the $
Console.WriteLine($"Hello {place}");
// Another option uses placeholders like so
// Note this does NOT have a $ at the start
Console.WriteLine("Hello {0}", place);

// Integers, which you may know as whole numbers like 1, 17, and 42
int age = 32;
// Doubles, which you may know as decimals like 3.14159 or 9.99
double height = 1.875;
// Booleans, true or false variables
bool blueEyed = true;

// Declare a variable called temperature that holds an integer
// Note: temperature reading is assumed to be in fahrenheit
int temperature = 75;
if(temperature >= 72)
{
    Console.WriteLine("It's a beautiful day to go outside!");
} else {
    Console.WriteLine("Maybe I'll stay inside today.");
}

temperature = 68;
if(temperature >= 72)
{
    // This executes if the temperature is greater than or equal to 72
    Console.WriteLine("It's a beautiful day to go outside!");
} else if(temperature > 64) {
    // This executes only if the temperature was NOT greater than or equal to 72 and IS above 64
    Console.WriteLine("I think it should be fine to go outside today with a light jacket.");    
} else {
    // If neither of the above conditions are met, we run the else statement
    Console.WriteLine("Maybe I'll stay inside today.");
}

for(int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}
Random rand = new Random();
for(int i = 1; i <= 10; i++){
    // Every time the loop executes we will get a NEW random value between 2 and 7
    Console.WriteLine(rand.Next(2,8));
}
// Arrays
// Declaring an array of length 5, initialized by default to all zeroes
int[] numArray = new int[5];
// Declaring an array with pre-populated values
// For arrays initialized this way, the length is determined by the size of the given data
int[] numArray2 = {1,2,3,4,6};
int[] array3; // Declared without initializing a size
array3 = new int[] {1,3,5,7,9}; // We can now fill the array by using the new operator
int[] arrayOfInts = {1, 6, 19, 2, 8};
Console.WriteLine(arrayOfInts[0]);    // The first number (1) lives at index 0.
Console.WriteLine(arrayOfInts[1]);    // The second number (6) lives at index 1.
Console.WriteLine(arrayOfInts[2]);    // The third number (18) lives at index 2.
Console.WriteLine(arrayOfInts[3]);    // The fourth number (2) lives at index 3.
Console.WriteLine(arrayOfInts[4]);    // The fifth and final number (8) lives at index 4.
int[] arr = {1, 2, 3, 4};
Console.WriteLine($"The first number of the arr is {arr[0]}"); 
arr[0] = 8;
Console.WriteLine($"The first number of the arr is now {arr[0]}");
// The array has now changed!
string[] myCars = new string[] { "Mazda Miata", "Ford Model T", "Dodge Challenger", "Nissan 300zx" };
// The 'Length' property tells us how many values are in the array (4 in our example here). 
// We can use this to determine where the loop ends
for (int idx = 0; idx < myCars.Length; idx++)
{
    Console.WriteLine($"I own a {myCars[idx]}");
}
// We can also use the 'foreach' keyword to iterate through each item in the array
foreach (string car in myCars)
{
    // We no longer need the index, because variable 'car' already represents each indexed value
    Console.WriteLine($"I own a {car}");
}
// Initializing an empty list of Motorcycle Manufacturers that expects string values
List<string> bikes = new List<string>();
// Use the Add function in a similar fashion to push
bikes.Add("Kawasaki");
bikes.Add("Triumph");
bikes.Add("BMW");
bikes.Add("Moto Guzzi");
bikes.Add("Harley Davidson");
bikes.Add("Suzuki");
// Accessing a generic list value is the same as an array
Console.WriteLine(bikes[2]); //Prints "BMW", remember we start at 0!
// To get the size of a List, we use Count instead of Length
Console.WriteLine($"We currently know of {bikes.Count} motorcycle manufacturers.");

// Using our list of motorcycle manufacturers from before
// we can easily loop through the list of them with a for loop
// this time, however, Count is the attribute for a number of items.
Console.WriteLine("The current manufacturers we have seen are:");
for (int idx = 0; idx < bikes.Count; idx++)
{
    Console.WriteLine("-" + bikes[idx]);
}
// Insert a new item between a specific index
bikes.Insert(2, "Yamaha");
// Removal from List
// Remove is a lot like Javascript array pop, but searches for a specified value
bikes.Remove("Suzuki");
bikes.Remove("Yamaha");
// We can also remove from a specific index
bikes.RemoveAt(0); 
// RemoveAt has no return value however, so we cannot get back what we removed
// The updated list can then be iterated through using a foreach loop
Console.WriteLine("List of Non-Japanese Manufacturers:");
foreach (string manu in bikes)
{
    Console.WriteLine("-" + manu);
}

Dictionary<string,string> profile = new Dictionary<string,string>();
// We add values to our dictionary the same way we add in Lists
// But remember to specify the key AND value
// When we add, we first specify the key, then the value
profile.Add("Name", "Sandra");
profile.Add("Language", "C#");
profile.Add("Location", "England");
// Now we can render the data like so
Console.WriteLine("Student profile");
// Notice how we use ["KeyName"] to pull the value out
Console.WriteLine("Name - " + profile["Name"]);
Console.WriteLine("From - " + profile["Location"]);
Console.WriteLine("Favorite Language - " + profile["Language"]);
foreach(KeyValuePair<string,string> entry in profile)
{
    Console.WriteLine($"{entry.Key} - {entry.Value}");
}


// FUNCTIONS
// static void SayHello()
// {
//     Console.WriteLine("Hello how are you doing today?");
// }
// SayHello();

// static void SayHello(string firstName = "buddy")
// {
//     Console.WriteLine($"Hey, {firstName}");
// }
// // We can call it without providing any arguments and the default value will be used...
// SayHello();
// // ...or we can call it with an argument and that argument's value will be used
// SayHello("Yoda");

static string SayHello(string firstName = "buddy")
{
    return $"Hey {firstName}";
}
string greeting;
greeting = SayHello();
string greeting2 = SayHello("Sally");

Console.WriteLine(greeting);
Console.WriteLine(greeting2);


// Type Casting 

// Implicit Casting
int num = 123123;
double bigNum = num;
Console.WriteLine(bigNum); // 123123

// Explicit Casting
double myDouble = 1234.7;
int myInt;
// Cast double to int
myInt = (int)myDouble; // Just like Java, this will truncate the decimal
Console.WriteLine(myInt); // 1234