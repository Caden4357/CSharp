// Create an integer array with the values 0 through 9 inside.
int[] numArray2 = {0,1,2,3,4,5,6,7,8,9};
// Create a string array with the names "Tim", "Martin", "Nikki", and "Sara".
string[] names = {"Tim", "Martin", "Nikki", "Sara"};
// Create a boolean array of length 10. Then fill it with alternating true/false values, starting with true. (Tip: do this using logic! Do not hard-code the values in!)
bool[] boolArray = new bool[10];
for(int i = 0; i < boolArray.Length; i++)
{
    if(i % 2 == 0)
    {
        boolArray[i] = true;
    }
    else
    {
        boolArray[i] = false;
    }
}
// Create a string List of ice cream flavors that holds at least 5 different flavors. (Feel free to add more than 5!)
List<string> iceCream = new List<string>();
iceCream.Add("Vanilla");
iceCream.Add("Chocolate");
iceCream.Add("Strawberry");
iceCream.Add("Mint");
iceCream.Add("Rocky Road");
// Output the length of this list after building it
Console.WriteLine(iceCream.Count);
// Output the third flavor in the list, then remove this value.
Console.WriteLine(iceCream[2]);
iceCream.RemoveAt(2);
// Output the new length of the list (It should just be one fewer!)
Console.WriteLine(iceCream.Count);
// User Info Dictionary
// Create a dictionary that will store both string keys as well as string values
Dictionary<string,string> user = new Dictionary<string,string>();
// Add key/value pairs to the dictionary where:
// Each key is a name from your names array (this can be done by hand or using logic
// Each value is a randomly selected flavor from your flavors List (remember Random from earlier?)
Random rand = new Random();
foreach(string name in names)
{
    user[name] = iceCream[rand.Next(0,iceCream.Count)];
}
// Loop through the dictionary and print out each user's name and their associated ice cream flavor
foreach(KeyValuePair<string,string> entry in user)
{
    Console.WriteLine(entry.Key + " - " + entry.Value);
}
// Output the length of the dictionary
Console.WriteLine(user.Count);
